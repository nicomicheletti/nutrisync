namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleCompra));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnumerodocumento = new TextBox();
            groupBox1 = new GroupBox();
            txtusuario = new TextBox();
            txttipodocumento = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtfecha = new TextBox();
            groupBox2 = new GroupBox();
            txtnumdoc = new TextBox();
            txtrazonsocial = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtdocproveedor = new TextBox();
            dgvproducto = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label9 = new Label();
            txtmontototal = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(106, 8);
            label1.Name = "label1";
            label1.Size = new Size(1029, 663);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 18);
            label2.Name = "label2";
            label2.Size = new Size(203, 29);
            label2.TabIndex = 22;
            label2.Text = "Detalle Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(636, 56);
            label3.Name = "label3";
            label3.Size = new Size(148, 18);
            label3.TabIndex = 23;
            label3.Text = "Número Documento:";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(788, 52);
            txtnumerodocumento.Multiline = true;
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.ReadOnly = true;
            txtnumerodocumento.Size = new Size(178, 28);
            txtnumerodocumento.TabIndex = 31;
            txtnumerodocumento.KeyPress += txtbusqueda_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Location = new Point(240, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 99);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Compra";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(470, 63);
            txtusuario.Name = "txtusuario";
            txtusuario.ReadOnly = true;
            txtusuario.Size = new Size(244, 24);
            txtusuario.TabIndex = 7;
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(227, 63);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.ReadOnly = true;
            txttipodocumento.Size = new Size(229, 24);
            txttipodocumento.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(470, 38);
            label6.Name = "label6";
            label6.Size = new Size(64, 18);
            label6.TabIndex = 5;
            label6.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 38);
            label4.Name = "label4";
            label4.Size = new Size(123, 18);
            label4.TabIndex = 3;
            label4.Text = "Tipo Documento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 38);
            label5.Name = "label5";
            label5.Size = new Size(53, 18);
            label5.TabIndex = 2;
            label5.Text = "Fecha:";
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(13, 63);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(196, 24);
            txtfecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtnumdoc);
            groupBox2.Controls.Add(txtrazonsocial);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Location = new Point(242, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(726, 99);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Proveedor";
            // 
            // txtnumdoc
            // 
            txtnumdoc.Location = new Point(659, 62);
            txtnumdoc.Name = "txtnumdoc";
            txtnumdoc.Size = new Size(55, 24);
            txtnumdoc.TabIndex = 28;
            txtnumdoc.Visible = false;
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.Location = new Point(227, 63);
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.ReadOnly = true;
            txtrazonsocial.Size = new Size(236, 24);
            txtrazonsocial.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 37);
            label7.Name = "label7";
            label7.Size = new Size(101, 18);
            label7.TabIndex = 3;
            label7.Text = "Razón Social:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 38);
            label8.Name = "label8";
            label8.Size = new Size(148, 18);
            label8.TabIndex = 2;
            label8.Text = "Numero Documento:";
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(13, 63);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.ReadOnly = true;
            txtdocproveedor.Size = new Size(196, 24);
            txtdocproveedor.TabIndex = 0;
            // 
            // dgvproducto
            // 
            dgvproducto.AllowUserToAddRows = false;
            dgvproducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproducto.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, SubTotal });
            dgvproducto.Location = new Point(163, 321);
            dgvproducto.Name = "dgvproducto";
            dgvproducto.ReadOnly = true;
            dgvproducto.RowHeadersWidth = 51;
            dgvproducto.RowTemplate.Height = 29;
            dgvproducto.Size = new Size(917, 294);
            dgvproducto.TabIndex = 35;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubTotal.HeaderText = "Sub Total";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(242, 634);
            label9.Name = "label9";
            label9.Size = new Size(92, 18);
            label9.TabIndex = 36;
            label9.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            txtmontototal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtmontototal.Location = new Point(334, 631);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.ReadOnly = true;
            txtmontototal.Size = new Size(122, 24);
            txtmontototal.TabIndex = 37;
            txtmontototal.Text = "0";
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(txtmontototal);
            Controls.Add(label9);
            Controls.Add(dgvproducto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtnumerodocumento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDetalleCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetalleCompra";
            Load += frmDetalleCompra_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnumerodocumento;
        private GroupBox groupBox1;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtfecha;
        private TextBox txtusuario;
        private TextBox txttipodocumento;
        private GroupBox groupBox2;
        private TextBox txtnumdoc;
        private TextBox txtrazonsocial;
        private Label label7;
        private Label label8;
        private TextBox txtdocproveedor;
        private DataGridView dgvproducto;
        private Label label9;
        private TextBox txtmontototal;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}