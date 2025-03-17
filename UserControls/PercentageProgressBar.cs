using System.ComponentModel;
using System.Drawing.Text;

namespace Coursework.UserControls
{
    public partial class PercentageProgressBar : ProgressBar
    {
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TextColour 
        {
            get
            {
                // Gets the colour of the SolidBrush used for drawing text
                return solidBrushText.Color; 
            }
            set
            {
                // Creates a new SolidBrush with the new colour to draw the text
                solidBrushText.Dispose();
                solidBrushText = new(value); 
            }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ProgressColour 
        {
            get
            {
                return solidBrushProgress.Color;
            }
            set
            {
                // Creates a new SolidBrush with the new colour to draw the progress
                solidBrushProgress.Dispose();
                solidBrushProgress = new(value);
            }
        }

        // Dictates whether the progress bar will display its percentage.
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool UsePercentage { get; set; }

        // Allows changing of the percentage font.
        [Category("Appearance"), Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                Invalidate();
            }
        }

        // Holds the percentage of the progress bar which has been filled.
        private float PercentageProgress
        {
            get
            {
                return ((float)Value * 100) / (float)Maximum;
            }
        }

        private SolidBrush solidBrushText = (SolidBrush)Brushes.DarkGreen;
        private SolidBrush solidBrushProgress = (SolidBrush)Brushes.Green;
        private RectangleF barProgress;
        public PercentageProgressBar()
        {
            // Sets style to be Continuous by default.
            Style = ProgressBarStyle.Continuous;

            // Sets the UserPaint bit to allow the control to handle painting rather than the OS. The AllPaintingInWmPaint bit is also set to reduce flicker by ignoring a message from the OS. Also sets DoubleBuffer to reduce flickering.
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            // Ensures text value is not empty so the font is correctly applied as 'Build'. Without this line, the 'Secondary' font would be used, which is not meant to be utilised on numbers.
            this.Text = "PERCENTAGE";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Calls the base OnPaint method.
            base.OnPaint(e);

            // Creates the Background as the ClientRectangle (the parts of the control which are visible)
            Rectangle barBackground = ClientRectangle;

            // Fills background colour.
            e.Graphics.Clear(BackColor);

            // Draws the progress bar as it fills.
            if (Value > 0)
            {
                barProgress = new(barBackground.X, barBackground.Y, (int)Math.Ceiling(PercentageProgress / 100 * barBackground.Width), barBackground.Height);
                e.Graphics.FillRectangle(solidBrushProgress, barProgress);
            }

            // Checks if the percentage is to be displayed on the ProgressBar.
            if (UsePercentage)
            {
                // Anti aliases text to remove jagged edges and artifacting
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                
                // Draws the percentage and percentage symbol seperately to provide spacing.
                e.Graphics.DrawString(((int)PercentageProgress).ToString(), Font, solidBrushText, new PointF((Width - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Width - 10 * Font.Size / 10), (Height - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Height) / 2)); 
                e.Graphics.DrawString("%", Font, solidBrushText, new PointF((Width - e.Graphics.MeasureString("%", Font).Width) - 1, (Height - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Height) / 2));

                // Checks if the progress bar has intersected with the text. If it has, the colour of the text will to the background colour change to ensure it remains legible.
                if (barProgress.IntersectsWith(new Rectangle(new Point((int)(Width - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Width - 10 * Font.Size / 5), (int)(Height - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Height) / 2 + 5), new Size((int)e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Width, Font.Height))))
                {
                    TextColour = this.BackColor;
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            // Redraws the control when it is resized.
            base.OnResize(e);  
            this.Invalidate();
        }
    }
}