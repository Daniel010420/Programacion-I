Public Class forminventario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"


    Private Sub forminventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerdatos()
    End Sub

    Sub obtenerdatos()
        dataTable = objConexion.obtenerDatosInventario().Tables("Inventario")
    End Sub



    Private Sub btnnuevoregistro_Click(sender As Object, e As EventArgs) Handles btnnuevoregistro.Click
        If btnnuevoregistro.Text = "Nuevo" Then
            btnnuevoregistro.Text = "Guadar"
            btnmodificarregistro.Text = "Cancelar"
            btneliminarregistro.Visible = False
            btnbuscar.Visible = False
            accion = "nuevo"
        Else
            Dim msg = objConexion.mantenimientoDatosInventario(New String() {
              "", txtnombre.Text, txtproveedor.Text, txtlab.Text, txtpresentacion.Text, txtvencelote.Text, txtpreciopresentacion.Text, txtunidadespresentacion.Text}, accion)
            MessageBox.Show(msg)

            obtenerdatos()

            btnnuevoregistro.Text = "Nuevo"
            btnmodificarregistro.Text = "Modificar"
            btneliminarregistro.Visible = True
            btnbuscar.Visible = True
        End If
    End Sub

    Private Sub btnmodificarregistro_Click(sender As Object, e As EventArgs) Handles btnmodificarregistro.Click
        If btnmodificarregistro.Text = "Modificar" Then
            btnnuevoregistro.Text = "Guadar"
            btnmodificarregistro.Text = "Cancelar"
            btneliminarregistro.Visible = False
            btnbuscar.Visible = False

        Else
            btnnuevoregistro.Text = "Nuevo"
            btnmodificarregistro.Text = "Modificar"
            btneliminarregistro.Visible = True
            btnbuscar.Visible = True
        End If
    End Sub




End Class


