﻿Imports System.Data
Imports System.Data.SqlClient
Public Class ProductoPorProveedor
    Inherits Conexion
    Dim id_, idProducto_, idProveedor_ As Integer
    Private nombreProveedor_ As String 'Esta propiedad se usa solo en el dataGridView
    Private paraBorrar_ As Boolean 'Esta propiedad se usa solo en el dataGridView

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set

    End Property

    Public Property idProducto() As Integer
        Get
            Return idProducto_
        End Get
        Set(ByVal value As Integer)
            idProducto_ = value
        End Set
    End Property


    Public Property idProveedor() As Integer
        Get
            Return idProveedor_
        End Get
        Set(ByVal value As Integer)
            idProveedor_ = value
        End Set
    End Property

    Public Property nombreProveedor() As String
        Get
            Return nombreProveedor_
        End Get
        Set(ByVal value As String)
            nombreProveedor_ = value
        End Set
    End Property

    Public Property paraBorrar() As String
        Get
            Return paraBorrar_
        End Get
        Set(ByVal value As String)
            paraBorrar_ = value
        End Set
    End Property

    Public Sub listaProductosProveedores(ByVal idProducto As Integer, ByVal listaProveedores As List(Of ProveedoresClass), ByVal lista As DataGridView)
        Dim listaProduProve As New List(Of ProductoPorProveedor)
        For Each fila As DataGridViewRow In lista.Rows

            Dim ProduProve As New ProductoPorProveedor
            ProduProve.id = fila.Cells("id").Value
            ProduProve.idProducto = fila.Cells("idProducto").Value
            ProduProve.idProveedor = fila.Cells("idProveedor").Value
            ProduProve.nombreProveedor = fila.Cells("nombreProveedor").Value
            ProduProve.paraBorrar = fila.Cells("paraBorrar").Value
            listaProduProve.Add(ProduProve)
        Next

        For Each pro As ProveedoresClass In listaProveedores
            Dim ProduProve As New ProductoPorProveedor

            ProduProve.id = 0
            ProduProve.idProveedor = pro.Id
            ProduProve.idProducto = idProducto
            ProduProve.nombreProveedor = pro.Nombre

            listaProduProve.Add(ProduProve)
        Next
        lista.DataSource = listaProduProve

        For Each fila As DataGridViewRow In lista.Rows
            If fila.Cells("paraBorrar").Value = True Then
                fila.DataGridView.CurrentCell = Nothing
                fila.Visible = False
            End If
        Next


        lista.Columns("id").Width = 30
        lista.Columns("idProveedor").Visible = False
        lista.Columns("idProducto").Visible = False
        lista.Columns("nombreProveedor").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        lista.Columns("paraBorrar").Width = 30
    End Sub

    Public Sub ActualizarTablas(ByVal listaProduProve As DataGridView, ByVal idProducto As Integer)
        For Each fila As DataGridViewRow In listaProduProve.Rows
            If fila.Cells("id").Value = 0 And fila.Cells("paraBorrar").Value = False Then

                Dim ProduProve As New ProductoPorProveedor
                ProduProve.idProveedor = fila.Cells("idProveedor").Value
                ProduProve.idProducto = idProducto
                ProduProve.Agregar(ProduProve)
                '¿Controlar si el proveedor está repetido?
            End If
            If fila.Cells("id").Value <> 0 And fila.Cells("paraBorrar").Value = True Then
                Dim ProduProve As New ProductoPorProveedor
                ProduProve.id = fila.Cells("id").Value
                ProduProve.Borrar(ProduProve)
            End If
        Next
    End Sub

    Public Sub Agregar(ByVal ProduProve As ProductoPorProveedor)
        Dim conex As New Conexion
        Dim sqlComando As New SqlCommand("ProduProveAgregar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@idProveedor", ProduProve.idProveedor)
        sqlComando.Parameters.AddWithValue("@idProducto", ProduProve.idProducto)
        sqlComando.ExecuteNonQuery()
        
    End Sub

    Public Sub Borrar(ByVal ProduProve As ProductoPorProveedor)
       Dim conex As New Conexion
        Dim sqlComando As New SqlCommand("ProduProveBorrar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@id", ProduProve.id)
        sqlComando.ExecuteNonQuery()
        
    End Sub

    Public Sub Consultar(ByVal idProducto As Integer, ByVal lista As DataGridView)
        Dim conex As New Conexion
        Dim sqlComando As New SqlCommand("ProduProveConsultar", conex.sqlconexion)
        sqlComando.CommandType = CommandType.StoredProcedure
        sqlComando.Parameters.AddWithValue("@idProducto", idProducto)

        'If sqlComando.ExecuteNonQuery Then
        '    Dim sqlDataAdapter As New SqlDataAdapter(sqlComando)
        '    Dim sqlDataTable As New Data.DataTable
        '    sqlDataAdapter.Fill(sqlDataTable)
        '    If sqlDataTable.Rows.Count > 0 Then
        '        lista.DataSource = sqlDataTable
        '        lista.Columns("id").Width = 40
        '        lista.Columns("idProducto").Visible = False
        '        lista.Columns("idProveedor").Visible = False
        '        lista.Columns("nombreProveedor").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        '        lista.Columns("paraBorrar").Width = 30
        '    Else
        '        lista.DataSource = Nothing
        '    End If
        'End If
       
       
    End Sub



End Class

