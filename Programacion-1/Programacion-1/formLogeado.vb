Public Class formLogeado

    Private Sub btnempleado_Click(sender As Object, e As EventArgs) Handles btnempleado.Click
        Dim formadmiempleado As New formAdministrarEmpleados
        formadmiempleado.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(formadmiempleado)

        formadmiempleado.Show()
    End Sub

    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        Dim formadmiclientesvip As New formAdministrarClientesVIP
        formadmiclientesvip.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(formadmiclientesvip)
        formadmiclientesvip.Show()

    End Sub
End Class