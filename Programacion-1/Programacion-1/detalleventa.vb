Public Class detalleventa
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim comandosql = ""
    Public c

    Dim mensajeenmentana = "Registro Detalle Venta"
    Dim Nombretabladebusqueda = "detallesventa"
    Dim buscarpor1 = "numfactura"
    Dim buscarpor2 = "NombreMedicamento"

    Dim idTabla = "Iddventas"
    Dim comandoinsertar = Nombretabladebusqueda + " (IdRegistroMedicamento,Cantidad,ingreso,IdVenta)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda
    Private Sub detalleventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cobganancia.Visible = False
        cobdescuento.Visible = False
        coblab.Enabled = False
        cobpre.Enabled = False
        txtid.Visible = False
        txtiddetalle.Visible = False

        cobcliente.Enabled = False
        obtenerdatos()
    End Sub
    Sub obtenerdatos()
        Try
            'la palabra Empleados es la palabra que envia la peticion de la tabla que quiere
            'la palabra datos tabla es la que recibe los resultados de la tabla
            'llenar los datos del grid
            grid.DataSource = objConexion.obtenerDatos().Tables("detalleventa").DefaultView
            grid.Columns(0).Visible = False
            grid.Columns(6).Visible = False
            grid.Columns(7).Visible = False
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False


            txtid.Text = Module1.idcompra
            txtfactura.Text = Module1.factura
            txtfactura.Text = txtfactura.Text.Trim
            txtfactura.Enabled = False


            filtro(txtfiltro.Text)


            cobcliente.DataSource = objConexion.obtenerDatos().Tables("Gananciadescuentocliente").DefaultView
            cobcliente.DisplayMember = "Nombre"
            cobcliente.ValueMember = "Clientes.IdClientes"
            cobcliente.AutoCompleteMode = AutoCompleteMode.Suggest
            cobcliente.AutoCompleteSource = AutoCompleteSource.ListItems

            cobdescuento.DataSource = objConexion.obtenerDatos().Tables("Gananciadescuentocliente").DefaultView
            cobdescuento.DisplayMember = "MargenDescuento"


            cobganancia.DataSource = objConexion.obtenerDatos().Tables("Gananciadescuentocliente").DefaultView
            cobganancia.DisplayMember = "MargenGanancia"

            cobmedicamento.DataSource = objConexion.obtenerDatos().Tables("RegistroMedicamento").DefaultView
            cobmedicamento.DisplayMember = "NombreMedicamento"
            cobmedicamento.ValueMember = "RegistroMedicamento.IdRegistroMedicamento"
            cobmedicamento.AutoCompleteMode = AutoCompleteMode.Suggest
            cobmedicamento.AutoCompleteSource = AutoCompleteSource.ListItems

            coblab.DataSource = objConexion.obtenerDatos().Tables("RegistroMedicamento").DefaultView
            coblab.DisplayMember = "Laboratorio"


            cobpre.DataSource = objConexion.obtenerDatos().Tables("RegistroMedicamento").DefaultView
            cobpre.DisplayMember = "Presentacion"



            cobcliente.SelectedValue = Module1.tclientes
        Catch ex As Exception
            'Mensaje si no hay datos que mostra
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


            'si el boton dice aceptar, significa que esta aceptando el nuevo registro y lo envia a la base
        ElseIf btnnuevoyaceptar.Text = "Aceptar" Then
            comandosql = comandoinsertar
            If lblcoste.Text = "" Then
                lblcoste.Text = 0
            End If
            If txtcantidad.Text = "" Then
                txtcantidad.Text = 0
            End If
            If txtprecio.Text = "" Then
                txtprecio.Text = 0
            End If


            Dim msg = objConexion.mantenimientodetallesventa(New String() {
            "",                 'dato(0) para el id, incrementa automaticamente no necesita enviar nada 
            cobmedicamento.SelectedValue,     'dato(1)
            txtcantidad.Text,     'dato(1)
            lblcoste.Text, 'dato(2)
           txtid.Text}, 'dato(2)
          accion, comandosql, idTabla) 'accion que se desea realizar en el case
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            obtenerdatos()
            limpiar()
            MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
            btneliminar.Enabled = True





        Else 'si el boton dice Guardar, significa que esta haciendo un cambio de un dato
            comandosql = comandoactualizar

            If lblcoste.Text = "" Then
                lblcoste.Text = 0
            End If
            If txtcantidad.Text = "" Then
                txtcantidad.Text = 0
            End If
            If txtprecio.Text = "" Then
                txtprecio.Text = 0
            End If


            Dim msg = objConexion.mantenimientodetallesventa(New String() {
              txtiddetalle.Text,      'dato(0) si se envia el id aqui porque es el que identifica el registro, update from id = x
              cobmedicamento.SelectedValue,     'dato(1)
            txtcantidad.Text,     'dato(1)
            lblcoste.Text}, 'dato(2)}, 'dato(3)
              accion, comandosql, idTabla)

            obtenerdatos()
            MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
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

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtiddetalle.Text <> "" Then
            If (MessageBox.Show("Esta seguro de borrar a " + cobmedicamento.Text, mensajeenmentana,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                comandosql = Nombretabladebusqueda
                Dim msg = objConexion.mantenimientodetallesventa(New String() {txtiddetalle.Text}, "eliminar", comandosql, idTabla)
                If msg = "Error en el proceso" Then
                    MessageBox.Show("No se pudo eliminar este registro, porque hay registros que dependen de el", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else MessageBox.Show("Debe selecionar un registro para eliminar", mensajeenmentana)
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
        bs.Filter = buscarpor1 + " like '%" & txtfactura.Text & "%' and " + buscarpor2 + " like '%" & valor & "%'"
        grid.DataSource = bs
    End Sub


    'pasar datos del grid al dar click hacia los txt
    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If btnnuevoyaceptar.Text <> "Aceptar" Then

            If grid.Rows.Count > 0 Then
                Dim i As Integer
                i = grid.CurrentRow.Index
                txtiddetalle.Text = grid.Item(0, i).Value()
                txtcantidad.Text = grid.Item(4, i).Value()
                'lblcoste.Text = grid.Item(5, i).Value()
                '  txtotrosvalores.Text = grid.Item(6, i).Value()
                cobmedicamento.SelectedValue = grid.Item(8, i).Value()
                '   coblab.SelectedValue = grid.Item(10, i).Value()
                '   cobpre.SelectedValue = grid.Item(10, i).Value()
                'coblaboratorio.SelectedValue = grid.Item(5, i).Value()
            End If



        End If
    End Sub


    Private Sub limpiar()
        txtcantidad.Text = ""
        txtprecio.Text = ""
        lblcoste.Text = ""
    End Sub

    Private Sub ganancia()
        Dim ganancia As Double = lblcoste.Text
        Dim gan As Double = ganancia + (ganancia * (cobganancia.Text / 100))

        lblcoste.Text = gan
    End Sub

    Private Sub descuento()
        Dim descuento As Double = lblcoste.Text
        Dim des As Double = descuento - (descuento * (cobdescuento.Text / 100))

        lblcoste.Text = des
    End Sub


    Private Sub txtprecio_KeyUp(sender As Object, e As KeyEventArgs) Handles txtprecio.KeyUp
        txtcantidad.Text = txtcantidad.Text.Trim
        txtprecio.Text = txtprecio.Text.Trim


        If txtcantidad.Text <> "" And txtprecio.Text <> "" Then
            If txtcantidad.Text > 0 And txtprecio.Text >= 0 Then
                Dim cantidad As Double = txtcantidad.Text
                Dim precio As Double = txtprecio.Text
                Dim resultado As Double = (precio * cantidad)
                lblcoste.Text = resultado

                ganancia()
            End If
        End If
    End Sub



    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) _
             AndAlso (Not e.KeyChar = "." Or txtprecio.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        txtcantidad.Text = txtcantidad.Text.Trim
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged
        txtprecio.Text = txtprecio.Text.Trim
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = txtid.Text.Trim
        Close()
    End Sub

    Private Sub txtcantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcantidad.KeyUp
        txtcantidad.Text = txtcantidad.Text.Trim
        txtprecio.Text = txtprecio.Text.Trim

        If txtcantidad.Text <> "" And txtprecio.Text <> "" Then
            If txtcantidad.Text > 0 And txtprecio.Text >= 0 Then
                Dim cantidad As Double = txtcantidad.Text
                Dim precio As Double = txtprecio.Text
                lblcoste.Text = precio * cantidad

                ganancia()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        descuento()
    End Sub
End Class