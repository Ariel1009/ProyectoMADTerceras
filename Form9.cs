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
    public partial class Form9 : Form
    {
        BDTableAdapters.busquedaIDProducTableAdapter busquedaIDProducTable = new BDTableAdapters.busquedaIDProducTableAdapter();
        BDTableAdapters.busquedaNombreProducTableAdapter busquedaNombreProducTable = new BDTableAdapters.busquedaNombreProducTableAdapter();
        BDTableAdapters.AplicarVentaTableAdapter aplicarVenta = new BDTableAdapters.AplicarVentaTableAdapter();
        BDTableAdapters.mostrarMetodosTableAdapter mostrarMetodos = new BDTableAdapters.mostrarMetodosTableAdapter();
        BDTableAdapters.crearVentaTableAdapter crearVenta = new BDTableAdapters.crearVentaTableAdapter();
        BDTableAdapters.PagosTableAdapter pagosTableAdapter = new BDTableAdapters.PagosTableAdapter();
        BDTableAdapters.CarritoTableAdapter carritoTable = new BDTableAdapters.CarritoTableAdapter();
        BDTableAdapters.RecuperarIDventaTableAdapter recuperar = new BDTableAdapters.RecuperarIDventaTableAdapter();
        BDTableAdapters.ReciboTableAdapter recibo = new BDTableAdapters.ReciboTableAdapter();
        
        BDTableAdapters.guardarUbicacionTableAdapter guardarUbicacion = new BDTableAdapters.guardarUbicacionTableAdapter();
        private int ID;
        private string nom;
        private decimal prec;
        private float descuento;
        private decimal subtotal;
        private decimal total;
        private decimal totalsinDesc;
        private decimal restante;
        private decimal cambio;
        private decimal nuevoprecio;
        private decimal nuevosubtotal;
        private decimal nuevoRestante;
        private decimal montoBorrado;
        private bool vald = false;
        List<Carrito> Carr = new List<Carrito>();
        List<MetodosPago> pagos = new List<MetodosPago>();
        Process proceso = new Process();
        public Form9()
        {
            InitializeComponent();
        }

        private void LlenarMetodos()
        {
            try
            {
                BD.mostrarMetodosDataTable mostrarMetodosRows = mostrarMetodos.GetDataMetodos();
                List<string> metodos = mostrarMetodosRows.AsEnumerable().Select(x => x[1].ToString()).ToList();
                CB_METODOS.DataSource = metodos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TXT_CODEPRODUCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TXT_CODEPRODUCT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(TXT_CODEPRODUCT.Text.Trim());
                BD.busquedaIDProducDataTable iDProducRows = busquedaIDProducTable.GetDataIDProduct(Id);
                DGV_PRODUCTO.DataSource = iDProducRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CBOX_ACTIVAR_CheckedChanged(object sender, EventArgs e)
        {
            if (CBOX_ACTIVAR.Checked)
            {
                TXT_CODEPRODUCT.Enabled = true;
                TXT_CODEPRODUCT.Clear();
            }
            else if(!CBOX_ACTIVAR.Checked)
            {
                TXT_CODEPRODUCT.Enabled = false;
                TXT_CODEPRODUCT.Clear();
            }
        }

        private void TXT_NAMEPRODUC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BD.busquedaNombreProducDataTable busquedaNombreProducRows = busquedaNombreProducTable.GetDataNameProduc(TXT_NAMEPRODUC.Text.Trim().ToString());
                DGV_PRODUCTO.DataSource = busquedaNombreProducRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CBOX_ACTIVAR2_CheckedChanged(object sender, EventArgs e)
        {
            if (CBOX_ACTIVAR2.Checked)
            {
                TXT_NAMEPRODUC.Enabled = true;
                TXT_NAMEPRODUC.Clear();
            }
            else if (!CBOX_ACTIVAR2.Checked)
            {
                TXT_NAMEPRODUC.Enabled = false;
                TXT_NAMEPRODUC.Clear();
            }
        }

        private void DGV_PRODUCTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ID = (int)DGV_PRODUCTO.CurrentCell.Value;
            //try
            //{
            //    BD.AplicarVentaDataTable ventaRows = aplicarVenta.GetDataAplicaVenta(ID, float.Parse(TXT_CANTIDAD.Text.Trim()));
            //    BD.AplicarVentaRow aplicarVentaRow = (BD.AplicarVentaRow)ventaRows.Rows[0];
            //    nom = aplicarVentaRow.Producto.ToString();
            //    prec = aplicarVentaRow.Precio;
            //    descuento = (float)aplicarVentaRow.Descuento;
            //    AgregarCarrito();
            //    total = total + aplicarVentaRow.Total;
            //    subtotal = subtotal + aplicarVentaRow.Subtotal;
            //    totalsinDesc = subtotal - total;
            //    LBL_CANTIDAD2.Text = subtotal.ToString();
            //    LBL_CANTIDAD5.Text = totalsinDesc.ToString();
            //    LBL_CANTIDAD4.Text = total.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void AgregarCarrito()
        {
            DialogResult dialogResult = MessageBox.Show("Desea Agregar Este Producto", "Carrito", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Carrito nuevo = new Carrito(ID, nom, prec, float.Parse(TXT_CANTIDAD.Text.Trim()), descuento);
                Carr.Add(nuevo);
                DGV_CARRITO.DataSource = null;
                DGV_CARRITO.DataSource = Carr;

                //do something
                TXT_CANTPRODUCT.Text = Carr.Sum(x => x.Cantidad).ToString();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            LlenarMetodos();
            try
            {
                LBL_NAMEUSER.Text = VariablesCom.NameUser.ToString();
                LBL_NUMCAJA.Text = VariablesCom.numCaja.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void BTN_AGREGARMETODO_Click(object sender, EventArgs e)
        {
            restante = total - (decimal.Parse(TXT__MONTOPA.Text.Trim()) + pagos.Sum(x => x.Monto));
            
            LBL_CANTIDAD1.Text = restante.ToString();
            if (restante<=0)
            {
                cambio = -(restante);
                LBL_CANTIDAD1.Text = "0.00";
                LBL_CANTIDAD3.Text = cambio.ToString();
                BTN_AGREGARMETODO.Enabled = false;
            }
            
            MetodosPago metodosPago = new MetodosPago(CB_METODOS.SelectedIndex+1,CB_METODOS.Text.ToString(), decimal.Parse(TXT__MONTOPA.Text.Trim()));
            pagos.Add(metodosPago);
            DGV_METODOS.DataSource = null;
            DGV_METODOS.DataSource = pagos;
        }

        private void BorrarPago(int _ID)
        {
            foreach (var Borrar in pagos)
            {
                if (Borrar.ID == _ID)
                {
                    montoBorrado = Borrar.Monto;
                    pagos.Remove(Borrar);
                    break;

                }
            }
        }

        private void BorrarCarrito(int _ID)
        {
            foreach (var Borrar in Carr)
            {
                if (Borrar.Id_PRODUCTO == _ID)
                {
                    Carr.Remove(Borrar);
                    break;

                }
            }
        }

        private void BTN_QUITARCARRITO_Click(object sender, EventArgs e)
        {
            int Aux_id = (int)DGV_CARRITO.CurrentRow.Cells[0].Value;
            
            BorrarCarrito(Aux_id);

            if(Carr.Count==0)
            {
                total = 0;
                subtotal = 0;
                totalsinDesc = 0;
                LBL_CANTIDAD2.Text = "0.00";
                LBL_CANTIDAD5.Text = "0.00";
                LBL_CANTIDAD4.Text = "0.00";
                TXT_CANTPRODUCT.Clear();
                DGV_CARRITO.DataSource = null;
                return;
            }

            if (Carr.Count == 1)
            {
                foreach(var data in Carr)
                {
                    nuevoprecio = ((decimal)data.Cantidad) * ((decimal)data.Descuento);
                    nuevosubtotal = ((decimal)data.Cantidad) * data.Precio;
                }
                total = nuevoprecio;
                subtotal = nuevosubtotal;
                totalsinDesc = subtotal - total;
                LBL_CANTIDAD2.Text = subtotal.ToString();
                LBL_CANTIDAD5.Text = totalsinDesc.ToString();
                LBL_CANTIDAD4.Text = total.ToString() + ".00";
                TXT_CANTPRODUCT.Text = Carr.Sum(x => x.Cantidad).ToString();
                DGV_CARRITO.DataSource = null;
                DGV_CARRITO.DataSource = Carr;
                return;
            }

            for (int i = 0; i < Carr.Count; i++)
            {
                nuevoprecio = nuevoprecio + (((decimal)Carr[i].Cantidad) * ((decimal)Carr[i].Descuento));
                nuevosubtotal = nuevosubtotal + (((decimal)Carr[i].Cantidad) * Carr[i].Precio);
            }
            total = nuevoprecio;
            subtotal = nuevosubtotal;
            totalsinDesc = subtotal - total;
            LBL_CANTIDAD2.Text = subtotal.ToString();
            LBL_CANTIDAD5.Text = totalsinDesc.ToString();
            LBL_CANTIDAD4.Text = total.ToString() + ".00";
            
            TXT_CANTPRODUCT.Text = Carr.Sum(x => x.Cantidad).ToString();
            DGV_CARRITO.DataSource = null;
            DGV_CARRITO.DataSource = Carr;

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void VentaMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (restante <= 0)
                {
                    crearVenta.GetDataInsertarVenta(VariablesCom.numCaja, total, subtotal, cambio, DTP_FECHAVENTA.Value, VariablesCom.user_id);
                    for (int i = 0; i < Carr.Count; i++)
                    {
                        carritoTable.GetDataCarrito(Carr[i].Id_PRODUCTO, Carr[i].Cantidad, VariablesCom.user_id);
                    }
                    for (int i = 0; i < pagos.Count; i++)
                    {
                        pagosTableAdapter.GetDataPagos(pagos[i].ID, pagos[i].Monto);
                    }
                    BD.RecuperarIDventaDataTable recuperarIDventas = recuperar.GetDataRecuperarID();
                    BD.RecuperarIDventaRow iDventaRow = (BD.RecuperarIDventaRow)recuperarIDventas.Rows[0];
                    MessageBox.Show("Venta " + iDventaRow.Column1 + " Hecha");
                }
                else
                {
                    MessageBox.Show("Por favor termine de pagar");
                }
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BTN_AGREGARCARRITO_Click(object sender, EventArgs e)
        {
            ID = (int)DGV_PRODUCTO.CurrentRow.Cells[0].Value;
            try
            {
                string valor = DGV_PRODUCTO.CurrentRow.Cells[4].Value.ToString();
                float cant = float.Parse(valor);
                if (float.Parse(TXT_CANTIDAD.Text.Trim()) >= cant)
                {
                    vald = true;
                    MessageBox.Show("No se puede comprar más de lo que hay de stock");
                }
                else
                {
                    vald = false;
                }
                if(!vald)
                {
                    BD.AplicarVentaDataTable ventaRows = aplicarVenta.GetDataAplicaVenta(ID, float.Parse(TXT_CANTIDAD.Text.Trim()));
                    BD.AplicarVentaRow aplicarVentaRow = (BD.AplicarVentaRow)ventaRows.Rows[0];
                    nom = aplicarVentaRow.Producto.ToString();
                    prec = aplicarVentaRow.Precio;
                    descuento = (float)aplicarVentaRow.Descuento;
                    AgregarCarrito();
                    total = total + aplicarVentaRow.Total;
                    subtotal = subtotal + aplicarVentaRow.Subtotal;
                    totalsinDesc = subtotal - total;
                    LBL_CANTIDAD2.Text = subtotal.ToString();
                    LBL_CANTIDAD5.Text = totalsinDesc.ToString();
                    LBL_CANTIDAD4.Text = total.ToString();
                    LBL_CANTIDAD1.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar al carrito");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //MessageBox.Show(DGV_PRODUCTO.CurrentRow.Cells[0].Value.ToString());
        }

        private void TicketMenuItem_Click(object sender, EventArgs e)
        {
            BD.RecuperarIDventaDataTable recuperarIDventas = recuperar.GetDataRecuperarID();
            BD.RecuperarIDventaRow iDventaRow = (BD.RecuperarIDventaRow)recuperarIDventas.Rows[0];
            int venta_id = iDventaRow.Column1;

            //Datos de la venta
            BD.ReciboDataTable reciboRows = recibo.GetDataRecibo(venta_id);
            BD.ReciboRow RboRow = (BD.ReciboRow)reciboRows.Rows[0];

            //crear pdf
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += imprimir;
            printDocument1.Print();

            int ticket = RboRow.Ticket;
            string rutaGuardado = @"C:\Users\ofeli\source\repos\ProyectoMADTerceras\PDF\Ticket " + ticket + ".pdf ";

            guardarUbicacion.GetDataUbicacion(ticket, rutaGuardado);
            //Mostrar pdf
            proceso.StartInfo.FileName = @"C:\Users\ofeli\source\repos\ProyectoMADTerceras\PDF\Ticket " + ticket + ".pdf "; ;
            proceso.Start();
        }

        private void imprimir (object sender, PrintPageEventArgs e)
        {
            BD.RecuperarIDventaDataTable recuperarIDventas = recuperar.GetDataRecuperarID();
            BD.RecuperarIDventaRow iDventaRow = (BD.RecuperarIDventaRow)recuperarIDventas.Rows[0];
            int venta_id = iDventaRow.Column1;

            //Datos de la venta
            BD.ReciboDataTable reciboRows = recibo.GetDataRecibo(venta_id);
            BD.ReciboRow RboRow = (BD.ReciboRow)reciboRows.Rows[0];


            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int width = 1600;
            int y = 20;

            //Seccion Encabezado
           e.Graphics.DrawString("Ticket: "+ RboRow.Ticket.ToString() + "   Fecha: "+ RboRow.fechaVenta.ToString() + " ", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
           e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));

            //Seccion Cajero
           e.Graphics.DrawString("Cajero que Atendio: "+ RboRow.nombre + " ", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
           e.Graphics.DrawString("Caja: " + RboRow.NumeroCaja.ToString() + " ", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));

            //Seccion Productos
            e.Graphics.DrawString("Productos:           Precio:           Cantidad:", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));

            for (int i =0; i<Carr.Count; i++)
            {
                e.Graphics.DrawString(""+Carr[i].Nombre+ "           $" + Carr[i].Precio+ "           " + Carr[i].Cantidad+"", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            }

            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));

            //Seccion Metodos de Pago
            e.Graphics.DrawString("Concepto:           Monto:", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            for (int i = 0; i < pagos.Count; i++)
            {
                e.Graphics.DrawString("|"+pagos[i].Metodo+ "           $" + pagos[i].Monto+"", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));

            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Recibio de cambio: $" + RboRow.cambio.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Subtotal: $"+ RboRow.subtotal.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));
            e.Graphics.DrawString("Total: $" + RboRow.total.ToString() + "", font, Brushes.Black, new RectangleF(0, y += 30, width, 20));

        }

        private void BTN_QUITARMETODO_Click(object sender, EventArgs e)
        {
            int Aux_id = (int)DGV_METODOS.CurrentRow.Cells[0].Value;

            BorrarPago(Aux_id);

            if (pagos.Count==0)
            {
                restante = total;
                LBL_CANTIDAD1.Text = restante.ToString();
                DGV_METODOS.DataSource = null;
                return;
            }


            nuevoRestante = restante + montoBorrado ;

            LBL_CANTIDAD1.Text = nuevoRestante.ToString();
            DGV_METODOS.DataSource = null;
            DGV_METODOS.DataSource = pagos;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV_PRODUCTO.DataSource = null;
            DGV_CARRITO.DataSource = null;
            TXT_CANTIDAD.Clear();
            TXT_CANTPRODUCT.Clear();
            TXT_CODEPRODUCT.Clear();
            TXT_NAMEPRODUC.Clear();
            TXT__MONTOPA.Clear();
            DTP_FECHAVENTA.ResetText();
        }
    }
}
