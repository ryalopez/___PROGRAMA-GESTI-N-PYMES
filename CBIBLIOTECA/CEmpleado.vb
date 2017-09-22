
Public Class CEmpleado

    Public ReadOnly Property id As Integer
        Get
            Return 0
        End Get
    End Property

    Public Property nombrePila As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property apellido1 As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property apellido2 As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public ReadOnly Property NomyAmpe As String
        Get
            Return nombrePila + " " + apellido1.ToUpper + " " + apellido2.ToUpper
        End Get
    End Property

    Public Property tipoDocumentoIdentidad As ETipoDocumento
        Get
            Return ETipoDocumento.NIF_DNI
        End Get
        Set(value As ETipoDocumento)

        End Set
    End Property

    Public Property DocumentoIdentidad As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property tipoVía As ETipoVía
        Get
            Return ETipoVía.CL
        End Get
        Set(value As ETipoVía)

        End Set
    End Property

    Public Property Vía As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Localidad As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property CódigoPostal As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Provincia As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Pais As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public ReadOnly Property DatosBancarios As String
        Get
            Return ""
        End Get
    End Property

    Public Property DBSICA As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property DBEntidad As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property DBSucursal As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property DBDígitoControl As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property DBCuenta As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Empresa As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property CentroTrabajo As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Convenio As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property CategoríaLaboral As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property HorasSemanales As Integer
        Get
            Return ""
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property NúmeroSeguridadSocial As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property GrupoCotización As String
        Get
            Return ""
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property CuentaContable As Integer
        Get
            Return 0
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property Baja As Boolean
        Get
            Return False
        End Get
        Set(value As Boolean)

        End Set
    End Property

End Class
