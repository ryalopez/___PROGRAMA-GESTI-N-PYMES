Public Class ctlDatosBancarios


    Private Sub btnValidarDDBB_Click(sender As Object, e As EventArgs) Handles btnValidarDDBB.Click

        Try

            Me.DC.Text = DígitoControl(Me.Banco, Me.Sucursal, Me.Cuenta)

        Catch exNN As ExcepCódigoNoNumérico

            MsgPregunta(exNN.Message)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Me.IBAN.Text = CódigoIban(Me.Banco, Me.Sucursal, Me.DC, Me.Cuenta)

    End Sub

    Public Function DígitoControl(prmBanco As TextBox, prmSucursal As TextBox, prmCuenta As TextBox) As String
        DígitoControl = ""

        Dim c As Integer = 0
        Dim t As Integer

        'La primera cifra del banco se multiplica por 4.
        If Integer.TryParse(Banco.Text.Substring(0, 1), c) Then
            t = c * 4
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La segunda cifra del banco se multiplica por 8.
        If Integer.TryParse(Banco.Text.Substring(1, 1), c) Then
            t += c * 8
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La tercera cifra del banco se multiplica por 5.
        If Integer.TryParse(Banco.Text.Substring(2, 1), c) Then
            t += c * 5
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La cuarta cifra del banco se multiplica por 10.
        If Integer.TryParse(Banco.Text.Substring(3, 1), c) Then
            t += c * 10
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la entidad se multiplica por 9.
        If Integer.TryParse(Sucursal.Text.Substring(0, 1), c) Then
            t += c * 9
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La segunda cifra de la entidad se multiplica por 7.
        If Integer.TryParse(Sucursal.Text.Substring(1, 1), c) Then
            t += c * 7
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La tercera cifra de la entidad se multiplica por 3.
        If Integer.TryParse(Sucursal.Text.Substring(2, 1), c) Then
            t += c * 3
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La cuarta cifra de la entidad se multiplica por 6.
        If Integer.TryParse(Sucursal.Text.Substring(3, 1), c) Then
            t += c * 6
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'Se divide entre 11 y nos quedamos con el resto de la división.
        Dim r As Integer = t Mod 11
        'A 11 le quitamos el resto anterior, y ese el el primer dígito de control, con la salvedad de que si nos da 10, el dígito es 1
        DígitoControl = (11 - r).ToString
        If DígitoControl = "10" Then
            DígitoControl = "1"
        End If
        t = 0
        'La primera cifra de la cuenta se multiplica por 1
        If Integer.TryParse(Cuenta.Text.Substring(0, 1), c) Then
            t = c * 1
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la cuenta se multiplica por 2
        If Integer.TryParse(Cuenta.Text.Substring(1, 1), c) Then
            t += c * 2
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la cuenta se multiplica por 4
        If Integer.TryParse(Cuenta.Text.Substring(2, 1), c) Then
            t += c * 4
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la cuenta se multiplica por 8
        If Integer.TryParse(Cuenta.Text.Substring(3, 1), c) Then
            t += c * 8
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la cuenta se multiplica por 5
        If Integer.TryParse(Cuenta.Text.Substring(4, 1), c) Then
            t += c * 5
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la cuenta se multiplica por 10
        If Integer.TryParse(Cuenta.Text.Substring(5, 1), c) Then
            t += c * 10
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la cuenta se multiplica por 9
        If Integer.TryParse(Cuenta.Text.Substring(6, 1), c) Then
            t += c * 9
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la cuenta se multiplica por 7
        If Integer.TryParse(Cuenta.Text.Substring(7, 1), c) Then
            t += c * 7
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la cuenta se multiplica por 3
        If Integer.TryParse(Cuenta.Text.Substring(8, 1), c) Then
            t += c * 3
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'La primera cifra de la cuenta se multiplica por 6
        If Integer.TryParse(Cuenta.Text.Substring(9, 1), c) Then
            t += c * 6
        Else
            Throw New ExcepCódigoNoNumérico(My.Resources.msgCódigosNuméricos, False)
        End If
        'Se divide entre 11 y nos quedamos con el resto de la división.
        r = t Mod 11
        'A 11 le quitamos el resto anterior, y ese el el primer dígito de control, con la salvedad de que si nos da 10, el dígito es 1
        t = 11 - r
        If t = 10 Then
            t = 1
        End If

        Return DígitoControl + t.ToString

    End Function

    Function Mod97(ByVal vIban)
        '734027177486111478 is too big to be represented as a 32-bit integer, so you can't just use Mod 97 like this.
        '20381770533000360417142800
        'A simple solution is to use some basic math :

        '    (a + b) mod n = ((a mod n) + (b mod n)) mod n
        '    (a * b) mod n = ((a mod n) * (b mod n)) mod n

        'And from that you can compute your modulo digit by digit:
        Dim i, m, digit
        m = 0
        For i = 1 To Len(vIban)
            digit = CInt(Mid(vIban, i, 1))
            m = (10 * m + digit) Mod 97
        Next
        Mod97 = m
    End Function

    Public Function CódigoIban(prmBanco As TextBox, prmSucursal As TextBox, prmDC As TextBox, prmCuenta As TextBox) As String
        CódigoIban = "ES"

        '- Se escriben ES00 seguido de los 20 dígitos de la CCC. Esto nos da una secuencia de 24 caracteres.
        '- Ponemos los 4 primeros caracteres, ES00, al final, detrás de los de la CCC y sustituimos las letras por números; la E por 14 y la S por 28.

        Dim s As String = prmBanco.Text + prmSucursal.Text + prmDC.Text + prmCuenta.Text + "14" + "28" + "00"

        '- Calculamos cuánto vale ese número obtenido módulo 97,dividiendo por 97 y quedándonos con el resto, le llamamos R.
        Dim r As Integer = Mod97(s)
        Dim t As Integer = 98 - r

        If t.ToString.Length = 1 Then
            CódigoIban += "0" + t.ToString
        Else
            CódigoIban += t.ToString
        End If

        Return CódigoIban

    End Function

End Class
