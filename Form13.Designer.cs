﻿
namespace ProyectoMADTerceras
{
    partial class Form13
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP_FIN = new System.Windows.Forms.DateTimePicker();
            this.DTP_INICIO = new System.Windows.Forms.DateTimePicker();
            this.CB_DEPTOS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_REPORTEVENTAS = new System.Windows.Forms.DataGridView();
            this.CB_NUMCAJA = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_REPORTEVENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 27);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_NUMCAJA);
            this.groupBox1.Controls.Add(this.DTP_FIN);
            this.groupBox1.Controls.Add(this.DTP_INICIO);
            this.groupBox1.Controls.Add(this.CB_DEPTOS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 235);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // DTP_FIN
            // 
            this.DTP_FIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FIN.Location = new System.Drawing.Point(139, 179);
            this.DTP_FIN.Name = "DTP_FIN";
            this.DTP_FIN.Size = new System.Drawing.Size(131, 27);
            this.DTP_FIN.TabIndex = 7;
            this.DTP_FIN.ValueChanged += new System.EventHandler(this.DTP_FIN_ValueChanged);
            // 
            // DTP_INICIO
            // 
            this.DTP_INICIO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_INICIO.Location = new System.Drawing.Point(139, 145);
            this.DTP_INICIO.Name = "DTP_INICIO";
            this.DTP_INICIO.Size = new System.Drawing.Size(131, 27);
            this.DTP_INICIO.TabIndex = 6;
            this.DTP_INICIO.ValueChanged += new System.EventHandler(this.DTP_INICIO_ValueChanged);
            // 
            // CB_DEPTOS
            // 
            this.CB_DEPTOS.FormattingEnabled = true;
            this.CB_DEPTOS.Location = new System.Drawing.Point(149, 91);
            this.CB_DEPTOS.Name = "CB_DEPTOS";
            this.CB_DEPTOS.Size = new System.Drawing.Size(121, 27);
            this.CB_DEPTOS.TabIndex = 5;
            this.CB_DEPTOS.SelectedIndexChanged += new System.EventHandler(this.CB_DEPTOS_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamentos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja:";
            // 
            // DGV_REPORTEVENTAS
            // 
            this.DGV_REPORTEVENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_REPORTEVENTAS.Location = new System.Drawing.Point(331, 52);
            this.DGV_REPORTEVENTAS.Name = "DGV_REPORTEVENTAS";
            this.DGV_REPORTEVENTAS.ReadOnly = true;
            this.DGV_REPORTEVENTAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_REPORTEVENTAS.Size = new System.Drawing.Size(275, 230);
            this.DGV_REPORTEVENTAS.TabIndex = 4;
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
            this.CB_NUMCAJA.Location = new System.Drawing.Point(149, 44);
            this.CB_NUMCAJA.Name = "CB_NUMCAJA";
            this.CB_NUMCAJA.Size = new System.Drawing.Size(121, 27);
            this.CB_NUMCAJA.TabIndex = 48;
            this.CB_NUMCAJA.SelectedIndexChanged += new System.EventHandler(this.CB_NUMCAJA_SelectedIndexChanged);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 308);
            this.Controls.Add(this.DGV_REPORTEVENTAS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form13";
            this.Text = "Reporte Ventas";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_REPORTEVENTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTP_FIN;
        private System.Windows.Forms.DateTimePicker DTP_INICIO;
        private System.Windows.Forms.ComboBox CB_DEPTOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_REPORTEVENTAS;
        private System.Windows.Forms.ComboBox CB_NUMCAJA;
    }
}