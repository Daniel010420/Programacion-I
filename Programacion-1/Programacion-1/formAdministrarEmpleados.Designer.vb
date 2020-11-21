<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAdministrarEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdui = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnmodificarycancelar = New System.Windows.Forms.Button()
        Me.btnnuevoyaceptar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdui)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 333)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos De Empleados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "IDEmpleado"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(19, 40)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 26
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(19, 205)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(220, 96)
        Me.txtdireccion.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Direccion "
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(19, 164)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(150, 20)
        Me.txttelefono.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Telefono"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(19, 123)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(220, 20)
        Me.txtcorreo.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Correo"
        '
        'txtdui
        '
        Me.txtdui.Location = New System.Drawing.Point(19, 82)
        Me.txtdui.Name = "txtdui"
        Me.txtdui.Size = New System.Drawing.Size(150, 20)
        Me.txtdui.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "DUI"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(19, 41)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(220, 20)
        Me.txtnombre.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre Completo"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(187, 29)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(84, 44)
        Me.btneliminar.TabIndex = 17
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnmodificarycancelar
        '
        Me.btnmodificarycancelar.Location = New System.Drawing.Point(95, 28)
        Me.btnmodificarycancelar.Name = "btnmodificarycancelar"
        Me.btnmodificarycancelar.Size = New System.Drawing.Size(87, 45)
        Me.btnmodificarycancelar.TabIndex = 18
        Me.btnmodificarycancelar.Text = "Modificar"
        Me.btnmodificarycancelar.UseVisualStyleBackColor = True
        '
        'btnnuevoyaceptar
        '
        Me.btnnuevoyaceptar.Location = New System.Drawing.Point(6, 28)
        Me.btnnuevoyaceptar.Name = "btnnuevoyaceptar"
        Me.btnnuevoyaceptar.Size = New System.Drawing.Size(84, 45)
        Me.btnnuevoyaceptar.TabIndex = 19
        Me.btnnuevoyaceptar.Text = "Nuevo"
        Me.btnnuevoyaceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnnuevoyaceptar)
        Me.GroupBox2.Controls.Add(Me.btnmodificarycancelar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 351)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 84)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edicion"
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(381, 25)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(346, 20)
        Me.txtfiltro.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Filtro:"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(301, 51)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(651, 442)
        Me.grid.TabIndex = 30
        '
        'formAdministrarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(964, 506)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "formAdministrarEmpleados"
        Me.Text = "Empleados "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificarycancelar As Button
    Friend WithEvents btnnuevoyaceptar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdui As TextBox
    Friend WithEvents Label3 As Label
End Class
