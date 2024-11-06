namespace CapaPresentacion
{
    partial class frmProducto
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            txtindice = new TextBox();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label11 = new Label();
            txtid = new TextBox();
            label10 = new Label();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            cbestado = new ComboBox();
            cbcategoria = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtdescripcion = new TextBox();
            txtnombre = new TextBox();
            txtcodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnguardarproducto = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btneliminarproducto = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // txtindice
            // 
            txtindice.Location = new Point(237, 55);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(35, 27);
            txtindice.TabIndex = 54;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(910, 40);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 51;
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(726, 39);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 50;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(638, 42);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 49;
            label11.Text = "Buscar por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(278, 55);
            txtid.Name = "txtid";
            txtid.Size = new Size(35, 27);
            txtid.TabIndex = 48;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(366, 22);
            label10.Name = "label10";
            label10.Size = new Size(866, 60);
            label10.TabIndex = 47;
            label10.Text = "Lista de Productos";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, Codigo, Nombre, Descripcion, IdCategoria, Categoria, Stock, PrecioCompra, PrecioVenta, EstadoValor, Estado });
            dgvdata.Location = new Point(366, 91);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowHeadersWidth = 51;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(866, 558);
            dgvdata.TabIndex = 46;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.MinimumWidth = 6;
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.MinimumWidth = 6;
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            IdCategoria.Visible = false;
            IdCategoria.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 110;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 80;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 80;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "Estado Valor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 80;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 22);
            label9.Name = "label9";
            label9.Size = new Size(216, 29);
            label9.TabIndex = 45;
            label9.Text = "Detalle Producto";
            // 
            // cbestado
            // 
            cbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestado.FormattingEnabled = true;
            cbestado.Location = new Point(14, 351);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(299, 28);
            cbestado.TabIndex = 42;
            // 
            // cbcategoria
            // 
            cbcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Location = new Point(14, 285);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(299, 28);
            cbcategoria.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(14, 328);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 40;
            label8.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(14, 262);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 39;
            label7.Text = "Categoria:";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(14, 216);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(299, 27);
            txtdescripcion.TabIndex = 34;
            txtdescripcion.KeyPress += txtdescripcion_KeyPress;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(14, 153);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(299, 27);
            txtnombre.TabIndex = 33;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(14, 91);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(299, 27);
            txtcodigo.TabIndex = 32;
            txtcodigo.KeyPress += txtcodigo_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(14, 193);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 31;
            label4.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(14, 130);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 30;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(14, 68);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 29;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 694);
            label1.TabIndex = 27;
            // 
            // btnbuscar
            // 
            btnbuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnbuscar.BackColor = Color.DarkGreen;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            btnbuscar.IconColor = Color.White;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 22;
            btnbuscar.Location = new Point(1124, 39);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(39, 28);
            btnbuscar.TabIndex = 55;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // btnguardarproducto
            // 
            btnguardarproducto.BackColor = Color.DarkGreen;
            btnguardarproducto.Cursor = Cursors.Hand;
            btnguardarproducto.FlatAppearance.BorderColor = Color.Black;
            btnguardarproducto.FlatStyle = FlatStyle.Flat;
            btnguardarproducto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardarproducto.ForeColor = Color.White;
            btnguardarproducto.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguardarproducto.IconColor = Color.White;
            btnguardarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarproducto.IconSize = 25;
            btnguardarproducto.Location = new Point(14, 402);
            btnguardarproducto.Name = "btnguardarproducto";
            btnguardarproducto.Size = new Size(299, 33);
            btnguardarproducto.TabIndex = 57;
            btnguardarproducto.Text = "Guardar";
            btnguardarproducto.TextAlign = ContentAlignment.MiddleRight;
            btnguardarproducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardarproducto.UseVisualStyleBackColor = false;
            btnguardarproducto.Click += btnguardar_Click_1;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.DarkGreen;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = Color.White;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 25;
            btnlimpiar.Location = new Point(14, 446);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(299, 33);
            btnlimpiar.TabIndex = 56;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlimpiarbuscador.BackColor = Color.DarkGreen;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpiarbuscador.ForeColor = Color.White;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.White;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 23;
            btnlimpiarbuscador.Location = new Point(1174, 40);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(39, 27);
            btnlimpiarbuscador.TabIndex = 59;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click_1;
            // 
            // btneliminarproducto
            // 
            btneliminarproducto.BackColor = Color.DarkGreen;
            btneliminarproducto.Cursor = Cursors.Hand;
            btneliminarproducto.FlatAppearance.BorderColor = Color.Black;
            btneliminarproducto.FlatStyle = FlatStyle.Flat;
            btneliminarproducto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminarproducto.ForeColor = Color.White;
            btneliminarproducto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btneliminarproducto.IconColor = Color.White;
            btneliminarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarproducto.IconSize = 25;
            btneliminarproducto.Location = new Point(14, 491);
            btneliminarproducto.Name = "btneliminarproducto";
            btneliminarproducto.Size = new Size(299, 33);
            btneliminarproducto.TabIndex = 58;
            btneliminarproducto.Text = " Eliminar";
            btneliminarproducto.TextAlign = ContentAlignment.MiddleRight;
            btneliminarproducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminarproducto.UseVisualStyleBackColor = false;
            btneliminarproducto.Click += btneliminar_Click_1;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(btnguardarproducto);
            Controls.Add(btnlimpiar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btneliminarproducto);
            Controls.Add(btnbuscar);
            Controls.Add(txtindice);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(cbestado);
            Controls.Add(cbcategoria);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtdescripcion);
            Controls.Add(txtnombre);
            Controls.Add(txtcodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtindice;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label11;
        private TextBox txtid;
        private Label label10;
        private DataGridView dgvdata;
        private Label label9;
        private ComboBox cbestado;
        private ComboBox cbcategoria;
        private Label label8;
        private Label label7;
        private TextBox txtdescripcion;
        private TextBox txtnombre;
        private TextBox txtcodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnguardarproducto;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btneliminarproducto;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}