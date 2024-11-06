namespace CapaPresentacion
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label11 = new Label();
            txtid = new TextBox();
            label10 = new Label();
            txtindice = new TextBox();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            btneliminarcategoria = new FontAwesome.Sharp.IconButton();
            btnguardarcategoria = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            cbestado = new ComboBox();
            label8 = new Label();
            txtdescripcion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
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
            btnlimpiarbuscador.Location = new Point(1177, 41);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(39, 27);
            btnlimpiarbuscador.TabIndex = 54;
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
            btnbuscar.Location = new Point(1125, 40);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(39, 28);
            btnbuscar.TabIndex = 55;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(914, 41);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 53;
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(730, 40);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 52;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(642, 43);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 51;
            label11.Text = "Buscar por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(282, 55);
            txtid.Name = "txtid";
            txtid.Size = new Size(35, 27);
            txtid.TabIndex = 50;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(369, 22);
            label10.Name = "label10";
            label10.Size = new Size(866, 60);
            label10.TabIndex = 49;
            label10.Text = "Lista de Categorias";
            // 
            // txtindice
            // 
            txtindice.Location = new Point(241, 55);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(35, 27);
            txtindice.TabIndex = 56;
            txtindice.Text = "0";
            txtindice.Visible = false;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdCategoria, Descripcion, EstadoValor, Estado });
            dgvdata.Location = new Point(369, 91);
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
            dgvdata.Size = new Size(866, 577);
            dgvdata.TabIndex = 48;
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
            // IdCategoria
            // 
            IdCategoria.HeaderText = "Id";
            IdCategoria.MinimumWidth = 6;
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            IdCategoria.Visible = false;
            IdCategoria.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
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
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 22);
            label9.Name = "label9";
            label9.Size = new Size(225, 29);
            label9.TabIndex = 47;
            label9.Text = "Detalle Categoria";
            // 
            // btneliminarcategoria
            // 
            btneliminarcategoria.BackColor = Color.DarkGreen;
            btneliminarcategoria.Cursor = Cursors.Hand;
            btneliminarcategoria.FlatAppearance.BorderColor = Color.Black;
            btneliminarcategoria.FlatStyle = FlatStyle.Flat;
            btneliminarcategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminarcategoria.ForeColor = Color.White;
            btneliminarcategoria.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btneliminarcategoria.IconColor = Color.White;
            btneliminarcategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarcategoria.IconSize = 25;
            btneliminarcategoria.Location = new Point(18, 295);
            btneliminarcategoria.Name = "btneliminarcategoria";
            btneliminarcategoria.Size = new Size(299, 33);
            btneliminarcategoria.TabIndex = 46;
            btneliminarcategoria.Text = " Eliminar";
            btneliminarcategoria.TextAlign = ContentAlignment.MiddleRight;
            btneliminarcategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminarcategoria.UseVisualStyleBackColor = false;
            btneliminarcategoria.Click += btneliminar_Click;
            // 
            // btnguardarcategoria
            // 
            btnguardarcategoria.BackColor = Color.DarkGreen;
            btnguardarcategoria.Cursor = Cursors.Hand;
            btnguardarcategoria.FlatAppearance.BorderColor = Color.Black;
            btnguardarcategoria.FlatStyle = FlatStyle.Flat;
            btnguardarcategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardarcategoria.ForeColor = Color.White;
            btnguardarcategoria.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguardarcategoria.IconColor = Color.White;
            btnguardarcategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarcategoria.IconSize = 25;
            btnguardarcategoria.Location = new Point(18, 211);
            btnguardarcategoria.Name = "btnguardarcategoria";
            btnguardarcategoria.Size = new Size(299, 33);
            btnguardarcategoria.TabIndex = 44;
            btnguardarcategoria.Text = "Guardar";
            btnguardarcategoria.TextAlign = ContentAlignment.MiddleRight;
            btnguardarcategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardarcategoria.UseVisualStyleBackColor = false;
            btnguardarcategoria.Click += btnguardar_Click;
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
            btnlimpiar.Location = new Point(18, 253);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(299, 33);
            btnlimpiar.TabIndex = 28;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // cbestado
            // 
            cbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestado.FormattingEnabled = true;
            cbestado.Location = new Point(18, 155);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(299, 28);
            cbestado.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(18, 132);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 41;
            label8.Text = "Estado:";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(18, 91);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(299, 27);
            txtdescripcion.TabIndex = 33;
            txtdescripcion.KeyPress += txtdescripcion_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 30;
            label2.Text = "Descripción:";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 694);
            label1.TabIndex = 29;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(label10);
            Controls.Add(txtindice);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(btneliminarcategoria);
            Controls.Add(btnguardarcategoria);
            Controls.Add(btnlimpiar);
            Controls.Add(cbestado);
            Controls.Add(label8);
            Controls.Add(txtdescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label11;
        private TextBox txtid;
        private Label label10;
        private TextBox txtindice;
        private DataGridView dgvdata;
        private Label label9;
        private FontAwesome.Sharp.IconButton btneliminarcategoria;
        private FontAwesome.Sharp.IconButton btnguardarcategoria;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private ComboBox cbestado;
        private Label label8;
        private TextBox txtdescripcion;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}