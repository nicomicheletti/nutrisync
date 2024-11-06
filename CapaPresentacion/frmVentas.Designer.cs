namespace CapaPresentacion
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            btnregistrar = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            btnagregar = new FontAwesome.Sharp.IconButton();
            dgvproducto = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            txtcantidad = new NumericUpDown();
            label11 = new Label();
            label9 = new Label();
            txtstock = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label1 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            txtnombrecliente = new TextBox();
            btnbuscarcli = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label5 = new Label();
            txtdoccliente = new TextBox();
            txtprecio = new TextBox();
            txtidproducto = new TextBox();
            txtproducto = new TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label7 = new Label();
            txtcodigoproducto = new TextBox();
            groupBox3 = new GroupBox();
            label15 = new Label();
            cbimpuesto = new ComboBox();
            txttotalpagar = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtpagacon = new TextBox();
            txtcambio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvproducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnregistrar
            // 
            btnregistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = Color.DodgerBlue;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 30;
            btnregistrar.Location = new Point(1093, 632);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(114, 38);
            btnregistrar.TabIndex = 44;
            btnregistrar.Text = "Registrar";
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(1093, 568);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 42;
            label12.Text = "Cambio:";
            // 
            // btnagregar
            // 
            btnagregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnagregar.IconColor = Color.Green;
            btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregar.Location = new Point(1096, 182);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(108, 90);
            btnagregar.TabIndex = 41;
            btnagregar.Text = "Agregar";
            btnagregar.TextAlign = ContentAlignment.TopCenter;
            btnagregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // dgvproducto
            // 
            dgvproducto.AllowUserToAddRows = false;
            dgvproducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproducto.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, btneliminar });
            dgvproducto.Location = new Point(44, 286);
            dgvproducto.Name = "dgvproducto";
            dgvproducto.ReadOnly = true;
            dgvproducto.RowHeadersWidth = 51;
            dgvproducto.RowTemplate.Height = 29;
            dgvproducto.Size = new Size(1032, 384);
            dgvproducto.TabIndex = 40;
            dgvproducto.CellContentClick += dgvproducto_CellContentClick;
            dgvproducto.CellPainting += dgvproducto_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            IdProducto.Width = 125;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubTotal.HeaderText = "Sub Total";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.MinimumWidth = 6;
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.Resizable = DataGridViewTriState.True;
            btneliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            btneliminar.Width = 40;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(719, 64);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(129, 27);
            txtcantidad.TabIndex = 34;
            txtcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtcantidad.KeyPress += txtcantidad_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(719, 39);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 33;
            label11.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(598, 39);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 32;
            label9.Text = "Stock:";
            // 
            // txtstock
            // 
            txtstock.Location = new Point(599, 64);
            txtstock.Name = "txtstock";
            txtstock.ReadOnly = true;
            txtstock.Size = new Size(110, 27);
            txtstock.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(481, 39);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 30;
            label8.Text = "Precio:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Location = new Point(44, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 103);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 39);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 3;
            label3.Text = "Tipo Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 39);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(269, 64);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(265, 28);
            cbotipodocumento.TabIndex = 1;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(14, 64);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(233, 27);
            txtfecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 22);
            label1.Name = "label1";
            label1.Size = new Size(203, 29);
            label1.TabIndex = 36;
            label1.Text = "Registrar Venta";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(27, 9);
            label10.Name = "label10";
            label10.Size = new Size(1193, 676);
            label10.TabIndex = 35;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(btnbuscarcli);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtdoccliente);
            groupBox2.Location = new Point(622, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(582, 103);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Cliente";
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(321, 62);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.ReadOnly = true;
            txtnombrecliente.Size = new Size(250, 27);
            txtnombrecliente.TabIndex = 27;
            // 
            // btnbuscarcli
            // 
            btnbuscarcli.BackColor = Color.LightGray;
            btnbuscarcli.Cursor = Cursors.Hand;
            btnbuscarcli.FlatAppearance.BorderColor = Color.Black;
            btnbuscarcli.FlatStyle = FlatStyle.Flat;
            btnbuscarcli.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscarcli.ForeColor = Color.White;
            btnbuscarcli.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            btnbuscarcli.IconColor = Color.Black;
            btnbuscarcli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarcli.IconSize = 22;
            btnbuscarcli.Location = new Point(265, 62);
            btnbuscarcli.Name = "btnbuscarcli";
            btnbuscarcli.Size = new Size(39, 28);
            btnbuscarcli.TabIndex = 26;
            btnbuscarcli.UseVisualStyleBackColor = false;
            btnbuscarcli.Click += btnbuscarcli_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 36);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre Completo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 39);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 2;
            label5.Text = "Numero Documento:";
            // 
            // txtdoccliente
            // 
            txtdoccliente.Location = new Point(14, 64);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.ReadOnly = true;
            txtdoccliente.Size = new Size(230, 27);
            txtdoccliente.TabIndex = 0;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(481, 64);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(110, 27);
            txtprecio.TabIndex = 29;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(150, 34);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(41, 27);
            txtidproducto.TabIndex = 28;
            txtidproducto.Visible = false;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(246, 64);
            txtproducto.Name = "txtproducto";
            txtproducto.ReadOnly = true;
            txtproducto.Size = new Size(226, 27);
            txtproducto.TabIndex = 27;
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.BackColor = Color.LightGray;
            btnbuscarproducto.Cursor = Cursors.Hand;
            btnbuscarproducto.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproducto.FlatStyle = FlatStyle.Flat;
            btnbuscarproducto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscarproducto.ForeColor = Color.White;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 22;
            btnbuscarproducto.Location = new Point(199, 63);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(39, 28);
            btnbuscarproducto.TabIndex = 26;
            btnbuscarproducto.UseVisualStyleBackColor = false;
            btnbuscarproducto.Click += btnbuscarproducto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 36);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 3;
            label6.Text = "Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 39);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 2;
            label7.Text = "Codigo Producto:";
            // 
            // txtcodigoproducto
            // 
            txtcodigoproducto.Location = new Point(14, 64);
            txtcodigoproducto.Name = "txtcodigoproducto";
            txtcodigoproducto.Size = new Size(177, 27);
            txtcodigoproducto.TabIndex = 0;
            txtcodigoproducto.KeyDown += txtcodigoproducto_KeyDown;
            txtcodigoproducto.KeyPress += txtcodigoproducto_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(cbimpuesto);
            groupBox3.Controls.Add(txtcantidad);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtstock);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtprecio);
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtcodigoproducto);
            groupBox3.Location = new Point(44, 174);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1032, 100);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información Producto";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(866, 38);
            label15.Name = "label15";
            label15.Size = new Size(82, 20);
            label15.TabIndex = 37;
            label15.Text = "Descuento:";
            // 
            // cbimpuesto
            // 
            cbimpuesto.FormattingEnabled = true;
            cbimpuesto.Location = new Point(866, 63);
            cbimpuesto.Name = "cbimpuesto";
            cbimpuesto.Size = new Size(151, 28);
            cbimpuesto.TabIndex = 35;
            cbimpuesto.SelectedIndexChanged += cbimpuesto_SelectedIndexChanged;
            // 
            // txttotalpagar
            // 
            txttotalpagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txttotalpagar.Location = new Point(1093, 442);
            txttotalpagar.Name = "txttotalpagar";
            txttotalpagar.ReadOnly = true;
            txttotalpagar.Size = new Size(114, 27);
            txttotalpagar.TabIndex = 30;
            txttotalpagar.Text = "0";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Location = new Point(1093, 419);
            label13.Name = "label13";
            label13.Size = new Size(100, 20);
            label13.TabIndex = 45;
            label13.Text = "Total a pagar:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Location = new Point(1093, 494);
            label14.Name = "label14";
            label14.Size = new Size(72, 20);
            label14.TabIndex = 46;
            label14.Text = "Paga con:";
            // 
            // txtpagacon
            // 
            txtpagacon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtpagacon.Location = new Point(1093, 519);
            txtpagacon.Multiline = true;
            txtpagacon.Name = "txtpagacon";
            txtpagacon.Size = new Size(114, 27);
            txtpagacon.TabIndex = 47;
            txtpagacon.KeyDown += txtpagacon_KeyDown;
            txtpagacon.KeyPress += txtpagacon_KeyPress;
            // 
            // txtcambio
            // 
            txtcambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtcambio.Location = new Point(1093, 591);
            txtcambio.Name = "txtcambio";
            txtcambio.ReadOnly = true;
            txtcambio.Size = new Size(114, 27);
            txtcambio.TabIndex = 48;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(txtcambio);
            Controls.Add(label14);
            Controls.Add(txtpagacon);
            Controls.Add(label13);
            Controls.Add(txttotalpagar);
            Controls.Add(btnregistrar);
            Controls.Add(label12);
            Controls.Add(btnagregar);
            Controls.Add(dgvproducto);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(label10);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvproducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnregistrar;
        private Label label12;
        private FontAwesome.Sharp.IconButton btnagregar;
        private DataGridView dgvproducto;
        private NumericUpDown txtcantidad;
        private Label label11;
        private Label label9;
        private TextBox txtstock;
        private Label label8;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label1;
        private Label label10;
        private GroupBox groupBox2;
        private TextBox txtnombrecliente;
        private FontAwesome.Sharp.IconButton btnbuscarcli;
        private Label label4;
        private Label label5;
        private TextBox txtdoccliente;
        private TextBox txtprecio;
        private TextBox txtidproducto;
        private TextBox txtproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private Label label6;
        private Label label7;
        private TextBox txtcodigoproducto;
        private GroupBox groupBox3;
        private TextBox txttotalpagar;
        private Label label13;
        private Label label14;
        private TextBox txtpagacon;
        private TextBox txtcambio;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
        private ComboBox cbimpuesto;
        private Label label15;
    }
}