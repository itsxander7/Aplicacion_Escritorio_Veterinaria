
namespace PL_Aplicacion_Escritorio_Veterinaria.Pantallas.Listar
{
    partial class frm_Entrada_Articulos
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
            System.Windows.Forms.GroupBox gb_EntradaArticulos;
            System.Windows.Forms.Label lbl_IdProveedor;
            System.Windows.Forms.Label lbl_NombreProveedor;
            System.Windows.Forms.Label lbl_Moneda;
            System.Windows.Forms.Label lbl_IdTransaccion;
            System.Windows.Forms.Label lbl_FechaVencimiento;
            System.Windows.Forms.Label lbl_Consecutivo;
            System.Windows.Forms.Label lbl_Estado;
            System.Windows.Forms.Label lbl_FechaTransacción;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Entrada_Articulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtb_FechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.mtb_FechaTransaccion = new System.Windows.Forms.MaskedTextBox();
            this.txt_IdTransaccion = new System.Windows.Forms.TextBox();
            this.lsb_IdProveedor = new System.Windows.Forms.ListBox();
            this.lsb_Moneda = new System.Windows.Forms.ListBox();
            this.txt_NombreProveedor = new System.Windows.Forms.TextBox();
            this.txt_Consecutivo = new System.Windows.Forms.TextBox();
            this.lsb_Estado = new System.Windows.Forms.ListBox();
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
            this.txt_Comentarios = new System.Windows.Forms.TextBox();
            this.lbl_Comentarios = new System.Windows.Forms.Label();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.txt_GastosAdicionales = new System.Windows.Forms.TextBox();
            this.lbl_GastosAdicionales = new System.Windows.Forms.Label();
            this.txt_IVA = new System.Windows.Forms.TextBox();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgv_Entrada_Articulos = new System.Windows.Forms.DataGridView();
            this.dt_CodigoArticulo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dt_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_FechaCaducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Ubicación = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dt_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Unidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dt_Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gb_EntradaArticulos = new System.Windows.Forms.GroupBox();
            lbl_IdProveedor = new System.Windows.Forms.Label();
            lbl_NombreProveedor = new System.Windows.Forms.Label();
            lbl_Moneda = new System.Windows.Forms.Label();
            lbl_IdTransaccion = new System.Windows.Forms.Label();
            lbl_FechaVencimiento = new System.Windows.Forms.Label();
            lbl_Consecutivo = new System.Windows.Forms.Label();
            lbl_Estado = new System.Windows.Forms.Label();
            lbl_FechaTransacción = new System.Windows.Forms.Label();
            gb_EntradaArticulos.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entrada_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_EntradaArticulos
            // 
            gb_EntradaArticulos.BackColor = System.Drawing.Color.LightPink;
            gb_EntradaArticulos.Controls.Add(this.mtb_FechaVencimiento);
            gb_EntradaArticulos.Controls.Add(this.mtb_FechaTransaccion);
            gb_EntradaArticulos.Controls.Add(this.txt_IdTransaccion);
            gb_EntradaArticulos.Controls.Add(lbl_IdProveedor);
            gb_EntradaArticulos.Controls.Add(lbl_NombreProveedor);
            gb_EntradaArticulos.Controls.Add(lbl_Moneda);
            gb_EntradaArticulos.Controls.Add(lbl_IdTransaccion);
            gb_EntradaArticulos.Controls.Add(this.lsb_IdProveedor);
            gb_EntradaArticulos.Controls.Add(this.lsb_Moneda);
            gb_EntradaArticulos.Controls.Add(this.txt_NombreProveedor);
            gb_EntradaArticulos.Controls.Add(lbl_FechaVencimiento);
            gb_EntradaArticulos.Controls.Add(lbl_Consecutivo);
            gb_EntradaArticulos.Controls.Add(lbl_Estado);
            gb_EntradaArticulos.Controls.Add(lbl_FechaTransacción);
            gb_EntradaArticulos.Controls.Add(this.txt_Consecutivo);
            gb_EntradaArticulos.Controls.Add(this.lsb_Estado);
            gb_EntradaArticulos.ForeColor = System.Drawing.SystemColors.HotTrack;
            gb_EntradaArticulos.Location = new System.Drawing.Point(50, 55);
            gb_EntradaArticulos.Name = "gb_EntradaArticulos";
            gb_EntradaArticulos.Size = new System.Drawing.Size(717, 146);
            gb_EntradaArticulos.TabIndex = 34;
            gb_EntradaArticulos.TabStop = false;
            gb_EntradaArticulos.Text = "Información";
            // 
            // mtb_FechaVencimiento
            // 
            this.mtb_FechaVencimiento.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mtb_FechaVencimiento.Enabled = false;
            this.mtb_FechaVencimiento.Location = new System.Drawing.Point(553, 117);
            this.mtb_FechaVencimiento.Mask = "00/00/0000";
            this.mtb_FechaVencimiento.Name = "mtb_FechaVencimiento";
            this.mtb_FechaVencimiento.Size = new System.Drawing.Size(120, 20);
            this.mtb_FechaVencimiento.TabIndex = 20;
            this.mtb_FechaVencimiento.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_FechaVencimiento_Validating);
            // 
            // mtb_FechaTransaccion
            // 
            this.mtb_FechaTransaccion.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mtb_FechaTransaccion.Enabled = false;
            this.mtb_FechaTransaccion.Location = new System.Drawing.Point(553, 84);
            this.mtb_FechaTransaccion.Mask = "00/00/0000";
            this.mtb_FechaTransaccion.Name = "mtb_FechaTransaccion";
            this.mtb_FechaTransaccion.Size = new System.Drawing.Size(120, 20);
            this.mtb_FechaTransaccion.TabIndex = 19;
            this.mtb_FechaTransaccion.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_FechaTransaccion_Validating);
            // 
            // txt_IdTransaccion
            // 
            this.txt_IdTransaccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdTransaccion.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_IdTransaccion.Enabled = false;
            this.txt_IdTransaccion.Location = new System.Drawing.Point(146, 120);
            this.txt_IdTransaccion.MaxLength = 20;
            this.txt_IdTransaccion.Name = "txt_IdTransaccion";
            this.txt_IdTransaccion.Size = new System.Drawing.Size(120, 20);
            this.txt_IdTransaccion.TabIndex = 14;
            this.txt_IdTransaccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdTransaccion_KeyPress);
            this.txt_IdTransaccion.Leave += new System.EventHandler(this.txt_IdTransaccion_Leave);
            // 
            // lbl_IdProveedor
            // 
            lbl_IdProveedor.AutoSize = true;
            lbl_IdProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_IdProveedor.Location = new System.Drawing.Point(44, 21);
            lbl_IdProveedor.Name = "lbl_IdProveedor";
            lbl_IdProveedor.Size = new System.Drawing.Size(73, 13);
            lbl_IdProveedor.TabIndex = 7;
            lbl_IdProveedor.Text = "ID_Proveedor";
            // 
            // lbl_NombreProveedor
            // 
            lbl_NombreProveedor.AutoSize = true;
            lbl_NombreProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_NombreProveedor.Location = new System.Drawing.Point(44, 53);
            lbl_NombreProveedor.Name = "lbl_NombreProveedor";
            lbl_NombreProveedor.Size = new System.Drawing.Size(96, 13);
            lbl_NombreProveedor.TabIndex = 8;
            lbl_NombreProveedor.Text = "Nombre Proveedor";
            // 
            // lbl_Moneda
            // 
            lbl_Moneda.AutoSize = true;
            lbl_Moneda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_Moneda.Location = new System.Drawing.Point(44, 87);
            lbl_Moneda.Name = "lbl_Moneda";
            lbl_Moneda.Size = new System.Drawing.Size(46, 13);
            lbl_Moneda.TabIndex = 9;
            lbl_Moneda.Text = "Moneda";
            // 
            // lbl_IdTransaccion
            // 
            lbl_IdTransaccion.AutoSize = true;
            lbl_IdTransaccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_IdTransaccion.Location = new System.Drawing.Point(43, 120);
            lbl_IdTransaccion.Name = "lbl_IdTransaccion";
            lbl_IdTransaccion.Size = new System.Drawing.Size(83, 13);
            lbl_IdTransaccion.TabIndex = 10;
            lbl_IdTransaccion.Text = "ID_Transacción";
            // 
            // lsb_IdProveedor
            // 
            this.lsb_IdProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsb_IdProveedor.FormattingEnabled = true;
            this.lsb_IdProveedor.Items.AddRange(new object[] {
            "Seleccionar uno:"});
            this.lsb_IdProveedor.Location = new System.Drawing.Point(146, 21);
            this.lsb_IdProveedor.Name = "lsb_IdProveedor";
            this.lsb_IdProveedor.Size = new System.Drawing.Size(120, 17);
            this.lsb_IdProveedor.TabIndex = 11;
            this.lsb_IdProveedor.SelectedIndexChanged += new System.EventHandler(this.lsb_IdProveedor_SelectedIndexChanged);
            // 
            // lsb_Moneda
            // 
            this.lsb_Moneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsb_Moneda.Enabled = false;
            this.lsb_Moneda.FormattingEnabled = true;
            this.lsb_Moneda.Items.AddRange(new object[] {
            "Seleccionar uno:"});
            this.lsb_Moneda.Location = new System.Drawing.Point(146, 87);
            this.lsb_Moneda.Name = "lsb_Moneda";
            this.lsb_Moneda.Size = new System.Drawing.Size(120, 17);
            this.lsb_Moneda.TabIndex = 13;
            this.lsb_Moneda.SelectedIndexChanged += new System.EventHandler(this.lsb_Moneda_SelectedIndexChanged);
            // 
            // txt_NombreProveedor
            // 
            this.txt_NombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombreProveedor.Enabled = false;
            this.txt_NombreProveedor.Location = new System.Drawing.Point(146, 47);
            this.txt_NombreProveedor.Name = "txt_NombreProveedor";
            this.txt_NombreProveedor.Size = new System.Drawing.Size(120, 20);
            this.txt_NombreProveedor.TabIndex = 12;
            // 
            // lbl_FechaVencimiento
            // 
            lbl_FechaVencimiento.AutoSize = true;
            lbl_FechaVencimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_FechaVencimiento.Location = new System.Drawing.Point(425, 122);
            lbl_FechaVencimiento.Name = "lbl_FechaVencimiento";
            lbl_FechaVencimiento.Size = new System.Drawing.Size(112, 13);
            lbl_FechaVencimiento.TabIndex = 18;
            lbl_FechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // lbl_Consecutivo
            // 
            lbl_Consecutivo.AutoSize = true;
            lbl_Consecutivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_Consecutivo.Location = new System.Drawing.Point(426, 23);
            lbl_Consecutivo.Name = "lbl_Consecutivo";
            lbl_Consecutivo.Size = new System.Drawing.Size(66, 13);
            lbl_Consecutivo.TabIndex = 15;
            lbl_Consecutivo.Text = "Consecutivo";
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_Estado.Location = new System.Drawing.Point(426, 55);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new System.Drawing.Size(40, 13);
            lbl_Estado.TabIndex = 16;
            lbl_Estado.Text = "Estado";
            // 
            // lbl_FechaTransacción
            // 
            lbl_FechaTransacción.AutoSize = true;
            lbl_FechaTransacción.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbl_FechaTransacción.Location = new System.Drawing.Point(426, 89);
            lbl_FechaTransacción.Name = "lbl_FechaTransacción";
            lbl_FechaTransacción.Size = new System.Drawing.Size(121, 13);
            lbl_FechaTransacción.TabIndex = 17;
            lbl_FechaTransacción.Text = "Fecha de la transacción";
            // 
            // txt_Consecutivo
            // 
            this.txt_Consecutivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Consecutivo.Enabled = false;
            this.txt_Consecutivo.Location = new System.Drawing.Point(553, 19);
            this.txt_Consecutivo.Name = "txt_Consecutivo";
            this.txt_Consecutivo.Size = new System.Drawing.Size(120, 20);
            this.txt_Consecutivo.TabIndex = 15;
            // 
            // lsb_Estado
            // 
            this.lsb_Estado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsb_Estado.Enabled = false;
            this.lsb_Estado.FormattingEnabled = true;
            this.lsb_Estado.Items.AddRange(new object[] {
            "Seleccionar uno:"});
            this.lsb_Estado.Location = new System.Drawing.Point(553, 51);
            this.lsb_Estado.Name = "lsb_Estado";
            this.lsb_Estado.Size = new System.Drawing.Size(120, 17);
            this.lsb_Estado.TabIndex = 16;
            this.lsb_Estado.SelectedIndexChanged += new System.EventHandler(this.lsb_Estado_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGray;
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
            this.toolStrip1.TabIndex = 6;
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
            this.tls_btn_refrescar.Click += new System.EventHandler(this.tls_btn_refrescar_Click);
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
            this.tls_btn_nuevo.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.tls_btn_nuevo.Name = "tls_btn_nuevo";
            this.tls_btn_nuevo.Size = new System.Drawing.Size(36, 36);
            this.tls_btn_nuevo.Text = "toolStripButton2";
            this.tls_btn_nuevo.ToolTipText = "Nuevo";
            this.tls_btn_nuevo.Click += new System.EventHandler(this.tls_btn_nuevo_Click);
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
            this.tls_btn_modificar.Click += new System.EventHandler(this.tls_btn_modificar_Click);
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
            this.tls_btn_eliminar.Click += new System.EventHandler(this.tls_btn_eliminar_Click);
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
            this.tls_btn_Filtrar.Click += new System.EventHandler(this.tls_btn_Filtrar_Click);
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
            this.tls_lbl_Limpiar.Click += new System.EventHandler(this.tls_lbl_Limpiar_Click);
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
            this.tls_btn_Salir.Click += new System.EventHandler(this.tls_btn_Salir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // txt_Comentarios
            // 
            this.txt_Comentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Comentarios.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_Comentarios.Enabled = false;
            this.txt_Comentarios.Location = new System.Drawing.Point(119, 445);
            this.txt_Comentarios.MaxLength = 51;
            this.txt_Comentarios.Name = "txt_Comentarios";
            this.txt_Comentarios.Size = new System.Drawing.Size(179, 20);
            this.txt_Comentarios.TabIndex = 21;
            this.txt_Comentarios.Leave += new System.EventHandler(this.txt_Comentarios_Leave);
            // 
            // lbl_Comentarios
            // 
            this.lbl_Comentarios.AutoSize = true;
            this.lbl_Comentarios.Location = new System.Drawing.Point(16, 445);
            this.lbl_Comentarios.Name = "lbl_Comentarios";
            this.lbl_Comentarios.Size = new System.Drawing.Size(65, 13);
            this.lbl_Comentarios.TabIndex = 24;
            this.lbl_Comentarios.Text = "Comentarios";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Subtotal.Enabled = false;
            this.txt_Subtotal.Location = new System.Drawing.Point(674, 375);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(120, 20);
            this.txt_Subtotal.TabIndex = 22;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(571, 375);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(46, 13);
            this.lbl_Subtotal.TabIndex = 26;
            this.lbl_Subtotal.Text = "Subtotal";
            // 
            // txt_GastosAdicionales
            // 
            this.txt_GastosAdicionales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GastosAdicionales.Enabled = false;
            this.txt_GastosAdicionales.Location = new System.Drawing.Point(674, 401);
            this.txt_GastosAdicionales.Name = "txt_GastosAdicionales";
            this.txt_GastosAdicionales.Size = new System.Drawing.Size(120, 20);
            this.txt_GastosAdicionales.TabIndex = 23;
            // 
            // lbl_GastosAdicionales
            // 
            this.lbl_GastosAdicionales.AutoSize = true;
            this.lbl_GastosAdicionales.Location = new System.Drawing.Point(571, 401);
            this.lbl_GastosAdicionales.Name = "lbl_GastosAdicionales";
            this.lbl_GastosAdicionales.Size = new System.Drawing.Size(97, 13);
            this.lbl_GastosAdicionales.TabIndex = 28;
            this.lbl_GastosAdicionales.Text = "Gastos Adicionales";
            // 
            // txt_IVA
            // 
            this.txt_IVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IVA.Enabled = false;
            this.txt_IVA.Location = new System.Drawing.Point(674, 426);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.Size = new System.Drawing.Size(120, 20);
            this.txt_IVA.TabIndex = 24;
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.AutoSize = true;
            this.lbl_IVA.Location = new System.Drawing.Point(571, 426);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(24, 13);
            this.lbl_IVA.TabIndex = 30;
            this.lbl_IVA.Text = "IVA";
            // 
            // txt_Total
            // 
            this.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Total.Enabled = false;
            this.txt_Total.Location = new System.Drawing.Point(674, 452);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(120, 20);
            this.txt_Total.TabIndex = 25;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(571, 452);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 13);
            this.lbl_Total.TabIndex = 32;
            this.lbl_Total.Text = "Total";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgv_Entrada_Articulos
            // 
            this.dgv_Entrada_Articulos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_Entrada_Articulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entrada_Articulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Entrada_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entrada_Articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_CodigoArticulo,
            this.dt_Descripcion,
            this.dt_FechaCaducidad,
            this.dt_Ubicación,
            this.dt_Cantidad,
            this.dt_Unidad,
            this.dt_Costo,
            this.dt_Descuento,
            this.dt_IVA,
            this.dt_Total});
            this.dgv_Entrada_Articulos.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Entrada_Articulos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Entrada_Articulos.Enabled = false;
            this.dgv_Entrada_Articulos.Location = new System.Drawing.Point(7, 214);
            this.dgv_Entrada_Articulos.Name = "dgv_Entrada_Articulos";
            this.dgv_Entrada_Articulos.Size = new System.Drawing.Size(788, 119);
            this.dgv_Entrada_Articulos.TabIndex = 20;
            this.dgv_Entrada_Articulos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_Entrada_Articulos_CellValidating);
            // 
            // dt_CodigoArticulo
            // 
            this.dt_CodigoArticulo.Frozen = true;
            this.dt_CodigoArticulo.HeaderText = "Código Artículo";
            this.dt_CodigoArticulo.Items.AddRange(new object[] {
            "Seleccione uno:"});
            this.dt_CodigoArticulo.Name = "dt_CodigoArticulo";
            this.dt_CodigoArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_CodigoArticulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dt_CodigoArticulo.Width = 80;
            // 
            // dt_Descripcion
            // 
            this.dt_Descripcion.FillWeight = 90F;
            this.dt_Descripcion.HeaderText = "Descripción Artículo";
            this.dt_Descripcion.Name = "dt_Descripcion";
            this.dt_Descripcion.ReadOnly = true;
            // 
            // dt_FechaCaducidad
            // 
            dataGridViewCellStyle2.Format = "MM/DD/AAAA";
            dataGridViewCellStyle2.NullValue = "00/00/1900";
            this.dt_FechaCaducidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_FechaCaducidad.HeaderText = "Fecha Caducidad";
            this.dt_FechaCaducidad.MaxInputLength = 10;
            this.dt_FechaCaducidad.Name = "dt_FechaCaducidad";
            this.dt_FechaCaducidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_FechaCaducidad.Width = 70;
            // 
            // dt_Ubicación
            // 
            this.dt_Ubicación.HeaderText = "Ubicación";
            this.dt_Ubicación.Items.AddRange(new object[] {
            "Seleccione uno:"});
            this.dt_Ubicación.Name = "dt_Ubicación";
            this.dt_Ubicación.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Ubicación.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dt_Ubicación.Width = 70;
            // 
            // dt_Cantidad
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0,00";
            this.dt_Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt_Cantidad.HeaderText = "Cantidad";
            this.dt_Cantidad.MaxInputLength = 7;
            this.dt_Cantidad.Name = "dt_Cantidad";
            this.dt_Cantidad.Width = 70;
            // 
            // dt_Unidad
            // 
            this.dt_Unidad.HeaderText = "Unidad Medida";
            this.dt_Unidad.Items.AddRange(new object[] {
            "Seleccione uno:"});
            this.dt_Unidad.Name = "dt_Unidad";
            this.dt_Unidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Unidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dt_Unidad.Width = 70;
            // 
            // dt_Costo
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0,00";
            this.dt_Costo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dt_Costo.HeaderText = "Costo por UM";
            this.dt_Costo.MaxInputLength = 7;
            this.dt_Costo.Name = "dt_Costo";
            this.dt_Costo.Width = 70;
            // 
            // dt_Descuento
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0,00";
            this.dt_Descuento.DefaultCellStyle = dataGridViewCellStyle5;
            this.dt_Descuento.HeaderText = "Descuento";
            this.dt_Descuento.MaxInputLength = 7;
            this.dt_Descuento.Name = "dt_Descuento";
            this.dt_Descuento.Width = 70;
            // 
            // dt_IVA
            // 
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0,00";
            this.dt_IVA.DefaultCellStyle = dataGridViewCellStyle6;
            this.dt_IVA.HeaderText = "IVA";
            this.dt_IVA.MaxInputLength = 7;
            this.dt_IVA.Name = "dt_IVA";
            this.dt_IVA.Width = 70;
            // 
            // dt_Total
            // 
            this.dt_Total.HeaderText = "Total";
            this.dt_Total.Name = "dt_Total";
            this.dt_Total.ReadOnly = true;
            this.dt_Total.Width = 70;
            // 
            // frm_Entrada_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(809, 501);
            this.Controls.Add(this.dgv_Entrada_Articulos);
            this.Controls.Add(gb_EntradaArticulos);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.txt_IVA);
            this.Controls.Add(this.lbl_IVA);
            this.Controls.Add(this.txt_GastosAdicionales);
            this.Controls.Add(this.lbl_GastosAdicionales);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.txt_Comentarios);
            this.Controls.Add(this.lbl_Comentarios);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_Entrada_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras de Artículos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Entrada_Articulos_FormClosing);
            this.Load += new System.EventHandler(this.frm_Entrada_Articulos_Load);
            gb_EntradaArticulos.ResumeLayout(false);
            gb_EntradaArticulos.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entrada_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tls_lbl_Salir;
        private System.Windows.Forms.ToolStripButton tls_btn_Salir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tls_lbl_Limpiar;
        private System.Windows.Forms.ToolStripLabel tls_lbl_Cancel;
        private System.Windows.Forms.ListBox lsb_IdProveedor;
        private System.Windows.Forms.ListBox lsb_Moneda;
        private System.Windows.Forms.TextBox txt_IdTransaccion;
        private System.Windows.Forms.TextBox txt_NombreProveedor;
        private System.Windows.Forms.TextBox txt_Consecutivo;
        private System.Windows.Forms.ListBox lsb_Estado;
        private System.Windows.Forms.TextBox txt_Comentarios;
        private System.Windows.Forms.Label lbl_Comentarios;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.TextBox txt_GastosAdicionales;
        private System.Windows.Forms.Label lbl_GastosAdicionales;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgv_Entrada_Articulos;
        private System.Windows.Forms.MaskedTextBox mtb_FechaVencimiento;
        private System.Windows.Forms.MaskedTextBox mtb_FechaTransaccion;
        private System.Windows.Forms.DataGridViewComboBoxColumn dt_CodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_FechaCaducidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn dt_Ubicación;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Cantidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn dt_Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Total;
    }
}