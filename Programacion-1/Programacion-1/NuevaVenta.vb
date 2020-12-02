Public Class NuevaVenta

    'Realiza la conexion a la base solo para este formulario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim comandosql = ""

    ' Dim objdetalle As New detallecompra



    Dim mensajeenmentana = "Registro de Ventas"
    Dim Nombretabladebusqueda = "Ventas"
    Dim buscarpor1 = "numfactura"
    Dim buscarpor2 = "Numfactura"

    Dim idTabla = "IdVentas"
    Dim comandoinsertar = Nombretabladebusqueda + " (numfactura, fechaventa, IdFormapago, IdCliente, Idtipofactura, IdEmpleado, Idsucursal)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda
    Private Sub NuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cobcliented.DataSource = objConexion.obtenerDatos().Tables("Clientes").DefaultView
            cobcliented.DisplayMember = "Nombre"
            cobcliented.ValueMember = "Clientes.IdClientes"
            cobcliented.AutoCompleteMode = AutoCompleteMode.Suggest
            cobcliented.AutoCompleteSource = AutoCompleteSource.ListItems

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


            cobfacturad.DataSource = objConexion.obtenerDatos().Tables("Factura").DefaultView
            cobfacturad.DisplayMember = "tipofactura"
            cobfacturad.ValueMember = "Tipofactura.Idtipofactura"
            cobfacturad.AutoCompleteMode = AutoCompleteMode.Suggest
            cobfacturad.AutoCompleteSource = AutoCompleteSource.ListItems

            cobpagod.DataSource = objConexion.obtenerDatos().Tables("formapago").DefaultView
            cobpagod.DisplayMember = "Formapago"
            cobpagod.ValueMember = "Formapago.Idformapago"
            cobpagod.AutoCompleteMode = AutoCompleteMode.Suggest
            cobpagod.AutoCompleteSource = AutoCompleteSource.ListItems



            ' //////////////////////////////////////////////////////////////////////////////////////////////

            cobid.DataSource = objConexion.obtenerDatos().Tables("nuevaventa").DefaultView
            cobid.DisplayMember = "IdVentas"
            cobid.ValueMember = "Ventas.IdVentas"

            cobclientelist.DataSource = objConexion.obtenerDatos().Tables("nuevaventa").DefaultView
            cobclientelist.DisplayMember = "Nombre"
            cobclientelist.ValueMember = "Clientes.IdClientes"

            cobsucursallist.DataSource = objConexion.obtenerDatos().Tables("nuevaventa").DefaultView
            cobsucursallist.DisplayMember = "Ubicacion"
            cobsucursallist.ValueMember = "Sucursal.IdSucursal"


            cobempleadoslist.DataSource = objConexion.obtenerDatos().Tables("nuevaventa").DefaultView
            cobempleadoslist.DisplayMember = "NombreCompleto"
            cobempleadoslist.ValueMember = "Empleados.IdEmpleado"


            cobfacturalist.DataSource = objConexion.obtenerDatos().Tables("nuevaventa").DefaultView
            cobfacturalist.DisplayMember = "tipofactura"
            cobfacturalist.ValueMember = "Tipofactura.Idtipofactura"

            cobpagolist.DataSource = objConexion.obtenerDatos().Tables("nuevaventa").DefaultView
            cobpagolist.DisplayMember = "Formapago"
            cobpagolist.ValueMember = "Formapago.Idformapago"

            cobfacturaslist.DataSource = objConexion.obtenerDatos().Tables("nuevaventa").DefaultView
            cobfacturaslist.DisplayMember = "numfactura"
            cobfacturaslist.ValueMember = "Ventas.IdVentas"
            cobfacturaslist.AutoCompleteMode = AutoCompleteMode.Suggest
            cobfacturaslist.AutoCompleteSource = AutoCompleteSource.ListItems

            cobfecha.DataSource = objConexion.obtenerDatos().Tables("nuevaventa").DefaultView
            cobfecha.DisplayMember = "fechaventa"


            Label5.text = Module1.idempleado

        Catch ex As Exception
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try

        cargargrid()
        obtenerdatosfacturashechas()

        mostrardatos()


    End Sub

    Sub obtenerdatosfacturashechas()
        Try
            cobfacturaslist.DataSource = objConexion.obtenerDatos().Tables("nuevaventa").DefaultView
            cobfacturaslist.DisplayMember = "numfactura"
            cobfacturaslist.ValueMember = "Ventas.IdVentas"
            cobfacturaslist.AutoCompleteMode = AutoCompleteMode.Suggest
            cobfacturaslist.AutoCompleteSource = AutoCompleteSource.ListItems

            grid.Columns(2).Visible = False
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            grid.Columns(11).Visible = False
            grid.Columns(12).Visible = False

            grid.Columns(0).DisplayIndex = 12
            grid.Columns(1).DisplayIndex = 11

            cobempleadod.SelectedValue = Module1.idempleado

            'grid.Columns(6).HeaderText = "Precio Unidad"
        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
    End Sub

    Sub cargargrid()
        Try
            grid.DataSource = objConexion.obtenerDatos().Tables("detalleventa").DefaultView


            filtro(cobfacturaslist.Text.Trim)

        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
    End Sub

    Private Sub txtfiltro_KeyUp(sender As Object, e As KeyEventArgs)
        filtro(cobfacturaslist.Text.Trim)

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
        If btnnuevoyaceptar.Text = "Nuevo" Then 'Nuevo
            btnnuevoyaceptar.Text = "Aceptar"
            btnmodificarycancelar.Text = "Cancelar"
            accion = "nuevo"
            btneliminar.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            cobempleadod.SelectedValue = Module1.idempleado
            agregaryactualizardatos()
            cobfacturad.SelectedValue = 2

            'si el boton dice aceptar, significa que esta aceptando el nuevo registro y lo envia a la base
        ElseIf btnnuevoyaceptar.Text = "Aceptar" Then
            comandosql = comandoinsertar
            If txtfacturad.Text <> "" Then
                Dim msg = objConexion.mantenimientoventas(New String() {
            "",                 'dato(0) para el id, incrementa automaticamente no necesita enviar nada 
            txtfacturad.Text,        'dato(2)
            calendariod.Text,
            cobpagod.SelectedValue,'dato(2
            cobcliented.SelectedValue,
            cobfacturad.SelectedValue,
            cobempleadod.SelectedValue,
                cobsucursald.SelectedValue}, 'dato(2)
          accion, comandosql, idTabla) 'accion que se desea realizar en el case

                Module1.tclientes = cobcliented.SelectedValue

                btnnuevoyaceptar.Text = "Nuevo"
                btnmodificarycancelar.Text = "Modificar"
                Button1.Enabled = True
                Button2.Enabled = True
                txtfacturad.Text = ""

                mostrardatos()


                If msg = "Accion realizada" Then
                    MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btneliminar.Enabled = True

                    Dim newventada As New detalleventa
                    newventada.ShowDialog()

                    obtenerdatosfacturashechas()
                    cargargrid()
                    Dim j = newventada.c
                    If j > 0 Then
                        cobfacturaslist.SelectedValue = newventada.c
                    End If
                    totalizar()
                ElseIf msg = "Error en el proceso" Then
                    MessageBox.Show("Error en el proceso, probablemente el numero de factura ya existe", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btneliminar.Enabled = True
                End If
            Else MessageBox.Show("Por favor escribe un nombre de factura", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            cobempleadod.SelectedValue = Module1.idempleado
        Else 'si el boton dice Guardar, significa que esta haciendo un cambio de un dato
            Button1.Enabled = True
            Button2.Enabled = True
            comandosql = comandoactualizar
            Dim msg = objConexion.mantenimientoventas(New String() {
              cobid.SelectedValue,      'dato(0) si se envia el id aqui porque es el que identifica el registro, update from id = x
            txtfacturad.Text,        'dato(2)
            calendariod.Text,
            cobpagod.SelectedValue,'dato(2
            cobcliented.SelectedValue,
            cobfacturad.SelectedValue,
            cobempleadod.SelectedValue,
                cobsucursald.SelectedValue}, 'dato(3)
              accion, comandosql, idTabla)

            Dim s = cobfacturaslist.SelectedValue

            MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
            obtenerdatosfacturashechas()

            cobfacturaslist.SelectedValue = s
            filtro(cobfacturaslist.Text.Trim)
            totalizar()
            mostrardatos()
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            btneliminar.Enabled = True
        End If
    End Sub



    Private Sub btnmodificarycancelar_Click(sender As Object, e As EventArgs) Handles btnmodificarycancelar.Click
        If btnmodificarycancelar.Text = "Modificar" Then 'Nuevo
            cobempleadod.SelectedValue = Module1.idempleado

            If cobempleadod.Text.Trim = cobempleadoslist.Text.Trim Then
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
        End If
        cobempleadod.SelectedValue = Module1.idempleado
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        cobempleadod.SelectedValue = Module1.idempleado
        If cobempleadod.Text.Trim = cobempleadoslist.Text.Trim Then
            If cobid.Text <> "" Then
                If (MessageBox.Show("Esta seguro de borrar " + cobfacturaslist.Text, mensajeenmentana,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    comandosql = Nombretabladebusqueda
                    Dim msg = objConexion.mantenimientoventas(New String() {cobid.Text}, "eliminar", comandosql, idTabla)
                    If msg = "Error en el proceso" Then
                        MessageBox.Show("No se pudo eliminar este registro, porque hay registros que dependen de el", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    If msg <> "Error en el proceso" Then
                        obtenerdatosfacturashechas()

                        filtro(cobfacturaslist.Text.Trim)
                        totalizar()

                    End If
                End If
            Else MessageBox.Show("Debe selecionar un registro para eliminar", mensajeenmentana)
            End If
        End If



    End Sub


    Private Sub totalizar()

        cobfacturalist.ValueMember = "Tipofactura.Idtipofactura"
        'lblRespuestaIva.Text = cobfactura.Text
        Try

            If grid.Rows.Count > 0 And grid.Columns.Count > 3 Then
                Dim fila As DataGridViewRow

                Dim nfilas As Integer = grid.Rows.Count - 1
                Dim subtotal, sumas, total, cu As Double
                Dim iva As Double
                For i As Integer = 0 To nfilas
                    fila = grid.Rows(i)


                    cu = Math.Round(Double.Parse(fila.Cells(7).Value.ToString()) / Double.Parse(fila.Cells(6).Value.ToString()), 2) '* Double.Parse(fila.Cells("precio").Value.ToString())
                    fila.Cells("cu").Value = cu.ToString()

                    subtotal = Double.Parse(fila.Cells(7).Value.ToString())
                    fila.Cells("subtotal").Value = subtotal.ToString()



                    sumas += subtotal

                Next
                iva = If(cobfacturalist.SelectedValue = 1, sumas * 0.13, 0)
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
        cobempleadod.SelectedValue = Module1.idempleado
        If cobempleadod.Text.Trim = cobempleadoslist.Text.Trim Then
            Module1.idcompra = cobid.Text
            Module1.factura = cobfacturaslist.Text
            Module1.tclientes = cobclientelist.SelectedValue
            Dim newventada As New detalleventa
            newventada.ShowDialog()
            cargargrid()
            Dim j = newventada.c
            If j > 0 Then
                cobfacturaslist.SelectedValue = newventada.c
            End If
            totalizar()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newventada As New ventas
        newventada.ShowDialog()
        Dim j = newventada.idddd
        If j > 0 Then
            cobfacturaslist.SelectedValue = newventada.idddd
        End If
        cobempleadod.SelectedValue = Module1.idempleado
    End Sub

    Private Sub cobfactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobfacturad.SelectedIndexChanged
        cobfacturalist.ValueMember = "Tipofactura.Idtipofactura"
        totalizar()
    End Sub

    Private Sub cobfacturaslist_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cobfacturaslist.SelectedIndexChanged
        filtro(cobfacturaslist.Text.Trim)
        totalizar()
    End Sub

    Private Sub cobfacturaslist_SelectedValueChanged(sender As Object, e As EventArgs) Handles cobfacturaslist.SelectedValueChanged
        filtro(cobfacturaslist.Text.Trim)
        totalizar()
    End Sub


    Private Sub mostrardatos()
        cobcliented.Visible = False
        calendariod.Visible = False
        cobsucursald.Visible = False
        txtfacturad.Visible = False
        cobfacturad.Visible = False
        cobpagod.Visible = False
        cobempleadod.Visible = False
        cobid.Visible = False

        cobclientelist.Visible = True
        cobsucursallist.Visible = True
        cobfacturalist.Visible = True
        cobfecha.Visible = True
        cobpagolist.Visible = True
        cobfacturaslist.Visible = True

        cobclientelist.Enabled = False
        cobsucursallist.Enabled = False
        cobfacturalist.Enabled = False
        cobfecha.Enabled = False
        cobpagolist.Enabled = False
        cobfacturaslist.Enabled = True
        cobempleadoslist.Enabled = False
        cobempleadoslist.Visible = True

        cobid.Visible = False

        grid.Visible = True
        GroupBox1.Visible = True
        Panel1.Visible = True
    End Sub


    Private Sub agregaryactualizardatos()
        If btnnuevoyaceptar.Text = "Aceptar" Then
            cobcliented.Visible = True
            calendariod.Visible = True
            cobsucursald.Visible = True
            txtfacturad.Visible = True
            cobfacturad.Visible = True
            cobpagod.Visible = True
            cobempleadod.Visible = True
            cobid.Visible = True
            cobempleadod.Enabled = False

            cobclientelist.Visible = False
            cobsucursallist.Visible = False
            cobfacturalist.Visible = False
            cobfecha.Visible = False
            cobpagolist.Visible = False
            cobfacturaslist.Visible = False
            cobempleadoslist.Visible = False

            cobid.Visible = False

            grid.Visible = True
            Panel1.Visible = True


        End If

        If btnnuevoyaceptar.Text = "Guardar" Then
            cobempleadod.Enabled = False
            cobcliented.Visible = True
            calendariod.Visible = True
            cobsucursald.Visible = True
            cobfacturalist.Visible = False
            txtfacturad.Visible = False
            cobfacturaslist.Visible = True
            cobpagod.Visible = True
            cobempleadod.Visible = True
            cobid.Visible = True


            cobclientelist.Visible = False
            cobsucursallist.Visible = False
            cobfecha.Visible = False
            cobpagolist.Visible = False
            '  cobfacturaslist.Visible = False
            cobempleadoslist.Visible = False

            cobid.Visible = False
            cobfacturad.Visible = True

            grid.Visible = True
            Panel1.Visible = True

        End If

        GroupBox1.Visible = False
        grid.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub cobfacturalist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobfacturalist.SelectedIndexChanged
        cobfacturalist.ValueMember = "Tipofactura.Idtipofactura"
        totalizar()
    End Sub

    Private Sub txtrecibe_TextChanged(sender As Object, e As EventArgs) Handles txtrecibe.TextChanged
        If txtrecibe.Text <> "" Then
            Dim total = lblRespuestaTotal.Text
            Dim paga = txtrecibe.Text
            Dim diferencia = paga - total
            Dim denominaciones() = {100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01}, cantidad = 0
            Dim denomina As String

            lstEjercicios.Items.Clear()

            If diferencia > 0 Then
                For Each denominacion In denominaciones
                    While diferencia > 0 And denominacion <= diferencia
                        diferencia = Math.Round(diferencia - denominacion, 2)
                        cantidad += 1
                    End While
                    If cantidad > 0 Then
                        If denominacion <= 1 Then
                            denomina = " moneda de "
                        Else
                            denomina = " billete de "
                        End If
                        lstEjercicios.Items.Add(cantidad.ToString() + denomina + denominacion.ToString())
                        cantidad = 0
                    End If
                Next

            End If
        End If

    End Sub

    Private Sub txtrecibe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrecibe.KeyPress
        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) _
           AndAlso (Not e.KeyChar = "." Or txtrecibe.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim newventana As New imprimirventa
        newventana.idventaaa = cobfacturaslist.SelectedValue
        newventana.ShowDialog()
    End Sub
End Class

