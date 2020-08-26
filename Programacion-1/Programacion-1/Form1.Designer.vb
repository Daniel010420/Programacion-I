<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcapital = New System.Windows.Forms.TextBox()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.txttiempo = New System.Windows.Forms.TextBox()
        Me.lblsimple = New System.Windows.Forms.Label()
        Me.lblcompuesto = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Capital"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Interes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(314, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tiempo (Año)"
        '
        'txtcapital
        '
        Me.txtcapital.Location = New System.Drawing.Point(57, 48)
        Me.txtcapital.Name = "txtcapital"
        Me.txtcapital.Size = New System.Drawing.Size(100, 20)
        Me.txtcapital.TabIndex = 4
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(208, 48)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(100, 20)
        Me.txtinteres.TabIndex = 5
        '
        'txttiempo
        '
        Me.txttiempo.Location = New System.Drawing.Point(390, 48)
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(71, 20)
        Me.txttiempo.TabIndex = 6
        '
        'lblsimple
        '
        Me.lblsimple.AutoSize = True
        Me.lblsimple.Location = New System.Drawing.Point(86, 134)
        Me.lblsimple.Name = "lblsimple"
        Me.lblsimple.Size = New System.Drawing.Size(83, 13)
        Me.lblsimple.TabIndex = 7
        Me.lblsimple.Text = "Interes simple: ?"
        '
        'lblcompuesto
        '
        Me.lblcompuesto.AutoSize = True
        Me.lblcompuesto.Location = New System.Drawing.Point(279, 134)
        Me.lblcompuesto.Name = "lblcompuesto"
        Me.lblcompuesto.Size = New System.Drawing.Size(106, 13)
        Me.lblcompuesto.TabIndex = 8
        Me.lblcompuesto.Text = "Interes compuesto: ?"
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(177, 180)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(88, 50)
        Me.btncalcular.TabIndex = 9
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 289)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.lblcompuesto)
        Me.Controls.Add(Me.lblsimple)
        Me.Controls.Add(Me.txttiempo)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.txtcapital)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcapital As TextBox
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents txttiempo As TextBox
    Friend WithEvents lblsimple As Label
    Friend WithEvents lblcompuesto As Label
    Friend WithEvents btncalcular As Button
End Class
