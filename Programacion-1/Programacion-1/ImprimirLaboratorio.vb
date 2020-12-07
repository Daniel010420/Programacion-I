Public Class ImprimirLaboratorio
    Private Sub imprimirlaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.Laboratorio' Puede moverla o quitarla según sea necesario.
        Me.LaboratorioTableAdapter.Fill(Me._BDFarmacia_SantaFeDataSet.Laboratorio)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class