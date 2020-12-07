Public Class ImprimirDano
    Private Sub ImprimirDano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.imprimirdanos' Puede moverla o quitarla según sea necesario.
        Me.imprimirdanosTableAdapter.Fill(Me._BDFarmacia_SantaFeDataSet.imprimirdanos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class