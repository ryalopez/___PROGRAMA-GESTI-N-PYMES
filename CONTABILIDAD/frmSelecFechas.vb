Imports System.Windows.Forms

Public Enum TipoListado
    Diario
    BalanceSumasSaldos
    BalanceSituación
    Mayor
End Enum

Public Class frmSelecFechas

    Public resul As String = ""
    Public tipoListado As tipoListado

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If Me.tipoListado = Contabilidad.TipoListado.BalanceSumasSaldos Then

            With Me.DateTimePicker1

                If .Value.Month() < 4 Then

                    resul += "PRIMER TRIMESTRE EJERCICIO " + .Value.Year.ToString

                ElseIf .Value.Month < 7 Then

                    resul += "SEGUNDO TRIMESTRE EJERCICIO " + .Value.Year.ToString

                ElseIf .Value.Month < 10 Then

                    resul += "TERCER TRIMESTRE EJERCICIO " + .Value.Year.ToString

                Else

                    resul += "CUARTO TRIMESTRE EJERCICIO " + .Value.Year.ToString

                End If
            End With

        ElseIf Me.tipoListado = Contabilidad.TipoListado.BalanceSituación Then

            resul += "EJERCICIO " + Me.DateTimePicker1.Value.Year.ToString

        Else
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
