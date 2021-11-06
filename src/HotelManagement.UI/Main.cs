using System.Windows.Forms;
using HotelManagement.UI.Components;


namespace HotelManagement.UI
{
    public partial class Main : Form
    {
        private CustomButton _current = new();
        private Form _activeForm;

        public Main()
        {
            InitializeComponent();
        }

        public void SetColor(object sender)
        {
            SetDefaultColor();
            if (sender is null) return;
            if (_current == (CustomButton) sender) return;
            _current = (CustomButton) sender;
            _current.BackColor = ColorScheme.Blue;
        }

        private void SetDefaultColor()
        {
            foreach (Control control in sidebar.Controls)
            {
                if (control.GetType() == typeof(CustomButton))
                {
                    control.BackColor = ColorScheme.DarkBlue;
                }
            }
        }

        private void OpenForm(Form form, object sender)
        {
            _activeForm?.Close();

            SetColor(sender);

            _activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(form);
            PanelMain.Tag = form;
            form.BringToFront();
            form.Show();
            LblTittle.Text = form.Text;
        }
    }
}
