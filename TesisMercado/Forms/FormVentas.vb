Imports System.Data
Imports System.Data.SqlClient

Public Class FormVentas

    Dim Venta As New ventaClass
    Dim conex As New Conexion

    'Private Sub LlenarTabla(ByVal tabla As DataGridView)


    '    Dim strComando As String = "ventaLlenarTabla"


    '    Dim sqlComando As New SqlCommand("ventaLlenarTabla", conex.sqlconexion)


    '    sqlComando.CommandType = CommandType.StoredProcedure
    '    conex.abrir()

    '    Dim sqlAdapter As New SqlDataAdapter(sqlComando)
    '    Dim sqlDataTable As New DataTable

    '    sqlAdapter.Fill(sqlDataTable)
    '    tabla.DataSource = sqlDataTable

    '    tabla.Columns("fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    '    conex.cerrar()

    'End Sub



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub

    Private Sub FormVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'LlenarTabla(DataGridView1)

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click



        Dim FormLstProductos As New FormLstProductos

        FormLstProductos.ShowDialog()


        txtIdProducto.Text = FormLstProductos.producto.Id
        txtDescripcion.Text = FormLstProductos.producto.nombre
        txtStock.Text = FormLstProductos.producto.cantidad
        txtPrecio.Text = FormLstProductos.producto.Precio


    End Sub
    'Private Sub Txtidventa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtidventa.TextChanged

    '    Dim FormVenta As New FormVentas


    '    FormVenta.ShowDialog()

    '    Txtidventa.Text = FormVenta.Venta.Id


    'End Sub


    'Private Sub txtnroticket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnroticket.TextChanged
    '    Dim FormVenta As New FormVentas


    '    FormVenta.ShowDialog()
    '    txtnroticket.Text = FormVenta.Venta.nro_ticket
    'End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        txtTotal.Text = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())

    End Sub
End Class