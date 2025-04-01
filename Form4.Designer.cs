
namespace ProyectoMADTerceras
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_WARNING5 = new System.Windows.Forms.Label();
            this.Lbl_WARNING4 = new System.Windows.Forms.Label();
            this.Lbl_WARNING3 = new System.Windows.Forms.Label();
            this.Lbl_WARNING2 = new System.Windows.Forms.Label();
            this.Lbl_WARNING = new System.Windows.Forms.Label();
            this.DTP_FNACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_ROL = new System.Windows.Forms.ComboBox();
            this.CB_NUMCAJA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.DGV_USERS = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USERS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.InsertarMenuItem,
            this.ConsultarMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(405, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // InsertarMenuItem
            // 
            this.InsertarMenuItem.Name = "InsertarMenuItem";
            this.InsertarMenuItem.Size = new System.Drawing.Size(76, 23);
            this.InsertarMenuItem.Text = "Insertar";
            this.InsertarMenuItem.Click += new System.EventHandler(this.InsertarMenuItem_Click);
            // 
            // ConsultarMenuItem
            // 
            this.ConsultarMenuItem.Name = "ConsultarMenuItem";
            this.ConsultarMenuItem.Size = new System.Drawing.Size(88, 23);
            this.ConsultarMenuItem.Text = "Consultar";
            this.ConsultarMenuItem.Click += new System.EventHandler(this.ConsultarMenuItem_Click);
            // 
            // Lbl_WARNING5
            // 
            this.Lbl_WARNING5.AutoSize = true;
            this.Lbl_WARNING5.Enabled = false;
            this.Lbl_WARNING5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING5.Location = new System.Drawing.Point(152, 285);
            this.Lbl_WARNING5.Name = "Lbl_WARNING5";
            this.Lbl_WARNING5.Size = new System.Drawing.Size(234, 13);
            this.Lbl_WARNING5.TabIndex = 56;
            this.Lbl_WARNING5.Text = "Solo se permiten Mayusculas y Numeros";
            this.Lbl_WARNING5.Visible = false;
            // 
            // Lbl_WARNING4
            // 
            this.Lbl_WARNING4.AutoSize = true;
            this.Lbl_WARNING4.Enabled = false;
            this.Lbl_WARNING4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING4.Location = new System.Drawing.Point(183, 236);
            this.Lbl_WARNING4.Name = "Lbl_WARNING4";
            this.Lbl_WARNING4.Size = new System.Drawing.Size(171, 13);
            this.Lbl_WARNING4.TabIndex = 55;
            this.Lbl_WARNING4.Text = "Fomato: algo.algo@algo.com";
            this.Lbl_WARNING4.Visible = false;
            // 
            // Lbl_WARNING3
            // 
            this.Lbl_WARNING3.AutoSize = true;
            this.Lbl_WARNING3.Enabled = false;
            this.Lbl_WARNING3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING3.Location = new System.Drawing.Point(172, 186);
            this.Lbl_WARNING3.Name = "Lbl_WARNING3";
            this.Lbl_WARNING3.Size = new System.Drawing.Size(197, 13);
            this.Lbl_WARNING3.TabIndex = 54;
            this.Lbl_WARNING3.Text = "Solo se permiten letras y numeros";
            this.Lbl_WARNING3.Visible = false;
            // 
            // Lbl_WARNING2
            // 
            this.Lbl_WARNING2.AutoSize = true;
            this.Lbl_WARNING2.Enabled = false;
            this.Lbl_WARNING2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING2.Location = new System.Drawing.Point(172, 133);
            this.Lbl_WARNING2.Name = "Lbl_WARNING2";
            this.Lbl_WARNING2.Size = new System.Drawing.Size(197, 13);
            this.Lbl_WARNING2.TabIndex = 53;
            this.Lbl_WARNING2.Text = "Solo se permiten letras y numeros";
            this.Lbl_WARNING2.Visible = false;
            // 
            // Lbl_WARNING
            // 
            this.Lbl_WARNING.AutoSize = true;
            this.Lbl_WARNING.Enabled = false;
            this.Lbl_WARNING.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WARNING.Location = new System.Drawing.Point(202, 84);
            this.Lbl_WARNING.Name = "Lbl_WARNING";
            this.Lbl_WARNING.Size = new System.Drawing.Size(140, 13);
            this.Lbl_WARNING.TabIndex = 52;
            this.Lbl_WARNING.Text = "Solo se permiten Letras";
            this.Lbl_WARNING.Visible = false;
            // 
            // DTP_FNACIMIENTO
            // 
            this.DTP_FNACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FNACIMIENTO.Location = new System.Drawing.Point(217, 402);
            this.DTP_FNACIMIENTO.Name = "DTP_FNACIMIENTO";
            this.DTP_FNACIMIENTO.Size = new System.Drawing.Size(130, 27);
            this.DTP_FNACIMIENTO.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 19);
            this.label8.TabIndex = 49;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // CB_ROL
            // 
            this.CB_ROL.FormattingEnabled = true;
            this.CB_ROL.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.CB_ROL.Location = new System.Drawing.Point(158, 353);
            this.CB_ROL.Name = "CB_ROL";
            this.CB_ROL.Size = new System.Drawing.Size(121, 27);
            this.CB_ROL.TabIndex = 48;
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
            this.CB_NUMCAJA.Location = new System.Drawing.Point(158, 307);
            this.CB_NUMCAJA.Name = "CB_NUMCAJA";
            this.CB_NUMCAJA.Size = new System.Drawing.Size(121, 27);
            this.CB_NUMCAJA.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Caja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Rol:";
            // 
            // TXT_PSW
            // 
            this.TXT_PSW.Location = new System.Drawing.Point(156, 156);
            this.TXT_PSW.Name = "TXT_PSW";
            this.TXT_PSW.Size = new System.Drawing.Size(225, 27);
            this.TXT_PSW.TabIndex = 44;
            // 
            // TXT_USER
            // 
            this.TXT_USER.Location = new System.Drawing.Point(156, 102);
            this.TXT_USER.Name = "TXT_USER";
            this.TXT_USER.Size = new System.Drawing.Size(225, 27);
            this.TXT_USER.TabIndex = 43;
            // 
            // TXT_CURP
            // 
            this.TXT_CURP.Location = new System.Drawing.Point(158, 255);
            this.TXT_CURP.Name = "TXT_CURP";
            this.TXT_CURP.Size = new System.Drawing.Size(225, 27);
            this.TXT_CURP.TabIndex = 42;
            // 
            // TXT_EMAIL
            // 
            this.TXT_EMAIL.Location = new System.Drawing.Point(157, 207);
            this.TXT_EMAIL.Name = "TXT_EMAIL";
            this.TXT_EMAIL.Size = new System.Drawing.Size(225, 27);
            this.TXT_EMAIL.TabIndex = 41;
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(157, 54);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(225, 27);
            this.TXT_NAME.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "CURP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre completo:";
            // 
            // DGV_USERS
            // 
            this.DGV_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_USERS.Location = new System.Drawing.Point(18, 466);
            this.DGV_USERS.Name = "DGV_USERS";
            this.DGV_USERS.Size = new System.Drawing.Size(368, 232);
            this.DGV_USERS.TabIndex = 57;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 718);
            this.Controls.Add(this.DGV_USERS);
            this.Controls.Add(this.Lbl_WARNING5);
            this.Controls.Add(this.Lbl_WARNING4);
            this.Controls.Add(this.Lbl_WARNING3);
            this.Controls.Add(this.Lbl_WARNING2);
            this.Controls.Add(this.Lbl_WARNING);
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
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultarMenuItem;
        private System.Windows.Forms.Label Lbl_WARNING5;
        private System.Windows.Forms.Label Lbl_WARNING4;
        private System.Windows.Forms.Label Lbl_WARNING3;
        private System.Windows.Forms.Label Lbl_WARNING2;
        private System.Windows.Forms.Label Lbl_WARNING;
        private System.Windows.Forms.DateTimePicker DTP_FNACIMIENTO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_ROL;
        private System.Windows.Forms.ComboBox CB_NUMCAJA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.DataGridView DGV_USERS;
    }
}