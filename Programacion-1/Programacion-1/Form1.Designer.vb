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
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.cobtipodeconversion = New System.Windows.Forms.ComboBox()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cobdato2 = New System.Windows.Forms.ComboBox()
        Me.cobdato1 = New System.Windows.Forms.ComboBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btncalcular
        '
        Me.btncalcular.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(40, 159)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(100, 27)
        Me.btncalcular.TabIndex = 22
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'cobtipodeconversion
        '
        Me.cobtipodeconversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobtipodeconversion.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobtipodeconversion.FormattingEnabled = True
        Me.cobtipodeconversion.Items.AddRange(New Object() {"Monedas", "Masa", "Volumen", "Longitud", "Almacenamiento", "Tiempo"})
        Me.cobtipodeconversion.Location = New System.Drawing.Point(40, 89)
        Me.cobtipodeconversion.Name = "cobtipodeconversion"
        Me.cobtipodeconversion.Size = New System.Drawing.Size(121, 24)
        Me.cobtipodeconversion.TabIndex = 21
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.BackColor = System.Drawing.SystemColors.Control
        Me.lblresultado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresultado.Location = New System.Drawing.Point(245, 166)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(0, 15)
        Me.lblresultado.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Resultado:"
        '
        'cobdato2
        '
        Me.cobdato2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobdato2.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobdato2.FormattingEnabled = True
        Me.cobdato2.Location = New System.Drawing.Point(350, 89)
        Me.cobdato2.Name = "cobdato2"
        Me.cobdato2.Size = New System.Drawing.Size(145, 24)
        Me.cobdato2.TabIndex = 18
        '
        'cobdato1
        '
        Me.cobdato1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobdato1.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobdato1.FormattingEnabled = True
        Me.cobdato1.Location = New System.Drawing.Point(184, 89)
        Me.cobdato1.Name = "cobdato1"
        Me.cobdato1.Size = New System.Drawing.Size(151, 24)
        Me.cobdato1.TabIndex = 17
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcantidad.Location = New System.Drawing.Point(36, 25)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(153, 19)
        Me.lblcantidad.TabIndex = 16
        Me.lblcantidad.Text = "Cantidad a convertir"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(204, 25)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(121, 21)
        Me.txtcantidad.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(521, 243)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.cobtipodeconversion)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cobdato2)
        Me.Controls.Add(Me.cobdato1)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.txtcantidad)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncalcular As Button
    Friend WithEvents cobtipodeconversion As ComboBox
    Friend WithEvents lblresultado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cobdato2 As ComboBox
    Friend WithEvents cobdato1 As ComboBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents txtcantidad As TextBox
End Class
