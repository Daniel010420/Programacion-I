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

    Private Sub btnproveedor_Click(sender As Object, e As EventArgs) Handles btnproveedor.Click
        Dim formadmiproveedor As New formAdministrarProveedor
        formadmiproveedor.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(formadmiproveedor)
        formadmiproveedor.Show()
    End Sub

    Private Sub btninventario_Click(sender As Object, e As EventArgs) Handles btninventario.Click
        Dim forminventario As New forminventario
        forminventario.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(forminventario)
        forminventario.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class