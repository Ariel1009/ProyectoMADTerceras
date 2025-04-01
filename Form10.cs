using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoMADTerceras
{
    public partial class Form10 : Form
    {
        BDTableAdapters.busquedaDosVentaTableAdapter busquedaDos = new BDTableAdapters.busquedaDosVentaTableAdapter();
        BDTableAdapters.productosTicketsTableAdapter productosTickets = new BDTableAdapters.productosTicketsTableAdapter();
        BDTableAdapters.consultarTicketTableAdapter consultarTicket = new BDTableAdapters.consultarTicketTableAdapter();
        Process proceso = new Process();
        public Form10()
        {
            InitializeComponent();
        }

        private void CB_NUMCAJA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BD.busquedaDosVentaDataTable busquedaDosVentas = busquedaDos.GetDataBusquedaDos(null, null, CB_NUMCAJA.SelectedIndex + 1);
                DGV_VENTAS.DataSource = busquedaDosVentas;
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
                BD.busquedaDosVentaDataTable busquedaDosVentas = busquedaDos.GetDataBusquedaDos(DTP_INICIO.Value, DTP_FIN.Value, null);
                DGV_VENTAS.DataSource = busquedaDosVentas;
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
                BD.busquedaDosVentaDataTable busquedaDosVentas = busquedaDos.GetDataBusquedaDos(DTP_INICIO.Value, DTP_FIN.Value, null);
                DGV_VENTAS.DataSource = busquedaDosVentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXT_VENTA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BD.productosTicketsDataTable productosTicketsRows = productosTickets.GetDataProductosTicket(int.Parse(TXT_VENTA.Text.Trim()));
                DGV_VENTAS.DataSource = productosTicketsRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DGV_VENTAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LBL_SUBTOTAL.Text = DGV_VENTAS.CurrentRow.Cells[4].Value.ToString();
                LBL_TOTAL.Text = DGV_VENTAS.CurrentRow.Cells[3].Value.ToString();
                TXT_FECHA.Text = DGV_VENTAS.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                LBL_SUBTOTAL.Text = "0.00";
                LBL_TOTAL.Text = "0.00";
                TXT_FECHA.Clear();
            }

        }

        private void BackMenuItem_Click(object sender, EventArgs e)
        {
            if (VariablesCom.tipo)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();
            }
            else
            {
                Form15 form15 = new Form15();
                this.Hide();
                form15.ShowDialog();
            }
            
        }

        private void reciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int Aux_id = int.Parse(TXT_VENTA.Text.Trim());
                BD.consultarTicketDataTable consultarTicketRows = consultarTicket.GetDataTicket(Aux_id);
                BD.consultarTicketRow ticketRow = (BD.consultarTicketRow)consultarTicketRows.Rows[0];

                proceso.StartInfo.FileName = @"" + ticketRow.ubicacion + "";
                proceso.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                BD.busquedaDosVentaDataTable busquedaDosVentas = busquedaDos.GetDataBusquedaDos(null, null, null);
                DGV_VENTAS.DataSource = busquedaDosVentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
