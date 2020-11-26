<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtususario = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Contraseña"
        '
        'txtususario
        '
        Me.txtususario.Location = New System.Drawing.Point(70, 133)
        Me.txtususario.Name = "txtususario"
        Me.txtususario.Size = New System.Drawing.Size(166, 20)
        Me.txtususario.TabIndex = 10
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(70, 211)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(166, 20)
        Me.txtpass.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Programacion_1.My.Resources.Resources.login
        Me.ClientSize = New System.Drawing.Size(310, 391)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtususario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtususario As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Button1 As Button
End Class
