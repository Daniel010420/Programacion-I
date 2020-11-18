Public Class solicitudes
    'Realiza la conexion a la base solo para este formulario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim datostabla = "DatosTabla"
    Dim comandosql = ""
    Public idddd

    Dim buscarpor1 = "Codigo"
    Dim buscarpor2 = "Codigo"
    Private Sub solicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerdatos()
    End Sub

    Sub obtenerdatos()
        Try
            'la palabra Empleados es la palabra que envia la peticion de la tabla que quiere
            'la palabra datos tabla es la que recibe los resultados de la tabla
            'llenar los datos del grid
            grid.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            grid.Columns(0).Visible = False
            grid.Columns(2).Visible = False
            grid.Columns(4).Visible = False
            grid.Columns(7).Visible = False
            grid.Columns(5).HeaderText = "Empleado"

        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
    End Sub

    Private Sub txtfiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtfiltro.KeyUp
        filtro(txtfiltro.Text)
    End Sub
    Private Sub filtro(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grid.DataSource
        bs.Filter = buscarpor1 + " like '%" & valor & "%' or " + buscarpor2 + " like '%" & valor & "%'"
        grid.DataSource = bs
    End Sub



    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick

        If grid.Rows.Count > 0 Then
            Dim i As Integer
            i = grid.CurrentRow.Index
            Label1.Text = grid.Item(0, i).Value()
        End If

    End Sub


    Public Function label()
        idddd = Label1.Text
    End Function

    Private Sub btnnuevoyaceptar_Click(sender As Object, e As EventArgs) Handles btnnuevoyaceptar.Click
        If Label1.Text <> "" Then
            label()
            Close()
        End If
    End Sub
End Class