Public Class FormPrecio
    'Realiza la conexion a la base solo para este formulario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim comandosql = ""

    Dim mensajeenmentana = "Registro de Precio"
    Dim Nombretabladebusqueda = "Precios"
    Dim buscarpor1 = "Codigo"
    Dim buscarpor2 = "Codigo"

    Dim idTabla = "IdPrecios"
    Dim comandoinsertar = Nombretabladebusqueda + " (IdSolicitudes,PrecioCompra)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda

    Private Sub FormPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  txtid.Visible = False
        Label1.Visible = False
        txtsolicitudes.Enabled = False
        btneliminar.Enabled = False
        btnmodificarycancelar.Enabled = False
        btnnuevoyaceptar.Enabled = False
        btnmodificarycancelar.Text = "Cancelar"
        obtenerdatos()
    End Sub
    Sub obtenerdatos()
        Try
            'la palabra Empleados es la palabra que envia la peticion de la tabla que quiere
            'la palabra datos tabla es la que recibe los resultados de la tabla
            'llenar los datos del grid
            grid.DataSource = objConexion.obtenerDatos().Tables("Precio").DefaultView
            gridsolicitudes.DataSource = objConexion.obtenerDatos().Tables("Solicitudes").DefaultView
            grid.Columns(0).Visible = False
            gridsolicitudes.Columns(0).Visible = False

        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
    End Sub
    'Boton primero
    Private Sub btnnuevoyaceptar_Click(sender As Object, e As EventArgs) Handles btnnuevoyaceptar.Click
        If btnnuevoyaceptar.Text = "Nuevo" Then 'Nuevo
            btnnuevoyaceptar.Text = "Aceptar"
            btnmodificarycancelar.Text = "Cancelar"
            accion = "nuevo"
            btneliminar.Enabled = False
            btnmodificarycancelar.Enabled = True
            limpiar()


            'si el boton dice aceptar, significa que esta aceptando el nuevo registro y lo envia a la base
        ElseIf btnnuevoyaceptar.Text = "Aceptar" Then
            comandosql = comandoinsertar


            Dim msg = objConexion.mantenimientoPrecio(New String() {
            "",
          txtid.Text,
           txtcompra.Text}, 'dato(2)
          accion, comandosql, idTabla) 'accion que se desea realizar en el case

            'btnmodificarycancelar.Text = "Modificar"
            obtenerdatos()
            limpiar()
            MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnmodificarycancelar.Enabled = False


            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            btneliminar.Enabled = False
            btnmodificarycancelar.Enabled = False
            btnnuevoyaceptar.Enabled = False
            btnmodificarycancelar.Text = "Cancelar"




        Else 'si el boton dice Guardar, significa que esta haciendo un cambio de un dato
            comandosql = comandoactualizar
            Dim msg = objConexion.mantenimientoPrecio(New String() {
             txtid.Text, 'dato(0) para el id, incrementa automaticamente no necesita enviar nada 
            txtcompra.Text     'dato(1)
          },
            accion, comandosql, idTabla)

            obtenerdatos()
            MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()



            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            btneliminar.Enabled = False
            btnmodificarycancelar.Enabled = False
            btnnuevoyaceptar.Enabled = False
            btnmodificarycancelar.Text = "Cancelar"


        End If
    End Sub



    Private Sub btnmodificarycancelar_Click(sender As Object, e As EventArgs) Handles btnmodificarycancelar.Click
        If btnmodificarycancelar.Text = "Modificar" Then 'Nuevo
            btnnuevoyaceptar.Text = "Guardar"
            btnmodificarycancelar.Text = "Cancelar"
            btneliminar.Enabled = False
            btnnuevoyaceptar.Enabled = True
            btnnuevoyaceptar.Text = "Guardar"
            accion = "modificar"
        Else 'Guardar


            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            obtenerdatos()
            btneliminar.Enabled = True

            btneliminar.Enabled = False
            btnmodificarycancelar.Enabled = False
            btnnuevoyaceptar.Enabled = False
            btnmodificarycancelar.Text = "Cancelar"

        End If
    End Sub


    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtid.Text <> "" Then
            If (MessageBox.Show("Esta seguro de borrar a " + txtsolicitudes.Text, mensajeenmentana,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                comandosql = Nombretabladebusqueda
                Dim msg = objConexion.mantenimientoClientes(New String() {txtid.Text}, "eliminar", comandosql, idTabla)
                If msg = "Error en el proceso" Then
                    MessageBox.Show("No se pudo eliminar este registro, porque hay registros que dependen de el", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else MessageBox.Show("Debe selecionar un registro para eliminar", mensajeenmentana)
        End If
        limpiar()

        btnnuevoyaceptar.Text = "Nuevo"
        btnmodificarycancelar.Text = "Modificar"
        btneliminar.Enabled = False
        btnmodificarycancelar.Enabled = False
        btnnuevoyaceptar.Enabled = False
        btnmodificarycancelar.Text = "Cancelar"
        obtenerdatos()
    End Sub


    'filtro del datagridview
    Private Sub txtfiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtfiltro.KeyUp
        filtroprecios(txtfiltro.Text)
    End Sub

    Private Sub filtroprecios(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grid.DataSource
        bs.Filter = buscarpor1 + " like '%" & valor & "%' or " + buscarpor2 + " like '%" & valor & "%'"
        grid.DataSource = bs
    End Sub






    Private Sub txtfiltroSoli_KeyUp(sender As Object, e As KeyEventArgs) Handles txtfiltrosoli.KeyUp
        filtrosoli(txtfiltrosoli.Text)
    End Sub

    Private Sub filtrosoli(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = gridsolicitudes.DataSource
        bs.Filter = buscarpor1 + " like '%" & valor & "%' or " + buscarpor2 + " like '%" & valor & "%'"
        gridsolicitudes.DataSource = bs
    End Sub




    'pasar datos del grid al dar click hacia los txt
    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If btnnuevoyaceptar.Text <> "Aceptar" Then


            If grid.Rows.Count > 0 Then

                Dim i As Integer
                i = grid.CurrentRow.Index
                txtid.Text = grid.Item(0, i).Value()
                txtcompra.Text = grid.Item(2, i).Value()
                lblmensaje.Text = "Modificar Precio Existente"
                btneliminar.Enabled = True
                btnnuevoyaceptar.Enabled = False
                btnmodificarycancelar.Enabled = True
                btnmodificarycancelar.Text = "Modificar"
            End If

        End If



    End Sub





    'limpia los campos
    Private Sub limpiar()
        txtcompra.Text = ""
    End Sub

    Private Sub gridsolicitudes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridsolicitudes.CellClick

        If gridsolicitudes.Rows.Count > 0 Then
            Dim i As Integer
            i = gridsolicitudes.CurrentRow.Index
            txtid.Text = gridsolicitudes.Item(0, i).Value()
            txtsolicitudes.Text = gridsolicitudes.Item(1, i).Value()
            lblmensaje.Text = "Agregar Nuevo Precio"
            btneliminar.Enabled = False
            btnmodificarycancelar.Text = "Cancelar"
            btnnuevoyaceptar.Enabled = True
            txtcompra.Text = ""

        End If


    End Sub
End Class