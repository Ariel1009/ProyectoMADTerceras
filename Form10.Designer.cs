
namespace ProyectoMADTerceras
{
    partial class Form10
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DGV_VENTAS = new System.Windows.Forms.DataGridView();
            this.CB_NUMCAJA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_INICIO = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_VENTA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_SUBTOTAL = new System.Windows.Forms.Label();
            this.LBL_TOTAL = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_FECHA = new System.Windows.Forms.TextBox();
            this.DTP_FIN = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VENTAS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DGV_VENTAS
            // 
            this.DGV_VENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VENTAS.Location = new System.Drawing.Point(64, 240);
            this.DGV_VENTAS.Name = "DGV_VENTAS";
            this.DGV_VENTAS.ReadOnly = true;
            this.DGV_VENTAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_VENTAS.Size = new System.Drawing.Size(721, 225);
            this.DGV_VENTAS.TabIndex = 0;
            this.DGV_VENTAS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_VENTAS_CellContentClick);
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
            this.CB_NUMCAJA.Location = new System.Drawing.Point(322, 41);
            this.CB_NUMCAJA.Name = "CB_NUMCAJA";
            this.CB_NUMCAJA.Size = new System.Drawing.Size(121, 27);
            this.CB_NUMCAJA.TabIndex = 49;
            this.CB_NUMCAJA.SelectedIndexChanged += new System.EventHandler(this.CB_NUMCAJA_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Caja:";
            // 
            // DTP_INICIO
            // 
            this.DTP_INICIO.Location = new System.Drawing.Point(548, 41);
            this.DTP_INICIO.Name = "DTP_INICIO";
            this.DTP_INICIO.Size = new System.Drawing.Size(200, 27);
            this.DTP_INICIO.TabIndex = 50;
            this.DTP_INICIO.ValueChanged += new System.EventHandler(this.DTP_INICIO_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Numero de venta:";
            // 
            // TXT_VENTA
            // 
            this.TXT_VENTA.Location = new System.Drawing.Point(155, 44);
            this.TXT_VENTA.Name = "TXT_VENTA";
            this.TXT_VENTA.Size = new System.Drawing.Size(100, 27);
            this.TXT_VENTA.TabIndex = 53;
            this.TXT_VENTA.TextChanged += new System.EventHandler(this.TXT_VENTA_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTP_FIN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DTP_INICIO);
            this.groupBox1.Controls.Add(this.TXT_VENTA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CB_NUMCAJA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 150);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Subtotal:   $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Total:    $";
            // 
            // LBL_SUBTOTAL
            // 
            this.LBL_SUBTOTAL.AutoSize = true;
            this.LBL_SUBTOTAL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SUBTOTAL.Location = new System.Drawing.Point(488, 544);
            this.LBL_SUBTOTAL.Name = "LBL_SUBTOTAL";
            this.LBL_SUBTOTAL.Size = new System.Drawing.Size(51, 25);
            this.LBL_SUBTOTAL.TabIndex = 56;
            this.LBL_SUBTOTAL.Text = "0.00";
            // 
            // LBL_TOTAL
            // 
            this.LBL_TOTAL.AutoSize = true;
            this.LBL_TOTAL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TOTAL.Location = new System.Drawing.Point(488, 575);
            this.LBL_TOTAL.Name = "LBL_TOTAL";
            this.LBL_TOTAL.Size = new System.Drawing.Size(51, 25);
            this.LBL_TOTAL.TabIndex = 57;
            this.LBL_TOTAL.Text = "0.00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenuItem,
            this.reciboToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 27);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackMenuItem
            // 
            this.BackMenuItem.Name = "BackMenuItem";
            this.BackMenuItem.Size = new System.Drawing.Size(53, 23);
            this.BackMenuItem.Text = "Back";
            this.BackMenuItem.Click += new System.EventHandler(this.BackMenuItem_Click);
            // 
            // reciboToolStripMenuItem
            // 
            this.reciboToolStripMenuItem.Name = "reciboToolStripMenuItem";
            this.reciboToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.reciboToolStripMenuItem.Text = "Recibo";
            this.reciboToolStripMenuItem.Click += new System.EventHandler(this.reciboToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(252, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 54;
            this.label5.Text = "Fecha:";
            // 
            // TXT_FECHA
            // 
            this.TXT_FECHA.Enabled = false;
            this.TXT_FECHA.Location = new System.Drawing.Point(313, 497);
            this.TXT_FECHA.Name = "TXT_FECHA";
            this.TXT_FECHA.Size = new System.Drawing.Size(324, 27);
            this.TXT_FECHA.TabIndex = 59;
            // 
            // DTP_FIN
            // 
            this.DTP_FIN.Location = new System.Drawing.Point(548, 74);
            this.DTP_FIN.Name = "DTP_FIN";
            this.DTP_FIN.Size = new System.Drawing.Size(200, 27);
            this.DTP_FIN.TabIndex = 54;
            this.DTP_FIN.ValueChanged += new System.EventHandler(this.DTP_FIN_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Fecha Fin:";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 631);
            this.Controls.Add(this.TXT_FECHA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBL_TOTAL);
            this.Controls.Add(this.LBL_SUBTOTAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_VENTAS);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form10";
            this.Text = "Consulta de ventas";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VENTAS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView DGV_VENTAS;
        private System.Windows.Forms.ComboBox CB_NUMCAJA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP_INICIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_VENTA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_SUBTOTAL;
        private System.Windows.Forms.Label LBL_TOTAL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciboToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_FECHA;
        private System.Windows.Forms.DateTimePicker DTP_FIN;
        private System.Windows.Forms.Label label7;
    }
}