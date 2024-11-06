namespace CapaPresentacion
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            txtindice = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label11 = new Label();
            txtid = new TextBox();
            btnguardarcliente = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            btneliminarcliente = new FontAwesome.Sharp.IconButton();
            cbestado = new ComboBox();
            label8 = new Label();
            txttelefono = new TextBox();
            label5 = new Label();
            txtcorreo = new TextBox();
            txtnombrecompleto = new TextBox();
            txtdocumento = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // txtindice
            // 
            txtindice.Location = new Point(241, 55);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(35, 27);
            txtindice.TabIndex = 54;
            txtindice.Text = "0";
            txtindice.Visible = false;
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
            btnbuscar.TabIndex = 53;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(914, 41);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 51;
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(730, 40);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 50;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(642, 43);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 49;
            label11.Text = "Buscar por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(282, 55);
            txtid.Name = "txtid";
            txtid.Size = new Size(35, 27);
            txtid.TabIndex = 48;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // btnguardarcliente
            // 
            btnguardarcliente.BackColor = Color.DarkGreen;
            btnguardarcliente.Cursor = Cursors.Hand;
            btnguardarcliente.FlatAppearance.BorderColor = Color.Black;
            btnguardarcliente.FlatStyle = FlatStyle.Flat;
            btnguardarcliente.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardarcliente.ForeColor = Color.White;
            btnguardarcliente.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguardarcliente.IconColor = Color.White;
            btnguardarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarcliente.IconSize = 25;
            btnguardarcliente.Location = new Point(18, 402);
            btnguardarcliente.Name = "btnguardarcliente";
            btnguardarcliente.Size = new Size(299, 33);
            btnguardarcliente.TabIndex = 43;
            btnguardarcliente.Text = "Guardar";
            btnguardarcliente.TextAlign = ContentAlignment.MiddleRight;
            btnguardarcliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardarcliente.UseVisualStyleBackColor = false;
            btnguardarcliente.Click += btnguardar_Click;
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
            btnlimpiar.Location = new Point(18, 446);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(299, 33);
            btnlimpiar.TabIndex = 28;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
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
            label10.TabIndex = 47;
            label10.Text = "Lista de Clientes";
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
            btnlimpiarbuscador.TabIndex = 52;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, Documento, NombreCompleto, Correo, Telefono, EstadoValor, Estado });
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
            dgvdata.Size = new Size(866, 572);
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
            // Documento
            // 
            Documento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Documento.HeaderText = "Nro Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
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
            Estado.Width = 157;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 22);
            label9.Name = "label9";
            label9.Size = new Size(193, 29);
            label9.TabIndex = 45;
            label9.Text = "Detalle Cliente";
            // 
            // btneliminarcliente
            // 
            btneliminarcliente.BackColor = Color.DarkGreen;
            btneliminarcliente.Cursor = Cursors.Hand;
            btneliminarcliente.FlatAppearance.BorderColor = Color.Black;
            btneliminarcliente.FlatStyle = FlatStyle.Flat;
            btneliminarcliente.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminarcliente.ForeColor = Color.White;
            btneliminarcliente.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btneliminarcliente.IconColor = Color.White;
            btneliminarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarcliente.IconSize = 25;
            btneliminarcliente.Location = new Point(18, 491);
            btneliminarcliente.Name = "btneliminarcliente";
            btneliminarcliente.Size = new Size(299, 33);
            btneliminarcliente.TabIndex = 44;
            btneliminarcliente.Text = " Eliminar";
            btneliminarcliente.TextAlign = ContentAlignment.MiddleRight;
            btneliminarcliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminarcliente.UseVisualStyleBackColor = false;
            btneliminarcliente.Click += btneliminar_Click;
            // 
            // cbestado
            // 
            cbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestado.FormattingEnabled = true;
            cbestado.Location = new Point(18, 349);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(299, 28);
            cbestado.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(18, 326);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 40;
            label8.Text = "Estado:";
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(18, 280);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(299, 27);
            txttelefono.TabIndex = 36;
            txttelefono.KeyPress += txttelefono_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(18, 257);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 35;
            label5.Text = "Telefono:";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(18, 216);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(299, 27);
            txtcorreo.TabIndex = 34;
            txtcorreo.KeyPress += txtcorreo_KeyPress;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(18, 153);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(299, 27);
            txtnombrecompleto.TabIndex = 33;
            txtnombrecompleto.KeyPress += txtnombrecompleto_KeyPress;
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(18, 91);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(299, 27);
            txtdocumento.TabIndex = 32;
            txtdocumento.KeyPress += txtdocumento_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(18, 193);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 31;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(18, 130);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 30;
            label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 29;
            label2.Text = "NroDocumento:";
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
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(txtindice);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(btnguardarcliente);
            Controls.Add(btnlimpiar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(btneliminarcliente);
            Controls.Add(cbestado);
            Controls.Add(label8);
            Controls.Add(txttelefono);
            Controls.Add(label5);
            Controls.Add(txtcorreo);
            Controls.Add(txtnombrecompleto);
            Controls.Add(txtdocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCliente";
            Text = "frmCliente";
            Load += frmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label11;
        private TextBox txtid;
        private FontAwesome.Sharp.IconButton btnguardarcliente;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private DataGridView dgvdata;
        private Label label9;
        private FontAwesome.Sharp.IconButton btneliminarcliente;
        private ComboBox cbestado;
        private Label label8;
        private TextBox txttelefono;
        private Label label5;
        private TextBox txtcorreo;
        private TextBox txtnombrecompleto;
        private TextBox txtdocumento;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}