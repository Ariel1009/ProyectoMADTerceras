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
    public partial class Form7 : Form
    {
        BDTableAdapters.DescuentosTableAdapter descuentos = new BDTableAdapters.DescuentosTableAdapter();
        BDTableAdapters.ShowDeptoTableAdapter deptos = new BDTableAdapters.ShowDeptoTableAdapter();
        BDTableAdapters.ProductoTableAdapter producto = new BDTableAdapters.ProductoTableAdapter();
        BDTableAdapters.buscarProductoTableAdapter buscarProducto = new BDTableAdapters.buscarProductoTableAdapter();
        private int ID;
        public Form7()
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

        private void LlenarDeptos()
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

        private void Form7_Load(object sender, EventArgs e)
        {
            Actualizar();
            LlenarDeptos();
            LlenarDescuentos();
        }

        private void DGV_PRODUCTOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = (int)DGV_PRODUCTOS.CurrentRow.Cells[0].Value;

            try
            {
                BD.buscarProductoDataTable buscarProductoRows = buscarProducto.GetDataBuscarProducto(ID);
                BD.buscarProductoRow row = (BD.buscarProductoRow)buscarProductoRows.Rows[0];
                TXT_PRODUCTOSC.Text = row.Producto.ToString();
                TXT_PRODUCTO.Text = row.Producto.ToString();
                TXT_DEPSTOSC.Text = row.Departamento.ToString();
                TXT_MEDIDASC.Text = row.Unidad_de_medida.ToString();
                TXT_MEDIDA.Text = row.Unidad_de_medida.ToString();
                TXT_PRECIOSC.Text = row.Precio_unitario.ToString();
                TXT_PRECIO.Text = row.Precio_unitario.ToString();
                TXT_EXISTENCIASC.Text = row.Existencias.ToString();
                TXT_EXISTENCIA.Text = row.Existencias.ToString();
                TXT_REORDENSC.Text = row.Punto_de_reorden.ToString();
                TXT_REORDEN.Text = row.Punto_de_reorden.ToString();
                TXT_COSTOSC.Text = row.Costo.ToString();
                TXT_COSTO.Text = row.Costo.ToString();
                TXT_ALTASC.Text = row.Fecha_de_alta.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ActualizarMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                producto.actualizarProduct(ID, TXT_PRODUCTO.Text.Trim().ToString(), decimal.Parse(TXT_PRECIO.Text.Trim()),
                                        decimal.Parse(TXT_COSTO.Text.Trim()), TXT_MEDIDA.Text.Trim().ToString(),
                                        int.Parse(TXT_EXISTENCIA.Text.Trim()), int.Parse(TXT_REORDEN.Text.Trim()),
                                        CB_DEPTOS.SelectedIndex + 1, VariablesCom.user_id, CB_DESCUENTO.SelectedIndex + 1);
                MessageBox.Show("Producto actualizado");
                limpiar();
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void limpiar()
        {
            TXT_PRODUCTOSC.Clear();
            TXT_PRODUCTO.Clear();
            TXT_PRECIO.Clear();
            TXT_PRECIOSC.Clear();
            TXT_MEDIDASC.Clear();
            TXT_MEDIDA.Clear();
            TXT_EXISTENCIASC.Clear();
            TXT_EXISTENCIA.Clear();
            TXT_COSTOSC.Clear();
            TXT_COSTO.Clear();
            TXT_ALTASC.Clear();
            TXT_REORDEN.Clear();
            TXT_REORDENSC.Clear();
            TXT_DEPSTOSC.Clear();
            CB_DEPTOS.ResetText();
            CB_DESCUENTO.ResetText();
        }

        private void BajaMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                producto.bajaProduct(ID);
                limpiar();
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
        }
    }
}
