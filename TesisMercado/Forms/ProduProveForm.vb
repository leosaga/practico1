﻿Public Class ProduProveForm

    Dim ProduProve As New ProductoPorProveedor
    Private producto_ As New Productos
    Private esNuevo_ As Boolean
    Dim func As New Funciones

    Public Property producto() As Productos
        Get
            Return producto_
        End Get
        Set(ByVal value As Productos)
            producto_ = value
        End Set
    End Property

    Public Property esNuevo() As Boolean
        Get
            Return esNuevo_
        End Get
        Set(ByVal value As Boolean)
            esNuevo_ = value
        End Set
    End Property

    Public Sub New(ByVal pro As Productos)

        InitializeComponent()
        producto = pro
        esNuevo = False

    End Sub

    Public Sub New()

        InitializeComponent()
        producto.id = 0
        producto.nombre = ""
        producto.codigo = 0
        producto.unidad = ""
        producto.cantidad = 0
        producto.Precio = 0
        esNuevo = True

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click


        Dim proveedoresSeleccionados As New List(Of Proveedores)
        Dim LstProveedores As New LstProveedores(proveedoresSeleccionados)
        lstProveedores.ShowDialog()

        'aluMateria.listaAlumnosMaterias(materia.id, alumnosSeleccionados, dgvAlumnosMateria)
        'ProduProve.listaProductosProveedores(producto.id, proveedoresSeleccionados, dgvProduProve)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If func.validarCampos(Me, ErrorProvider1) Then

            producto.nombre = txtNombre.Text
            producto.codigo = txtCodigo.Text
            producto.unidad = txtUnidad.Text
            producto.cantidad = txtCantidad.Text
            producto.Precio = txtPrecio.Text

            If esNuevo Then
                producto.id = producto.Agregar(producto)

            Else

                'producto.id = txtid.Text
                producto.Modificar(producto)


            End If

            ProduProve.ActualizarTablas(dgvProduProve, producto.id)

            Me.Close()

        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        For Each ProduProve As DataGridViewRow In dgvProduProve.SelectedRows

            ProduProve.Cells("paraBorrar").Value = True
            dgvProduProve.CurrentCell = Nothing
            ProduProve.Visible = False

        Next


    End Sub

    Private Sub ProduProveForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombre.Text = producto.nombre
        txtCodigo.Text = producto.codigo
        txtUnidad.Text = producto.unidad
        txtCantidad.Text = producto.cantidad
        txtPrecio.Text = producto.Precio
        txtid.Text = producto.id

        ProduProve.Consultar(producto.id, dgvProduProve)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub
End Class