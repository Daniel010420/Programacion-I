﻿Public Class Nuevacompra
    'Realiza la conexion a la base solo para este formulario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim comandosql = ""
    Dim objdetalle As New detallecompra



    Dim mensajeenmentana = "Registro de Compra"
    Dim Nombretabladebusqueda = "Compras"
    Dim buscarpor1 = "nunfactura"
    Dim buscarpor2 = "Nunfactura"

    Dim idTabla = "IdCompra"
    Dim comandoinsertar = Nombretabladebusqueda + " (nunfactura,IdProveedor,IdTipoFactura,fecha,IdFormaPago,IdSucursal)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda

    Private Sub pedidossolicitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Visible = False

        ' obtenerdatos()


        obtenerdatosfacturashechas()
    End Sub

    Sub obtenerdatosfacturashechas()
        Try
            'la palabra Empleados es la palabra que envia la peticion de la tabla que quiere
            'la palabra datos tabla es la que recibe los resultados de la tabla
            'llenar los datos del grid
            grid.DataSource = objConexion.obtenerDatos().Tables("Compras").DefaultView

            grid.Columns(1).Visible = False
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            grid.Columns(11).Visible = False
            grid.Columns(12).Visible = False
            '   grid.Columns(0).Visible = False
            grid.Columns(0).DisplayIndex = 12


            cobproveedor.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
            cobproveedor.DisplayMember = "Proveedor"
            cobproveedor.ValueMember = " Proveedores.IdProveedores"

            cobsucursal.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
            cobsucursal.DisplayMember = "Ubicacion"
            cobsucursal.ValueMember = "Sucursal.IdSucursal"

            cobfactura.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
            cobfactura.DisplayMember = "tipofactura"
            cobfactura.ValueMember = "Tipofactura.Idtipofactura"

            cobpago.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
            cobpago.DisplayMember = "Formapago"
            cobpago.ValueMember = "Formapago.Idformapago"



            cobid.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
            cobid.DisplayMember = "IdCompra"
            cobid.ValueMember = "Compras.IdCompra"




            cobfacturas.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
            cobfacturas.DisplayMember = "nunfactura"
            cobfacturas.ValueMember = "Compras.IdCompra"
            cobfacturas.AutoCompleteMode = AutoCompleteMode.Suggest
            cobfacturas.AutoCompleteSource = AutoCompleteSource.ListItems




            cargar()
            filtro(cobfacturas.Text.Trim)
            totalizar()
        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try
    End Sub



    Private Sub cargar()
        cobproveedor.Enabled = False
        cobsucursal.Enabled = False
        cobfactura.Enabled = False
        cobfacturas.Enabled = True
        cobpago.Enabled = False
        cobid.Visible = False
    End Sub

    Private Sub cargar2()
        cobproveedor.Enabled = True
        cobsucursal.Enabled = True
        cobfactura.Enabled = True
        cobpago.Enabled = True
        cobid.Visible = True
        'cobfacturas.Enabled = False
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


        cobfactura.DataSource = objConexion.obtenerDatos().Tables("Factura").DefaultView
        cobfactura.DisplayMember = "tipofactura"
        cobfactura.ValueMember = "Tipofactura.Idtipofactura"
        cobfactura.AutoCompleteMode = AutoCompleteMode.Suggest
        cobfactura.AutoCompleteSource = AutoCompleteSource.ListItems


        cobpago.DataSource = objConexion.obtenerDatos().Tables("formapago").DefaultView
        cobpago.DisplayMember = "Formapago"
        cobpago.ValueMember = "Formapago.Idformapago"
        cobpago.AutoCompleteMode = AutoCompleteMode.Suggest
        cobpago.AutoCompleteSource = AutoCompleteSource.ListItems


        cobid.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
        cobid.DisplayMember = "IdCompra"
        cobid.ValueMember = "Compras.IdCompra"
        cobid.AutoCompleteMode = AutoCompleteMode.Suggest
        cobid.AutoCompleteSource = AutoCompleteSource.ListItems


        cobfacturas.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
        cobfacturas.DisplayMember = "nunfactura"
        cobfacturas.ValueMember = "Compras.IdCompra"
        cobfacturas.AutoCompleteMode = AutoCompleteMode.Suggest
        cobfacturas.AutoCompleteSource = AutoCompleteSource.ListItems

    End Sub

    Private Sub txtfiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles cobfacturas.KeyUp
        filtro(cobfacturas.Text.Trim)

    End Sub



    Private Sub cargar3()
        cobproveedor.Enabled = True
        cobsucursal.Enabled = True
        cobfactura.Enabled = True
        cobpago.Enabled = True
        cobid.Visible = True
        cobfacturas.Enabled = True
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


        cobfactura.DataSource = objConexion.obtenerDatos().Tables("Factura").DefaultView
        cobfactura.DisplayMember = "tipofactura"
        cobfactura.ValueMember = "Tipofactura.Idtipofactura"
        cobfactura.AutoCompleteMode = AutoCompleteMode.Suggest
        cobfactura.AutoCompleteSource = AutoCompleteSource.ListItems


        cobpago.DataSource = objConexion.obtenerDatos().Tables("formapago").DefaultView
        cobpago.DisplayMember = "Formapago"
        cobpago.ValueMember = "Formapago.Idformapago"
        cobpago.AutoCompleteMode = AutoCompleteMode.Suggest
        cobpago.AutoCompleteSource = AutoCompleteSource.ListItems


        cobid.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
        cobid.DisplayMember = "IdCompra"
        cobid.ValueMember = "Compras.IdCompra"
        cobid.AutoCompleteMode = AutoCompleteMode.Suggest
        cobid.AutoCompleteSource = AutoCompleteSource.ListItems


        cobfacturas.DataSource = objConexion.obtenerDatos().Tables("FacturaCompras").DefaultView
        cobfacturas.DisplayMember = "nunfactura"
        cobfacturas.ValueMember = "Compras.IdCompra"
        cobfacturas.AutoCompleteMode = AutoCompleteMode.Suggest
        cobfacturas.AutoCompleteSource = AutoCompleteSource.ListItems


    End Sub

    Private Sub filtro(ByVal valor As String)

        Dim bs As New BindingSource()
        bs.DataSource = grid.DataSource
        bs.Filter = buscarpor1 + " like '%" & valor & "%' or " + buscarpor2 + " like '%" & valor & "%'"
        grid.DataSource = bs

    End Sub

    Private Sub cobfacturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobfacturas.SelectedIndexChanged
        filtro(cobfacturas.Text.Trim)


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

            Dim msg = objConexion.mantenimientocompra(New String() {
            "",                 'dato(0) para el id, incrementa automaticamente no necesita enviar nada 
            cobfacturas.Text,        'dato(2)
            cobproveedor.SelectedValue,        'dato(2)
            cobfactura.SelectedValue,
            calendario.Text,'dato(2)
            cobpago.SelectedValue, 'dato(2)
            cobsucursal.SelectedValue}, 'dato(2)
          accion, comandosql, idTabla) 'accion que se desea realizar en el case
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            cargar()

            obtenerdatosfacturashechas()



            If msg = "Accion realizada" Then
                MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btneliminar.Enabled = True


                Dim newventada As New detallecompra
                newventada.ShowDialog()
                Close()
                '  If objBuscarCategoriaProducto._idC > 0 Then
                '    cboCategoriaProductos.SelectedValue = objBuscarCategoriaProducto._idC
                'End If
            ElseIf msg = "Error en el proceso" Then
                MessageBox.Show("Error en el proceso, probablemente el numero de factura ya existe", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btneliminar.Enabled = True
            End If




        Else 'si el boton dice Guardar, significa que esta haciendo un cambio de un dato
            comandosql = comandoactualizar
            Dim msg = objConexion.mantenimientocompra(New String() {
              cobid.SelectedValue,      'dato(0) si se envia el id aqui porque es el que identifica el registro, update from id = x
               cobfacturas.Text,        'dato(2)
            cobproveedor.SelectedValue,        'dato(2)
            cobfactura.SelectedValue,
            calendario.Text,'dato(2)
            cobpago.SelectedValue, 'dato(2)
            cobsucursal.SelectedValue}, 'dato(3)
              accion, comandosql, idTabla)

            obtenerdatosfacturashechas()
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
            obtenerdatosfacturashechas()

            btneliminar.Enabled = True
        End If
    End Sub





    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If cobid.Text <> "" Then
            If (MessageBox.Show("Esta seguro de borrar " + cobfacturas.Text, mensajeenmentana,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                comandosql = Nombretabladebusqueda
                Dim msg = objConexion.mantenimientocompra(New String() {cobid.Text}, "eliminar", comandosql, idTabla)
                If msg = "Error en el proceso" Then
                    MessageBox.Show("No se pudo eliminar este registro, porque hay registros que dependen de el", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else MessageBox.Show("Debe selecionar un registro para eliminar", mensajeenmentana)
        End If
        obtenerdatosfacturashechas()
    End Sub




    Private Sub totalizar()

        cobfactura.ValueMember = "Tipofactura.Idtipofactura"
        'lblRespuestaIva.Text = cobfactura.Text
        Try

            If grid.Rows.Count > 0 And grid.Columns.Count > 3 Then
                Dim fila As DataGridViewRow

                Dim nfilas As Integer = grid.Rows.Count - 1
                Dim subtotal, sumas, total As Double
                Dim iva As Double
                For i As Integer = 0 To nfilas
                    fila = grid.Rows(i)


                    subtotal = Double.Parse(fila.Cells(6).Value.ToString()) + Double.Parse(fila.Cells(7).Value.ToString()) '* Double.Parse(fila.Cells("precio").Value.ToString())


                    fila.Cells("subtotal").Value = subtotal.ToString()
                    sumas += subtotal

                Next
                iva = If(cobfactura.SelectedValue = 2, sumas * 0.13, 0)
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
        Module1.factura = cobfacturas.Text

        Dim newventada As New detallecompra
        newventada.ShowDialog()
        Close()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newventada As New Facturas
        newventada.ShowDialog()

        Dim j = newventada.idddd
        If j > 0 Then
            cobfacturas.SelectedValue = newventada.idddd
        End If



    End Sub

    Private Sub cobfactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobfactura.SelectedIndexChanged
        cobfactura.ValueMember = "Tipofactura.Idtipofactura"
        'lblRespuestaIva.Text = cobfactura.Text
        totalizar()


    End Sub
End Class
