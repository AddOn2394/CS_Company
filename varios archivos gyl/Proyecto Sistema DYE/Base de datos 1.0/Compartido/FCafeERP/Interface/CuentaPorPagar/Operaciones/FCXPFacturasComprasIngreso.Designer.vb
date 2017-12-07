<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCXPFacturasComprasIngreso
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCodigoProveedor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtInformacion = New System.Windows.Forms.TextBox()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTipoLibro = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTasaMunicipal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTimbres = New System.Windows.Forms.TextBox()
        Me.lbTimbres = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbSubCentro = New System.Windows.Forms.ComboBox()
        Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtImpuesto_idp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBien = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtImpuesto_retiva = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtImpuesto_isr = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtImpuesto_iva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCalculoCombustible = New System.Windows.Forms.Button()
        Me.txtTotalFactura = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipoFactura = New System.Windows.Forms.ComboBox()
        Me.cmbTipoLibro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dg1 = New System.Windows.Forms.DataGridView()
        Me.colCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCentro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubCentro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.txtHaber = New System.Windows.Forms.TextBox()
        Me.txtDebe = New System.Windows.Forms.TextBox()
        Me.txtPorAplicar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 48)
        Me.Panel1.TabIndex = 0
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.White
        Me.lbTitulo.Location = New System.Drawing.Point(14, 12)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(159, 21)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "PERIODO CONTABLE:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtCodigoProveedor)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtInformacion)
        Me.GroupBox1.Controls.Add(Me.txtNombreProveedor)
        Me.GroupBox1.Controls.Add(Me.txtNit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 56)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1087, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Proveedor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(133, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(257, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "[F8 = Buscar Proveedor | F10 = Nuevo Proveedor]"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Codigo Proveedor:"
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.Enabled = False
        Me.txtCodigoProveedor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(136, 64)
        Me.txtCodigoProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(116, 22)
        Me.txtCodigoProveedor.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(260, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Información:"
        '
        'txtInformacion
        '
        Me.txtInformacion.BackColor = System.Drawing.Color.White
        Me.txtInformacion.Enabled = False
        Me.txtInformacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInformacion.ForeColor = System.Drawing.Color.Black
        Me.txtInformacion.Location = New System.Drawing.Point(351, 31)
        Me.txtInformacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInformacion.Name = "txtInformacion"
        Me.txtInformacion.Size = New System.Drawing.Size(574, 22)
        Me.txtInformacion.TabIndex = 3
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.BackColor = System.Drawing.Color.White
        Me.txtNombreProveedor.Enabled = False
        Me.txtNombreProveedor.ForeColor = System.Drawing.Color.Black
        Me.txtNombreProveedor.Location = New System.Drawing.Point(260, 64)
        Me.txtNombreProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(665, 22)
        Me.txtNombreProveedor.TabIndex = 2
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(136, 27)
        Me.txtNit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(116, 22)
        Me.txtNit.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nit:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTipoLibro)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtTasaMunicipal)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtTimbres)
        Me.GroupBox2.Controls.Add(Me.lbTimbres)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.cmbSubCentro)
        Me.GroupBox2.Controls.Add(Me.cmbCentroCosto)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtImpuesto_idp)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtBien)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtServicio)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtImpuesto_retiva)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtImpuesto_isr)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtImpuesto_iva)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnCalculoCombustible)
        Me.GroupBox2.Controls.Add(Me.txtTotalFactura)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDocumento)
        Me.GroupBox2.Controls.Add(Me.txtSerie)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbTipoFactura)
        Me.GroupBox2.Controls.Add(Me.cmbTipoLibro)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 182)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1087, 167)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Documentos [F4=Modifica Elementos][F3=Modifica Fecha]"
        '
        'txtTipoLibro
        '
        Me.txtTipoLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTipoLibro.FormattingEnabled = True
        Me.txtTipoLibro.Items.AddRange(New Object() {"BIEN", "SERVICIO", "COMBUSTIBLE"})
        Me.txtTipoLibro.Location = New System.Drawing.Point(517, 20)
        Me.txtTipoLibro.Name = "txtTipoLibro"
        Me.txtTipoLibro.Size = New System.Drawing.Size(165, 21)
        Me.txtTipoLibro.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(128, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "No:"
        '
        'txtTasaMunicipal
        '
        Me.txtTasaMunicipal.BackColor = System.Drawing.Color.White
        Me.txtTasaMunicipal.Enabled = False
        Me.txtTasaMunicipal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaMunicipal.ForeColor = System.Drawing.Color.Black
        Me.txtTasaMunicipal.Location = New System.Drawing.Point(930, 92)
        Me.txtTasaMunicipal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTasaMunicipal.Name = "txtTasaMunicipal"
        Me.txtTasaMunicipal.Size = New System.Drawing.Size(136, 22)
        Me.txtTasaMunicipal.TabIndex = 22
        Me.txtTasaMunicipal.Text = "0.00"
        Me.txtTasaMunicipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTasaMunicipal.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(822, 95)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 13)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Tasa Municipal:"
        Me.Label20.Visible = False
        '
        'txtTimbres
        '
        Me.txtTimbres.BackColor = System.Drawing.Color.White
        Me.txtTimbres.Enabled = False
        Me.txtTimbres.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimbres.ForeColor = System.Drawing.Color.Black
        Me.txtTimbres.Location = New System.Drawing.Point(930, 55)
        Me.txtTimbres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTimbres.Name = "txtTimbres"
        Me.txtTimbres.Size = New System.Drawing.Size(136, 22)
        Me.txtTimbres.TabIndex = 20
        Me.txtTimbres.Text = "0.00"
        Me.txtTimbres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTimbres.Visible = False
        '
        'lbTimbres
        '
        Me.lbTimbres.AutoSize = True
        Me.lbTimbres.Location = New System.Drawing.Point(866, 59)
        Me.lbTimbres.Name = "lbTimbres"
        Me.lbTimbres.Size = New System.Drawing.Size(49, 13)
        Me.lbTimbres.TabIndex = 19
        Me.lbTimbres.Text = "Timbres:"
        Me.lbTimbres.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(906, 129)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 30)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Generar Gastos"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cmbSubCentro
        '
        Me.cmbSubCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubCentro.FormattingEnabled = True
        Me.cmbSubCentro.Items.AddRange(New Object() {"B - Bien", "S - Servicio"})
        Me.cmbSubCentro.Location = New System.Drawing.Point(399, 167)
        Me.cmbSubCentro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbSubCentro.Name = "cmbSubCentro"
        Me.cmbSubCentro.Size = New System.Drawing.Size(314, 21)
        Me.cmbSubCentro.TabIndex = 29
        Me.cmbSubCentro.Visible = False
        '
        'cmbCentroCosto
        '
        Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCentroCosto.FormattingEnabled = True
        Me.cmbCentroCosto.Items.AddRange(New Object() {"B - Bien", "S - Servicio"})
        Me.cmbCentroCosto.Location = New System.Drawing.Point(129, 167)
        Me.cmbCentroCosto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCentroCosto.Name = "cmbCentroCosto"
        Me.cmbCentroCosto.Size = New System.Drawing.Size(262, 21)
        Me.cmbCentroCosto.TabIndex = 28
        Me.cmbCentroCosto.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Centro de Costos:"
        Me.Label15.Visible = False
        '
        'txtImpuesto_idp
        '
        Me.txtImpuesto_idp.BackColor = System.Drawing.Color.White
        Me.txtImpuesto_idp.Enabled = False
        Me.txtImpuesto_idp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuesto_idp.ForeColor = System.Drawing.Color.Black
        Me.txtImpuesto_idp.Location = New System.Drawing.Point(233, 128)
        Me.txtImpuesto_idp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtImpuesto_idp.Name = "txtImpuesto_idp"
        Me.txtImpuesto_idp.Size = New System.Drawing.Size(136, 22)
        Me.txtImpuesto_idp.TabIndex = 18
        Me.txtImpuesto_idp.Text = "0.00"
        Me.txtImpuesto_idp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImpuesto_idp.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(195, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "IDP:"
        Me.Label14.Visible = False
        '
        'txtBien
        '
        Me.txtBien.BackColor = System.Drawing.Color.White
        Me.txtBien.Enabled = False
        Me.txtBien.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBien.ForeColor = System.Drawing.Color.Black
        Me.txtBien.Location = New System.Drawing.Point(271, 93)
        Me.txtBien.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBien.Name = "txtBien"
        Me.txtBien.Size = New System.Drawing.Size(140, 22)
        Me.txtBien.TabIndex = 24
        Me.txtBien.Text = "0.00"
        Me.txtBien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(225, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Bien:"
        '
        'txtServicio
        '
        Me.txtServicio.BackColor = System.Drawing.Color.White
        Me.txtServicio.Enabled = False
        Me.txtServicio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServicio.ForeColor = System.Drawing.Color.Black
        Me.txtServicio.Location = New System.Drawing.Point(77, 93)
        Me.txtServicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(140, 22)
        Me.txtServicio.TabIndex = 22
        Me.txtServicio.Text = "0.00"
        Me.txtServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Servicios:"
        '
        'txtImpuesto_retiva
        '
        Me.txtImpuesto_retiva.BackColor = System.Drawing.Color.White
        Me.txtImpuesto_retiva.Enabled = False
        Me.txtImpuesto_retiva.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuesto_retiva.ForeColor = System.Drawing.Color.Black
        Me.txtImpuesto_retiva.Location = New System.Drawing.Point(646, 131)
        Me.txtImpuesto_retiva.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtImpuesto_retiva.Name = "txtImpuesto_retiva"
        Me.txtImpuesto_retiva.Size = New System.Drawing.Size(140, 22)
        Me.txtImpuesto_retiva.TabIndex = 20
        Me.txtImpuesto_retiva.Text = "0.00"
        Me.txtImpuesto_retiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(584, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Ret. Iva:"
        '
        'txtImpuesto_isr
        '
        Me.txtImpuesto_isr.BackColor = System.Drawing.Color.White
        Me.txtImpuesto_isr.Enabled = False
        Me.txtImpuesto_isr.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuesto_isr.ForeColor = System.Drawing.Color.Black
        Me.txtImpuesto_isr.Location = New System.Drawing.Point(436, 131)
        Me.txtImpuesto_isr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtImpuesto_isr.Name = "txtImpuesto_isr"
        Me.txtImpuesto_isr.Size = New System.Drawing.Size(140, 22)
        Me.txtImpuesto_isr.TabIndex = 18
        Me.txtImpuesto_isr.Text = "0.00"
        Me.txtImpuesto_isr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(377, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Ret. Isr:"
        '
        'txtImpuesto_iva
        '
        Me.txtImpuesto_iva.BackColor = System.Drawing.Color.White
        Me.txtImpuesto_iva.Enabled = False
        Me.txtImpuesto_iva.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuesto_iva.ForeColor = System.Drawing.Color.Black
        Me.txtImpuesto_iva.Location = New System.Drawing.Point(47, 131)
        Me.txtImpuesto_iva.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtImpuesto_iva.Name = "txtImpuesto_iva"
        Me.txtImpuesto_iva.Size = New System.Drawing.Size(140, 22)
        Me.txtImpuesto_iva.TabIndex = 16
        Me.txtImpuesto_iva.Text = "0.00"
        Me.txtImpuesto_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "IVA:"
        '
        'btnCalculoCombustible
        '
        Me.btnCalculoCombustible.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCalculoCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculoCombustible.ForeColor = System.Drawing.Color.White
        Me.btnCalculoCombustible.Location = New System.Drawing.Point(930, 21)
        Me.btnCalculoCombustible.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalculoCombustible.Name = "btnCalculoCombustible"
        Me.btnCalculoCombustible.Size = New System.Drawing.Size(138, 30)
        Me.btnCalculoCombustible.TabIndex = 14
        Me.btnCalculoCombustible.Text = "Calculo Combustible"
        Me.btnCalculoCombustible.UseVisualStyleBackColor = False
        Me.btnCalculoCombustible.Visible = False
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.Location = New System.Drawing.Point(784, 20)
        Me.txtTotalFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.Size = New System.Drawing.Size(140, 22)
        Me.txtTotalFactura.TabIndex = 4
        Me.txtTotalFactura.Text = "0.00"
        Me.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(688, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Total Factura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Descripción Factura:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(135, 55)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(482, 29)
        Me.txtDescripcion.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(342, 18)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(111, 22)
        Me.dtpFecha.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha:"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(163, 18)
        Me.txtDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(117, 22)
        Me.txtDocumento.TabIndex = 1
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(57, 18)
        Me.txtSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(63, 22)
        Me.txtSerie.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Serie:"
        '
        'cmbTipoFactura
        '
        Me.cmbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoFactura.FormattingEnabled = True
        Me.cmbTipoFactura.Items.AddRange(New Object() {"B - Bien", "S - Servicio"})
        Me.cmbTipoFactura.Location = New System.Drawing.Point(629, 56)
        Me.cmbTipoFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTipoFactura.Name = "cmbTipoFactura"
        Me.cmbTipoFactura.Size = New System.Drawing.Size(229, 21)
        Me.cmbTipoFactura.TabIndex = 6
        '
        'cmbTipoLibro
        '
        Me.cmbTipoLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoLibro.FormattingEnabled = True
        Me.cmbTipoLibro.Items.AddRange(New Object() {"B - Bien", "S - Servicio", "C - Combustible"})
        Me.cmbTipoLibro.Location = New System.Drawing.Point(696, -4)
        Me.cmbTipoLibro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTipoLibro.Name = "cmbTipoLibro"
        Me.cmbTipoLibro.Size = New System.Drawing.Size(262, 21)
        Me.cmbTipoLibro.TabIndex = 2
        Me.cmbTipoLibro.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Compra:"
        '
        'Dg1
        '
        Me.Dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCuenta, Me.colCentro, Me.colSubCentro, Me.colNombreCuenta, Me.colDescripcion, Me.colDebe, Me.colHaber})
        Me.Dg1.Location = New System.Drawing.Point(15, 357)
        Me.Dg1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Dg1.Name = "Dg1"
        Me.Dg1.Size = New System.Drawing.Size(1087, 230)
        Me.Dg1.TabIndex = 2
        '
        'colCuenta
        '
        Me.colCuenta.HeaderText = "Cuenta Contable"
        Me.colCuenta.Name = "colCuenta"
        Me.colCuenta.Width = 95
        '
        'colCentro
        '
        Me.colCentro.HeaderText = "Centro"
        Me.colCentro.Name = "colCentro"
        Me.colCentro.ReadOnly = True
        Me.colCentro.Width = 35
        '
        'colSubCentro
        '
        Me.colSubCentro.HeaderText = "Sub"
        Me.colSubCentro.Name = "colSubCentro"
        Me.colSubCentro.ReadOnly = True
        Me.colSubCentro.Width = 35
        '
        'colNombreCuenta
        '
        Me.colNombreCuenta.HeaderText = "Nombre Cuenta"
        Me.colNombreCuenta.Name = "colNombreCuenta"
        Me.colNombreCuenta.ReadOnly = True
        Me.colNombreCuenta.Width = 200
        '
        'colDescripcion
        '
        Me.colDescripcion.HeaderText = "Descripcion Linea"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Width = 300
        '
        'colDebe
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.colDebe.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDebe.HeaderText = "Debe"
        Me.colDebe.Name = "colDebe"
        '
        'colHaber
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.colHaber.DefaultCellStyle = DataGridViewCellStyle6
        Me.colHaber.HeaderText = "Haber"
        Me.colHaber.Name = "colHaber"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(162, 595)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 46)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAplicar
        '
        Me.btnAplicar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAplicar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicar.ForeColor = System.Drawing.Color.White
        Me.btnAplicar.Location = New System.Drawing.Point(15, 595)
        Me.btnAplicar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(154, 46)
        Me.btnAplicar.TabIndex = 11
        Me.btnAplicar.Text = "(F9) Grabar"
        Me.btnAplicar.UseVisualStyleBackColor = False
        '
        'txtHaber
        '
        Me.txtHaber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHaber.Location = New System.Drawing.Point(945, 595)
        Me.txtHaber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHaber.Name = "txtHaber"
        Me.txtHaber.ReadOnly = True
        Me.txtHaber.Size = New System.Drawing.Size(153, 25)
        Me.txtHaber.TabIndex = 10
        Me.txtHaber.Text = "0.00"
        Me.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDebe
        '
        Me.txtDebe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebe.Location = New System.Drawing.Point(784, 595)
        Me.txtDebe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDebe.Name = "txtDebe"
        Me.txtDebe.ReadOnly = True
        Me.txtDebe.Size = New System.Drawing.Size(153, 25)
        Me.txtDebe.TabIndex = 9
        Me.txtDebe.Text = "0.00"
        Me.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPorAplicar
        '
        Me.txtPorAplicar.BackColor = System.Drawing.Color.Black
        Me.txtPorAplicar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorAplicar.ForeColor = System.Drawing.Color.White
        Me.txtPorAplicar.Location = New System.Drawing.Point(623, 595)
        Me.txtPorAplicar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPorAplicar.Name = "txtPorAplicar"
        Me.txtPorAplicar.ReadOnly = True
        Me.txtPorAplicar.Size = New System.Drawing.Size(153, 25)
        Me.txtPorAplicar.TabIndex = 8
        Me.txtPorAplicar.Text = "0.00"
        Me.txtPorAplicar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 603)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "F2 = Buscar Catalogo"
        '
        'FCXPFacturasComprasIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 649)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.txtHaber)
        Me.Controls.Add(Me.txtDebe)
        Me.Controls.Add(Me.txtPorAplicar)
        Me.Controls.Add(Me.Dg1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FCXPFacturasComprasIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas por Pagar (Jornalización de Documentos)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInformacion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtNit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtImpuesto_idp As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBien As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtServicio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtImpuesto_retiva As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtImpuesto_isr As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtImpuesto_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCalculoCombustible As System.Windows.Forms.Button
    Friend WithEvents txtTotalFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoLibro As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSubCentro As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents txtHaber As System.Windows.Forms.TextBox
    Friend WithEvents txtDebe As System.Windows.Forms.TextBox
    Friend WithEvents txtPorAplicar As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTimbres As System.Windows.Forms.TextBox
    Friend WithEvents lbTimbres As System.Windows.Forms.Label
    Friend WithEvents txtTasaMunicipal As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents colCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCentro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubCentro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombreCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHaber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTipoLibro As System.Windows.Forms.ComboBox
End Class
