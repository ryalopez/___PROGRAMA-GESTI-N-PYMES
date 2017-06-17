Imports System.Windows.Forms
Imports Biblioteca

Public Class frmAsientos

    Private Esquina As New Point(21, 103)

    Public Event CambioNúmeros()
    Public Event CambioTipoAsiento(tipoAsiento As eTiposAsiento)
    Public Event PreparaAsientoDisposición(ByRef sender As frmAsientos)

    Private m_tipoAsiento As eTiposAsiento

    Private m_ClaveHash As String

    Private m_númeroAsiento As Integer
    Private m_fechaAsiento As Date
    Private m_Operación As String
    Private m_Justificante As String
    Private m_CuentaProveedor As Integer
    Private m_NombreProveedor As String
    Private m_CuentaGasto As Integer
    Private m_NombreGasto As String
    Private m_CIF As String

    Private m_IVA As Double
    Private m_CuotaIVA As Double
    Private m_BaseIVA As Double
    Private m_CuentaIVA As Integer

    Private m_CuentaBanco As Integer

    Private m_ImporteTotal As Double


    Private Sub frmAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.FacturasRecibidas' Puede moverla o quitarla según sea necesario.
        Me.FacturasRecibidasTableAdapter.Fill(Me.BDContabilidadGMELO.FacturasRecibidas)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Cargos' Puede moverla o quitarla según sea necesario.
        Me.CargosTableAdapter.Fill(Me.BDContabilidadGMELO.Cargos)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Abonos' Puede moverla o quitarla según sea necesario.
        Me.AbonosTableAdapter.Fill(Me.BDContabilidadGMELO.Abonos)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasBancarias' Puede moverla o quitarla según sea necesario.
        Me.CuentasBancariasTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasBancarias)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasProveedores' Puede moverla o quitarla según sea necesario.
        Me.CuentasProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasProveedores)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasGasto' Puede moverla o quitarla según sea necesario.
        Me.CuentasGastoTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasGasto)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Asientos' Puede moverla o quitarla según sea necesario.
        Me.AsientosTableAdapter.Fill(Me.BDContabilidadGMELO.Asientos)
        '
        ' Agregar asiento
        '
        m_númeroAsiento = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
        Me.NúmeroTextBox.Text = Me.NúmeroAsiento.ToString
        Me.FechaDateTimePicker.Value = Today
        Me.m_fechaAsiento = Me.FechaDateTimePicker.Value

    End Sub


    Public Property TipoAsiento As eTiposAsiento
        Get
            Return Me.m_tipoAsiento
        End Get
        Set(value As eTiposAsiento)
            Me.m_tipoAsiento = value
            RaiseEvent CambioTipoAsiento(m_tipoAsiento)
        End Set
    End Property

    Public ReadOnly Property NúmeroAsiento As Integer
        Get
            Return Me.m_númeroAsiento
        End Get
    End Property

    Public ReadOnly Property FechaAsiento As Date
        Get
            Return Me.m_fechaAsiento
        End Get
    End Property

    Public ReadOnly Property Operación As String
        Get
            Return Me.m_Operación
        End Get
    End Property

    Public ReadOnly Property Justificante As String
        Get
            Return Me.m_Justificante
        End Get
    End Property

    Public ReadOnly Property IVA As Double
        Get
            Return Me.m_IVA
        End Get
    End Property

    Public ReadOnly Property CuotaIVA As Double
        Get
            Return Me.m_CuotaIVA
        End Get
    End Property

    Public ReadOnly Property BaseIVA As Double
        Get
            Return Me.m_BaseIVA
        End Get
    End Property

    Public ReadOnly Property CuentaIVASoportado As Integer
        Get
            Return Me.m_CuentaIVA
        End Get
    End Property

    Public ReadOnly Property CuentaGasto As Integer
        Get
            Return Me.m_CuentaGasto
        End Get
    End Property

    Public ReadOnly Property CuentaBanco As Integer
        Get
            Return Me.m_CuentaBanco
        End Get
    End Property

    Public ReadOnly Property CuentaProveedor As Integer
        Get
            Return Me.m_CuentaProveedor
        End Get
    End Property

    Public ReadOnly Property NombreProveedor As String
        Get
            Return Me.m_NombreProveedor
        End Get
    End Property
    Public ReadOnly Property NombreGasto As String
        Get
            Return Me.m_NombreGasto
        End Get
    End Property
    Public ReadOnly Property CIF As String
        Get
            Return Me.m_CIF
        End Get
    End Property
    Public ReadOnly Property ImporteTotal As Double
        Get
            Return Me.m_ImporteTotal
        End Get
    End Property
    Public ReadOnly Property ClaveHash As String
        Get
            Return Me.m_ClaveHash
        End Get
    End Property


    Private Sub ProveedoresComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProveedoresComboBox.SelectedIndexChanged

        If ProveedoresComboBox.SelectedIndex > -1 Then

            Dim p As Integer = Me.ProveedoresBindingSource.Find("DocumentoIdentidad", ProveedoresComboBox.SelectedValue)
            If p > -1 Then

                Me.ProveedoresBindingSource.Position = p
                Me.m_NombreProveedor = CStr(CType(Me.ProveedoresBindingSource.Current, DataRowView).Item("Nombre"))
                Me.m_CuentaProveedor = CInt(CType(Me.ProveedoresBindingSource.Current, DataRowView).Item("Cuenta4"))
                Me.m_CuentaGasto = CInt(CType(Me.ProveedoresBindingSource.Current, DataRowView).Item("Cuenta6"))
                Me.m_CIF = CStr(CType(Me.ProveedoresBindingSource.Current, DataRowView).Item("DocumentoIdentidad"))
                Dim q As Integer = Me.CuentasGastoBindingSource.Find("Código", Me.CuentaGasto)

                If q > -1 Then

                    Me.CuentasGastoBindingSource.Position = q

                    Me.m_CuentaGasto = CInt(CType(Me.CuentasGastoBindingSource.Current, DataRowView).Item("Código"))
                    Me.m_NombreGasto = CStr(CType(Me.CuentasGastoBindingSource.Current, DataRowView).Item("Nombre"))
                    Me.CuentasGastoComboBox.SelectedValue = Me.CuentaGasto

                Else

                    Me.m_CuentaGasto = 0
                    Me.m_NombreGasto = ""

                End If

            Else

                Me.m_NombreProveedor = ""
                Me.m_CuentaProveedor = 0
                Me.m_NombreGasto = ""
                Me.m_CuentaGasto = 0

            End If

            If Me.TipoAsiento = eTiposAsiento.COMPRA Then

                Me.m_Operación = Me.NombreGasto + " / " + Me.NombreProveedor

            End If

            Me.OperaciónTextBox.Text = Me.Operación


        End If

    End Sub

    Private Sub rbComprasRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbComprasRadioButton.CheckedChanged
        If rbComprasRadioButton.Checked Then

            Me.m_tipoAsiento = eTiposAsiento.COMPRA
            Me.DatosCompraGroupBox.Location = Esquina
            Me.DatosCompraGroupBox.Visible = True
            Me.TipoDisposiciónGroupBox.Visible = False

        End If

    End Sub
    Private Sub rbReintegro_CheckedChanged(sender As Object, e As EventArgs) Handles rbReintegroRadioButton.CheckedChanged

        If rbReintegroRadioButton.Checked Then

            Me.m_tipoAsiento = eTiposAsiento.REINTEGRO_EFECTIVO
            Me.DatosCompraGroupBox.Visible = False
            Me.TipoDisposiciónGroupBox.Location = Esquina
            Me.TipoDisposiciónGroupBox.Visible = True

        End If

    End Sub

    Private Sub rbVentasRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentasRadioButton.CheckedChanged
        If rbVentasRadioButton.Checked Then

            Me.m_tipoAsiento = eTiposAsiento.VENTA
            Me.DatosCompraGroupBox.Visible = False
            Me.TipoDisposiciónGroupBox.Visible = False
            CMódulo.MsgInformativo("No está disponible ésta entrada de asientos.")
            Me.rbVentanillaRadioButton.Checked = False
        End If

    End Sub

    Private Sub rbIVANo_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVANo.CheckedChanged

        If rbIVANo.Checked Then

            Me.m_IVA = 0
            Me.m_CuentaIVA = 0
            Me.TipoIVATextBox.Text = 0.ToString
            'forzar recálculo
            RaiseEvent CambioNúmeros()

        End If
    End Sub

    Private Sub rbIVANormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVANormal.CheckedChanged

        If rbIVANormal.Checked Then

            Me.m_IVA = 21
            Me.m_CuentaIVA = 472021
            Me.TipoIVATextBox.Text = 21.ToString
            'forzar recálculo
            RaiseEvent CambioNúmeros()

        End If
    End Sub

    Private Sub rbIVAReducido_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVAReducido.CheckedChanged

        If rbIVAReducido.Checked Then

            Me.m_IVA = 10
            Me.m_CuentaIVA = 472010
            Me.TipoIVATextBox.Text = 10.ToString
            'forzar recálculo
            RaiseEvent CambioNúmeros()

        End If
    End Sub

    Private Sub rbIVASuperReducido_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVASuperReducido.CheckedChanged

        If rbIVASuperReducido.Checked Then

            Me.m_IVA = 4
            Me.m_CuentaIVA = 472004
            Me.TipoIVATextBox.Text = 4.ToString
            'forzar recálculo
            RaiseEvent CambioNúmeros()

        End If
    End Sub

    Private Sub rbPagoCaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbPagoCaja.CheckedChanged

        If rbPagoCaja.Checked Then

            Me.m_CuentaBanco = 570
            Me.BancosComboBox.Visible = False
        End If
    End Sub

    Private Sub rbPagoBanco_CheckedChanged(sender As Object, e As EventArgs) Handles rbPagoBanco.CheckedChanged
        If rbPagoBanco.Checked Then

            Me.BancosComboBox.Visible = True

        End If
    End Sub

    Private Sub BancosComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BancosComboBox.SelectedIndexChanged

        With Me.BancosComboBox


            If .SelectedIndex > -1 Then

                Select Case .SelectedIndex
                    Case 0

                        Me.m_CuentaBanco = 572001

                    Case 1

                        Me.m_CuentaBanco = 572002

                    Case Else

                        Throw New Exception("La cuenta Bancaria de Pago no existe.")

                End Select

            End If
        End With
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        ' Validar asiento
        '
        If Not frmAsientos.Válido(Me) Then

            Exit Sub

        Else

            GenerarAsiento()

            If Me.TipoAsiento = eTiposAsiento.COMPRA Then

                GenerarFactura()

            End If


        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Shared Function Válido(asto As frmAsientos) As Boolean

        Dim msg As String = ""
        Select Case asto.TipoAsiento
            Case eTiposAsiento.REINTEGRO_EFECTIVO

                If Len(Trim(asto.Operación)) = 0 Then

                    msg += "El campo Operación no puede quedar en blanco. "

                End If
                If asto.CuentaBanco = 0 Then

                    msg += "La cuenta bancaria no puede ser 0. "

                End If
                If asto.ImporteTotal = 0 Then

                    msg += "El importe total no puede ser 0. "

                End If
                If Len(Trim(msg)) <> 0 Then

                    CMódulo.MsgErrorCrítico(msg)
                    Válido = False
                    Exit Function

                End If

            Case eTiposAsiento.COMPRA
                If Len(Trim(asto.Operación)) = 0 Then

                    msg += "El campo Operación no puede quedar en blanco. "

                End If
                If asto.CuentaBanco = 0 Then

                    msg += "La cuenta bancaria no puede ser 0. "

                End If
                If asto.IVA <> 0 And asto.CuentaIVASoportado = 0 Then

                    msg += "El IVA soportado no puede ser 0. "

                End If
                If asto.ImporteTotal = 0 Then

                    msg += "El importe total no puede ser 0. "

                End If
                If Len(Trim(msg)) <> 0 Then

                    CMódulo.MsgErrorCrítico(msg)
                    Válido = False
                    Exit Function

                End If
            Case Else

                Válido = False

        End Select

        Válido = True

    End Function

    Private Sub CuentasGastoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuentasGastoComboBox.SelectedIndexChanged

        If CuentasGastoComboBox.SelectedIndex > -1 Then

            Me.m_CuentaGasto = CInt(CuentasGastoComboBox.SelectedValue)

        End If
    End Sub

    Private Sub GenerarAsiento()

        Me.m_ClaveHash = CMódulo.Clave(Me.FechaAsiento.ToString + Me.Operación + Me.Justificante)
        Me.AsientosTableAdapter.Insert(Me.NúmeroAsiento, Me.FechaAsiento, Me.Justificante, Me.Operación, Me.ClaveHash)

        Select Case Me.TipoAsiento

            Case eTiposAsiento.REINTEGRO_EFECTIVO
                '
                ' Agregar cargos
                '
                Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, Me.NúmeroAsiento, "C")
                Me.CargosTableAdapter.Insert(NúmeroAsiento, Me.CuentaGasto, NúmeroApunte, Me.BaseIVA)

                '
                ' Agregar abonos
                '
                NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, Me.NúmeroAsiento, "A")
                Me.AbonosTableAdapter.Insert(NúmeroAsiento, Me.CuentaBanco, NúmeroApunte, Me.ImporteTotal)

            Case eTiposAsiento.COMPRA
                '
                ' Agregar cargos
                '
                Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, Me.NúmeroAsiento, "C")
                Me.CargosTableAdapter.Insert(NúmeroAsiento, Me.CuentaGasto, NúmeroApunte, Me.BaseIVA)
                If Me.IVA <> 0 Then
                    NúmeroApunte += 1
                    Me.CargosTableAdapter.Insert(NúmeroAsiento, Me.CuentaIVASoportado, NúmeroApunte, Me.CuotaIVA)
                End If
                NúmeroApunte += 1
                Me.CargosTableAdapter.Insert(NúmeroAsiento, Me.CuentaProveedor, NúmeroApunte, Me.ImporteTotal)

                '
                ' Agregar abonos
                '
                NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, Me.NúmeroAsiento, "A")
                Me.AbonosTableAdapter.Insert(NúmeroAsiento, Me.CuentaProveedor, NúmeroApunte, Me.ImporteTotal)
                NúmeroApunte += 1
                Me.AbonosTableAdapter.Insert(NúmeroAsiento, Me.CuentaBanco, NúmeroApunte, Me.ImporteTotal)
            Case Else

                Exit Sub

        End Select
    End Sub

    Private Sub FechaDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaDateTimePicker.ValueChanged

        Me.m_fechaAsiento = Me.FechaDateTimePicker.Value

    End Sub

    Private Sub JustificanteTextBox_TextChanged(sender As Object, e As EventArgs) Handles JustificanteTextBox.TextChanged

        Me.m_Justificante = Me.JustificanteTextBox.Text

    End Sub

    Private Sub TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalTextBox.TextChanged

    RaiseEvent CambioNúmeros()

    End Sub

    Private Sub TotalDispuestoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalDispuestoTextBox.TextChanged

        RaiseEvent CambioNúmeros()
        RaiseEvent PreparaAsientoDisposición(Me)

    End Sub

    Private Sub Realiza_Los_Cálculos() Handles Me.CambioNúmeros

        Select Case Me.TipoAsiento
            Case eTiposAsiento.REINTEGRO_EFECTIVO

                If Len(Trim(Me.TotalDispuestoTextBox.Text)) <> 0 Then

                    Me.m_ImporteTotal = CDbl(Me.TotalDispuestoTextBox.Text)
                    Me.m_IVA = 0
                    Me.m_BaseIVA = Me.ImporteTotal
                    Me.m_CuotaIVA = 0

                End If

            Case eTiposAsiento.COMPRA

                If Len(Trim(Me.TotalTextBox.Text)) <> 0 Then

                    Me.m_ImporteTotal = CDbl(Me.TotalTextBox.Text)
                    Dim R As Double = 1 + Me.IVA / 100
                    Me.m_BaseIVA = Math.Round((Me.ImporteTotal / R), 2)
                    Me.m_CuotaIVA = Me.ImporteTotal - Me.m_BaseIVA

                    Me.BaseIVATextBox.Text = Me.BaseIVA.ToString
                    Me.CuotaIVATextBox.Text = Me.CuotaIVA.ToString

                End If
        End Select

    End Sub

    Private Sub GenerarFactura()


        If Me.TipoAsiento = eTiposAsiento.COMPRA Then
            Me.FacturasRecibidasTableAdapter.Insert(Me.Justificante, Me.FechaAsiento, Nothing, Me.CIF, Me.NombreProveedor, Me.ClaveHash, Me.BaseIVA, Me.IVA, Me.CuotaIVA, Me.ImporteTotal)
        Else
        End If
    End Sub

    Private Sub BancosDispComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BancosDispComboBox.SelectedIndexChanged

        With Me.BancosDispComboBox


            If .SelectedIndex > -1 Then

                Select Case .SelectedIndex
                    Case 0

                        Me.m_CuentaBanco = 572001

                    Case 1

                        Me.m_CuentaBanco = 572002

                    Case Else

                        Throw New Exception("La cuenta Bancaria de Pago no existe.")

                End Select

            End If
        End With
    End Sub

    Private Sub Prepara_Asiento_Disposición(ByRef sender As frmAsientos) Handles Me.PreparaAsientoDisposición

        sender.m_CuentaGasto = 551001
        ' sender.m_CuentaBanco = 5720001
        If sender.rbVentanillaRadioButton.Checked = True Then
            sender.m_Operación = "DISPOSICION EFECTIVO EN OFICINA " + Trim(sender.NúmeroOficinaTextBox.Text)
            sender.m_Justificante = Trim(sender.NúmeroOficinaTextBox.Text)
        ElseIf sender.rbCajeroRadioButton.Checked = True Then
            sender.m_Operación = "DISPOSICION EFECTIVO EN CAJERO " + Trim(sender.NúmeroOficinaTextBox.Text)
            sender.m_Justificante = Trim(sender.NúmeroOficinaTextBox.Text)
        ElseIf sender.rbChequeRadioButton.Checked = True Then
            sender.m_Operación = "ABONO DE CHEQUE " + Trim(sender.NúmeroOficinaTextBox.Text)
            sender.m_Justificante = Trim(sender.NúmeroOficinaTextBox.Text)
        Else
            CMódulo.MsgErrorCrítico("ERROR AL GENERAR ASIENTO DE REINTEGRO. ASIENTO NO GENERADO")

            Exit Sub

        End If

    End Sub
End Class
