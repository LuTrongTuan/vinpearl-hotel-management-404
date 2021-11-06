using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HotelManagement.UI.Components
{
    public class CustomButton : Button
    {
        //Fields
        private int _borderSize;
        private int _borderRadius;
        private Color _borderColor = Color.PaleVioletRed;

        //Properties
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        public Color TextColor
        {
            get => this.ForeColor;
            set => this.ForeColor = value;
        }

        //Constructor
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.Resize += Button_Resize;
        }

        //Methods

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

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += Container_BackColorChanged;
        }

        private void Container_BackColorChanged(object sender, EventArgs e) => Invalidate();

        private void Button_Resize(object sender, EventArgs e)
        {
            if (_borderRadius > this.Height)
                _borderRadius = this.Height;
        }
    }
}