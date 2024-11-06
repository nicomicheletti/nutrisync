namespace CapaPresentacion.Modales
{
    partial class MD_DetallePermisoSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD_DetallePermisoSimple));
            label10 = new Label();
            cbestado = new ComboBox();
            label8 = new Label();
            txtnombrepermiso = new TextBox();
            label3 = new Label();
            txtnombremenu = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.White;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(325, 263);
            label10.TabIndex = 50;
            label10.Text = "Detalle del Permiso";
            // 
            // cbestado
            // 
            cbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestado.FormattingEnabled = true;
            cbestado.Location = new Point(52, 229);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(254, 28);
            cbestado.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(52, 206);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 59;
            label8.Text = "Estado:";
            // 
            // txtnombrepermiso
            // 
            txtnombrepermiso.Location = new Point(52, 88);
            txtnombrepermiso.Name = "txtnombrepermiso";
            txtnombrepermiso.ReadOnly = true;
            txtnombrepermiso.Size = new Size(254, 27);
            txtnombrepermiso.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(52, 65);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 57;
            label3.Text = "Nombre del Permiso:";
            // 
            // txtnombremenu
            // 
            txtnombremenu.Location = new Point(52, 160);
            txtnombremenu.Name = "txtnombremenu";
            txtnombremenu.ReadOnly = true;
            txtnombremenu.Size = new Size(254, 27);
            txtnombremenu.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(52, 137);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 61;
            label1.Text = "Nombre del Menu:";
            // 
            // MD_DetallePermisoSimple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(351, 281);
            Controls.Add(txtnombremenu);
            Controls.Add(label1);
            Controls.Add(cbestado);
            Controls.Add(label8);
            Controls.Add(txtnombrepermiso);
            Controls.Add(label3);
            Controls.Add(label10);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MD_DetallePermisoSimple";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MD_DetallePermisoSimple";
            Load += MD_DetallePermisoSimple_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private ComboBox cbestado;
        private Label label8;
        private TextBox txtnombrepermiso;
        private Label label3;
        private TextBox txtnombremenu;
        private Label label1;
    }
}