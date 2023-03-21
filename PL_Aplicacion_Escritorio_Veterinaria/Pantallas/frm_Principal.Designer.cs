
namespace PL_Aplicacion_Escritorio_Veterinaria.Pantallas
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.mniLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mniModulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ComprasProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_FacturacionServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_FacturacionProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOtrosModulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_IngresoExpediente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_RegistroArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_RegistroUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_RegistroSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniLogin,
            this.mniModulos,
            this.mniOtrosModulos,
            this.mniSalir});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(1349, 40);
            this.mnPrincipal.TabIndex = 4;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // mniLogin
            // 
            this.mniLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniLogin.ForeColor = System.Drawing.Color.Black;
            this.mniLogin.Image = ((System.Drawing.Image)(resources.GetObject("mniLogin.Image")));
            this.mniLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniLogin.Name = "mniLogin";
            this.mniLogin.Size = new System.Drawing.Size(97, 36);
            this.mniLogin.Text = "Login";
            this.mniLogin.Click += new System.EventHandler(this.mniLogin_Click);
            // 
            // mniModulos
            // 
            this.mniModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_ComprasProductos,
            this.tsm_FacturacionServicios,
            this.tsm_FacturacionProductos});
            this.mniModulos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniModulos.ForeColor = System.Drawing.Color.Black;
            this.mniModulos.Image = ((System.Drawing.Image)(resources.GetObject("mniModulos.Image")));
            this.mniModulos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniModulos.Name = "mniModulos";
            this.mniModulos.Size = new System.Drawing.Size(121, 36);
            this.mniModulos.Text = "Módulos";
            // 
            // tsm_ComprasProductos
            // 
            this.tsm_ComprasProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsm_ComprasProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsm_ComprasProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_ComprasProductos.Image = ((System.Drawing.Image)(resources.GetObject("tsm_ComprasProductos.Image")));
            this.tsm_ComprasProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm_ComprasProductos.Name = "tsm_ComprasProductos";
            this.tsm_ComprasProductos.Size = new System.Drawing.Size(265, 38);
            this.tsm_ComprasProductos.Text = "Compras";
            this.tsm_ComprasProductos.Click += new System.EventHandler(this.tsm_ComprasProductos_Click);
            // 
            // tsm_FacturacionServicios
            // 
            this.tsm_FacturacionServicios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tsm_FacturacionServicios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsm_FacturacionServicios.Image = ((System.Drawing.Image)(resources.GetObject("tsm_FacturacionServicios.Image")));
            this.tsm_FacturacionServicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm_FacturacionServicios.Name = "tsm_FacturacionServicios";
            this.tsm_FacturacionServicios.Size = new System.Drawing.Size(265, 38);
            this.tsm_FacturacionServicios.Text = "Facturación de Servicios";
            this.tsm_FacturacionServicios.Click += new System.EventHandler(this.tsm_FacturacionServicios_Click);
            // 
            // tsm_FacturacionProductos
            // 
            this.tsm_FacturacionProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tsm_FacturacionProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsm_FacturacionProductos.Image = ((System.Drawing.Image)(resources.GetObject("tsm_FacturacionProductos.Image")));
            this.tsm_FacturacionProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm_FacturacionProductos.Name = "tsm_FacturacionProductos";
            this.tsm_FacturacionProductos.Size = new System.Drawing.Size(265, 38);
            this.tsm_FacturacionProductos.Text = "Facturación de Productos";
            this.tsm_FacturacionProductos.Click += new System.EventHandler(this.tsm_FacturacionProductos_Click);
            // 
            // mniOtrosModulos
            // 
            this.mniOtrosModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_IngresoExpediente,
            this.tsm_RegistroArticulos,
            this.tsm_RegistroUsuarios,
            this.tsm_RegistroSocios,
            this.tsm_Reportes,
            this.tsm_Mantenimiento});
            this.mniOtrosModulos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.mniOtrosModulos.Image = ((System.Drawing.Image)(resources.GetObject("mniOtrosModulos.Image")));
            this.mniOtrosModulos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniOtrosModulos.Name = "mniOtrosModulos";
            this.mniOtrosModulos.Size = new System.Drawing.Size(166, 36);
            this.mniOtrosModulos.Text = "Otros módulos";
            // 
            // tsm_IngresoExpediente
            // 
            this.tsm_IngresoExpediente.BackColor = System.Drawing.Color.LightGray;
            this.tsm_IngresoExpediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsm_IngresoExpediente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_IngresoExpediente.Image = ((System.Drawing.Image)(resources.GetObject("tsm_IngresoExpediente.Image")));
            this.tsm_IngresoExpediente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm_IngresoExpediente.Name = "tsm_IngresoExpediente";
            this.tsm_IngresoExpediente.Size = new System.Drawing.Size(248, 38);
            this.tsm_IngresoExpediente.Text = "Ingreso del Expediente";
            this.tsm_IngresoExpediente.Click += new System.EventHandler(this.tsm_IngresoExpediente_Click);
            // 
            // tsm_RegistroArticulos
            // 
            this.tsm_RegistroArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsm_RegistroArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsm_RegistroArticulos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_RegistroArticulos.Image = ((System.Drawing.Image)(resources.GetObject("tsm_RegistroArticulos.Image")));
            this.tsm_RegistroArticulos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm_RegistroArticulos.Name = "tsm_RegistroArticulos";
            this.tsm_RegistroArticulos.Size = new System.Drawing.Size(248, 38);
            this.tsm_RegistroArticulos.Text = "Registro de Articulos";
            this.tsm_RegistroArticulos.Click += new System.EventHandler(this.tsm_RegistroArticulos_Click);
            // 
            // tsm_RegistroUsuarios
            // 
            this.tsm_RegistroUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsm_RegistroUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsm_RegistroUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_RegistroUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsm_RegistroUsuarios.Image")));
            this.tsm_RegistroUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm_RegistroUsuarios.Name = "tsm_RegistroUsuarios";
            this.tsm_RegistroUsuarios.Size = new System.Drawing.Size(248, 38);
            this.tsm_RegistroUsuarios.Text = "Registro de Usuarios";
            this.tsm_RegistroUsuarios.Click += new System.EventHandler(this.tsm_RegistroUsuarios_Click);
            // 
            // tsm_RegistroSocios
            // 
            this.tsm_RegistroSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsm_RegistroSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsm_RegistroSocios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_RegistroSocios.Image = ((System.Drawing.Image)(resources.GetObject("tsm_RegistroSocios.Image")));
            this.tsm_RegistroSocios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm_RegistroSocios.Name = "tsm_RegistroSocios";
            this.tsm_RegistroSocios.Size = new System.Drawing.Size(248, 38);
            this.tsm_RegistroSocios.Text = "Registro de Socios";
            this.tsm_RegistroSocios.Click += new System.EventHandler(this.tsm_RegistroSocios_Click);
            // 
            // tsm_Reportes
            // 
            this.tsm_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tsm_Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsm_Reportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Reportes.Image")));
            this.tsm_Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm_Reportes.Name = "tsm_Reportes";
            this.tsm_Reportes.Size = new System.Drawing.Size(248, 38);
            this.tsm_Reportes.Text = "Reportes";
            this.tsm_Reportes.Click += new System.EventHandler(this.tsm_Reportes_Click);
            // 
            // tsm_Mantenimiento
            // 
            this.tsm_Mantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tsm_Mantenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsm_Mantenimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_Mantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Mantenimiento.Image")));
            this.tsm_Mantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsm_Mantenimiento.Name = "tsm_Mantenimiento";
            this.tsm_Mantenimiento.Size = new System.Drawing.Size(248, 38);
            this.tsm_Mantenimiento.Text = "Mantenimiento";
            this.tsm_Mantenimiento.Click += new System.EventHandler(this.tsm_Mantenimiento_Click);
            // 
            // mniSalir
            // 
            this.mniSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.mniSalir.Image = ((System.Drawing.Image)(resources.GetObject("mniSalir.Image")));
            this.mniSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniSalir.Name = "mniSalir";
            this.mniSalir.Size = new System.Drawing.Size(88, 36);
            this.mniSalir.Text = "Salir";
            this.mniSalir.Click += new System.EventHandler(this.mniSalir_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.mnPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Principal_FormClosing);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mniLogin;
        private System.Windows.Forms.ToolStripMenuItem mniModulos;
        private System.Windows.Forms.ToolStripMenuItem tsm_ComprasProductos;
        private System.Windows.Forms.ToolStripMenuItem tsm_FacturacionProductos;
        private System.Windows.Forms.ToolStripMenuItem mniSalir;
        private System.Windows.Forms.ToolStripMenuItem mniOtrosModulos;
        private System.Windows.Forms.ToolStripMenuItem tsm_FacturacionServicios;
        private System.Windows.Forms.ToolStripMenuItem tsm_IngresoExpediente;
        private System.Windows.Forms.ToolStripMenuItem tsm_RegistroArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsm_Mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsm_Reportes;
        private System.Windows.Forms.ToolStripMenuItem tsm_RegistroUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsm_RegistroSocios;
    }
}