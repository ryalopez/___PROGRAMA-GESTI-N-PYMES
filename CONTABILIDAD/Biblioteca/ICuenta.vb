Public Interface ICuenta

    Delegate Sub CambioUIEventHandler(sender As Object, e As CCambioUI)

    Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs)

    Property Código As Integer
    Property CódigoCuentaMaestra As Integer
    Property Nombre As String
    Property idCuentaPerdidasyGanancias As Integer
    Property idCuentaBalanceResultados As Integer
    Property CanceladaAltaCuenta As Boolean

End Interface
