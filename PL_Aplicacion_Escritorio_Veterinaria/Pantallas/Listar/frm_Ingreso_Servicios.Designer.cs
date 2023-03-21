
namespace PL_Aplicacion_Escritorio_Veterinaria.Pantallas.Listar
{
    partial class frm_Ingreso_Servicios
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
            System.Windows.Forms.GroupBox gb_FacturacionServicios;
            System.Windows.Forms.Label lbl_IdCliente;
            System.Windows.Forms.Label lbl_NombreCliente;
            System.Windows.Forms.Label lbl_Moneda;
            System.Windows.Forms.Label lbl_IdTransaccion;
            System.Windows.Forms.Label lbl_FechaVencimiento;
            System.Windows.Forms.Label lbl_Consecutivo;
            System.Windows.Forms.Label lbl_Estado;
            System.Windows.Forms.Label lbl_FechaTransacción;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ingreso_Servicios));
            this.mtb_FechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.mtb_FechaTransaccion = new System.Windows.Forms.MaskedTextBox();
            this.txt_IdTransaccion = new System.Windows.Forms.TextBox();
            this.lsb_IdCliente = new System.Windows.Forms.ListBox();
            this.lsb_Moneda = new System.Windows.Forms.ListBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.txt_Consecutivo = new System.Windows.Forms.TextBox();
            this.lsb_Estado = new System.Windows.Forms.ListBox();
            this.dgv_FacturacionServicios = new System.Windows.Forms.DataGridView();
            this.dt_CodigoServicio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dt_DescripcionServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_CodigoMascota = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dt_CodigoProfesional = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dt_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Unidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dt_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Comentarios = new System.Windows.Forms.TextBox();
            this.lbl_Comentarios = new System.Windows.Forms.Label();
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
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_IVA = new System.Windows.Forms.TextBox();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.txt_IngresosAdicionales = new System.Windows.Forms.TextBox();
            this.lbl_IngresosAdicionales = new System.Windows.Forms.Label();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            gb_FacturacionServicios = new System.Windows.Forms.GroupBox();
            lbl_IdCliente = new System.Windows.Forms.Label();
            lbl_NombreCliente = new System.Windows.Forms.Label();
            lbl_Moneda = new System.Windows.Forms.Label();
            lbl_IdTransaccion = new System.Windows.Forms.Label();
            lbl_FechaVencimiento = new System.Windows.Forms.Label();
            lbl_Consecutivo = new System.Windows.Forms.Label();
            lbl_Estado = new System.Windows.Forms.Label();
            lbl_FechaTransacción = new System.Windows.Forms.Label();
            gb_FacturacionServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FacturacionServicios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_FacturacionServicios
            // 
            gb_FacturacionServicios.BackColor = System.Drawing.Color.LightPink;
            gb_FacturacionServicios.Controls.Add(this.mtb_FechaVencimiento);
            gb_FacturacionServicios.Controls.Add(this.mtb_FechaTransaccion);
            gb_FacturacionServicios.Controls.Add(this.txt_IdTransaccion);
            gb_FacturacionServicios.Controls.Add(lbl_IdCliente);
            gb_FacturacionServicios.Controls.Add(lbl_NombreCliente);
            gb_FacturacionServicios.Controls.Add(lbl_Moneda);
            gb_FacturacionServicios.Controls.Add(lbl_IdTransaccion);
            gb_FacturacionServicios.Controls.Add(this.lsb_IdCliente);
            gb_FacturacionServicios.Controls.Add(this.lsb_Moneda);
            gb_FacturacionServicios.Controls.Add(this.txt_NombreCliente);
            gb_FacturacionServicios.Controls.Add(lbl_FechaVencimiento);
            gb_FacturacionServicios.Controls.Add(lbl_Consecutivo);
            gb_FacturacionServicios.Controls.Add(lbl_Estado);
            gb_FacturacionServicios.Controls.Add(lbl_FechaTransacción);
            gb_FacturacionServicios.Controls.Add(this.txt_Consecutivo);
            gb_FacturacionServicios.Controls.Add(this.lsb_Estado);
            gb_FacturacionServicios.ForeColor = System.Drawing.SystemColors.HotTrack;
            gb_FacturacionServicios.Location = new System.Drawing.Point(48, 57);
            gb_FacturacionServicios.Name = "gb_FacturacionServicios";
            gb_FacturacionServicios.Size = new System.Drawing.Size(717, 149);
            gb_FacturacionServicios.TabIndex = 60;
            gb_FacturacionServicios.TabStop = false;
            gb_FacturacionServicios.Text = "Información";
            // 
            // mtb_FechaVencimiento
            // 
            this.mtb_FechaVencimiento.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mtb_FechaVencimiento.Enabled = false;
            this.mtb_FechaVencimiento.Location = new System.Drawing.Point(538, 119);
            this.mtb_FechaVencimiento.Mask = "00/00/0000";
            this.mtb_FechaVencimiento.Name = "mtb_FechaVencimiento";
            this.mtb_FechaVencimiento.Size = new System.Drawing.Size(120, 20);
            this.mtb_FechaVencimiento.TabIndex = 26;
            this.mtb_FechaVencimiento.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_FechaVencimiento_Validating);
            // 
            // mtb_FechaTransaccion
            // 
            this.mtb_FechaTransaccion.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mtb_FechaTransaccion.Enabled = false;
            this.mtb_FechaTransaccion.Location = new System.Drawing.Point(538, 86);
            this.mtb_FechaTransaccion.Mask = "00/00/0000";
            this.mtb_FechaTransaccion.Name = "mtb_FechaTransaccion";
            this.mtb_FechaTransaccion.Size = new System.Drawing.Size(120, 20);
            this.mtb_FechaTransaccion.TabIndex = 25;
            this.mtb_FechaTransaccion.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_FechaTransaccion_Validating);
            // 
            // txt_IdTransaccion
            // 
            this.txt_IdTransaccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdTransaccion.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_IdTransaccion.Enabled = false;
            this.txt_IdTransaccion.Location = new System.Drawing.Point(131, 122);
            this.txt_IdTransaccion.Name = "txt_IdTransaccion";
            this.txt_IdTransaccion.Size = new System.Drawing.Size(120, 20);
            this.txt_IdTransaccion.TabIndex = 13;
            this.txt_IdTransaccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdTransaccion_KeyPress);
            this.txt_IdTransaccion.Leave += new System.EventHandler(this.txt_IdTransaccion_Leave);
            // 
            // lbl_IdCliente
            // 
            lbl_IdCliente.AutoSize = true;
            lbl_IdCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_IdCliente.Location = new System.Drawing.Point(29, 23);
            lbl_IdCliente.Name = "lbl_IdCliente";
            lbl_IdCliente.Size = new System.Drawing.Size(56, 13);
            lbl_IdCliente.TabIndex = 7;
            lbl_IdCliente.Text = "ID_Cliente";
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_NombreCliente.Location = new System.Drawing.Point(29, 55);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new System.Drawing.Size(79, 13);
            lbl_NombreCliente.TabIndex = 8;
            lbl_NombreCliente.Text = "Nombre Cliente";
            // 
            // lbl_Moneda
            // 
            lbl_Moneda.AutoSize = true;
            lbl_Moneda.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_Moneda.Location = new System.Drawing.Point(29, 89);
            lbl_Moneda.Name = "lbl_Moneda";
            lbl_Moneda.Size = new System.Drawing.Size(46, 13);
            lbl_Moneda.TabIndex = 9;
            lbl_Moneda.Text = "Moneda";
            // 
            // lbl_IdTransaccion
            // 
            lbl_IdTransaccion.AutoSize = true;
            lbl_IdTransaccion.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_IdTransaccion.Location = new System.Drawing.Point(28, 122);
            lbl_IdTransaccion.Name = "lbl_IdTransaccion";
            lbl_IdTransaccion.Size = new System.Drawing.Size(83, 13);
            lbl_IdTransaccion.TabIndex = 10;
            lbl_IdTransaccion.Text = "ID_Transacción";
            // 
            // lsb_IdCliente
            // 
            this.lsb_IdCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsb_IdCliente.FormattingEnabled = true;
            this.lsb_IdCliente.Items.AddRange(new object[] {
            "Seleccionar uno:"});
            this.lsb_IdCliente.Location = new System.Drawing.Point(131, 23);
            this.lsb_IdCliente.Name = "lsb_IdCliente";
            this.lsb_IdCliente.Size = new System.Drawing.Size(120, 17);
            this.lsb_IdCliente.TabIndex = 11;
            this.lsb_IdCliente.SelectedIndexChanged += new System.EventHandler(this.lsb_IdCliente_SelectedIndexChanged);
            // 
            // lsb_Moneda
            // 
            this.lsb_Moneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsb_Moneda.Enabled = false;
            this.lsb_Moneda.FormattingEnabled = true;
            this.lsb_Moneda.Items.AddRange(new object[] {
            "Seleccionar uno:"});
            this.lsb_Moneda.Location = new System.Drawing.Point(131, 89);
            this.lsb_Moneda.Name = "lsb_Moneda";
            this.lsb_Moneda.Size = new System.Drawing.Size(120, 17);
            this.lsb_Moneda.TabIndex = 12;
            this.lsb_Moneda.SelectedIndexChanged += new System.EventHandler(this.lsb_Moneda_SelectedIndexChanged);
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombreCliente.Enabled = false;
            this.txt_NombreCliente.Location = new System.Drawing.Point(131, 49);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(120, 20);
            this.txt_NombreCliente.TabIndex = 14;
            // 
            // lbl_FechaVencimiento
            // 
            lbl_FechaVencimiento.AutoSize = true;
            lbl_FechaVencimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_FechaVencimiento.Location = new System.Drawing.Point(410, 124);
            lbl_FechaVencimiento.Name = "lbl_FechaVencimiento";
            lbl_FechaVencimiento.Size = new System.Drawing.Size(112, 13);
            lbl_FechaVencimiento.TabIndex = 18;
            lbl_FechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // lbl_Consecutivo
            // 
            lbl_Consecutivo.AutoSize = true;
            lbl_Consecutivo.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_Consecutivo.Location = new System.Drawing.Point(411, 25);
            lbl_Consecutivo.Name = "lbl_Consecutivo";
            lbl_Consecutivo.Size = new System.Drawing.Size(66, 13);
            lbl_Consecutivo.TabIndex = 15;
            lbl_Consecutivo.Text = "Consecutivo";
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_Estado.Location = new System.Drawing.Point(411, 57);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new System.Drawing.Size(40, 13);
            lbl_Estado.TabIndex = 16;
            lbl_Estado.Text = "Estado";
            // 
            // lbl_FechaTransacción
            // 
            lbl_FechaTransacción.AutoSize = true;
            lbl_FechaTransacción.ForeColor = System.Drawing.SystemColors.ControlText;
            lbl_FechaTransacción.Location = new System.Drawing.Point(411, 91);
            lbl_FechaTransacción.Name = "lbl_FechaTransacción";
            lbl_FechaTransacción.Size = new System.Drawing.Size(121, 13);
            lbl_FechaTransacción.TabIndex = 17;
            lbl_FechaTransacción.Text = "Fecha de la transacción";
            // 
            // txt_Consecutivo
            // 
            this.txt_Consecutivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Consecutivo.Enabled = false;
            this.txt_Consecutivo.Location = new System.Drawing.Point(538, 21);
            this.txt_Consecutivo.Name = "txt_Consecutivo";
            this.txt_Consecutivo.Size = new System.Drawing.Size(120, 20);
            this.txt_Consecutivo.TabIndex = 22;
            // 
            // lsb_Estado
            // 
            this.lsb_Estado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsb_Estado.Enabled = false;
            this.lsb_Estado.FormattingEnabled = true;
            this.lsb_Estado.Items.AddRange(new object[] {
            "Seleccionar uno:"});
            this.lsb_Estado.Location = new System.Drawing.Point(538, 53);
            this.lsb_Estado.Name = "lsb_Estado";
            this.lsb_Estado.Size = new System.Drawing.Size(120, 17);
            this.lsb_Estado.TabIndex = 19;
            this.lsb_Estado.SelectedIndexChanged += new System.EventHandler(this.lsb_Estado_SelectedIndexChanged);
            // 
            // dgv_FacturacionServicios
            // 
            this.dgv_FacturacionServicios.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_FacturacionServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FacturacionServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_FacturacionServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FacturacionServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_CodigoServicio,
            this.dt_DescripcionServicio,
            this.dt_CodigoMascota,
            this.dt_CodigoProfesional,
            this.dt_Cantidad,
            this.dt_Unidad,
            this.dt_Precio,
            this.dt_Descuento,
            this.dt_IVA,
            this.dt_Total});
            this.dgv_FacturacionServicios.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FacturacionServicios.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_FacturacionServicios.Enabled = false;
            this.dgv_FacturacionServicios.Location = new System.Drawing.Point(9, 221);
            this.dgv_FacturacionServicios.Name = "dgv_FacturacionServicios";
            this.dgv_FacturacionServicios.Size = new System.Drawing.Size(788, 119);
            this.dgv_FacturacionServicios.TabIndex = 61;
            this.dgv_FacturacionServicios.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_FacturacionServicios_CellValidating);
            // 
            // dt_CodigoServicio
            // 
            this.dt_CodigoServicio.HeaderText = "Código Servicio";
            this.dt_CodigoServicio.Items.AddRange(new object[] {
            "Seleccione uno:"});
            this.dt_CodigoServicio.Name = "dt_CodigoServicio";
            this.dt_CodigoServicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_CodigoServicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dt_CodigoServicio.Width = 80;
            // 
            // dt_DescripcionServicio
            // 
            this.dt_DescripcionServicio.FillWeight = 90F;
            this.dt_DescripcionServicio.HeaderText = "Descripción Servicio";
            this.dt_DescripcionServicio.Name = "dt_DescripcionServicio";
            this.dt_DescripcionServicio.ReadOnly = true;
            // 
            // dt_CodigoMascota
            // 
            this.dt_CodigoMascota.HeaderText = "Código Mascota";
            this.dt_CodigoMascota.Items.AddRange(new object[] {
            "Seleccione uno:"});
            this.dt_CodigoMascota.Name = "dt_CodigoMascota";
            this.dt_CodigoMascota.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_CodigoMascota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dt_CodigoMascota.Width = 70;
            // 
            // dt_CodigoProfesional
            // 
            this.dt_CodigoProfesional.HeaderText = "Cod. del Profesional";
            this.dt_CodigoProfesional.Items.AddRange(new object[] {
            "Seleccione uno:"});
            this.dt_CodigoProfesional.Name = "dt_CodigoProfesional";
            this.dt_CodigoProfesional.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_CodigoProfesional.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dt_CodigoProfesional.Width = 70;
            // 
            // dt_Cantidad
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0,00";
            this.dt_Cantidad.DefaultCellStyle = dataGridViewCellStyle8;
            this.dt_Cantidad.HeaderText = "Cantidad";
            this.dt_Cantidad.MaxInputLength = 10;
            this.dt_Cantidad.Name = "dt_Cantidad";
            this.dt_Cantidad.Width = 70;
            // 
            // dt_Unidad
            // 
            this.dt_Unidad.HeaderText = "Unidad Medida";
            this.dt_Unidad.Name = "dt_Unidad";
            this.dt_Unidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Unidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dt_Unidad.Width = 70;
            // 
            // dt_Precio
            // 
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0,00";
            this.dt_Precio.DefaultCellStyle = dataGridViewCellStyle9;
            this.dt_Precio.HeaderText = "Precio por UM";
            this.dt_Precio.MaxInputLength = 10;
            this.dt_Precio.Name = "dt_Precio";
            this.dt_Precio.Width = 70;
            // 
            // dt_Descuento
            // 
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0,00";
            this.dt_Descuento.DefaultCellStyle = dataGridViewCellStyle10;
            this.dt_Descuento.HeaderText = "Descuento";
            this.dt_Descuento.MaxInputLength = 10;
            this.dt_Descuento.Name = "dt_Descuento";
            this.dt_Descuento.Width = 70;
            // 
            // dt_IVA
            // 
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0,00";
            this.dt_IVA.DefaultCellStyle = dataGridViewCellStyle11;
            this.dt_IVA.HeaderText = "IVA";
            this.dt_IVA.MaxInputLength = 10;
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
            // txt_Comentarios
            // 
            this.txt_Comentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Comentarios.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_Comentarios.Enabled = false;
            this.txt_Comentarios.Location = new System.Drawing.Point(137, 421);
            this.txt_Comentarios.Name = "txt_Comentarios";
            this.txt_Comentarios.Size = new System.Drawing.Size(162, 20);
            this.txt_Comentarios.TabIndex = 51;
            this.txt_Comentarios.Validated += new System.EventHandler(this.txt_Comentarios_Validated);
            // 
            // lbl_Comentarios
            // 
            this.lbl_Comentarios.AutoSize = true;
            this.lbl_Comentarios.Location = new System.Drawing.Point(34, 421);
            this.lbl_Comentarios.Name = "lbl_Comentarios";
            this.lbl_Comentarios.Size = new System.Drawing.Size(65, 13);
            this.lbl_Comentarios.TabIndex = 50;
            this.lbl_Comentarios.Text = "Comentarios";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.toolStrip1.TabIndex = 49;
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
            this.tls_btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
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
            // txt_Total
            // 
            this.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Total.Enabled = false;
            this.txt_Total.Location = new System.Drawing.Point(674, 453);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(120, 20);
            this.txt_Total.TabIndex = 59;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(571, 453);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 13);
            this.lbl_Total.TabIndex = 58;
            this.lbl_Total.Text = "Total";
            // 
            // txt_IVA
            // 
            this.txt_IVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IVA.Enabled = false;
            this.txt_IVA.Location = new System.Drawing.Point(674, 427);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.Size = new System.Drawing.Size(120, 20);
            this.txt_IVA.TabIndex = 57;
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.AutoSize = true;
            this.lbl_IVA.Location = new System.Drawing.Point(571, 427);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(24, 13);
            this.lbl_IVA.TabIndex = 56;
            this.lbl_IVA.Text = "IVA";
            // 
            // txt_IngresosAdicionales
            // 
            this.txt_IngresosAdicionales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IngresosAdicionales.Enabled = false;
            this.txt_IngresosAdicionales.Location = new System.Drawing.Point(674, 402);
            this.txt_IngresosAdicionales.Name = "txt_IngresosAdicionales";
            this.txt_IngresosAdicionales.Size = new System.Drawing.Size(120, 20);
            this.txt_IngresosAdicionales.TabIndex = 55;
            // 
            // lbl_IngresosAdicionales
            // 
            this.lbl_IngresosAdicionales.AutoSize = true;
            this.lbl_IngresosAdicionales.Location = new System.Drawing.Point(571, 402);
            this.lbl_IngresosAdicionales.Name = "lbl_IngresosAdicionales";
            this.lbl_IngresosAdicionales.Size = new System.Drawing.Size(104, 13);
            this.lbl_IngresosAdicionales.TabIndex = 54;
            this.lbl_IngresosAdicionales.Text = "Ingresos Adicionales";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Subtotal.Enabled = false;
            this.txt_Subtotal.Location = new System.Drawing.Point(674, 376);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(120, 20);
            this.txt_Subtotal.TabIndex = 53;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(571, 376);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(46, 13);
            this.lbl_Subtotal.TabIndex = 52;
            this.lbl_Subtotal.Text = "Subtotal";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_Ingreso_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(809, 501);
            this.Controls.Add(this.dgv_FacturacionServicios);
            this.Controls.Add(gb_FacturacionServicios);
            this.Controls.Add(this.txt_Comentarios);
            this.Controls.Add(this.lbl_Comentarios);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.txt_IVA);
            this.Controls.Add(this.lbl_IVA);
            this.Controls.Add(this.txt_IngresosAdicionales);
            this.Controls.Add(this.lbl_IngresosAdicionales);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.lbl_Subtotal);
            this.Name = "frm_Ingreso_Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación de Servicios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Ingreso_Servicios_FormClosing);
            this.Load += new System.EventHandler(this.frm_Ingreso_Servicios_Load);
            gb_FacturacionServicios.ResumeLayout(false);
            gb_FacturacionServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FacturacionServicios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_FacturacionServicios;
        private System.Windows.Forms.TextBox txt_IdTransaccion;
        private System.Windows.Forms.ListBox lsb_IdCliente;
        private System.Windows.Forms.ListBox lsb_Moneda;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.TextBox txt_Consecutivo;
        private System.Windows.Forms.ListBox lsb_Estado;
        private System.Windows.Forms.TextBox txt_Comentarios;
        private System.Windows.Forms.Label lbl_Comentarios;
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
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.TextBox txt_IngresosAdicionales;
        private System.Windows.Forms.Label lbl_IngresosAdicionales;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtb_FechaVencimiento;
        private System.Windows.Forms.MaskedTextBox mtb_FechaTransaccion;
        private System.Windows.Forms.DataGridViewComboBoxColumn dt_CodigoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_DescripcionServicio;
        private System.Windows.Forms.DataGridViewComboBoxColumn dt_CodigoMascota;
        private System.Windows.Forms.DataGridViewComboBoxColumn dt_CodigoProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Cantidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn dt_Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Total;
    }
}