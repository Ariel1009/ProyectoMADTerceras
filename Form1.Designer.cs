
namespace ProyectoMADTerceras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_WARNING2 = new System.Windows.Forms.Label();
            this.LBL_WARNING = new System.Windows.Forms.Label();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.LKLB_CUENTA = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_PSW = new System.Windows.Forms.TextBox();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_WARNING2
            // 
            this.LBL_WARNING2.AutoSize = true;
            this.LBL_WARNING2.Enabled = false;
            this.LBL_WARNING2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_WARNING2.Location = new System.Drawing.Point(201, 215);
            this.LBL_WARNING2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_WARNING2.Name = "LBL_WARNING2";
            this.LBL_WARNING2.Size = new System.Drawing.Size(115, 13);
            this.LBL_WARNING2.TabIndex = 19;
            this.LBL_WARNING2.Text = "Ingrese su contraseña";
            this.LBL_WARNING2.Visible = false;
            // 
            // LBL_WARNING
            // 
            this.LBL_WARNING.AutoSize = true;
            this.LBL_WARNING.Enabled = false;
            this.LBL_WARNING.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_WARNING.Location = new System.Drawing.Point(220, 153);
            this.LBL_WARNING.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_WARNING.Name = "LBL_WARNING";
            this.LBL_WARNING.Size = new System.Drawing.Size(96, 13);
            this.LBL_WARNING.TabIndex = 18;
            this.LBL_WARNING.Text = "Ingrese su usuario";
            this.LBL_WARNING.Visible = false;
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Location = new System.Drawing.Point(147, 264);
            this.BTN_INGRESAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(140, 35);
            this.BTN_INGRESAR.TabIndex = 17;
            this.BTN_INGRESAR.Text = "Ingresar";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click);
            // 
            // LKLB_CUENTA
            // 
            this.LKLB_CUENTA.AutoSize = true;
            this.LKLB_CUENTA.Location = new System.Drawing.Point(219, 328);
            this.LKLB_CUENTA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LKLB_CUENTA.Name = "LKLB_CUENTA";
            this.LKLB_CUENTA.Size = new System.Drawing.Size(98, 19);
            this.LKLB_CUENTA.TabIndex = 16;
            this.LKLB_CUENTA.TabStop = true;
            this.LKLB_CUENTA.Text = "Crear cuenta";
            this.LKLB_CUENTA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKLB_CUENTA_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "No tienes cuenta:";
            // 
            // TXT_PSW
            // 
            this.TXT_PSW.Location = new System.Drawing.Point(136, 183);
            this.TXT_PSW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_PSW.Name = "TXT_PSW";
            this.TXT_PSW.Size = new System.Drawing.Size(223, 27);
            this.TXT_PSW.TabIndex = 14;
            this.TXT_PSW.UseSystemPasswordChar = true;
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(136, 121);
            this.TXT_USUARIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(223, 27);
            this.TXT_USUARIO.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = ".:Bienvenido:.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 376);
            this.Controls.Add(this.LBL_WARNING2);
            this.Controls.Add(this.LBL_WARNING);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.LKLB_CUENTA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_PSW);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_WARNING2;
        private System.Windows.Forms.Label LBL_WARNING;
        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.LinkLabel LKLB_CUENTA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_PSW;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

