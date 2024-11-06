namespace CapaPresentacion
{
    partial class frmPermiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermiso));
            btneditarestado = new FontAwesome.Sharp.IconButton();
            txtidcomponente = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label11 = new Label();
            txtid = new TextBox();
            label10 = new Label();
            btnverdetallepermisosimple = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdPermiso = new DataGridViewTextBoxColumn();
            IdComponente = new DataGridViewTextBoxColumn();
            NombrePermiso = new DataGridViewTextBoxColumn();
            NombreMenu = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btneditarestado
            // 
            btneditarestado.BackColor = Color.DarkGreen;
            btneditarestado.Cursor = Cursors.Hand;
            btneditarestado.FlatAppearance.BorderColor = Color.Black;
            btneditarestado.FlatStyle = FlatStyle.Flat;
            btneditarestado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btneditarestado.ForeColor = Color.White;
            btneditarestado.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            btneditarestado.IconColor = Color.White;
            btneditarestado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneditarestado.IconSize = 22;
            btneditarestado.Location = new Point(18, 135);
            btneditarestado.Name = "btneditarestado";
            btneditarestado.Size = new Size(299, 33);
            btneditarestado.TabIndex = 58;
            btneditarestado.Text = "Editar Estado";
            btneditarestado.TextAlign = ContentAlignment.MiddleRight;
            btneditarestado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneditarestado.UseVisualStyleBackColor = false;
            btneditarestado.Click += btneditarestado_Click;
            // 
            // txtidcomponente
            // 
            txtidcomponente.Location = new Point(241, 55);
            txtidcomponente.Name = "txtidcomponente";
            txtidcomponente.Size = new Size(35, 27);
            txtidcomponente.TabIndex = 56;
            txtidcomponente.Text = "0";
            txtidcomponente.Visible = false;
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
            btnbuscar.Location = new Point(1124, 40);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(39, 28);
            btnbuscar.TabIndex = 55;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
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
            btnlimpiarbuscador.Location = new Point(1176, 41);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(39, 27);
            btnlimpiarbuscador.TabIndex = 54;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(913, 41);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 53;
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(729, 40);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 52;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(641, 43);
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
            label10.Location = new Point(366, 22);
            label10.Name = "label10";
            label10.Size = new Size(866, 60);
            label10.TabIndex = 49;
            label10.Text = "Lista de Permisos";
            // 
            // btnverdetallepermisosimple
            // 
            btnverdetallepermisosimple.BackColor = Color.DarkGreen;
            btnverdetallepermisosimple.Cursor = Cursors.Hand;
            btnverdetallepermisosimple.FlatAppearance.BorderColor = Color.Black;
            btnverdetallepermisosimple.FlatStyle = FlatStyle.Flat;
            btnverdetallepermisosimple.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnverdetallepermisosimple.ForeColor = Color.White;
            btnverdetallepermisosimple.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            btnverdetallepermisosimple.IconColor = Color.White;
            btnverdetallepermisosimple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnverdetallepermisosimple.IconSize = 22;
            btnverdetallepermisosimple.Location = new Point(18, 91);
            btnverdetallepermisosimple.Name = "btnverdetallepermisosimple";
            btnverdetallepermisosimple.Size = new Size(299, 33);
            btnverdetallepermisosimple.TabIndex = 57;
            btnverdetallepermisosimple.Text = "Ver Detalle";
            btnverdetallepermisosimple.TextAlign = ContentAlignment.MiddleRight;
            btnverdetallepermisosimple.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnverdetallepermisosimple.UseVisualStyleBackColor = false;
            btnverdetallepermisosimple.Click += btnverdetalle_Click;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdPermiso, IdComponente, NombrePermiso, NombreMenu, Estado, EstadoValor });
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
            dgvdata.Size = new Size(866, 642);
            dgvdata.TabIndex = 48;
            dgvdata.CellClick += dgvdata_CellClick;
            dgvdata.CellContentDoubleClick += dgvdata_CellContentDoubleClick;
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
            // IdPermiso
            // 
            IdPermiso.HeaderText = "IdPermiso";
            IdPermiso.MinimumWidth = 6;
            IdPermiso.Name = "IdPermiso";
            IdPermiso.ReadOnly = true;
            IdPermiso.Visible = false;
            IdPermiso.Width = 125;
            // 
            // IdComponente
            // 
            IdComponente.HeaderText = "IdComponente";
            IdComponente.MinimumWidth = 6;
            IdComponente.Name = "IdComponente";
            IdComponente.ReadOnly = true;
            IdComponente.Visible = false;
            IdComponente.Width = 125;
            // 
            // NombrePermiso
            // 
            NombrePermiso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombrePermiso.HeaderText = "Nombre Permiso";
            NombrePermiso.MinimumWidth = 6;
            NombrePermiso.Name = "NombrePermiso";
            NombrePermiso.ReadOnly = true;
            // 
            // NombreMenu
            // 
            NombreMenu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreMenu.HeaderText = "Nombre Menu";
            NombreMenu.MinimumWidth = 6;
            NombreMenu.Name = "NombreMenu";
            NombreMenu.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 22);
            label9.Name = "label9";
            label9.Size = new Size(128, 29);
            label9.TabIndex = 47;
            label9.Text = "Permisos";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 761);
            label1.TabIndex = 29;
            // 
            // frmPermiso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 761);
            Controls.Add(btneditarestado);
            Controls.Add(txtidcomponente);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(label10);
            Controls.Add(btnverdetallepermisosimple);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPermiso";
            Text = "frmPermiso";
            Load += frmPermiso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn NombreCompleto;
        private FontAwesome.Sharp.IconButton btneditarestado;
        private TextBox txtidcomponente;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label11;
        private TextBox txtid;
        private Label label10;
        private DataGridViewTextBoxColumn IdUsuario;
        private FontAwesome.Sharp.IconButton btnverdetallepermisosimple;
        private DataGridView dgvdata;
        private Label label9;
        private Label label1;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdPermiso;
        private DataGridViewTextBoxColumn IdComponente;
        private DataGridViewTextBoxColumn NombrePermiso;
        private DataGridViewTextBoxColumn NombreMenu;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn EstadoValor;
    }
}