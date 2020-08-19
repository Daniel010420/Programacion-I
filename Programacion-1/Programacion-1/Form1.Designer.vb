<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lsttabla = New System.Windows.Forms.ListBox()
        Me.txttabla = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsttabla
        '
        Me.lsttabla.FormattingEnabled = True
        Me.lsttabla.Location = New System.Drawing.Point(153, 26)
        Me.lsttabla.Name = "lsttabla"
        Me.lsttabla.Size = New System.Drawing.Size(161, 186)
        Me.lsttabla.TabIndex = 7
        '
        'txttabla
        '
        Me.txttabla.Location = New System.Drawing.Point(52, 23)
        Me.txttabla.Name = "txttabla"
        Me.txttabla.Size = New System.Drawing.Size(62, 20)
        Me.txttabla.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tabla:"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(12, 49)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(115, 80)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 253)
        Me.Controls.Add(Me.lsttabla)
        Me.Controls.Add(Me.txttabla)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablas de multiplicar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsttabla As ListBox
    Friend WithEvents txttabla As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerar As Button
End Class
