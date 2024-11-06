namespace CapaPresentacion.Modales
{
    partial class MD_DetallePermisoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD_DetallePermisoUsuario));
            lbltitulo = new Label();
            label1 = new Label();
            cbestado = new ComboBox();
            label8 = new Label();
            txtnombrecompleto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtid = new TextBox();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdComponente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoPermiso = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            btnagregarpermiso = new FontAwesome.Sharp.IconButton();
            btneliminarpermiso = new FontAwesome.Sharp.IconButton();
            btnguardarpermiso = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
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
            lbltitulo.TabIndex = 50;
            lbltitulo.Text = "Permisos del Usuario";
            lbltitulo.TextAlign = ContentAlignment.MiddleLeft;
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
            label1.TabIndex = 52;
            label1.Text = "Información del Usuario";
            // 
            // cbestado
            // 
            cbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestado.FormattingEnabled = true;
            cbestado.Location = new Point(684, 100);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(211, 28);
            cbestado.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(684, 77);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 55;
            label8.Text = "Estado:";
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(401, 101);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.ReadOnly = true;
            txtnombrecompleto.Size = new Size(254, 27);
            txtnombrecompleto.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(401, 78);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 53;
            label3.Text = "Nombre Completo:";
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
            label2.TabIndex = 57;
            label2.Text = "Lista de Permisos";
            // 
            // txtid
            // 
            txtid.Location = new Point(306, 166);
            txtid.Name = "txtid";
            txtid.Size = new Size(41, 27);
            txtid.TabIndex = 58;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvdata.BackgroundColor = Color.White;
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
            dgvdata.Location = new Point(306, 201);
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
            dgvdata.Size = new Size(811, 403);
            dgvdata.TabIndex = 59;
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
            TipoPermiso.HeaderText = "TipoPermiso";
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
            // btnagregarpermiso
            // 
            btnagregarpermiso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnagregarpermiso.BackColor = Color.DarkGreen;
            btnagregarpermiso.Cursor = Cursors.Hand;
            btnagregarpermiso.FlatStyle = FlatStyle.Popup;
            btnagregarpermiso.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnagregarpermiso.IconColor = Color.Black;
            btnagregarpermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregarpermiso.IconSize = 27;
            btnagregarpermiso.ImageAlign = ContentAlignment.BottomCenter;
            btnagregarpermiso.Location = new Point(39, 201);
            btnagregarpermiso.Name = "btnagregarpermiso";
            btnagregarpermiso.Size = new Size(240, 40);
            btnagregarpermiso.TabIndex = 60;
            btnagregarpermiso.Text = "Agregar Permisos";
            btnagregarpermiso.TextAlign = ContentAlignment.MiddleRight;
            btnagregarpermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnagregarpermiso.UseVisualStyleBackColor = false;
            btnagregarpermiso.Click += btnagregarpermiso_Click;
            // 
            // btneliminarpermiso
            // 
            btneliminarpermiso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btneliminarpermiso.BackColor = Color.DarkGreen;
            btneliminarpermiso.Cursor = Cursors.Hand;
            btneliminarpermiso.FlatStyle = FlatStyle.Popup;
            btneliminarpermiso.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btneliminarpermiso.IconColor = Color.Black;
            btneliminarpermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarpermiso.IconSize = 26;
            btneliminarpermiso.Location = new Point(39, 252);
            btneliminarpermiso.Name = "btneliminarpermiso";
            btneliminarpermiso.Size = new Size(240, 40);
            btneliminarpermiso.TabIndex = 61;
            btneliminarpermiso.Text = "Eliminar Permisos";
            btneliminarpermiso.TextAlign = ContentAlignment.MiddleRight;
            btneliminarpermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminarpermiso.UseVisualStyleBackColor = false;
            btneliminarpermiso.Click += btneliminarpermiso_Click;
            // 
            // btnguardarpermiso
            // 
            btnguardarpermiso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnguardarpermiso.BackColor = Color.DarkGreen;
            btnguardarpermiso.Cursor = Cursors.Hand;
            btnguardarpermiso.FlatStyle = FlatStyle.Popup;
            btnguardarpermiso.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguardarpermiso.IconColor = Color.Black;
            btnguardarpermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarpermiso.IconSize = 24;
            btnguardarpermiso.Location = new Point(40, 564);
            btnguardarpermiso.Name = "btnguardarpermiso";
            btnguardarpermiso.Size = new Size(240, 40);
            btnguardarpermiso.TabIndex = 62;
            btnguardarpermiso.Text = "Guardar Permisos";
            btnguardarpermiso.TextAlign = ContentAlignment.MiddleRight;
            btnguardarpermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardarpermiso.UseVisualStyleBackColor = false;
            btnguardarpermiso.Click += btnguardarpermiso_Click;
            // 
            // MD_DetallePermisoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 628);
            Controls.Add(btnguardarpermiso);
            Controls.Add(btneliminarpermiso);
            Controls.Add(btnagregarpermiso);
            Controls.Add(dgvdata);
            Controls.Add(txtid);
            Controls.Add(label2);
            Controls.Add(cbestado);
            Controls.Add(label8);
            Controls.Add(txtnombrecompleto);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lbltitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MD_DetallePermisoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MD_DetallePermisoUsuario";
            Load += MD_DetallePermisoUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label label1;
        private ComboBox cbestado;
        private Label label8;
        private TextBox txtnombrecompleto;
        private Label label3;
        private Label label2;
        private TextBox txtid;
        private DataGridView dgvdata;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdComponente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoPermiso;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn EstadoValor;
        private FontAwesome.Sharp.IconButton btnagregarpermiso;
        private FontAwesome.Sharp.IconButton btneliminarpermiso;
        private FontAwesome.Sharp.IconButton btnguardarpermiso;
    }
}