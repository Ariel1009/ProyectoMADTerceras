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
    public partial class Form5 : Form
    {
        BDTableAdapters.UsuarioTableAdapter usuario = new BDTableAdapters.UsuarioTableAdapter();
        BDTableAdapters.busquedaUserTableAdapter busquedaUser = new BDTableAdapters.busquedaUserTableAdapter();
        private bool vald;
        private int ID;
        public Form5()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            BD.UsuarioDataTable usuarioRows = usuario.GetDataUser();
            DGV_USERS.DataSource = usuarioRows;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void DGV_USERS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = (int)DGV_USERS.CurrentRow.Cells[0].Value;
                //MessageBox.Show("'"+ID+"'");
                BD.busquedaUserDataTable userRows = busquedaUser.GetDataBusqueda(ID);
                BD.busquedaUserRow busquedaUserRow = (BD.busquedaUserRow)userRows.Rows[0];
                TXT_NAMESC.Text = busquedaUserRow.Cajero.ToString();
                TXT_NAME.Text = busquedaUserRow.Cajero.ToString();
                TXT_USERSC.Text = busquedaUserRow.Usuario.ToString();
                TXT_USER.Text = busquedaUserRow.Usuario.ToString();
                TXT_PSWSC.Text = busquedaUserRow.Pass.ToString();
                TXT_PSW.Text = busquedaUserRow.Pass.ToString();
                TXT_CURPSC.Text = busquedaUserRow.CURP.ToString();
                TXT_CURP.Text = busquedaUserRow.CURP.ToString();
                TXT_EMAILSC.Text = busquedaUserRow.Email.ToString();
                TXT_EMAIL.Text = busquedaUserRow.Email.ToString();
                TXT_CAJASC.Text = busquedaUserRow.Caja.ToString();
                TXT_EMAIL.Text = busquedaUserRow.Email.ToString();
                TXT_FNACIMIENTOSC.Text = busquedaUserRow.Fecha_de_Nacimiento.ToString();
                if (busquedaUserRow.ROL == 1)
                {
                    TXT_ROLSC.Text = "Administrador";
                }
                else if (busquedaUserRow.ROL == 2)
                {
                    TXT_ROLSC.Text = "Cajero";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ActualizarMenuItem_Click(object sender, EventArgs e)
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

                if (vald == false && nombre != "" && user != "" && psw != "" && email != "" && curp != "")
                {
                    usuario.actualizarUsuario(ID, nombre, psw, curp, email, CB_ROL.SelectedIndex + 1, DTP_FNACIMIENTO.Value, CB_NUMCAJA.SelectedIndex + 1, user);
                    limpiarItems();
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

        private void limpiarItems()
        {
            TXT_NAMESC.Clear();
            TXT_PSWSC.Clear();
            TXT_CURPSC.Clear();
            TXT_EMAILSC.Clear();
            TXT_USERSC.Clear();
            TXT_FNACIMIENTOSC.Clear();
            TXT_ROLSC.Clear();
            TXT_CAJASC.Clear();
            TXT_NAME.Clear();
            TXT_PSW.Clear();
            TXT_CURP.Clear();
            TXT_EMAIL.Clear();
            TXT_USER.Clear();
            DTP_FNACIMIENTO.ResetText();
            CB_ROL.ResetText();
            CB_NUMCAJA.ResetText();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.bajaUsuario(ID);
                limpiarItems();
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
