<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGastos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtnfactura = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Labelnfactura = New System.Windows.Forms.Label
        Me.Labelmonto = New System.Windows.Forms.Label
        Me.Labelfecha = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(66, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'txtnfactura
        '
        Me.txtnfactura.Location = New System.Drawing.Point(66, 49)
        Me.txtnfactura.Name = "txtnfactura"
        Me.txtnfactura.Size = New System.Drawing.Size(100, 20)
        Me.txtnfactura.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(260, 7)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(66, 84)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(100, 20)
        Me.txtmonto.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(476, 282)
        Me.DataGridView1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Servicio"
        '
        'Labelnfactura
        '
        Me.Labelnfactura.AutoSize = True
        Me.Labelnfactura.BackColor = System.Drawing.Color.Transparent
        Me.Labelnfactura.ForeColor = System.Drawing.Color.White
        Me.Labelnfactura.Location = New System.Drawing.Point(6, 52)
        Me.Labelnfactura.Name = "Labelnfactura"
        Me.Labelnfactura.Size = New System.Drawing.Size(54, 13)
        Me.Labelnfactura.TabIndex = 7
        Me.Labelnfactura.Text = "N Factura"
        '
        'Labelmonto
        '
        Me.Labelmonto.AutoSize = True
        Me.Labelmonto.BackColor = System.Drawing.Color.Transparent
        Me.Labelmonto.ForeColor = System.Drawing.Color.White
        Me.Labelmonto.Location = New System.Drawing.Point(15, 87)
        Me.Labelmonto.Name = "Labelmonto"
        Me.Labelmonto.Size = New System.Drawing.Size(37, 13)
        Me.Labelmonto.TabIndex = 8
        Me.Labelmonto.Text = "Monto"
        '
        'Labelfecha
        '
        Me.Labelfecha.AutoSize = True
        Me.Labelfecha.BackColor = System.Drawing.Color.Transparent
        Me.Labelfecha.ForeColor = System.Drawing.Color.White
        Me.Labelfecha.Location = New System.Drawing.Point(206, 14)
        Me.Labelfecha.Name = "Labelfecha"
        Me.Labelfecha.Size = New System.Drawing.Size(37, 13)
        Me.Labelfecha.TabIndex = 9
        Me.Labelfecha.Text = "Fecha"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.Black
        Me.btnCancelar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Location = New System.Drawing.Point(380, 442)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 58)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.BackColor = System.Drawing.Color.Black
        Me.BtnAceptar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAceptar.Location = New System.Drawing.Point(24, 442)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(93, 58)
        Me.BtnAceptar.TabIndex = 15
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(317, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 42)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 505)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Labelfecha)
        Me.Controls.Add(Me.Labelmonto)
        Me.Controls.Add(Me.Labelnfactura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtnfactura)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "FormGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormServicios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtnfactura As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Labelnfactura As System.Windows.Forms.Label
    Friend WithEvents Labelmonto As System.Windows.Forms.Label
    Friend WithEvents Labelfecha As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
