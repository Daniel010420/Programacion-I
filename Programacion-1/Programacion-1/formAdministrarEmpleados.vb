Public Class formAdministrarEmpleados
    'Realiza la conexion a la base solo para este formulario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"

    'accion al cargar el formulario
    Private Sub formAdministrarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Enabled = False
        obtenerdatos()
    End Sub


    'obtiene los datos y los recarga en el gridview
    Sub obtenerdatos()
        'la palabra Empleados es la que recibe los datos que envio la consulta en la clase conexion
        dataTable = objConexion.obtenerDatosEmpleados().Tables("Empleados")
        Try
            grid.DataSource = objConexion.obtenerDatosEmpleados().Tables("Empleados").DefaultView
        Catch ex As Exception
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
    End Sub



    Private Sub btnnuevoyaceptar_Click(sender As Object, e As EventArgs) Handles btnnuevoyaceptar.Click
        If btnnuevoyaceptar.Text = "Nuevo" Then 'Nuevo
            btnnuevoyaceptar.Text = "Aceptar"
            btnmodificarycancelar.Text = "Cancelar"
            accion = "nuevo"
            btneliminar.Enabled = False
            limpiar()


        ElseIf btnnuevoyaceptar.Text = "Aceptar" Then
            Dim msg = objConexion.mantenimientoEmpleados(New String() {
              "", txtnombre.Text, txtdui.Text, txttelefono.Text, txtcorreo.Text, txtdireccion.Text}, accion)
            MessageBox.Show(msg, "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            obtenerdatos()
            btneliminar.Enabled = True

        Else
            Dim msg = objConexion.mantenimientoEmpleados(New String() {
              txtid.Text, txtnombre.Text, txtdui.Text, txttelefono.Text, txtcorreo.Text, txtdireccion.Text}, accion)
            MessageBox.Show(msg, "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            obtenerdatos()
            btneliminar.Enabled = True
        End If

    End Sub

    Private Sub btnmodificarycancelar_Click(sender As Object, e As EventArgs) Handles btnmodificarycancelar.Click
        If btnmodificarycancelar.Text = "Modificar" Then 'Nuevo
            btnnuevoyaceptar.Text = "Guardar"
            btnmodificarycancelar.Text = "Cancelar"
            btneliminar.Enabled = False
            accion = "modificar"
        Else 'Guardar
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            obtenerdatos()
            btneliminar.Enabled = True
        End If

    End Sub


    Private Sub limpiar()
        txtid.Text = ""
        txtnombre.Text = ""
        txtdui.Text = ""
        txttelefono.Text = ""
        txtcorreo.Text = ""
        txtdireccion.Text = ""

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If (MessageBox.Show("Esta seguro de borrar a " + txtnombre.Text, "Registro de cliente",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            objConexion.mantenimientoEmpleados(New String() {txtid.Text}, "eliminar")
        End If
        limpiar()
        obtenerdatos()
    End Sub

    Private Sub txtfiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtfiltro.KeyUp
        filtro(txtfiltro.Text)
    End Sub

    Private Sub filtro(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grid.DataSource
        bs.Filter = "NombreCompleto like '%" & valor & "%' or DUI like '%" & valor & "%'"
        grid.DataSource = bs
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        Dim i As Integer
        i = grid.CurrentRow.Index
        txtid.Text = grid.Item(0, i).Value()
        txtnombre.Text = grid.Item(1, i).Value()
        txtdui.Text = grid.Item(2, i).Value()
        txttelefono.Text = grid.Item(3, i).Value()
        txtcorreo.Text = grid.Item(4, i).Value()
        txtdireccion.Text = grid.Item(5, i).Value()
    End Sub
End Class