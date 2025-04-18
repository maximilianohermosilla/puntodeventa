namespace PuntoDeVenta
{
    public partial class ToastForm : Form
    {
        const string SUCCESS = "SUCCESS";
        const string ERROR = "ERROR";
        const string WARNING = "WARNING";
        const string INFO = "INFO";

        public int toastX, toastY;
        public int y = 100;

        public ToastForm(string type, string message)
        {
            InitializeComponent();

            labelToastMessage.Text = message;

            switch (type)
            {
                case SUCCESS:
                    labelToastTitle.Text = "Confirmación";
                    panelToastBorder.BackColor = Color.FromArgb(57, 155, 53);
                    pictureToastIcon.Image = Properties.Resources.check_ok;
                    break;
                case ERROR:
                    labelToastTitle.Text = "Error";
                    panelToastBorder.BackColor = Color.FromArgb(227, 50, 45);
                    pictureToastIcon.Image = Properties.Resources.cancel;
                    break;
                case WARNING:
                    labelToastTitle.Text = "Advertencia";
                    panelToastBorder.BackColor = Color.FromArgb(245, 171, 35);
                    pictureToastIcon.Image = Properties.Resources.warning;
                    break;
                case INFO:
                    labelToastTitle.Text = "Información";
                    panelToastBorder.BackColor = Color.FromArgb(18, 136, 191);
                    pictureToastIcon.Image = Properties.Resources.help;
                    break;
                default:
                    break;
            }
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 10;
            toastY = ScreenHeight - this.Height + 10;

            this.Location = new Point(toastX, toastY);
        }

        private void timerToast_Tick(object sender, EventArgs e)
        {
            toastY -= 30;
            this.Location = new Point(toastX, toastY);
            if (toastY < 125)
            {
                timerToast.Stop();
                toastHide.Start();
            }
        }

        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 10;
                this.Location = new Point(toastX, toastY += 20);

                if(toastY > Screen.PrimaryScreen.WorkingArea.Height - 300)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }
    }
}
