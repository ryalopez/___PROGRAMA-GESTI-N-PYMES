'
' Enumeraciones de la aplicación
'
Public Enum EForms
    ALBARÁN = 1
    BLANCO = 0
    FACTURA = 3
    RECIBO = 2
End Enum
Public Enum ETiposAsiento

    COMPRA = 1
    REINTEGRO_EFECTIVO = 2
    ADEUDO_TELEPEAJE = 3
    CUOTA_TARJETA = 4
    AMORTIZACIÓN_PRÉSTAMO = 5
    VENTA = 6

End Enum

Public Enum EPrefijosCuenta

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

Public Enum EServidores
    NUBE = 0
    PCRLM = 1
    PCPAPA = 2
    PORTATIL = 3
End Enum

Public Enum ETipoDocumento

    Ninguno = 0
    NIF_DNI = 1
    CIF = 2
    NIE = 3
    Pasaporte = 4

End Enum

Public Enum ETipoListadoClientes

    Todos = 0
    Activos = 1
    Baja = 2
    ActivosFactura = 3
    ActivosRecibo = 4

End Enum

Public Enum ETipoListadoContable
    Diario = 0
    BalanceSumasSaldos = 1
    BalanceSituación = 2
    Mayor = 3
    Balance = 4
End Enum

Public Enum ETipoOrigenDatos
    ODBC = 0
    ADO = 1
End Enum

Public Enum ETipoVía
    CL = 0
    PZA = 1
End Enum


