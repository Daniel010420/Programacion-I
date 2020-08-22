Public Class Form1

    'objeto que llama a la clase de estadistica
    Dim ojbestadistica As New Estadistica

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        lblrespuestamedia.Text = ojbestadistica.CalcularMedia(txtserie.Text.Split(","))
        lblrespuestavarianza.Text = ojbestadistica.CalcularVarianza(txtserie.Text.Split(","))
        lblrespuestadesv.Text = ojbestadistica.CalcularDesvTipica(txtserie.Text.Split(","))
    End Sub








    Private Sub grdEstadistica_KeyUp(sender As Object, e As KeyEventArgs) Handles grdEstadistica.KeyUp
        'numero de filas menos una que es la fila de inicio, para recorrer hasta la ultima fila creada
        Dim numerodefilas = grdEstadistica.Rows.Count - 1
        Dim x1 = 0
        Dim f1 = 0
        Dim totalf1 = 0
        Dim totalx1xf1 = 0.0
        Dim totalx21xf1 = 0.0

        Dim fila As New DataGridViewRow




        For i = 0 To numerodefilas - 1
            fila = grdEstadistica.Rows(i)

            'optener valor si la celda no esta vacia
            If fila.Cells("x1").Value <> "" Then
                x1 = Integer.Parse(fila.Cells("x1").Value.ToString())
            End If
            'optener valor si la celda no esta vacia
            If fila.Cells("f1").Value <> "" Then
                f1 = Integer.Parse(fila.Cells("f1").Value.ToString())
            End If

            totalf1 = totalf1 + f1
            totalx1xf1 = totalx1xf1 + (x1 * f1)
            totalx21xf1 = totalx21xf1 + (x1 ^ 2 * f1)

            'colocar resultado en las demas filas
            fila.Cells("n1").Value = totalf1.ToString()
            fila.Cells("x1xf1").Value = (x1 * f1).ToString()
            fila.Cells("x21xf1").Value = (x1 ^ 2 * f1).ToString()


        Next
        'colocar totales en los label
        lbltotalf1.Text = totalf1.ToString()
        lbltotalx1xf1.Text = totalx1xf1.ToString()
        lbltotalx21xf1.Text = totalx21xf1.ToString()


        Dim media = Math.Round(totalx1xf1 / totalf1, 2),
        varianza = Math.Round(totalx21xf1 / totalf1 - media ^ 2, 2)
        lblrespuestamedia.Text = media.ToString()
        lblrespuestavarianza.Text = varianza.ToString()
        lblrespuestadesv.Text = ((varianza) ^ 1 / 2).ToString()


    End Sub
End Class
