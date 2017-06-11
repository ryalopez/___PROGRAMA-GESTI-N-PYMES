Imports System.Windows.Forms
Imports Biblioteca

Public Class frmAsientos

    Private m_tipoAsiento As eTiposAsiento
    Private m_númeroAsiento As Integer
    Private m_fechaAsiento As Date
    Private m_Operación As String
    Private m_Justificante As String
    Private m_CuentaProveedor As Integer
    Private m_CuentaGasto As Integer
    Private m_IVA As Double
    Private m_CuentaIVA As Integer
    Private m_CuentaBanco As Integer

    Private Sub frmAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        AsientosBindingSource.SuspendBinding()
        m_númeroAsiento = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
        Me.NúmeroTextBox.Text = Me.NúmeroAsiento.ToString
        Me.FechaDateTimePicker.Value = Today
        Me.m_fechaAsiento = Me.FechaDateTimePicker.Value

    End Sub


    Public ReadOnly Property TipoAsiento As eTiposAsiento
        Get
            Return Me.m_tipoAsiento
        End Get
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

    Private Sub CuentasProveedoresComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuentasProveedoresComboBox.SelectedIndexChanged

        Me.m_CuentaProveedor = CInt(CType(Me.ProveedoresBindingSource.Current, DataRowView).Item("Cuenta4"))
        If CuentasProveedoresComboBox.SelectedIndex > 0 Then

            Dim p As Integer = Me.CuentasGastoBindingSource.Find("Código", CType(Me.ProveedoresBindingSource.Current, DataRowView).Item("Cuenta6"))
            If p > -1 Then

                Me.CuentasGastoBindingSource.Position = p

            End If

            If Me.TipoAsiento = eTiposAsiento.COMPRA Then
                Dim NombreProveedor As String = CType(Me.ProveedoresBindingSource.Current, DataRowView).Item("Nombre").ToString
                Me.m_Operación = NombreProveedor + " S/F " + Me.Justificante + "."
                Me.OperaciónTextBox.Text = Me.Operación
                Me.m_Justificante = Me.JustificanteTextBox.Text
            End If
        End If

    End Sub

    Private Sub rbComprasRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbComprasRadioButton.CheckedChanged
        If rbComprasRadioButton.Checked Then

            Me.m_tipoAsiento = eTiposAsiento.COMPRA

        End If

    End Sub

    Private Sub rbVentasRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentasRadioButton.CheckedChanged
        If rbVentasRadioButton.Checked Then

            Me.m_tipoAsiento = eTiposAsiento.VENTA

        End If

    End Sub

    Private Sub rbIVANo_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVANo.CheckedChanged

        If rbIVANo.Checked Then

            Me.m_IVA = 0
            Me.m_CuentaIVA = 0

        End If
    End Sub

    Private Sub rbIVANormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVANormal.CheckedChanged

        If rbIVANormal.Checked Then

            Me.m_IVA = 21
            Me.m_CuentaIVA = 472021

        End If
    End Sub

    Private Sub rbIVAReducido_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVAReducido.CheckedChanged

        If rbIVAReducido.Checked Then

            Me.m_IVA = 10
            Me.m_CuentaIVA = 472010

        End If
    End Sub

    Private Sub rbIVASuperReducido_CheckedChanged(sender As Object, e As EventArgs) Handles rbIVASuperReducido.CheckedChanged

        If rbIVASuperReducido.Checked Then

            Me.m_IVA = 4
            Me.m_CuentaIVA = 472004

        End If
    End Sub

    Private Sub rbPagoCaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbPagoCaja.CheckedChanged

        If rbPagoCaja.Checked Then

            Me.m_CuentaBanco = 5700001
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
        '
        ' Validar asiento
        '
        If Not frmAsientos.Válido(Me) Then

            Exit Sub

        Else

            GenerarAsiento()


        End If


        '
        ' Agregar cargo
        '
        Dim NúmeroApunte As Integer = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, NúmeroAsiento, "C")
        ''Me.CargosTableAdapter.Insert(NúmeroAsiento, CInt(CódigoCuenta), NúmeroApunte, 0)
        '
        ' Agregar abono
        '
        NúmeroApunte = CMódulo.NúmeroNuevoApunte(My.Settings.BDContabilidadConnectionString, NúmeroAsiento, "A")
        ''Me.AbonosTableAdapter.Insert(NúmeroAsiento, CInt(CódigoCuenta), NúmeroApunte, 0)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Shared Function Válido(asto As frmAsientos) As Boolean

        Dim msg As String = ""
        If asto.CuentaProveedor = 0 Then

            msg += "La cuenta del cliente/proveedor no puede ser 0. "

        End If
        If asto.CuentaGasto = 0 Then

            msg += "La cuenta de gasto no puede ser 0. "

        End If
        If asto.IVA <> 0 AndAlso asto.CuentaIVASoportado = 0 Then

            msg += "La cuenta de IVA soportado no puede ser 0. "

        End If
        If asto.CuentaBanco = 0 Then

            msg += "La cuenta bancaria no puede ser 0. "

        End If
        If Len(Trim(asto.Operación)) <> 0 Then

            msg += "El campo Operación no puede quedar en blanco. "

        End If
        If Len(Trim(asto.Justificante)) <> 0 Then

            msg += "El campo Justificante no puede quedar en blanco. "

        End If
        If Len(Trim(msg)) <> 0 Then

            CMódulo.MsgErrorCrítico(msg)

        End If

    End Function

    Private Sub CuentasGastoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuentasGastoComboBox.SelectedIndexChanged

        If CuentasGastoComboBox.SelectedIndex > -1 Then

            Me.m_CuentaGasto = CInt(CuentasGastoComboBox.SelectedValue)

        End If
    End Sub

    Private Sub GenerarAsiento()

        ' Me.AsientosTableAdapter.Insert(Me.NúmeroAsiento, Me.FechaAsiento, Me.FechaDateTimePicker, Me.OperaciónTextBox.Text)

    End Sub

    Private Sub FechaDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaDateTimePicker.ValueChanged

        Me.m_fechaAsiento = Me.FechaDateTimePicker.Value

    End Sub
End Class
