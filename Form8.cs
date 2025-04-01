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
    public partial class Form8 : Form
    {
        BDTableAdapters.DescuentosTableAdapter descuentos = new BDTableAdapters.DescuentosTableAdapter();
        private bool vald;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            BD.DescuentosDataTable descuentosRows = descuentos.GetDataDescuentos();
            DGV_DESCUENTOS.DataSource = descuentosRows;
        }

        private void IngresarMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBOX_FIJO.Checked)
                {
                    vald = true;
                }
                else if (CBOX_VARIANTE.Checked)
                {
                    vald = false;
                }
                if (TXT_CONCEPT.Text == "" || TXT_MONTO.Text == "" || !CBOX_VARIANTE.Checked || !CBOX_FIJO.Checked)
                {
                    descuentos.InsertarDescuentos(TXT_CONCEPT.Text.Trim().ToString(), float.Parse(TXT_MONTO.Text.Trim()), vald, DTP_INICIO.Value, DTP_FIN.Value);
                    MessageBox.Show("Descuento aprobado");
                    Limpiar();
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Llene todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            TXT_CONCEPT.Clear();
            TXT_MONTO.Clear();
            CBOX_FIJO.ResetText();
            CBOX_VARIANTE.ResetText();
            DTP_FIN.ResetText();
            DTP_INICIO.ResetText();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
        }
    }
}
