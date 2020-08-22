Public Class Form1

    'objeto que llama a la clase de estadistica
    Dim ojbestadistica As New Estadistica

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        lblrespuestamedia.Text = ojbestadistica.CalcularMedia(txtserie.Text.Split(","))
        lblrespuestavarianza.Text = ojbestadistica.CalcularVarianza(txtserie.Text.Split(","))
        lblrespuestadesv.Text = ojbestadistica.CalcularDesvTipica(txtserie.Text.Split(","))
    End Sub
End Class
