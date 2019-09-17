
Imports System.Data
Imports System.Data.SqlClient
Public Class Gastos
    Dim Id_, Nfactura_, Idproveedor_ As Integer
    Dim Monto_, Pago_ As Decimal
    Dim Fecha_, Fechapago_ As Date

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property Nfactura() As Integer
        Get
            Return Nfactura_
        End Get
        Set(ByVal value As Integer)
            Nfactura_ = value
        End Set
    End Property
    Public Property Idproveedor() As Integer
        Get
            Return Idproveedor_
        End Get
        Set(ByVal value As Integer)
            Idproveedor_ = value
        End Set
    End Property
    Public Property Monto() As Decimal
        Get
            Return Monto_
        End Get
        Set(ByVal value As Decimal)
            Monto_ = value
        End Set
    End Property
    Public Property Pago() As Decimal
        Get
            Return Pago_
        End Get
        Set(ByVal value As Decimal)
            Pago_ = value
        End Set
    End Property


    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property


    Public Property Fechapago() As Date
        Get
            Return Fechapago_
        End Get
        Set(ByVal value As Date)
            Fechapago_ = value
        End Set
    End Property


    Public Sub Agregar(ByVal gasto As Gastos)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("ClientesAgregar", conex.sqlconexion)

        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        sqlComando.Parameters.AddWithValue("@Id_proveedor", gasto.Idproveedor)
        sqlComando.Parameters.AddWithValue("@Nro_factura", gasto.Nfactura)
        sqlComando.Parameters.AddWithValue("@monto", gasto.Monto)
        sqlComando.Parameters.AddWithValue("@fecha", gasto.Fecha)
        sqlComando.Parameters.AddWithValue("@pago", gasto.Pago)
        sqlComando.Parameters.AddWithValue("@fecha_pago", gasto.Fechapago)
        sqlComando.ExecuteNonQuery()
        conex.cerrar()

    End Sub

End Class
