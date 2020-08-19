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
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblinformacion2 = New System.Windows.Forms.Label()
        Me.lblinformacion = New System.Windows.Forms.Label()
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
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(46, 146)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(39, 13)
        Me.lbl5.TabIndex = 28
        Me.lbl5.Text = "Label3"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(42, 112)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(39, 13)
        Me.lbl4.TabIndex = 27
        Me.lbl4.Text = "Label3"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(46, 55)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(39, 13)
        Me.lbl2.TabIndex = 26
        Me.lbl2.Text = "Label1"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(42, 85)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(39, 13)
        Me.lbl.TabIndex = 25
        Me.lbl.Text = "Label1"
        '
        'lblinformacion2
        '
        Me.lblinformacion2.AutoSize = True
        Me.lblinformacion2.Location = New System.Drawing.Point(37, 265)
        Me.lblinformacion2.Name = "lblinformacion2"
        Me.lblinformacion2.Size = New System.Drawing.Size(0, 13)
        Me.lblinformacion2.TabIndex = 24
        '
        'lblinformacion
        '
        Me.lblinformacion.AutoSize = True
        Me.lblinformacion.Location = New System.Drawing.Point(37, 239)
        Me.lblinformacion.Name = "lblinformacion"
        Me.lblinformacion.Size = New System.Drawing.Size(0, 13)
        Me.lblinformacion.TabIndex = 23
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(150, 146)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(121, 40)
        Me.btncalcular.TabIndex = 22
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'cobtipodeconversion
        '
        Me.cobtipodeconversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobtipodeconversion.FormattingEnabled = True
        Me.cobtipodeconversion.Items.AddRange(New Object() {"Monedas", "Masa", "Volumen", "Longitud", "Almacenamiento", "Tiempo"})
        Me.cobtipodeconversion.Location = New System.Drawing.Point(150, 55)
        Me.cobtipodeconversion.Name = "cobtipodeconversion"
        Me.cobtipodeconversion.Size = New System.Drawing.Size(121, 21)
        Me.cobtipodeconversion.TabIndex = 21
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Location = New System.Drawing.Point(202, 204)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(0, 13)
        Me.lblresultado.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Resultado"
        '
        'cobdato2
        '
        Me.cobdato2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobdato2.FormattingEnabled = True
        Me.cobdato2.Location = New System.Drawing.Point(150, 109)
        Me.cobdato2.Name = "cobdato2"
        Me.cobdato2.Size = New System.Drawing.Size(121, 21)
        Me.cobdato2.TabIndex = 18
        '
        'cobdato1
        '
        Me.cobdato1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobdato1.FormattingEnabled = True
        Me.cobdato1.Location = New System.Drawing.Point(150, 82)
        Me.cobdato1.Name = "cobdato1"
        Me.cobdato1.Size = New System.Drawing.Size(121, 21)
        Me.cobdato1.TabIndex = 17
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(42, 23)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(102, 13)
        Me.lblcantidad.TabIndex = 16
        Me.lblcantidad.Text = "Cantidad a convertir"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(150, 20)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(121, 20)
        Me.txtcantidad.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 337)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblinformacion2)
        Me.Controls.Add(Me.lblinformacion)
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

    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblinformacion2 As Label
    Friend WithEvents lblinformacion As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents cobtipodeconversion As ComboBox
    Friend WithEvents lblresultado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cobdato2 As ComboBox
    Friend WithEvents cobdato1 As ComboBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents txtcantidad As TextBox
End Class
