namespace CapaPresentacion
{
    partial class frmHistorialCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialCompras));
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label10 = new Label();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label11 = new Label();
            label2 = new Label();
            btnverdetallecompra = new FontAwesome.Sharp.IconButton();
            txtnumerodocumento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, TipoDocumento, NumeroDocumento, MontoTotal });
            dgvdata.Location = new Point(129, 155);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(989, 499);
            dgvdata.TabIndex = 40;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellContentDoubleClick += dgvdata_CellContentDoubleClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.MinimumWidth = 6;
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Resizable = DataGridViewTriState.True;
            btnseleccionar.SortMode = DataGridViewColumnSortMode.Automatic;
            btnseleccionar.Width = 30;
            // 
            // TipoDocumento
            // 
            TipoDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.MinimumWidth = 6;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NumeroDocumento.HeaderText = "Número Documento";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            // 
            // MontoTotal
            // 
            MontoTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 19);
            label1.Name = "label1";
            label1.Size = new Size(123, 29);
            label1.TabIndex = 36;
            label1.Text = "Compras";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(110, 10);
            label10.Name = "label10";
            label10.Size = new Size(1029, 663);
            label10.TabIndex = 35;
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
            btnlimpiarbuscador.Location = new Point(1055, 102);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(39, 27);
            btnlimpiarbuscador.TabIndex = 65;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
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
            btnbuscar.Location = new Point(1005, 101);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(39, 28);
            btnbuscar.TabIndex = 64;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(791, 102);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 63;
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(607, 101);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 62;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(519, 104);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 61;
            label11.Text = "Buscar por:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 84);
            label2.Name = "label2";
            label2.Size = new Size(989, 60);
            label2.TabIndex = 60;
            label2.Text = "Lista de Compras";
            // 
            // btnverdetallecompra
            // 
            btnverdetallecompra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnverdetallecompra.BackColor = Color.DarkGreen;
            btnverdetallecompra.Cursor = Cursors.Hand;
            btnverdetallecompra.FlatStyle = FlatStyle.Popup;
            btnverdetallecompra.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnverdetallecompra.IconColor = Color.Black;
            btnverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnverdetallecompra.IconSize = 35;
            btnverdetallecompra.Location = new Point(930, 22);
            btnverdetallecompra.Name = "btnverdetallecompra";
            btnverdetallecompra.Size = new Size(188, 55);
            btnverdetallecompra.TabIndex = 66;
            btnverdetallecompra.Text = "Ver Detalle de Compra";
            btnverdetallecompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnverdetallecompra.UseVisualStyleBackColor = false;
            btnverdetallecompra.Click += btnverdetallecompra_Click;
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(791, 36);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(108, 27);
            txtnumerodocumento.TabIndex = 67;
            txtnumerodocumento.Visible = false;
            // 
            // frmHistorialCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(txtnumerodocumento);
            Controls.Add(btnverdetallecompra);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(dgvdata);
            Controls.Add(label1);
            Controls.Add(label10);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHistorialCompras";
            Text = "frmHistorialCompras";
            Load += frmHistorialCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdata;
        private Label label1;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label11;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnverdetallecompra;
        private TextBox txtnumerodocumento;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
    }
}