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
    public partial class Form18 : Form
    {
        BDTableAdapters.ShowDeptoTableAdapter showDepto = new BDTableAdapters.ShowDeptoTableAdapter();
        BDTableAdapters.DeptosTableAdapter deptos = new BDTableAdapters.DeptosTableAdapter();
        private bool vald = false;
        private int ID;
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            try
            {
                BD.ShowDeptoDataTable deptoRows = showDepto.GetDataDeptos();
                DGV_DEPTOS.DataSource = deptoRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TXT_DEPTOS.Text.Trim().ToString();
                for (int i=0; i < nombre.Length; i++)
                {
                    if(!(nombre[i] >= 65 && nombre[i]<=90 || nombre[i] >= 97 && nombre[i] <= 122 || nombre[i]==32))
                    {
                        vald = true;
                        MessageBox.Show("Formato permitido: A-Z, a-z");
                    }
                }
                if(!vald)
                {
                    deptos.GetDataInserDeptos(nombre);
                    Actualizar();
                    MessageBox.Show("Departamento dado de alta");
                    TXT_DEPTOS.Clear();
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

        private void DGV_DEPTOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = (int)DGV_DEPTOS.CurrentRow.Cells[0].Value;
                TXT_DEPTOS.Text = DGV_DEPTOS.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TXT_DEPTOS.Text.Trim().ToString();
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (!(nombre[i] >= 65 && nombre[i] <= 90 || nombre[i] >= 97 && nombre[i] <= 122 || nombre[i] == 32))
                    {
                        vald = true;
                        MessageBox.Show("Formato permitido: A-Z, a-z");
                    }
                }
                if (!vald)
                {
                    deptos.updtDeptos(ID, nombre);
                    Actualizar();
                    MessageBox.Show("Departamento Actualizado");
                    TXT_DEPTOS.Clear();
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

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                deptos.bajaDeptos(ID);
                Actualizar();
                MessageBox.Show("Departamento dado de baja");
                TXT_DEPTOS.Clear();
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
