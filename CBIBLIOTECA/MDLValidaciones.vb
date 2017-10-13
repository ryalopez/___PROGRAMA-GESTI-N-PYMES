Imports System
Imports Microsoft.VisualBasic


Public Module MDLValidaciones
    ''' <summary>
    ''' Separa un numero de documento en número y letra e indica si la letra está al principio o al final
    ''' </summary>
    ''' <param name="NúmeroDocumento">Es el original</param>
    ''' <param name="Número">Devuelve el número</param>
    ''' <param name="Letra">Devuelve la letra</param>
    ''' <param name="LetraDespues">Si es true la letra esta al final del número</param>
    ''' <returns></returns>
    Public Function SeparaDocumentoIdentidad(ByVal NúmeroDocumento As String, Optional ByRef Número As Integer = 0, Optional ByRef Letra As String = "", Optional ByRef LetraDespues As Boolean = False) As Boolean

        Dim a As Array = NúmeroDocumento.ToCharArray
        For i = 0 To a.Length - 1

            If Not Char.IsLetterOrDigit(a(i)) Then

                Return False

            ElseIf Char.IsDigit(a(i)) Then

                Número = CInt(Número.ToString + a(i).ToString)

            Else

                Letra = a(i).ToString.ToUpper
                If i = 0 Then

                    LetraDespues = False

                ElseIf i = a.Length - 1 Then

                    LetraDespues = True

                Else

                    Return False

                End If

            End If
        Next

        Return True

    End Function
    ''' <summary>
    ''' Valida un número de DNI o NIF. Primero separa el número de la letra y luego comprueba si la letra es la que corresponde a ese número
    ''' 
    ''' La formula para calcular la letra del DNI y obtener el NIF es la siguiente:
    '''
    '''Tomamos el número completo de hasta 8 cifras de nuestro DNI, lo dividimos entre 23 y nos quedamos con el resto de dicha división, 
    '''o dicho de otro modo, calculamos el módulo 23 del DNI.
    '''
    '''Sea como sea, el resultado anterior es un número entre 0 y 22. A cada uno de estos posibles números le corresponde una letra, 
    '''según la siguiente tabla
    '''
    '''RESTO	0	1	2	3	4	5	6	7	8	9	10	11	12	13	14	15	16	17	18	19	20	21	22
    '''LETRA	T	R	W	A	G	M	Y	F	P	D	X	B	N	J	Z	S	Q	V	H	L	C	K	E
    ''' </summary>
    ''' <param name="NúmeroDocumento"></param>
    ''' <returns></returns>
    Public Function Validar_DNI_NIF(ByRef NúmeroDocumento As String) As Boolean

        Dim número As Integer = 0
        Dim letra As String = ""
        Dim atrás As Boolean = False
        If SeparaDocumentoIdentidad(NúmeroDocumento.ToString, número, letra, atrás) Then
            '
            ' la letra en el DNI y el NIF debe ir atrás
            If atrás = False Then

                Return False

            End If

            Dim l As String = ""
            Dim i As Integer = número Mod 23
            Select Case i
                Case 0
                    l = "T"
                Case 1
                    l = "R"
                Case 2
                    l = "W"
                Case 3
                    l = "A"
                Case 4
                    l = "G"
                Case 5
                    l = "M"
                Case 6
                    l = "Y"
                Case 7
                    l = "F"
                Case 8
                    l = "P"
                Case 9
                    l = "D"
                Case 10
                    l = "X"
                Case 11
                    l = "B"
                Case 12
                    l = "N"
                Case 13
                    l = "J"
                Case 14
                    l = "Z"
                Case 15
                    l = "S"
                Case 16
                    l = "Q"
                Case 17
                    l = "V"
                Case 18
                    l = "H"
                Case 19
                    l = "L"
                Case 20
                    l = "C"
                Case 21
                    l = "K"
                Case 22
                    l = "E"
            End Select

            If l = letra Then

                NúmeroDocumento = número.ToString.PadLeft(8, "0") + letra
                Return True

            Else

                Dim pNúmeroDocumento As String = ""
                pNúmeroDocumento = número.ToString.PadLeft(8, "0") + l

                If MsgPregunta("El número de documento " + NúmeroDocumento + " no es correcto. Debería ser " + pNúmeroDocumento + ". ¿Quiere corregirlo?") = MsgBoxResult.Yes Then
                    NúmeroDocumento = pNúmeroDocumento
                    Return True

                End If

                Return False

            End If

        Else

            MsgErrorCrítico("El número de documento " + NúmeroDocumento + " no es válido.")
            Return False

        End If

        Return False

    End Function
    ''' <summary>
    ''' Separa un numero de documento en primera letra, número y última letra
    ''' </summary>
    ''' <param name="NúmeroDocumento">Es el original</param>
    ''' <param name="Número">Devuelve el número</param>
    ''' <param name="LetraPrimera">Devuelve la letra</param>
    ''' <param name="LetraÚltima">Si es true la letra esta al final del número</param>
    ''' <returns></returns>
    Public Function SeparaDocumentoIdentidad(ByRef NúmeroDocumento As String, Optional ByRef Número As Integer = 0, Optional ByRef LetraPrimera As String = "", Optional ByRef LetraÚltima As String = "") As Boolean

        Dim a As Array = NúmeroDocumento.ToCharArray
        For i = 0 To a.Length - 1

            If Not Char.IsLetterOrDigit(a(i)) Then

                Return False

            ElseIf Char.IsDigit(a(i)) Then

                Número = CInt(Número.ToString + a(i).ToString)

            Else

                If i = 0 Then
                    'TODO Revisar primera letra. Comprobar si es X, Y o Z y poner el primer dígito númerico
                    LetraPrimera = a(i).ToString.ToUpper
                    If LetraPrimera = "X" Then
                        Número = 0
                    ElseIf LetraPrimera = "Y" Then
                        Número = 1
                    ElseIf LetraPrimera = "Z" Then
                        Número = 2

                    End If
                ElseIf i = a.Length - 1 Then

                    LetraÚltima = a(i).ToString.ToUpper

                Else

                    Return False

                End If

            End If
        Next

        If LetraPrimera.Trim.Length = 0 Or LetraÚltima.Trim.Length = 0 Then

            Return False

        End If

        Return True

    End Function
    ''' <summary>
    ''' Valida un número de NIE de extranjeros residentes en españa, que consta de C1234567L C es X, Y o Z
    ''' 
    ''' X8312197C
    ''' 
    ''' Primero se separan el número de la primera y segunda letra y luego comprueba si las letras son las que corresponden a ese número
    ''' 
    ''' La formula para calcular la letra del NIE es la siguiente:
    '''
    '''Tomamos el número completo de hasta 7 cifras de nuestro NIE, lo dividimos entre 23 y nos quedamos con el resto de dicha división, 
    '''o dicho de otro modo, calculamos el módulo 23 del NIE.
    '''
    '''Sea como sea, el resultado anterior es un número entre 0 y 22. A cada uno de estos posibles números le corresponde una letra, 
    '''según la siguiente tabla
    '''
    '''RESTO	0	1	2	3	4	5	6	7	8	9	10	11	12	13	14	15	16	17	18	19	20	21	22
    '''LETRA	T	R	W	A	G	M	Y	F	P	D	X	B	N	J	Z	S	Q	V	H	L	C	K	E
    '''
    ''' El dígito de control (primer dígito) se sustituye 0->X, 1->Y, 2->Z
    ''' </summary>
    ''' <param name="NúmeroDocumento"></param>
    ''' <returns></returns>
    Public Function Validar_NIE(ByRef NúmeroDocumento As String) As Boolean

        Dim número As Integer = 0
        Dim letraPrimera As String = ""
        Dim letraÚltima As String = ""
        If SeparaDocumentoIdentidad(NúmeroDocumento.ToString, número, letraPrimera, letraÚltima) Then

            Dim l1 As String = ""
            Dim l2 As String = ""
            Dim i As Integer = número Mod 23
            Select Case i
                Case 0
                    l1 = "T"
                Case 1
                    l1 = "R"
                Case 2
                    l1 = "W"
                Case 3
                    l1 = "A"
                Case 4
                    l1 = "G"
                Case 5
                    l1 = "M"
                Case 6
                    l1 = "Y"
                Case 7
                    l1 = "F"
                Case 8
                    l1 = "P"
                Case 9
                    l1 = "D"
                Case 10
                    l1 = "X"
                Case 11
                    l1 = "B"
                Case 12
                    l1 = "N"
                Case 13
                    l1 = "J"
                Case 14
                    l1 = "Z"
                Case 15
                    l1 = "S"
                Case 16
                    l1 = "Q"
                Case 17
                    l1 = "V"
                Case 18
                    l1 = "H"
                Case 19
                    l1 = "l1"
                Case 20
                    l1 = "C"
                Case 21
                    l1 = "K"
                Case 22
                    l1 = "E"
                Case Else
                    Throw New Exception("Error en la función Módulo Entero en Validad_NIE")
                    Return False

            End Select

            NúmeroDocumento = número.ToString.PadLeft(8, "0")
            Select Case NúmeroDocumento.Substring(0, 1)
                Case "0"
                    l2 = "X"

                Case "1"
                    l2 = "Y"

                Case "2"
                    l2 = "Z"

                Case Else
                    MsgErrorCrítico("El número de documento " + NúmeroDocumento + " no es válido.")
                    Return False

            End Select
            '
            ' Quitar el primer dígito numérico
            '
            NúmeroDocumento = letraPrimera + NúmeroDocumento.Substring(1)

            Dim pNúmeroDocumento As String = ""
            If l1 = letraÚltima Then

                NúmeroDocumento = NúmeroDocumento + letraÚltima
                Return True

            Else

                pNúmeroDocumento = NúmeroDocumento + l1

            End If

            If MsgPregunta("El número de documento " + NúmeroDocumento + letraÚltima + " no es correcto. Debería ser " + pNúmeroDocumento + ". ¿Quiere corregirlo?") = MsgBoxResult.Yes Then
                NúmeroDocumento = pNúmeroDocumento

                Return True

            End If

        Else

            MsgErrorCrítico("El número de documento " + NúmeroDocumento + " no es válido.")
            Return False

        End If

        Return False
    End Function
    ''' <summary>
    ''' Valida un CIF de extranjeros residentes en españa, que consta de 9 dígitos alfanuméricos con la siguiente estructura: O P P N N N N N C
    ''' O: Tipo de Organización  ; P: Código provincia  ; N: Número correlativo por provincia ; C: Dígito o letra de control
    ''' 
    ''' TIPO DE ORGANIZACION (Letra O)
    ''' A - Sociedad Anónima.	
    ''' B - Sociedad de Responsabilidad Limitada.	
    ''' C - Sociedad Colectiva.
    ''' D - Sociedad Comanditaria.	
    ''' E - Comunidad de Bienes.	
    ''' F - Sociedad Cooperativa.
    ''' G - Asociaciones y otros tipos no definidos.	
    ''' H - Comunidad de propietarios en régimen de propiedad horizontal.	
    ''' K,L,M - Formato Antiguo.
    ''' N - Entidades no residentes.	
    ''' P - Corporación local.	
    ''' Q - Organismo autónomo estatal o no,y asimilados, 
    ''' R - Congregaciones e instituciones religiosas.
    ''' S - Organos de la Administración del Estado y Comunidades Autónomas	 
    ''' 
    ''' 1-64 70-84 92-99 '88 (64 + 15 + 8 =) 87
    ''' 
    ''' </summary>
    ''' <param name="NúmeroDocumento"></param>
    ''' <returns></returns>
    Public Function Validar_CIF(ByRef NúmeroDocumento As String) As Boolean

        Return False
    End Function

End Module
