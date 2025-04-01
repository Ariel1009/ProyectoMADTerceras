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
    public partial class Form2 : Form
    {
        BDTableAdapters.UsuarioTableAdapter usuario = new BDTableAdapters.UsuarioTableAdapter();
        private bool vald = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void BTN_REGISTER_Click(object sender, EventArgs e)
        {
            String nombre = TXT_NAME.Text.Trim().ToString();
            String user = TXT_USER.Text.Trim().ToString();
            String psw = TXT_PSW.Text.Trim().ToString();
            String email = TXT_EMAIL.Text.Trim().ToString();
            String curp = TXT_CURP.Text.Trim().ToString();
            try
            {
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (!(nombre[i] >= 65 && nombre[i] <= 90 || nombre[i] >= 97 && nombre[i] <= 122 || nombre[i] == 32))
                    {
                        vald = true;
                        Lbl_WARNING.Visible = true;
                        break;
                    }
                    else
                    {
                        vald = false;
                        //MessageBox.Show("Validacion correcta");
                        Lbl_WARNING.Visible = false;
                        break;
                    }
                }
                for (int i = 0; i < user.Length; i++)
                {
                    if (!(user[i] >= 65 && user[i] <= 90 || user[i] >= 97 && user[i] <= 122 || user[i] >= 48 && user[i] <= 57))
                    {
                        vald = true;
                        Lbl_WARNING2.Visible = true;
                        break;
                    }
                    else
                    {
                        vald = false;
                        //MessageBox.Show("Validacion correcta");
                        Lbl_WARNING2.Visible = false;
                        break;
                    }
                }
                for (int i = 0; i < psw.Length; i++)
                {
                    if (!(psw[i] >= 65 && psw[i] <= 90 || psw[i] >= 97 && psw[i] <= 122 || psw[i] >= 48 && psw[i] <= 57))
                    {
                        vald = true;
                        Lbl_WARNING3.Visible = true;
                        break;
                    }
                    else
                    {
                        vald = false;
                        //MessageBox.Show("Validacion correcta");
                        Lbl_WARNING3.Visible = false;
                        break;
                    }
                }
                for (int i = 0; i < email.Length; i++)
                {
                    if (!(email[i] >= 65 && email[i] <= 90 || email[i] >= 97 && email[i] <= 122 || email[i] >= 48 && email[i] <= 57 || email[i] == 95 || email[i] == 46 || email[i] == 64))
                    {
                        vald = true;
                        Lbl_WARNING4.Visible = true;
                        break;
                    }
                    else
                    {
                        vald = false;
                        //MessageBox.Show("Validacion correcta");
                        Lbl_WARNING4.Visible = false;
                        break;
                    }
                }
                for (int i = 0; i < curp.Length; i++)
                {
                    if (!(curp[i] >= 65 && curp[i] <= 90 || curp[i] >= 48 && curp[i] <= 57))
                    {
                        vald = true;
                        Lbl_WARNING5.Visible = true;
                        break;
                    }
                    else
                    {
                        vald = false;
                        //MessageBox.Show("Validacion correcta");
                        Lbl_WARNING5.Visible = false;
                        break;
                    }
                }
                if (vald==false && nombre!="" && user!="" && psw!="" && email != "" && curp!="")
                {
                    usuario.insertarUsuario(nombre, psw, curp, email, CB_ROL.SelectedIndex + 1, DTP_FNACIMIENTO.Value, CB_NUMCAJA.SelectedIndex + 1, user);
                    MessageBox.Show("Usuario creado");
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
           
        }
    }
}
