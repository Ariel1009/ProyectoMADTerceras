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
    public partial class Form12 : Form
    {
        BDTableAdapters.AllUsuariosTableAdapter allUsuarios = new BDTableAdapters.AllUsuariosTableAdapter();
        BDTableAdapters.ShowDeptoTableAdapter deptos = new BDTableAdapters.ShowDeptoTableAdapter();
        BDTableAdapters.ReporteCajeroTableAdapter reporteCajero = new BDTableAdapters.ReporteCajeroTableAdapter();
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            LlenarComboDeptos();
            LlenarComboUsers();
            try
            {
                try
                {
                    BD.ReporteCajeroDataTable cajeroRows = reporteCajero.GetDataReporteCajero(null, null, null, null);
                    DGV_REPORTECAJERO.DataSource = cajeroRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
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

        private void LlenarComboUsers()
        {
            try
            {
                BD.AllUsuariosDataTable allUsuariosRows = allUsuarios.GetDataAllUsers();
                List<string> Usuarios = allUsuariosRows.AsEnumerable().Select(x => x[0].ToString()).ToList();
                CB_USERS.DataSource = Usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CB_USERS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BD.ReporteCajeroDataTable cajeroRows = reporteCajero.GetDataReporteCajero(null, null,CB_USERS.SelectedIndex + 1, null);
                DGV_REPORTECAJERO.DataSource = cajeroRows;
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
                BD.ReporteCajeroDataTable cajeroRows = reporteCajero.GetDataReporteCajero(null, null, null, CB_DEPTOS.SelectedIndex + 1);
                DGV_REPORTECAJERO.DataSource = cajeroRows;
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
                BD.ReporteCajeroDataTable cajeroRows = reporteCajero.GetDataReporteCajero(DTP_INICIO.Value, DTP_FIN.Value, null, null);
                DGV_REPORTECAJERO.DataSource = cajeroRows;
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
                BD.ReporteCajeroDataTable cajeroRows = reporteCajero.GetDataReporteCajero(DTP_INICIO.Value, DTP_FIN.Value, null, null);
                DGV_REPORTECAJERO.DataSource = cajeroRows;
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
