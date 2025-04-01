
namespace ProyectoMADTerceras
{
    partial class Form6
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
            this.BackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_DESCUENTO = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_DEPTOS = new System.Windows.Forms.ComboBox();
            this.TXT_REORDEN = new System.Windows.Forms.TextBox();
            this.TXT_EXISTENCIA = new System.Windows.Forms.TextBox();
            this.TXT_COSTO = new System.Windows.Forms.TextBox();
            this.TXT_PRECIO = new System.Windows.Forms.TextBox();
            this.TXT__MEDIDA = new System.Windows.Forms.TextBox();
            this.TXT_PRODUCTO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DGV_PRODUCTOS = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenuItem,
            this.InsertarMenuItem,
            this.consultarToolStripMenuItem,
            this.descuentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackMenuItem
            // 
            this.BackMenuItem.Name = "BackMenuItem";
            this.BackMenuItem.Size = new System.Drawing.Size(53, 23);
            this.BackMenuItem.Text = "Back";
            this.BackMenuItem.Click += new System.EventHandler(this.BackMenuItem_Click);
            // 
            // InsertarMenuItem
            // 
            this.InsertarMenuItem.Name = "InsertarMenuItem";
            this.InsertarMenuItem.Size = new System.Drawing.Size(76, 23);
            this.InsertarMenuItem.Text = "Insertar";
            this.InsertarMenuItem.Click += new System.EventHandler(this.InsertarMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.descuentosToolStripMenuItem.Text = "Descuentos";
            this.descuentosToolStripMenuItem.Click += new System.EventHandler(this.descuentosToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_DESCUENTO);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CB_DEPTOS);
            this.groupBox1.Controls.Add(this.TXT_REORDEN);
            this.groupBox1.Controls.Add(this.TXT_EXISTENCIA);
            this.groupBox1.Controls.Add(this.TXT_COSTO);
            this.groupBox1.Controls.Add(this.TXT_PRECIO);
            this.groupBox1.Controls.Add(this.TXT__MEDIDA);
            this.groupBox1.Controls.Add(this.TXT_PRODUCTO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 433);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // CB_DESCUENTO
            // 
            this.CB_DESCUENTO.FormattingEnabled = true;
            this.CB_DESCUENTO.Location = new System.Drawing.Point(124, 382);
            this.CB_DESCUENTO.Name = "CB_DESCUENTO";
            this.CB_DESCUENTO.Size = new System.Drawing.Size(164, 27);
            this.CB_DESCUENTO.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Descuento:";
            // 
            // CB_DEPTOS
            // 
            this.CB_DEPTOS.FormattingEnabled = true;
            this.CB_DEPTOS.Location = new System.Drawing.Point(146, 326);
            this.CB_DEPTOS.Name = "CB_DEPTOS";
            this.CB_DEPTOS.Size = new System.Drawing.Size(142, 27);
            this.CB_DEPTOS.TabIndex = 13;
            // 
            // TXT_REORDEN
            // 
            this.TXT_REORDEN.Location = new System.Drawing.Point(171, 276);
            this.TXT_REORDEN.Name = "TXT_REORDEN";
            this.TXT_REORDEN.Size = new System.Drawing.Size(117, 27);
            this.TXT_REORDEN.TabIndex = 12;
            // 
            // TXT_EXISTENCIA
            // 
            this.TXT_EXISTENCIA.Location = new System.Drawing.Point(110, 226);
            this.TXT_EXISTENCIA.Name = "TXT_EXISTENCIA";
            this.TXT_EXISTENCIA.Size = new System.Drawing.Size(178, 27);
            this.TXT_EXISTENCIA.TabIndex = 11;
            // 
            // TXT_COSTO
            // 
            this.TXT_COSTO.Location = new System.Drawing.Point(87, 178);
            this.TXT_COSTO.Name = "TXT_COSTO";
            this.TXT_COSTO.Size = new System.Drawing.Size(201, 27);
            this.TXT_COSTO.TabIndex = 10;
            // 
            // TXT_PRECIO
            // 
            this.TXT_PRECIO.Location = new System.Drawing.Point(146, 135);
            this.TXT_PRECIO.Name = "TXT_PRECIO";
            this.TXT_PRECIO.Size = new System.Drawing.Size(142, 27);
            this.TXT_PRECIO.TabIndex = 9;
            // 
            // TXT__MEDIDA
            // 
            this.TXT__MEDIDA.Location = new System.Drawing.Point(171, 87);
            this.TXT__MEDIDA.Name = "TXT__MEDIDA";
            this.TXT__MEDIDA.Size = new System.Drawing.Size(117, 27);
            this.TXT__MEDIDA.TabIndex = 8;
            // 
            // TXT_PRODUCTO
            // 
            this.TXT_PRODUCTO.Location = new System.Drawing.Point(110, 45);
            this.TXT_PRODUCTO.Name = "TXT_PRODUCTO";
            this.TXT_PRODUCTO.Size = new System.Drawing.Size(178, 27);
            this.TXT_PRODUCTO.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Punto de reorden:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Depertamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unidad de medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio unitario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Existencia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 33);
            this.label8.TabIndex = 15;
            this.label8.Text = "Productos";
            // 
            // DGV_PRODUCTOS
            // 
            this.DGV_PRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTOS.Location = new System.Drawing.Point(362, 88);
            this.DGV_PRODUCTOS.Name = "DGV_PRODUCTOS";
            this.DGV_PRODUCTOS.Size = new System.Drawing.Size(368, 388);
            this.DGV_PRODUCTOS.TabIndex = 16;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 499);
            this.Controls.Add(this.DGV_PRODUCTOS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_DESCUENTO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_DEPTOS;
        private System.Windows.Forms.TextBox TXT_REORDEN;
        private System.Windows.Forms.TextBox TXT_EXISTENCIA;
        private System.Windows.Forms.TextBox TXT_COSTO;
        private System.Windows.Forms.TextBox TXT_PRECIO;
        private System.Windows.Forms.TextBox TXT__MEDIDA;
        private System.Windows.Forms.TextBox TXT_PRODUCTO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGV_PRODUCTOS;
    }
}