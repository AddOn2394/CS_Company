Public Class FCXCIngresoFacturasVentas
    Public objfactura As cxc_factura_ventas
    Public objpago As cxc_aplicar_pagos
    Public objpartidacontabletemporal As Cn_Partida_Contable_Enc
    Public ObjCliente As cxc_clientes
    Public ObjProducto As cxc_catalogo_productos
    Public objresumenventas As tb_resumen_ventas
    Dim objventasasiento As tb_ventas_asiento

    Dim filaVentasAsiento As Datos.tb_ventas_asientoRow
    Public filacliente As Datos.cxc_clientesRow = Nothing
    Public filaproducto As Datos.cxc_catalogo_productosRow = Nothing
    Public filafactura As Datos.cxc_factura_ventasRow = Nothing
    Public filaresumen As Datos.tb_resumen_ventasRow = Nothing

    Dim f As FCXCAplicarPago
    Dim h As FcxcBuscadoClientes
    Dim b As FcxcBuscadorProductos
    Dim o As FCXCFacturasVentas

    Public objdetallefactura As cxc_detalle_factura
    Public obj As cxc_factura_ventas
    Public origen As String = ""

    Private Sub FCXCIngresoFacturasVentas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Label1.Text = "Ingreso de Facturas de Ventas" & GNombreEmpresa
            CmbTipoProducto.SelectedIndex = 1
            CmbTipoVenta.Text = "CREDITO"
            TxtIVAExento.Visible = False
            TxtNoExencion.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            obj = New cxc_factura_ventas
            obj.Fill()
            If origen = "CREAR" Then
                TxtNitCLiente.Text = "C/F"
                TxtIdFactura.Text = CType(obj.Siguiente("id_factura"), Long).ToString
                Try
                    DtmFecha.Value = DateAndTime.DateValue(Date.Now.Day.ToString + "/" + GPeriodoContable.periodo_corr.ToString + "/" + GPeriodoContable.periodo_fiscal.ToString)
                Catch ex As Exception
                    Try
                        DtmFecha.Value = DateAndTime.DateValue(GPeriodoContable.periodo_corr.ToString + "/" + Date.Now.Day.ToString + "/" + GPeriodoContable.periodo_fiscal.ToString)
                    Catch ext As Exception
                        DtmFecha.Value = DateAndTime.DateValue(GPeriodoContable.periodo_corr.ToString + "/28/" + GPeriodoContable.periodo_fiscal.ToString)
                    End Try
                End Try
                objpago = New cxc_aplicar_pagos
                objpago.Fill()
                BloquearControles(2)
            ElseIf origen = "MODIFICAR" Then
                TxtIdCliente.Text = filaresumen.idcliente
                TxtIdFactura.Text = filaresumen.idfactura
                TxtSerie.Text = filaresumen.serie_factura
                TxtNumero.Text = filaresumen.numero_factura
                DtmFecha.Value = filaresumen.fecha_factura
                TxtNombreCliente.Text = filaresumen.nombre_cliente
                TxtNitCLiente.Text = filaresumen.nit_cliente
                TxtSumaDetalle.Text = filaresumen.total_factura
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BloquearControles(parAccesso As String)
        If parAccesso = "1" Then
            TxtCodigoProducto.Enabled = False
            CmbTipoProducto.Enabled = False
            TxtNoExencion.Enabled = False
            TxtIVAExento.Enabled = False
            Button2.Enabled = False
            BtnAplicar.Enabled = False
            TxtNitCLiente.Enabled = False
        ElseIf parAccesso = "2" Then
            TxtCodigoProducto.Enabled = True
            CmbTipoProducto.Enabled = True
            TxtNoExencion.Enabled = False
            TxtIVAExento.Enabled = True
            Button2.Enabled = True
            BtnAplicar.Enabled = True
            TxtNitCLiente.Enabled = True
        End If
    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnAplicar.Click
        Try
            f = New FCXCAplicarPago
            f.objpago = objpago
            f.TxtSerie.Text = TxtSerie.Text
            f.TxtNumero.Text = TxtNumero.Text
            f.TxtMonto.Text = TxtSumaDetalle.Text
            f.TxtIdCliente.Text = TxtIdCliente.Text
            f.TxtNitCliente.Text = TxtNitCLiente.Text
            f.TxtNombreCliente.Text = TxtNombreCliente.Text
            f.TxtIdFactura.Text = TxtIdFactura.Text
            f.TxtPorAplicar.Text = TxtSumaDetalle.Text
            f.TxtVenta.Text = CmbTipoVenta.Text
            f.TipoDocumento = "FACTURA"
            f.f = Me
            f.Show()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TxtNitCLiente_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNitCLiente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ObjCliente = New cxc_clientes
                ObjCliente.Fill()
                
                h = New FcxcBuscadoClientes
                h.origen = "FACTURA"
                h.objcliente = ObjCliente
                h.g2 = Me
                h.Show()
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TxtCodigoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigoProducto.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ObjProducto = New cxc_catalogo_productos
                ObjProducto.Fill()
                b = New FcxcBuscadorProductos
                b.objproductos = ObjProducto
                b.a = Me
                b.Show()
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub TxtNitCLiente_Leave(sender As Object, e As EventArgs) Handles TxtNitCLiente.Leave
        Try
            If TxtNitCLiente.Text = "" Then
                MsgBox("No puede dejar este campo vacio, favor ingrese un numero de NIT...", MsgBoxStyle.OkOnly)
                TxtNitCLiente.Focus()
            End If
            If TxtNitCLiente.Text <> "" Then
                Dim ObjCliente As New cxc_clientes
                ObjCliente.buscarByNit(TxtNitCLiente.Text)

                If ObjCliente.DataTable.Rows.Count = 0 Then
                    If MsgBox("El Nit ingresado no existe en la base de datos... Desea ingresarlo?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        Dim F As New FcxcIngresoClientes
                        F.parNit = TxtNitCLiente.Text
                        F.objcliente = ObjCliente
                        F.ShowDialog()
                        TxtNitCLiente.Focus()
                        Exit Sub
                    End If
                End If


                Dim parInformacion As String = String.Empty
                filacliente = ObjCliente.DataTable.Rows(0)
                TxtIdCliente.Text = filacliente.id_cliente
                TxtNombreCliente.Text = filacliente.nombre
                TxtDirecCliente.Text = filacliente.direccion
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TxtCodigoProducto_Leave(sender As Object, e As EventArgs) Handles TxtCodigoProducto.Leave
        Try
            If TxtCodigoProducto.Text <> "" Then
                Dim objproducto As New cxc_catalogo_productos
                objproducto.buscarByCodigo(TxtCodigoProducto.Text)

                If objproducto.DataTable.Rows.Count = 0 Then
                    If MsgBox("El código ingresado no existe en la base de datos... Desea ingresarlo?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        Dim F As New FCXCcrearproductos
                        F.parCodigo = TxtCodigoProducto.Text
                        F.objproducto = objproducto
                        F.ShowDialog()
                        TxtCodigoProducto.Focus()
                        Exit Sub
                    End If
                End If
                Dim parInformacion As String = String.Empty
                filaproducto = objproducto.DataTable.Rows(0)
                TxtProducto.Text = filaproducto.nombre_producto
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub agregarDetalles()
        Dim values() As Object = {GEmpresa, TxtIdFactura.Text, TxtCodigoProducto.Text, TxtProducto.Text, 1, 1, TxtTotal.Text, _
                                  TxtBase.Text, TxtIVA.Text, " ", CmbTipoProducto.Text}
        Dim index As Integer = DgtDetalleFactura.Rows.Add()
        Dim currentRow As DataGridViewRow = DgtDetalleFactura.Rows(index)
        currentRow.SetValues(values)
        Dim Total As Single
        Total = 0
        For Each row As DataGridViewRow In DgtDetalleFactura.Rows
            Total += Val(row.Cells(6).Value)
        Next

        TxtSumaDetalle.Text = Total.ToString

        Dim objproducto As New cxc_catalogo_productos
        objproducto.fillbyIdCodigoAndIdEmpresa(GEmpresa, TxtCodigoProducto.Text)
        filaproducto = objproducto.DataTable.Rows(0)

        Dim varNombreCuenta As String
        Dim FilaCatalogo As Datos.cn_catalogoRow = buscarCatalago(filaproducto.codigo_contable)
        If FilaCatalogo Is Nothing Then
            MsgBox("NO EXISTE EL CODIGO EN EL CATALOGO DE CUENTAS CONTABLES....", MsgBoxStyle.Critical)
            varNombreCuenta = ""
            Exit Sub
        End If

        Dim varDescripcion As String = String.Format("F {0}{1} {2} {3} {4} ({5}) Q.{6}", TxtSerie.Text, TxtNumero.Text, _
                                                                DtmFecha.Value.ToString("dd/MM/yyyy"), _
                                                                TxtNitCLiente.Text, _
                                                                TxtNombreCliente.Text, _
                                                                TxtIVA.Text, TxtTotal.Text)
        Dim value() As Object = {filaproducto.codigo_contable, FilaCatalogo.nombre_cuenta, 1, 1, varDescripcion, 0.0, TxtBase.Text}
        Dim indice As Integer = DgtAsientoContable.Rows.Add()
        Dim currentsRow As DataGridViewRow = DgtAsientoContable.Rows(indice)
        currentsRow.SetValues(value)

        Dim valores() As Object = {"21005001", "DEBITO FISCAL", 1, 1, varDescripcion, 0.0, TxtIVA.Text}
        Dim indices As Integer = DgtAsientoContable.Rows.Add()
        Dim actualRow As DataGridViewRow = DgtAsientoContable.Rows(indices)
        actualRow.SetValues(valores)

        If CmbTipoVenta.Text = "CREDITO" Then
            Dim valores2() As Object = {"11003001", "VARIOS", 1, 1, varDescripcion, TxtSumaDetalle.Text, 0.0}
            Dim indices2 As Integer = DgtAsientoContable.Rows.Add()
            Dim actualRow2 As DataGridViewRow = DgtAsientoContable.Rows(indices2)
            actualRow2.SetValues(valores2)
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim values() As Object = {GEmpresa, TxtIdFactura.Text, TxtCodigoProducto.Text, TxtProducto.Text, 1, 1, TxtTotal.Text, _
                                  TxtBase.Text, TxtIVA.Text, " ", CmbTipoProducto.Text}
        Dim index As Integer = DgtDetalleFactura.Rows.Add()
        Dim currentRow As DataGridViewRow = DgtDetalleFactura.Rows(index)
        currentRow.SetValues(values)
        Dim Total As Single
        Total = 0
        For Each row As DataGridViewRow In DgtDetalleFactura.Rows
            Total += Val(row.Cells(6).Value)
        Next

        TxtSumaDetalle.Text = Total.ToString

        Dim objproducto As New cxc_catalogo_productos
        objproducto.fillbyIdCodigoAndIdEmpresa(GEmpresa, TxtCodigoProducto.Text)
        filaproducto = objproducto.DataTable.Rows(0)

        Dim varNombreCuenta As String
        Dim FilaCatalogo As Datos.cn_catalogoRow = buscarCatalago(filaproducto.codigo_contable)
        If FilaCatalogo Is Nothing Then
            MsgBox("NO EXISTE EL CODIGO EN EL CATALOGO DE CUENTAS CONTABLES....", MsgBoxStyle.Critical)
            varNombreCuenta = ""
            Exit Sub
        End If

        Dim varDescripcion As String = String.Format("F {0}{1} {2} {3} {4} ({5}) Q.{6}", TxtSerie.Text, TxtNumero.Text, _
                                                                DtmFecha.Value.ToString("dd/MM/yyyy"), _
                                                                TxtNitCLiente.Text, _
                                                                TxtNombreCliente.Text, _
                                                                TxtIVA.Text, TxtTotal.Text)
        Dim value() As Object = {filaproducto.codigo_contable, FilaCatalogo.nombre_cuenta, 1, 1, varDescripcion, 0.0, TxtBase.Text}
        Dim indice As Integer = DgtAsientoContable.Rows.Add()
        Dim currentsRow As DataGridViewRow = DgtAsientoContable.Rows(indice)
        currentsRow.SetValues(value)

        Dim valores() As Object = {"21005001", "DEBITO FISCAL", 1, 1, varDescripcion, 0.0, TxtIVA.Text}
        Dim indices As Integer = DgtAsientoContable.Rows.Add()
        Dim actualRow As DataGridViewRow = DgtAsientoContable.Rows(indices)
        actualRow.SetValues(valores)

        If CmbTipoVenta.Text = "CREDITO" Then
            Dim valores2() As Object = {"11003002", "VARIOS", 1, 1, varDescripcion, TxtSumaDetalle.Text, 0.0}
            Dim indices2 As Integer = DgtAsientoContable.Rows.Add()
            Dim actualRow2 As DataGridViewRow = DgtAsientoContable.Rows(indices2)
            actualRow2.SetValues(valores2)
        End If

    End Sub
    Private Sub vaciarDetalle()
        Try
            CmbTipoProducto.Text = ""
            TxtTotal.Text = ""
            TxtCodigoProducto.Text = ""
            TxtProducto.Text = ""
            TxtBase.Text = ""
            TxtIVA.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Private Function buscarCatalago(parCodigoCuenta As String) As Datos.cn_catalogoRow
        Try
            Dim ObjCatalogo As New Cn_Catalogo
            ObjCatalogo.FillByCuenta(GEmpresa, parCodigoCuenta)

            If ObjCatalogo.DataTable.Rows.Count > 0 Then
                Return ObjCatalogo.DataTable.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim varProceso As Integer = Sesion.getProcesoID()
        Try
            If origen = "CREAR" Then
                If CmbTipoVenta.Text = "CONTADO" Then
                    If TxtEfectivo.Text = "" Or TxtTarjetasCredito.Text = "" Then
                        MsgBox("No ha aplicado pago a la factura favor realizarlo", MsgBoxStyle.OkOnly)
                        BtnAplicar.Focus()
                    Else
                        objdetallefactura = New cxc_detalle_factura
                        objdetallefactura.Fill()
                        Dim linea As Integer = 1
                        Dim filadetalle As Datos.cxc_detalle_facturaRow = Nothing
                        For Each row As DataGridViewRow In DgtDetalleFactura.Rows

                            filadetalle = objdetallefactura.NuevoRegistro()
                            filadetalle.id_empresa = Convert.ToString(row.Cells(0).Value)
                            filadetalle.id_factura = Convert.ToString(row.Cells(1).Value)
                            filadetalle.id_detalle_factura = linea
                            filadetalle.cod_producto = Convert.ToString(row.Cells(2).Value)
                            filadetalle.producto = Convert.ToString(row.Cells(3).Value)
                            filadetalle.cantidad = Convert.ToString(row.Cells(4).Value)
                            filadetalle.precio_unitario = Convert.ToString(row.Cells(5).Value)
                            filadetalle.precio_total = Convert.ToString(row.Cells(6).Value)
                            filadetalle.base = Convert.ToString(row.Cells(7).Value)
                            filadetalle.iva = Convert.ToString(row.Cells(8).Value)
                            filadetalle.ref_exencion = Convert.ToString(row.Cells(9).Value)
                            filadetalle.tipo_producto = Convert.ToString(row.Cells(10).Value)
                            linea += 1
                            objdetallefactura.AgregarRegistro(filadetalle)
                        Next
                        objdetallefactura.Update()

                        objfactura = New cxc_factura_ventas
                        objfactura.FillByEmpresa(GEmpresa)
                        Dim fila As Datos.cxc_factura_ventasRow = Nothing
                        fila = objfactura.NuevoRegistro
                        fila.id_factura = TxtIdFactura.Text
                        fila.idempresa = GEmpresa
                        fila.id_proceso = varProceso
                        fila.serie_factura = TxtSerie.Text
                        fila.numero = TxtNumero.Text
                        fila.fecha = DtmFecha.Text
                        fila.id_cliente = TxtIdCliente.Text
                        fila.estado = "PAGADA"
                        fila.tipo_venta = "CONTADO"
                        fila.id_estado = 1
                        fila.id_estado_bancos = 1
                        fila.estado_bancos = "NO REGISTRADO"
                        fila.id_recibo = 0
                        objfactura.AgregarRegistro(fila)
                        objfactura.Update()

                        Dim objresumenventas As tb_resumen_ventas
                        objresumenventas = New tb_resumen_ventas
                        Dim datatabla As DataSet
                        datatabla = objresumenventas.CargarResumenVentas(52, GEmpresa, 1)
                        Dim fecha As Date
                        fecha = DtmFecha.Text
                        Dim G As New FCXCFacturasVentas
                        G.DgtResumenVentas.DataSource = objresumenventas.DataTable.DefaultView

                        Dim varDescripcion As String = String.Format("F {0}{1} {2} {3} {4} ({5}) Q.{6}", TxtSerie.Text, TxtNumero.Text, _
                                                                                fecha.ToString("yyyy/MM/dd"), _
                                                                                TxtNitCLiente.Text, _
                                                                                TxtNombreCliente.Text, _
                                                                                TxtIVA.Text, TxtTotal.Text)

                        Dim varLinea As Integer = 1
                        objpartidacontabletemporal = New Cn_Partida_Contable_Enc
                        objpartidacontabletemporal.BorrarTemporal(varProceso)
                        objpartidacontabletemporal.FillByPeriodoContable(GEmpresa, GPeriodoContable.periodo_fiscal, GPeriodoContable.periodo_corr)
                        For Each row As DataGridViewRow In DgtAsientoContable.Rows
                            objpartidacontabletemporal.AgregarLineaTemporal(varProceso, varLinea, Convert.ToString(row.Cells(0).Value), Convert.ToString(row.Cells(2).Value), Convert.ToString(row.Cells(3).Value), Convert.ToString(row.Cells(4).Value), Convert.ToString(row.Cells(5).Value), Convert.ToString(row.Cells(6).Value))
                            varLinea += 1
                        Next
                        Dim varNoAsiento As Integer = -1
                        varNoAsiento = DarNumeroAsiento().ToString.PadLeft(5, "0")
                        Dim varAsiento As Integer = objpartidacontabletemporal.crearPartidaContable(GEmpresa, varProceso, GPeriodoContable.periodo_fiscal, GPeriodoContable.periodo_corr, _
                                                                                                    "FV", TxtSerie.Text, TxtNumero.Text, DtmFecha.Text, varDescripcion, GUsuario, -1)


                        MsgBox(String.Format("Asiento Contable Asignado #{0}", varNoAsiento), MsgBoxStyle.Information)

                        'Me.Dispose()
                        LimpiarFormulario()
                        CmbTipoVenta.Focus()
                    End If
                Else
                    agregarDetalles()
                    objdetallefactura = New cxc_detalle_factura
                    objdetallefactura.Fill()
                    Dim linea As Integer = 1
                    Dim filadetalle As Datos.cxc_detalle_facturaRow = Nothing
                    For Each row As DataGridViewRow In DgtDetalleFactura.Rows

                        filadetalle = objdetallefactura.NuevoRegistro()
                        filadetalle.id_empresa = Convert.ToString(row.Cells(0).Value)
                        filadetalle.id_factura = Convert.ToString(row.Cells(1).Value)
                        filadetalle.id_detalle_factura = linea
                        filadetalle.cod_producto = Convert.ToString(row.Cells(2).Value)
                        filadetalle.producto = Convert.ToString(row.Cells(3).Value)
                        filadetalle.cantidad = Convert.ToString(row.Cells(4).Value)
                        filadetalle.precio_unitario = Convert.ToString(row.Cells(5).Value)
                        filadetalle.precio_total = Convert.ToString(row.Cells(6).Value)
                        filadetalle.base = Convert.ToString(row.Cells(7).Value)
                        filadetalle.iva = Convert.ToString(row.Cells(8).Value)
                        filadetalle.ref_exencion = Convert.ToString(row.Cells(9).Value)
                        filadetalle.tipo_producto = Convert.ToString(row.Cells(10).Value)
                        linea += 1
                        objdetallefactura.AgregarRegistro(filadetalle)
                    Next

                    objdetallefactura.Update()
                    objfactura = New cxc_factura_ventas
                    objfactura.FillByEmpresa(GEmpresa)
                    Dim fila As Datos.cxc_factura_ventasRow = Nothing
                    fila = objfactura.NuevoRegistro
                    fila.id_factura = TxtIdFactura.Text
                    fila.idempresa = GEmpresa
                    fila.id_proceso = varProceso
                    fila.serie_factura = TxtSerie.Text
                    fila.numero = TxtNumero.Text
                    fila.fecha = DtmFecha.Text
                    fila.id_cliente = TxtIdCliente.Text
                    fila.estado = "ACTIVA"
                    fila.tipo_venta = "CREDITO"
                    fila.id_estado = 2
                    fila.id_estado_bancos = 1
                    fila.estado_bancos = "NO REGISTRADO"
                    fila.id_recibo = 0
                    objfactura.AgregarRegistro(fila)
                    objfactura.Update()
                    Dim objresumenventas As tb_resumen_ventas
                    objresumenventas = New tb_resumen_ventas
                    Dim datatabla As DataSet
                    datatabla = objresumenventas.CargarResumenVentas(52, GEmpresa, 1)
                    Dim fecha As Date
                    fecha = DtmFecha.Text
                    Dim G As New FCXCFacturasVentas
                    G.DgtResumenVentas.DataSource = objresumenventas.DataTable.DefaultView

                    Dim varDescripcion As String = String.Format("F {0}{1} {2} {3} {4} ({5}) Q.{6}", TxtSerie.Text, TxtNumero.Text, _
                                                                            fecha.ToString("yyyy/MM/dd"), _
                                                                            TxtNitCLiente.Text, _
                                                                            TxtNombreCliente.Text, _
                                                                            TxtIVA.Text, TxtTotal.Text)

                    Dim varLinea As Integer = 1
                    objpartidacontabletemporal = New Cn_Partida_Contable_Enc
                    objpartidacontabletemporal.BorrarTemporal(varProceso)
                    objpartidacontabletemporal.FillByPeriodoContable(GEmpresa, GPeriodoContable.periodo_fiscal, GPeriodoContable.periodo_corr)
                    For Each row As DataGridViewRow In DgtAsientoContable.Rows
                        objpartidacontabletemporal.AgregarLineaTemporal(varProceso, varLinea, Convert.ToString(row.Cells(0).Value), Convert.ToString(row.Cells(2).Value), Convert.ToString(row.Cells(3).Value), Convert.ToString(row.Cells(4).Value), Convert.ToString(row.Cells(5).Value), Convert.ToString(row.Cells(6).Value))
                        varLinea += 1
                    Next
                    Dim varNoAsiento As Integer = -1
                    varNoAsiento = DarNumeroAsiento().ToString.PadLeft(5, "0")
                    Dim varAsiento As Integer = objpartidacontabletemporal.crearPartidaContable(GEmpresa, varProceso, GPeriodoContable.periodo_fiscal, GPeriodoContable.periodo_corr, _
                                                                                                "FV", TxtSerie.Text, TxtNumero.Text, DtmFecha.Text, varDescripcion, GUsuario, -1)

                    If CmbTipoVenta.Text = "CREDITO" Then
                        Dim lineas As Integer = 1
                        Dim filapago As Datos.cxc_aplicar_pagosRow = Nothing
                        objpago = New cxc_aplicar_pagos
                        objpago.Fill()
                        filapago = objpago.NuevoRegistro()
                        filapago.id_pago = lineas
                        filapago.tarjeta_credito = " "
                        filapago.tarjeta_credito_ref = " "
                        filapago.banco = " "
                        filapago.cheque = 0
                        filapago.monto = TxtSumaDetalle.Text
                        filapago.id_factura = TxtIdFactura.Text
                        filapago.tipo_pago = "CREDITO"
                        filapago.id_forma_pago = 3
                        objpago.AgregarRegistro(filapago)
                        objpago.Update()
                    End If
                    MsgBox(String.Format("Asiento Contable Asignado #{0}", varNoAsiento), MsgBoxStyle.Information)

                    objventasasiento = New tb_ventas_asiento
                    objventasasiento.Fill()
                    filaVentasAsiento = objventasasiento.NuevoRegistro()
                    filaVentasAsiento.idempresa = GEmpresa
                    filaVentasAsiento.asiento = varNoAsiento
                    filaVentasAsiento.idfactura = TxtIdFactura.Text
                    filaVentasAsiento.periodoCorr = GPeriodoContable.periodo_corr
                    filaVentasAsiento.periodoFiscal = GPeriodoContable.periodo_fiscal

                    objventasasiento.AgregarRegistro(filaVentasAsiento)
                    objventasasiento.Update()

                    'Me.Dispose()
                    LimpiarFormulario()
                    CmbTipoVenta.Focus()
                End If
            ElseIf origen = "MODIFICAR" Then
                objfactura = New cxc_factura_ventas
                objfactura.fillbyid_factura(TxtIdFactura.Text)
                Dim Fila As Datos.cxc_factura_ventasRow = Nothing
                Fila = objfactura.DataTable.Rows(0)
                Fila.serie_factura = TxtSerie.Text
                Fila.numero = TxtNumero.Text
                Fila.fecha = DtmFecha.Text
                objfactura.Update()

                Dim objresumenventas As tb_resumen_ventas
                objresumenventas = New tb_resumen_ventas
                Dim datatabla As DataSet
                datatabla = objresumenventas.CargarResumenVentas(52, GEmpresa, 1)
                Dim o As New FCXCFacturasVentas
                o.DgtResumenVentas.DataSource = datatabla.Tables(0).DefaultView
                o.f = Me
                MsgBox("Cambios aplicados correctamente...", MsgBoxStyle.OkOnly, "Aviso")
                Me.Dispose()
            End If

        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CmbTipoVenta_Leave(sender As Object, e As EventArgs) Handles CmbTipoProducto.Leave
        If CmbTipoProducto.Text = "BIEN" Then
            TxtCodigoProducto.Text = 10
            Dim objproducto As New cxc_catalogo_productos
            objproducto.buscarByCodigo(TxtCodigoProducto.Text)
            Dim parInformacion As String = String.Empty
            filaproducto = objproducto.DataTable.Rows(0)
            TxtProducto.Text = filaproducto.nombre_producto
        ElseIf CmbTipoProducto.Text = "SERVICIO" Then
            TxtCodigoProducto.Text = 11
            Dim objproducto As New cxc_catalogo_productos
            objproducto.buscarByCodigo(TxtCodigoProducto.Text)
            Dim parInformacion As String = String.Empty
            filaproducto = objproducto.DataTable.Rows(0)
            TxtProducto.Text = filaproducto.nombre_producto
        End If

    End Sub


    Private Sub CmbTipoVenta_Leave1(sender As Object, e As EventArgs) Handles CmbTipoVenta.Leave
        If CmbTipoVenta.SelectedItem = "CREDITO" Then
            BtnAplicar.Visible = False
            TxtEfectivo.Visible = False
            TxtCheques.Visible = False
            TxtTarjetasCredito.Visible = False
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
        Else
            BtnAplicar.Visible = True
            TxtEfectivo.Visible = True
            TxtCheques.Visible = True
            TxtTarjetasCredito.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
        End If
    End Sub
    Private Function DarNumeroAsiento() As Integer
        Try
            Dim ObjNoAsiento As New Cn_Periodo_Contable
            Return ObjNoAsiento.darCorrelativo(GEmpresa, GPeriodoContable.periodo_fiscal, GPeriodoContable.periodo_corr)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtNitCLiente.Text = " "
        Me.Dispose()
    End Sub

    Private Sub DtmFecha_Leave(sender As Object, e As EventArgs) Handles DtmFecha.Leave
        If Month(DtmFecha.Text) <> GPeriodoContable.periodo_corr Then
            MsgBox("La fecha ingresada es incorrecta, favor ingrese nuevamente", vbOKOnly)
            DtmFecha.Focus()
        End If
    End Sub
    Private Sub LimpiarFormulario()
        TxtSerie.Text = ""
        TxtNumero.Text = ""
        TxtNitCLiente.Text = "C/F"
        TxtNombreCliente.Text = ""
        TxtDirecCliente.Text = ""
        TxtCodigoProducto.Text = ""
        TxtProducto.Text = ""
        TxtTotal.Text = ""
        TxtBase.Text = ""
        TxtIVA.Text = ""
        TxtNoExencion.Text = ""
        TxtIVAExento.Text = ""
        TxtEfectivo.Text = ""
        TxtTarjetasCredito.Text = ""
        TxtSumaDetalle.Text = ""
        DgtDetalleFactura.Rows.Clear()
        DgtAsientoContable.Rows.Clear()
        CmbTipoProducto.SelectedIndex = 1
        Try
            TxtIVAExento.Visible = False
            TxtNoExencion.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            obj = New cxc_factura_ventas
            obj.Fill()
            TxtIdFactura.Text = CType(obj.Siguiente("id_factura"), Long).ToString
            Try
                DtmFecha.Value = DateAndTime.DateValue(Date.Now.Day.ToString + "/" + GPeriodoContable.periodo_corr.ToString + "/" + GPeriodoContable.periodo_fiscal.ToString)
            Catch ex As Exception
                Try
                    DtmFecha.Value = DateAndTime.DateValue(GPeriodoContable.periodo_corr.ToString + "/" + Date.Now.Day.ToString + "/" + GPeriodoContable.periodo_fiscal.ToString)
                Catch ext As Exception
                    DtmFecha.Value = DateAndTime.DateValue(GPeriodoContable.periodo_corr.ToString + "/28/" + GPeriodoContable.periodo_fiscal.ToString)
                End Try
            End Try
            objpago = New cxc_aplicar_pagos
            objpago.Fill()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TxtNombreCliente_Leave(sender As Object, e As EventArgs) Handles TxtNombreCliente.Leave
        Dim objcompras As tb_resumen_ventas
        objcompras = New tb_resumen_ventas
        If objcompras.VerificaDocumento(GEmpresa, TxtIdCliente.Text, TxtSerie.Text, TxtNumero.Text) Then
            MsgBox("Este documento ya fue ingresado anteriormente, por favor veriquelo...", MsgBoxStyle.Critical)
            TxtNumero.Text = ""
            TxtSerie.Text = ""
            TxtSerie.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub TxtTotal_Leave(sender As Object, e As EventArgs) Handles TxtTotal.Leave
        Try
            Dim objcliente As cxc_clientes
            Dim filacliente As Datos.cxc_clientesRow = Nothing
            If TxtTotal.Text = "" Then
                MsgBox("No puede dejar este campo vacio, favor ingrese un monto para continuar", MsgBoxStyle.OkOnly, "Mensaje de Validación")
                TxtTotal.Focus()
                Exit Sub
            End If
            TxtTotal.Text = CType(TxtTotal.Text, Decimal).ToString("N2")
            objcliente = New cxc_clientes
            objcliente.fillbyIdCodigoCliente(TxtIdCliente.Text)
            filacliente = objcliente.DataTable.Rows(0)
            If filacliente.regimen = "SI" Then
                TxtBase.Text = TxtTotal.Text
                TxtIVA.Text = 0
                Label21.Visible = False
                Label22.Visible = True
                TxtNoExencion.Visible = False
                TxtIVAExento.Visible = True
                TxtIVAExento.Text = FormatNumber((TxtTotal.Text / 1.12) * 0.12, 2)
            Else
                TxtBase.Text = FormatNumber(TxtTotal.Text / 1.12, 2)
                TxtIVA.Text = FormatNumber(TxtBase.Text * 0.12, 2)
                Label21.Visible = False
                Label22.Visible = False
                TxtNoExencion.Visible = False
                TxtIVAExento.Visible = False
                TxtIVAExento.Text = 0
            End If

        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Private Sub TxtPruebaENTER_KeyPress(ByVal sender As Object, _
                           ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                       Handles TxtBase.KeyPress, TxtCheques.KeyPress, TxtCodigoProducto.KeyPress, TxtDirecCliente.KeyPress, TxtEfectivo.KeyPress, TxtIdCliente.KeyPress, TxtIdFactura.KeyPress _
                       , TxtIVA.KeyPress, TxtIVAExento.KeyPress, TxtNitCLiente.KeyPress, TxtNoExencion.KeyPress, TxtNombreCliente.KeyPress, TxtNumero.KeyPress, TxtProducto.KeyPress, _
                       TxtSerie.KeyPress, TxtSumaDetalle.KeyPress, TxtTarjetasCredito.KeyPress, TxtTotal.KeyPress, CmbTipoProducto.KeyPress, CmbTipoVenta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class