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
    public partial class Form3 : Form
    {
        BDTableAdapters.ProductoTableAdapter producto = new BDTableAdapters.ProductoTableAdapter();
        public Form3()
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

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando sesion");
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            this.Hide();
            form9.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
        }

        private void consultaDeReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            this.Hide();
            form11.ShowDialog();
        }

        private void cajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            this.Hide();
            form12.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            this.Hide();
            form14.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            this.Hide();
            form13.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            this.Hide();
            form18.ShowDialog();
        }

        private void gestionUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }

        private void gestionCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            this.Hide();
            form19.ShowDialog();
        }
    }
}
