
Public Class formAdministrarProveedor
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Private Sub formAdministrarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerdatos()
    End Sub

    Sub obtenerdatos()
        dataTable = objConexion.obtenerDatosProveedor().Tables("Proveedor")
        mostrardatos()
    End Sub

    Sub mostrardatos()
        txtid.Text = dataTable.Rows(0).ItemArray(0).ToString()
        txtnombre.Text = dataTable.Rows(0).ItemArray(1).ToString()
        txttelefono.Text = dataTable.Rows(0).ItemArray(2).ToString()
        txtdireccion.Text = dataTable.Rows(0).ItemArray(3).ToString()

    End Sub


End Class