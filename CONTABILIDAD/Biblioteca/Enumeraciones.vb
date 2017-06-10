'
' Enumeraciones de la aplicación
'
Public Enum eForms
    ALBARÁN = 1
    BLANCO = 0
    FACTURA = 3
    RECIBO = 2
End Enum
Public Enum eTiposAsiento

    Ninguno = 0
    FACTURA_PROVEEDOR = 1
    PAGO_FACTURA_CAJA = 2
    PAGO_FACTURA_BANCO = 3

End Enum

Public Enum ePrefijosCuenta

    Ninguno = 0
    ASESORÍA = 1
    CAFETERÍA = 2
    CLIENTES = 3
    FARMACIA = 4
    FERRETERÍA = 5
    COMBUSTIBLE = 6
    INFORMÁTICA = 7
    LEASING = 8
    NOTARÍA = 9
    PAPELERÍA = 10
    PARKING = 11
    PASTELERÍA = 12
    PROVEEDORES = 13
    RESTAURANTE = 14
    SEGUROS = 15
    SUPERMERCADO = 16
    TALLERES = 17
    TAXIS = 18
    TRANSPORTES = 19

End Enum

Public Enum eServidores
    NUBE = 0
    PCRLM = 1
    PCPAPA = 2
    PORTATIL = 3
End Enum

Public Enum eTipoDocumento

    Ninguno = 0
    NIF = 1
    CIF = 2
    NIE = 3
    Pasaporte = 4

End Enum

Public Enum eTipoListadoClientes

    Todos = 0
    Activos = 1
    Baja = 2
    ActivosFactura = 3
    ActivosRecibo = 4

End Enum

Public Enum eTipoListadoContable
    Diario = 0
    BalanceSumasSaldos = 1
    BalanceSituación = 2
    Mayor = 3
    Balance = 4
End Enum

Public Enum eTipoOrigenDatos
    ODBC = 0
    ADO = 1
End Enum

Public Enum eTipoVía
    CL = 0
    PZA = 1
End Enum


