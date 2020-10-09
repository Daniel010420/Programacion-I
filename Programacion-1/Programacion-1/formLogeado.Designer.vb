<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogeado
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btninventario = New System.Windows.Forms.Button()
        Me.btnproveedor = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.btnempleado = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btninventario)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnproveedor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnclientes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnempleado)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 426)
        Me.SplitContainer1.SplitterDistance = 111
        Me.SplitContainer1.TabIndex = 3
        '
        'btninventario
        '
        Me.btninventario.Location = New System.Drawing.Point(12, 187)
        Me.btninventario.Name = "btninventario"
        Me.btninventario.Size = New System.Drawing.Size(83, 36)
        Me.btninventario.TabIndex = 3
        Me.btninventario.Text = "Inventario"
        Me.btninventario.UseVisualStyleBackColor = True
        '
        'btnproveedor
        '
        Me.btnproveedor.Location = New System.Drawing.Point(12, 137)
        Me.btnproveedor.Name = "btnproveedor"
        Me.btnproveedor.Size = New System.Drawing.Size(83, 36)
        Me.btnproveedor.TabIndex = 2
        Me.btnproveedor.Text = "Administrar Proveedor"
        Me.btnproveedor.UseVisualStyleBackColor = True
        '
        'btnclientes
        '
        Me.btnclientes.Location = New System.Drawing.Point(12, 87)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(83, 36)
        Me.btnclientes.TabIndex = 1
        Me.btnclientes.Text = "Administrar clientes preferidos"
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'btnempleado
        '
        Me.btnempleado.Location = New System.Drawing.Point(12, 27)
        Me.btnempleado.Name = "btnempleado"
        Me.btnempleado.Size = New System.Drawing.Size(83, 46)
        Me.btnempleado.TabIndex = 0
        Me.btnempleado.Text = "Administrar empleados"
        Me.btnempleado.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(322, -3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(277, 27)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Farmancia Santa Fé"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'formLogeado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "formLogeado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido a Farmacia Santa Fe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnclientes As Button
    Friend WithEvents btnempleado As Button
    Friend WithEvents btninventario As Button
    Friend WithEvents btnproveedor As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
