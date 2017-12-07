Public Class FCXPFacturasComprasIngreso

    Public objCompras As Debito_Compras
    ' datos que se usarán más tarde para ingresarán en las contraseñas...
    Public parDocRecepcion As String = ""
    Public parNit As String = ""
    Public parSerie As String
    Public parFactura As String
    Public parFechaFactura As Date
    Public parTotal_Factura As Double
    ' termina todo aca.   

    Dim FilaProveedor As Datos.proveedorRow = Nothing
    Dim varTasaIva As Double = 0.0

    Private Sub FCXPFacturasComprasIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lbTitulo.Text = Sesion.darTituloPeriodo()
            varTasaIva = Sesion.darTasaIvaFiscal()
            txtTotalFactura.Tag = "0.00"
            txtTipoLibro.SelectedIndex = 0
            ' Cargar a referente a las facturas que vienen en camino.
            Try
                dtpFecha.Value = DateAndTime.DateValue(Date.Now.Day.ToString + "/" + GPeriodoContable.periodo_corr.ToString + "/" + GPeriodoContable.periodo_fiscal.ToString)
            Catch ex As Exception
                Try
                    dtpFecha.Value = DateAndTime.DateValue(GPeriodoContable.periodo_corr.ToString + "/" + Date.Now.Day.ToString + "/" + GPeriodoContable.periodo_fiscal.ToString)
                Catch ext As Exception
                    dtpFecha.Value = DateAndTime.DateValue(GPeriodoContable.periodo_corr.ToString + "/28/" + GPeriodoContable.periodo_fiscal.ToString)
                End Try
            End Try
            If parNit <> "" Then
                txtNit.Text = parNit
                txtNit.Enabled = False
                txtNit_Leave(sender, e)

                txtSerie.Text = parSerie
                txtDocumento.Text = parFactura
                txtSerie.ReadOnly = True
                txtDocumento.ReadOnly = True

                dtpFecha.Value = parFechaFactura
                dtpFecha.Enabled = False

                txtTotalFactura.Text = parTotal_Factura.ToString("N2")
                txtTotalFactura.ReadOnly = True

                txtTotalFactura_Leave(sender, e)

            End If
            ' carga Combos que se usarán....
            CargaCombos()
            txtSerie.Focus()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmbCentroCosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCentroCosto.SelectedIndexChanged
        Try
            Dim parCentro As String = CType(cmbCentroCosto.Text.Split("-").GetValue(0), String).Trim
            CargaComboSubCentro(parCentro)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CargaCombos()
        Try
            Dim ObjTipoFactura As New Cxp_Tipo_Factura
            ObjTipoFactura.FillByEmpresa(GEmpresa)

            cmbTipoFactura.Items.Clear()
            For Each FilaTipo As Datos.cxp_tipo_facturaRow In ObjTipoFactura.DataTable.Rows
                cmbTipoFactura.Items.Add(FilaTipo.idcodigo + " - " + FilaTipo.nombre.ToUpper)
            Next
            If cmbTipoFactura.Items.Count > 0 Then
                cmbTipoFactura.SelectedIndex = 0
            End If
            cmbTipoLibro.SelectedIndex = 0

            Dim ObjCentroCosto As New Cn_Centro_Costo
            ObjCentroCosto.FillByEmpresa(GEmpresa)

            cmbCentroCosto.Items.Clear()
            For Each FilaCentro As Datos.cn_centro_costoRow In ObjCentroCosto.DataTable.Rows
                cmbCentroCosto.Items.Add(FilaCentro.idcentro + " - " + FilaCentro.nombre_centro.ToUpper)
            Next

            If cmbCentroCosto.Items.Count > 0 Then
                cmbCentroCosto.SelectedIndex = 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CargaComboSubCentro(parIDCentro As String)
        Try
            Dim ObjSubCentro As New Cn_Centro_Costo_Det
            ObjSubCentro.FillByEmpresaCentroCostro(GEmpresa, parIDCentro)

            cmbSubCentro.Items.Clear()
            For Each Fila As Datos.cn_centro_costo_detRow In ObjSubCentro.DataTable.Rows
                cmbSubCentro.Items.Add(Fila.idsubcentro + " - " + Fila.nombre_subcentro)
            Next
            If cmbSubCentro.Items.Count > 0 Then
                cmbSubCentro.SelectedIndex = 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub txtNit_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNit.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txtNit_Leave(sender, New EventArgs)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNit_Leave(sender As Object, e As EventArgs) Handles txtNit.Leave
        Try
            If txtNit.Text <> "" Then
                Dim ObjProveedor As New Proveedor
                ObjProveedor.buscarByNit(txtNit.Text)

                If ObjProveedor.DataTable.Rows.Count = 0 Then
                    If MsgBox("Este proveedor no existe en la base de datos... Desea ingresarlo de una vez?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
                        Exit Sub
                    Else
                        Dim F As New FCXPProveedorIngreso
                        F.parNit = txtNit.Text
                        F.ObjProveedor = ObjProveedor
                        F.ShowDialog()

                        txtNit.Focus()
                        Exit Sub
                    End If
                End If

                Dim parInformacion As String = String.Empty
                FilaProveedor = ObjProveedor.DataTable.Rows(0)
                txtCodigoProveedor.Text = FilaProveedor.codproveedor
                txtNombreProveedor.Text = FilaProveedor.nombre_proveedor.ToUpper
                If FilaProveedor.agente_retenedor = 1 Then
                    parInformacion = "AGENTE RETENEDOR "
                End If
                If FilaProveedor.pequeno = 1 Then
                    parInformacion += "// PEQUEÑO CONTRIBUYENTE"
                    cmbTipoFactura.SelectedIndex = 2
                End If
                If FilaProveedor.pagos_trimestrales = 1 Then
                    parInformacion += "// PAGOS TRIMESTRALES"
                End If
                If FilaProveedor.tarjeta_credito = 1 Then
                    parInformacion += "// ES DE TARJETA CREDITO"
                End If
                txtInformacion.Text = parInformacion.ToUpper
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtTotalFactura_Leave(sender As Object, e As EventArgs) Handles txtTotalFactura.Leave
        Try
            txtTotalFactura.Text = CType(txtTotalFactura.Text, Double).ToString("N2")
            If Not IsNumeric(txtTotalFactura.Text) Then
                MsgBox("EL TOTAL DE LA FACTURA NO ES VALIDA...", MsgBoxStyle.Critical)
                txtTotalFactura.Text = "0.00"
                txtTotalFactura.Focus()
                Exit Sub
            End If
            txtTotalFactura.Tag = txtTotalFactura.Text

            If txtTotalFactura.Tag <> "0.00" Then
                txtTasaMunicipal.Enabled = True
            End If

            CalculoIva(txtTotalFactura.Text)
            calculaOtrosImpuestos()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CalculaOtrosImpuestos()
        Try
            If objCompras.darTipoDocumentoIva(GEmpresa, darSplit(cmbTipoFactura.Text)) = 1 Then
                txtImpuesto_isr.Text = objCompras.CalcularRetIsrDoc(txtCodigoProveedor.Text,
                                                                    Sesion.darSplit(cmbTipoLibro.Text),
                                                                    Sesion.darSplit(cmbTipoFactura.Text),
                                                                    txtTotalFactura.Text)

                txtTimbres.Text = objCompras.CalcularRetIsrTimbre(Sesion.darSplit(cmbTipoFactura.Text), txtTotalFactura.Text)
                If CType(txtTimbres.Text, Decimal) <> 0.0 Then
                    txtTimbres.Visible = True
                    lbTimbres.Visible = True
                    txtImpuesto_retiva.Text = "0.00"
                Else
                    txtTimbres.Visible = False
                    lbTimbres.Visible = False
                    txtImpuesto_retiva.Text = objCompras.CalcularRetIva(txtNit.Text, txtTotalFactura.Text, txtImpuesto_iva.Text, 15).ToString("N2")
                End If

            Else
                txtImpuesto_isr.Text = "0.00"
                txtTimbres.Text = "0.00"
                txtImpuesto_retiva.Text = "0.00"
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CalculoIva(parTotalFactura As Double)
        Try
            Dim varSubTotal As Double = parTotalFactura / (1 + (varTasaIva / 100))
            'Format(parTotalFactura / (1 + (varTasaIva / 100)), "#.##")
            Dim varIva As Double = parTotalFactura - varSubTotal

            If objCompras.darTipoDocumentoIva(GEmpresa, darSplit(cmbTipoFactura.Text)) = 1 Then
                If FilaProveedor.pequeno = 1 Then
                    txtImpuesto_iva.Text = "0.00"
                Else
                    txtImpuesto_iva.Text = varIva.ToString("N2")
                End If

                If CType(cmbTipoLibro.Text.Split("-").GetValue(0), String).Trim = "S" Or CType(cmbTipoLibro.Text.Split("-").GetValue(0), String).Trim = "B" Then  ' es bien.
                    txtServicio.Text = (CType(txtTotalFactura.Text, Decimal) - CType(txtImpuesto_iva.Text, Decimal)).ToString("N2")
                    txtBien.Text = "0.00"
                    btnCalculoCombustible.Visible = False
                    Label14.Visible = False
                    txtImpuesto_idp.Visible = False
                Else
                    txtBien.Text = (CType(txtTotalFactura.Text, Decimal) - CType(txtImpuesto_iva.Text, Decimal)).ToString("N2")
                    txtServicio.Text = "0.00"
                    If CType(cmbTipoLibro.Text.Split("-").GetValue(0), String).Trim = "C" Then
                        btnCalculoCombustible.Visible = True
                        Label14.Visible = True
                        txtImpuesto_idp.Visible = True
                    End If
                End If

            Else
                txtImpuesto_iva.Text = "0.00"
                If CType(cmbTipoLibro.Text.Split("-").GetValue(0), String).Trim = "S" Or CType(cmbTipoLibro.Text.Split("-").GetValue(0), String).Trim = "B" Then  ' es bien.
                    txtServicio.Text = txtTotalFactura.Text
                    txtBien.Text = "0.00"
                Else
                    txtServicio.Text = "0.00"
                    txtBien.Text = txtTotalFactura.Text
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTotalFactura_TextChanged(sender As Object, e As EventArgs) Handles txtTotalFactura.TextChanged
        Try
            ' calculo para el iva.
            CalculoIva(txtTotalFactura.Text)
            CalculaOtrosImpuestos()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculoCombustible.Click
        Try
            Dim F As New FCXPFacturasComprasCombustible
            F.parTotalFactura = txtTotalFactura.Text
            F.parTasaIva = varTasaIva
            F.parImpuestoidp = txtImpuesto_idp
            F.parImpuestoIva = txtImpuesto_iva
            F.ShowDialog()

            CalculaOtrosImpuestos()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ' Vamos a Generar el asiento contable del contribuyente.
            If txtSerie.Text = "" Then
                MsgBox("Tiene que ingresar un numero de serie para poder generar los gastos...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If txtDescripcion.Text = "" Then
                MsgBox("Tiene que ingresar una descripcion de documento para poder generar los gastos...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If txtNit.Text = "" Then
                MsgBox("Todavia no ha generado un numero de nit para este documento...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If CType(txtTotalFactura.Text, Double) <= 0 Then
                MsgBox("Tiene que ingresar un total valido para este factura...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If objCompras.darTipoDocumentoIva(GEmpresa, darSplit(cmbTipoFactura.Text)) = 1 Then
                If txtDocumento.Text = "" Then
                    MsgBox("Tiene que ingresar un numero de documento para poder generar los gastos...", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If objCompras.VerificaDocumento(GEmpresa, txtCodigoProveedor.Text, txtSerie.Text, txtDocumento.Text) Then
                    MsgBox("Este documento ya fue ingresado anteriormente, por favor veriquelo...", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

            Dg1.Enabled = True
            txtTotalFactura.Enabled = False
            btnCalculoCombustible.Enabled = False

            Dim ObjVariable As New Control_Variable
            ObjVariable.FillByEmpresa(GEmpresa)

            Dim stCuentaCxp As String = ObjVariable.FindByVariableString(GEmpresa, "CUENTA_CXP")
            Dim stCuentaIva As String = ObjVariable.FindByVariableString(GEmpresa, "CUENTA_IVA")
            Dim stCuentaIdp As String = ObjVariable.FindByVariableString(GEmpresa, "CUENTA_IDP")
            Dim stCuentaIsr As String = ObjVariable.FindByVariableString(GEmpresa, "CUENTA_ISR")
            Dim stCuentaRetiva As String = ObjVariable.FindByVariableString(GEmpresa, "CUENTA_RETIVA")
            Dim stCuentaTimbres As String = ObjVariable.FindByVariableString(GEmpresa, "CUENTA_TIMBRES")
            Dim stCuentaTasaMunicipal As String = ObjVariable.FindByVariableString(GEmpresa, "CUENTA_TASA_MUNICIPAL")

            Dim stTipoIva As String = CType(cmbTipoLibro.Text.Split("-").GetValue(0), String).Trim

            Dim stConcepto As String = String.Format("F {0}{1} {2} {3} {4} ({5}) Q.{6}", txtSerie.Text, txtDocumento.Text, _
                                                                dtpFecha.Value.ToString("dd/MM/yyyy"), _
                                                                txtNit.Text, _
                                                                txtNombreProveedor.Text, _
                                                                stTipoIva, txtTotalFactura.Text)

            Dim _TotalPorPagar As Double = CType(txtTotalFactura.Text, Double) - CType(txtImpuesto_isr.Text, Double) - CType(txtImpuesto_retiva.Text, Double) -
                CType(txtTimbres.Text, Double)

            ' empezamos a poner a trasladar los datos en el asiento contable.
            Dim Index As Integer = 0
            ' cuenta por pagar.
            Index = Dg1.Rows.Add()
            Dg1.Rows(Index).Cells(0).Value = stCuentaCxp
            Dg1.Rows(Index).Cells(1).Value = 1 'CType(cmbCentroCosto.Text.Split("-").GetValue(0), String).Trim
            Dg1.Rows(Index).Cells(2).Value = 1 'CType(cmbSubCentro.Text.Split("-").GetValue(0), String).Trim
            Dg1.Rows(Index).Cells(3).Value = buscarCatalago(stCuentaCxp).nombre_cuenta.ToUpper
            Dg1.Rows(Index).Cells(4).Value = txtDescripcion.Text
            If cmbTipoFactura.Text.Substring(0, 3) = "008" Then  'notas de credito
                Dg1.Rows(Index).Cells(5).Value = _TotalPorPagar.ToString("N2")
                Dg1.Rows(Index).Cells(6).Value = "0.00"
            Else
                Dg1.Rows(Index).Cells(5).Value = "0.00"
                Dg1.Rows(Index).Cells(6).Value = _TotalPorPagar.ToString("N2")
            End If

            ' retenciones de ISR .. si hay 
            If CType(txtImpuesto_isr.Text, Double) <> 0.0 Then
                Index = Dg1.Rows.Add()
                Dg1.Rows(Index).Cells(0).Value = stCuentaIsr
                Dg1.Rows(Index).Cells(1).Value = 1 'CType(cmbCentroCosto.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(2).Value = 1 'CType(cmbSubCentro.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(3).Value = buscarCatalago(stCuentaIsr).nombre_cuenta.ToUpper
                Dg1.Rows(Index).Cells(4).Value = txtDescripcion.Text
                Dg1.Rows(Index).Cells(5).Value = "0.00"
                Dg1.Rows(Index).Cells(6).Value = txtImpuesto_isr.Text
            End If
            If CType(txtImpuesto_retiva.Text, Double) <> 0.0 Then
                Index = Dg1.Rows.Add()
                Dg1.Rows(Index).Cells(0).Value = stCuentaRetiva
                Dg1.Rows(Index).Cells(1).Value = 1 'CType(cmbCentroCosto.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(2).Value = 1 'CType(cmbSubCentro.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(3).Value = buscarCatalago(stCuentaRetiva).nombre_cuenta.ToUpper
                Dg1.Rows(Index).Cells(4).Value = txtDescripcion.Text
                Dg1.Rows(Index).Cells(5).Value = "0.00"
                Dg1.Rows(Index).Cells(6).Value = txtImpuesto_retiva.Text
            End If
            If CType(txtTimbres.Text, Double) <> 0.0 Then
                Index = Dg1.Rows.Add()
                Dg1.Rows(Index).Cells(0).Value = stCuentaTimbres
                Dg1.Rows(Index).Cells(1).Value = 1 'CType(cmbCentroCosto.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(2).Value = 1 'CType(cmbSubCentro.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(3).Value = buscarCatalago(stCuentaTimbres).nombre_cuenta.ToUpper
                Dg1.Rows(Index).Cells(4).Value = txtDescripcion.Text
                Dg1.Rows(Index).Cells(5).Value = "0.00"
                Dg1.Rows(Index).Cells(6).Value = txtTimbres.Text
            End If
            If CType(txtImpuesto_iva.Text, Double) <> 0.0 Then
                Index = Dg1.Rows.Add()
                Dg1.Rows(Index).Cells(0).Value = stCuentaIva
                Dg1.Rows(Index).Cells(1).Value = 1 'CType(cmbCentroCosto.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(2).Value = 1 'CType(cmbSubCentro.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(3).Value = buscarCatalago(stCuentaIva).nombre_cuenta.ToUpper
                Dg1.Rows(Index).Cells(4).Value = stConcepto
                If cmbTipoFactura.Text.Substring(0, 3) = "008" Then  'notas de credito
                    Dg1.Rows(Index).Cells(5).Value = "0.00"
                    Dg1.Rows(Index).Cells(6).Value = txtImpuesto_iva.Text
                Else
                    Dg1.Rows(Index).Cells(5).Value = txtImpuesto_iva.Text
                    Dg1.Rows(Index).Cells(6).Value = "0.00"
                End If
            End If
            If CType(txtImpuesto_idp.Text, Double) <> 0.0 Then
                Index = Dg1.Rows.Add()
                Dg1.Rows(Index).Cells(0).Value = stCuentaIdp
                Dg1.Rows(Index).Cells(1).Value = 1 'CType(cmbCentroCosto.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(2).Value = 1 'CType(cmbSubCentro.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(3).Value = buscarCatalago(stCuentaIdp).nombre_cuenta.ToUpper
                Dg1.Rows(Index).Cells(4).Value = txtDescripcion.Text
                Dg1.Rows(Index).Cells(5).Value = txtImpuesto_idp.Text
                Dg1.Rows(Index).Cells(6).Value = "0.00"
            End If
            If CType(txtTasaMunicipal.Text, Double) <> 0.0 Then
                Index = Dg1.Rows.Add()
                Dg1.Rows(Index).Cells(0).Value = stCuentaIdp
                Dg1.Rows(Index).Cells(1).Value = 1 'CType(cmbCentroCosto.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(2).Value = 1 'CType(cmbSubCentro.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(Index).Cells(3).Value = buscarCatalago(stCuentaTasaMunicipal).nombre_cuenta.ToUpper
                Dg1.Rows(Index).Cells(4).Value = txtDescripcion.Text
                Dg1.Rows(Index).Cells(5).Value = txtTasaMunicipal.Text
                Dg1.Rows(Index).Cells(6).Value = "0.00"
            End If
            CalculaValores()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' el concepto para trasladar todo.
    Private Sub Dg1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Dg1.CellBeginEdit
        Try
            If txtDescripcion.Text = "" Then
                MsgBox("Tiene que ingresar una descripcion antes de continuar...", MsgBoxStyle.Critical)
                e.Cancel = True
            End If
            'If e.ColumnIndex = 5 Then
            '    If IsNumeric(Dg1.Rows(e.RowIndex).Cells("colHaber").Value) Then
            '        If CType(Dg1.Rows(e.RowIndex).Cells("colHaber").Value, Double) <> 0.0 Then
            '            e.Cancel = True
            '        End If
            '    End If
            '    If Dg1.Rows(e.RowIndex).Cells("colSubCentro").Value = "" Then
            '        e.Cancel = True
            '    End If
            'End If
            'If e.ColumnIndex = 6 Then
            '    If IsNumeric(Dg1.Rows(e.RowIndex).Cells("colDebe").Value) Then
            '        If CType(Dg1.Rows(e.RowIndex).Cells("colDebe").Value, Double) <> 0.0 Then
            '            e.Cancel = True
            '        End If
            '    End If
            '    If Dg1.Rows(e.RowIndex).Cells("colSubCentro").Value = "" Then
            '        e.Cancel = True
            '    End If
            'End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Dg1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dg1.CellEndEdit
        Try
            ' para buscar en el catalogo....
            If e.ColumnIndex = 0 Then   ' cuando sea cuenta catalogo...
                Dim valCelda As String = Dg1.Rows(e.RowIndex).Cells("colCuenta").Value
                If valCelda = "" Then
                    Exit Sub
                End If

                Dim FilaCatalogo As Datos.cn_catalogoRow = buscarCatalago(valCelda)
                If FilaCatalogo Is Nothing Then
                    MsgBox("NO EXISTE EL CODIGO EN EL CATALOGO....", MsgBoxStyle.Critical)
                    Dg1.Rows(e.RowIndex).Cells("colCuenta").Value = ""
                    Exit Sub
                End If

                Dg1.Rows(e.RowIndex).Cells("colNombreCuenta").Value = FilaCatalogo.nombre_cuenta.ToUpper
                Dg1.Rows(e.RowIndex).Cells("colDescripcion").Value = txtDescripcion.Text
                Dg1.Rows(e.RowIndex).Cells("colCentro").Value = 1 'CType(cmbCentroCosto.Text.Split("-").GetValue(0), String).Trim
                Dg1.Rows(e.RowIndex).Cells("colSubCentro").Value = 1 'CType(cmbSubCentro.Text.Split("-").GetValue(0), String).Trim
            End If
            If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Then
                CalculaValores()
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Dg1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles Dg1.RowsRemoved
        CalculaValores()
    End Sub

    Private Sub CalculaValores()
        Try
            Dim valSumaDebe As Double = 0.0
            Dim valSumaHaber As Double = 0.0
            For Each Fila As DataGridViewRow In Dg1.Rows
                If IsNumeric(Fila.Cells("colDebe").Value) Then
                    valSumaDebe += Fila.Cells("colDebe").Value
                End If
                If IsNumeric(Fila.Cells("colHaber").Value) Then
                    valSumaHaber += Fila.Cells("colHaber").Value
                End If
            Next
            txtDebe.Text = valSumaDebe.ToString("N2")
            txtHaber.Text = valSumaHaber.ToString("N2")
            txtPorAplicar.Text = CType((valSumaDebe - valSumaHaber), Double).ToString("N2")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FCnAsientosContablesIngreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F2 Then
                Dim F As New FCnBusquedaCatalogo
                F.FilaDataGrid = Dg1.CurrentRow
                F.ShowDialog()
            End If
            If e.KeyCode = Keys.F3 Then
                Dim _Texto As String = Me.dtpFecha.Value.ToString("d")
                Dim _Input As String = InputBox("Ingrese la fecha del documento", "Cambiar Fecha", _Texto)

                If _Input <> "" Then
                    dtpFecha.Value = CDate(_Input)
                End If
            End If
            If e.KeyCode = Keys.F5 Then  ' buscamos por centro de costos.
                Dim F As New FCnBusquedaCentroCosto
                F.FilaGrid = Dg1.CurrentRow
                F.TipoBusqueda = "C"
                F.ShowDialog()
            End If
            If e.KeyCode = Keys.F6 Then  ' buscamos por centro de costos.
                Dim F As New FCnBusquedaCentroCosto
                F.FilaGrid = Dg1.CurrentRow
                F.TipoBusqueda = "S"
                F.ShowDialog()
            End If
            If e.KeyCode = Keys.F8 Then
                Dim F As New FBusquedaProveedorCxp
                F.objProveedor = New Proveedor
                F.objRegresaCodigo = txtCodigoProveedor
                F.objRegresaNit = txtNit
                F.objRegresaNombre = txtNombreProveedor
                F.ShowDialog()
            End If
            If e.KeyCode = Keys.F10 Then
                Dim F As New FCXPProveedorIngreso
                F.ObjProveedor = New Proveedor
                F.TipoForma = "A"
                F.ShowDialog()
            End If
            If e.KeyCode = Keys.F9 Then
                btnAplicar_Click(sender, New EventArgs)
            End If
        Catch ex As Exception
        End Try
    End Sub
    '  termina.

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Try
            If Dg1.Rows.Count = 0 Then
                MsgBox("Tiene que ingresar por lo menos un detalle de asientos contables...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If CType(txtPorAplicar.Text, Double) <> 0.0 Then
                MsgBox("El Asiento Contable no ha sido cuadrado aun....", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If MsgBox("Esta Seguro de Guardar este Asiento Contable?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
                Exit Sub
            End If
            Dg1.Enabled = True

            Dim varProceso As Integer = Sesion.getProcesoID()
            Dim varLinea As Integer = 1
            Dim varDebe As Double = 0.0, varHaber As Double = 0.0
            Dim ObjPartida As New Cn_Partida_Contable_Enc

            ObjPartida.BorrarTemporal(varProceso)
            For I As Integer = 0 To Dg1.Rows.Count - 2

                varDebe = IIf(Dg1.Rows(I).Cells("colDebe").Value = "", 0.0, Dg1.Rows(I).Cells("colDebe").Value)
                varHaber = IIf(Dg1.Rows(I).Cells("colHaber").Value = "", 0.0, Dg1.Rows(I).Cells("colHaber").Value)

                ObjPartida.AgregarLineaTemporal(varProceso, varLinea, Dg1.Rows(I).Cells("colCuenta").Value, _
                                Dg1.Rows(I).Cells("colCentro").Value, Dg1.Rows(I).Cells("colSubCentro").Value,
                                Dg1.Rows(I).Cells("colDescripcion").Value, varDebe, varHaber)
                varLinea += 1
            Next
            ' ahora guardamos el asiento contable como tal ....
            Dim varAsiento As Integer = ObjPartida.crearDebitoCompras(GEmpresa, varProceso, GPeriodoContable.periodo_fiscal,
                                                                      GPeriodoContable.periodo_corr, txtCodigoProveedor.Text, txtNit.Text, CType(cmbTipoFactura.Text.Split("-").GetValue(0), String).Trim, txtSerie.Text,
                                                                      txtDocumento.Text, dtpFecha.Value, txtDescripcion.Text, txtTotalFactura.Text, CType(cmbTipoLibro.Text.Split("-").GetValue(0), String).Trim,
                                                                      txtImpuesto_iva.Text, txtImpuesto_idp.Text, txtImpuesto_isr.Text, txtImpuesto_retiva.Text, txtTimbres.Text, GUsuario, parDocRecepcion, 0, txtTasaMunicipal.Text, Now(), 1)

            MsgBox(String.Format("Asiento Contable Asignado #{0}", varAsiento), MsgBoxStyle.Information)

            If parNit <> "" Then
                Me.Dispose()
            Else
                ' limpiamos la pantalla para proceder con lo otro.
                LimpiarPantalla()
                txtNit.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LimpiarPantalla()
        Try
            txtNit.Text = ""
            txtCodigoProveedor.Text = ""
            txtNombreProveedor.Text = ""
            txtInformacion.Text = ""
            txtSerie.Text = ""
            txtDocumento.Text = ""
            txtDescripcion.Text = ""
            txtTotalFactura.Text = "0.00"
            txtImpuesto_iva.Text = "0.00"
            txtImpuesto_isr.Text = "0.00"
            txtImpuesto_idp.Text = "0.00"
            txtImpuesto_retiva.Text = "0.00"

            Dg1.Rows.Clear()

            Dg1.Enabled = True
            txtTotalFactura.Enabled = True
            btnCalculoCombustible.Enabled = True

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub cmbTipoLibro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoLibro.SelectedIndexChanged
        Try
            txtTotalFactura_TextChanged(sender, e)
            CalculaOtrosImpuestos()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmbTipoFactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoFactura.SelectedIndexChanged
        Try
            CalculoIva(txtTotalFactura.Text)
            CalculaOtrosImpuestos()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTasaMunicipal_TextChanged(sender As Object, e As EventArgs) Handles txtTasaMunicipal.TextChanged
        Try
            CalculoIva(CType(txtTotalFactura.Text, Decimal) - CType(txtTasaMunicipal.Text, Decimal))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Control_Focus(sender As Object, e As EventArgs) Handles txtSerie.Enter, txtDocumento.Enter, txtDescripcion.Enter,
                                                                        txtTotalFactura.Enter
        Try
            CType(sender, TextBox).BackColor = Color.LightYellow
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Control_Leave(sender As Object, e As EventArgs) Handles txtSerie.Leave, txtDocumento.Leave, txtDescripcion.Leave,
                                                                         txtTotalFactura.Leave
        Try
            CType(sender, TextBox).BackColor = Color.White
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Control_Keydown(sender As Object, e As KeyEventArgs) Handles txtSerie.KeyDown, txtDocumento.KeyDown, txtDescripcion.KeyDown,
                                                                     txtTotalFactura.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Dim _Texto As TextBox = CType(sender, TextBox)
                Dim _Input As String = InputBox("Editar Información", "Editar", _Texto.Text)

                If _Input <> "" Then
                    _Texto.Text = _Input
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTipoLibro_TextChanged(sender As Object, e As EventArgs)
        Try
            If txtTipoLibro.Text = "SERVICIO" Or txtTipoLibro.Text = "BIEN" Or txtTipoLibro.Text = "COMBUSTIBLE" Then
                If txtTipoLibro.Text = "BIEN" Then
                    cmbTipoLibro.SelectedIndex = 0
                End If
                If txtTipoLibro.Text = "SERVICIO" Then
                    cmbTipoLibro.SelectedIndex = 1
                End If
                If txtTipoLibro.Text = "COMBUSTIBLE" Then
                    cmbTipoLibro.SelectedIndex = 2
                End If
            Else
                txtTipoLibro.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTipoLibro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTipoLibro.SelectedIndexChanged
        Try
            If txtTipoLibro.Text = "SERVICIO" Or txtTipoLibro.Text = "BIEN" Or txtTipoLibro.Text = "COMBUSTIBLE" Then
                If txtTipoLibro.Text = "BIEN" Then
                    cmbTipoLibro.SelectedIndex = 0
                End If
                If txtTipoLibro.Text = "SERVICIO" Then
                    cmbTipoLibro.SelectedIndex = 1
                End If
                If txtTipoLibro.Text = "COMBUSTIBLE" Then
                    cmbTipoLibro.SelectedIndex = 2
                End If
            Else
                txtTipoLibro.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtPruebaENTER_KeyPress(ByVal sender As Object, _
                           ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                       Handles txtBien.KeyPress, txtCodigoProveedor.KeyPress, txtDebe.KeyPress, txtDescripcion.KeyPress, txtDocumento.KeyPress, txtHaber.KeyPress, txtImpuesto_idp.KeyPress _
                       , txtImpuesto_isr.KeyPress, txtImpuesto_iva.KeyPress, txtImpuesto_retiva.KeyPress, txtInformacion.KeyPress, txtNit.KeyPress, txtNombreProveedor.KeyPress, txtPorAplicar.KeyPress, _
                       txtSerie.KeyPress, txtServicio.KeyPress, txtTasaMunicipal.KeyPress, txtTimbres.KeyPress, txtTipoLibro.KeyPress, txtTotalFactura.KeyPress, cmbTipoFactura.KeyPress, cmbTipoLibro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class