Public Class detallecompra 'Realiza la conexion a la base solo para este formulario
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim comandosql = ""
    Public a


    Dim mensajeenmentana = "Registro Detalle Compra"
    Dim Nombretabladebusqueda = "detallecompra"
    Dim buscarpor1 = "nunfactura"
    Dim buscarpor2 = "NombreMedicamento"

    Dim idTabla = "Iddetallecompra"
    Dim comandoinsertar = Nombretabladebusqueda + " (IdRegistroMedicamento,Cantidad,PrecioCompra,CosteAdicional,IdCompra)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda

    Private Sub detallecompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coblab.Enabled = False
        cobpre.Enabled = False
        txtid.Visible = False
        txtiddetalle.Visible = False
        lblcoste.Text = ""

        txtid.Text = Module1.idcompra
        txtfactura.Text = Module1.factura
        txtfactura.Text = txtfactura.Text.Trim
        txtfactura.Enabled = False

        Try
            cobmedicamento.DataSource = objConexion.obtenerDatos().Tables("RegistroMedicamento").DefaultView
            cobmedicamento.DisplayMember = "NombreMedicamento"
            cobmedicamento.ValueMember = "RegistroMedicamento.IdRegistroMedicamento"
            cobmedicamento.AutoCompleteMode = AutoCompleteMode.Suggest
            cobmedicamento.AutoCompleteSource = AutoCompleteSource.ListItems

            coblab.DataSource = objConexion.obtenerDatos().Tables("RegistroMedicamento").DefaultView
            coblab.DisplayMember = "Laboratorio"


            cobpre.DataSource = objConexion.obtenerDatos().Tables("RegistroMedicamento").DefaultView
            cobpre.DisplayMember = "Presentacion"

        Catch ex As Exception
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try


        obtenerdatos()
    End Sub

    Sub obtenerdatos()
        Try
            'la palabra Empleados es la palabra que envia la peticion de la tabla que quiere
            'la palabra datos tabla es la que recibe los resultados de la tabla
            'llenar los datos del grid




            grid.DataSource = objConexion.obtenerDatos().Tables("Compras").DefaultView
            grid.Columns(0).Visible = False
            grid.Columns(7).Visible = False
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            grid.Columns(11).Visible = False

            filtro(txtfiltro.Text)


        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try

    End Sub



    '  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'Boton primero
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
            If txtotrosvalores.Text = "" Then
                txtotrosvalores.Text = 0
            End If


            Dim msg = objConexion.mantenimientodetallecompra(New String() {
            "",                 'dato(0) para el id, incrementa automaticamente no necesita enviar nada 
            cobmedicamento.SelectedValue,     'dato(1)
            txtcantidad.Text,     'dato(1)
            txtprecio.Text,        'dato(2)
           txtotrosvalores.Text, 'dato(2)
           txtid.Text}, 'dato(2)
          accion, comandosql, idTabla) 'accion que se desea realizar en el case
            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"

            MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
            btneliminar.Enabled = True

            limpiar()
            obtenerdatos()




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
            If txtotrosvalores.Text = "" Then
                txtotrosvalores.Text = 0
            End If

            Dim msg = objConexion.mantenimientodetallecompra(New String() {
              txtiddetalle.Text,      'dato(0) si se envia el id aqui porque es el que identifica el registro, update from id = x
              cobmedicamento.SelectedValue,     'dato(1)
            txtcantidad.Text,     'dato(1)
            txtprecio.Text,        'dato(2)
           txtotrosvalores.Text}, 'dato(2)}, 'dato(3)
              accion, comandosql, idTabla)


            MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnnuevoyaceptar.Text = "Nuevo"
            btnmodificarycancelar.Text = "Modificar"
            btneliminar.Enabled = True
            limpiar()
            obtenerdatos()
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

            btneliminar.Enabled = True
            obtenerdatos()
        End If
    End Sub





    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtiddetalle.Text <> "" Then
            If (MessageBox.Show("Esta seguro de borrar a " + cobmedicamento.Text, mensajeenmentana,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                comandosql = Nombretabladebusqueda
                Dim msg = objConexion.mantenimientodetallecompra(New String() {txtiddetalle.Text}, "eliminar", comandosql, idTabla)
                If msg = "Error en el proceso" Then
                    MessageBox.Show("No se pudo eliminar este registro, porque hay registros que dependen de el", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                If msg <> "Error en el proceso" Then
                    limpiar()
                    obtenerdatos()
                End If
            End If
        Else MessageBox.Show("Debe selecionar un registro para eliminar", mensajeenmentana)
        End If

    End Sub


    'filtro del datagridview
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
                txtprecio.Text = grid.Item(5, i).Value()
                txtotrosvalores.Text = grid.Item(6, i).Value()
                cobmedicamento.SelectedValue = grid.Item(9, i).Value()
                '   coblab.SelectedValue = grid.Item(10, i).Value()
                '   cobpre.SelectedValue = grid.Item(10, i).Value()
                'coblaboratorio.SelectedValue = grid.Item(5, i).Value()
            End If



        End If
    End Sub

    'limpia los campos
    Private Sub limpiar()
        txtcantidad.Text = ""
        txtprecio.Text = ""
        txtotrosvalores.Text = ""
        lblcoste.Text = ""
    End Sub

    Private Sub calculo()
        txtcantidad.Text = txtcantidad.Text.Trim
        txtprecio.Text = txtprecio.Text.Trim
        txtotrosvalores.Text = txtotrosvalores.Text.Trim

        If txtcantidad.Text <> "" And txtprecio.Text <> "" Then
            If txtcantidad.Text > 0 And txtprecio.Text >= 0 Then
                Dim cantidad As Double = txtcantidad.Text
                Dim precio As Double = txtprecio.Text

                Dim res = cantidad * precio
                lblcoste.Text = res

                If txtotrosvalores.Text <> "" Then
                    If txtotrosvalores.Text >= 0 Then
                        lblcoste.Text = res + txtotrosvalores.Text
                    End If
                End If
            End If
        End If
    End Sub



    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        'solo permite enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        'permite decimales solo un punto
        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) _
            AndAlso (Not e.KeyChar = "." Or txtprecio.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtotrosvalores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtotrosvalores.KeyPress
        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) _
            AndAlso (Not e.KeyChar = "." Or txtotrosvalores.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim newform As New Nuevacompra
        '     newform.MdiParent = formLogeado
        '   newform.Show()
        a = txtid.Text.Trim
        Close()



    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

        calculo()
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

        calculo()
    End Sub

    Private Sub txtotrosvalores_TextChanged(sender As Object, e As EventArgs) Handles txtotrosvalores.TextChanged
        calculo()
    End Sub
End Class
