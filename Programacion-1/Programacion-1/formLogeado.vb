Public Class formLogeado
    Public logeado


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Dim newform As New formAdministrarProveedor
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim newform As New formAdministrarEmpleados
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub LaboratoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaboratoriosToolStripMenuItem.Click
        Dim newform As New formAdministrarLaboratorio
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub MotivosDeDañoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotivosDeDañoToolStripMenuItem.Click
        Dim newform As New formMotivosDaño
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub PresentacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionesToolStripMenuItem.Click
        Dim newform As New formPresentacion
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub AdministarCargosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim newform As New formCargo
        newform.MdiParent = Me
        newform.Show()
    End Sub


    Private Sub TiposDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeClientesToolStripMenuItem.Click
        Dim newform As New formtipocliente
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub AdministrarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarClientesToolStripMenuItem.Click
        Dim newform As New formClientes
        newform.MdiParent = Me
        newform.Show()
    End Sub


    Private Sub PorcientoGananciaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub PorcientoDescuentoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        Dim newform As New formUsuarios
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub RegistroGeneralMedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroGeneralMedicamentoToolStripMenuItem.Click
        Dim newform As New formRegistroMedicamento
        newform.MdiParent = Me
        newform.Show()

        'If Label1.Text = 1 Then
        'InventarioToolStripMenuItem.Enabled = True
        'UsuariosToolStripMenuItem.Enabled = True
        'ProveedoresToolStripMenuItem.Enabled = True
        'ClientesToolStripMenuItem.Enabled = True
        'End If
    End Sub

    Private Sub formLogeado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InventarioToolStripMenuItem.Enabled = False
        UsuariosToolStripMenuItem.Enabled = False
        ProveedoresToolStripMenuItem.Enabled = False
        ClientesToolStripMenuItem.Enabled = False
        btntrabajo.Visible = False



        Dim newform As New home
        newform.MdiParent = Me
        newform.Show()



    End Sub

    Private Sub PedidosPorRecibirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosPorRecibirToolStripMenuItem.Click
        Dim newform As New Nuevacompra
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub RealizarSolicitudDeMedicinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarSolicitudDeMedicinaToolStripMenuItem.Click
        Dim newform As New NuevaSolicitud
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        Dim newform As New NuevaVenta
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub CargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem.Click
        Dim newform As New formCargo
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub PreciosDeGananciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosDeGananciaToolStripMenuItem.Click
        Dim newform As New formPorcientoGanancia
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub PreciosDeDescuentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosDeDescuentoToolStripMenuItem.Click
        Dim newform As New formdescuentos
        newform.MdiParent = Me
        newform.Show()
    End Sub



    Private Sub IniciarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSesionToolStripMenuItem.Click




        If IniciarSesionToolStripMenuItem.Text = "Iniciar Sesion" Then
            Dim newform As New home
            newform.MdiParent = Me
            newform.Show()
        ElseIf IniciarSesionToolStripMenuItem.Text = "Cerrar Sesion" Then
            InventarioToolStripMenuItem.Enabled = False
            UsuariosToolStripMenuItem.Enabled = False
            ProveedoresToolStripMenuItem.Enabled = False
            ClientesToolStripMenuItem.Enabled = False
            IniciarSesionToolStripMenuItem.Text = "Iniciar Sesion"
            btntrabajo.Visible = False

        End If



        '    If Label1.Text = 1 Then

        'End If

        ' If 1 = 1 Then


        '        End If

    End Sub

    Private Sub btntrabajo_Click(sender As Object, e As EventArgs) Handles btntrabajo.Click
        InventarioToolStripMenuItem.Enabled = True
        UsuariosToolStripMenuItem.Enabled = True
        ProveedoresToolStripMenuItem.Enabled = True
        ClientesToolStripMenuItem.Enabled = True
        btntrabajo.Visible = False
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        Dim newform As New Sucursales
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub FormasDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormasDePagoToolStripMenuItem.Click
        Dim newform As New FormasPago
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub TipoFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoFacturaToolStripMenuItem.Click
        Dim newform As New TipoFactura
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub ReportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportarToolStripMenuItem.Click
        Dim newform As New reportardaño
        newform.MdiParent = Me
        newform.Show()
    End Sub

    Private Sub ListadoProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoProveedoresToolStripMenuItem.Click
        Dim newform As New Proveedores
        newform.MdiParent = Me
        newform.Show()
    End Sub
End Class