<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCXCIngresoFacturasVentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GrpInformacionCliente = New System.Windows.Forms.GroupBox()
        Me.TxtDirecCliente = New System.Windows.Forms.TextBox()
        Me.LblDireccionCliente = New System.Windows.Forms.Label()
        Me.LblNombreCliente = New System.Windows.Forms.Label()
        Me.LblNitCliente = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.TxtNitCLiente = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtmFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtIVAExento = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtNoExencion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBase = New System.Windows.Forms.TextBox()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.CmbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.DgtDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.id_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.base = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.TxtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmbTipoVenta = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtSumaDetalle = New System.Windows.Forms.TextBox()
        Me.BtnAplicar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtIdFactura = New System.Windows.Forms.TextBox()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtEfectivo = New System.Windows.Forms.TextBox()
        Me.TxtCheques = New System.Windows.Forms.TextBox()
        Me.TxtTarjetasCredito = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DgtAsientoContable = New System.Windows.Forms.DataGridView()
        Me.ColCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNombreCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCentro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSubCentro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datos = New FCafeERP.Datos()
        Me.GrpInformacionCliente.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgtDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgtAsientoContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpInformacionCliente
        '
        Me.GrpInformacionCliente.Controls.Add(Me.TxtDirecCliente)
        Me.GrpInformacionCliente.Controls.Add(Me.LblDireccionCliente)
        Me.GrpInformacionCliente.Controls.Add(Me.LblNombreCliente)
        Me.GrpInformacionCliente.Controls.Add(Me.LblNitCliente)
        Me.GrpInformacionCliente.Controls.Add(Me.TxtNombreCliente)
        Me.GrpInformacionCliente.Controls.Add(Me.TxtNitCLiente)
        Me.GrpInformacionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrpInformacionCliente.Location = New System.Drawing.Point(14, 192)
        Me.GrpInformacionCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrpInformacionCliente.Name = "GrpInformacionCliente"
        Me.GrpInformacionCliente.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrpInformacionCliente.Size = New System.Drawing.Size(700, 145)
        Me.GrpInformacionCliente.TabIndex = 2
        Me.GrpInformacionCliente.TabStop = False
        Me.GrpInformacionCliente.Text = "Información del Cliente"
        '
        'TxtDirecCliente
        '
        Me.TxtDirecCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDirecCliente.Enabled = False
        Me.TxtDirecCliente.Location = New System.Drawing.Point(10, 107)
        Me.TxtDirecCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDirecCliente.Name = "TxtDirecCliente"
        Me.TxtDirecCliente.ReadOnly = True
        Me.TxtDirecCliente.Size = New System.Drawing.Size(665, 25)
        Me.TxtDirecCliente.TabIndex = 3
        '
        'LblDireccionCliente
        '
        Me.LblDireccionCliente.AutoSize = True
        Me.LblDireccionCliente.Location = New System.Drawing.Point(7, 86)
        Me.LblDireccionCliente.Name = "LblDireccionCliente"
        Me.LblDireccionCliente.Size = New System.Drawing.Size(168, 19)
        Me.LblDireccionCliente.TabIndex = 8
        Me.LblDireccionCliente.Text = "Dirección o domicilio fiscal"
        '
        'LblNombreCliente
        '
        Me.LblNombreCliente.AutoSize = True
        Me.LblNombreCliente.Location = New System.Drawing.Point(127, 26)
        Me.LblNombreCliente.Name = "LblNombreCliente"
        Me.LblNombreCliente.Size = New System.Drawing.Size(150, 19)
        Me.LblNombreCliente.TabIndex = 6
        Me.LblNombreCliente.Text = "Nombre o Razón Social"
        '
        'LblNitCliente
        '
        Me.LblNitCliente.AutoSize = True
        Me.LblNitCliente.Location = New System.Drawing.Point(7, 26)
        Me.LblNitCliente.Name = "LblNitCliente"
        Me.LblNitCliente.Size = New System.Drawing.Size(30, 19)
        Me.LblNitCliente.TabIndex = 5
        Me.LblNitCliente.Text = "NIT"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreCliente.Location = New System.Drawing.Point(131, 47)
        Me.TxtNombreCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.Size = New System.Drawing.Size(545, 25)
        Me.TxtNombreCliente.TabIndex = 1
        '
        'TxtNitCLiente
        '
        Me.TxtNitCLiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNitCLiente.Location = New System.Drawing.Point(7, 47)
        Me.TxtNitCLiente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNitCLiente.Name = "TxtNitCLiente"
        Me.TxtNitCLiente.Size = New System.Drawing.Size(116, 25)
        Me.TxtNitCLiente.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 59)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso de Facturación de Ventas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtmFecha)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNumero)
        Me.GroupBox1.Controls.Add(Me.TxtSerie)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 101)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(388, 84)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Factura"
        '
        'DtmFecha
        '
        Me.DtmFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtmFecha.Location = New System.Drawing.Point(258, 42)
        Me.DtmFecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtmFecha.Name = "DtmFecha"
        Me.DtmFecha.Size = New System.Drawing.Size(112, 25)
        Me.DtmFecha.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Número"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Serie"
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(134, 42)
        Me.TxtNumero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(116, 25)
        Me.TxtNumero.TabIndex = 1
        '
        'TxtSerie
        '
        Me.TxtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSerie.Location = New System.Drawing.Point(10, 42)
        Me.TxtSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(116, 25)
        Me.TxtSerie.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TxtIVAExento)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtNoExencion)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtBase)
        Me.GroupBox2.Controls.Add(Me.TxtIVA)
        Me.GroupBox2.Controls.Add(Me.CmbTipoProducto)
        Me.GroupBox2.Controls.Add(Me.DgtDetalleFactura)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.TxtProducto)
        Me.GroupBox2.Controls.Add(Me.TxtCodigoProducto)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 345)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(700, 103)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de la Factura"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(483, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 19)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "IVA Exento"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(476, 139)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 47)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "&Agregar"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'TxtIVAExento
        '
        Me.TxtIVAExento.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TxtIVAExento.Location = New System.Drawing.Point(486, 48)
        Me.TxtIVAExento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtIVAExento.Name = "TxtIVAExento"
        Me.TxtIVAExento.Size = New System.Drawing.Size(107, 25)
        Me.TxtIVAExento.TabIndex = 4
        Me.TxtIVAExento.Text = "0.00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(377, 78)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(87, 19)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Exención No."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(250, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 19)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Base"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(374, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 19)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "IVA"
        '
        'TxtNoExencion
        '
        Me.TxtNoExencion.Location = New System.Drawing.Point(378, 99)
        Me.TxtNoExencion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNoExencion.Name = "TxtNoExencion"
        Me.TxtNoExencion.Size = New System.Drawing.Size(90, 25)
        Me.TxtNoExencion.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 19)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Tipo Producto"
        '
        'TxtBase
        '
        Me.TxtBase.Enabled = False
        Me.TxtBase.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TxtBase.Location = New System.Drawing.Point(253, 48)
        Me.TxtBase.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.ReadOnly = True
        Me.TxtBase.Size = New System.Drawing.Size(116, 25)
        Me.TxtBase.TabIndex = 2
        Me.TxtBase.Text = "0.00"
        '
        'TxtIVA
        '
        Me.TxtIVA.Enabled = False
        Me.TxtIVA.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TxtIVA.Location = New System.Drawing.Point(378, 48)
        Me.TxtIVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.ReadOnly = True
        Me.TxtIVA.Size = New System.Drawing.Size(101, 25)
        Me.TxtIVA.TabIndex = 3
        Me.TxtIVA.Text = "0.00"
        '
        'CmbTipoProducto
        '
        Me.CmbTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTipoProducto.FormattingEnabled = True
        Me.CmbTipoProducto.Items.AddRange(New Object() {"BIEN", "SERVICIO"})
        Me.CmbTipoProducto.Location = New System.Drawing.Point(10, 48)
        Me.CmbTipoProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbTipoProducto.Name = "CmbTipoProducto"
        Me.CmbTipoProducto.Size = New System.Drawing.Size(116, 25)
        Me.CmbTipoProducto.TabIndex = 0
        '
        'DgtDetalleFactura
        '
        Me.DgtDetalleFactura.AllowUserToAddRows = False
        Me.DgtDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgtDetalleFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_empresa, Me.id_factura, Me.cod_producto, Me.producto, Me.cantidad, Me.precio_unitario, Me.precio_total, Me.base, Me.iva, Me.exencion, Me.tipo_producto})
        Me.DgtDetalleFactura.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgtDetalleFactura.Location = New System.Drawing.Point(3, 89)
        Me.DgtDetalleFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DgtDetalleFactura.Name = "DgtDetalleFactura"
        Me.DgtDetalleFactura.Size = New System.Drawing.Size(694, 10)
        Me.DgtDetalleFactura.TabIndex = 10
        Me.DgtDetalleFactura.Visible = False
        '
        'id_empresa
        '
        Me.id_empresa.HeaderText = "Empresa"
        Me.id_empresa.Name = "id_empresa"
        Me.id_empresa.Width = 25
        '
        'id_factura
        '
        Me.id_factura.HeaderText = "Id Factura"
        Me.id_factura.Name = "id_factura"
        Me.id_factura.Width = 75
        '
        'cod_producto
        '
        Me.cod_producto.HeaderText = "Cod. Producto"
        Me.cod_producto.Name = "cod_producto"
        Me.cod_producto.Width = 75
        '
        'producto
        '
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 75
        '
        'precio_unitario
        '
        Me.precio_unitario.HeaderText = "Precio Unitario"
        Me.precio_unitario.Name = "precio_unitario"
        '
        'precio_total
        '
        Me.precio_total.HeaderText = "Total"
        Me.precio_total.Name = "precio_total"
        '
        'base
        '
        Me.base.HeaderText = "Base"
        Me.base.Name = "base"
        '
        'iva
        '
        Me.iva.HeaderText = "IVA"
        Me.iva.Name = "iva"
        '
        'exencion
        '
        Me.exencion.HeaderText = "Exencion"
        Me.exencion.Name = "exencion"
        '
        'tipo_producto
        '
        Me.tipo_producto.HeaderText = "Tipo de Producto"
        Me.tipo_producto.Name = "tipo_producto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(132, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(131, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Producto"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Código"
        Me.Label6.Visible = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(131, 48)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(116, 25)
        Me.TxtTotal.TabIndex = 1
        Me.TxtTotal.Text = "0.00"
        '
        'TxtProducto
        '
        Me.TxtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProducto.Enabled = False
        Me.TxtProducto.Location = New System.Drawing.Point(131, 86)
        Me.TxtProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.ReadOnly = True
        Me.TxtProducto.Size = New System.Drawing.Size(238, 25)
        Me.TxtProducto.TabIndex = 1
        Me.TxtProducto.Visible = False
        '
        'TxtCodigoProducto
        '
        Me.TxtCodigoProducto.Location = New System.Drawing.Point(7, 88)
        Me.TxtCodigoProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCodigoProducto.Name = "TxtCodigoProducto"
        Me.TxtCodigoProducto.Size = New System.Drawing.Size(116, 25)
        Me.TxtCodigoProducto.TabIndex = 0
        Me.TxtCodigoProducto.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = Global.FCafeERP.My.Resources.Resources.newflat
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(474, 467)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(118, 52)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Image = Global.FCafeERP.My.Resources.Resources.closeflat1
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(600, 467)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(122, 52)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 19)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Tipo Venta"
        '
        'CmbTipoVenta
        '
        Me.CmbTipoVenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTipoVenta.FormattingEnabled = True
        Me.CmbTipoVenta.Items.AddRange(New Object() {"CREDITO"})
        Me.CmbTipoVenta.Location = New System.Drawing.Point(90, 65)
        Me.CmbTipoVenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbTipoVenta.Name = "CmbTipoVenta"
        Me.CmbTipoVenta.Size = New System.Drawing.Size(151, 25)
        Me.CmbTipoVenta.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(532, 464)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 19)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "TOTAL:"
        Me.Label14.Visible = False
        '
        'TxtSumaDetalle
        '
        Me.TxtSumaDetalle.Enabled = False
        Me.TxtSumaDetalle.Location = New System.Drawing.Point(594, 460)
        Me.TxtSumaDetalle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSumaDetalle.Name = "TxtSumaDetalle"
        Me.TxtSumaDetalle.ReadOnly = True
        Me.TxtSumaDetalle.Size = New System.Drawing.Size(116, 25)
        Me.TxtSumaDetalle.TabIndex = 8
        Me.TxtSumaDetalle.Visible = False
        '
        'BtnAplicar
        '
        Me.BtnAplicar.Appearance.BackColor = System.Drawing.Color.Green
        Me.BtnAplicar.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAplicar.Appearance.ForeColor = System.Drawing.Color.White
        Me.BtnAplicar.Appearance.Options.UseBackColor = True
        Me.BtnAplicar.Appearance.Options.UseFont = True
        Me.BtnAplicar.Appearance.Options.UseForeColor = True
        Me.BtnAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.BtnAplicar.Location = New System.Drawing.Point(17, 464)
        Me.BtnAplicar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAplicar.Name = "BtnAplicar"
        Me.BtnAplicar.Size = New System.Drawing.Size(127, 55)
        Me.BtnAplicar.TabIndex = 4
        Me.BtnAplicar.Text = "Aplicar &Pago"
        Me.BtnAplicar.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtIdFactura)
        Me.GroupBox3.Controls.Add(Me.TxtIdCliente)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(409, 99)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(304, 85)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control Interno"
        '
        'TxtIdFactura
        '
        Me.TxtIdFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdFactura.Enabled = False
        Me.TxtIdFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdFactura.Location = New System.Drawing.Point(89, 51)
        Me.TxtIdFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtIdFactura.Name = "TxtIdFactura"
        Me.TxtIdFactura.ReadOnly = True
        Me.TxtIdFactura.Size = New System.Drawing.Size(204, 13)
        Me.TxtIdFactura.TabIndex = 3
        Me.TxtIdFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdCliente.Enabled = False
        Me.TxtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdCliente.Location = New System.Drawing.Point(89, 22)
        Me.TxtIdCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.ReadOnly = True
        Me.TxtIdCliente.Size = New System.Drawing.Size(204, 13)
        Me.TxtIdCliente.TabIndex = 2
        Me.TxtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Cod. Factura:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 19)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Cod. Cliente:"
        '
        'TxtEfectivo
        '
        Me.TxtEfectivo.Enabled = False
        Me.TxtEfectivo.Location = New System.Drawing.Point(152, 493)
        Me.TxtEfectivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtEfectivo.Name = "TxtEfectivo"
        Me.TxtEfectivo.ReadOnly = True
        Me.TxtEfectivo.Size = New System.Drawing.Size(116, 25)
        Me.TxtEfectivo.TabIndex = 17
        Me.TxtEfectivo.Visible = False
        '
        'TxtCheques
        '
        Me.TxtCheques.Location = New System.Drawing.Point(594, 493)
        Me.TxtCheques.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCheques.Name = "TxtCheques"
        Me.TxtCheques.ReadOnly = True
        Me.TxtCheques.Size = New System.Drawing.Size(116, 25)
        Me.TxtCheques.TabIndex = 18
        Me.TxtCheques.Visible = False
        '
        'TxtTarjetasCredito
        '
        Me.TxtTarjetasCredito.Enabled = False
        Me.TxtTarjetasCredito.Location = New System.Drawing.Point(275, 491)
        Me.TxtTarjetasCredito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTarjetasCredito.Name = "TxtTarjetasCredito"
        Me.TxtTarjetasCredito.ReadOnly = True
        Me.TxtTarjetasCredito.Size = New System.Drawing.Size(116, 25)
        Me.TxtTarjetasCredito.TabIndex = 19
        Me.TxtTarjetasCredito.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(148, 474)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 19)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Efectivo"
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(523, 493)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 19)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Cheques"
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(272, 473)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 19)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Tarjeta de Crédito"
        Me.Label19.Visible = False
        '
        'DgtAsientoContable
        '
        Me.DgtAsientoContable.AllowUserToAddRows = False
        Me.DgtAsientoContable.AllowUserToDeleteRows = False
        Me.DgtAsientoContable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgtAsientoContable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCuenta, Me.ColNombreCuenta, Me.ColCentro, Me.ColSubCentro, Me.ColDescripcion, Me.ColDebe, Me.ColHaber})
        Me.DgtAsientoContable.Location = New System.Drawing.Point(17, 783)
        Me.DgtAsientoContable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DgtAsientoContable.Name = "DgtAsientoContable"
        Me.DgtAsientoContable.Size = New System.Drawing.Size(693, 126)
        Me.DgtAsientoContable.TabIndex = 17
        Me.DgtAsientoContable.Visible = False
        '
        'ColCuenta
        '
        Me.ColCuenta.HeaderText = "Cod. Contable"
        Me.ColCuenta.Name = "ColCuenta"
        Me.ColCuenta.ReadOnly = True
        '
        'ColNombreCuenta
        '
        Me.ColNombreCuenta.HeaderText = "Cuenta"
        Me.ColNombreCuenta.Name = "ColNombreCuenta"
        Me.ColNombreCuenta.ReadOnly = True
        '
        'ColCentro
        '
        Me.ColCentro.HeaderText = "Centro"
        Me.ColCentro.Name = "ColCentro"
        Me.ColCentro.ReadOnly = True
        Me.ColCentro.Width = 25
        '
        'ColSubCentro
        '
        Me.ColSubCentro.HeaderText = "SubCentro"
        Me.ColSubCentro.Name = "ColSubCentro"
        Me.ColSubCentro.ReadOnly = True
        Me.ColSubCentro.Width = 25
        '
        'ColDescripcion
        '
        Me.ColDescripcion.HeaderText = "Descripcion"
        Me.ColDescripcion.Name = "ColDescripcion"
        Me.ColDescripcion.ReadOnly = True
        '
        'ColDebe
        '
        Me.ColDebe.HeaderText = "Debe"
        Me.ColDebe.Name = "ColDebe"
        Me.ColDebe.ReadOnly = True
        '
        'ColHaber
        '
        Me.ColHaber.HeaderText = "Haber"
        Me.ColHaber.Name = "ColHaber"
        Me.ColHaber.ReadOnly = True
        '
        'Datos
        '
        Me.Datos.DataSetName = "Datos"
        Me.Datos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FCXCIngresoFacturasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 584)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.DgtAsientoContable)
        Me.Controls.Add(Me.CmbTipoVenta)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtEfectivo)
        Me.Controls.Add(Me.TxtCheques)
        Me.Controls.Add(Me.TxtTarjetasCredito)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnAplicar)
        Me.Controls.Add(Me.TxtSumaDetalle)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrpInformacionCliente)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FCXCIngresoFacturasVentas"
        Me.Text = "Ingreso de Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpInformacionCliente.ResumeLayout(False)
        Me.GrpInformacionCliente.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgtDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgtAsientoContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpInformacionCliente As System.Windows.Forms.GroupBox
    Friend WithEvents LblNombreCliente As System.Windows.Forms.Label
    Friend WithEvents LblNitCliente As System.Windows.Forms.Label
    Friend WithEvents TxtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtNitCLiente As System.Windows.Forms.TextBox
    Friend WithEvents TxtDirecCliente As System.Windows.Forms.TextBox
    Friend WithEvents LblDireccionCliente As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents TxtSerie As System.Windows.Forms.TextBox
    Friend WithEvents DtmFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgtDetalleFactura As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtProducto As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtBase As System.Windows.Forms.TextBox
    Friend WithEvents TxtIVA As System.Windows.Forms.TextBox
    Friend WithEvents CmbTipoProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtSumaDetalle As System.Windows.Forms.TextBox
    Friend WithEvents BtnAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtIdFactura As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCheques As System.Windows.Forms.TextBox
    Friend WithEvents TxtTarjetasCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Datos As FCafeERP.Datos
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents id_empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgtAsientoContable As System.Windows.Forms.DataGridView
    Friend WithEvents ColCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNombreCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCentro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSubCentro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDebe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColHaber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CmbTipoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtIVAExento As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtNoExencion As System.Windows.Forms.TextBox
    Friend WithEvents base As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_producto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
