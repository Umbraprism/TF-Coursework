using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Coursework.UserControls
{
    public partial class RoundedPanel : Panel
    {
        [Browsable(false)] // done to hide the backcolor proerty so user can not change it  
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackColor { get; set; }       

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color ForeColor { get; set; }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Radius
        {
            get
            {
                return panelRadius;
            }
            set
            {
                if (value <= 180 && value >= 0)
                {
                    panelRadius = value;
                }
                Invalidate();
            }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color PanelColour
        {
            get
            {
                return panelColour;
            }
            set
            {
                panelColour = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColour
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Border Style")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DashStyle Style
        {
            get
            {
                return borderStyle;
            }
            set
            {
                borderStyle = value;
                Invalidate();
            }
        }

        private int panelRadius = 50;
        private int borderSize = 0;
        private Color panelColour = Color.Gainsboro;
        private Color borderColor = Color.White;
        private DashStyle borderStyle = DashStyle.Solid;

        public RoundedPanel()
        {
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath roundedPath = new())
            {
                roundedPath.StartFigure();
                roundedPath.AddArc(ClientRectangle.X, ClientRectangle.Y, Radius, Radius, 180, 90); // top left
                roundedPath.AddArc(ClientRectangle.Width - Radius, ClientRectangle.Y, Radius, Radius, 270, 90); // top right
                roundedPath.AddArc(ClientRectangle.Width - Radius, ClientRectangle.Height - Radius, Radius, Radius, 0, 90); // bottom right
                roundedPath.AddArc(ClientRectangle.X, ClientRectangle.Height - Radius, Radius, Radius, 90, 90); // bottom left
                roundedPath.CloseFigure();

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (Pen borderPen = new(BorderColour, BorderSize))
                using (SolidBrush panelBrush = new(PanelColour))
                {
                    e.Graphics.FillPath(panelBrush, roundedPath);

                    borderPen.Alignment = PenAlignment.Inset;
                    borderPen.DashStyle = Style;

                    e.Graphics.DrawPath(borderPen, roundedPath);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }
}