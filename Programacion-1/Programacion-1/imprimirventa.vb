Public Class imprimirventa
    Public idventaaa As Integer = 0
    Private Sub imprimirventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.imprimirventa' Puede moverla o quitarla según sea necesario.
        Me.imprimirventaTableAdapter.Fillventasreporte(Me._BDFarmacia_SantaFeDataSet.imprimirventa, idventaaa)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class