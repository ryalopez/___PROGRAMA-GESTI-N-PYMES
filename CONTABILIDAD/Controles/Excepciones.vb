Module Excepciones

    Class ExcepCódigoNoNumérico
        Inherits Exception

        Dim respuesta As Boolean

        Public Sub New(prmMsg As String, prmRespuesta As Boolean)
            MyBase.New(prmMsg)

            respuesta = prmRespuesta

        End Sub

    End Class

    Friend Sub MsgInformativo(ByVal msg As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, My.Resources.EMPRESA)

    End Sub

    Friend Sub MsgErrorCrítico(ByVal msg As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
        MsgBox(msg, iconos, My.Resources.EMPRESA)

    End Sub

    Friend Function MsgPregunta(ByVal msg As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle)
        Return MsgBox(msg, iconos, My.Resources.EMPRESA)

    End Function

    Friend Function MsgAdvertencia(ByVal msg As String) As MsgBoxResult

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.Question + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Return MsgBox(msg, iconos, My.Resources.EMPRESA)

    End Function

    Friend Sub MsgDatosGuardadosOK()

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Dim msg As String = "Los datos se han grabado correctamente."
        MsgBox(msg, iconos, My.Resources.EMPRESA)

    End Sub

    Friend Sub MsgErrorBorrarFila(ByVal Tabla As String, ByVal TablaRelacionada As String)

        Dim iconos As MsgBoxStyle = CType(MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, MsgBoxStyle)
        Dim msg As String = "ERROR. No se puede borrar el registro de " & _
            Tabla & " porque existen registros relacionados en  " & TablaRelacionada
        MsgBox(msg, iconos, My.Resources.EMPRESA)

    End Sub

End Module
