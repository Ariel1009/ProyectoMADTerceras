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
    public partial class Form13 : Form
    {
        BDTableAdapters.ShowDeptoTableAdapter deptos = new BDTableAdapters.ShowDeptoTableAdapter();
        BDTableAdapters.ReporteVentaTableAdapter reporteVenta = new BDTableAdapters.ReporteVentaTableAdapter();
        public Form13()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            LlenarComboDeptos();
            try
            {
                BD.ReporteVentaDataTable ventaRows = reporteVenta.GetDataReporteVenta(null, null, null, null);
                DGV_REPORTEVENTAS.DataSource = ventaRows;
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

        private void CB_NUMCAJA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BD.ReporteVentaDataTable ventaRows = reporteVenta.GetDataReporteVenta(null, null, CB_NUMCAJA.SelectedIndex + 1,null);
                DGV_REPORTEVENTAS.DataSource = ventaRows;
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
                BD.ReporteVentaDataTable ventaRows = reporteVenta.GetDataReporteVenta(null, null, null, CB_DEPTOS.SelectedIndex + 1);
                DGV_REPORTEVENTAS.DataSource = ventaRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DTP_INICIO_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BD.ReporteVentaDataTable ventaRows = reporteVenta.GetDataReporteVenta(DTP_INICIO.Value, DTP_FIN.Value, null, null);
                DGV_REPORTEVENTAS.DataSource = ventaRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DTP_FIN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BD.ReporteVentaDataTable ventaRows = reporteVenta.GetDataReporteVenta(DTP_INICIO.Value, DTP_FIN.Value, null, null);
                DGV_REPORTEVENTAS.DataSource = ventaRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
