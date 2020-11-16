Public Class detallecompra

    Private Sub detallecompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = Module1.id
        txtfactura.Text = Module1.factura
    End Sub
End Class