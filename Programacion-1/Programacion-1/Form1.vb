Public Class Form1

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        Dim num, i As Int64
        i = 1
        num = txttabla.Text


        lsttabla.Items.Clear()
        Do While i <= 10
            lsttabla.Items.Add(num.ToString + "X" + i.ToString + "=" + (num * i).ToString)
            i = i + 1
        Loop

    End Sub
End Class
