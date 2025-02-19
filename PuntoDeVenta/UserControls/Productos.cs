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
            SetActivePanel(null);
            EtiquetaDialog etiquetaDialog = new EtiquetaDialog();
            etiquetaDialog.labelProducto.Text = "Modificar Producto";

            if (etiquetaDialog.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show(etiquetaDialog.txtEtiqueta.Text);
            }
            etiquetaDialog.Dispose();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            SetActivePanel(null);
            EtiquetaDialog etiquetaDialog = new EtiquetaDialog();
            etiquetaDialog.labelProducto.Text = "Eliminar Producto";
            if (etiquetaDialog.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show(etiquetaDialog.txtEtiqueta.Text);
            }
            etiquetaDialog.Dispose();

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

        public void SetActivePanel(UserControl? control)
        {
            nuevoProducto1.Visible = false;


            if (control != null)
            {
                control.Visible = true;
            }
        }
    }
}
