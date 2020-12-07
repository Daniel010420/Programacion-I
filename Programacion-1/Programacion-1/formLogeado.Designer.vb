<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogeado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosDeGananciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosDeDescuentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportarDañoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotivosDeDañoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistroGeneralMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteMedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PedidosPorRecibirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarSolicitudDeMedicinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormasDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LaboratoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListasoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TiposDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btntrabajo = New System.Windows.Forms.Button()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.IniciarSesionToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MenuToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SalirToolStripMenuItem.Text = "Cerrar programa"
        '
        'IniciarSesionToolStripMenuItem
        '
        Me.IniciarSesionToolStripMenuItem.Name = "IniciarSesionToolStripMenuItem"
        Me.IniciarSesionToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.IniciarSesionToolStripMenuItem.Text = "Iniciar Sesion"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.OtrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreciosToolStripMenuItem1, Me.ReportarDañoToolStripMenuItem, Me.PresentacionesToolStripMenuItem, Me.ToolStripMenuItem4, Me.RegistroGeneralMedicamentoToolStripMenuItem, Me.ReporteMedicamentosToolStripMenuItem, Me.ToolStripMenuItem5, Me.PedidosPorRecibirToolStripMenuItem, Me.RealizarSolicitudDeMedicinaToolStripMenuItem, Me.NuevaVentaToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.InventarioToolStripMenuItem.Text = "Medicamento"
        '
        'PreciosToolStripMenuItem1
        '
        Me.PreciosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreciosDeGananciaToolStripMenuItem, Me.PreciosDeDescuentoToolStripMenuItem})
        Me.PreciosToolStripMenuItem1.Name = "PreciosToolStripMenuItem1"
        Me.PreciosToolStripMenuItem1.Size = New System.Drawing.Size(237, 22)
        Me.PreciosToolStripMenuItem1.Text = "Precios"
        '
        'PreciosDeGananciaToolStripMenuItem
        '
        Me.PreciosDeGananciaToolStripMenuItem.Name = "PreciosDeGananciaToolStripMenuItem"
        Me.PreciosDeGananciaToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PreciosDeGananciaToolStripMenuItem.Text = "Precios de ganancia"
        '
        'PreciosDeDescuentoToolStripMenuItem
        '
        Me.PreciosDeDescuentoToolStripMenuItem.Name = "PreciosDeDescuentoToolStripMenuItem"
        Me.PreciosDeDescuentoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PreciosDeDescuentoToolStripMenuItem.Text = "Precios de descuento"
        '
        'ReportarDañoToolStripMenuItem
        '
        Me.ReportarDañoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MotivosDeDañoToolStripMenuItem, Me.ReportarToolStripMenuItem, Me.ListaDeReportesToolStripMenuItem})
        Me.ReportarDañoToolStripMenuItem.Name = "ReportarDañoToolStripMenuItem"
        Me.ReportarDañoToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ReportarDañoToolStripMenuItem.Text = "Reportar Daño"
        '
        'MotivosDeDañoToolStripMenuItem
        '
        Me.MotivosDeDañoToolStripMenuItem.Name = "MotivosDeDañoToolStripMenuItem"
        Me.MotivosDeDañoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MotivosDeDañoToolStripMenuItem.Text = "Motivos de Daño"
        '
        'ReportarToolStripMenuItem
        '
        Me.ReportarToolStripMenuItem.Name = "ReportarToolStripMenuItem"
        Me.ReportarToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ReportarToolStripMenuItem.Text = "Reportar"
        '
        'ListaDeReportesToolStripMenuItem
        '
        Me.ListaDeReportesToolStripMenuItem.Name = "ListaDeReportesToolStripMenuItem"
        Me.ListaDeReportesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ListaDeReportesToolStripMenuItem.Text = "Lista de reportes"
        '
        'PresentacionesToolStripMenuItem
        '
        Me.PresentacionesToolStripMenuItem.Name = "PresentacionesToolStripMenuItem"
        Me.PresentacionesToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.PresentacionesToolStripMenuItem.Text = "Presentaciones"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(234, 6)
        '
        'RegistroGeneralMedicamentoToolStripMenuItem
        '
        Me.RegistroGeneralMedicamentoToolStripMenuItem.Name = "RegistroGeneralMedicamentoToolStripMenuItem"
        Me.RegistroGeneralMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.RegistroGeneralMedicamentoToolStripMenuItem.Text = "Registro General Medicamento"
        '
        'ReporteMedicamentosToolStripMenuItem
        '
        Me.ReporteMedicamentosToolStripMenuItem.Name = "ReporteMedicamentosToolStripMenuItem"
        Me.ReporteMedicamentosToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ReporteMedicamentosToolStripMenuItem.Text = "Listado de Medicamentos"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(234, 6)
        '
        'PedidosPorRecibirToolStripMenuItem
        '
        Me.PedidosPorRecibirToolStripMenuItem.Name = "PedidosPorRecibirToolStripMenuItem"
        Me.PedidosPorRecibirToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.PedidosPorRecibirToolStripMenuItem.Text = "Compra Recibida"
        '
        'RealizarSolicitudDeMedicinaToolStripMenuItem
        '
        Me.RealizarSolicitudDeMedicinaToolStripMenuItem.Name = "RealizarSolicitudDeMedicinaToolStripMenuItem"
        Me.RealizarSolicitudDeMedicinaToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.RealizarSolicitudDeMedicinaToolStripMenuItem.Text = "Realizar solicitud de medicina"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva Venta"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministarToolStripMenuItem, Me.SucursalesToolStripMenuItem, Me.FormasDePagoToolStripMenuItem, Me.TipoFacturaToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Empresa"
        '
        'AdministarToolStripMenuItem
        '
        Me.AdministarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ListadoEmpleadosToolStripMenuItem, Me.ToolStripMenuItem3, Me.UsuariosToolStripMenuItem1, Me.CargosToolStripMenuItem})
        Me.AdministarToolStripMenuItem.Name = "AdministarToolStripMenuItem"
        Me.AdministarToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AdministarToolStripMenuItem.Text = "Administar Empleados"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ListadoEmpleadosToolStripMenuItem
        '
        Me.ListadoEmpleadosToolStripMenuItem.Name = "ListadoEmpleadosToolStripMenuItem"
        Me.ListadoEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ListadoEmpleadosToolStripMenuItem.Text = "Listado Empleados"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(170, 6)
        '
        'UsuariosToolStripMenuItem1
        '
        Me.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        Me.UsuariosToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.UsuariosToolStripMenuItem1.Text = "Usuarios"
        '
        'CargosToolStripMenuItem
        '
        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CargosToolStripMenuItem.Text = "Cargos"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'FormasDePagoToolStripMenuItem
        '
        Me.FormasDePagoToolStripMenuItem.Name = "FormasDePagoToolStripMenuItem"
        Me.FormasDePagoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.FormasDePagoToolStripMenuItem.Text = "Formas de pago"
        '
        'TipoFacturaToolStripMenuItem
        '
        Me.TipoFacturaToolStripMenuItem.Name = "TipoFacturaToolStripMenuItem"
        Me.TipoFacturaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.TipoFacturaToolStripMenuItem.Text = "Tipo de Facturas"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem1, Me.ListadoProveedoresToolStripMenuItem, Me.ToolStripMenuItem2, Me.LaboratoriosToolStripMenuItem, Me.ListasoToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'ListadoProveedoresToolStripMenuItem
        '
        Me.ListadoProveedoresToolStripMenuItem.Name = "ListadoProveedoresToolStripMenuItem"
        Me.ListadoProveedoresToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ListadoProveedoresToolStripMenuItem.Text = "Listado Proveedores"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(194, 6)
        '
        'LaboratoriosToolStripMenuItem
        '
        Me.LaboratoriosToolStripMenuItem.Name = "LaboratoriosToolStripMenuItem"
        Me.LaboratoriosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.LaboratoriosToolStripMenuItem.Text = "Laboratorios"
        '
        'ListasoToolStripMenuItem
        '
        Me.ListasoToolStripMenuItem.Name = "ListasoToolStripMenuItem"
        Me.ListasoToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ListasoToolStripMenuItem.Text = "Listado de Laboratorios"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarClientesToolStripMenuItem, Me.ListadoDeClientesToolStripMenuItem, Me.ToolStripMenuItem1, Me.TiposDeClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AdministrarClientesToolStripMenuItem
        '
        Me.AdministrarClientesToolStripMenuItem.Name = "AdministrarClientesToolStripMenuItem"
        Me.AdministrarClientesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AdministrarClientesToolStripMenuItem.Text = "Administrar Clientes"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'TiposDeClientesToolStripMenuItem
        '
        Me.TiposDeClientesToolStripMenuItem.Name = "TiposDeClientesToolStripMenuItem"
        Me.TiposDeClientesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.TiposDeClientesToolStripMenuItem.Text = "Tipos De Clientes"
        '
        'btntrabajo
        '
        Me.btntrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntrabajo.Location = New System.Drawing.Point(0, 27)
        Me.btntrabajo.Name = "btntrabajo"
        Me.btntrabajo.Size = New System.Drawing.Size(185, 97)
        Me.btntrabajo.TabIndex = 3
        Me.btntrabajo.Text = "Empezar a trabajar"
        Me.btntrabajo.UseVisualStyleBackColor = True
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasPorClienteToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'VentasPorClienteToolStripMenuItem
        '
        Me.VentasPorClienteToolStripMenuItem.Name = "VentasPorClienteToolStripMenuItem"
        Me.VentasPorClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VentasPorClienteToolStripMenuItem.Text = "Ventas por cliente"
        '
        'formLogeado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btntrabajo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "formLogeado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido a Farmacia Santa Fe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportarDañoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MotivosDeDañoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaboratoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegistroGeneralMedicamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosPorRecibirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealizarSolicitudDeMedicinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormasDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PreciosDeGananciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreciosDeDescuentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IniciarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btntrabajo As Button
    Friend WithEvents ListadoProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ListasoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ListadoEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents ReporteMedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents ListaDeReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasPorClienteToolStripMenuItem As ToolStripMenuItem
End Class
