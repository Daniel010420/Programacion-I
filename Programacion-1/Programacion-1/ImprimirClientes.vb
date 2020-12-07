Public Class ImprimirClientes
    Private Sub imrpimirclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.imprimirclientes' Puede moverla o quitarla según sea necesario.
        Me.imprimirclientesTableAdapter.Fillclientes(Me._BDFarmacia_SantaFeDataSet.imprimirclientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class