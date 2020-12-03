Public Class imprimirsolicitud
    Public idsolirepor As Integer = 0
    Private Sub imprimirsolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.imprimirsolicitud' Puede moverla o quitarla según sea necesario.
        Me.imprimirsolicitudTableAdapter.Fillsolicitud(Me._BDFarmacia_SantaFeDataSet.imprimirsolicitud, idsolirepor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class