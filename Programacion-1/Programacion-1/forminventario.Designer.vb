<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forminventario
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnnuevoregistro = New System.Windows.Forms.Button()
        Me.btnmodificarregistro = New System.Windows.Forms.Button()
        Me.btneliminarregistro = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtunidadespresentacion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtvencelote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpresentacion = New System.Windows.Forms.TextBox()
        Me.txtpreciopresentacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlab = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.btnnuevoregistro)
        Me.GroupBox2.Controls.Add(Me.btnmodificarregistro)
        Me.GroupBox2.Controls.Add(Me.btneliminarregistro)
        Me.GroupBox2.Location = New System.Drawing.Point(73, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 84)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edicion"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(277, 29)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(84, 44)
        Me.btnbuscar.TabIndex = 20
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnnuevoregistro
        '
        Me.btnnuevoregistro.Location = New System.Drawing.Point(6, 28)
        Me.btnnuevoregistro.Name = "btnnuevoregistro"
        Me.btnnuevoregistro.Size = New System.Drawing.Size(84, 45)
        Me.btnnuevoregistro.TabIndex = 19
        Me.btnnuevoregistro.Text = "Nuevo"
        Me.btnnuevoregistro.UseVisualStyleBackColor = True
        '
        'btnmodificarregistro
        '
        Me.btnmodificarregistro.Location = New System.Drawing.Point(95, 28)
        Me.btnmodificarregistro.Name = "btnmodificarregistro"
        Me.btnmodificarregistro.Size = New System.Drawing.Size(87, 45)
        Me.btnmodificarregistro.TabIndex = 18
        Me.btnmodificarregistro.Text = "Modificar"
        Me.btnmodificarregistro.UseVisualStyleBackColor = True
        '
        'btneliminarregistro
        '
        Me.btneliminarregistro.Location = New System.Drawing.Point(187, 29)
        Me.btneliminarregistro.Name = "btneliminarregistro"
        Me.btneliminarregistro.Size = New System.Drawing.Size(84, 44)
        Me.btneliminarregistro.TabIndex = 17
        Me.btneliminarregistro.Text = "Eliminar"
        Me.btneliminarregistro.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtunidadespresentacion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtvencelote)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtpresentacion)
        Me.GroupBox1.Controls.Add(Me.txtpreciopresentacion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtlab)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtproveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 325)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(11, 38)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(209, 20)
        Me.txtid.TabIndex = 78
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "ID"
        '
        'txtunidadespresentacion
        '
        Me.txtunidadespresentacion.Location = New System.Drawing.Point(292, 87)
        Me.txtunidadespresentacion.Name = "txtunidadespresentacion"
        Me.txtunidadespresentacion.Size = New System.Drawing.Size(209, 20)
        Me.txtunidadespresentacion.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(292, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Unidades por presentación"
        '
        'txtvencelote
        '
        Me.txtvencelote.Location = New System.Drawing.Point(9, 289)
        Me.txtvencelote.Name = "txtvencelote"
        Me.txtvencelote.Size = New System.Drawing.Size(209, 20)
        Me.txtvencelote.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Vencimiento del lote"
        '
        'txtpresentacion
        '
        Me.txtpresentacion.Location = New System.Drawing.Point(9, 240)
        Me.txtpresentacion.Multiline = True
        Me.txtpresentacion.Name = "txtpresentacion"
        Me.txtpresentacion.Size = New System.Drawing.Size(209, 20)
        Me.txtpresentacion.TabIndex = 70
        '
        'txtpreciopresentacion
        '
        Me.txtpreciopresentacion.Location = New System.Drawing.Point(292, 38)
        Me.txtpreciopresentacion.Multiline = True
        Me.txtpreciopresentacion.Name = "txtpreciopresentacion"
        Me.txtpreciopresentacion.Size = New System.Drawing.Size(209, 20)
        Me.txtpreciopresentacion.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(292, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Precios por presentacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Presentación"
        '
        'txtlab
        '
        Me.txtlab.Location = New System.Drawing.Point(9, 189)
        Me.txtlab.Name = "txtlab"
        Me.txtlab.Size = New System.Drawing.Size(209, 20)
        Me.txtlab.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Laboratorio"
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(9, 138)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(209, 20)
        Me.txtproveedor.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Proveedor"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(9, 87)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(209, 20)
        Me.txtnombre.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Nombre del medicamiento"
        '
        'forminventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 462)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "forminventario"
        Me.Text = "Inventario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnnuevoregistro As Button
    Friend WithEvents btnmodificarregistro As Button
    Friend WithEvents btneliminarregistro As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtunidadespresentacion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtvencelote As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtpresentacion As TextBox
    Friend WithEvents txtpreciopresentacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlab As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label10 As Label
End Class
