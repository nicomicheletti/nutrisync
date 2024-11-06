namespace CapaPresentacion
{
    partial class frmGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupo));
            label9 = new Label();
            label1 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label11 = new Label();
            txtid = new TextBox();
            label10 = new Label();
            txtidcomponente = new TextBox();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdGrupoPermiso = new DataGridViewTextBoxColumn();
            IdComponente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btneditargrupo = new FontAwesome.Sharp.IconButton();
            btnverdetallegrupo = new FontAwesome.Sharp.IconButton();
            btneliminargrupo = new FontAwesome.Sharp.IconButton();
            btnagregargrupo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(21, 22);
            label9.Name = "label9";
            label9.Size = new Size(101, 29);
            label9.TabIndex = 65;
            label9.Text = "Grupos";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 694);
            label1.TabIndex = 58;
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
            btnbuscar.Location = new Point(1125, 41);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(39, 28);
            btnbuscar.TabIndex = 73;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(914, 42);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 71;
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(730, 41);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 70;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(642, 44);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 69;
            label11.Text = "Buscar por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(285, 55);
            txtid.Name = "txtid";
            txtid.Size = new Size(35, 27);
            txtid.TabIndex = 68;
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
            label10.TabIndex = 67;
            label10.Text = "Lista de Gurpos";
            // 
            // txtidcomponente
            // 
            txtidcomponente.Location = new Point(244, 55);
            txtidcomponente.Name = "txtidcomponente";
            txtidcomponente.Size = new Size(35, 27);
            txtidcomponente.TabIndex = 74;
            txtidcomponente.Text = "0";
            txtidcomponente.Visible = false;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdGrupoPermiso, IdComponente, Nombre, Estado, EstadoValor });
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
            dgvdata.Size = new Size(866, 577);
            dgvdata.TabIndex = 66;
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
            // IdGrupoPermiso
            // 
            IdGrupoPermiso.HeaderText = "IdGrupoPermiso";
            IdGrupoPermiso.MinimumWidth = 6;
            IdGrupoPermiso.Name = "IdGrupoPermiso";
            IdGrupoPermiso.ReadOnly = true;
            IdGrupoPermiso.Visible = false;
            IdGrupoPermiso.Width = 125;
            // 
            // IdComponente
            // 
            IdComponente.HeaderText = "IdComponente";
            IdComponente.MinimumWidth = 6;
            IdComponente.Name = "IdComponente";
            IdComponente.ReadOnly = true;
            IdComponente.Visible = false;
            IdComponente.Width = 150;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
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
            btnlimpiarbuscador.Location = new Point(1177, 42);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(39, 27);
            btnlimpiarbuscador.TabIndex = 72;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // btneditargrupo
            // 
            btneditargrupo.BackColor = Color.DarkGreen;
            btneditargrupo.Cursor = Cursors.Hand;
            btneditargrupo.FlatAppearance.BorderColor = Color.Black;
            btneditargrupo.FlatStyle = FlatStyle.Popup;
            btneditargrupo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btneditargrupo.ForeColor = Color.White;
            btneditargrupo.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            btneditargrupo.IconColor = Color.White;
            btneditargrupo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneditargrupo.IconSize = 22;
            btneditargrupo.Location = new Point(21, 175);
            btneditargrupo.Name = "btneditargrupo";
            btneditargrupo.Size = new Size(299, 33);
            btneditargrupo.TabIndex = 76;
            btneditargrupo.Text = "Editar";
            btneditargrupo.TextAlign = ContentAlignment.MiddleRight;
            btneditargrupo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneditargrupo.UseVisualStyleBackColor = false;
            btneditargrupo.Click += btneditar_Click;
            // 
            // btnverdetallegrupo
            // 
            btnverdetallegrupo.BackColor = Color.DarkGreen;
            btnverdetallegrupo.Cursor = Cursors.Hand;
            btnverdetallegrupo.FlatAppearance.BorderColor = Color.Black;
            btnverdetallegrupo.FlatStyle = FlatStyle.Popup;
            btnverdetallegrupo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnverdetallegrupo.ForeColor = Color.White;
            btnverdetallegrupo.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            btnverdetallegrupo.IconColor = Color.White;
            btnverdetallegrupo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnverdetallegrupo.IconSize = 22;
            btnverdetallegrupo.Location = new Point(21, 91);
            btnverdetallegrupo.Name = "btnverdetallegrupo";
            btnverdetallegrupo.Size = new Size(299, 33);
            btnverdetallegrupo.TabIndex = 75;
            btnverdetallegrupo.Text = "Ver Detalle";
            btnverdetallegrupo.TextAlign = ContentAlignment.MiddleRight;
            btnverdetallegrupo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnverdetallegrupo.UseVisualStyleBackColor = false;
            btnverdetallegrupo.Click += btnverdetalle_Click;
            // 
            // btneliminargrupo
            // 
            btneliminargrupo.BackColor = Color.DarkGreen;
            btneliminargrupo.Cursor = Cursors.Hand;
            btneliminargrupo.FlatStyle = FlatStyle.Popup;
            btneliminargrupo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminargrupo.ForeColor = Color.White;
            btneliminargrupo.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btneliminargrupo.IconColor = Color.White;
            btneliminargrupo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminargrupo.IconSize = 26;
            btneliminargrupo.Location = new Point(21, 217);
            btneliminargrupo.Name = "btneliminargrupo";
            btneliminargrupo.Size = new Size(299, 33);
            btneliminargrupo.TabIndex = 78;
            btneliminargrupo.Text = "Eliminar";
            btneliminargrupo.TextAlign = ContentAlignment.MiddleRight;
            btneliminargrupo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminargrupo.UseVisualStyleBackColor = false;
            btneliminargrupo.Click += btneliminar_Click;
            // 
            // btnagregargrupo
            // 
            btnagregargrupo.BackColor = Color.DarkGreen;
            btnagregargrupo.Cursor = Cursors.Hand;
            btnagregargrupo.FlatStyle = FlatStyle.Popup;
            btnagregargrupo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregargrupo.ForeColor = Color.White;
            btnagregargrupo.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnagregargrupo.IconColor = Color.White;
            btnagregargrupo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregargrupo.IconSize = 24;
            btnagregargrupo.ImageAlign = ContentAlignment.BottomCenter;
            btnagregargrupo.Location = new Point(21, 133);
            btnagregargrupo.Name = "btnagregargrupo";
            btnagregargrupo.Size = new Size(299, 33);
            btnagregargrupo.TabIndex = 77;
            btnagregargrupo.Text = "Agregar";
            btnagregargrupo.TextAlign = ContentAlignment.MiddleRight;
            btnagregargrupo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregargrupo.UseVisualStyleBackColor = false;
            btnagregargrupo.Click += btnagregar_Click;
            // 
            // frmGrupo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(btneliminargrupo);
            Controls.Add(btnagregargrupo);
            Controls.Add(btneditargrupo);
            Controls.Add(btnverdetallegrupo);
            Controls.Add(label9);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(txtidcomponente);
            Controls.Add(dgvdata);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(label10);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGrupo";
            Text = "frmGrupo";
            Load += frmGrupo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label11;
        private TextBox txtid;
        private Label label10;
        private TextBox txtidcomponente;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdGrupoPermiso;
        private DataGridViewTextBoxColumn IdComponente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn EstadoValor;
        private FontAwesome.Sharp.IconButton btneditargrupo;
        private FontAwesome.Sharp.IconButton btnverdetallegrupo;
        private FontAwesome.Sharp.IconButton btneliminargrupo;
        private FontAwesome.Sharp.IconButton btnagregargrupo;
    }
}