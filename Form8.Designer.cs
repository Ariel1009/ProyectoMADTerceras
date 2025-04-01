
namespace ProyectoMADTerceras
{
    partial class Form8
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
            this.IngresarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBOX_FIJO = new System.Windows.Forms.CheckBox();
            this.CBOX_VARIANTE = new System.Windows.Forms.CheckBox();
            this.DTP_FIN = new System.Windows.Forms.DateTimePicker();
            this.DTP_INICIO = new System.Windows.Forms.DateTimePicker();
            this.TXT_MONTO = new System.Windows.Forms.TextBox();
            this.TXT_CONCEPT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_DESCUENTOS = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DESCUENTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.IngresarMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 27);
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
            // IngresarMenuItem
            // 
            this.IngresarMenuItem.Name = "IngresarMenuItem";
            this.IngresarMenuItem.Size = new System.Drawing.Size(80, 23);
            this.IngresarMenuItem.Text = "Ingresar";
            this.IngresarMenuItem.Click += new System.EventHandler(this.IngresarMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBOX_FIJO);
            this.groupBox1.Controls.Add(this.CBOX_VARIANTE);
            this.groupBox1.Location = new System.Drawing.Point(377, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // CBOX_FIJO
            // 
            this.CBOX_FIJO.AutoSize = true;
            this.CBOX_FIJO.Location = new System.Drawing.Point(21, 22);
            this.CBOX_FIJO.Name = "CBOX_FIJO";
            this.CBOX_FIJO.Size = new System.Drawing.Size(54, 23);
            this.CBOX_FIJO.TabIndex = 10;
            this.CBOX_FIJO.Text = "Fijo";
            this.CBOX_FIJO.UseVisualStyleBackColor = true;
            // 
            // CBOX_VARIANTE
            // 
            this.CBOX_VARIANTE.AutoSize = true;
            this.CBOX_VARIANTE.Location = new System.Drawing.Point(21, 62);
            this.CBOX_VARIANTE.Name = "CBOX_VARIANTE";
            this.CBOX_VARIANTE.Size = new System.Drawing.Size(86, 23);
            this.CBOX_VARIANTE.TabIndex = 11;
            this.CBOX_VARIANTE.Text = "Variante";
            this.CBOX_VARIANTE.UseVisualStyleBackColor = true;
            // 
            // DTP_FIN
            // 
            this.DTP_FIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FIN.Location = new System.Drawing.Point(381, 179);
            this.DTP_FIN.Name = "DTP_FIN";
            this.DTP_FIN.Size = new System.Drawing.Size(129, 27);
            this.DTP_FIN.TabIndex = 20;
            // 
            // DTP_INICIO
            // 
            this.DTP_INICIO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_INICIO.Location = new System.Drawing.Point(137, 179);
            this.DTP_INICIO.Name = "DTP_INICIO";
            this.DTP_INICIO.Size = new System.Drawing.Size(129, 27);
            this.DTP_INICIO.TabIndex = 19;
            // 
            // TXT_MONTO
            // 
            this.TXT_MONTO.Location = new System.Drawing.Point(138, 98);
            this.TXT_MONTO.Name = "TXT_MONTO";
            this.TXT_MONTO.Size = new System.Drawing.Size(89, 27);
            this.TXT_MONTO.TabIndex = 18;
            // 
            // TXT_CONCEPT
            // 
            this.TXT_CONCEPT.Location = new System.Drawing.Point(121, 54);
            this.TXT_CONCEPT.Name = "TXT_CONCEPT";
            this.TXT_CONCEPT.Size = new System.Drawing.Size(175, 27);
            this.TXT_CONCEPT.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha de inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha de fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Monto:      $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Concepto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descuentos";
            // 
            // DGV_DESCUENTOS
            // 
            this.DGV_DESCUENTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DESCUENTOS.Location = new System.Drawing.Point(39, 278);
            this.DGV_DESCUENTOS.Name = "DGV_DESCUENTOS";
            this.DGV_DESCUENTOS.Size = new System.Drawing.Size(445, 209);
            this.DGV_DESCUENTOS.TabIndex = 22;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 515);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_DESCUENTOS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTP_FIN);
            this.Controls.Add(this.DTP_INICIO);
            this.Controls.Add(this.TXT_MONTO);
            this.Controls.Add(this.TXT_CONCEPT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form8";
            this.Text = "Descuento";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DESCUENTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IngresarMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBOX_FIJO;
        private System.Windows.Forms.CheckBox CBOX_VARIANTE;
        private System.Windows.Forms.DateTimePicker DTP_FIN;
        private System.Windows.Forms.DateTimePicker DTP_INICIO;
        private System.Windows.Forms.TextBox TXT_MONTO;
        private System.Windows.Forms.TextBox TXT_CONCEPT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_DESCUENTOS;
    }
}