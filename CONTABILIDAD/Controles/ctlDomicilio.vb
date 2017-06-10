Imports System.ComponentModel

<DefaultEvent("DirecciónIncorrecta")> _
Public Class ctlDomicilio
    Inherits UserControl

    ' Crear eventos
    Public Event DirecciónIncorrecta( _
     ByVal Sender As System.Object, _
     ByVal e As DirecciónNumEventArgs)

    ' Errores
    Public Enum DirNumErrores
        Correcto = 0
        FaltaCalle = 1
        FaltaMunicipio = 2
        FaltaCodPostal = 3
        MalLongitudCodPostal = 4
        FaltaOtrosDatos = 5
    End Enum

    Public Class DirecciónNumEventArgs
        Inherits System.EventArgs

        Private mstrMessage As String
        Private mintError As DirNumErrores

        <Description("Mensaje para mostrar el error")> _
        Property Mensaje() As String
            Get
                Return mstrMessage
            End Get
            Set(ByVal Value As String)
                mstrMessage = Value
            End Set
        End Property

        <Description("NúmeroError")> _
        Property NúmeroError() As DirNumErrores
            Get
                Return mintError
            End Get
            Set(ByVal Value As DirNumErrores)
                mintError = Value
            End Set
        End Property
    End Class


    Private mModificado As Boolean = False
    Public Property Modificado() As Boolean
        Get
            Return Me.mModificado
        End Get
        Set(value As Boolean)
            Me.mModificado = value
        End Set
    End Property
    '
    ' propiedades de diseño
    '
    Private mTítuloControl As String
    <Description("Título para el control, por ejemplo 'Dirección entregas'"), Category("Diseño")> _
    Property TítuloControl() As String
        Get
            Return Me.mTítuloControl
        End Get
        Set(value As String)
            Me.mTítuloControl = value
            Me.GroupBox1.Text = Me.mTítuloControl
        End Set
    End Property

    <Description("Calle del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Calle As String
        Get
            Return CalleTextBox.Text
        End Get
        Set(value As String)
            CalleTextBox.Text = value
        End Set
    End Property

    <Description("Número de la calle"), Category("Domicilio"), Bindable(True)>
    Public Property Número As Integer
        Get
            Return NúmeroTextBox.Text
        End Get
        Set(value As Integer)
            NúmeroTextBox.Text = value
        End Set
    End Property

    <Description("Bloque del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Bloque As String
        Get
            Return BloqueTextBox.Text
        End Get
        Set(value As String)
            BloqueTextBox.Text = value
        End Set
    End Property

    <Description("Escalera del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Escalera As String
        Get
            Return EscaleraTextBox.Text
        End Get
        Set(value As String)
            EscaleraTextBox.Text = value
        End Set
    End Property

    <Description("Piso del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Piso As Integer
        Get
            Return PisoTextBox.Text
        End Get
        Set(value As Integer)
            PisoTextBox.Text = value
        End Set
    End Property

    <Description("Puerta del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Puerta As String
        Get
            Return PuertaTextBox.Text
        End Get
        Set(value As String)
            PuertaTextBox.Text = value
        End Set
    End Property

    <Description("Código de pais del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Pais As String
        Get
            Return PaisesComboBox.SelectedValue
        End Get
        Set(value As String)
            PaisesComboBox.SelectedValue = value
        End Set
    End Property

    <Description("Código de provincia del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Provincia As Integer
        Get
            Return ProvinciasComboBox.SelectedValue
        End Get
        Set(value As Integer)
            ProvinciasComboBox.SelectedValue = value
        End Set
    End Property

    <Description("Municipio del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property Municipio As String
        Get
            Return MunicipioTextBox.Text
        End Get
        Set(value As String)
            MunicipioTextBox.Text = value
        End Set
    End Property

    <Description("Código postal del domicilio"), Category("Domicilio"), Bindable(True)>
    Public Property CodPostal As String
        Get
            Return CodPostalTextBox.Text
        End Get
        Set(value As String)
            CodPostalTextBox.Text = value
        End Set
    End Property

    Private Sub ctlDomicilio_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.PaisesTableAdapter.Fill(Me.BDGeografía.Paises)
        Me.ProvinciasTableAdapter.Fill(Me.BDGeografía.Provincias)

    End Sub

    Private Sub ctlDomicilio_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating

        Dim strMsg As String = ""
        Dim intNum As DirNumErrores = DirNumErrores.Correcto
        Dim eArgs As DirecciónNumEventArgs

        ' Obtener el nombre de la calle       
        '****************************************
        ' Comprobar que el nombre de la calle no está en blanco
        '****************************************
        If CalleTextBox.Text.Length = 0 Then
            intNum = DirNumErrores.FaltaCalle
            strMsg = "La calle no puede quedar en blanco"
        End If

        If intNum = DirNumErrores.Correcto Then

            If MunicipioTextBox.Text.Length = 0 Then

                intNum = DirNumErrores.FaltaMunicipio
                strMsg = "El municipio no puede quedar en blanco"

            End If

        End If

        If intNum = DirNumErrores.Correcto Then

            If CodPostalTextBox.Text.Length = 0 Then

                intNum = DirNumErrores.FaltaCodPostal
                strMsg = "El código postal no puede quedar en blanco"

            ElseIf PaisesComboBox.SelectedValue = "ES" And CodPostalTextBox.Text.Length <> 5 Then

                intNum = DirNumErrores.MalLongitudCodPostal
                strMsg = "El código postal debe tener 5 dígitos numéricos"

            ElseIf PaisesComboBox.SelectedValue = "ES" And Not IsNumeric(CodPostalTextBox.Text) Then

                intNum = DirNumErrores.MalLongitudCodPostal
                strMsg = "Los 5 dígitos del código postal deben ser numéricos"

            End If

        End If

        If intNum = DirNumErrores.Correcto Then

            If NúmeroTextBox.Text.Length = 0 And BloqueTextBox.Text.Length = 0 And EscaleraTextBox.Text.Length = 0 _
                And PisoTextBox.Text.Length = 0 And PuertaTextBox.Text.Length = 0 Then

                intNum = DirNumErrores.FaltaOtrosDatos
                strMsg = "El número, bloque, escalera, piso y puerta del domicilio no pueden quedar todos en blanco"

            End If

        End If

        If intNum <> DirNumErrores.Correcto Then
            ' If message is filled in, raise event
            eArgs = New DirecciónNumEventArgs
            eArgs.NúmeroError = intNum
            eArgs.Mensaje = strMsg

            e.Cancel = True

            RaiseEvent DirecciónIncorrecta(Me, eArgs)

        End If

    End Sub

    Public Sub CargarDatos(prmCalle As String, prmNúmero As String, prmBloque As String, prmEscalera As String, prmPiso As String, _
                           prmPuerta As String, prmPais As String, prmProvincia As Integer, prmMunicipio As String, prmCodPostal As String)

        With Me

            .Calle = prmCalle
            .Número = prmNúmero
            .Bloque = prmBloque
            .Escalera = prmEscalera
            .Piso = prmPiso
            .Puerta = prmPuerta
            .Pais = prmPais
            .Provincia = prmProvincia
            .Municipio = prmMunicipio
            .CodPostal = prmCodPostal

        End With

    End Sub

End Class
