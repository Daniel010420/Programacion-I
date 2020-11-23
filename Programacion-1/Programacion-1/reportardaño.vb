Public Class reportardaño
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim comandosql = ""
    Public a


    Dim mensajeenmentana = "Registro Reporte Daño"
    Dim Nombretabladebusqueda = "MedicamentoDanado"
    Dim buscarpor1 = "FechaDeReporte"
    Dim buscarpor2 = "NombreMedicamento"

    Dim idTabla = "IdMedicamentoDanado"
    Dim comandoinsertar = Nombretabladebusqueda + " (IdRegistroMedicamento,IdMotivoDanado,Cantidad,FechaDeReporte)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda
    Private Sub calendario_ValueChanged(sender As Object, e As EventArgs) Handles calendario.ValueChanged
        '    txtfecha.Text = calendario.Text
    End Sub

    Private Sub reportardaño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coblab.Enabled = False
        cobpre.Enabled = False
        txtid.Visible = False

        cobmedicamento.DataSource = objConexion.obtenerDatos().Tables("RegistroMedicamento").DefaultView
        cobmedicamento.DisplayMember = "NombreMedicamento"
        cobmedicamento.ValueMember = "RegistroMedicamento.IdRegistroMedicamento"
        cobmedicamento.AutoCompleteMode = AutoCompleteMode.Suggest
        cobmedicamento.AutoCompleteSource = AutoCompleteSource.ListItems

        coblab.DataSource = objConexion.obtenerDatos().Tables("RegistroMedicamento").DefaultView
        coblab.DisplayMember = "Laboratorio"


        cobpre.DataSource = objConexion.obtenerDatos().Tables("RegistroMedicamento").DefaultView
        cobpre.DisplayMember = "Presentacion"


        cobmotivos.DataSource = objConexion.obtenerDatos().Tables("MotivosDaño").DefaultView
        cobmotivos.DisplayMember = "MotivoDano"
        cobmotivos.ValueMember = "MotivosDano.IdmotivoDano"
        cobmotivos.AutoCompleteMode = AutoCompleteMode.Suggest
        cobmotivos.AutoCompleteSource = AutoCompleteSource.ListItems
        obtenerdatos()
    End Sub
    Sub obtenerdatos()
        Try
            'la palabra Empleados es la palabra que envia la peticion de la tabla que quiere
            'la palabra datos tabla es la que recibe los resultados de la tabla
            'llenar los datos del grid
            grid.DataSource = objConexion.obtenerDatos().Tables("Medicamentodanado").DefaultView

            grid.Columns(0).Visible = False
            grid.Columns(5).Visible = False
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            'grid.Columns(11).Visible = False


            'txtid.Text = Module1.idcompra
            'txtfactura.Text = Module1.factura
            'txtfactura.Text = txtfactura.Text.Trim
            'txtfactura.Enabled = False

            '            filtro(txtfiltro.Text)




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
            Dim msg = objConexion.mantenimientomedicamentodanado(New String() {
"",
cobmedicamento.SelectedValue,
cobmotivos.SelectedValue,
txtcantidad.Text,
calendario.Text},
accion, comandosql, idTabla) 'accion que se desea realizar en el case
            btnnuevoyaceptar.Text = "Nuevo"
                btnmodificarycancelar.Text = "Modificar"
                obtenerdatos()
                limpiar()
                MessageBox.Show(msg, mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btneliminar.Enabled = True


        Else 'si el boton dice Guardar, significa que esta haciendo un cambio de un dato
            comandosql = comandoactualizar
            Dim msg = objConexion.mantenimientomedicamentodanado(New String() {
                txtid.Text,
cobmedicamento.SelectedValue,
cobmotivos.SelectedValue,
txtcantidad.Text,
calendario.Text},
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
        If txtid.Text <> "" Then
            If (MessageBox.Show("Esta seguro de borrar a " + cobmedicamento.Text, mensajeenmentana,
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                comandosql = Nombretabladebusqueda
                Dim msg = objConexion.mantenimientomedicamentodanado(New String() {txtid.Text}, "eliminar", comandosql, idTabla)
                If msg = "Error en el proceso" Then
                    MessageBox.Show("No se pudo eliminar este registro, porque hay registros que dependen de el", mensajeenmentana, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else MessageBox.Show("Debe selecionar un registro para eliminar", mensajeenmentana)
        End If
        limpiar()
        obtenerdatos()
    End Sub


    'filtro del datagridview
    Private Sub txtfiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtfiltro.KeyUp
        filtro(txtfiltro.Text)
    End Sub
    Private Sub filtro(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grid.DataSource
        bs.Filter = buscarpor1 + " like '%" & valor & "%' or " + buscarpor2 + " like '%" & valor & "%'"
        grid.DataSource = bs
    End Sub


    'filtro del datagridview



    'pasar datos del grid al dar click hacia los txt
    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If btnnuevoyaceptar.Text <> "Aceptar" Then

            If grid.Rows.Count > 0 Then
                Dim i As Integer
                i = grid.CurrentRow.Index
                txtid.Text = grid.Item(0, i).Value()
                txtcantidad.Text = grid.Item(6, i).Value()
                '  txtprecio.Text = grid.Item(5, i).Value()
                '  txtotrosvalores.Text = grid.Item(6, i).Value()
                cobmedicamento.SelectedValue = grid.Item(8, i).Value()
                cobmotivos.SelectedValue = grid.Item(5, i).Value()
                '   cobpre.SelectedValue = grid.Item(10, i).Value()
                'coblaboratorio.SelectedValue = grid.Item(5, i).Value()
            End If



        End If
    End Sub

    'limpia los campos
    Private Sub limpiar()
        txtcantidad.Text = ""


    End Sub



    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        'solo permite enteros
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub





    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        txtcantidad.Text = txtcantidad.Text.Trim
    End Sub


End Class