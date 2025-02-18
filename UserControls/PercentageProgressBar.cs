using System.ComponentModel;
using System.Drawing.Text;

namespace Coursework.UserControls
{
    public partial class PercentageProgressBar : ProgressBar
    {
        [Category("Appearance")] // groups the property into the Apperance category within the designer.
        public Color TextColour // This property will be used to change the colour of the text, the american spelling is used to align with the standard in the designer for easier readability
        {
            get
            {
                return solidBrushText.Color; // gets the colour of the SolidBrush used for drawing text
            }
            set
            {
                solidBrushText.Dispose(); // disposes of old brush  to prevent leaks
                solidBrushText = new(value); // creates a new SolidBrush with the new colour
            }
        }

        [Category("Appearance")]
        public Color ProgressColour // this gets the colour property of the SolidBrush used for drawing
        {
            get
            {
                return solidBrushProgress.Color;
            }
            set
            {
                solidBrushProgress.Dispose();
                solidBrushProgress = new(value);
            }
        }

        [Category("Appearance")]
        public bool UsePercentage { get; set; }

        [Category("Appearance"), Browsable(true)]
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

        private float PercentageProgress
        {
            get
            {
                return (float)Value / (float)Maximum * 100;
            }
        }

        private SolidBrush solidBrushText = (SolidBrush)Brushes.DarkGreen;
        private SolidBrush solidBrushProgress = (SolidBrush)Brushes.Green;
        private RectangleF barProgress;
        public PercentageProgressBar()
        {
            Style = ProgressBarStyle.Continuous;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true); // Removes the automatic VisualStyles which would overwrite the custom OnPaint
            InitializeComponent();
            this.Text = "PERCENTAGE"; // ensures text value is not empty so the font is correctly applied as 'Build'. Without this line, the 'Secondary' font would be used, which is not meant to be utilised on numbers.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle barBackground = ClientRectangle;

            e.Graphics.Clear(BackColor);

            if (Value > 0)
            {
                barProgress = new(barBackground.X, barBackground.Y, (int)Math.Ceiling(PercentageProgress / 100 * barBackground.Width), barBackground.Height);
                e.Graphics.FillRectangle(solidBrushProgress, barProgress);
            }

            if (UsePercentage) // this will check if the progress bar will display the percentage completed, this allows me to use this as a progress bar with a custom back colour and progress bar colour
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias; // anti aliases text to remove jagged edges and artifacting
                
                // fix or else

                e.Graphics.DrawString(((int)PercentageProgress).ToString(), Font, solidBrushText, new PointF((Width - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Width - 10 * Font.Size / 10), (Height - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Height) / 2)); 
                e.Graphics.DrawString("%", Font, solidBrushText, new PointF((Width - e.Graphics.MeasureString("%", Font).Width) - 1, (Height - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Height) / 2));

                if (barProgress.IntersectsWith(new Rectangle(new Point((int)(Width - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Width - 10 * Font.Size / 5), (int)(Height - e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Height) / 2 + 5), new Size((int)e.Graphics.MeasureString(((int)PercentageProgress).ToString(), Font).Width, Font.Height))))
                {
                    TextColour = this.BackColor;
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);  
            this.Invalidate();
        }
    }
}