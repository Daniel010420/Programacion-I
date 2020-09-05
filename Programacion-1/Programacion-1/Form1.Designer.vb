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
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.optResiduo = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optDivicion = New System.Windows.Forms.RadioButton()
        Me.optMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.cboOperaciones = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(297, 42)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(0, 13)
        Me.lblRespuesta.TabIndex = 41
        '
        'optResiduo
        '
        Me.optResiduo.AutoSize = True
        Me.optResiduo.Location = New System.Drawing.Point(142, 172)
        Me.optResiduo.Name = "optResiduo"
        Me.optResiduo.Size = New System.Drawing.Size(64, 17)
        Me.optResiduo.TabIndex = 40
        Me.optResiduo.TabStop = True
        Me.optResiduo.Text = "Residuo"
        Me.optResiduo.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(142, 126)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(76, 17)
        Me.optPorcentaje.TabIndex = 39
        Me.optPorcentaje.TabStop = True
        Me.optPorcentaje.Text = "Porcentaje"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(142, 149)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(31, 17)
        Me.optExponenciacion.TabIndex = 38
        Me.optExponenciacion.TabStop = True
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optDivicion
        '
        Me.optDivicion.AutoSize = True
        Me.optDivicion.Location = New System.Drawing.Point(142, 103)
        Me.optDivicion.Name = "optDivicion"
        Me.optDivicion.Size = New System.Drawing.Size(30, 17)
        Me.optDivicion.TabIndex = 37
        Me.optDivicion.TabStop = True
        Me.optDivicion.Text = "/"
        Me.optDivicion.UseVisualStyleBackColor = True
        '
        'optMultiplicacion
        '
        Me.optMultiplicacion.AutoSize = True
        Me.optMultiplicacion.Location = New System.Drawing.Point(142, 80)
        Me.optMultiplicacion.Name = "optMultiplicacion"
        Me.optMultiplicacion.Size = New System.Drawing.Size(29, 17)
        Me.optMultiplicacion.TabIndex = 36
        Me.optMultiplicacion.TabStop = True
        Me.optMultiplicacion.Text = "*"
        Me.optMultiplicacion.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(142, 57)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(28, 17)
        Me.optResta.TabIndex = 35
        Me.optResta.TabStop = True
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Numero 1"
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(238, 35)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(53, 20)
        Me.txtnum2.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Numero 1"
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Checked = True
        Me.optSuma.Location = New System.Drawing.Point(142, 34)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(31, 17)
        Me.optSuma.TabIndex = 31
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(71, 35)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(53, 20)
        Me.txtnum1.TabIndex = 30
        '
        'cboOperaciones
        '
        Me.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperaciones.FormattingEnabled = True
        Me.cboOperaciones.Items.AddRange(New Object() {"Seleccione una opción", "Suma", "Resta", "Multiplicación", "División", "Porcentaje", "Exponenciación", "Residuo"})
        Me.cboOperaciones.Location = New System.Drawing.Point(255, 122)
        Me.cboOperaciones.Name = "cboOperaciones"
        Me.cboOperaciones.Size = New System.Drawing.Size(121, 21)
        Me.cboOperaciones.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 53)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 290)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.optResiduo)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optDivicion)
        Me.Controls.Add(Me.optMultiplicacion)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.cboOperaciones)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parcial I"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRespuesta As Label
    Friend WithEvents optResiduo As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optDivicion As RadioButton
    Friend WithEvents optMultiplicacion As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents cboOperaciones As ComboBox
    Friend WithEvents Button1 As Button
End Class
