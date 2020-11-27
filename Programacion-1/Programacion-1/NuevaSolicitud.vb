Public Class NuevaSolicitud
    'Realiza la conexion a la base solo para este formulario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim comandosql = ""
    ' Dim objdetalle As New detallecompra


    Dim mensajeenmentana = "Registro de Solicitud"
    Dim Nombretabladebusqueda = "Solicitudes"
    Dim buscarpor1 = "Codigo"
    Dim buscarpor2 = "Codigo"

    Dim idTabla = "IdSolicitudes"
    Dim comandoinsertar = Nombretabladebusqueda + " (Codigo,IdProveedor,IdEmpleado,fecha_Registro,IdSucursal)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda
    Private Sub NuevaSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cobproveedord.DataSource = objConexion.obtenerDatos().Tables("Proveedores").DefaultView
            cobproveedord.DisplayMember = "Proveedor"
            cobproveedord.ValueMember = " Proveedores.IdProveedores"
            cobproveedord.AutoCompleteMode = AutoCompleteMode.Suggest
            cobproveedord.AutoCompleteSource = AutoCompleteSource.ListItems

            cobsucursald.DataSource = objConexion.obtenerDatos().Tables("Sucursal").DefaultView
            cobsucursald.DisplayMember = "Ubicacion"
            cobsucursald.ValueMember = "Sucursal.IdSucursal"
            cobsucursald.AutoCompleteMode = AutoCompleteMode.Suggest
            cobsucursald.AutoCompleteSource = AutoCompleteSource.ListItems

            cobempleadod.DataSource = objConexion.obtenerDatos().Tables("Empleados").DefaultView
            cobempleadod.DisplayMember = "NombreCompleto"
            cobempleadod.ValueMember = "Empleados.IdEmpleado"
            cobempleadod.AutoCompleteMode = AutoCompleteMode.Suggest
            cobempleadod.AutoCompleteSource = AutoCompleteSource.ListItems


            cobid.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobid.DisplayMember = "IdSolicitudes"
            cobid.ValueMember = "Solicitudes.IdSolicitudes"

            ' //////////////////////////////////////////////////////////////////////////////////////////////

            cobproveedorlist.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobproveedorlist.DisplayMember = "Proveedor"
            cobproveedorlist.ValueMember = " Proveedores.IdProveedores"

            cobsucursallist.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobsucursallist.DisplayMember = "Ubicacion"
            cobsucursallist.ValueMember = "Sucursal.IdSucursal"

            cobempleadolist.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobempleadolist.DisplayMember = "NombreCompleto"
            cobempleadolist.ValueMember = "Empleados.IdEmpleado"



            cobcodigolist.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobcodigolist.DisplayMember = "Codigo"
            cobcodigolist.ValueMember = "Solicitudes.IdSolicitudes"
            cobcodigolist.AutoCompleteMode = AutoCompleteMode.Suggest
            cobcodigolist.AutoCompleteSource = AutoCompleteSource.ListItems

            cobfecha.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobfecha.DisplayMember = "Fecha_Registro"
            cobid.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobid.DisplayMember = "IdSolicitudes"
            cobid.ValueMember = "Solicitudes.IdSolicitudes"


        Catch ex As Exception
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
        obtenerdatosfacturashechas()
        cargargrid()

        mostrardatos()

    End Sub

    Sub obtenerdatosfacturashechas()
        Try
            cobcodigolist.DataSource = objConexion.obtenerDatos().Tables("nuevasolicitud").DefaultView
            cobcodigolist.DisplayMember = "Codigo"
            cobcodigolist.ValueMember = "Solicitudes.IdSolicitudes"
            cobcodigolist.AutoCompleteMode = AutoCompleteMode.Suggest
            cobcodigolist.AutoCompleteSource = AutoCompleteSource.ListItems


            cobempleadod.SelectedValue = Module1.idempleado
        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
    End Sub

    Sub cargargrid()
        Try
            grid.DataSource = objConexion.obtenerDatos().Tables("detallesolicitud").DefaultView


            grid.DataSource = objConexion.obtenerDatos().Tables("detallesolicitud").DefaultView


            grid.Columns(2).Visible = False
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            grid.Columns(11).Visible = False
            grid.Columns(12).Visible = False

            grid.Columns(0).DisplayIndex = 10
            grid.Columns(1).DisplayIndex = 9


            filtro(cobcodigolist.Text.Trim)
            totalizar()
            cobempleadod.SelectedValue = Module1.idempleado
        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
    End Sub

    Private Sub txtfiltro_KeyUp(sender As Object, e As KeyEventArgs)
        filtro(cobcodigolist.Text.Trim)

    End Sub

    Private Sub filtro(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grid.DataSource
        bs.Filter = buscarpor1 + " like '%" & valor & "%' or " + buscarpor2 + " like '%" & valor & "%'"
        grid.DataSource = bs
    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'Boton primero
    Private Sub btnnuevoyaceptar_Click(sender As Object, e As EventArgs) Handles btnnuevoyaceptar.Click


        cobempleadod.SelectedValue = Module1.idempleado
        If btnnuevoyaceptar.Text = "Nuevo" Then 'Nuevo
            btnnuevoyaceptar.Text = "Aceptar"
            btnmodificarycancelar.Text = "Cancelar"
            accion = "nuevo"
            btneliminar.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False

            agregaryactualizardatos()
            ' cobfacturad.SelectedValue = 2

            'si el boton dice aceptar, significa que esta aceptando el nuevo registro y lo envia a la base
        ElseIf btnnuevoyaceptar.Text = "Aceptar" Then
            comandosql = comandoinsertar
            If txtfacturad.Text <> "" Then
                Dim msg = objConexion.mantenimientosolicitudes(New String() {
            "",                 'dato(0) para el id, incrementa automaticamente no necesita enviar nada 
            txtfacturad.Text,        'dato(2)
            cobproveedord.SelectedValue,        'dato(2)
            cobempleadod.SelectedValue,
            calendariod.Text,'dato(2) 'dato(2)
            cobsucursald.SelectedValue}, 'dato(2)
          accion, comandosql, idTabla) 'accion que se desea realizar en el case


                btnnuevoyaceptar.Text = "Nuevo"
                btnmodificarycancelar.Text = "Modificar"
                Button1.Enabled = True
                Button2.Enabled = True
                txtfacturad.Text = ""

                mostrardatos()


                If msg = "Accion realizada" Then
                    MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btneliminar.Enabled = True

                    obtenerdatosfacturashechas()

                    Dim newventada As New detallesolicitud
                    newventada.ShowDialog()

                    Dim j = newventada.b
                    If j > 0 Then
                        cobcodigolist.SelectedValue = newventada.b
                    End If
                    totalizar()
                ElseIf msg = "Error en el proceso" Then
                    MessageBox.Show("Error en el proceso, probablemente el numero de factura ya existe", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btneliminar.Enabled = True
                End If
            Else MessageBox.Show("Por favor escribe un nombre de solicitud", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            cobempleadod.SelectedValue = Module1.idempleado
        Else 'si el boton dice Guardar, significa que esta haciendo un cambio de un dato
            Button1.Enabled = True
            Button2.Enabled = True
            comandosql = comandoactualizar
            Dim msg = objConexion.mantenimientosolicitudes(New String() {
              cobid.SelectedValue,      'dato(0) si se envia el id aqui porque es el que identifica el registro, update from id = x
               cobcodigolist.Text,        'dato(2)
            cobproveedord.SelectedValue,        'dato(2)
            cobempleadod.SelectedValue,
            calendariod.Text,'dato(2)
            cobsucursald.SelectedValue}, 'dato(3)
              accion, comandosql, idTabla)

            Dim s = cobcodigolist.SelectedValue

            MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
            obtenerdatosfacturashechas()

            cobcodigolist.SelectedValue = s
            filtro(cobcodigolist.Text.Trim)
            totalizar()
            mostrardatos()
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            btneliminar.Enabled = True
        End If
    End Sub



    Private Sub btnmodificarycancelar_Click(sender As Object, e As EventArgs) Handles btnmodificarycancelar.Click

        cobempleadod.SelectedValue = Module1.idempleado

        If btnmodificarycancelar.Text = "Modificar" Then 'Nuevo

            If cobempleadod.Text.Trim = cobempleadolist.Text.Trim Then
                btnnuevoyaceptar.Text = "Guardar"
                btnmodificarycancelar.Text = "Cancelar"
                btneliminar.Enabled = False
                accion = "modificar"
                Button1.Enabled = False





                agregaryactualizardatos()
            End If



            'Button2.Enabled = False
        Else 'Guardar
            Button1.Enabled = True
            Button2.Enabled = True
            btnnuevoyaceptar.Text = "Nuevo"
            txtfacturad.Text = ""
            btnmodificarycancelar.Text = "Modificar"
            btneliminar.Enabled = True
            mostrardatos()
            cobempleadod.SelectedValue = Module1.idempleado
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If cobempleadod.Text.Trim = cobempleadolist.Text.Trim Then
            If cobid.Text <> "" Then
                If (MessageBox.Show("Esta seguro de borrar " + cobcodigolist.Text, mensajeenmentana,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    comandosql = Nombretabladebusqueda
                    Dim msg = objConexion.mantenimientosolicitudes(New String() {cobid.Text}, "eliminar", comandosql, idTabla)
                    If msg = "Error en el proceso" Then
                        MessageBox.Show("No se pudo eliminar este registro, porque hay registros que dependen de el", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    If msg <> "Error en el proceso" Then
                        obtenerdatosfacturashechas()

                        filtro(cobcodigolist.Text.Trim)
                        totalizar()

                    End If
                End If
            Else MessageBox.Show("Debe selecionar un registro para eliminar", mensajeenmentana)
            End If

        End If


    End Sub


    Private Sub totalizar()


        ' cobfactura.ValueMember = "Tipofactura.Idtipofactura"
        'lblRespuestaIva.Text = cobfactura.Text
        Try

            If grid.Rows.Count > 0 And grid.Columns.Count > 3 Then
                Dim fila As DataGridViewRow
                Dim nfilas As Integer = grid.Rows.Count - 1
                Dim subtotal, sumas, total, cu As Double
                Dim iva As Double
                For i As Integer = 0 To nfilas
                    fila = grid.Rows(i)


                    subtotal = Math.Round(Double.Parse(fila.Cells(7).Value.ToString()), 2) '* Double.Parse(fila.Cells("precio").Value.ToString())
                    cu = Math.Round(Double.Parse(fila.Cells(7).Value.ToString()) / Double.Parse(fila.Cells(6).Value.ToString()), 2) '* Double.Parse(fila.Cells("precio").Value.ToString())

                    fila.Cells("subtotal").Value = subtotal.ToString()
                    fila.Cells("cu").Value = cu.ToString()
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

        If cobempleadod.Text.Trim = cobempleadolist.Text.Trim Then
            Module1.idcompra = cobid.Text
            Module1.factura = cobcodigolist.Text

            Dim newventada As New detallesolicitud
            newventada.ShowDialog()
            cargargrid()
            Dim j = newventada.b
            If j > 0 Then
                cobcodigolist.SelectedValue = newventada.b
            End If
            totalizar()

        End If

        cobempleadod.SelectedValue = Module1.idempleado

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newventada As New solicitudes
        newventada.ShowDialog()
        Dim j = newventada.idddd
        If j > 0 Then
            cobcodigolist.SelectedValue = newventada.idddd
        End If
    End Sub



    Private Sub cobfacturaslist_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cobcodigolist.SelectedIndexChanged
        filtro(cobcodigolist.Text.Trim)
        totalizar()
    End Sub

    Private Sub cobfacturaslist_SelectedValueChanged(sender As Object, e As EventArgs) Handles cobcodigolist.SelectedValueChanged
        filtro(cobcodigolist.Text.Trim)
        totalizar()
    End Sub

    Private Sub mostrardatos()
        cobproveedord.Visible = False
        calendariod.Visible = False
        cobsucursald.Visible = False
        txtfacturad.Visible = False
        cobempleadod.Visible = False

        cobproveedorlist.Visible = True
        cobsucursallist.Visible = True
        cobempleadolist.Visible = True
        cobfecha.Visible = True
        cobcodigolist.Visible = True
        cobid.Visible = False


        cobproveedorlist.Enabled = False
        cobsucursallist.Enabled = False
        cobempleadolist.Enabled = False
        cobfecha.Enabled = False
        cobcodigolist.Enabled = True
        cobid.Enabled = False

        grid.Visible = True
        Panel1.Visible = True
    End Sub


    Private Sub agregaryactualizardatos()
        If btnnuevoyaceptar.Text = "Aceptar" Then
            cobproveedord.Visible = True
            calendariod.Visible = True
            cobsucursald.Visible = True
            txtfacturad.Visible = True
            cobempleadod.Visible = True

            cobproveedorlist.Visible = False
            cobsucursallist.Visible = False
            cobempleadolist.Visible = False
            cobfecha.Visible = False
            cobcodigolist.Visible = False
            cobid.Visible = False
            cobempleadod.Enabled = False
        End If

        If btnnuevoyaceptar.Text = "Guardar" Then
            cobproveedord.Visible = True
            calendariod.Visible = True
            cobsucursald.Visible = True
            ' txtfacturad.Visible = True
            cobempleadod.Visible = True
            cobempleadod.Enabled = False
            cobproveedorlist.Visible = False
            cobsucursallist.Visible = False
            cobempleadolist.Visible = False
            cobfecha.Visible = False
            cobcodigolist.Visible = True
            cobid.Visible = False
        End If
        grid.Visible = False
        Panel1.Visible = False
    End Sub

End Class

