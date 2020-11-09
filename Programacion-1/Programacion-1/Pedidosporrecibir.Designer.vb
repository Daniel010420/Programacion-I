<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidosporrecibir
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
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnnuevoyaceptar = New System.Windows.Forms.Button()
        Me.btnmodificarycancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.coblaboratorio = New System.Windows.Forms.ComboBox()
        Me.cobpresentacion = New System.Windows.Forms.ComboBox()
        Me.cobmedicamento = New System.Windows.Forms.ComboBox()
        Me.cobproveedor = New System.Windows.Forms.ComboBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(291, 58)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(738, 448)
        Me.grid.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(333, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Filtro:"
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(371, 25)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(346, 20)
        Me.txtfiltro.TabIndex = 38
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnnuevoyaceptar)
        Me.GroupBox2.Controls.Add(Me.btnmodificarycancelar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(-4, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 84)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edicion"
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
        'btnmodificarycancelar
        '
        Me.btnmodificarycancelar.Location = New System.Drawing.Point(95, 28)
        Me.btnmodificarycancelar.Name = "btnmodificarycancelar"
        Me.btnmodificarycancelar.Size = New System.Drawing.Size(87, 45)
        Me.btnmodificarycancelar.TabIndex = 18
        Me.btnmodificarycancelar.Text = "Modificar"
        Me.btnmodificarycancelar.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Codigo)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.coblaboratorio)
        Me.GroupBox1.Controls.Add(Me.cobpresentacion)
        Me.GroupBox1.Controls.Add(Me.cobmedicamento)
        Me.GroupBox1.Controls.Add(Me.cobproveedor)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 325)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Laboratorio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Medicamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Presentacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Proveedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Codigo"
        '
        'Codigo
        '
        Me.Codigo.AutoSize = True
        Me.Codigo.Location = New System.Drawing.Point(6, 259)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(49, 13)
        Me.Codigo.TabIndex = 5
        Me.Codigo.Text = "Cantidad"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(6, 39)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(220, 20)
        Me.txtcodigo.TabIndex = 4
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(6, 276)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(220, 20)
        Me.txtcantidad.TabIndex = 4
        '
        'coblaboratorio
        '
        Me.coblaboratorio.FormattingEnabled = True
        Me.coblaboratorio.Location = New System.Drawing.Point(6, 227)
        Me.coblaboratorio.Name = "coblaboratorio"
        Me.coblaboratorio.Size = New System.Drawing.Size(220, 21)
        Me.coblaboratorio.TabIndex = 3
        '
        'cobpresentacion
        '
        Me.cobpresentacion.FormattingEnabled = True
        Me.cobpresentacion.Location = New System.Drawing.Point(6, 180)
        Me.cobpresentacion.Name = "cobpresentacion"
        Me.cobpresentacion.Size = New System.Drawing.Size(220, 21)
        Me.cobpresentacion.TabIndex = 2
        '
        'cobmedicamento
        '
        Me.cobmedicamento.FormattingEnabled = True
        Me.cobmedicamento.Location = New System.Drawing.Point(6, 130)
        Me.cobmedicamento.Name = "cobmedicamento"
        Me.cobmedicamento.Size = New System.Drawing.Size(220, 21)
        Me.cobmedicamento.TabIndex = 3
        '
        'cobproveedor
        '
        Me.cobproveedor.FormattingEnabled = True
        Me.cobproveedor.Location = New System.Drawing.Point(6, 83)
        Me.cobproveedor.Name = "cobproveedor"
        Me.cobproveedor.Size = New System.Drawing.Size(220, 21)
        Me.cobproveedor.TabIndex = 2
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(31, 39)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 0
        '
        'Pedidosporrecibir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 518)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Pedidosporrecibir"
        Me.Text = "Pedidos Por Recibir"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnnuevoyaceptar As Button
    Friend WithEvents btnmodificarycancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Codigo As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents coblaboratorio As ComboBox
    Friend WithEvents cobpresentacion As ComboBox
    Friend WithEvents cobmedicamento As ComboBox
    Friend WithEvents cobproveedor As ComboBox
    Friend WithEvents txtid As TextBox
End Class
