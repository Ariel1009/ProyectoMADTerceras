using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMADTerceras
{
    public partial class Form15 : Form
    {
        BDTableAdapters.ProductoTableAdapter producto = new BDTableAdapters.ProductoTableAdapter();
        public Form15()
        {
            InitializeComponent();
        }

        private void Actualizar()
        {
            try
            {
                BD.ProductoDataTable productoRows = producto.GetDataProducto();
                DGV_PRODUCTOS.DataSource = productoRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            this.Hide();
            form16.ShowDialog();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            this.Hide();
            form17.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando sesion");
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void consultaDeRecibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
