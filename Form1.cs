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
    public partial class Form1 : Form
    {
        BDTableAdapters.LoginTableAdapter login = new BDTableAdapters.LoginTableAdapter();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void LKLB_CUENTA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            try
            {
                BD.LoginDataTable loginRows = login.GetDataLogin("a",TXT_USUARIO.Text.Trim().ToString(), TXT_PSW.Text.Trim().ToString());
                BD.LoginDataTable loginRows2 = login.GetDataLogin("c", TXT_USUARIO.Text.Trim().ToString(), TXT_PSW.Text.Trim().ToString());

                if (TXT_USUARIO.Text!="" && TXT_PSW.Text!="")
                {
                    LBL_WARNING.Visible = false;
                    LBL_WARNING2.Visible = false;

                    if (loginRows.Count>0)
                    {
                        BD.LoginRow row = (BD.LoginRow)loginRows.Rows[0];
                        VariablesCom.NameUser = row.nombre.ToString();
                        VariablesCom.numCaja = row.NumeroCaja.ToString();
                        VariablesCom.user_id = row.usuario_id;
                        VariablesCom.tipo = true;
                        MessageBox.Show("Ingresando");
                        Form3 form3 = new Form3();
                        this.Hide();
                        form3.ShowDialog();
                    }
                    else if (loginRows2.Count > 0)
                    {
                        BD.LoginRow row = (BD.LoginRow)loginRows2.Rows[0];
                        VariablesCom.NameUser = row.nombre.ToString();
                        VariablesCom.numCaja = row.NumeroCaja.ToString();
                        VariablesCom.user_id = row.usuario_id;
                        VariablesCom.tipo = false;
                        MessageBox.Show("Ingresando");
                        Form15 form15 = new Form15();
                        this.Hide();
                        form15.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                }
                else
                {
                    LBL_WARNING.Visible = true;
                    LBL_WARNING2.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
