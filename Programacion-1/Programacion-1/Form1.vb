Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num1, num2, respuesta As Double


        num1 = txtnum1.Text
        num2 = txtnum2.Text



        If optSuma.Checked Then
            respuesta = num1 + num2
            lblRespuesta.Text = respuesta
        End If

        If optResta.Checked Then
            respuesta = num1 - num2
            lblRespuesta.Text = respuesta
        End If

        If optMultiplicacion.Checked Then
            respuesta = num1 * num2
            lblRespuesta.Text = respuesta
        End If

        If optDivicion.Checked Then
            respuesta = num1 / num2
            lblRespuesta.Text = respuesta
        End If

        If optPorcentaje.Checked Then
            respuesta = (num1 * num2) / 100
            lblRespuesta.Text = respuesta
        End If

        If optExponenciacion.Checked Then
            respuesta = num1 ^ num2
            lblRespuesta.Text = respuesta
        End If

        If optResiduo.Checked Then
            respuesta = num1 Mod num2
            lblRespuesta.Text = respuesta
        End If



        Select Case cboOperaciones.SelectedIndex
            Case 1
                respuesta = num1 + num2
                lblRespuesta.Text = respuesta
            Case 2
                respuesta = num1 - num2
                lblRespuesta.Text = respuesta
            Case 3
                respuesta = num1 * num2
                lblRespuesta.Text = respuesta
            Case 4
                respuesta = num1 / num2
                lblRespuesta.Text = respuesta
            Case 5
                respuesta = (num1 * num2) / 100
                lblRespuesta.Text = respuesta
            Case 6
                respuesta = num1 ^ num2
                lblRespuesta.Text = respuesta
            Case 7
                respuesta = num1 Mod num2
                lblRespuesta.Text = respuesta
        End Select
    End Sub
End Class