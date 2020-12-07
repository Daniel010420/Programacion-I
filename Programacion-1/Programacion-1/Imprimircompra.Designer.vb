<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Imprimircompra
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me._BDFarmacia_SantaFeDataSet = New Programacion_1._BDFarmacia_SantaFeDataSet()
        Me.imprimircomprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.imprimircomprasTableAdapter = New Programacion_1._BDFarmacia_SantaFeDataSetTableAdapters.imprimircomprasTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me._BDFarmacia_SantaFeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imprimircomprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_BDFarmacia_SantaFeDataSet
        '
        Me._BDFarmacia_SantaFeDataSet.DataSetName = "_BDFarmacia_SantaFeDataSet"
        Me._BDFarmacia_SantaFeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'imprimircomprasBindingSource
        '
        Me.imprimircomprasBindingSource.DataMember = "imprimircompras"
        Me.imprimircomprasBindingSource.DataSource = Me._BDFarmacia_SantaFeDataSet
        '
        'imprimircomprasTableAdapter
        '
        Me.imprimircomprasTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSetcompras"
        ReportDataSource1.Value = Me.imprimircomprasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programacion_1.Reportecompra.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 426)
        Me.ReportViewer1.TabIndex = 0
        '
        'Imprimircompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Imprimircompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimircompra"
        CType(Me._BDFarmacia_SantaFeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imprimircomprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imprimircomprasBindingSource As BindingSource
    Friend WithEvents _BDFarmacia_SantaFeDataSet As _BDFarmacia_SantaFeDataSet
    Friend WithEvents imprimircomprasTableAdapter As _BDFarmacia_SantaFeDataSetTableAdapters.imprimircomprasTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
