Imports System.Data
Imports System.Data.SqlClient
Public Class ProveedoresClass
    Dim Id_, Telefono_ As Integer
    Dim Nombre_, Direccion_, Localidad_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property
    Public Property Localidad() As String
        Get
            Return Localidad_
        End Get
        Set(ByVal value As String)
            Localidad_ = value
        End Set
    End Property
    Public Property Telefono() As Integer
        Get
            Return Telefono_
        End Get
        Set(ByVal value As Integer)
            Telefono_ = value
        End Set
    End Property


    Public Sub Agregar(ByVal Proveedores As ProveedoresClass)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("ProveedoresAgreagar", conex.sqlconexion)

        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        'sqlComando.Parameters.AddWithValue("@Id", Producto.Id)
        sqlComando.Parameters.AddWithValue("@nombre", Proveedores.Nombre)
        sqlComando.Parameters.AddWithValue("@direccion", Proveedores.Direccion)
        sqlComando.Parameters.AddWithValue("@localidad", Proveedores.Localidad)
        sqlComando.Parameters.AddWithValue("@telefono", Proveedores.Telefono)
       

        sqlComando.ExecuteNonQuery()

        conex.cerrar()

    End Sub
    Public Sub Modificar(ByVal Proveedores As ProveedoresClass)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("proveedoresModificar", conex.sqlconexion)
        conex.abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        sqlComando.Parameters.AddWithValue("@Id", Proveedores.Id)
        sqlComando.Parameters.AddWithValue("@nombre", Proveedores.Nombre)
        sqlComando.Parameters.AddWithValue("@direccion", Proveedores.Direccion)
        sqlComando.Parameters.AddWithValue("@localidad", Proveedores.Localidad)
        sqlComando.Parameters.AddWithValue("@telefono", Proveedores.Telefono)

        sqlComando.ExecuteNonQuery()

        conex.cerrar()

    End Sub

    Public Sub Eliminar(ByVal au_id As String)

        Dim conex As New Conexion
        conex.abrir()

        Dim sqlComando As New SqlCommand("proveedoresEliminar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@Id", Id)
        Try
            sqlComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR EL REGISTRO...!")
        End Try

    End Sub

End Class
