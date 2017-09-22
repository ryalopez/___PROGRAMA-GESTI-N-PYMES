Imports System.ComponentModel
Imports CBiblioteca

<Bindable(True)>
Public Class CDocumentoIdentidad

    Private mTipo As ETipoDocumento
    Private mValor As String
    Private mEsVálido As Boolean

    Sub New(prmTipo As ETipoDocumento, prmValorDocumento As String)

        Select Case prmTipo
            Case ETipoDocumento.Ninguno
                Me.mTipo = prmTipo
                Me.mValor = prmValorDocumento
                Me.mEsVálido = True

                Exit Select

            Case ETipoDocumento.NIF_DNI
                If EsNIFVálido(prmValorDocumento) Then
                    Me.mTipo = prmTipo
                    Me.mValor = prmValorDocumento
                    Me.mEsVálido = True

                    Exit Select

                End If

            Case ETipoDocumento.CIF
                If EsCIFVálido(prmValorDocumento) Then
                    Me.mTipo = prmTipo
                    Me.mValor = prmValorDocumento
                    Me.mEsVálido = True

                    Exit Select

                End If

            Case ETipoDocumento.NIE
                If EsNIEVálido(prmValorDocumento) Then
                    Me.mTipo = prmTipo
                    Me.mValor = prmValorDocumento
                    Me.mEsVálido = True

                    Exit Select

                End If

            Case ETipoDocumento.Pasaporte
                If EsPasaporteVálido(prmValorDocumento) Then
                    Me.mTipo = prmTipo
                    Me.mValor = prmValorDocumento
                    Me.mEsVálido = True

                    Exit Select

                End If

            Case Else

                Me.mEsVálido = False

        End Select

    End Sub

    <Bindable(True)>
    Public ReadOnly Property Tipo As ETipoDocumento
        Get
            Return Me.mTipo
        End Get
    End Property
    <Bindable(True)>
    Public ReadOnly Property Valor As String
        Get
            Return Me.mValor
        End Get
    End Property
    <Bindable(True)>
    Public ReadOnly Property EsVálido As Boolean
        Get
            Return Me.mEsVálido
        End Get
    End Property

    Public Function EsNIFVálido(ByRef Valor As String)
        Return False
    End Function

    Public Function EsCIFVálido(ByRef Valor As String)
        Return False
    End Function

    Public Function EsNIEVálido(ByRef Valor As String)
        Return False
    End Function

    Public Function EsPasaporteVálido(ByRef Valor As String)
        Return False
    End Function

End Class
