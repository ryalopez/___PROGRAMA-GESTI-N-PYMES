Imports System.Windows.Forms
Imports Biblioteca

Public Class frmAsientos

    Private m_tipo As eTiposAsiento
    Private m_númeroAsiento As Integer

    Sub New(tipoAsiento As eTiposAsiento)
        ' MyBase.New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        m_tipo = tipoAsiento
        Me.Text = "Asiento: " + [Enum].GetName(GetType(eTiposAsiento), m_tipo)
        '
        ' Agregar asiento
        '
        AsientosBindingSource.SuspendBinding()
        m_númeroAsiento = CMódulo.NúmeroNuevoAsiento(My.Settings.BDContabilidadConnectionString)
        ''Me.AsientosTableAdapter.Insert(NúmeroAsiento, Today, "*", "*")
        Me.NúmeroTextBox.Text = NúmeroAsiento.ToString
        Me.FechaDateTimePicker.Value = Today

        Dim CódigoCuenta As String = "570"
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
    End Sub

    Public ReadOnly Property tipo As eTiposAsiento
        Get
            Return m_tipo
        End Get
    End Property

    Public ReadOnly Property NúmeroAsiento As Integer
        Get
            Return Me.m_númeroAsiento
        End Get
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AsientosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AsientosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDContabilidadGMELO)

    End Sub

    Private Sub frmAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasProveedores' Puede moverla o quitarla según sea necesario.
        Me.CuentasProveedoresTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasProveedores)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.CuentasGasto' Puede moverla o quitarla según sea necesario.
        Me.CuentasGastoTableAdapter.Fill(Me.BDContabilidadGMELO.CuentasGasto)
        'TODO: esta línea de código carga datos en la tabla 'BDContabilidadGMELO.Asientos' Puede moverla o quitarla según sea necesario.
        Me.AsientosTableAdapter.Fill(Me.BDContabilidadGMELO.Asientos)

    End Sub

    Private Sub CuentasProveedoresComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuentasProveedoresComboBox.SelectedIndexChanged

        If CuentasProveedoresComboBox.SelectedIndex > 0 Then

            Dim p As Integer = Me.CuentasGastoBindingSource.Find("Código", CType(Me.ProveedoresBindingSource.Current, DataRowView).Item("Cuenta6"))
            MsgBox("pos = " + p.ToString)
            If p > -1 Then

                Me.CuentasGastoBindingSource.Position = p

            End If

        End If

    End Sub

    Private Sub CuentasGastoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuentasGastoComboBox.SelectedIndexChanged

    End Sub
End Class
