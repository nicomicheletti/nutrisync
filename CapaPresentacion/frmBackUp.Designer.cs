namespace CapaPresentacion
{
    partial class frmBackUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnresguardar = new FontAwesome.Sharp.IconButton();
            btnrestaurar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(188, 14);
            label1.Name = "label1";
            label1.Size = new Size(883, 646);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(323, 47);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 1;
            label2.Text = "Resguardo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(743, 47);
            label3.Name = "label3";
            label3.Size = new Size(194, 32);
            label3.TabIndex = 2;
            label3.Text = "Restauración";
            // 
            // label4
            // 
            label4.BackColor = Color.Lavender;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(223, 108);
            label4.Name = "label4";
            label4.Size = new Size(384, 516);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.BackColor = Color.Lavender;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(647, 108);
            label5.Name = "label5";
            label5.Size = new Size(384, 516);
            label5.TabIndex = 4;
            // 
            // btnresguardar
            // 
            btnresguardar.BackColor = Color.DarkGreen;
            btnresguardar.Cursor = Cursors.Hand;
            btnresguardar.FlatStyle = FlatStyle.Popup;
            btnresguardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnresguardar.IconChar = FontAwesome.Sharp.IconChar.CloudUploadAlt;
            btnresguardar.IconColor = Color.Black;
            btnresguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnresguardar.Location = new Point(277, 544);
            btnresguardar.Name = "btnresguardar";
            btnresguardar.Size = new Size(276, 51);
            btnresguardar.TabIndex = 5;
            btnresguardar.Text = "Resguardar";
            btnresguardar.TextAlign = ContentAlignment.MiddleRight;
            btnresguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnresguardar.UseVisualStyleBackColor = false;
            btnresguardar.Click += btnresguardar_Click;
            // 
            // btnrestaurar
            // 
            btnrestaurar.BackColor = Color.DarkGreen;
            btnrestaurar.Cursor = Cursors.Hand;
            btnrestaurar.FlatStyle = FlatStyle.Popup;
            btnrestaurar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnrestaurar.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            btnrestaurar.IconColor = Color.Black;
            btnrestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnrestaurar.Location = new Point(702, 544);
            btnrestaurar.Name = "btnrestaurar";
            btnrestaurar.Size = new Size(276, 51);
            btnrestaurar.TabIndex = 6;
            btnrestaurar.Text = "Restaurar";
            btnrestaurar.TextAlign = ContentAlignment.MiddleRight;
            btnrestaurar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnrestaurar.UseVisualStyleBackColor = false;
            btnrestaurar.Click += btnrestaurar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Lavender;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(240, 132);
            label6.Name = "label6";
            label6.Size = new Size(359, 20);
            label6.TabIndex = 7;
            label6.Text = "Presionar el botón de Resguardar para realizar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Lavender;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(241, 163);
            label7.Name = "label7";
            label7.Size = new Size(324, 20);
            label7.TabIndex = 8;
            label7.Text = "una copia de seguridad completa de todos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Lavender;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(241, 195);
            label8.Name = "label8";
            label8.Size = new Size(172, 20);
            label8.TabIndex = 9;
            label8.Text = "los datos del sistema.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Lavender;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(241, 242);
            label9.Name = "label9";
            label9.Size = new Size(262, 20);
            label9.TabIndex = 10;
            label9.Text = "Esta copia se guardará en la ruta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Lavender;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(317, 282);
            label10.Name = "label10";
            label10.Size = new Size(183, 20);
            label10.TabIndex = 11;
            label10.Text = "C:\\BackUp_Sistema\\";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Lavender;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(241, 320);
            label11.Name = "label11";
            label11.Size = new Size(214, 20);
            label11.TabIndex = 12;
            label11.Text = "El nombre del archivo sera:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Lavender;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(303, 354);
            label12.Name = "label12";
            label12.Size = new Size(203, 20);
            label12.TabIndex = 13;
            label12.Text = "Resguardo_(fecha).bak";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Lavender;
            label13.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(296, 440);
            label13.Name = "label13";
            label13.Size = new Size(231, 22);
            label13.TabIndex = 14;
            label13.Text = "SE RECOMIENDO REALIZAR";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Lavender;
            label14.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(284, 473);
            label14.Name = "label14";
            label14.Size = new Size(256, 22);
            label14.TabIndex = 15;
            label14.Text = "RESGUARDO SEMANALMENTE";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Lavender;
            label15.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(705, 440);
            label15.Name = "label15";
            label15.Size = new Size(273, 22);
            label15.TabIndex = 16;
            label15.Text = "REALIZAR RESTAURACION SOLO";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Lavender;
            label16.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(722, 473);
            label16.Name = "label16";
            label16.Size = new Size(243, 22);
            label16.TabIndex = 17;
            label16.Text = "EN CASO DE SER NECESARIO";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Lavender;
            label17.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(661, 195);
            label17.Name = "label17";
            label17.Size = new Size(113, 20);
            label17.TabIndex = 20;
            label17.Text = "en el sistema.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Lavender;
            label18.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(661, 163);
            label18.Name = "label18";
            label18.Size = new Size(353, 20);
            label18.TabIndex = 19;
            label18.Text = "todos los datos del último resguardo realizado";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Lavender;
            label19.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(660, 132);
            label19.Name = "label19";
            label19.Size = new Size(362, 20);
            label19.TabIndex = 18;
            label19.Text = "Presionar el botón de Restaurar para recuperar";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Lavender;
            label20.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(771, 265);
            label20.Name = "label20";
            label20.Size = new Size(115, 20);
            label20.TabIndex = 21;
            label20.Text = "¡ATENCION!";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Lavender;
            label21.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(658, 311);
            label21.Name = "label21";
            label21.Size = new Size(363, 20);
            label21.TabIndex = 22;
            label21.Text = "Todos los datos del sistema que no hayan";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Lavender;
            label22.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(689, 343);
            label22.Name = "label22";
            label22.Size = new Size(300, 20);
            label22.TabIndex = 23;
            label22.Text = "sido resguardados serán perdidos.";
            // 
            // frmBackUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 694);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnrestaurar);
            Controls.Add(btnresguardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBackUp";
            Text = "frmRestauracion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnresguardar;
        private FontAwesome.Sharp.IconButton btnrestaurar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
    }
}