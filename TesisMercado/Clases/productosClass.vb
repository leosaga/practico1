Imports System.Data
Imports System.Data.SqlClient
Public Class productosClass
    Dim Id_, id_Rubro_, codigo_, cantidad_, Ganancia_, Precio_, precio_venta_ As Integer
    Dim nombre_, unidad_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property id_Rubro() As Integer
        Get
            Return id_Rubro_
        End Get
        Set(ByVal value As Integer)
            id_Rubro_ = value
        End Set
    End Property

    Public Property codigo() As Integer
        Get
            Return codigo_
        End Get
        Set(ByVal value As Integer)
            codigo_ = value
        End Set
    End Property

    Public Property cantidad() As Integer
        Get
            Return cantidad_
        End Get
        Set(ByVal value As Integer)
            cantidad_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Property unidad() As String
        Get
            Return unidad_
        End Get
        Set(ByVal value As String)
            unidad_ = value
        End Set
    End Property

    Public Property Ganancia() As Integer
        Get
            Return Ganancia_
        End Get
        Set(ByVal value As Integer)
            Ganancia_ = value
        End Set
    End Property

    Public Property Precio() As Integer
        Get
            Return Precio_
        End Get
        Set(ByVal value As Integer)
            Precio_ = value
        End Set
    End Property

    Public Property precio_venta() As Integer
        Get
            Return precio_venta_
        End Get
        Set(ByVal value As Integer)
            precio_venta_ = value
        End Set
    End Property

    Public Sub ConsultarProducto(ByVal listado As DataGridView)
        Dim conex As New Conexion
        Dim objComando As New SqlCommand("ConsultarProducto", conex.sqlconexion)
        objComando.CommandType = CommandType.StoredProcedure

    End Sub


    Public Function Agregar(ByVal Producto As productosClass)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("productosAgregar", conex.sqlconexion)

        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        'sqlComando.Parameters.AddWithValue("@Id", Producto.Id)
        sqlComando.Parameters.AddWithValue("@nombre", Producto.nombre)
        sqlComando.Parameters.AddWithValue("@unidad", Producto.unidad)
        sqlComando.Parameters.AddWithValue("@codigo", Producto.codigo)
        sqlComando.Parameters.AddWithValue("@Precio", Producto.Precio)
        sqlComando.Parameters.AddWithValue("@cantidad", Producto.cantidad)
        'sqlComando.Parameters.AddWithValue("@id_Rubro", Producto.id_Rubro)
        sqlComando.Parameters.AddWithValue("@Ganancia", Producto.Ganancia)
        sqlComando.Parameters.AddWithValue("@precio_venta", Producto.precio_venta)


        Return sqlComando.ExecuteNonQuery()
        conex.cerrar()

    End Function

    Public Sub Modificar(ByVal Producto As productosClass)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("productosModificar", conex.sqlconexion)
        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        sqlComando.Parameters.AddWithValue("@Id", Producto.Id)
        sqlComando.Parameters.AddWithValue("@nombre", Producto.nombre)
        sqlComando.Parameters.AddWithValue("@unidad", Producto.unidad)
        sqlComando.Parameters.AddWithValue("@codigo", Producto.codigo)
        sqlComando.Parameters.AddWithValue("@Precio", Producto.Precio)
        sqlComando.Parameters.AddWithValue("@cantidad", Producto.cantidad)
        'sqlComando.Parameters.AddWithValue("@id_Rubro", Producto.id_Rubro)
        sqlComando.Parameters.AddWithValue("@Ganancia", Producto.Ganancia)
        sqlComando.Parameters.AddWithValue("@precio_venta", Producto.precio_venta)


        sqlComando.ExecuteNonQuery()


        conex.cerrar()

    End Sub


    Public Sub Eliminar(ByVal idProducto As Integer)

        Dim conex As New Conexion
        conex.abrir()

        Dim sqlComando As New SqlCommand("productosEliminar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@Id", idProducto)
        Try
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub

End Class
