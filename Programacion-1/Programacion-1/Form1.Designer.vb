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
        Me.ltbmostrar = New System.Windows.Forms.ListBox()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.btnmostrarpareseimpares = New System.Windows.Forms.Button()
        Me.btncajero = New System.Windows.Forms.Button()
        Me.btnprimo = New System.Windows.Forms.Button()
        Me.btnparoimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltbmostrar
        '
        Me.ltbmostrar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbmostrar.FormattingEnabled = True
        Me.ltbmostrar.ItemHeight = 20
        Me.ltbmostrar.Location = New System.Drawing.Point(235, 22)
        Me.ltbmostrar.Name = "ltbmostrar"
        Me.ltbmostrar.Size = New System.Drawing.Size(193, 284)
        Me.ltbmostrar.TabIndex = 13
        '
        'txtnumero
        '
        Me.txtnumero.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(75, 41)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 26)
        Me.txtnumero.TabIndex = 12
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumero.Location = New System.Drawing.Point(13, 41)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(56, 20)
        Me.lblnumero.TabIndex = 11
        Me.lblnumero.Text = "Numero"
        '
        'btnmostrarpareseimpares
        '
        Me.btnmostrarpareseimpares.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrarpareseimpares.Location = New System.Drawing.Point(124, 216)
        Me.btnmostrarpareseimpares.Name = "btnmostrarpareseimpares"
        Me.btnmostrarpareseimpares.Size = New System.Drawing.Size(105, 60)
        Me.btnmostrarpareseimpares.TabIndex = 10
        Me.btnmostrarpareseimpares.Text = "Mostrar pares e impares"
        Me.btnmostrarpareseimpares.UseVisualStyleBackColor = True
        '
        'btncajero
        '
        Me.btncajero.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncajero.Location = New System.Drawing.Point(13, 216)
        Me.btncajero.Name = "btncajero"
        Me.btncajero.Size = New System.Drawing.Size(105, 60)
        Me.btncajero.TabIndex = 9
        Me.btncajero.Text = "Cajero"
        Me.btncajero.UseVisualStyleBackColor = True
        '
        'btnprimo
        '
        Me.btnprimo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprimo.Location = New System.Drawing.Point(124, 140)
        Me.btnprimo.Name = "btnprimo"
        Me.btnprimo.Size = New System.Drawing.Size(105, 60)
        Me.btnprimo.TabIndex = 8
        Me.btnprimo.Text = "Primo?"
        Me.btnprimo.UseVisualStyleBackColor = True
        '
        'btnparoimpar
        '
        Me.btnparoimpar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnparoimpar.Location = New System.Drawing.Point(13, 140)
        Me.btnparoimpar.Name = "btnparoimpar"
        Me.btnparoimpar.Size = New System.Drawing.Size(105, 60)
        Me.btnparoimpar.TabIndex = 7
        Me.btnparoimpar.Text = "Par e Impar"
        Me.btnparoimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 343)
        Me.Controls.Add(Me.ltbmostrar)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblnumero)
        Me.Controls.Add(Me.btnmostrarpareseimpares)
        Me.Controls.Add(Me.btncajero)
        Me.Controls.Add(Me.btnprimo)
        Me.Controls.Add(Me.btnparoimpar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estructuras de control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltbmostrar As ListBox
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents lblnumero As Label
    Friend WithEvents btnmostrarpareseimpares As Button
    Friend WithEvents btncajero As Button
    Friend WithEvents btnprimo As Button
    Friend WithEvents btnparoimpar As Button
End Class
