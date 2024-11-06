namespace CapaPresentacion
{
    partial class frmAuditoriaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoriaVentas));
            label9 = new Label();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            txtoperacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            txtindice = new TextBox();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            FechaAuditoria = new DataGridViewTextBoxColumn();
            Operacion = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtfechaauditoria = new TextBox();
            label3 = new Label();
            txtmontototal = new TextBox();
            label4 = new Label();
            txttipodocumento = new TextBox();
            label5 = new Label();
            txtnrodocumento = new TextBox();
            label6 = new Label();
            txtnombrecliente = new TextBox();
            label8 = new Label();
            txtnombreusuario = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(19, 21);
            label9.Name = "label9";
            label9.Size = new Size(216, 29);
            label9.TabIndex = 65;
            label9.Text = "Detalle Auditoria";
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
            btnlimpiar.Location = new Point(19, 527);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(299, 33);
            btnlimpiar.TabIndex = 57;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // txtoperacion
            // 
            txtoperacion.Location = new Point(19, 90);
            txtoperacion.Name = "txtoperacion";
            txtoperacion.ReadOnly = true;
            txtoperacion.Size = new Size(299, 27);
            txtoperacion.TabIndex = 60;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 59;
            label2.Text = "Operación";
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
            btnbuscar.Location = new Point(1126, 39);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(39, 28);
            btnbuscar.TabIndex = 73;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(915, 40);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 71;
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(731, 39);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 70;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(643, 42);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 69;
            label11.Text = "Buscar por:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(370, 21);
            label10.Name = "label10";
            label10.Size = new Size(866, 60);
            label10.TabIndex = 67;
            label10.Text = "Lista de Auditorias";
            // 
            // txtindice
            // 
            txtindice.Location = new Point(242, 54);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(35, 27);
            txtindice.TabIndex = 74;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, FechaAuditoria, Operacion, TipoDocumento, NumeroDocumento, NombreCliente, MontoTotal, NombreCompleto });
            dgvdata.Location = new Point(370, 90);
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
            // FechaAuditoria
            // 
            FechaAuditoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaAuditoria.HeaderText = "Fecha Auditoria";
            FechaAuditoria.MinimumWidth = 6;
            FechaAuditoria.Name = "FechaAuditoria";
            FechaAuditoria.ReadOnly = true;
            // 
            // Operacion
            // 
            Operacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Operacion.HeaderText = "Operación";
            Operacion.MinimumWidth = 6;
            Operacion.Name = "Operacion";
            Operacion.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            TipoDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.MinimumWidth = 6;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            TipoDocumento.Visible = false;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NumeroDocumento.HeaderText = "Número Documento";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            NumeroDocumento.Visible = false;
            // 
            // NombreCliente
            // 
            NombreCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCliente.HeaderText = "Nombre Cliente";
            NombreCliente.MinimumWidth = 6;
            NombreCliente.Name = "NombreCliente";
            NombreCliente.ReadOnly = true;
            NombreCliente.Visible = false;
            // 
            // MontoTotal
            // 
            MontoTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.ReadOnly = true;
            MontoTotal.Visible = false;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.HeaderText = "Nombre Usuario";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
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
            btnlimpiarbuscador.Location = new Point(1178, 40);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(39, 27);
            btnlimpiarbuscador.TabIndex = 72;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // txtfechaauditoria
            // 
            txtfechaauditoria.Location = new Point(19, 152);
            txtfechaauditoria.Name = "txtfechaauditoria";
            txtfechaauditoria.ReadOnly = true;
            txtfechaauditoria.Size = new Size(299, 27);
            txtfechaauditoria.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(19, 129);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 75;
            label3.Text = "Fecha Auditoria";
            // 
            // txtmontototal
            // 
            txtmontototal.Location = new Point(19, 215);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.ReadOnly = true;
            txtmontototal.Size = new Size(299, 27);
            txtmontototal.TabIndex = 78;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(19, 192);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 77;
            label4.Text = "Monto Total";
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(19, 279);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.ReadOnly = true;
            txttipodocumento.Size = new Size(299, 27);
            txttipodocumento.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(19, 256);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 79;
            label5.Text = "Tipo Documento";
            // 
            // txtnrodocumento
            // 
            txtnrodocumento.Location = new Point(19, 344);
            txtnrodocumento.Name = "txtnrodocumento";
            txtnrodocumento.ReadOnly = true;
            txtnrodocumento.Size = new Size(299, 27);
            txtnrodocumento.TabIndex = 82;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(19, 321);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 81;
            label6.Text = "Numero Documento";
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(19, 411);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.ReadOnly = true;
            txtnombrecliente.Size = new Size(299, 27);
            txtnombrecliente.TabIndex = 86;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(19, 388);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 85;
            label8.Text = "Nombre Cliente";
            // 
            // txtnombreusuario
            // 
            txtnombreusuario.Location = new Point(19, 478);
            txtnombreusuario.Name = "txtnombreusuario";
            txtnombreusuario.ReadOnly = true;
            txtnombreusuario.Size = new Size(299, 27);
            txtnombreusuario.TabIndex = 88;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(19, 455);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 87;
            label7.Text = "Nombre Usuario";
            // 
            // frmAuditoriaVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(txtnombreusuario);
            Controls.Add(label7);
            Controls.Add(txtnombrecliente);
            Controls.Add(label8);
            Controls.Add(txtnrodocumento);
            Controls.Add(label6);
            Controls.Add(txttipodocumento);
            Controls.Add(label5);
            Controls.Add(txtmontototal);
            Controls.Add(label4);
            Controls.Add(txtfechaauditoria);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(btnlimpiar);
            Controls.Add(txtoperacion);
            Controls.Add(label2);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(txtindice);
            Controls.Add(dgvdata);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(label1);
            Controls.Add(label10);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAuditoriaVentas";
            Text = "frmAuditoriaVentas";
            Load += frmAuditoriaVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private TextBox txtoperacion;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label11;
        private Label label10;
        private TextBox txtindice;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtfechaauditoria;
        private Label label3;
        private TextBox txtmontototal;
        private Label label4;
        private TextBox txttipodocumento;
        private Label label5;
        private TextBox txtnrodocumento;
        private Label label6;
        private TextBox txtnombrecliente;
        private Label label8;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn FechaAuditoria;
        private DataGridViewTextBoxColumn Operacion;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn NombreCompleto;
        private TextBox txtnombreusuario;
        private Label label7;
    }
}