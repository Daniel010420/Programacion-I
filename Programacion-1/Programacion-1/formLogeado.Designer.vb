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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromocionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescuentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GananciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportarDañoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotivosDeDañoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoRepoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministarCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MenuToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PromocionesToolStripMenuItem, Me.StockToolStripMenuItem, Me.ReportarDañoToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.InventarioToolStripMenuItem.Text = "Medicamento"
        '
        'PromocionesToolStripMenuItem
        '
        Me.PromocionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescuentoToolStripMenuItem, Me.GananciaToolStripMenuItem})
        Me.PromocionesToolStripMenuItem.Name = "PromocionesToolStripMenuItem"
        Me.PromocionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PromocionesToolStripMenuItem.Text = "Porcentajes"
        '
        'DescuentoToolStripMenuItem
        '
        Me.DescuentoToolStripMenuItem.Name = "DescuentoToolStripMenuItem"
        Me.DescuentoToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DescuentoToolStripMenuItem.Text = "Descuento"
        '
        'GananciaToolStripMenuItem
        '
        Me.GananciaToolStripMenuItem.Name = "GananciaToolStripMenuItem"
        Me.GananciaToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.GananciaToolStripMenuItem.Text = "Ganancia"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ReportarDañoToolStripMenuItem
        '
        Me.ReportarDañoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MotivosDeDañoToolStripMenuItem, Me.NuevoRepoteToolStripMenuItem})
        Me.ReportarDañoToolStripMenuItem.Name = "ReportarDañoToolStripMenuItem"
        Me.ReportarDañoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportarDañoToolStripMenuItem.Text = "Reportar Daño"
        '
        'MotivosDeDañoToolStripMenuItem
        '
        Me.MotivosDeDañoToolStripMenuItem.Name = "MotivosDeDañoToolStripMenuItem"
        Me.MotivosDeDañoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MotivosDeDañoToolStripMenuItem.Text = "Motivos de Daño"
        '
        'NuevoRepoteToolStripMenuItem
        '
        Me.NuevoRepoteToolStripMenuItem.Name = "NuevoRepoteToolStripMenuItem"
        Me.NuevoRepoteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoRepoteToolStripMenuItem.Text = "Nuevo Repote"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministarToolStripMenuItem, Me.AdministarCargosToolStripMenuItem, Me.PermisosEmpleadosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.UsuariosToolStripMenuItem.Text = "Empleados"
        '
        'AdministarToolStripMenuItem
        '
        Me.AdministarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.AdministarToolStripMenuItem.Name = "AdministarToolStripMenuItem"
        Me.AdministarToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AdministarToolStripMenuItem.Text = "Administar Empleados"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PermisosToolStripMenuItem.Text = "Usuarios"
        '
        'AdministarCargosToolStripMenuItem
        '
        Me.AdministarCargosToolStripMenuItem.Name = "AdministarCargosToolStripMenuItem"
        Me.AdministarCargosToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AdministarCargosToolStripMenuItem.Text = "Administar Cargos"
        '
        'PermisosEmpleadosToolStripMenuItem
        '
        Me.PermisosEmpleadosToolStripMenuItem.Name = "PermisosEmpleadosToolStripMenuItem"
        Me.PermisosEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PermisosEmpleadosToolStripMenuItem.Text = "Permisos de Empleados"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem1, Me.LaboratoriosToolStripMenuItem, Me.NuevaCompraToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'LaboratoriosToolStripMenuItem
        '
        Me.LaboratoriosToolStripMenuItem.Name = "LaboratoriosToolStripMenuItem"
        Me.LaboratoriosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.LaboratoriosToolStripMenuItem.Text = "Laboratorios"
        '
        'NuevaCompraToolStripMenuItem
        '
        Me.NuevaCompraToolStripMenuItem.Name = "NuevaCompraToolStripMenuItem"
        Me.NuevaCompraToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NuevaCompraToolStripMenuItem.Text = "Nueva Compra"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.TiposDeClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'TiposDeClientesToolStripMenuItem
        '
        Me.TiposDeClientesToolStripMenuItem.Name = "TiposDeClientesToolStripMenuItem"
        Me.TiposDeClientesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TiposDeClientesToolStripMenuItem.Text = "Tipos de Clientes"
        '
        'formLogeado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
    Friend WithEvents PromocionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescuentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GananciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportarDañoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MotivosDeDañoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoRepoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministarCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaboratoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TiposDeClientesToolStripMenuItem As ToolStripMenuItem
End Class
