namespace CapaPresentación
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            menu = new MenuStrip();
            menuseguridad = new FontAwesome.Sharp.IconMenuItem();
            submenuusuario = new ToolStripMenuItem();
            submenupermiso = new ToolStripMenuItem();
            submenugrupo = new ToolStripMenuItem();
            menuventas = new FontAwesome.Sharp.IconMenuItem();
            submenuClientes = new ToolStripMenuItem();
            submenuVentas = new ToolStripMenuItem();
            submenuhistorialventas = new ToolStripMenuItem();
            submenuauditoria = new ToolStripMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            submenuCategoria = new ToolStripMenuItem();
            submenuhistorialcompras = new ToolStripMenuItem();
            submenunegocio = new ToolStripMenuItem();
            submenuProducto = new ToolStripMenuItem();
            submenuProveedores = new ToolStripMenuItem();
            submenuCompras = new ToolStripMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            submenureportecompras = new ToolStripMenuItem();
            submenureporteventas = new ToolStripMenuItem();
            menubackup = new FontAwesome.Sharp.IconMenuItem();
            menuacercade = new FontAwesome.Sharp.IconMenuItem();
            contenedor = new Panel();
            label1 = new Label();
            lblUsuario = new Label();
            menuStrip1 = new MenuStrip();
            btnsalir = new FontAwesome.Sharp.IconButton();
            menumembresia = new FontAwesome.Sharp.IconMenuItem();
            submenucuota = new ToolStripMenuItem();
            submenupago = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuseguridad, menuventas, menucompras, menureportes, menubackup, menuacercade, menumembresia });
            menu.Location = new Point(0, 73);
            menu.Name = "menu";
            menu.Size = new Size(1253, 73);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuseguridad
            // 
            menuseguridad.AutoSize = false;
            menuseguridad.DropDownItems.AddRange(new ToolStripItem[] { submenuusuario, submenupermiso, submenugrupo });
            menuseguridad.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            menuseguridad.IconColor = Color.Black;
            menuseguridad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuseguridad.IconSize = 50;
            menuseguridad.ImageScaling = ToolStripItemImageScaling.None;
            menuseguridad.Name = "menuseguridad";
            menuseguridad.Size = new Size(85, 69);
            menuseguridad.Text = "Seguridad";
            menuseguridad.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuusuario
            // 
            submenuusuario.Name = "submenuusuario";
            submenuusuario.Size = new Size(150, 26);
            submenuusuario.Text = "Usuarios";
            submenuusuario.Click += submenuusuario_Click;
            // 
            // submenupermiso
            // 
            submenupermiso.Name = "submenupermiso";
            submenupermiso.Size = new Size(150, 26);
            submenupermiso.Text = "Permisos";
            submenupermiso.Click += submenupermiso_Click;
            // 
            // submenugrupo
            // 
            submenugrupo.Name = "submenugrupo";
            submenugrupo.Size = new Size(150, 26);
            submenugrupo.Text = "Grupos";
            submenugrupo.Click += submenugrupo_Click;
            // 
            // menuventas
            // 
            menuventas.AutoSize = false;
            menuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuClientes, submenuVentas, submenuhistorialventas, submenuauditoria });
            menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuventas.IconColor = Color.Black;
            menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuventas.IconSize = 50;
            menuventas.ImageScaling = ToolStripItemImageScaling.None;
            menuventas.Name = "menuventas";
            menuventas.Size = new Size(85, 69);
            menuventas.Text = "Ventas";
            menuventas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuClientes
            // 
            submenuClientes.Name = "submenuClientes";
            submenuClientes.Size = new Size(192, 26);
            submenuClientes.Text = "Clientes";
            submenuClientes.Click += submenuClientes_Click;
            // 
            // submenuVentas
            // 
            submenuVentas.Name = "submenuVentas";
            submenuVentas.Size = new Size(192, 26);
            submenuVentas.Text = "Registrar Venta";
            submenuVentas.Click += submenuVentas_Click;
            // 
            // submenuhistorialventas
            // 
            submenuhistorialventas.Name = "submenuhistorialventas";
            submenuhistorialventas.Size = new Size(192, 26);
            submenuhistorialventas.Text = "Ventas";
            submenuhistorialventas.Click += submenuhistorialventas_Click;
            // 
            // submenuauditoria
            // 
            submenuauditoria.Name = "submenuauditoria";
            submenuauditoria.Size = new Size(192, 26);
            submenuauditoria.Text = "Auditoria";
            submenuauditoria.Click += submenuauditoria_Click;
            // 
            // menucompras
            // 
            menucompras.AutoSize = false;
            menucompras.DropDownItems.AddRange(new ToolStripItem[] { submenuCategoria, submenuhistorialcompras, submenunegocio, submenuProducto, submenuProveedores, submenuCompras });
            menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            menucompras.IconColor = Color.Black;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.IconSize = 50;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(85, 69);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuCategoria
            // 
            submenuCategoria.Name = "submenuCategoria";
            submenuCategoria.Size = new Size(208, 26);
            submenuCategoria.Text = "Categoria";
            submenuCategoria.Click += submenuCategoria_Click;
            // 
            // submenuhistorialcompras
            // 
            submenuhistorialcompras.Name = "submenuhistorialcompras";
            submenuhistorialcompras.Size = new Size(208, 26);
            submenuhistorialcompras.Text = "Compras";
            submenuhistorialcompras.Click += submenuhistorialcompras_Click;
            // 
            // submenunegocio
            // 
            submenunegocio.Name = "submenunegocio";
            submenunegocio.Size = new Size(208, 26);
            submenunegocio.Text = "Negocio";
            submenunegocio.Click += submenunegocio_Click;
            // 
            // submenuProducto
            // 
            submenuProducto.Name = "submenuProducto";
            submenuProducto.Size = new Size(208, 26);
            submenuProducto.Text = "Producto";
            submenuProducto.Click += submenuProducto_Click;
            // 
            // submenuProveedores
            // 
            submenuProveedores.Name = "submenuProveedores";
            submenuProveedores.Size = new Size(208, 26);
            submenuProveedores.Text = "Proveedores";
            submenuProveedores.Click += submenuProveedores_Click;
            // 
            // submenuCompras
            // 
            submenuCompras.Name = "submenuCompras";
            submenuCompras.Size = new Size(208, 26);
            submenuCompras.Text = "Registrar Compra";
            submenuCompras.Click += submenuCompras_Click;
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.DropDownItems.AddRange(new ToolStripItem[] { submenureportecompras, submenureporteventas });
            menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.IconSize = 50;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(85, 69);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenureportecompras
            // 
            submenureportecompras.Name = "submenureportecompras";
            submenureportecompras.Size = new Size(208, 26);
            submenureportecompras.Text = "Reporte Compras";
            submenureportecompras.Click += submenureportecompras_Click;
            // 
            // submenureporteventas
            // 
            submenureporteventas.Name = "submenureporteventas";
            submenureporteventas.Size = new Size(208, 26);
            submenureporteventas.Text = "Reporte Ventas";
            submenureporteventas.Click += submenureporteventas_Click;
            // 
            // menubackup
            // 
            menubackup.AutoSize = false;
            menubackup.IconChar = FontAwesome.Sharp.IconChar.Cloud;
            menubackup.IconColor = Color.Black;
            menubackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menubackup.IconSize = 50;
            menubackup.ImageScaling = ToolStripItemImageScaling.None;
            menubackup.Name = "menubackup";
            menubackup.Size = new Size(85, 69);
            menubackup.Text = "BackUp";
            menubackup.TextImageRelation = TextImageRelation.ImageAboveText;
            menubackup.Click += menubackup_Click;
            // 
            // menuacercade
            // 
            menuacercade.AutoSize = false;
            menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuacercade.IconColor = Color.Black;
            menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuacercade.IconSize = 50;
            menuacercade.ImageScaling = ToolStripItemImageScaling.None;
            menuacercade.Name = "menuacercade";
            menuacercade.Size = new Size(85, 69);
            menuacercade.Text = "Acerca de";
            menuacercade.TextImageRelation = TextImageRelation.ImageAboveText;
            menuacercade.Click += menuacercade_Click;
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 146);
            contenedor.Margin = new Padding(3, 4, 3, 4);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1253, 683);
            contenedor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 17);
            label1.Name = "label1";
            label1.Size = new Size(228, 39);
            label1.TabIndex = 2;
            label1.Text = "NUTRISYINC";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.DarkGreen;
            lblUsuario.Location = new Point(1015, 29);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "lblUsuario";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DarkGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1253, 73);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnsalir
            // 
            btnsalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsalir.BackColor = Color.DarkGreen;
            btnsalir.FlatAppearance.BorderSize = 0;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnsalir.IconColor = Color.Black;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsalir.IconSize = 50;
            btnsalir.Location = new Point(1169, 10);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(72, 56);
            btnsalir.TabIndex = 7;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // menumembresia
            // 
            menumembresia.DropDownItems.AddRange(new ToolStripItem[] { submenucuota, submenupago });
            menumembresia.IconChar = FontAwesome.Sharp.IconChar.None;
            menumembresia.IconColor = Color.Black;
            menumembresia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menumembresia.Name = "menumembresia";
            menumembresia.Size = new Size(117, 69);
            menumembresia.Text = "Membresía";
            // 
            // submenucuota
            // 
            submenucuota.Name = "submenucuota";
            submenucuota.Size = new Size(224, 26);
            submenucuota.Text = "Cuota";
            submenucuota.Click += cuotaToolStripMenuItem_Click;
            // 
            // submenupago
            // 
            submenupago.Name = "submenupago";
            submenupago.Size = new Size(224, 26);
            submenupago.Text = "Pago";
            submenupago.Click += submenupago_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 829);
            Controls.Add(btnsalir);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Controls.Add(contenedor);
            Controls.Add(menu);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Inicio_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menuseguridad;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private Panel contenedor;
        private Label label1;
        private Label lblUsuario;
        private ToolStripMenuItem submenuClientes;
        private ToolStripMenuItem submenuProveedores;
        private ToolStripMenuItem submenuCategoria;
        private ToolStripMenuItem submenuProducto;
        private ToolStripMenuItem submenuVentas;
        private ToolStripMenuItem submenuCompras;
        private ToolStripMenuItem submenunegocio;
        private ToolStripMenuItem submenureportecompras;
        private ToolStripMenuItem submenureporteventas;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconButton btnsalir;
        private ToolStripMenuItem submenuusuario;
        private ToolStripMenuItem submenupermiso;
        private ToolStripMenuItem submenugrupo;
        private ToolStripMenuItem submenuhistorialcompras;
        private ToolStripMenuItem submenuhistorialventas;
        private ToolStripMenuItem submenuauditoria;
        private FontAwesome.Sharp.IconMenuItem menubackup;
        private FontAwesome.Sharp.IconMenuItem menumembresia;
        private ToolStripMenuItem submenucuota;
        private ToolStripMenuItem submenupago;
    }
}

