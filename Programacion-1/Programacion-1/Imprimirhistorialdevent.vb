Public Class Imprimirhistorialdevent
    Private Sub Imprimirventasporcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.ventasporcliente' Puede moverla o quitarla según sea necesario.
        Me.ventasporclienteTableAdapter.Fillventasporcliente(Me._BDFarmacia_SantaFeDataSet.ventasporcliente)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
    End Sub
End Class