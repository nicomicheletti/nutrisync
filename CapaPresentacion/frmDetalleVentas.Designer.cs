namespace CapaPresentacion
{
    partial class frmDetalleVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleVentas));
            txtmontototal = new TextBox();
            dgvproducto = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            txtdoccliente = new TextBox();
            txtusuario = new TextBox();
            txttipodocumento = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtnombrecliente = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtfecha = new TextBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            txtnumdoc = new TextBox();
            groupBox1 = new GroupBox();
            txtnumerodocumento = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtpago = new TextBox();
            label10 = new Label();
            txtcambio = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvproducto).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtmontototal
            // 
            txtmontototal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtmontototal.Location = new Point(376, 634);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.ReadOnly = true;
            txtmontototal.Size = new Size(106, 27);
            txtmontototal.TabIndex = 48;
            txtmontototal.Text = "0";
            // 
            // dgvproducto
            // 
            dgvproducto.AllowUserToAddRows = false;
            dgvproducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproducto.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, SubTotal });
            dgvproducto.Location = new Point(173, 323);
            dgvproducto.Name = "dgvproducto";
            dgvproducto.ReadOnly = true;
            dgvproducto.RowHeadersWidth = 51;
            dgvproducto.RowTemplate.Height = 29;
            dgvproducto.Size = new Size(894, 294);
            dgvproducto.TabIndex = 46;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
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
            // txtdoccliente
            // 
            txtdoccliente.Location = new Point(13, 63);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.ReadOnly = true;
            txtdoccliente.Size = new Size(196, 27);
            txtdoccliente.TabIndex = 0;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(470, 63);
            txtusuario.Name = "txtusuario";
            txtusuario.ReadOnly = true;
            txtusuario.Size = new Size(244, 27);
            txtusuario.TabIndex = 7;
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(227, 63);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.ReadOnly = true;
            txttipodocumento.Size = new Size(229, 27);
            txttipodocumento.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(470, 38);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 5;
            label6.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 38);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 3;
            label4.Text = "Tipo Documento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 38);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 2;
            label5.Text = "Fecha:";
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(227, 63);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.ReadOnly = true;
            txtnombrecliente.Size = new Size(227, 27);
            txtnombrecliente.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 37);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 3;
            label7.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 38);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 2;
            label8.Text = "Numero Documento:";
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(13, 63);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(196, 27);
            txtfecha.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(277, 636);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 47;
            label9.Text = "Monto Total:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtnumdoc);
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtdoccliente);
            groupBox2.Location = new Point(267, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(726, 99);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Cliente";
            // 
            // txtnumdoc
            // 
            txtnumdoc.Location = new Point(659, 62);
            txtnumdoc.Name = "txtnumdoc";
            txtnumdoc.Size = new Size(55, 27);
            txtnumdoc.TabIndex = 28;
            txtnumdoc.Visible = false;
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
            groupBox1.Location = new Point(265, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 99);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Venta";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(812, 59);
            txtnumerodocumento.Multiline = true;
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.ReadOnly = true;
            txtnumerodocumento.Size = new Size(178, 28);
            txtnumerodocumento.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(657, 63);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 40;
            label3.Text = "Número Documento: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(128, 20);
            label2.Name = "label2";
            label2.Size = new Size(178, 29);
            label2.TabIndex = 39;
            label2.Text = "Detalle Venta";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(109, 10);
            label1.Name = "label1";
            label1.Size = new Size(1029, 663);
            label1.TabIndex = 38;
            // 
            // txtpago
            // 
            txtpago.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtpago.Location = new Point(599, 635);
            txtpago.Name = "txtpago";
            txtpago.ReadOnly = true;
            txtpago.Size = new Size(106, 27);
            txtpago.TabIndex = 50;
            txtpago.Text = "0";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(500, 637);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 49;
            label10.Text = "Monto Pago:";
            // 
            // txtcambio
            // 
            txtcambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtcambio.Location = new Point(846, 635);
            txtcambio.Name = "txtcambio";
            txtcambio.ReadOnly = true;
            txtcambio.Size = new Size(106, 27);
            txtcambio.TabIndex = 52;
            txtcambio.Text = "0";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(728, 637);
            label11.Name = "label11";
            label11.Size = new Size(112, 20);
            label11.TabIndex = 51;
            label11.Text = "Monto Cambio:";
            // 
            // frmDetalleVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(txtcambio);
            Controls.Add(label11);
            Controls.Add(txtpago);
            Controls.Add(label10);
            Controls.Add(txtmontototal);
            Controls.Add(dgvproducto);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtnumerodocumento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDetalleVentas";
            Text = "frmDetalleVentas";
            Load += frmDetalleVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvproducto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmontototal;
        private DataGridView dgvproducto;
        private TextBox txtdoccliente;
        private TextBox txtusuario;
        private TextBox txttipodocumento;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtnombrecliente;
        private Label label7;
        private Label label8;
        private TextBox txtfecha;
        private Label label9;
        private GroupBox groupBox2;
        private TextBox txtnumdoc;
        private GroupBox groupBox1;
        private TextBox txtnumerodocumento;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtpago;
        private Label label10;
        private TextBox txtcambio;
        private Label label11;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}