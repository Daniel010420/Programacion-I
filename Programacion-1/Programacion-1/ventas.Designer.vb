<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventas
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
        Me.btnnuevoyaceptar = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnuevoyaceptar
        '
        Me.btnnuevoyaceptar.Location = New System.Drawing.Point(450, 6)
        Me.btnnuevoyaceptar.Name = "btnnuevoyaceptar"
        Me.btnnuevoyaceptar.Size = New System.Drawing.Size(84, 30)
        Me.btnnuevoyaceptar.TabIndex = 44
        Me.btnnuevoyaceptar.Text = "Seleccionar"
        Me.btnnuevoyaceptar.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid.Location = New System.Drawing.Point(18, 63)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(772, 380)
        Me.grid.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Filtro:"
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(98, 12)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(346, 20)
        Me.txtfiltro.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 45
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 467)
        Me.Controls.Add(Me.btnnuevoyaceptar)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnuevoyaceptar As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents Label1 As Label
End Class
