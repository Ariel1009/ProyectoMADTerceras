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
    public partial class Form6 : Form
    {
        BDTableAdapters.DescuentosTableAdapter descuentos = new BDTableAdapters.DescuentosTableAdapter();
        BDTableAdapters.ShowDeptoTableAdapter deptos = new BDTableAdapters.ShowDeptoTableAdapter();
        BDTableAdapters.ProductoTableAdapter producto = new BDTableAdapters.ProductoTableAdapter();
        private bool vald = false;
        public Form6()
        {
            InitializeComponent();
        }

        private void BackMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void Actualizar()
        {
            try
            {
                BD.ProductoDataTable productoRows = producto.GetDataProducto();
                DGV_PRODUCTOS.DataSource = productoRows;
            }
            catch (Exception ex )
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Actualizar();
            LlenarDeptos();
            LlenarDescuentos();
        }

        private void LlenarDeptos()
        {
            try
            {
                BD.ShowDeptoDataTable showDeptos = deptos.GetDataDeptos();
                List<string> departamentos = showDeptos.AsEnumerable().Select(x => x[1].ToString()).ToList();
                CB_DEPTOS.DataSource = departamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LlenarDescuentos()
        {
            try
            {
                BD.DescuentosDataTable descuentosRows = descuentos.GetDataDescuentos();
                List<string> descuento = descuentosRows.AsEnumerable().Select(x => x[0].ToString()).ToList();
                CB_DESCUENTO.DataSource = descuento;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InsertarMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                decimal precioC = decimal.Parse(TXT_PRECIO.Text.Trim());
                decimal costoC = decimal.Parse(TXT_COSTO.Text.Trim());
                if (precioC<=0)
                {
                    MessageBox.Show("Precio negativo");
                    vald = true;
                }

                if (precioC >= costoC)
                {
                    MessageBox.Show("El precio no puede ser mayor que el costo");
                    vald = true;
                }


                if (!vald)
                {
                    producto.insertProduct(TXT_PRODUCTO.Text.Trim().ToString(), decimal.Parse(TXT_PRECIO.Text.Trim()),
                                        decimal.Parse(TXT_COSTO.Text.Trim()), TXT__MEDIDA.Text.Trim().ToString(),
                                        int.Parse(TXT_EXISTENCIA.Text.Trim()), int.Parse(TXT_REORDEN.Text.Trim()),
                                        CB_DEPTOS.SelectedIndex + 1, VariablesCom.user_id, CB_DESCUENTO.SelectedIndex + 1);
                    MessageBox.Show("Producto registrado");
                    Limpiar();
                    Actualizar();
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

        private void Limpiar()
        {
            TXT_PRODUCTO.Clear();
            TXT_PRECIO.Clear();
            TXT_COSTO.Clear();
            TXT_EXISTENCIA.Clear();
            TXT__MEDIDA.Clear();
            TXT_REORDEN.Clear();
            CB_DEPTOS.ResetText();
            CB_DESCUENTO.ResetText();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.ShowDialog();
        }
    }
}
