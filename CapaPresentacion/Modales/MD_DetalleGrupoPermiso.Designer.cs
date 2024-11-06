namespace CapaPresentacion.Modales
{
    partial class MD_DetalleGrupoPermiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD_DetalleGrupoPermiso));
            btnguardarpermiso = new FontAwesome.Sharp.IconButton();
            btnagregarpermiso = new FontAwesome.Sharp.IconButton();
            btneliminarpermiso = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdComponente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoPermiso = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            txtid = new TextBox();
            label2 = new Label();
            cbestado = new ComboBox();
            label8 = new Label();
            txtnombregrupo = new TextBox();
            label3 = new Label();
            label1 = new Label();
            lbltitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btnguardarpermiso
            // 
            btnguardarpermiso.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnguardarpermiso.BackColor = Color.DarkGreen;
            btnguardarpermiso.Cursor = Cursors.Hand;
            btnguardarpermiso.FlatStyle = FlatStyle.Popup;
            btnguardarpermiso.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguardarpermiso.IconColor = Color.Black;
            btnguardarpermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarpermiso.IconSize = 24;
            btnguardarpermiso.Location = new Point(39, 564);
            btnguardarpermiso.Name = "btnguardarpermiso";
            btnguardarpermiso.Size = new Size(240, 40);
            btnguardarpermiso.TabIndex = 75;
            btnguardarpermiso.Text = "Guardar Permisos";
            btnguardarpermiso.TextAlign = ContentAlignment.MiddleRight;
            btnguardarpermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardarpermiso.UseVisualStyleBackColor = false;
            btnguardarpermiso.Click += btnguardarpermiso_Click;
            // 
            // btnagregarpermiso
            // 
            btnagregarpermiso.BackColor = Color.DarkGreen;
            btnagregarpermiso.Cursor = Cursors.Hand;
            btnagregarpermiso.FlatStyle = FlatStyle.Popup;
            btnagregarpermiso.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnagregarpermiso.IconColor = Color.Black;
            btnagregarpermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregarpermiso.IconSize = 27;
            btnagregarpermiso.ImageAlign = ContentAlignment.BottomCenter;
            btnagregarpermiso.Location = new Point(39, 206);
            btnagregarpermiso.Name = "btnagregarpermiso";
            btnagregarpermiso.Size = new Size(240, 40);
            btnagregarpermiso.TabIndex = 73;
            btnagregarpermiso.Text = "Agregar Permisos";
            btnagregarpermiso.TextAlign = ContentAlignment.MiddleRight;
            btnagregarpermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregarpermiso.UseVisualStyleBackColor = false;
            btnagregarpermiso.Click += btnagregarpermiso_Click;
            // 
            // btneliminarpermiso
            // 
            btneliminarpermiso.BackColor = Color.DarkGreen;
            btneliminarpermiso.Cursor = Cursors.Hand;
            btneliminarpermiso.FlatStyle = FlatStyle.Popup;
            btneliminarpermiso.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btneliminarpermiso.IconColor = Color.Black;
            btneliminarpermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarpermiso.IconSize = 26;
            btneliminarpermiso.Location = new Point(39, 257);
            btneliminarpermiso.Name = "btneliminarpermiso";
            btneliminarpermiso.Size = new Size(240, 40);
            btneliminarpermiso.TabIndex = 74;
            btneliminarpermiso.Text = "Eliminar Permisos";
            btneliminarpermiso.TextAlign = ContentAlignment.MiddleRight;
            btneliminarpermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminarpermiso.UseVisualStyleBackColor = false;
            btneliminarpermiso.Click += btneliminarpermiso_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvdata.BackgroundColor = Color.LightGray;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdComponente, Nombre, TipoPermiso, Estado, EstadoValor });
            dgvdata.Location = new Point(306, 206);
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
            dgvdata.Size = new Size(811, 398);
            dgvdata.TabIndex = 72;
            dgvdata.CellClick += dgvdata_CellClick;
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
            // IdComponente
            // 
            IdComponente.HeaderText = "IdComponente";
            IdComponente.MinimumWidth = 6;
            IdComponente.Name = "IdComponente";
            IdComponente.ReadOnly = true;
            IdComponente.Visible = false;
            IdComponente.Width = 125;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // TipoPermiso
            // 
            TipoPermiso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoPermiso.HeaderText = "Tipo de Permiso";
            TipoPermiso.MinimumWidth = 6;
            TipoPermiso.Name = "TipoPermiso";
            TipoPermiso.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 150;
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
            // txtid
            // 
            txtid.Location = new Point(401, 168);
            txtid.Name = "txtid";
            txtid.Size = new Size(41, 27);
            txtid.TabIndex = 71;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Padding = new Padding(25, 5, 0, 0);
            label2.Size = new Size(1121, 464);
            label2.TabIndex = 70;
            label2.Text = "Lista de Permisos";
            // 
            // cbestado
            // 
            cbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestado.FormattingEnabled = true;
            cbestado.Location = new Point(684, 104);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(211, 28);
            cbestado.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(684, 81);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 68;
            label8.Text = "Estado:";
            // 
            // txtnombregrupo
            // 
            txtnombregrupo.Location = new Point(401, 105);
            txtnombregrupo.Name = "txtnombregrupo";
            txtnombregrupo.ReadOnly = true;
            txtnombregrupo.Size = new Size(254, 27);
            txtnombregrupo.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(401, 82);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 66;
            label3.Text = "Nombre del Grupo:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Padding = new Padding(25, 5, 0, 0);
            label1.Size = new Size(1121, 77);
            label1.TabIndex = 65;
            label1.Text = "Información del Grupo";
            // 
            // lbltitulo
            // 
            lbltitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbltitulo.BackColor = Color.White;
            lbltitulo.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.Location = new Point(12, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Padding = new Padding(20, 0, 0, 0);
            lbltitulo.Size = new Size(1121, 58);
            lbltitulo.TabIndex = 63;
            lbltitulo.Text = "Detalle del Grupo";
            lbltitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MD_DetalleGrupoPermiso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1144, 640);
            Controls.Add(btnguardarpermiso);
            Controls.Add(btnagregarpermiso);
            Controls.Add(btneliminarpermiso);
            Controls.Add(dgvdata);
            Controls.Add(txtid);
            Controls.Add(label2);
            Controls.Add(cbestado);
            Controls.Add(label8);
            Controls.Add(txtnombregrupo);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lbltitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MD_DetalleGrupoPermiso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MD_DetalleGrupoPermiso";
            Load += MD_DetalleGrupoPermiso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnguardarpermiso;
        private FontAwesome.Sharp.IconButton btnagregarpermiso;
        private FontAwesome.Sharp.IconButton btneliminarpermiso;
        private DataGridView dgvdata;
        private TextBox txtid;
        private Label label2;
        private ComboBox cbestado;
        private Label label8;
        private TextBox txtnombregrupo;
        private Label label3;
        private Label label1;
        private Label lbltitulo;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdComponente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoPermiso;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn EstadoValor;
    }
}