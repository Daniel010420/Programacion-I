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
        Me.lblserie = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.lblmedia = New System.Windows.Forms.Label()
        Me.lblvarianza = New System.Windows.Forms.Label()
        Me.lbldesviacion = New System.Windows.Forms.Label()
        Me.lblrespuestavarianza = New System.Windows.Forms.Label()
        Me.lblrespuestadesv = New System.Windows.Forms.Label()
        Me.lblrespuestamedia = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.grdEstadistica = New System.Windows.Forms.DataGridView()
        Me.x1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x1xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x21xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbltotalx21xf1 = New System.Windows.Forms.Label()
        Me.lbltotalx1xf1 = New System.Windows.Forms.Label()
        Me.lbltotalf1 = New System.Windows.Forms.Label()
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(12, 21)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(31, 13)
        Me.lblserie.TabIndex = 0
        Me.lblserie.Text = "Serie"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(49, 18)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(100, 20)
        Me.txtserie.TabIndex = 1
        '
        'lblmedia
        '
        Me.lblmedia.AutoSize = True
        Me.lblmedia.Location = New System.Drawing.Point(12, 55)
        Me.lblmedia.Name = "lblmedia"
        Me.lblmedia.Size = New System.Drawing.Size(36, 13)
        Me.lblmedia.TabIndex = 2
        Me.lblmedia.Text = "Media"
        '
        'lblvarianza
        '
        Me.lblvarianza.AutoSize = True
        Me.lblvarianza.Location = New System.Drawing.Point(12, 86)
        Me.lblvarianza.Name = "lblvarianza"
        Me.lblvarianza.Size = New System.Drawing.Size(48, 13)
        Me.lblvarianza.TabIndex = 3
        Me.lblvarianza.Text = "Varianza"
        '
        'lbldesviacion
        '
        Me.lbldesviacion.AutoSize = True
        Me.lbldesviacion.Location = New System.Drawing.Point(12, 113)
        Me.lbldesviacion.Name = "lbldesviacion"
        Me.lbldesviacion.Size = New System.Drawing.Size(67, 13)
        Me.lbldesviacion.TabIndex = 4
        Me.lbldesviacion.Text = "Desv. Tipica"
        '
        'lblrespuestavarianza
        '
        Me.lblrespuestavarianza.AutoSize = True
        Me.lblrespuestavarianza.Location = New System.Drawing.Point(85, 86)
        Me.lblrespuestavarianza.Name = "lblrespuestavarianza"
        Me.lblrespuestavarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestavarianza.TabIndex = 5
        Me.lblrespuestavarianza.Text = "?"
        '
        'lblrespuestadesv
        '
        Me.lblrespuestadesv.AutoSize = True
        Me.lblrespuestadesv.Location = New System.Drawing.Point(85, 113)
        Me.lblrespuestadesv.Name = "lblrespuestadesv"
        Me.lblrespuestadesv.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestadesv.TabIndex = 6
        Me.lblrespuestadesv.Text = "?"
        '
        'lblrespuestamedia
        '
        Me.lblrespuestamedia.AutoSize = True
        Me.lblrespuestamedia.Location = New System.Drawing.Point(85, 55)
        Me.lblrespuestamedia.Name = "lblrespuestamedia"
        Me.lblrespuestamedia.Size = New System.Drawing.Size(13, 13)
        Me.lblrespuestamedia.TabIndex = 7
        Me.lblrespuestamedia.Text = "?"
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(12, 154)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(103, 33)
        Me.btncalcular.TabIndex = 8
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'grdEstadistica
        '
        Me.grdEstadistica.AllowUserToDeleteRows = False
        Me.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstadistica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x1, Me.f1, Me.n1, Me.x1xf1, Me.x21xf1})
        Me.grdEstadistica.Location = New System.Drawing.Point(174, 18)
        Me.grdEstadistica.Name = "grdEstadistica"
        Me.grdEstadistica.Size = New System.Drawing.Size(543, 382)
        Me.grdEstadistica.TabIndex = 10
        '
        'x1
        '
        Me.x1.HeaderText = "X1"
        Me.x1.Name = "x1"
        '
        'f1
        '
        Me.f1.HeaderText = "F1"
        Me.f1.Name = "f1"
        '
        'n1
        '
        Me.n1.HeaderText = "N1"
        Me.n1.Name = "n1"
        '
        'x1xf1
        '
        Me.x1xf1.HeaderText = "X1 x F1"
        Me.x1xf1.Name = "x1xf1"
        '
        'x21xf1
        '
        Me.x21xf1.HeaderText = "X21 x F1"
        Me.x21xf1.Name = "x21xf1"
        '
        'lbltotalx21xf1
        '
        Me.lbltotalx21xf1.AutoSize = True
        Me.lbltotalx21xf1.Location = New System.Drawing.Point(656, 422)
        Me.lbltotalx21xf1.Name = "lbltotalx21xf1"
        Me.lbltotalx21xf1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalx21xf1.TabIndex = 15
        Me.lbltotalx21xf1.Text = "0.0"
        '
        'lbltotalx1xf1
        '
        Me.lbltotalx1xf1.AutoSize = True
        Me.lbltotalx1xf1.Location = New System.Drawing.Point(556, 422)
        Me.lbltotalx1xf1.Name = "lbltotalx1xf1"
        Me.lbltotalx1xf1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalx1xf1.TabIndex = 14
        Me.lbltotalx1xf1.Text = "0.0"
        '
        'lbltotalf1
        '
        Me.lbltotalf1.AutoSize = True
        Me.lbltotalf1.Location = New System.Drawing.Point(350, 422)
        Me.lbltotalf1.Name = "lbltotalf1"
        Me.lbltotalf1.Size = New System.Drawing.Size(22, 13)
        Me.lbltotalf1.TabIndex = 13
        Me.lbltotalf1.Text = "0.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 462)
        Me.Controls.Add(Me.lbltotalx21xf1)
        Me.Controls.Add(Me.lbltotalx1xf1)
        Me.Controls.Add(Me.lbltotalf1)
        Me.Controls.Add(Me.grdEstadistica)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.lblrespuestamedia)
        Me.Controls.Add(Me.lblrespuestadesv)
        Me.Controls.Add(Me.lblrespuestavarianza)
        Me.Controls.Add(Me.lbldesviacion)
        Me.Controls.Add(Me.lblvarianza)
        Me.Controls.Add(Me.lblmedia)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.lblserie)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matrices y POO"
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblserie As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents lblmedia As Label
    Friend WithEvents lblvarianza As Label
    Friend WithEvents lbldesviacion As Label
    Friend WithEvents lblrespuestavarianza As Label
    Friend WithEvents lblrespuestadesv As Label
    Friend WithEvents lblrespuestamedia As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents grdEstadistica As DataGridView
    Friend WithEvents x1 As DataGridViewTextBoxColumn
    Friend WithEvents f1 As DataGridViewTextBoxColumn
    Friend WithEvents n1 As DataGridViewTextBoxColumn
    Friend WithEvents x1xf1 As DataGridViewTextBoxColumn
    Friend WithEvents x21xf1 As DataGridViewTextBoxColumn
    Friend WithEvents lbltotalx21xf1 As Label
    Friend WithEvents lbltotalx1xf1 As Label
    Friend WithEvents lbltotalf1 As Label
End Class
