namespace CapaPresentacion
{
    partial class frmNegocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNegocio));
            label9 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            txtdireccion = new TextBox();
            txtruc = new TextBox();
            txtnombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnSubir = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            picLogo = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGreen;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(32, 23);
            label9.Name = "label9";
            label9.Size = new Size(207, 29);
            label9.TabIndex = 19;
            label9.Text = "Detalle Negocio";
            // 
            // label1
            // 
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(645, 694);
            label1.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnGuardarCambios);
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(txtruc);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnSubir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(picLogo);
            groupBox1.Location = new Point(32, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 306);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.Gg;
            btnGuardarCambios.IconColor = Color.Black;
            btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarCambios.IconSize = 25;
            btnGuardarCambios.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardarCambios.Location = new Point(256, 244);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(299, 32);
            btnGuardarCambios.TabIndex = 13;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(256, 193);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(299, 27);
            txtdireccion.TabIndex = 12;
            // 
            // txtruc
            // 
            txtruc.Location = new Point(256, 128);
            txtruc.Name = "txtruc";
            txtruc.Size = new Size(299, 27);
            txtruc.TabIndex = 11;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(256, 62);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(299, 27);
            txtnombre.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(256, 170);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(256, 106);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "R.U.C :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(256, 39);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 7;
            label5.Text = "Nombre Negocio:";
            // 
            // btnSubir
            // 
            btnSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnSubir.IconColor = Color.Black;
            btnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSubir.IconSize = 25;
            btnSubir.ImageAlign = ContentAlignment.MiddleRight;
            btnSubir.Location = new Point(27, 244);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(180, 32);
            btnSubir.TabIndex = 2;
            btnSubir.Text = "Subir";
            btnSubir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 39);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Logo:";
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(27, 67);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(180, 167);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1249, 694);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnSubir;
        private Label label2;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private TextBox txtdireccion;
        private TextBox txtruc;
        private TextBox txtnombre;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}