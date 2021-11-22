using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HotelManagement.UI.Components
{
    [DefaultEvent("_TextChanged")]
    public partial class TextBox : UserControl
    {
        private Color _borderColor = Color.BlueViolet;
        private Color _focusColor = Color.Aqua;
        private Color _placeHolderColor = Color.WhiteSmoke;
        private int _borderSize = 2;
        private int _borderRadius;
        private bool _isFocused;
        private bool _isPlaceHolder;
        private bool _isError;
        private bool _underline;
        private string _placeHolder;
        private string _errorMessage;
        private string _temp;

        public event EventHandler _TextChanged;

        public TextBox() => InitializeComponent();

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (_borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -_borderSize, -_borderSize);
                int smoothSize = _borderSize > 0 ? _borderSize : 1;

                using var pathBorderSmooth = GetFigurePath(rectBorderSmooth, _borderRadius);
                using var pathBorder = GetFigurePath(rectBorder, _borderRadius - _borderSize);
                using var penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize);
                using var penBorder = new Pen(_borderColor, _borderSize);
                //-Drawing
                this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                if (_borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                if (_isFocused) penBorder.Color = _focusColor;

                if (_underline) //Line Style
                {
                    //Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graph.SmoothingMode = SmoothingMode.None;
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else //Normal Style
                {
                    //Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using var penBorder = new Pen(_borderColor, _borderSize);
                this.Region = new Region(this.ClientRectangle);
                penBorder.Alignment = PenAlignment.Inset;
                if (_isFocused) penBorder.Color = _focusColor;

                if (_underline) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else //Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, _borderRadius - _borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, _borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }

        public Color BorderColor
        {
            get => _borderColor;
            set => _borderColor = value;
        }

        public Color FocusedColor
        {
            get => _focusColor;
            set => _focusColor = value;
        }

        public bool Underline
        {
            get => _underline;
            set => _underline = value;
        }

        public Color Background
        {
            get => this.textBox1.BackColor;
            set => this.textBox1.BackColor = value;
        }

        public bool Password
        {
            get => textBox1.UseSystemPasswordChar;
            set => textBox1.UseSystemPasswordChar = value;
        }

        public bool Multiline
        {
            get => textBox1.Multiline;
            set
            {
                textBox1.Multiline = value;
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

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        public string PlaceHolder
        {
            get => _placeHolder;
            set
            {
                _placeHolder = value;
                textBox1.Text = string.Empty;
                SetPlaceholder();
            }
        }

        public override string Text
        {
            get
            {
                if (textBox1.Text == _placeHolder || textBox1.Text == ErrorMessage)
                    return "";
                return textBox1.Text;
            }
            set => textBox1.Text = value;
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                //SetPlaceholder();
            }
        }

        public Color PlaceHolderColor
        {
            get => _placeHolderColor;
            set => _placeHolderColor = value;
        }

        public bool IsError
        {
            get => _isError;
            set
            {
                _isError = value;
                SetErrorMessage();
            }
        }

        private void SetErrorMessage()
        {
            if (IsError)
            {
                _placeHolder = ErrorMessage;
                _temp = _placeHolder;
                textBox1.Text = _placeHolder;
                textBox1.ForeColor = _placeHolderColor;
            }
        }

        private void SetPlaceholder()
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) || _placeHolder == "") return;
            _isPlaceHolder = true;
            textBox1.Text =  _placeHolder;
            textBox1.ForeColor = _placeHolderColor;
        }
        private void RemovePlaceholder()
        {
            if (_isPlaceHolder && _placeHolder != "" && textBox1.Text == PlaceHolder)
            {
                _isPlaceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
            RemovePlaceholder();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
            SetPlaceholder();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
            RemovePlaceholder();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            _isFocused = true;
            RemovePlaceholder();
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            _isFocused = false;
            SetPlaceholder();
            this.Invalidate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
    }
}