using PuntoDeVenta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PuntoDeVenta.UserControls
{
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
            SetActivePanel(nuevoProducto1);
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            SetActivePanel(nuevoProducto1);
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            //SetActivePanel(etiquetaControl1);
            //Form2 testDialog = new Form2();

            //// Show testDialog as a modal dialog and determine if DialogResult = OK.
            //if (testDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    // Read the contents of testDialog's TextBox.
            //    this.txtResult.Text = testDialog.TextBox1.Text;
            //}
            //else
            //{
            //    this.txtResult.Text = "Cancelled";
            //}
            //testDialog.Dispose();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {

        }

        private void btnVentasPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {

        }

        public void SetActivePanel(UserControl control)
        {
            etiquetaControl1.Visible = false;
            nuevoProducto1.Visible = false;


            control.Visible = true;
        }
    }
}
