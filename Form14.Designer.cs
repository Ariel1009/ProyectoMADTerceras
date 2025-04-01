
namespace ProyectoMADTerceras
{
    partial class Form14
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
            this.CBOX_AGOTADOS = new System.Windows.Forms.CheckBox();
            this.CB_DEPTOS = new System.Windows.Forms.ComboBox();
            this.TXT_EXMINIMA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_REPORTEINVENTARIO = new System.Windows.Forms.DataGridView();
            this.CBOX_MERMA = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_REPORTEINVENTARIO)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 27);
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
            this.groupBox1.Controls.Add(this.CBOX_MERMA);
            this.groupBox1.Controls.Add(this.CBOX_AGOTADOS);
            this.groupBox1.Controls.Add(this.CB_DEPTOS);
            this.groupBox1.Controls.Add(this.TXT_EXMINIMA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // CBOX_AGOTADOS
            // 
            this.CBOX_AGOTADOS.AutoSize = true;
            this.CBOX_AGOTADOS.Location = new System.Drawing.Point(90, 190);
            this.CBOX_AGOTADOS.Name = "CBOX_AGOTADOS";
            this.CBOX_AGOTADOS.Size = new System.Drawing.Size(95, 23);
            this.CBOX_AGOTADOS.TabIndex = 8;
            this.CBOX_AGOTADOS.Text = "Agotados";
            this.CBOX_AGOTADOS.UseVisualStyleBackColor = true;
            this.CBOX_AGOTADOS.CheckedChanged += new System.EventHandler(this.CBOX_AGOTADOS_CheckedChanged);
            // 
            // CB_DEPTOS
            // 
            this.CB_DEPTOS.FormattingEnabled = true;
            this.CB_DEPTOS.Location = new System.Drawing.Point(157, 43);
            this.CB_DEPTOS.Name = "CB_DEPTOS";
            this.CB_DEPTOS.Size = new System.Drawing.Size(121, 27);
            this.CB_DEPTOS.TabIndex = 7;
            this.CB_DEPTOS.SelectedIndexChanged += new System.EventHandler(this.CB_DEPTOS_SelectedIndexChanged);
            // 
            // TXT_EXMINIMA
            // 
            this.TXT_EXMINIMA.Location = new System.Drawing.Point(157, 142);
            this.TXT_EXMINIMA.Name = "TXT_EXMINIMA";
            this.TXT_EXMINIMA.Size = new System.Drawing.Size(121, 27);
            this.TXT_EXMINIMA.TabIndex = 5;
            this.TXT_EXMINIMA.TextChanged += new System.EventHandler(this.TXT_EXMINIMA_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Existencia Minima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamentos:";
            // 
            // DGV_REPORTEINVENTARIO
            // 
            this.DGV_REPORTEINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_REPORTEINVENTARIO.Location = new System.Drawing.Point(336, 57);
            this.DGV_REPORTEINVENTARIO.Name = "DGV_REPORTEINVENTARIO";
            this.DGV_REPORTEINVENTARIO.ReadOnly = true;
            this.DGV_REPORTEINVENTARIO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_REPORTEINVENTARIO.Size = new System.Drawing.Size(275, 230);
            this.DGV_REPORTEINVENTARIO.TabIndex = 3;
            // 
            // CBOX_MERMA
            // 
            this.CBOX_MERMA.AutoSize = true;
            this.CBOX_MERMA.Location = new System.Drawing.Point(90, 93);
            this.CBOX_MERMA.Name = "CBOX_MERMA";
            this.CBOX_MERMA.Size = new System.Drawing.Size(76, 23);
            this.CBOX_MERMA.TabIndex = 9;
            this.CBOX_MERMA.Text = "Merma";
            this.CBOX_MERMA.UseVisualStyleBackColor = true;
            this.CBOX_MERMA.CheckedChanged += new System.EventHandler(this.CBOX_MERMA_CheckedChanged);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_REPORTEINVENTARIO);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form14";
            this.Text = "Reporte Inventario";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_REPORTEINVENTARIO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CBOX_AGOTADOS;
        private System.Windows.Forms.ComboBox CB_DEPTOS;
        private System.Windows.Forms.TextBox TXT_EXMINIMA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_REPORTEINVENTARIO;
        private System.Windows.Forms.CheckBox CBOX_MERMA;
    }
}