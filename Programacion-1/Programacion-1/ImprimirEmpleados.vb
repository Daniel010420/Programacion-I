Public Class ImprimirEmpleados
    Private Sub Formimprimirempleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me._BDFarmacia_SantaFeDataSet.Empleados)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class