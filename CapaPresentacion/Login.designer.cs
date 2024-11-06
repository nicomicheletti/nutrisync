namespace CapaPresentación
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtusuario = new TextBox();
            txtclave = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btningresar = new FontAwesome.Sharp.IconButton();
            btncancelar = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.ForestGreen;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 35);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            txtusuario.Anchor = AnchorStyles.None;
            txtusuario.CharacterCasing = CharacterCasing.Lower;
            txtusuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.Location = new Point(329, 110);
            txtusuario.Margin = new Padding(3, 4, 3, 4);
            txtusuario.Multiline = true;
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(443, 34);
            txtusuario.TabIndex = 1;
            // 
            // txtclave
            // 
            txtclave.Anchor = AnchorStyles.None;
            txtclave.CharacterCasing = CharacterCasing.Lower;
            txtclave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtclave.Location = new Point(329, 186);
            txtclave.Margin = new Padding(3, 4, 3, 4);
            txtclave.Multiline = true;
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(443, 34);
            txtclave.TabIndex = 2;
            txtclave.KeyDown += txtclave_KeyDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(336, 84);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 3;
            label2.Text = "NUMERO DOCUMENTO";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(336, 160);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 4;
            label3.Text = "CONTRASEÑA";
            // 
            // btningresar
            // 
            btningresar.Anchor = AnchorStyles.None;
            btningresar.BackColor = Color.ForestGreen;
            btningresar.Cursor = Cursors.Hand;
            btningresar.FlatAppearance.BorderColor = Color.Black;
            btningresar.FlatAppearance.BorderSize = 2;
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btningresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btningresar.IconColor = Color.Black;
            btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btningresar.IconSize = 30;
            btningresar.Location = new Point(329, 248);
            btningresar.Margin = new Padding(3, 4, 3, 4);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(214, 55);
            btningresar.TabIndex = 5;
            btningresar.Text = "INGRESAR";
            btningresar.TextAlign = ContentAlignment.MiddleRight;
            btningresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Anchor = AnchorStyles.None;
            btncancelar.BackColor = Color.ForestGreen;
            btncancelar.Cursor = Cursors.Hand;
            btncancelar.FlatAppearance.BorderColor = Color.Black;
            btncancelar.FlatAppearance.BorderSize = 2;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btncancelar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            btncancelar.IconColor = Color.Black;
            btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncancelar.IconSize = 30;
            btncancelar.Location = new Point(558, 248);
            btncancelar.Margin = new Padding(3, 4, 3, 4);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(214, 55);
            btncancelar.TabIndex = 6;
            btncancelar.Text = "CANCELAR";
            btncancelar.TextAlign = ContentAlignment.MiddleRight;
            btncancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(453, 24);
            label4.Name = "label4";
            label4.Size = new Size(199, 32);
            label4.TabIndex = 7;
            label4.Text = "Iniciar Sesión";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(830, 330);
            Controls.Add(label4);
            Controls.Add(btncancelar);
            Controls.Add(btningresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtclave);
            Controls.Add(txtusuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtusuario;
        private TextBox txtclave;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton btningresar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private Label label4;
    }
}