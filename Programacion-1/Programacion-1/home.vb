Public Class home
    'Realiza la conexion a la base solo para este formulario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "modificar"
    Dim datostabla = "DatosTabla"
    Dim comandosql = ""
    Dim inicio As New formLogeado
    Public log = 0

    Dim mensajeenmentana = "Registro de Cargo"
    Dim Nombretabladebusqueda = "Usuarios"
    Dim buscarpor1 = "Cargo"
    Dim buscarpor2 = "Cargo"
    Dim idTabla = "IdUsuarios"
    Dim comandoinsertar = Nombretabladebusqueda + " (Cargo)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtususario.Text <> "" And txtpass.Text <> "" Then
            Dim msg = objConexion.user(New String() {
txtususario.Text,      'dato(0) si se envia el id aqui porque es el que identifica el registro, update from id = x
txtpass.Text}, 'dato(1)
accion, comandosql, idTabla)

            If msg = "realizada" Then
                ' formLogeado.Label1.Text = 1
                formLogeado.btntrabajo.Visible = True
                formLogeado.IniciarSesionToolStripMenuItem.Text = "Cerrar Sesion"
                Close()

            Else msg = "Usuario o contraseña no encontrado"
                MessageBox.Show(msg)
                log = 0
            End If
        End If




    End Sub
End Class