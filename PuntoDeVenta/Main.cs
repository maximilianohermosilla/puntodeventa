using Microsoft.Extensions.DependencyInjection;
using PuntoDeVenta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void btnVentas_Click(object sender, EventArgs e)
        {
            SetActivePanel(ventas1);
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            SetActivePanel(creditos1);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            SetActivePanel(productos1);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            SetActivePanel(inventario1);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SetActivePanel(clientes1);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            SetActivePanel(compras1);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            SetActivePanel(configuracion1);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            SetActivePanel(facturas1);
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            SetActivePanel(corte1);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SetActivePanel(reportes1);
        }

        public void SetActivePanel(UserControl control)
        {
            ventas1.Visible = false;
            reportes1.Visible = false;
            productos1.Visible = false;
            inventario1.Visible = false;
            facturas1.Visible = false;
            creditos1.Visible = false;
            corte1.Visible = false;
            configuracion1.Visible = false;
            compras1.Visible = false;
            clientes1.Visible = false;

            control.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void panelNavbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
