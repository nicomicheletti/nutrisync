namespace CapaPresentacion.Modales
{
    partial class MD_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD_Proveedor));
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label11 = new Label();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btnbuscar
            // 
            btnbuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnbuscar.BackColor = Color.White;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.ForeColor = Color.White;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 22;
            btnbuscar.Location = new Point(561, 60);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(39, 28);
            btnbuscar.TabIndex = 60;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Location = new Point(350, 61);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(200, 27);
            txtbusqueda.TabIndex = 58;
            // 
            // cbbusqueda
            // 
            cbbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(166, 60);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(172, 28);
            cbbusqueda.TabIndex = 57;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(78, 63);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 56;
            label11.Text = "Buscar por:";
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlimpiarbuscador.BackColor = Color.White;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpiarbuscador.ForeColor = Color.White;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.Black;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 23;
            btnlimpiarbuscador.Location = new Point(613, 61);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(39, 27);
            btnlimpiarbuscador.TabIndex = 59;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, Documento, RazonSocial });
            dgvdata.Location = new Point(12, 122);
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
            dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ActiveCaption;
            dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdata.Size = new Size(657, 265);
            dgvdata.TabIndex = 54;
            dgvdata.CellDoubleClick += dgvdata_CellDoubleClick;
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
            // RazonSocial
            // 
            RazonSocial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.MinimumWidth = 6;
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(657, 99);
            label10.TabIndex = 55;
            label10.Text = "Lista de Proveedores";
            // 
            // MD_Proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(687, 397);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label11);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(dgvdata);
            Controls.Add(label10);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MD_Proveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MD_Proveedor";
            Load += MD_Proveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private DataGridView dgvdata;
        private Label label10;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn RazonSocial;
    }
}