Public Class imprimirhistorialdecompra
    Private Sub imprimirhistorialdecompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.historialdecompra' Puede moverla o quitarla según sea necesario.
        Me.historialdecompraTableAdapter.Fillhistorialcompra(Me._BDFarmacia_SantaFeDataSet.historialdecompra)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class