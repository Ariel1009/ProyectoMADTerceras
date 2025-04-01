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
    public partial class Form19 : Form
    {
        BDTableAdapters.AllUsuariosTableAdapter allUsuarios = new BDTableAdapters.AllUsuariosTableAdapter();
        BDTableAdapters.CajaTableAdapter caja = new BDTableAdapters.CajaTableAdapter();
        BDTableAdapters.MostrarCajasTableAdapter mostrarCajas = new BDTableAdapters.MostrarCajasTableAdapter();
        private bool estado;
        private bool vald = false;
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            Actualizar();
        }

        private void LlenarCombo()
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

        private void Actualizar()
        {
            try
            {
                BD.MostrarCajasDataTable mostrarCajasRows = mostrarCajas.GetDataMostrarCaja();
                DGV_USERS.DataSource = mostrarCajasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(CBOX_ACTIVE.Checked && CBOX_INACTIVE.Checked)
                {
                    vald = true;
                    MessageBox.Show("Seleccione uno de ambos");
                }

                if(CBOX_ACTIVE.Checked)
                {
                    estado = true;
                }
                else if (CBOX_INACTIVE.Checked)
                {
                    estado = false;
                }
                else
                {
                    vald = true;
                    MessageBox.Show("Seleccione uno de ambos");
                }

                if(!vald)
                {
                    caja.GetDataCrearCaja(CB_NUMCAJA.SelectedIndex + 1, CB_USERS.Text.ToString(), estado);
                    MessageBox.Show("Caja Creada");
                    Actualizar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                caja.GestionCajas("a", CB_NUMCAJA.SelectedIndex + 1, CB_USERS.Text.ToString());
                MessageBox.Show("Caja Activada");
                Actualizar();
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
                caja.GestionCajas("b", CB_NUMCAJA.SelectedIndex + 1, CB_USERS.Text.ToString());
                MessageBox.Show("Caja Desactivada");
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
