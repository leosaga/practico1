﻿Imports System.Data
Imports System.Data.SqlClient
Public Class LstProductos

    Dim producto As New productosClass
    Dim conex As New Conexion

    Private Sub LstProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        producto.ConsultarProducto(dgvProductos)

        LlenarTabla(dgvProductos)

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



        tabla.Columns("precio_venta").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        conex.cerrar()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim ProduProveForm As New ProduProveForm()
        ProduProveForm.ShowDialog()
        producto.ConsultarProducto(dgvProductos)

    End Sub


    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        producto.id = dgvProductos.Item("id", dgvProductos.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿esta seguro de eliminar  " & producto.id.ToString & "?", "advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then
            producto.Eliminar(producto.Id)
        End If
        producto.ConsultarProducto(dgvProductos)
    End Sub

    Public Sub ModificarProducto()
        producto.id = dgvProductos.Item("id", dgvProductos.CurrentRow.Index).Value
        producto.nombre = dgvProductos.Item("nombre", dgvProductos.CurrentRow.Index).Value
        producto.codigo = dgvProductos.Item("codigo", dgvProductos.CurrentRow.Index).Value
        producto.unidad = dgvProductos.Item("unidad", dgvProductos.CurrentRow.Index).Value
        producto.cantidad = dgvProductos.Item("cantidad", dgvProductos.CurrentRow.Index).Value
        producto.Precio = dgvProductos.Item("precio", dgvProductos.CurrentRow.Index).Value

        Dim ProduProveForm As New ProduProveForm(producto)
        ProduProveForm.ShowDialog()
        producto.ConsultarProducto(dgvProductos)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        ModificarProducto()

    End Sub

    Private Sub dgvProductos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick

        ModificarProducto()

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Close()

    End Sub

End Class