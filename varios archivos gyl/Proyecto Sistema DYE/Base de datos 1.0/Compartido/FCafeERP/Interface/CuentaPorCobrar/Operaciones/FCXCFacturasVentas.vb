Public Class FCXCFacturasVentas
    Public objfactura As cxc_factura_ventas
    Public objresumenfacturas As tb_resumen_ventas
    Public origen As String = ""
    Public f As FCXCIngresoFacturasVentas
    Private Sub FCXCFacturasVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objresumenfacturas = New tb_resumen_ventas(Me.Datos)
            objresumenfacturas.FillByEmpresa(GEmpresa)


            DgtResumenVentas.DataSource = objresumenfacturas.DataTable.DefaultView
            DgtResumenVentas.Columns("idproceso").Visible = False
            DgtResumenVentas.Columns("idresumen").Visible = False
            DgtResumenVentas.Columns("idempresa").HeaderText = "Empresa"
            DgtResumenVentas.Columns("idempresa").Width = 50
            DgtResumenVentas.Columns("idcliente").Width = 50
            DgtResumenVentas.Columns("idfactura").Width = 50
            DgtResumenVentas.Columns("numero_factura").Width = 50
            DgtResumenVentas.Columns("serie_factura").Width = 50
            DgtResumenVentas.Columns("nit_cliente").Width = 75
            DgtResumenVentas.Columns("nombre_cliente").Width = 300

            DgtResumenVentas.Columns("idcliente").HeaderText = "ID Cliente"
            DgtResumenVentas.Columns("idfactura").HeaderText = "ID Factura"
            DgtResumenVentas.Columns("serie_factura").HeaderText = "Serie"
            DgtResumenVentas.Columns("numero_factura").HeaderText = "No."
            DgtResumenVentas.Columns("nit_cliente").HeaderText = "NIT"
            DgtResumenVentas.Columns("nombre_cliente").HeaderText = "Cliente"
            DgtResumenVentas.Columns("total_factura").HeaderText = "Monto"
            DgtResumenVentas.Columns("fecha_factura").HeaderText = "Fecha"
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        Try
            f = New FCXCIngresoFacturasVentas
            f.origen = "CREAR"
            f.objfactura = objfactura
            f.Show()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Try
            f = New FCXCIngresoFacturasVentas
            f.filaresumen = objresumenfacturas.DefaultViewRow(DgtResumenVentas.CurrentRow.Index)
            f.origen = "MODIFICAR"
            f.objfactura = objfactura
            f.Show()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
        
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        Try
            If MsgBox("Seguro que desea anular el registro seleccionado...", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
                Exit Sub
            End If
            objfactura = New cxc_factura_ventas
            Dim filaresumen As Datos.tb_resumen_ventasRow
            Dim varproceso As Integer = Sesion.getProcesoID
            filaresumen = objresumenfacturas.DefaultViewRow(DgtResumenVentas.CurrentRow.Index)

            objfactura.AnularFacturas(filaresumen.idempresa, filaresumen.idfactura, varproceso, filaresumen.serie_factura, filaresumen.numero_factura, CType(filaresumen.fecha_factura, Date), GUsuario)
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
End Class