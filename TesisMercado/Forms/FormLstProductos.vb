Imports System.Data
Imports System.Data.SqlClient
Public Class FormLstProductos

    Private producto_ As New productosClass

    Public Property producto() As productosClass
        Get
            Return producto_
        End Get
        Set(ByVal value As productosClass)
            producto_ = value
        End Set
    End Property

    Dim Pro As New productosClass
    Dim conex As New Conexion

    ' Dim FormLstProductos As New FormLstProductos

    'FormLstProductos.ShowDialog

    ' txtProducto = FormLstProductos.nombre


    Private Sub FormLstProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LlenarTabla(DataGridView1)

    End Sub

    Private Sub LlenarTabla(ByVal tabla As DataGridView)


        Dim strComando As String = "productosLlenarTabla"


        Dim sqlComando As New SqlCommand("productosLlenarTabla", conex.sqlconexion)


        sqlComando.CommandType = CommandType.StoredProcedure
        conex.abrir()

        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqlDataTable As New DataTable

        sqlAdapter.Fill(sqlDataTable)
        tabla.DataSource = sqlDataTable


        tabla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("precio_venta").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        conex.cerrar()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        producto.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        producto.nombre = DataGridView1.Item("nombre", DataGridView1.CurrentRow.Index).Value
        producto.cantidad = DataGridView1.Item("cantidad", DataGridView1.CurrentRow.Index).Value
        producto.Precio = DataGridView1.Item("Precio", DataGridView1.CurrentRow.Index).Value
        Close()
    End Sub
End Class