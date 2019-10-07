Imports System.Data
Imports System.Data.SqlClient
Public Class LstProveedores

    Dim conex As New Conexion

    Private listaProveedores_ As List(Of Proveedores)

    Public Property listaProveedores() As List(Of Proveedores)
        Get
            Return listaProveedores_
        End Get
        Set(ByVal value As List(Of Proveedores))
            listaProveedores_ = value
        End Set
    End Property

    Private Sub LlenarTabla(ByVal tabla As DataGridView)


        Dim strComando As String = "proveedoresLlenarTabla"


        Dim sqlComando As New SqlCommand("proveedoresLlenarTabla", conex.sqlconexion)


        sqlComando.CommandType = CommandType.StoredProcedure
        conex.abrir()

        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqlDataTable As New DataTable

        sqlAdapter.Fill(sqlDataTable)
        tabla.DataSource = sqlDataTable
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Localidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        conex.cerrar()

    End Sub

    Public Sub New(ByRef lisProveedores As List(Of Proveedores))
        InitializeComponent()
        listaProveedores = lisProveedores
    End Sub

    Dim proveedor As New Proveedores


    Private Sub LstProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        proveedor.ConsultarProveedor(dgvProveedores)

        LlenarTabla(dgvProveedores)

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        For Each proveedor As DataGridViewRow In dgvProveedores.SelectedRows
            Dim proveedores As New Proveedores

            proveedores.Id = proveedor.Cells("id").Value
            proveedores.nombre = proveedor.Cells("nombre").Value
            proveedores.telefono = proveedor.Cells("telefono").Value
            proveedores.direccion = proveedor.Cells("direccion").Value
            proveedores.localidad = proveedor.Cells("localidad").Value

            listaProveedores.Add(proveedores)
        Next
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub
End Class