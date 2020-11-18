Public Class NuevaSolicitud
    'Realiza la conexion a la base solo para este formulario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim comandosql = ""
    Dim objdetalle As New detallecompra



    Dim mensajeenmentana = "Registro de Solicitud"
    Dim Nombretabladebusqueda = "Solicitudes"
    Dim buscarpor1 = "Codigo"
    Dim buscarpor2 = "Codigo"

    Dim idTabla = "IdSolicitudes"
    Dim comandoinsertar = Nombretabladebusqueda + " (Codigo,IdProveedor,IdEmpleado,fecha_Registro,IdSucursal)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda
    Private Sub NuevaSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        obtenerdatossolicitudhecha()
    End Sub

    Sub obtenerdatossolicitudhecha()
        Try
            'la palabra Empleados es la palabra que envia la peticion de la tabla que quiere
            'la palabra datos tabla es la que recibe los resultados de la tabla
            'llenar los datos del grid
            grid.DataSource = objConexion.obtenerDatos().Tables("detallesolicitud").DefaultView

            grid.Columns(1).Visible = False
            grid.Columns(7).Visible = False
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            grid.Columns(11).Visible = False
            grid.Columns(0).Visible = False
            grid.Columns(0).DisplayIndex = 11


            cobproveedor.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobproveedor.DisplayMember = "Proveedor"
            cobproveedor.ValueMember = " Proveedores.IdProveedores"

            cobsucursal.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobsucursal.DisplayMember = "Ubicacion"
            cobsucursal.ValueMember = "Sucursal.IdSucursal"

            cobcodigo.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobcodigo.DisplayMember = "Codigo"
            cobcodigo.ValueMember = "Solicitudess.IdSolicitudes"

            cobempleado.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobempleado.DisplayMember = "NombreCompleto"
            cobempleado.ValueMember = "Empleados.IdEmpleado"

            cobid.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobid.DisplayMember = "IdSolicitudes"
            cobid.ValueMember = "Solcitudes.IdSolicitudes"



            cargar()
            filtro(cobcodigo.Text.Trim)
            totalizar()
        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
    End Sub


    Private Sub cargar()
        cobproveedor.Enabled = False
        cobsucursal.Enabled = False
        cobempleado.Enabled = False
        cobid.Visible = False
    End Sub

    Private Sub cargar2()
        cobproveedor.Enabled = True
        cobsucursal.Enabled = True
        cobempleado.Enabled = True
        cobid.Visible = True
        grid.DataSource = ""



        cobproveedor.DataSource = objConexion.obtenerDatos().Tables("Proveedores").DefaultView
        cobproveedor.DisplayMember = "Proveedor"
        cobproveedor.ValueMember = " Proveedores.IdProveedores"
        cobproveedor.AutoCompleteMode = AutoCompleteMode.Suggest
        cobproveedor.AutoCompleteSource = AutoCompleteSource.ListItems


        cobsucursal.DataSource = objConexion.obtenerDatos().Tables("Sucursal").DefaultView
        cobsucursal.DisplayMember = "Ubicacion"
        cobsucursal.ValueMember = "Sucursal.IdSucursal"
        cobsucursal.AutoCompleteMode = AutoCompleteMode.Suggest
        cobsucursal.AutoCompleteSource = AutoCompleteSource.ListItems


        cobempleado.DataSource = objConexion.obtenerDatos().Tables("Empleados").DefaultView
        cobempleado.DisplayMember = "NombreCompleto"
        cobempleado.ValueMember = "Empleados.IdEmpleado"
        cobempleado.AutoCompleteMode = AutoCompleteMode.Suggest
        cobempleado.AutoCompleteSource = AutoCompleteSource.ListItems





        cobid.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
        cobid.DisplayMember = "IdSolicitudes"
        cobid.ValueMember = "Solicitudes.IdSolicitudes"
        cobid.AutoCompleteMode = AutoCompleteMode.Suggest
        cobid.AutoCompleteSource = AutoCompleteSource.ListItems


        cobcodigo.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
        cobcodigo.DisplayMember = "Codigo"
        cobcodigo.ValueMember = "Solicitudes.IdSolicitudes"
        cobcodigo.AutoCompleteMode = AutoCompleteMode.Suggest
        cobcodigo.AutoCompleteSource = AutoCompleteSource.ListItems

    End Sub

    Private Sub txtfiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles cobcodigo.KeyUp
        filtro(cobcodigo.Text.Trim)

    End Sub



    Private Sub cargar3()
        cobproveedor.Enabled = True
        cobsucursal.Enabled = True
        cobempleado.Enabled = True
        'cobpago.Enabled = True
        cobid.Visible = True
        cobcodigo.Enabled = True
        grid.DataSource = ""




        cobproveedor.DataSource = objConexion.obtenerDatos().Tables("Proveedores").DefaultView
        cobproveedor.DisplayMember = "Proveedor"
        cobproveedor.ValueMember = " Proveedores.IdProveedores"
        cobproveedor.AutoCompleteMode = AutoCompleteMode.Suggest
        cobproveedor.AutoCompleteSource = AutoCompleteSource.ListItems


        cobsucursal.DataSource = objConexion.obtenerDatos().Tables("Sucursal").DefaultView
        cobsucursal.DisplayMember = "Ubicacion"
        cobsucursal.ValueMember = "Sucursal.IdSucursal"
        cobsucursal.AutoCompleteMode = AutoCompleteMode.Suggest
        cobsucursal.AutoCompleteSource = AutoCompleteSource.ListItems


        cobempleado.DataSource = objConexion.obtenerDatos().Tables("Empleados").DefaultView
        cobempleado.DisplayMember = "NombreCompleto"
        cobempleado.ValueMember = "Empleados.IdEmpleado"
        cobempleado.AutoCompleteMode = AutoCompleteMode.Suggest
        cobempleado.AutoCompleteSource = AutoCompleteSource.ListItems





        cobid.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
        cobid.DisplayMember = "IdSolicitudes"
        cobid.ValueMember = "Solicitudes.IdSolicitudes"
        cobid.AutoCompleteMode = AutoCompleteMode.Suggest
        cobid.AutoCompleteSource = AutoCompleteSource.ListItems


        cobcodigo.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
        cobcodigo.DisplayMember = "Codigo"
        cobcodigo.ValueMember = "Solicitudes.IdSolicitudes"
        cobcodigo.AutoCompleteMode = AutoCompleteMode.Suggest
        cobcodigo.AutoCompleteSource = AutoCompleteSource.ListItems


    End Sub

    Private Sub filtro(ByVal valor As String)

        Dim bs As New BindingSource()
        bs.DataSource = grid.DataSource
        bs.Filter = buscarpor1 + " like '%" & valor & "%' or " + buscarpor2 + " like '%" & valor & "%'"
        grid.DataSource = bs

    End Sub

    Private Sub cobcodigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobcodigo.SelectedIndexChanged
        filtro(cobcodigo.Text.Trim)


        totalizar()


    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'Boton primero
    Private Sub btnnuevoyaceptar_Click(sender As Object, e As EventArgs) Handles btnnuevoyaceptar.Click
        If btnnuevoyaceptar.Text = "Nuevo" Then 'Nuevo
            btnnuevoyaceptar.Text = "Aceptar"
            btnmodificarycancelar.Text = "Cancelar"
            accion = "nuevo"
            btneliminar.Enabled = False
            cargar2()


            'si el boton dice aceptar, significa que esta aceptando el nuevo registro y lo envia a la base
        ElseIf btnnuevoyaceptar.Text = "Aceptar" Then
            comandosql = comandoinsertar

            Dim msg = objConexion.mantenimientosolicitudes(New String() {
            "",                 'dato(0) para el id, incrementa automaticamente no necesita enviar nada 
            cobcodigo.Text,        'dato(2)
            cobproveedor.SelectedValue,        'dato(2)
            cobempleado.SelectedValue,
            calendario.Text,'dato(2)
            cobsucursal.SelectedValue}, 'dato(2)
          accion, comandosql, idTabla) 'accion que se desea realizar en el case
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            cargar()

            obtenerdatossolicitudhecha()

            If msg = "Accion realizada" Then
                MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btneliminar.Enabled = True


                Dim newventada As New detallesolicitud
                newventada.ShowDialog()
                Close()
                'If objBuscarCategoriaProducto._idC > 0 Then
                'cboCategoriaProductos.SelectedValue = objBuscarCategoriaProducto._idC
                'End If
            ElseIf msg = "Error en el proceso" Then
                    MessageBox.Show("Error en el proceso, probablemente el numero de solicitud ya existe", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btneliminar.Enabled = True
            End If




        Else 'si el boton dice Guardar, significa que esta haciendo un cambio de un dato
            comandosql = comandoactualizar
            Dim msg = objConexion.mantenimientosolicitudes(New String() {
              cobid.SelectedValue,      'dato(0) si se envia el id aqui porque es el que identifica el registro, update from id = x
               cobcodigo.Text,        'dato(2)
            cobproveedor.SelectedValue,        'dato(2)
            cobempleado.SelectedValue,
            calendario.Text,'dato(2)
            cobsucursal.SelectedValue}, 'dato(3)
              accion, comandosql, idTabla)

            obtenerdatossolicitudhecha()
            MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            btneliminar.Enabled = True
        End If
    End Sub



    Private Sub btnmodificarycancelar_Click(sender As Object, e As EventArgs) Handles btnmodificarycancelar.Click
        If btnmodificarycancelar.Text = "Modificar" Then 'Nuevo
            cargar3()
            btnnuevoyaceptar.Text = "Guardar"
            btnmodificarycancelar.Text = "Cancelar"
            btneliminar.Enabled = False
            accion = "modificar"
        Else 'Guardar
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            obtenerdatossolicitudhecha()

            btneliminar.Enabled = True
        End If
    End Sub





    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If cobid.Text <> "" Then
            If (MessageBox.Show("Esta seguro de borrar " + cobcodigo.Text, mensajeenmentana,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                comandosql = Nombretabladebusqueda
                Dim msg = objConexion.mantenimientosolicitudes(New String() {cobid.Text}, "eliminar", comandosql, idTabla)
                If msg = "Error en el proceso" Then
                    MessageBox.Show("No se pudo eliminar este registro, porque hay registros que dependen de el", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else MessageBox.Show("Debe selecionar un registro para eliminar", mensajeenmentana)
        End If
        obtenerdatossolicitudhecha()
    End Sub




    Private Sub totalizar()

        ' cobfactura.ValueMember = "Tipofactura.Idtipofactura"
        'lblRespuestaIva.Text = cobfactura.Text
        Try

            If grid.Rows.Count > 0 And grid.Columns.Count > 3 Then
                Dim fila As DataGridViewRow
                Dim nfilas As Integer = grid.Rows.Count - 1
                Dim subtotal, sumas, total As Double
                Dim iva As Double
                For i As Integer = 0 To nfilas
                    fila = grid.Rows(i)


                    subtotal = Double.Parse(fila.Cells(6).Value.ToString()) '* Double.Parse(fila.Cells("precio").Value.ToString())

                    'fila.Cells("subtotal").Value = subtotal.ToString()
                    sumas += subtotal

                Next
                '        iva = If(cobfactura.SelectedValue = 2, sumas * 0.13, 0)
                total = sumas + iva


                lblRespuestaSuma.Text = "$ " + Math.Round(sumas, 2).ToString()
                lblRespuestaIva.Text = "$ " + Math.Round(iva, 2).ToString()
                lblRespuestaTotal.Text = "$ " + Math.Round(total, 2).ToString()

                '   lblnregistros.Text = (VentasBindingSource.Position + 1) & " de " & VentasBindingSource.Count

            Else lblRespuestaSuma.Text = "$ 0"
                lblRespuestaIva.Text = "$ 0"
                lblRespuestaTotal.Text = "$ 0"
            End If

        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.idcompra = cobid.Text
        Module1.factura = cobcodigo.Text

        Dim newventada As New detallesolicitud
        newventada.ShowDialog()
        Close()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newventada As New solicitudes
        newventada.ShowDialog()

        Dim j = newventada.idddd
        If j > 0 Then
            cobcodigo.SelectedValue = newventada.idddd
        End If



    End Sub


End Class

