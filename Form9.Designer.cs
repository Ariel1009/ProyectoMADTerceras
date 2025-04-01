
namespace ProyectoMADTerceras
{
    partial class Form9
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
            this.VentaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBOX_ACTIVAR2 = new System.Windows.Forms.CheckBox();
            this.CBOX_ACTIVAR = new System.Windows.Forms.CheckBox();
            this.TXT_CANTIDAD = new System.Windows.Forms.TextBox();
            this.BTN_AGREGARCARRITO = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_NAMEPRODUC = new System.Windows.Forms.TextBox();
            this.TXT_CODEPRODUCT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_PRODUCTO = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_CANTPRODUCT = new System.Windows.Forms.TextBox();
            this.DGV_CARRITO = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_QUITARCARRITO = new System.Windows.Forms.Button();
            this.CB_METODOS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT__MONTOPA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_METODOS = new System.Windows.Forms.DataGridView();
            this.BTN_AGREGARMETODO = new System.Windows.Forms.Button();
            this.BTN_QUITARMETODO = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LBL_CANTIDAD1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_CANTIDAD2 = new System.Windows.Forms.Label();
            this.LBL_CANTIDAD3 = new System.Windows.Forms.Label();
            this.LBL_CANTIDAD4 = new System.Windows.Forms.Label();
            this.LBL_CANTIDAD5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LBL_NAMEUSER = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LBL_NUMCAJA = new System.Windows.Forms.Label();
            this.DTP_FECHAVENTA = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTO)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CARRITO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_METODOS)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.VentaMenuItem,
            this.TicketMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(685, 29);
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
            // VentaMenuItem
            // 
            this.VentaMenuItem.Name = "VentaMenuItem";
            this.VentaMenuItem.Size = new System.Drawing.Size(61, 23);
            this.VentaMenuItem.Text = "Venta";
            this.VentaMenuItem.Click += new System.EventHandler(this.VentaMenuItem_Click);
            // 
            // TicketMenuItem
            // 
            this.TicketMenuItem.Name = "TicketMenuItem";
            this.TicketMenuItem.Size = new System.Drawing.Size(63, 23);
            this.TicketMenuItem.Text = "Ticket";
            this.TicketMenuItem.Click += new System.EventHandler(this.TicketMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBOX_ACTIVAR2);
            this.groupBox1.Controls.Add(this.CBOX_ACTIVAR);
            this.groupBox1.Controls.Add(this.TXT_CANTIDAD);
            this.groupBox1.Controls.Add(this.BTN_AGREGARCARRITO);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TXT_NAMEPRODUC);
            this.groupBox1.Controls.Add(this.TXT_CODEPRODUCT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DGV_PRODUCTO);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 294);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Producto";
            // 
            // CBOX_ACTIVAR2
            // 
            this.CBOX_ACTIVAR2.AutoSize = true;
            this.CBOX_ACTIVAR2.Location = new System.Drawing.Point(285, 66);
            this.CBOX_ACTIVAR2.Name = "CBOX_ACTIVAR2";
            this.CBOX_ACTIVAR2.Size = new System.Drawing.Size(15, 14);
            this.CBOX_ACTIVAR2.TabIndex = 29;
            this.CBOX_ACTIVAR2.UseVisualStyleBackColor = true;
            this.CBOX_ACTIVAR2.CheckedChanged += new System.EventHandler(this.CBOX_ACTIVAR2_CheckedChanged);
            // 
            // CBOX_ACTIVAR
            // 
            this.CBOX_ACTIVAR.AutoSize = true;
            this.CBOX_ACTIVAR.Location = new System.Drawing.Point(285, 31);
            this.CBOX_ACTIVAR.Name = "CBOX_ACTIVAR";
            this.CBOX_ACTIVAR.Size = new System.Drawing.Size(15, 14);
            this.CBOX_ACTIVAR.TabIndex = 28;
            this.CBOX_ACTIVAR.UseVisualStyleBackColor = true;
            this.CBOX_ACTIVAR.CheckedChanged += new System.EventHandler(this.CBOX_ACTIVAR_CheckedChanged);
            // 
            // TXT_CANTIDAD
            // 
            this.TXT_CANTIDAD.Location = new System.Drawing.Point(139, 91);
            this.TXT_CANTIDAD.Name = "TXT_CANTIDAD";
            this.TXT_CANTIDAD.Size = new System.Drawing.Size(100, 26);
            this.TXT_CANTIDAD.TabIndex = 27;
            // 
            // BTN_AGREGARCARRITO
            // 
            this.BTN_AGREGARCARRITO.Location = new System.Drawing.Point(284, 126);
            this.BTN_AGREGARCARRITO.Name = "BTN_AGREGARCARRITO";
            this.BTN_AGREGARCARRITO.Size = new System.Drawing.Size(24, 24);
            this.BTN_AGREGARCARRITO.TabIndex = 21;
            this.BTN_AGREGARCARRITO.Text = "+";
            this.BTN_AGREGARCARRITO.UseVisualStyleBackColor = true;
            this.BTN_AGREGARCARRITO.Click += new System.EventHandler(this.BTN_AGREGARCARRITO_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Cantidad:";
            // 
            // TXT_NAMEPRODUC
            // 
            this.TXT_NAMEPRODUC.Enabled = false;
            this.TXT_NAMEPRODUC.Location = new System.Drawing.Point(139, 59);
            this.TXT_NAMEPRODUC.Name = "TXT_NAMEPRODUC";
            this.TXT_NAMEPRODUC.Size = new System.Drawing.Size(140, 26);
            this.TXT_NAMEPRODUC.TabIndex = 15;
            this.TXT_NAMEPRODUC.TextChanged += new System.EventHandler(this.TXT_NAMEPRODUC_TextChanged);
            // 
            // TXT_CODEPRODUCT
            // 
            this.TXT_CODEPRODUCT.Enabled = false;
            this.TXT_CODEPRODUCT.Location = new System.Drawing.Point(139, 25);
            this.TXT_CODEPRODUCT.Name = "TXT_CODEPRODUCT";
            this.TXT_CODEPRODUCT.Size = new System.Drawing.Size(140, 26);
            this.TXT_CODEPRODUCT.TabIndex = 14;
            this.TXT_CODEPRODUCT.TextChanged += new System.EventHandler(this.TXT_CODEPRODUCT_TextChanged);
            this.TXT_CODEPRODUCT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_CODEPRODUCT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo producto:";
            // 
            // DGV_PRODUCTO
            // 
            this.DGV_PRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTO.Location = new System.Drawing.Point(18, 126);
            this.DGV_PRODUCTO.Name = "DGV_PRODUCTO";
            this.DGV_PRODUCTO.ReadOnly = true;
            this.DGV_PRODUCTO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTO.Size = new System.Drawing.Size(261, 142);
            this.DGV_PRODUCTO.TabIndex = 11;
            this.DGV_PRODUCTO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PRODUCTO_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_CANTPRODUCT);
            this.groupBox2.Controls.Add(this.DGV_CARRITO);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BTN_QUITARCARRITO);
            this.groupBox2.Location = new System.Drawing.Point(24, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 280);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrito";
            // 
            // TXT_CANTPRODUCT
            // 
            this.TXT_CANTPRODUCT.Enabled = false;
            this.TXT_CANTPRODUCT.Location = new System.Drawing.Point(178, 32);
            this.TXT_CANTPRODUCT.Name = "TXT_CANTPRODUCT";
            this.TXT_CANTPRODUCT.Size = new System.Drawing.Size(100, 26);
            this.TXT_CANTPRODUCT.TabIndex = 25;
            // 
            // DGV_CARRITO
            // 
            this.DGV_CARRITO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CARRITO.Location = new System.Drawing.Point(15, 72);
            this.DGV_CARRITO.Name = "DGV_CARRITO";
            this.DGV_CARRITO.Size = new System.Drawing.Size(233, 192);
            this.DGV_CARRITO.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cantidad de productos:";
            // 
            // BTN_QUITARCARRITO
            // 
            this.BTN_QUITARCARRITO.Location = new System.Drawing.Point(254, 75);
            this.BTN_QUITARCARRITO.Name = "BTN_QUITARCARRITO";
            this.BTN_QUITARCARRITO.Size = new System.Drawing.Size(24, 24);
            this.BTN_QUITARCARRITO.TabIndex = 22;
            this.BTN_QUITARCARRITO.Text = "-";
            this.BTN_QUITARCARRITO.UseVisualStyleBackColor = true;
            this.BTN_QUITARCARRITO.Click += new System.EventHandler(this.BTN_QUITARCARRITO_Click);
            // 
            // CB_METODOS
            // 
            this.CB_METODOS.FormattingEnabled = true;
            this.CB_METODOS.Location = new System.Drawing.Point(151, 27);
            this.CB_METODOS.Name = "CB_METODOS";
            this.CB_METODOS.Size = new System.Drawing.Size(148, 26);
            this.CB_METODOS.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Metodos de Pago:";
            // 
            // TXT__MONTOPA
            // 
            this.TXT__MONTOPA.Location = new System.Drawing.Point(151, 70);
            this.TXT__MONTOPA.Name = "TXT__MONTOPA";
            this.TXT__MONTOPA.Size = new System.Drawing.Size(100, 26);
            this.TXT__MONTOPA.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Monto:   $";
            // 
            // DGV_METODOS
            // 
            this.DGV_METODOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_METODOS.Location = new System.Drawing.Point(30, 102);
            this.DGV_METODOS.Name = "DGV_METODOS";
            this.DGV_METODOS.Size = new System.Drawing.Size(233, 192);
            this.DGV_METODOS.TabIndex = 26;
            // 
            // BTN_AGREGARMETODO
            // 
            this.BTN_AGREGARMETODO.Location = new System.Drawing.Point(269, 102);
            this.BTN_AGREGARMETODO.Name = "BTN_AGREGARMETODO";
            this.BTN_AGREGARMETODO.Size = new System.Drawing.Size(24, 24);
            this.BTN_AGREGARMETODO.TabIndex = 26;
            this.BTN_AGREGARMETODO.Text = "+";
            this.BTN_AGREGARMETODO.UseVisualStyleBackColor = true;
            this.BTN_AGREGARMETODO.Click += new System.EventHandler(this.BTN_AGREGARMETODO_Click);
            // 
            // BTN_QUITARMETODO
            // 
            this.BTN_QUITARMETODO.Location = new System.Drawing.Point(269, 132);
            this.BTN_QUITARMETODO.Name = "BTN_QUITARMETODO";
            this.BTN_QUITARMETODO.Size = new System.Drawing.Size(24, 24);
            this.BTN_QUITARMETODO.TabIndex = 27;
            this.BTN_QUITARMETODO.Text = "-";
            this.BTN_QUITARMETODO.UseVisualStyleBackColor = true;
            this.BTN_QUITARMETODO.Click += new System.EventHandler(this.BTN_QUITARMETODO_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV_METODOS);
            this.groupBox3.Controls.Add(this.BTN_AGREGARMETODO);
            this.groupBox3.Controls.Add(this.CB_METODOS);
            this.groupBox3.Controls.Add(this.BTN_QUITARMETODO);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TXT__MONTOPA);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.LBL_CANTIDAD1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(354, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 353);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metodos de pago:";
            // 
            // LBL_CANTIDAD1
            // 
            this.LBL_CANTIDAD1.AutoSize = true;
            this.LBL_CANTIDAD1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CANTIDAD1.Location = new System.Drawing.Point(181, 314);
            this.LBL_CANTIDAD1.Name = "LBL_CANTIDAD1";
            this.LBL_CANTIDAD1.Size = new System.Drawing.Size(82, 23);
            this.LBL_CANTIDAD1.TabIndex = 34;
            this.LBL_CANTIDAD1.Text = "............";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Falta por pagar: $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Subtotal:  $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 622);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total:  $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(405, 686);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Cambio:  $";
            // 
            // LBL_CANTIDAD2
            // 
            this.LBL_CANTIDAD2.AutoSize = true;
            this.LBL_CANTIDAD2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CANTIDAD2.Location = new System.Drawing.Point(505, 536);
            this.LBL_CANTIDAD2.Name = "LBL_CANTIDAD2";
            this.LBL_CANTIDAD2.Size = new System.Drawing.Size(94, 23);
            this.LBL_CANTIDAD2.TabIndex = 35;
            this.LBL_CANTIDAD2.Text = "..............";
            // 
            // LBL_CANTIDAD3
            // 
            this.LBL_CANTIDAD3.AutoSize = true;
            this.LBL_CANTIDAD3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CANTIDAD3.Location = new System.Drawing.Point(506, 686);
            this.LBL_CANTIDAD3.Name = "LBL_CANTIDAD3";
            this.LBL_CANTIDAD3.Size = new System.Drawing.Size(82, 23);
            this.LBL_CANTIDAD3.TabIndex = 36;
            this.LBL_CANTIDAD3.Text = "............";
            // 
            // LBL_CANTIDAD4
            // 
            this.LBL_CANTIDAD4.AutoSize = true;
            this.LBL_CANTIDAD4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CANTIDAD4.Location = new System.Drawing.Point(507, 622);
            this.LBL_CANTIDAD4.Name = "LBL_CANTIDAD4";
            this.LBL_CANTIDAD4.Size = new System.Drawing.Size(118, 23);
            this.LBL_CANTIDAD4.TabIndex = 37;
            this.LBL_CANTIDAD4.Text = "..................";
            // 
            // LBL_CANTIDAD5
            // 
            this.LBL_CANTIDAD5.AutoSize = true;
            this.LBL_CANTIDAD5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CANTIDAD5.Location = new System.Drawing.Point(506, 581);
            this.LBL_CANTIDAD5.Name = "LBL_CANTIDAD5";
            this.LBL_CANTIDAD5.Size = new System.Drawing.Size(112, 23);
            this.LBL_CANTIDAD5.TabIndex = 39;
            this.LBL_CANTIDAD5.Text = ".................";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(358, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 23);
            this.label12.TabIndex = 38;
            this.label12.Text = "Usted Ahorro:  $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "Usuario:";
            // 
            // LBL_NAMEUSER
            // 
            this.LBL_NAMEUSER.AutoSize = true;
            this.LBL_NAMEUSER.Location = new System.Drawing.Point(159, 66);
            this.LBL_NAMEUSER.Name = "LBL_NAMEUSER";
            this.LBL_NAMEUSER.Size = new System.Drawing.Size(134, 18);
            this.LBL_NAMEUSER.TabIndex = 41;
            this.LBL_NAMEUSER.Text = "Nombre del usuario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(394, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 19);
            this.label13.TabIndex = 42;
            this.label13.Text = "Caja:";
            // 
            // LBL_NUMCAJA
            // 
            this.LBL_NUMCAJA.AutoSize = true;
            this.LBL_NUMCAJA.Location = new System.Drawing.Point(452, 66);
            this.LBL_NUMCAJA.Name = "LBL_NUMCAJA";
            this.LBL_NUMCAJA.Size = new System.Drawing.Size(113, 18);
            this.LBL_NUMCAJA.TabIndex = 43;
            this.LBL_NUMCAJA.Text = "Numero de caja";
            // 
            // DTP_FECHAVENTA
            // 
            this.DTP_FECHAVENTA.Location = new System.Drawing.Point(445, 487);
            this.DTP_FECHAVENTA.Name = "DTP_FECHAVENTA";
            this.DTP_FECHAVENTA.Size = new System.Drawing.Size(200, 26);
            this.DTP_FECHAVENTA.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(386, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 18);
            this.label14.TabIndex = 45;
            this.label14.Text = "Fecha:";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 742);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DTP_FECHAVENTA);
            this.Controls.Add(this.LBL_NUMCAJA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LBL_NAMEUSER);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LBL_CANTIDAD5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LBL_CANTIDAD4);
            this.Controls.Add(this.LBL_CANTIDAD3);
            this.Controls.Add(this.LBL_CANTIDAD2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form9";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTO)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CARRITO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_METODOS)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VentaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TicketMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_NAMEPRODUC;
        private System.Windows.Forms.TextBox TXT_CODEPRODUCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_PRODUCTO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_CANTPRODUCT;
        private System.Windows.Forms.DataGridView DGV_CARRITO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_AGREGARCARRITO;
        private System.Windows.Forms.Button BTN_QUITARCARRITO;
        private System.Windows.Forms.ComboBox CB_METODOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT__MONTOPA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_METODOS;
        private System.Windows.Forms.Button BTN_AGREGARMETODO;
        private System.Windows.Forms.Button BTN_QUITARMETODO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_CANTIDAD1;
        private System.Windows.Forms.Label LBL_CANTIDAD2;
        private System.Windows.Forms.Label LBL_CANTIDAD3;
        private System.Windows.Forms.Label LBL_CANTIDAD4;
        private System.Windows.Forms.TextBox TXT_CANTIDAD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox CBOX_ACTIVAR2;
        private System.Windows.Forms.CheckBox CBOX_ACTIVAR;
        private System.Windows.Forms.Label LBL_CANTIDAD5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LBL_NAMEUSER;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LBL_NUMCAJA;
        private System.Windows.Forms.DateTimePicker DTP_FECHAVENTA;
        private System.Windows.Forms.Label label14;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}