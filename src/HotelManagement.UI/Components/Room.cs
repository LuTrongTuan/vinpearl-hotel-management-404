using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HotelManagement.UI.Components
{
    public partial class Room : UserControl
    {
        private Color _borderColor;
        private int _borderSize = 1;
        private int _borderRadius;

        public Room()
        {
            InitializeComponent();
        }

        public string RoomNumber
        {
            get => this.LblRoomName.Text;
            set => this.LblRoomName.Text = value;
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set => _borderRadius = value;
        }

        public int BorderSize
        {
            get => _borderSize;
            set => _borderSize = value;
        }

        public Color BorderColor
        {
            get => _borderColor;
            set => _borderColor = value;
        }

        public Color Background
        {
            get => BackColor;
            set => BackColor = value;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
           

            var rectSurface = this.ClientRectangle;
            var rectBorder = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize);
            var smoothSize = 2;
            if (_borderSize > 0)
                smoothSize = _borderSize;

            if (_borderRadius > 2) //Rounded button
            {
                using var pathSurface = GetFigurePath(rectSurface, _borderRadius);
                using var pathBorder = GetFigurePath(rectBorder, _borderRadius - _borderSize);
                using var penSurface = new Pen(this.Parent.BackColor, smoothSize);
                using var penBorder = new Pen(_borderColor, _borderSize);
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                //Button surface
                this.Region = new Region(pathSurface);
                //Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                //Button border                    
                if (_borderSize >= 1)
                    //Draw control border
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (_borderSize >= 1)
                {
                    using Pen penBorder = new(_borderColor, _borderSize);
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
