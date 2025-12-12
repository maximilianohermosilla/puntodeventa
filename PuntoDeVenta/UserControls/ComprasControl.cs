using PuntoDeVenta.Enum;
using PuntoDeVenta.Helpers;
using PuntoDeVenta.UserControls.ComprasControls;

namespace PuntoDeVenta.UserControls
{
    public partial class ComprasControl : UserControl
    {
        public ComprasControl()
        {
            InitializeComponent();
            InitializeControls();
        }

        public void InitializeControls()
        {
            comprasFormControl1 = new ComprasFormControl();

            panelMain.Controls.Add(comprasFormControl1);

            comprasFormControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            comprasFormControl1.Dock = DockStyle.Fill;
            comprasFormControl1.Location = new Point(0, 0);
            comprasFormControl1.Name = "turnoControl1";
            comprasFormControl1.Size = new Size(319, 529);
            comprasFormControl1.TabIndex = 18;

            comprasFormControl1.Visible = true;
            _ = GetUltimoMovimiento();
        }


        private void btnCompras_Click(object sender, EventArgs e)
        {
            comprasFormControl1.Visible = true;
            _ = GetUltimoMovimiento();
        }

        public async Task GetUltimoMovimiento()
        {
            await comprasFormControl1.GetUltimoMovimiento((int)FormaPagoEnum.Efectivo);
            await comprasFormControl1.GetUltimoMovimiento((int)FormaPagoEnum.MercadoPago);
        }


    }
}
