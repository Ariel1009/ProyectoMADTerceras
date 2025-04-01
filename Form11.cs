using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoMADTerceras
{
    public partial class Form11 : Form
    {
        BDTableAdapters.BusquedaDevTableAdapter busquedaDev = new BDTableAdapters.BusquedaDevTableAdapter();
        BDTableAdapters.Devolucion_inerTableAdapter devolucion_Iner = new BDTableAdapters.Devolucion_inerTableAdapter();
        BDTableAdapters.Devolucion_productsTableAdapter devolucion_Products = new BDTableAdapters.Devolucion_productsTableAdapter();
        BDTableAdapters.RecuperarIdDevolucionTableAdapter recuperarIdDEV = new BDTableAdapters.RecuperarIdDevolucionTableAdapter();
        BDTableAdapters.MostrarNotaCreditoTableAdapter mostrarNota = new BDTableAdapters.MostrarNotaCreditoTableAdapter();
        BDTableAdapters.guardarUbicacionDevolucionTableAdapter guardarUbicacion = new BDTableAdapters.guardarUbicacionDevolucionTableAdapter();
        BDTableAdapters.recuperarPrecioProductTableAdapter recuperarPrecioProduct = new BDTableAdapters.recuperarPrecioProductTableAdapter();
        private bool integridad;
        private bool vald = false;
        private bool stock;
        Process proceso = new Process();
        private decimal Precio;
        private float CantVent;

        private float CantTotal; //Total de los articulos en la venta
        private float CantFinal; //Cantidad final de lo que se devuelve menos el de la venta
        List<Devolucion> dev = new List<Devolucion>();
        public Form11()
        {
            InitializeComponent();
        }

        private void TXT_VENTA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BD.BusquedaDevDataTable busquedaDevRows = busquedaDev.GetDataProductDev(int.Parse(TXT_VENTA.Text.Trim()));
                DGV_DEVPROC.DataSource = busquedaDevRows;
                CantTotal = 0;
                for (int i = 0; i < busquedaDevRows.Count; i++)
                {
                    CantTotal = (float)(CantTotal + busquedaDevRows[i].Cantidad);
                }
                foreach(var data in dev)
                {
                    if(data.Venta_Id == int.Parse(TXT_VENTA.Text.Trim()))
                    {
                        if(data.Stock == false)
                        {
                            MessageBox.Show("Esta venta ya ha devuelto todos sus productos");
                        }
                        else
                        {
                            MessageBox.Show("Esta venta aun tiene productos que devolver");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esta venta no ha tenido devoluciones");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AgregarDevolucion()
        {
            DialogResult dialogResult = MessageBox.Show("Desea Devolver Este Producto", "Devolucion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                foreach(var data in dev)
                {
                    if (data.Venta_Id == int.Parse(TXT_VENTA.Text.Trim()))
                    {
                        data.Cantidad = CantFinal;
                        data.Stock = stock;
                        return;
                    }
                }

                Devolucion nuevo = new Devolucion(int.Parse(TXT_VENTA.Text.Trim()), CantFinal, stock);
                dev.Add(nuevo);
               
                //do something
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Aux_id = (int)DGV_DEVPROC.CurrentRow.Cells[0].Value;
            float Cant = float.Parse(TXT_CANTDEV.Text.Trim());
            //float CantVent = (float)DGV_DEVPROC.CurrentRow.Cells[2].Value;
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
                    return;
                }

                if(Cant > CantVent)
                {
                    vald = true;
                    MessageBox.Show("No se puede devolver mas de lo que se compro");
                    return;
                }
                else
                {
                    vald = false;
                }

                CantFinal = (CantTotal - Cant) - CantFinal;
                if(CantFinal > 0)
                {
                    stock = true;
                }
                else if(CantFinal == 0)
                {
                    stock = false;
                }
                AgregarDevolucion();

                if(!vald)
                {
                    devolucion_Iner.GetDataDevolucion(TXT_MOTIVO.Text.Trim().ToString(), integridad, int.Parse(TXT_VENTA.Text.Trim()), Aux_id, int.Parse(TXT_CANTDEV.Text.Trim()));

                    devolucion_Products.GetDataDevProcd(int.Parse(TXT_CANTDEV.Text.Trim()), Aux_id, VariablesCom.user_id);
                    MessageBox.Show("Devolucion hecha");

                    DGV_DEVPROC.CurrentRow.Cells[2].Value = (CantVent - Cant).ToString() ;
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
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

            e.Graphics.DrawString("Nota de Credito: "+ creditoRow.NotaCredito.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Motivo de la devolucion: " + creditoRow.motivo.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Producto: " + creditoRow.Producto.ToString() + "     Precio: $"+ creditoRow.Precio.ToString()+ "     Cantidad: " + TXT_CANTDEV.Text.Trim().ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Cambio devuelto: $" + Precio.ToString() + "  ", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Subtotal: $" + creditoRow.nuevo_Subtotal.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Total: $" + creditoRow.nuevoTotal.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void DGV_DEVPROC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Aux_id = (int)DGV_DEVPROC.CurrentRow.Cells[0].Value;
                BD.recuperarPrecioProductDataTable productRows = recuperarPrecioProduct.GetDataRecuperarPrecio(Aux_id, int.Parse(TXT_CANTDEV.Text.Trim()));
                BD.recuperarPrecioProductRow recuperar = (BD.recuperarPrecioProductRow)productRows.Rows[0];
                Precio = recuperar.Precio;
                //MessageBox.Show(""+ DGV_DEVPROC.CurrentRow.Cells[2].Value.ToString() + "");
                string Cantidad = DGV_DEVPROC.CurrentRow.Cells[2].Value.ToString();

                CantVent = float.Parse(Cantidad);
                TXT_CAMBIO.Text = Precio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
