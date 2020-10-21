Public Class formLogeado
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Dim newform As New formAdministrarProveedor
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim newform As New formAdministrarEmpleados
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub LaboratoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaboratoriosToolStripMenuItem.Click
        Dim newform As New formAdministrarLaboratorio
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub MotivosDeDañoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotivosDeDañoToolStripMenuItem.Click
        Dim newform As New formMotivosDaño
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub PresentacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionesToolStripMenuItem.Click
        Dim newform As New formPresentacion
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub AdministarCargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministarCargosToolStripMenuItem.Click
        Dim newform As New formCargo
        newform.MdiParent = Me
        newform.Show()
    End Sub


    Private Sub TiposDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeClientesToolStripMenuItem.Click
        Dim newform As New formtipocliente
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub AdministrarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarClientesToolStripMenuItem.Click
        Dim newform As New formClientes
        newform.MdiParent = Me
        newform.Show()
    End Sub


    Private Sub PorcientoGananciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorcientoGananciaToolStripMenuItem.Click
        Dim newform As New formPorcientoGanancia
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub PreciosMedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosMedicamentoToolStripMenuItem.Click
        Dim newform As New FormPrecio
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub PorcientoDescuentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorcientoDescuentoToolStripMenuItem.Click

    End Sub
End Class