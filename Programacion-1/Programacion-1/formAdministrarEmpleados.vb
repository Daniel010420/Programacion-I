Public Class formAdministrarEmpleados
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Private Sub formAdministrarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerdatos()
    End Sub

    Sub obtenerdatos()
        dataTable = objConexion.obtenerDatosEmpleados().Tables("Empleados")
        mostrardatos()
    End Sub

    Sub mostrardatos()
        txtid.Text = dataTable.Rows(0).ItemArray(0).ToString()
        txtnombre.Text = dataTable.Rows(0).ItemArray(1).ToString()
        txtapellido.Text = dataTable.Rows(0).ItemArray(2).ToString()
        txtdui.Text = dataTable.Rows(0).ItemArray(3).ToString()
        txtcorreo.Text = dataTable.Rows(0).ItemArray(4).ToString()
        txttelefono.Text = dataTable.Rows(0).ItemArray(5).ToString()
        txtdireccion.Text = dataTable.Rows(0).ItemArray(6).ToString()
    End Sub

End Class