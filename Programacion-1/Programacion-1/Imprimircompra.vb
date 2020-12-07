Public Class Imprimircompra
    Public idcompraas As Integer = 0
    Private Sub Imprimircompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.imprimircompras' Puede moverla o quitarla según sea necesario.
        Me.imprimircomprasTableAdapter.Fillcompras(Me._BDFarmacia_SantaFeDataSet.imprimircompras, idcompraas)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class