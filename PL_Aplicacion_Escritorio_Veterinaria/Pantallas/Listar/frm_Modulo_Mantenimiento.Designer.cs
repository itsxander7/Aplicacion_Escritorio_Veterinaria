
namespace PL_Aplicacion_Escritorio_Veterinaria.Pantallas.Listar
{
    partial class frm_Modulo_Mantenimiento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Modulo_Mantenimiento));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tls_btn_refrescar = new System.Windows.Forms.ToolStripButton();
            this.tls_lbl_refrescar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.tls_lbl_nuevo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_btn_modificar = new System.Windows.Forms.ToolStripButton();
            this.tls_lbl_modificar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.tls_lbl_eliminar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_lbl_Filtrar = new System.Windows.Forms.ToolStripLabel();
            this.tls_txt_Filtrar = new System.Windows.Forms.ToolStripTextBox();
            this.tls_btn_Filtrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_lbl_Limpiar = new System.Windows.Forms.ToolStripButton();
            this.tls_lbl_Cancel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_lbl_Salir = new System.Windows.Forms.ToolStripLabel();
            this.tls_btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Unidad de medida",
            "Método de valoración",
            "Status",
            "Moneda",
            "Estado",
            "Ubicación",
            "Forma de Entrega",
            "Código del Profesional",
            "Función",
            "Departamento",
            "Rol",
            "Tipo de Usuario",
            "Status Clave de Acceso",
            "Tipos de Cambio",
            "Teléfono",
            "Tipo de Servicio",
            "País",
            "Ciudad"});
            this.checkedListBox1.Location = new System.Drawing.Point(15, 75);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(174, 289);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Tipo de Enfermedad",
            "Tipo de Usuario",
            "Domicilio",
            "Raza",
            "Tipo de Contribuyente",
            "Dieta",
            "Cirugía",
            "Doctor"});
            this.checkedListBox2.Location = new System.Drawing.Point(195, 75);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(174, 289);
            this.checkedListBox2.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_btn_refrescar,
            this.tls_lbl_refrescar,
            this.toolStripSeparator2,
            this.tls_btn_nuevo,
            this.tls_lbl_nuevo,
            this.toolStripSeparator3,
            this.tls_btn_modificar,
            this.tls_lbl_modificar,
            this.toolStripSeparator4,
            this.tls_btn_eliminar,
            this.tls_lbl_eliminar,
            this.toolStripSeparator6,
            this.tls_lbl_Filtrar,
            this.tls_txt_Filtrar,
            this.tls_btn_Filtrar,
            this.toolStripSeparator7,
            this.tls_lbl_Limpiar,
            this.tls_lbl_Cancel,
            this.toolStripSeparator1,
            this.tls_lbl_Salir,
            this.tls_btn_Salir,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 39);
            this.toolStrip1.TabIndex = 62;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tls_btn_refrescar
            // 
            this.tls_btn_refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("tls_btn_refrescar.Image")));
            this.tls_btn_refrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_btn_refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_refrescar.Name = "tls_btn_refrescar";
            this.tls_btn_refrescar.Size = new System.Drawing.Size(36, 36);
            this.tls_btn_refrescar.Text = "toolStripButton1";
            this.tls_btn_refrescar.ToolTipText = "Refrescar";
            // 
            // tls_lbl_refrescar
            // 
            this.tls_lbl_refrescar.Name = "tls_lbl_refrescar";
            this.tls_lbl_refrescar.Size = new System.Drawing.Size(55, 36);
            this.tls_lbl_refrescar.Text = "Refrescar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tls_btn_nuevo
            // 
            this.tls_btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("tls_btn_nuevo.Image")));
            this.tls_btn_nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_nuevo.Name = "tls_btn_nuevo";
            this.tls_btn_nuevo.Size = new System.Drawing.Size(36, 36);
            this.tls_btn_nuevo.Text = "toolStripButton2";
            this.tls_btn_nuevo.ToolTipText = "Nuevo";
            // 
            // tls_lbl_nuevo
            // 
            this.tls_lbl_nuevo.Name = "tls_lbl_nuevo";
            this.tls_lbl_nuevo.Size = new System.Drawing.Size(42, 36);
            this.tls_lbl_nuevo.Text = "Nuevo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tls_btn_modificar
            // 
            this.tls_btn_modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("tls_btn_modificar.Image")));
            this.tls_btn_modificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_btn_modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_modificar.Name = "tls_btn_modificar";
            this.tls_btn_modificar.Size = new System.Drawing.Size(36, 36);
            this.tls_btn_modificar.Text = "toolStripButton3";
            this.tls_btn_modificar.ToolTipText = "Modificar";
            // 
            // tls_lbl_modificar
            // 
            this.tls_lbl_modificar.Name = "tls_lbl_modificar";
            this.tls_lbl_modificar.Size = new System.Drawing.Size(58, 36);
            this.tls_lbl_modificar.Text = "Modificar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tls_btn_eliminar
            // 
            this.tls_btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("tls_btn_eliminar.Image")));
            this.tls_btn_eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_eliminar.Name = "tls_btn_eliminar";
            this.tls_btn_eliminar.Size = new System.Drawing.Size(36, 36);
            this.tls_btn_eliminar.Text = "toolStripButton4";
            this.tls_btn_eliminar.ToolTipText = "Eliminar";
            // 
            // tls_lbl_eliminar
            // 
            this.tls_lbl_eliminar.Name = "tls_lbl_eliminar";
            this.tls_lbl_eliminar.Size = new System.Drawing.Size(50, 36);
            this.tls_lbl_eliminar.Text = "Eliminar";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tls_lbl_Filtrar
            // 
            this.tls_lbl_Filtrar.Name = "tls_lbl_Filtrar";
            this.tls_lbl_Filtrar.Size = new System.Drawing.Size(37, 36);
            this.tls_lbl_Filtrar.Text = "Filtrar";
            // 
            // tls_txt_Filtrar
            // 
            this.tls_txt_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tls_txt_Filtrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tls_txt_Filtrar.Name = "tls_txt_Filtrar";
            this.tls_txt_Filtrar.Size = new System.Drawing.Size(100, 39);
            // 
            // tls_btn_Filtrar
            // 
            this.tls_btn_Filtrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_Filtrar.Image = ((System.Drawing.Image)(resources.GetObject("tls_btn_Filtrar.Image")));
            this.tls_btn_Filtrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_btn_Filtrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_Filtrar.Name = "tls_btn_Filtrar";
            this.tls_btn_Filtrar.Size = new System.Drawing.Size(36, 36);
            this.tls_btn_Filtrar.Text = "toolStripButton1";
            this.tls_btn_Filtrar.ToolTipText = "Filtrar";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // tls_lbl_Limpiar
            // 
            this.tls_lbl_Limpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_lbl_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("tls_lbl_Limpiar.Image")));
            this.tls_lbl_Limpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_lbl_Limpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_lbl_Limpiar.Name = "tls_lbl_Limpiar";
            this.tls_lbl_Limpiar.Size = new System.Drawing.Size(36, 36);
            this.tls_lbl_Limpiar.Text = "toolStripButton1";
            this.tls_lbl_Limpiar.ToolTipText = "Filtrar";
            // 
            // tls_lbl_Cancel
            // 
            this.tls_lbl_Cancel.Name = "tls_lbl_Cancel";
            this.tls_lbl_Cancel.Size = new System.Drawing.Size(53, 36);
            this.tls_lbl_Cancel.Text = "Cancelar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tls_lbl_Salir
            // 
            this.tls_lbl_Salir.Name = "tls_lbl_Salir";
            this.tls_lbl_Salir.Size = new System.Drawing.Size(29, 36);
            this.tls_lbl_Salir.Text = "Salir";
            // 
            // tls_btn_Salir
            // 
            this.tls_btn_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("tls_btn_Salir.Image")));
            this.tls_btn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_btn_Salir.Name = "tls_btn_Salir";
            this.tls_btn_Salir.Size = new System.Drawing.Size(36, 36);
            this.tls_btn_Salir.Text = "toolStripButton2";
            this.tls_btn_Salir.ToolTipText = "Salir";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // frm_Modulo_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(809, 501);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "frm_Modulo_Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tls_btn_refrescar;
        private System.Windows.Forms.ToolStripLabel tls_lbl_refrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tls_btn_nuevo;
        private System.Windows.Forms.ToolStripLabel tls_lbl_nuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tls_btn_modificar;
        private System.Windows.Forms.ToolStripLabel tls_lbl_modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tls_btn_eliminar;
        private System.Windows.Forms.ToolStripLabel tls_lbl_eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel tls_lbl_Filtrar;
        private System.Windows.Forms.ToolStripTextBox tls_txt_Filtrar;
        private System.Windows.Forms.ToolStripButton tls_btn_Filtrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tls_lbl_Limpiar;
        private System.Windows.Forms.ToolStripLabel tls_lbl_Cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tls_lbl_Salir;
        private System.Windows.Forms.ToolStripButton tls_btn_Salir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}