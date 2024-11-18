namespace CapaPresentacion
{
    partial class frmPago
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
            btnguardarpago = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            btneliminarpago = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtindice = new TextBox();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label11 = new Label();
            txtid = new TextBox();
            dgvdata = new DataGridView();
            label9 = new Label();
            cbcuota = new ComboBox();
            cbcliente = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtprecio = new TextBox();
            txtfecha = new TextBox();
            txtcodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btnguardarpago
            // 
            btnguardarpago.BackColor = Color.DarkGreen;
            btnguardarpago.Cursor = Cursors.Hand;
            btnguardarpago.FlatAppearance.BorderColor = Color.Black;
            btnguardarpago.FlatStyle = FlatStyle.Flat;
            btnguardarpago.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardarpago.ForeColor = Color.White;
            btnguardarpago.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnguardarpago.IconColor = Color.White;
            btnguardarpago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardarpago.IconSize = 25;
            btnguardarpago.Location = new Point(26, 393);
            btnguardarpago.Name = "btnguardarpago";
            btnguardarpago.Size = new Size(299, 33);
            btnguardarpago.TabIndex = 81;
            btnguardarpago.Text = "Guardar";
            btnguardarpago.TextAlign = ContentAlignment.MiddleRight;
            btnguardarpago.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardarpago.UseVisualStyleBackColor = false;
            btnguardarpago.Click += btnguardarproducto_Click;
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
            btnlimpiar.Location = new Point(26, 432);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(299, 33);
            btnlimpiar.TabIndex = 80;
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
            btnlimpiarbuscador.Location = new Point(1203, 31);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(39, 27);
            btnlimpiarbuscador.TabIndex = 83;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // btneliminarpago
            // 
            btneliminarpago.BackColor = Color.DarkGreen;
            btneliminarpago.Cursor = Cursors.Hand;
            btneliminarpago.FlatAppearance.BorderColor = Color.Black;
            btneliminarpago.FlatStyle = FlatStyle.Flat;
            btneliminarpago.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminarpago.ForeColor = Color.White;
            btneliminarpago.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btneliminarpago.IconColor = Color.White;
            btneliminarpago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminarpago.IconSize = 25;
            btneliminarpago.Location = new Point(26, 471);
            btneliminarpago.Name = "btneliminarpago";
            btneliminarpago.Size = new Size(299, 33);
            btneliminarpago.TabIndex = 82;
            btneliminarpago.Text = " Eliminar";
            btneliminarpago.TextAlign = ContentAlignment.MiddleRight;
            btneliminarpago.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminarpago.UseVisualStyleBackColor = false;
            btneliminarpago.Click += btneliminarproducto_Click;
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
            btnbuscar.Location = new Point(1153, 30);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(39, 28);
            btnbuscar.TabIndex = 79;
            btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(266, 46);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(35, 27);
            txtindice.TabIndex = 78;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(939, 31);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 77;
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(755, 30);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 76;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(667, 33);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 75;
            label11.Text = "Buscar por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(307, 46);
            txtid.Name = "txtid";
            txtid.Size = new Size(35, 27);
            txtid.TabIndex = 74;
            txtid.Text = "0";
            txtid.Visible = false;
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
            dgvdata.Location = new Point(395, 82);
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
            dgvdata.TabIndex = 72;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(43, 13);
            label9.Name = "label9";
            label9.Size = new Size(170, 29);
            label9.TabIndex = 71;
            label9.Text = "Detalle Pago";
            // 
            // cbcuota
            // 
            cbcuota.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcuota.FormattingEnabled = true;
            cbcuota.Location = new Point(43, 342);
            cbcuota.Name = "cbcuota";
            cbcuota.Size = new Size(282, 28);
            cbcuota.TabIndex = 70;
            // 
            // cbcliente
            // 
            cbcliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcliente.FormattingEnabled = true;
            cbcliente.Location = new Point(43, 276);
            cbcliente.Name = "cbcliente";
            cbcliente.Size = new Size(282, 28);
            cbcliente.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(43, 319);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 68;
            label8.Text = "Cuota:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(43, 253);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 67;
            label7.Text = "Cliente:";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(43, 207);
            txtprecio.Name = "txtprecio";
            txtprecio.ReadOnly = true;
            txtprecio.Size = new Size(282, 27);
            txtprecio.TabIndex = 66;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(43, 144);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(282, 27);
            txtfecha.TabIndex = 65;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(43, 82);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.ReadOnly = true;
            txtcodigo.Size = new Size(282, 27);
            txtcodigo.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(43, 184);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 63;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(43, 121);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 62;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(43, 59);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 61;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 631);
            label1.TabIndex = 60;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(395, 13);
            label10.Name = "label10";
            label10.Size = new Size(866, 60);
            label10.TabIndex = 73;
            label10.Text = "Lista de Pagos";
            // 
            // frmPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 631);
            Controls.Add(btnguardarpago);
            Controls.Add(btnlimpiar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(btneliminarpago);
            Controls.Add(btnbuscar);
            Controls.Add(txtindice);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(txtid);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(cbcuota);
            Controls.Add(cbcliente);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtprecio);
            Controls.Add(txtfecha);
            Controls.Add(txtcodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Name = "frmPago";
            Text = "frmPago";
            Load += frmPago_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnguardarpago;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btneliminarpago;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtindice;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label11;
        private TextBox txtid;
        private DataGridView dgvdata;
        private Label label9;
        private ComboBox cbcuota;
        private ComboBox cbcliente;
        private Label label8;
        private Label label7;
        private TextBox txtprecio;
        private TextBox txtfecha;
        private TextBox txtcodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
    }
}