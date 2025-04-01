
namespace ProyectoMADTerceras
{
    partial class Form11
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
            this.DGV_DEVPROC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_VENTA = new System.Windows.Forms.TextBox();
            this.TXT_CANTDEV = new System.Windows.Forms.TextBox();
            this.TXT_MOTIVO = new System.Windows.Forms.TextBox();
            this.CBOX_BUENA = new System.Windows.Forms.CheckBox();
            this.CBOX_MALA = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_CAMBIO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DEVPROC)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_DEVPROC
            // 
            this.DGV_DEVPROC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DEVPROC.Location = new System.Drawing.Point(354, 114);
            this.DGV_DEVPROC.Name = "DGV_DEVPROC";
            this.DGV_DEVPROC.ReadOnly = true;
            this.DGV_DEVPROC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DEVPROC.Size = new System.Drawing.Size(374, 240);
            this.DGV_DEVPROC.TabIndex = 0;
            this.DGV_DEVPROC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DEVPROC_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad a devolver:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivo de devolucion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Integridad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de venta:";
            // 
            // TXT_VENTA
            // 
            this.TXT_VENTA.Location = new System.Drawing.Point(166, 78);
            this.TXT_VENTA.Name = "TXT_VENTA";
            this.TXT_VENTA.Size = new System.Drawing.Size(152, 27);
            this.TXT_VENTA.TabIndex = 5;
            this.TXT_VENTA.TextChanged += new System.EventHandler(this.TXT_VENTA_TextChanged);
            // 
            // TXT_CANTDEV
            // 
            this.TXT_CANTDEV.Location = new System.Drawing.Point(184, 122);
            this.TXT_CANTDEV.Name = "TXT_CANTDEV";
            this.TXT_CANTDEV.Size = new System.Drawing.Size(134, 27);
            this.TXT_CANTDEV.TabIndex = 6;
            // 
            // TXT_MOTIVO
            // 
            this.TXT_MOTIVO.Location = new System.Drawing.Point(26, 196);
            this.TXT_MOTIVO.Multiline = true;
            this.TXT_MOTIVO.Name = "TXT_MOTIVO";
            this.TXT_MOTIVO.Size = new System.Drawing.Size(292, 108);
            this.TXT_MOTIVO.TabIndex = 7;
            // 
            // CBOX_BUENA
            // 
            this.CBOX_BUENA.AutoSize = true;
            this.CBOX_BUENA.Location = new System.Drawing.Point(118, 331);
            this.CBOX_BUENA.Name = "CBOX_BUENA";
            this.CBOX_BUENA.Size = new System.Drawing.Size(71, 23);
            this.CBOX_BUENA.TabIndex = 8;
            this.CBOX_BUENA.Text = "Buena";
            this.CBOX_BUENA.UseVisualStyleBackColor = true;
            // 
            // CBOX_MALA
            // 
            this.CBOX_MALA.AutoSize = true;
            this.CBOX_MALA.Location = new System.Drawing.Point(207, 331);
            this.CBOX_MALA.Name = "CBOX_MALA";
            this.CBOX_MALA.Size = new System.Drawing.Size(60, 23);
            this.CBOX_MALA.TabIndex = 9;
            this.CBOX_MALA.Text = "Mala";
            this.CBOX_MALA.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.devolucionToolStripMenuItem,
            this.notaDeCreditoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 27);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            this.devolucionToolStripMenuItem.Click += new System.EventHandler(this.devolucionToolStripMenuItem_Click);
            // 
            // notaDeCreditoToolStripMenuItem
            // 
            this.notaDeCreditoToolStripMenuItem.Name = "notaDeCreditoToolStripMenuItem";
            this.notaDeCreditoToolStripMenuItem.Size = new System.Drawing.Size(132, 23);
            this.notaDeCreditoToolStripMenuItem.Text = "Nota de Credito";
            this.notaDeCreditoToolStripMenuItem.Click += new System.EventHandler(this.notaDeCreditoToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cambio Devuelto:   $";
            // 
            // TXT_CAMBIO
            // 
            this.TXT_CAMBIO.Location = new System.Drawing.Point(556, 72);
            this.TXT_CAMBIO.Name = "TXT_CAMBIO";
            this.TXT_CAMBIO.ReadOnly = true;
            this.TXT_CAMBIO.Size = new System.Drawing.Size(129, 27);
            this.TXT_CAMBIO.TabIndex = 12;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 381);
            this.Controls.Add(this.TXT_CAMBIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBOX_MALA);
            this.Controls.Add(this.CBOX_BUENA);
            this.Controls.Add(this.TXT_MOTIVO);
            this.Controls.Add(this.TXT_CANTDEV);
            this.Controls.Add(this.TXT_VENTA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_DEVPROC);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form11";
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DEVPROC)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_DEVPROC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_VENTA;
        private System.Windows.Forms.TextBox TXT_CANTDEV;
        private System.Windows.Forms.TextBox TXT_MOTIVO;
        private System.Windows.Forms.CheckBox CBOX_BUENA;
        private System.Windows.Forms.CheckBox CBOX_MALA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDeCreditoToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_CAMBIO;
    }
}