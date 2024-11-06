namespace CapaPresentacion
{
    partial class frmSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguridad));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtdocumento = new TextBox();
            txtnombrecompleto = new TextBox();
            txtcorreo = new TextBox();
            txtclave = new TextBox();
            label5 = new Label();
            txtconfirmarclave = new TextBox();
            label6 = new Label();
            label8 = new Label();
            cbestado = new ComboBox();
            label9 = new Label();
            dgvdata = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label10 = new Label();
            txtid = new TextBox();
            label11 = new Label();
            cbbusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            txtindice = new TextBox();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btneliminarusuario = new FontAwesome.Sharp.IconButton();
            btnguardarusuario = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnverpermisos = new FontAwesome.Sharp.IconButton();
            btngestionarpermisos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 683);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 193);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(12, 91);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(299, 27);
            txtdocumento.TabIndex = 4;
            txtdocumento.KeyPress += txtdocumento_KeyPress;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(12, 153);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(299, 27);
            txtnombrecompleto.TabIndex = 5;
            txtnombrecompleto.KeyPress += txtnombrecompleto_KeyPress;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(12, 216);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(299, 27);
            txtcorreo.TabIndex = 6;
            txtcorreo.KeyPress += txtcorreo_KeyPress;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(12, 280);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(299, 27);
            txtclave.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(12, 257);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 7;
            label5.Text = "Contraseña:";
            // 
            // txtconfirmarclave
            // 
            txtconfirmarclave.Location = new Point(12, 344);
            txtconfirmarclave.Name = "txtconfirmarclave";
            txtconfirmarclave.PasswordChar = '*';
            txtconfirmarclave.Size = new Size(299, 27);
            txtconfirmarclave.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(12, 321);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 9;
            label6.Text = "Confirmar contraseña:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(12, 384);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 12;
            label8.Text = "Estado:";
            // 
            // cbestado
            // 
            cbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestado.FormattingEnabled = true;
            cbestado.Location = new Point(12, 407);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(299, 28);
            cbestado.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 22);
            label9.Name = "label9";
            label9.Size = new Size(201, 29);
            label9.TabIndex = 17;
            label9.Text = "Detalle Usuario";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdUsuario, Documento, NombreCompleto, Correo, Clave, EstadoValor, Estado });
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
            dgvdata.Size = new Size(866, 575);
            dgvdata.TabIndex = 18;
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
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.MinimumWidth = 6;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            IdUsuario.Width = 125;
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
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 6;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            Clave.Width = 125;
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
            Estado.Width = 125;
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
            label10.TabIndex = 19;
            label10.Text = "Lista de Usuarios";
            // 
            // txtid
            // 
            txtid.Location = new Point(276, 55);
            txtid.Name = "txtid";
            txtid.Size = new Size(35, 27);
            txtid.TabIndex = 20;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(639, 41);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 21;
            label11.Text = "Buscar por:";
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(727, 38);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 22;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(911, 39);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 23;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(235, 55);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(35, 27);
            txtindice.TabIndex = 26;
            txtindice.Text = "0";
            txtindice.Visible = false;
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
            btnlimpiarbuscador.Location = new Point(1175, 40);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(39, 27);
            btnlimpiarbuscador.TabIndex = 61;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click_1;
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
            btnbuscar.TabIndex = 60;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // btneliminarusuario
            // 
            btneliminarusuario.BackColor = Color.DarkGreen;
            btneliminarusuario.Cursor = Cursors.Hand;
            btneliminarusuario.FlatStyle = FlatStyle.Popup;
            btneliminarusuario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminarusuario.ForeColor = Color.White;
            btneliminarusuario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btneliminarusuario.IconColor = Color.White;
            btneliminarusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarusuario.IconSize = 26;
            btneliminarusuario.Location = new Point(12, 547);
            btneliminarusuario.Name = "btneliminarusuario";
            btneliminarusuario.Size = new Size(299, 33);
            btneliminarusuario.TabIndex = 82;
            btneliminarusuario.Text = "Eliminar";
            btneliminarusuario.TextAlign = ContentAlignment.MiddleRight;
            btneliminarusuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminarusuario.UseVisualStyleBackColor = false;
            btneliminarusuario.Click += btneliminarusuario_Click;
            // 
            // btnguardarusuario
            // 
            btnguardarusuario.BackColor = Color.DarkGreen;
            btnguardarusuario.Cursor = Cursors.Hand;
            btnguardarusuario.FlatStyle = FlatStyle.Popup;
            btnguardarusuario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardarusuario.ForeColor = Color.White;
            btnguardarusuario.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguardarusuario.IconColor = Color.White;
            btnguardarusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarusuario.IconSize = 24;
            btnguardarusuario.ImageAlign = ContentAlignment.BottomCenter;
            btnguardarusuario.Location = new Point(12, 463);
            btnguardarusuario.Name = "btnguardarusuario";
            btnguardarusuario.Size = new Size(299, 33);
            btnguardarusuario.TabIndex = 81;
            btnguardarusuario.Text = "Guardar";
            btnguardarusuario.TextAlign = ContentAlignment.MiddleRight;
            btnguardarusuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardarusuario.UseVisualStyleBackColor = false;
            btnguardarusuario.Click += btnguardarusuario_Click_1;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.DarkGreen;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Popup;
            btnlimpiar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = Color.White;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 22;
            btnlimpiar.Location = new Point(12, 505);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(299, 33);
            btnlimpiar.TabIndex = 80;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click_1;
            // 
            // btnverpermisos
            // 
            btnverpermisos.BackColor = Color.DarkGreen;
            btnverpermisos.Cursor = Cursors.Hand;
            btnverpermisos.FlatAppearance.BorderColor = Color.Black;
            btnverpermisos.FlatStyle = FlatStyle.Popup;
            btnverpermisos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnverpermisos.ForeColor = Color.White;
            btnverpermisos.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            btnverpermisos.IconColor = Color.White;
            btnverpermisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnverpermisos.IconSize = 22;
            btnverpermisos.Location = new Point(12, 590);
            btnverpermisos.Name = "btnverpermisos";
            btnverpermisos.Size = new Size(299, 33);
            btnverpermisos.TabIndex = 79;
            btnverpermisos.Text = "Ver Permisos";
            btnverpermisos.TextAlign = ContentAlignment.MiddleRight;
            btnverpermisos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnverpermisos.UseVisualStyleBackColor = false;
            btnverpermisos.Click += btnverpermisos_Click_1;
            // 
            // btngestionarpermisos
            // 
            btngestionarpermisos.BackColor = Color.DarkGreen;
            btngestionarpermisos.Cursor = Cursors.Hand;
            btngestionarpermisos.FlatAppearance.BorderColor = Color.Black;
            btngestionarpermisos.FlatStyle = FlatStyle.Popup;
            btngestionarpermisos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btngestionarpermisos.ForeColor = Color.White;
            btngestionarpermisos.IconChar = FontAwesome.Sharp.IconChar.Key;
            btngestionarpermisos.IconColor = Color.White;
            btngestionarpermisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btngestionarpermisos.IconSize = 22;
            btngestionarpermisos.Location = new Point(12, 633);
            btngestionarpermisos.Name = "btngestionarpermisos";
            btngestionarpermisos.Size = new Size(299, 33);
            btngestionarpermisos.TabIndex = 83;
            btngestionarpermisos.Text = "Gestionar Permisos";
            btngestionarpermisos.TextAlign = ContentAlignment.MiddleRight;
            btngestionarpermisos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btngestionarpermisos.UseVisualStyleBackColor = false;
            btngestionarpermisos.Click += btngestionarpermisos_Click_1;
            // 
            // frmSeguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 683);
            Controls.Add(btngestionarpermisos);
            Controls.Add(btneliminarusuario);
            Controls.Add(btnguardarusuario);
            Controls.Add(btnlimpiar);
            Controls.Add(btnverpermisos);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btnbuscar);
            Controls.Add(txtindice);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(label10);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(cbestado);
            Controls.Add(label8);
            Controls.Add(txtconfirmarclave);
            Controls.Add(label6);
            Controls.Add(txtclave);
            Controls.Add(label5);
            Controls.Add(txtcorreo);
            Controls.Add(txtnombrecompleto);
            Controls.Add(txtdocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSeguridad";
            Text = "frmSeguridad";
            Load += frmSeguridad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtdocumento;
        private TextBox txtnombrecompleto;
        private TextBox txtcorreo;
        private TextBox txtclave;
        private Label label5;
        private TextBox txtconfirmarclave;
        private Label label6;
        private Label label8;
        private ComboBox cbestado;
        private Label label9;
        private DataGridView dgvdata;
        private Label label10;
        private TextBox txtid;
        private Label label11;
        private ComboBox cbbusqueda;
        private TextBox txtbusqueda;
        private TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btneliminarusuario;
        private FontAwesome.Sharp.IconButton btnguardarusuario;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnverpermisos;
        private FontAwesome.Sharp.IconButton btngestionarpermisos;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        /*
private FontAwesome.Sharp.IconButton btneliminarusuario;
private FontAwesome.Sharp.IconButton btnlimpiar;
private FontAwesome.Sharp.IconButton btnguardarusuario;
private FontAwesome.Sharp.IconButton btnbuscar;
private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
private FontAwesome.Sharp.IconButton btnverpermisos;
private FontAwesome.Sharp.IconButton btngestionarpermisos;
*/
    }
}