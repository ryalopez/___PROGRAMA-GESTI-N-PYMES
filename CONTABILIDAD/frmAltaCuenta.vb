Imports System.Windows.Forms
Imports System.EventArgs
Imports System.ComponentModel
Imports CBiblioteca
Imports System

Public Class FrmAltaCuenta
    Implements INotifyPropertyChanged, ICuenta

    Private mCódigo As Integer
    Private mCódigoCuentaMaestra As Integer
    Private mNombre As String
    Private mIdCuentaPerdidasyGanancias As Integer
    Private mIdCuentaBalanceSituación As Integer
    Private mCanceladaAltaCuenta As Boolean

    Public Delegate Sub CambioUIEventHandler(sender As Object, e As CCambioUI)

    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
    Private Event ICuenta_PropertyChanged As ICuenta.PropertyChangedEventHandler Implements ICuenta.PropertyChanged

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim a As New BDContabilidadGMELOTableAdapters.CuentasTableAdapter
        a.Insert(Me.Código, CódigoCuentaMaestra, Me.Nombre, Me.idCuentaPerdidasyGanancias, Me.idCuentaBalanceResultados, Me.Código)
        Me.mCanceladaAltaCuenta = False
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.mCanceladaAltaCuenta = True
        Me.Close()
    End Sub

    Private Sub FrmAltaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.PérdidasyGananciasTableAdapter.Fill(Me.BDContabilidadGMELO.PérdidasyGanancias)
        Me.BalanceSituaciónTableAdapter.Fill(Me.BDContabilidadGMELO.BalanceSituación)

        Me.Text = "Alta de Cuenta"
        Me.CanceladaAltaCuenta = True
        Me.CódigoCuentaTextBox.DataBindings.Add(New Binding("Text", Me, "Código"))
        Me.NombreTextBox.DataBindings.Add(New Binding("Text", Me, "Nombre"))
        Me.BalanceSituaciónComboBox.SelectedValue = Me.mIdCuentaBalanceSituación
        Me.PérdidasyGananciasComboBox.SelectedValue = Me.mIdCuentaPerdidasyGanancias

    End Sub

    Public Property Código As Integer Implements ICuenta.Código

        Get
            Return Me.mCódigo
        End Get
        Set(value As Integer)
            Me.mCódigo = value
            RaiseEvent PropertyChanged(Me,
                New System.ComponentModel.PropertyChangedEventArgs("Código"))
        End Set
    End Property

    Public Property CódigoCuentaMaestra As Integer Implements ICuenta.CódigoCuentaMaestra
        Get
            Return Me.mCódigoCuentaMaestra
        End Get
        Set(value As Integer)
            Me.mCódigoCuentaMaestra = value
            RaiseEvent PropertyChanged(Me,
                New System.ComponentModel.PropertyChangedEventArgs("CódigoCuentaMaestra"))
        End Set
    End Property

    Public Property Nombre As String Implements ICuenta.Nombre
        Get
            Return Me.mNombre
        End Get
        Set(value As String)
            Me.mNombre = value
            RaiseEvent PropertyChanged(Me,
               New System.ComponentModel.PropertyChangedEventArgs("Nombre"))
        End Set
    End Property

    Public Property idCuentaPerdidasyGanancias As Integer Implements ICuenta.idCuentaPerdidasyGanancias
        Get
            Me.mIdCuentaPerdidasyGanancias = CInt(Me.PérdidasyGananciasComboBox.SelectedValue)
            Return Me.mIdCuentaPerdidasyGanancias
        End Get
        Set(value As Integer)
            Me.mIdCuentaPerdidasyGanancias = value
            Me.PérdidasyGananciasComboBox.SelectedValue = Me.mIdCuentaPerdidasyGanancias
            RaiseEvent PropertyChanged(Me,
               New System.ComponentModel.PropertyChangedEventArgs("idCuentaPerdidasyGanancias"))
        End Set
    End Property

    Public Property idCuentaBalanceResultados As Integer Implements ICuenta.idCuentaBalanceResultados
        Get
            Me.mIdCuentaBalanceSituación = CInt(Me.BalanceSituaciónComboBox.SelectedValue)
            Return Me.mIdCuentaBalanceSituación
        End Get
        Set(value As Integer)
            Me.mIdCuentaBalanceSituación = value
            Me.BalanceSituaciónComboBox.SelectedValue = Me.mIdCuentaBalanceSituación
            RaiseEvent PropertyChanged(Me,
               New System.ComponentModel.PropertyChangedEventArgs("idCuentaBalanceSituación"))
        End Set
    End Property

    Public Property CanceladaAltaCuenta As Boolean Implements ICuenta.CanceladaAltaCuenta
        Get
            Return Me.mCanceladaAltaCuenta
        End Get
        Set(value As Boolean)
            Me.mCanceladaAltaCuenta = value
            RaiseEvent PropertyChanged(Me,
               New System.ComponentModel.PropertyChangedEventArgs("CanceladaAltaCuenta"))
        End Set
    End Property

    Private Sub BalanceSituaciónBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BalanceSituaciónBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BalanceSituaciónBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDContabilidadGMELO)

    End Sub

    Private Sub BalanceSituaciónComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BalanceSituaciónComboBox.SelectedIndexChanged
        Me.mIdCuentaBalanceSituación = CInt(Me.BalanceSituaciónComboBox.SelectedValue)
    End Sub

    Private Sub PérdidasyGananciasComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PérdidasyGananciasComboBox.SelectedIndexChanged
        Me.mIdCuentaPerdidasyGanancias = CInt(Me.PérdidasyGananciasComboBox.SelectedValue)
    End Sub
End Class
