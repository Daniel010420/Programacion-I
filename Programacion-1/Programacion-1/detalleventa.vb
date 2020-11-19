Public Class detalleventa
    Dim objConexion As New Conexion
    Dim dataTable As New DataTable
    Dim accion As String = "nuevo"
    Dim comandosql = ""


    Dim mensajeenmentana = "Registro Detalle Venta"
    Dim Nombretabladebusqueda = "detallesventa"
    Dim buscarpor1 = "numfactura"
    Dim buscarpor2 = "NombreMedicamento"

    Dim idTabla = "Iddventas"
    Dim comandoinsertar = Nombretabladebusqueda + " (IdRegistroMedicamento,Cantidad,ingreso,IdVenta)" 'campos de la tabla en orden menos id
    Dim comandoactualizar = Nombretabladebusqueda
    Private Sub detalleventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coblab.Enabled = False
        cobpre.Enabled = False
        txtid.Visible = False
        txtiddetalle.Visible = False
        lblcoste.Text = ""
        obtenerdatos()
    End Sub
    Sub obtenerdatos()
        Try
            'la palabra Empleados es la palabra que envia la peticion de la tabla que quiere
            'la palabra datos tabla es la que recibe los resultados de la tabla
            'llenar los datos del grid
            grid.DataSource = objConexion.obtenerDatos().Tables("Gananciadescuentocliente").DefaultView
            '     grid.Columns(0).Visible = False
            '    grid.Columns(7).Visible = False
            '   grid.Columns(8).Visible = False
            '  grid.Columns(9).Visible = False
            ' grid.Columns(10).Visible = False
            'grid.Columns(11).Visible = False


            txtid.Text = Module1.idcompra
            txtfactura.Text = Module1.factura
            txtfactura.Text = txtfactura.Text.Trim
            txtfactura.Enabled = False

            'filtro(txtfiltro.Text)


            cobcliente.DataSource = objConexion.obtenerDatos().Tables("Gananciadescuentocliente").DefaultView
            cobcliente.DisplayMember = "Nombre"
            cobcliente.ValueMember = "Clientes.IdClientes"
            cobcliente.AutoCompleteMode = AutoCompleteMode.Suggest
            cobcliente.AutoCompleteSource = AutoCompleteSource.ListItems

            cobdescuento.DataSource = objConexion.obtenerDatos().Tables("Gananciadescuentocliente").DefaultView
            cobdescuento.DisplayMember = "MargenDescuento"


            cobganancia.DataSource = objConexion.obtenerDatos().Tables("Gananciadescuentocliente").DefaultView
            cobganancia.DisplayMember = "MargenGanancia"






        Catch ex As Exception
            'Mensaje si no hay datos que mostra
            MsgBox("No hay datos en la Base de Datos " & ex.Message)
        End Try

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

    Private Sub txtotrosvalores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtotrosvalores.KeyPress
        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) _
           AndAlso (Not e.KeyChar = "." Or txtotrosvalores.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        txtcantidad.Text = txtcantidad.Text.Trim
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged
        txtprecio.Text = txtprecio.Text.Trim
    End Sub

    Private Sub txtotrosvalores_TextChanged(sender As Object, e As EventArgs) Handles txtotrosvalores.TextChanged
        txtotrosvalores.Text = txtotrosvalores.Text.Trim
    End Sub
End Class