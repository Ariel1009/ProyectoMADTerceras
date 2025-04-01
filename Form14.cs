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
    public partial class Form14 : Form
    {
        BDTableAdapters.ShowDeptoTableAdapter deptos = new BDTableAdapters.ShowDeptoTableAdapter();
        BDTableAdapters.ReporteInventarioTableAdapter reporteInventario = new BDTableAdapters.ReporteInventarioTableAdapter();
        private int merma;
        private bool agotados;
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            LlenarComboDeptos();
            try
            {
                BD.ReporteInventarioDataTable inventarioRows = reporteInventario.GetDataReporteInventario(null, null, null, null);
                DGV_REPORTEINVENTARIO.DataSource = inventarioRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LlenarComboDeptos()
        {
            try
            {
                BD.ShowDeptoDataTable showDeptos = deptos.GetDataDeptos();
                List<string> departamentos = showDeptos.AsEnumerable().Select(x => x[0].ToString()).ToList();
                CB_DEPTOS.DataSource = departamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CB_DEPTOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BD.ReporteInventarioDataTable inventarioRows = reporteInventario.GetDataReporteInventario(CB_DEPTOS.SelectedIndex + 1, null, null,null);
                DGV_REPORTEINVENTARIO.DataSource = inventarioRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CBOX_MERMA_CheckedChanged(object sender, EventArgs e)
        {
            if (CBOX_MERMA.Checked)
            {
                merma = 1;
            }
            else if(!CBOX_MERMA.Checked)
            {
                merma = 1;
            }
            try
            {
                BD.ReporteInventarioDataTable inventarioRows = reporteInventario.GetDataReporteInventario(null, null, null, merma);
                DGV_REPORTEINVENTARIO.DataSource = inventarioRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CBOX_AGOTADOS_CheckedChanged(object sender, EventArgs e)
        {
            if (CBOX_MERMA.Checked)
            {
                agotados = true;
            }
            else if (!CBOX_MERMA.Checked)
            {
                agotados = false;
            }
            try
            {
                BD.ReporteInventarioDataTable inventarioRows = reporteInventario.GetDataReporteInventario(null, null, agotados, null);
                DGV_REPORTEINVENTARIO.DataSource = inventarioRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXT_EXMINIMA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BD.ReporteInventarioDataTable inventarioRows = reporteInventario.GetDataReporteInventario(null, int.Parse(TXT_EXMINIMA.Text.Trim()), null, null);
                DGV_REPORTEINVENTARIO.DataSource = inventarioRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }
    }
}
