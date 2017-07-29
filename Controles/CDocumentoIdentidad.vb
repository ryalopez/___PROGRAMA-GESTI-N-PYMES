Imports System.ComponentModel
Imports Biblioteca

<Bindable(True)>
Public Class CDocumentoIdentidad

    Private mTipo As eTipoDocumento
    Private mValor As String
    Private mEsVálido As Boolean

    Sub New(prmTipo As eTipoDocumento, prmValorDocumento As String)

        Select Case prmTipo
            Case eTipoDocumento.Ninguno
                Me.mTipo = prmTipo
                Me.mValor = prmValorDocumento
                Me.mEsVálido = True

                Exit Select

            Case eTipoDocumento.NIF_DNI
                If EsNIFVálido(prmValorDocumento) Then
                    Me.mTipo = prmTipo
                    Me.mValor = prmValorDocumento
                    Me.mEsVálido = True

                    Exit Select

                End If

            Case eTipoDocumento.CIF
                If EsCIFVálido(prmValorDocumento) Then
                    Me.mTipo = prmTipo
                    Me.mValor = prmValorDocumento
                    Me.mEsVálido = True

                    Exit Select

                End If

            Case eTipoDocumento.NIE
                If EsNIEVálido(prmValorDocumento) Then
                    Me.mTipo = prmTipo
                    Me.mValor = prmValorDocumento
                    Me.mEsVálido = True

                    Exit Select

                End If

            Case eTipoDocumento.Pasaporte
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
    Public ReadOnly Property Tipo As eTipoDocumento
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
