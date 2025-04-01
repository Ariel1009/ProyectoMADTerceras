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
using System.Drawing.Printing;

namespace ProyectoMADTerceras
{
    public partial class Form17 : Form
    {
        BDTableAdapters.BusquedaDevTableAdapter busquedaDev = new BDTableAdapters.BusquedaDevTableAdapter();
        BDTableAdapters.Devolucion_inerTableAdapter devolucion_Iner = new BDTableAdapters.Devolucion_inerTableAdapter();
        BDTableAdapters.Devolucion_productsTableAdapter devolucion_Products = new BDTableAdapters.Devolucion_productsTableAdapter();
        BDTableAdapters.RecuperarIdDevolucionTableAdapter recuperarIdDEV = new BDTableAdapters.RecuperarIdDevolucionTableAdapter();
        BDTableAdapters.MostrarNotaCreditoTableAdapter mostrarNota = new BDTableAdapters.MostrarNotaCreditoTableAdapter();
        BDTableAdapters.guardarUbicacionDevolucionTableAdapter guardarUbicacion = new BDTableAdapters.guardarUbicacionDevolucionTableAdapter();
        private bool integridad;
        private bool vald = false;
        Process proceso = new Process();
        public Form17()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            this.Hide();
            form15.ShowDialog();
        }

        private void TXT_VENTA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BD.BusquedaDevDataTable busquedaDevRows = busquedaDev.GetDataProductDev(int.Parse(TXT_VENTA.Text.Trim()));
                DGV_DEVPROC.DataSource = busquedaDevRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Aux_id = (int)DGV_DEVPROC.CurrentRow.Cells[0].Value;
            try
            {
                if (CBOX_BUENA.Checked)
                {
                    integridad = true;
                }
                else if (CBOX_MALA.Checked)
                {
                    integridad = false;
                }
                else
                {
                    vald = true;
                    MessageBox.Show("Por favor selecione uno de los dos");
                }

                if (!vald)
                {
                    devolucion_Iner.GetDataDevolucion(TXT_MOTIVO.Text.Trim().ToString(), integridad, int.Parse(TXT_VENTA.Text.Trim()), Aux_id, int.Parse(TXT_CANTDEV.Text.Trim()));

                    devolucion_Products.GetDataDevProcd(int.Parse(TXT_CANTDEV.Text.Trim()), Aux_id, VariablesCom.user_id);
                    MessageBox.Show("Devolucion hecha");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void notaDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BD.RecuperarIdDevolucionDataTable idDevolucionRows = recuperarIdDEV.GetDataRecuperarIdDev();
            BD.RecuperarIdDevolucionRow devolucionRow = (BD.RecuperarIdDevolucionRow)idDevolucionRows.Rows[0];
            int Aux_id = devolucionRow.Column1;

            //C:\Users\ofeli\source\repos\ProyectoMADTerceras\NotasCredito
            BD.MostrarNotaCreditoDataTable mostrarNotaCreditoRows = mostrarNota.GetData(Aux_id);
            BD.MostrarNotaCreditoRow creditoRow = (BD.MostrarNotaCreditoRow)mostrarNotaCreditoRows.Rows[0];

            //crear pdf
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += imprimir;
            printDocument1.Print();

            int ticket = creditoRow.NotaCredito;
            string rutaGuardado = @"C:\Users\ofeli\source\repos\ProyectoMADTerceras\NotasCredito\Nota_de_Credito " + ticket + ".pdf ";
            guardarUbicacion.GetDataUbicacionDev(ticket, rutaGuardado);


            proceso.StartInfo.FileName = @"C:\Users\ofeli\source\repos\ProyectoMADTerceras\NotasCredito\Nota_de_Credito " + ticket + ".pdf ";
            proceso.Start();
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {

            BD.RecuperarIdDevolucionDataTable idDevolucionRows = recuperarIdDEV.GetDataRecuperarIdDev();
            BD.RecuperarIdDevolucionRow devolucionRow = (BD.RecuperarIdDevolucionRow)idDevolucionRows.Rows[0];
            int Aux_id = devolucionRow.Column1;

            //C:\Users\ofeli\source\repos\ProyectoMADTerceras\NotasCredito
            BD.MostrarNotaCreditoDataTable mostrarNotaCreditoRows = mostrarNota.GetData(Aux_id);
            BD.MostrarNotaCreditoRow creditoRow = (BD.MostrarNotaCreditoRow)mostrarNotaCreditoRows.Rows[0];

            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int width = 1600;
            int y = 20;

            e.Graphics.DrawString("Nota de Credito: " + creditoRow.NotaCredito.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Motivo de la devolucion: " + creditoRow.motivo.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Producto: " + creditoRow.Producto.ToString() + "     Precio: $" + creditoRow.Precio.ToString() + "     Cantidad: " + creditoRow.cantidad.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Subtotal: $" + creditoRow.nuevo_Subtotal.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Total: $" + creditoRow.nuevoTotal.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));

        }
    }
}
