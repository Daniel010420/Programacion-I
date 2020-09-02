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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.txtunidad = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(423, 384)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnlimpiar)
        Me.TabPage1.Controls.Add(Me.btncalcular)
        Me.TabPage1.Controls.Add(Me.txtresultado)
        Me.TabPage1.Controls.Add(Me.txtunidad)
        Me.TabPage1.Controls.Add(Me.txtcantidad)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(415, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mi conversor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(35, 151)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(91, 53)
        Me.btncalcular.TabIndex = 18
        Me.btncalcular.Text = "calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txtresultado
        '
        Me.txtresultado.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresultado.Location = New System.Drawing.Point(90, 106)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(127, 26)
        Me.txtresultado.TabIndex = 17
        '
        'txtunidad
        '
        Me.txtunidad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunidad.Location = New System.Drawing.Point(90, 66)
        Me.txtunidad.Name = "txtunidad"
        Me.txtunidad.Size = New System.Drawing.Size(127, 26)
        Me.txtunidad.TabIndex = 16
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(90, 20)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(127, 26)
        Me.txtcantidad.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Resultado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Unidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cantidad:"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(415, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Area (Superficie)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(148, 151)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(91, 53)
        Me.btnlimpiar.TabIndex = 19
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 408)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parcial I"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents txtunidad As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnlimpiar As Button
End Class
