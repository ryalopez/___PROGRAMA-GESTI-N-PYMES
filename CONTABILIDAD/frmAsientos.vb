Imports System.Windows.Forms
Imports Biblioteca

Public Class frmAsientos

    Private Esquina As New Point(21, 103)

    Public Event CálculosCompra()
    Public Event CálculosReintegro()
    Public Event CálculosTelepeaje()
    Public Event CálculosCapitalDevuelto()
    Public Event CálculosInterés()
    Public Event CálculosInterésMora()
    Public Event CuentasPréstamo(PréstamoLargo As Integer, NombrePréstamo As String)
    Public Event CambioTipoAsiento(tipoAsiento As eTiposAsiento)

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

    Private m_NúmeroTarjeta As String
    Private m_CuotaTarjeta As Double
    Private m_CuentaBanco As Integer

    Private m_CapitalDevuelto As Double
    Private m_Interés As Double
    Private m_InteresMora As Double
    Private m_CtaPréstamoLargo As Integer
    Private m_CtaPréstamo As Integer
    Private m_CtaIntereses As Integer

    Private m_ImporteTotal As Double
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.m_ClaveHash = ""

        Me.m_númeroAsiento = 0
        Me.FechaDateTimePicker.Value = Today
        Me.m_fechaAsiento = Me.FechaDateTimePicker.Value
        Me.m_Operación = ""
        Me.m_Justificante = ""
        Me.m_CuentaProveedor = 0
        Me.m_NombreProveedor = ""
        Me.m_CuentaGasto = 0
        Me.m_NombreGasto = ""
        Me.m_CIF = ""

        Me.m_IVA = 0
        Me.m_CuotaIVA = 0
        Me.m_BaseIVA = 0
        Me.m_CuentaIVA = 0

        Me.m_CuentaBanco = 0
        Me.m_NúmeroTarjeta = ""
        Me.m_CuotaTarjeta = 0
        Me.m_ImporteTotal = 0



    End Sub

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
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.PréstamosLargoPlazo' Puede moverla o quitarla según sea necesario.
        Me.PréstamosLargoPlazoTableAdapter.Fill(Me.BDContabilidadGMELO.PréstamosLargoPlazo)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Préstamos' Puede moverla o quitarla según sea necesario.
        Me.PréstamosTableAdapter.Fill(Me.BDContabilidadGMELO.Préstamos)

        m_númeroAsiento = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
        Me.NúmeroTextBox.Text = Me.NúmeroAsiento.ToString

        Me.Text = My.Resources.Título + " - Entrada de asientos"
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
    Public ReadOnly Property NúmeroTarjeta As String
        Get
            Return Me.m_NúmeroTarjeta
        End Get
    End Property
    Public ReadOnly Property CuotaTarjeta As Double
        Get
            Return Me.m_CuotaTarjeta
        End Get
    End Property

    Public ReadOnly Property ImporteTotal As Double
        Get
            Return Me.m_ImporteTotal
        End Get
    End Property
    Public ReadOnly Property CapitalDevuelo As Double
        Get
            Return Me.m_CapitalDevuelto
        End Get
    End Property
    Public ReadOnly Property Interés As Double
        Get
            Return Me.m_Interés
        End Get
    End Property
    Public ReadOnly Property InterésMora As Double
        Get
            Return Me.m_InteresMora
        End Get
    End Property
    Public ReadOnly Property CtaPréstamo As Integer
        Get
            Return Me.m_CtaPréstamo
        End Get
    End Property
    Public ReadOnly Property CtaPréstamoLargo As Integer
        Get
            Return Me.m_CtaPréstamoLargo
        End Get
    End Property
    Public ReadOnly Property CuentaIntereses As Integer
        Get
            Return Me.m_CtaIntereses
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
            Me.AdeudoTelepeajeGroupBox.Visible = False
            Me.CuotaTarjetaGroupBox.Visible = False
            Me.DevolPrestamoGroupBox.Visible = False
        End If

    End Sub
    Private Sub rbReintegro_CheckedChanged(sender As Object, e As EventArgs) Handles rbReintegroRadioButton.CheckedChanged

        If rbReintegroRadioButton.Checked Then

            Me.m_tipoAsiento = eTiposAsiento.REINTEGRO_EFECTIVO
            Me.DatosCompraGroupBox.Visible = False
            Me.TipoDisposiciónGroupBox.Location = Esquina
            Me.TipoDisposiciónGroupBox.Visible = True
            Me.AdeudoTelepeajeGroupBox.Visible = False
            Me.CuotaTarjetaGroupBox.Visible = False
            Me.DevolPrestamoGroupBox.Visible = False
        End If
    End Sub
    Private Sub rbAdeudoTelePeajeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdeudoTelePeajeRadioButton.CheckedChanged
        If rbAdeudoTelePeajeRadioButton.Checked Then

            Me.m_tipoAsiento = eTiposAsiento.ADEUDO_TELEPEAJE
            Me.DatosCompraGroupBox.Visible = False
            Me.TipoDisposiciónGroupBox.Visible = False
            Me.AdeudoTelepeajeGroupBox.Location = Esquina
            Me.AdeudoTelepeajeGroupBox.Visible = True
            Me.CuotaTarjetaGroupBox.Visible = False
            Me.DevolPrestamoGroupBox.Visible = False
        End If
    End Sub

    Private Sub CuotaTarjetaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CuotaTarjetaRadioButton.CheckedChanged
        Me.m_tipoAsiento = eTiposAsiento.CUOTA_TARJETA
        Me.DatosCompraGroupBox.Visible = False
        Me.TipoDisposiciónGroupBox.Visible = False
        Me.AdeudoTelepeajeGroupBox.Visible = False
        Me.CuotaTarjetaGroupBox.Location = Esquina
        Me.CuotaTarjetaGroupBox.Visible = True
        Me.DevolPrestamoGroupBox.Visible = False
    End Sub

    Private Sub DevolPrestamoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DevolPrestamoRadioButton.CheckedChanged
        Me.m_tipoAsiento = eTiposAsiento.AMORTIZACIÓN_PRÉSTAMO
        Me.DatosCompraGroupBox.Visible = False
        Me.TipoDisposiciónGroupBox.Visible = False
        Me.AdeudoTelepeajeGroupBox.Visible = False
        Me.CuotaTarjetaGroupBox.Visible = False
        Me.DevolPrestamoGroupBox.Location = Esquina
        Me.DevolPrestamoGroupBox.Visible = True
    End Sub
    Private Sub rbVentasRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentasRadioButton.CheckedChanged
        If rbVentasRadioButton.Checked Then

            Me.m_tipoAsiento = eTiposAsiento.VENTA
            Me.DatosCompraGroupBox.Visible = False
            Me.TipoDisposiciónGroupBox.Visible = False
            Me.AdeudoTelepeajeGroupBox.Visible = False
            Me.CuotaTarjetaGroupBox.Visible = False
            Me.DevolPrestamoGroupBox.Visible = False
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
            RaiseEvent CálculosCompra()

        End If
    End Sub

    Private Sub rbIVANormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVANormal.CheckedChanged

        If rbIVANormal.Checked Then

            Me.m_IVA = 21
            Me.m_CuentaIVA = 472021
            Me.TipoIVATextBox.Text = 21.ToString
            'forzar recálculo
            RaiseEvent CálculosCompra()

        End If
    End Sub

    Private Sub rbIVAReducido_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVAReducido.CheckedChanged

        If rbIVAReducido.Checked Then

            Me.m_IVA = 10
            Me.m_CuentaIVA = 472010
            Me.TipoIVATextBox.Text = 10.ToString
            'forzar recálculo
            RaiseEvent CálculosCompra()

        End If
    End Sub

    Private Sub rbIVASuperReducido_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVASuperReducido.CheckedChanged

        If rbIVASuperReducido.Checked Then

            Me.m_IVA = 4
            Me.m_CuentaIVA = 472004
            Me.TipoIVATextBox.Text = 4.ToString
            'forzar recálculo
            RaiseEvent CálculosCompra()

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
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Validar asiento
        '
        Select Case Me.TipoAsiento
            Case eTiposAsiento.COMPRA
                If Not frmAsientos.GenerarAsientoCompra(Me) Then
                    Exit Sub
                End If
            Case eTiposAsiento.REINTEGRO_EFECTIVO
                If Not frmAsientos.GenerarAsientoReintegro(Me) Then
                    Exit Sub
                End If
            Case eTiposAsiento.ADEUDO_TELEPEAJE
                If Not frmAsientos.GenerarAsientoTelePeaje(Me) Then
                    Exit Sub
                End If
            Case eTiposAsiento.CUOTA_TARJETA
                If Not frmAsientos.GenerarAsientoCuotaTarjeta(Me) Then
                    Exit Sub
                End If
            Case eTiposAsiento.AMORTIZACIÓN_PRÉSTAMO
                If Not frmAsientos.GenerarAsientoDevoluciónPréstamo(Me) Then
                    Exit Sub
                End If
            Case Else
                Exit Sub

        End Select
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Shared Function GenerarAsientoCompra(ByRef asto As frmAsientos) As Boolean
        '
        ' Validar
        '
        Dim msg As String = ""
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
            Return False

        End If

        asto.m_ClaveHash = CMódulo.Clave(asto.FechaAsiento.ToString + asto.Operación + asto.Justificante)
        asto.AsientosTableAdapter.Insert(asto.NúmeroAsiento, asto.FechaAsiento, asto.Justificante, asto.Operación, asto.ClaveHash)

        '
        ' Agregar cargos
        '
        Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "C")
        asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaGasto, NúmeroApunte, asto.BaseIVA)
        If asto.IVA <> 0 Then
            NúmeroApunte += 1
            asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaIVASoportado, NúmeroApunte, asto.CuotaIVA)
        End If
        NúmeroApunte += 1
        asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaProveedor, NúmeroApunte, asto.ImporteTotal)

        '
        ' Agregar abonos
        '
        NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "A")
        asto.AbonosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaProveedor, NúmeroApunte, asto.ImporteTotal)
        NúmeroApunte += 1
        asto.AbonosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaBanco, NúmeroApunte, asto.ImporteTotal)
        '
        'Generar Factura
        '

        asto.FacturasRecibidasTableAdapter.Insert(asto.Justificante, asto.FechaAsiento, Nothing, asto.CIF,
                                                  asto.NombreProveedor, asto.ClaveHash, asto.BaseIVA, asto.IVA, asto.CuotaIVA, asto.ImporteTotal)

        Return True

    End Function
    Private Shared Function GenerarAsientoReintegro(ByRef asto As frmAsientos) As Boolean

        asto.m_CuentaGasto = 551001
        ' asto.m_CuentaBanco = 5720001
        If asto.rbVentanillaRadioButton.Checked = True Then
            asto.m_Operación = "DISPOSICION EFECTIVO EN OFICINA " + Trim(asto.NúmeroOficinaTextBox.Text)
            asto.m_Justificante = Trim(asto.NúmeroOficinaTextBox.Text)
        ElseIf asto.rbCajeroRadioButton.Checked = True Then
            asto.m_Operación = "DISPOSICION EFECTIVO EN CAJERO " + Trim(asto.NúmeroOficinaTextBox.Text)
            asto.m_Justificante = Trim(asto.NúmeroOficinaTextBox.Text)
        ElseIf asto.rbChequeRadioButton.Checked = True Then
            asto.m_Operación = "ABONO DE CHEQUE " + Trim(asto.NúmeroOficinaTextBox.Text)
            asto.m_Justificante = Trim(asto.NúmeroOficinaTextBox.Text)
        Else
            CMódulo.MsgErrorCrítico("ERROR AL GENERAR ASIENTO DE REINTEGRO. ASIENTO NO GENERADO")
            Return False

        End If

        '
        ' Validar
        '

        Dim msg As String = ""
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
            Return False

        End If

        asto.m_ClaveHash = CMódulo.Clave(asto.FechaAsiento.ToString + asto.Operación + asto.Justificante)
        asto.AsientosTableAdapter.Insert(asto.NúmeroAsiento, asto.FechaAsiento, asto.Justificante, asto.Operación, asto.ClaveHash)

        '
        ' Agregar cargos
        '
        Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "C")
        asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaGasto, NúmeroApunte, asto.BaseIVA)

        '
        ' Agregar abonos
        '
        NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "A")
        asto.AbonosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaBanco, NúmeroApunte, asto.ImporteTotal)

        Return True

    End Function

    Private Shared Function GenerarAsientoTelePeaje(ByRef asto As frmAsientos) As Boolean

        asto.m_CuentaProveedor = 410102
        asto.m_NombreProveedor = "AUTOPISTAS DE PEAJE"

        asto.m_CuentaGasto = 629008
        asto.m_Justificante = "S/J"


        asto.m_Operación = "ABONO TELEPEAJE " + Trim(asto.Justificante)
        '
        ' Validar
        '
        Dim msg As String = ""
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
            Return False

        End If

        asto.m_ClaveHash = CMódulo.Clave(asto.FechaAsiento.ToString + asto.Operación + asto.Justificante)
        asto.AsientosTableAdapter.Insert(asto.NúmeroAsiento, asto.FechaAsiento, asto.Justificante, asto.Operación, asto.ClaveHash)

        '
        ' Agregar cargos
        '
        Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "C")
        asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaGasto, NúmeroApunte, asto.BaseIVA)
        NúmeroApunte += 1
        asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaIVASoportado, NúmeroApunte, asto.CuotaIVA)
        NúmeroApunte += 1
        asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaProveedor, NúmeroApunte, asto.ImporteTotal)

        '
        ' Agregar abonos
        '
        NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "A")
        asto.AbonosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaProveedor, NúmeroApunte, asto.ImporteTotal)
        NúmeroApunte += 1
        asto.AbonosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaBanco, NúmeroApunte, asto.ImporteTotal)
        '
        'Generar Factura
        '

        asto.FacturasRecibidasTableAdapter.Insert(asto.Justificante, asto.FechaAsiento, Nothing, asto.CIF,
                                                  asto.NombreProveedor, asto.ClaveHash, asto.BaseIVA, asto.IVA, asto.CuotaIVA, asto.ImporteTotal)

        Return True

    End Function

    Private Shared Function GenerarAsientoCuotaTarjeta(ByRef asto As frmAsientos) As Boolean

        asto.m_CuentaGasto = 669
        asto.m_Justificante = asto.Justificante


        asto.m_Operación = "CUOTA TARJETA " + Trim(asto.NúmeroTarjeta)

        '
        ' Validar
        '
        Dim msg As String = ""
        If Len(Trim(asto.Operación)) = 0 Then

            msg += "El campo Operación no puede quedar en blanco. "

        End If
        If asto.CuentaBanco = 0 Then

            msg += "La cuenta bancaria no puede ser 0. "

        End If
        If asto.CuotaTarjeta = 0 Then

            msg += "El importe de la cuota no puede ser 0. "

        End If
        If Len(Trim(msg)) <> 0 Then

            CMódulo.MsgErrorCrítico(msg)
            Return False

        End If

        asto.m_ClaveHash = CMódulo.Clave(asto.FechaAsiento.ToString + asto.Operación + asto.Justificante)
        asto.AsientosTableAdapter.Insert(asto.NúmeroAsiento, asto.FechaAsiento, asto.Justificante, asto.Operación, asto.ClaveHash)

        '
        ' Agregar cargos
        '
        Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "C")
        asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaGasto, NúmeroApunte, asto.CuotaTarjeta)

        '
        ' Agregar abonos
        '
        NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "A")
        asto.AbonosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaBanco, NúmeroApunte, asto.CuotaTarjeta)

        Return True

    End Function
    Private Shared Function GenerarAsientoDevoluciónPréstamo(ByRef asto As frmAsientos) As Boolean

        '
        ' Validar
        '
        Dim msg As String = ""
        If Len(Trim(asto.Operación)) = 0 Then

            msg += "El campo Operación no puede quedar en blanco. "

        End If
        If asto.CuentaBanco = 0 Then

            msg += "La cuenta bancaria no puede ser 0. "

        End If
        If asto.CapitalDevuelo = 0 AndAlso asto.Interés = 0 AndAlso asto.InterésMora = 0 Then

            msg += "El capital devuelto, el interés y el interés de mora no pueden ser simultaneamente 0. "

        End If
        If Len(Trim(msg)) <> 0 Then

            CMódulo.MsgErrorCrítico(msg)
            Return False

        End If
        asto.m_ClaveHash = CMódulo.Clave(asto.FechaAsiento.ToString + asto.Operación + asto.Justificante)
        asto.AsientosTableAdapter.Insert(asto.NúmeroAsiento, asto.FechaAsiento, asto.Justificante, asto.Operación, asto.ClaveHash)

        '
        ' Agregar cargos
        '
        Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "C")
        asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CtaPréstamo, NúmeroApunte, asto.CapitalDevuelo)
        If asto.Interés <> 0 Then
            NúmeroApunte += 1
            asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaIntereses, NúmeroApunte, asto.Interés)
        End If
        If asto.InterésMora <> 0 Then
            NúmeroApunte += 1
            asto.CargosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaIntereses, NúmeroApunte, asto.InterésMora)
        End If
        '
        ' Agregar abonos
        '
        NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, asto.NúmeroAsiento, "A")
        asto.AbonosTableAdapter.Insert(asto.NúmeroAsiento, asto.CuentaBanco, NúmeroApunte, asto.CapitalDevuelo + asto.Interés + asto.InterésMora)



        Return True

    End Function
    Private Sub FechaDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaDateTimePicker.ValueChanged

        Me.m_fechaAsiento = Me.FechaDateTimePicker.Value

    End Sub

    Private Sub JustificanteTextBox_TextChanged(sender As Object, e As EventArgs) Handles JustificanteTextBox.TextChanged

        Me.m_Justificante = Me.JustificanteTextBox.Text

    End Sub

    Private Sub TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalTextBox.TextChanged

        RaiseEvent CálculosCompra()

    End Sub

    Private Sub TotalDispuestoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalDispuestoTextBox.TextChanged

        RaiseEvent CálculosReintegro()

    End Sub
    Private Sub TotalTelepeajeTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalTelepeajeTextBox.TextChanged

        RaiseEvent CálculosTelepeaje()

    End Sub
    Private Sub CuentasGastoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuentasGastoComboBox.SelectedIndexChanged

        If CuentasGastoComboBox.SelectedIndex > -1 Then

            Me.m_CuentaGasto = CInt(CuentasGastoComboBox.SelectedValue)

        End If
    End Sub
    Private Sub TarjetaTextBox_TextChanged(sender As Object, e As EventArgs) Handles TarjetaTextBox.TextChanged

        Me.m_NúmeroTarjeta = Me.TarjetaTextBox.Text

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

    Private Sub Bancos2ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Bancos2ComboBox.SelectedIndexChanged

        With Me.Bancos2ComboBox

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


    Private Sub BancoCuentaTjtaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BancoCuentaTjtaComboBox.SelectedIndexChanged

        With Me.BancoCuentaTjtaComboBox


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
    Sub Realiza_Los_Cálculos_Compra() Handles Me.CálculosCompra

        If Len(Trim(Me.TotalTextBox.Text)) <> 0 Then

            Me.m_ImporteTotal = CDbl(Me.TotalTextBox.Text)
            Dim R As Double = 1 + Me.IVA / 100
            Me.m_BaseIVA = Math.Round((Me.ImporteTotal / R), 2)
            Me.m_CuotaIVA = Me.ImporteTotal - Me.m_BaseIVA

            Me.BaseIVATextBox.Text = Me.BaseIVA.ToString
            Me.CuotaIVATextBox.Text = Me.CuotaIVA.ToString

        End If


    End Sub

    Sub Realiza_Los_Cálculos_Reintegro() Handles Me.CálculosReintegro

        If Len(Trim(Me.TotalDispuestoTextBox.Text)) <> 0 Then

            Me.m_ImporteTotal = CDbl(Me.TotalDispuestoTextBox.Text)
            Me.m_IVA = 0
            Me.m_BaseIVA = Me.ImporteTotal
            Me.m_CuotaIVA = 0

        End If

    End Sub

    Sub Realiza_Los_Cálculos_TelePeaje() Handles Me.CálculosTelepeaje


        If Len(Trim(Me.TotalTelepeajeTextBox.Text)) <> 0 Then

            Me.m_ImporteTotal = CDbl(Me.TotalTelepeajeTextBox.Text)
            Me.m_IVA = 21
            Me.m_CuentaIVA = 472021
            Dim R As Double = 1 + Me.IVA / 100
            Me.m_BaseIVA = Math.Round((Me.ImporteTotal / R), 2)
            Me.m_CuotaIVA = Me.ImporteTotal - Me.m_BaseIVA
            ' EN EL TELEPEAJE SOLO SE SOPORTA LA MITAD DEL IVA
            Me.m_CuotaIVA = Me.m_CuotaIVA / 2
            Me.m_BaseIVA += Me.m_CuotaIVA

        End If

    End Sub
    Sub CálculoCapitalDevuelto() Handles Me.CálculosCapitalDevuelto


        If Len(Trim(Me.CapitalDevueltoTextBox.Text)) <> 0 Then

            Me.m_CapitalDevuelto = CDbl(Me.CapitalDevueltoTextBox.Text)

        Else

            Me.m_CapitalDevuelto = 0

        End If

    End Sub
    Sub CálculoInterés() Handles Me.CálculosInterés


        If Len(Trim(Me.InteresesTextBox.Text)) <> 0 Then

            Me.m_Interés = CDbl(Me.InteresesTextBox.Text)

        Else

            Me.m_Interés = 0

        End If

    End Sub
    Sub CálculoInterésMora() Handles Me.CálculosInterésMora


        If Len(Trim(Me.InteresesMoraTextBox.Text)) <> 0 Then

            Me.m_InteresMora = CDbl(Me.InteresesMoraTextBox.Text)

        Else

            Me.m_InteresMora = 0

        End If

    End Sub
    Private Sub TotalCuotaTarjeaTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalCuotaTarjeaTextBox.TextChanged
        Me.m_CuotaTarjeta = CDbl(Me.TotalCuotaTarjeaTextBox.Text)
    End Sub

    Private Sub PréstamosLargoPlazoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PréstamosLargoPlazoComboBox.SelectedIndexChanged

        If Me.PréstamosLargoPlazoComboBox.SelectedIndex > -1 Then

            Me.m_Operación = "DEVOLUCIÓN PRÉSTAMO"
            Dim filtro As String = "PRÉSTAMO = " + PréstamosLargoPlazoComboBox.SelectedValue.ToString + " and Año = " +
                Me.FechaAsiento.Year.ToString + " and Mes = " + Me.FechaAsiento.Month.ToString
            Dim filas As BDContabilidadGMELO.PréstamosRow() = CType(Me.BDContabilidadGMELO.Préstamos.Select(filtro), BDContabilidadGMELO.PréstamosRow())

            Me.m_Operación = "DEVOLUCIÓN PRÉSTAMO"
            Me.m_Justificante = filas(0).MES.ToString("N2") + " / " + filas(0).AÑO.ToString("N2")
            Me.CapitalDevueltoTextBox.Text = filas(0).CAPITAL.ToString("N2")
            Me.InteresesTextBox.Text = filas(0).INTERES.ToString("N2")


            Me.m_CtaPréstamoLargo = CInt(PréstamosLargoPlazoComboBox.SelectedValue)

            Me.m_Operación = Operación

            Me.m_Justificante = "RECIBO BANCO"
            If filas(0).PRÉSTAMO = 170005 Then
                Me.m_CuentaBanco = 572001 'bsch
            ElseIf filas(0).PRÉSTAMO = 170003 Then
                Me.m_CuentaBanco = 572002 'bbva
            End If
            Me.m_CtaPréstamo = filas(0).CAPITAL_PTE
            Me.m_CtaIntereses = filas(0).INTERESES

        Else

            Throw New Exception("Not existe el préstamo")
            Exit Sub

        End If

    End Sub

    Private Sub CapitalDevueltoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CapitalDevueltoTextBox.TextChanged

        RaiseEvent CálculosCapitalDevuelto()

    End Sub

    Private Sub InteresesTextBox_TextChanged(sender As Object, e As EventArgs) Handles InteresesTextBox.TextChanged

        RaiseEvent CálculosInterés()

    End Sub

    Private Sub InteresesMoraTextBox_TextChanged(sender As Object, e As EventArgs) Handles InteresesMoraTextBox.TextChanged

        RaiseEvent CálculosInterésMora()

    End Sub

End Class
