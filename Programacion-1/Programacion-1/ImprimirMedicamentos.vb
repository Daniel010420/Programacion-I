Public Class imprimirmedicamentos
    Private Sub imprimirmedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.imprimirmedicamentos' Puede moverla o quitarla según sea necesario.
        Me.imprimirmedicamentosTableAdapter.Fillmedicamentos(Me._BDFarmacia_SantaFeDataSet.imprimirmedicamentos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class