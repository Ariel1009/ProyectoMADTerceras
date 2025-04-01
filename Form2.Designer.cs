
namespace ProyectoMADTerceras
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT_PSW = new System.Windows.Forms.TextBox();
            this.TXT_USER = new System.Windows.Forms.TextBox();
            this.TXT_CURP = new System.Windows.Forms.TextBox();
            this.TXT_EMAIL = new System.Windows.Forms.TextBox();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_ROL = new System.Windows.Forms.ComboBox();
            this.CB_NUMCAJA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_FNACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_REGISTER = new System.Windows.Forms.Button();
            this.Lbl_WARNING = new System.Windows.Forms.Label();
            this.Lbl_WARNING2 = new System.Windows.Forms.Label();
            this.Lbl_WARNING3 = new System.Windows.Forms.Label();
            this.Lbl_WARNING4 = new System.Windows.Forms.Label();
            this.Lbl_WARNING5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_PSW
            // 
            this.TXT_PSW.Location = new System.Drawing.Point(160, 132);
            this.TXT_PSW.Name = "TXT_PSW";
            this.TXT_PSW.Size = new System.Drawing.Size(225, 26);
            this.TXT_PSW.TabIndex = 22;
            // 
            // TXT_USER
            // 
            this.TXT_USER.Location = new System.Drawing.Point(160, 78);
            this.TXT_USER.Name = "TXT_USER";
            this.TXT_USER.Size = new System.Drawing.Size(225, 26);
            this.TXT_USER.TabIndex = 21;
            // 
            // TXT_CURP
            // 
            this.TXT_CURP.Location = new System.Drawing.Point(162, 231);
            this.TXT_CURP.Name = "TXT_CURP";
            this.TXT_CURP.Size = new System.Drawing.Size(225, 26);
            this.TXT_CURP.TabIndex = 20;
            // 
            // TXT_EMAIL
            // 
            this.TXT_EMAIL.Location = new System.Drawing.Point(161, 183);
            this.TXT_EMAIL.Name = "TXT_EMAIL";
            this.TXT_EMAIL.Size = new System.Drawing.Size(225, 26);
            this.TXT_EMAIL.TabIndex = 19;
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(161, 30);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(225, 26);
            this.TXT_NAME.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "CURP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre completo:";
            // 
            // CB_ROL
            // 
            this.CB_ROL.FormattingEnabled = true;
            this.CB_ROL.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.CB_ROL.Location = new System.Drawing.Point(162, 329);
            this.CB_ROL.Name = "CB_ROL";
            this.CB_ROL.Size = new System.Drawing.Size(121, 28);
            this.CB_ROL.TabIndex = 26;
            // 
            // CB_NUMCAJA
            // 
            this.CB_NUMCAJA.FormattingEnabled = true;
            this.CB_NUMCAJA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.CB_NUMCAJA.Location = new System.Drawing.Point(162, 283);
            this.CB_NUMCAJA.Name = "CB_NUMCAJA";
            this.CB_NUMCAJA.Size = new System.Drawing.Size(121, 28);
            this.CB_NUMCAJA.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Caja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Rol:";
            // 
            // DTP_FNACIMIENTO
            // 
            this.DTP_FNACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FNACIMIENTO.Location = new System.Drawing.Point(221, 378);
            this.DTP_FNACIMIENTO.Name = "DTP_FNACIMIENTO";
            this.DTP_FNACIMIENTO.Size = new System.Drawing.Size(130, 26);
            this.DTP_FNACIMIENTO.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // BTN_REGISTER
            // 
            this.BTN_REGISTER.Location = new System.Drawing.Point(160, 439);
            this.BTN_REGISTER.Name = "BTN_REGISTER";
            this.BTN_REGISTER.Size = new System.Drawing.Size(110, 29);
            this.BTN_REGISTER.TabIndex = 29;
            this.BTN_REGISTER.Text = "Registrar";
            this.BTN_REGISTER.UseVisualStyleBackColor = true;
            this.BTN_REGISTER.Click += new System.EventHandler(this.BTN_REGISTER_Click);
            // 
            // Lbl_WARNING
            // 
            this.Lbl_WARNING.AutoSize = true;
            this.Lbl_WARNING.Enabled = false;
            this.Lbl_WARNING.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING.Location = new System.Drawing.Point(206, 60);
            this.Lbl_WARNING.Name = "Lbl_WARNING";
            this.Lbl_WARNING.Size = new System.Drawing.Size(140, 13);
            this.Lbl_WARNING.TabIndex = 30;
            this.Lbl_WARNING.Text = "Solo se permiten Letras";
            this.Lbl_WARNING.Visible = false;
            // 
            // Lbl_WARNING2
            // 
            this.Lbl_WARNING2.AutoSize = true;
            this.Lbl_WARNING2.Enabled = false;
            this.Lbl_WARNING2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING2.Location = new System.Drawing.Point(176, 107);
            this.Lbl_WARNING2.Name = "Lbl_WARNING2";
            this.Lbl_WARNING2.Size = new System.Drawing.Size(197, 13);
            this.Lbl_WARNING2.TabIndex = 31;
            this.Lbl_WARNING2.Text = "Solo se permiten letras y numeros";
            this.Lbl_WARNING2.Visible = false;
            // 
            // Lbl_WARNING3
            // 
            this.Lbl_WARNING3.AutoSize = true;
            this.Lbl_WARNING3.Enabled = false;
            this.Lbl_WARNING3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING3.Location = new System.Drawing.Point(176, 162);
            this.Lbl_WARNING3.Name = "Lbl_WARNING3";
            this.Lbl_WARNING3.Size = new System.Drawing.Size(197, 13);
            this.Lbl_WARNING3.TabIndex = 32;
            this.Lbl_WARNING3.Text = "Solo se permiten letras y numeros";
            this.Lbl_WARNING3.Visible = false;
            // 
            // Lbl_WARNING4
            // 
            this.Lbl_WARNING4.AutoSize = true;
            this.Lbl_WARNING4.Enabled = false;
            this.Lbl_WARNING4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING4.Location = new System.Drawing.Point(187, 212);
            this.Lbl_WARNING4.Name = "Lbl_WARNING4";
            this.Lbl_WARNING4.Size = new System.Drawing.Size(171, 13);
            this.Lbl_WARNING4.TabIndex = 33;
            this.Lbl_WARNING4.Text = "Fomato: algo.algo@algo.com";
            this.Lbl_WARNING4.Visible = false;
            // 
            // Lbl_WARNING5
            // 
            this.Lbl_WARNING5.AutoSize = true;
            this.Lbl_WARNING5.Enabled = false;
            this.Lbl_WARNING5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING5.Location = new System.Drawing.Point(156, 261);
            this.Lbl_WARNING5.Name = "Lbl_WARNING5";
            this.Lbl_WARNING5.Size = new System.Drawing.Size(234, 13);
            this.Lbl_WARNING5.TabIndex = 34;
            this.Lbl_WARNING5.Text = "Solo se permiten Mayusculas y Numeros";
            this.Lbl_WARNING5.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 487);
            this.Controls.Add(this.Lbl_WARNING5);
            this.Controls.Add(this.Lbl_WARNING4);
            this.Controls.Add(this.Lbl_WARNING3);
            this.Controls.Add(this.Lbl_WARNING2);
            this.Controls.Add(this.Lbl_WARNING);
            this.Controls.Add(this.BTN_REGISTER);
            this.Controls.Add(this.DTP_FNACIMIENTO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CB_ROL);
            this.Controls.Add(this.CB_NUMCAJA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_PSW);
            this.Controls.Add(this.TXT_USER);
            this.Controls.Add(this.TXT_CURP);
            this.Controls.Add(this.TXT_EMAIL);
            this.Controls.Add(this.TXT_NAME);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Primer Registrro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_PSW;
        private System.Windows.Forms.TextBox TXT_USER;
        private System.Windows.Forms.TextBox TXT_CURP;
        private System.Windows.Forms.TextBox TXT_EMAIL;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_ROL;
        private System.Windows.Forms.ComboBox CB_NUMCAJA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_FNACIMIENTO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_REGISTER;
        private System.Windows.Forms.Label Lbl_WARNING;
        private System.Windows.Forms.Label Lbl_WARNING2;
        private System.Windows.Forms.Label Lbl_WARNING3;
        private System.Windows.Forms.Label Lbl_WARNING4;
        private System.Windows.Forms.Label Lbl_WARNING5;
    }
}