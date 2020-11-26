<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaSolicitud
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
        Dim Label2 As System.Windows.Forms.Label
        Dim NfacturaLabel As System.Windows.Forms.Label
        Dim Fecha_vtaLabel As System.Windows.Forms.Label
        Dim IdTipofacturaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cobempleadolist = New System.Windows.Forms.ComboBox()
        Me.cobsucursallist = New System.Windows.Forms.ComboBox()
        Me.cobcodigolist = New System.Windows.Forms.ComboBox()
        Me.cobproveedorlist = New System.Windows.Forms.ComboBox()
        Me.txtfacturad = New System.Windows.Forms.TextBox()
        Me.calendariod = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnnuevoyaceptar = New System.Windows.Forms.Button()
        Me.btnmodificarycancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.cobempleadod = New System.Windows.Forms.ComboBox()
        Me.cobsucursald = New System.Windows.Forms.ComboBox()
        Me.cobproveedord = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRespuestaTotal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblRespuestaIva = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.lblRespuestaSuma = New System.Windows.Forms.Label()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cobid = New System.Windows.Forms.ComboBox()
        Me.cobfecha = New System.Windows.Forms.ComboBox()
        Label2 = New System.Windows.Forms.Label()
        NfacturaLabel = New System.Windows.Forms.Label()
        Fecha_vtaLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(306, 10)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 13)
        Label2.TabIndex = 55
        Label2.Text = "Sucursal"
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(557, 11)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(73, 13)
        NfacturaLabel.TabIndex = 47
        NfacturaLabel.Text = "Solicitud: No.:"
        '
        'Fecha_vtaLabel
        '
        Fecha_vtaLabel.AutoSize = True
        Fecha_vtaLabel.Location = New System.Drawing.Point(17, 43)
        Fecha_vtaLabel.Name = "Fecha_vtaLabel"
        Fecha_vtaLabel.Size = New System.Drawing.Size(40, 13)
        Fecha_vtaLabel.TabIndex = 48
        Fecha_vtaLabel.Text = "Fecha:"
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(306, 43)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(54, 13)
        IdTipofacturaLabel.TabIndex = 50
        IdTipofacturaLabel.Text = "Empleado"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(17, 10)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 13)
        Label1.TabIndex = 52
        Label1.Text = "Proveedor"
        '
        'cobempleadolist
        '
        Me.cobempleadolist.FormattingEnabled = True
        Me.cobempleadolist.Location = New System.Drawing.Point(374, 39)
        Me.cobempleadolist.Name = "cobempleadolist"
        Me.cobempleadolist.Size = New System.Drawing.Size(147, 21)
        Me.cobempleadolist.TabIndex = 70
        '
        'cobsucursallist
        '
        Me.cobsucursallist.FormattingEnabled = True
        Me.cobsucursallist.Location = New System.Drawing.Point(374, 7)
        Me.cobsucursallist.Name = "cobsucursallist"
        Me.cobsucursallist.Size = New System.Drawing.Size(147, 21)
        Me.cobsucursallist.TabIndex = 69
        '
        'cobcodigolist
        '
        Me.cobcodigolist.FormattingEnabled = True
        Me.cobcodigolist.Location = New System.Drawing.Point(626, 5)
        Me.cobcodigolist.Name = "cobcodigolist"
        Me.cobcodigolist.Size = New System.Drawing.Size(147, 21)
        Me.cobcodigolist.TabIndex = 68
        '
        'cobproveedorlist
        '
        Me.cobproveedorlist.FormattingEnabled = True
        Me.cobproveedorlist.Location = New System.Drawing.Point(76, 8)
        Me.cobproveedorlist.Name = "cobproveedorlist"
        Me.cobproveedorlist.Size = New System.Drawing.Size(147, 21)
        Me.cobproveedorlist.TabIndex = 66
        '
        'txtfacturad
        '
        Me.txtfacturad.Location = New System.Drawing.Point(626, 6)
        Me.txtfacturad.Name = "txtfacturad"
        Me.txtfacturad.Size = New System.Drawing.Size(147, 20)
        Me.txtfacturad.TabIndex = 65
        '
        'calendariod
        '
        Me.calendariod.Location = New System.Drawing.Point(76, 43)
        Me.calendariod.Name = "calendariod"
        Me.calendariod.Size = New System.Drawing.Size(222, 20)
        Me.calendariod.TabIndex = 49
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(783, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(864, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 50)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Editar detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnnuevoyaceptar)
        Me.GroupBox2.Controls.Add(Me.btnmodificarycancelar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 473)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 84)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro Solicitud"
        '
        'btnnuevoyaceptar
        '
        Me.btnnuevoyaceptar.Location = New System.Drawing.Point(6, 28)
        Me.btnnuevoyaceptar.Name = "btnnuevoyaceptar"
        Me.btnnuevoyaceptar.Size = New System.Drawing.Size(84, 45)
        Me.btnnuevoyaceptar.TabIndex = 19
        Me.btnnuevoyaceptar.Text = "Nuevo"
        Me.btnnuevoyaceptar.UseVisualStyleBackColor = True
        '
        'btnmodificarycancelar
        '
        Me.btnmodificarycancelar.Location = New System.Drawing.Point(95, 28)
        Me.btnmodificarycancelar.Name = "btnmodificarycancelar"
        Me.btnmodificarycancelar.Size = New System.Drawing.Size(87, 45)
        Me.btnmodificarycancelar.TabIndex = 18
        Me.btnmodificarycancelar.Text = "Modificar"
        Me.btnmodificarycancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(187, 29)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(84, 44)
        Me.btneliminar.TabIndex = 17
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'cobempleadod
        '
        Me.cobempleadod.FormattingEnabled = True
        Me.cobempleadod.Location = New System.Drawing.Point(374, 39)
        Me.cobempleadod.Name = "cobempleadod"
        Me.cobempleadod.Size = New System.Drawing.Size(147, 21)
        Me.cobempleadod.TabIndex = 58
        '
        'cobsucursald
        '
        Me.cobsucursald.FormattingEnabled = True
        Me.cobsucursald.Location = New System.Drawing.Point(374, 6)
        Me.cobsucursald.Name = "cobsucursald"
        Me.cobsucursald.Size = New System.Drawing.Size(147, 21)
        Me.cobsucursald.TabIndex = 57
        '
        'cobproveedord
        '
        Me.cobproveedord.FormattingEnabled = True
        Me.cobproveedord.Location = New System.Drawing.Point(76, 8)
        Me.cobproveedord.Name = "cobproveedord"
        Me.cobproveedord.Size = New System.Drawing.Size(147, 21)
        Me.cobproveedord.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblRespuestaTotal)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.lblRespuestaIva)
        Me.Panel1.Controls.Add(Me.lbliva)
        Me.Panel1.Controls.Add(Me.lblRespuestaSuma)
        Me.Panel1.Controls.Add(Me.lblsuma)
        Me.Panel1.Location = New System.Drawing.Point(721, 473)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 104)
        Me.Panel1.TabIndex = 54
        '
        'lblRespuestaTotal
        '
        Me.lblRespuestaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaTotal.Location = New System.Drawing.Point(97, 76)
        Me.lblRespuestaTotal.Name = "lblRespuestaTotal"
        Me.lblRespuestaTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaTotal.Size = New System.Drawing.Size(100, 16)
        Me.lblRespuestaTotal.TabIndex = 5
        Me.lblRespuestaTotal.Text = "00.00"
        Me.lblRespuestaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(16, 76)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(61, 16)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "TOTAL:"
        '
        'lblRespuestaIva
        '
        Me.lblRespuestaIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaIva.Location = New System.Drawing.Point(97, 44)
        Me.lblRespuestaIva.Name = "lblRespuestaIva"
        Me.lblRespuestaIva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaIva.Size = New System.Drawing.Size(100, 16)
        Me.lblRespuestaIva.TabIndex = 3
        Me.lblRespuestaIva.Text = "00.00"
        Me.lblRespuestaIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbliva
        '
        Me.lbliva.AutoSize = True
        Me.lbliva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliva.Location = New System.Drawing.Point(16, 44)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(36, 16)
        Me.lbliva.TabIndex = 2
        Me.lbliva.Text = "IVA:"
        '
        'lblRespuestaSuma
        '
        Me.lblRespuestaSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaSuma.Location = New System.Drawing.Point(97, 9)
        Me.lblRespuestaSuma.Name = "lblRespuestaSuma"
        Me.lblRespuestaSuma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaSuma.Size = New System.Drawing.Size(100, 16)
        Me.lblRespuestaSuma.TabIndex = 1
        Me.lblRespuestaSuma.Text = "00.00"
        Me.lblRespuestaSuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsuma
        '
        Me.lblsuma.AutoSize = True
        Me.lblsuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuma.Location = New System.Drawing.Point(16, 9)
        Me.lblsuma.Name = "lblsuma"
        Me.lblsuma.Size = New System.Drawing.Size(55, 16)
        Me.lblsuma.TabIndex = 0
        Me.lblsuma.Text = "SUMA:"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subtotal, Me.cu})
        Me.grid.Location = New System.Drawing.Point(9, 91)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(912, 371)
        Me.grid.TabIndex = 53
        '
        'subtotal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 150
        '
        'cu
        '
        Me.cu.HeaderText = "Coste/Empaque"
        Me.cu.Name = "cu"
        Me.cu.ReadOnly = True
        '
        'cobid
        '
        Me.cobid.FormattingEnabled = True
        Me.cobid.Location = New System.Drawing.Point(534, 549)
        Me.cobid.Name = "cobid"
        Me.cobid.Size = New System.Drawing.Size(147, 21)
        Me.cobid.TabIndex = 59
        '
        'cobfecha
        '
        Me.cobfecha.FormattingEnabled = True
        Me.cobfecha.Location = New System.Drawing.Point(76, 43)
        Me.cobfecha.Name = "cobfecha"
        Me.cobfecha.Size = New System.Drawing.Size(222, 21)
        Me.cobfecha.TabIndex = 64
        '
        'NuevaSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 582)
        Me.Controls.Add(Me.cobempleadolist)
        Me.Controls.Add(Me.cobsucursallist)
        Me.Controls.Add(Me.cobcodigolist)
        Me.Controls.Add(Me.cobproveedorlist)
        Me.Controls.Add(Me.txtfacturad)
        Me.Controls.Add(Me.calendariod)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cobempleadod)
        Me.Controls.Add(Me.cobsucursald)
        Me.Controls.Add(Me.cobproveedord)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(NfacturaLabel)
        Me.Controls.Add(Fecha_vtaLabel)
        Me.Controls.Add(IdTipofacturaLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cobid)
        Me.Controls.Add(Me.cobfecha)
        Me.Name = "NuevaSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Nueva Solicitud"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cobempleadolist As ComboBox
    Friend WithEvents cobsucursallist As ComboBox
    Friend WithEvents cobcodigolist As ComboBox
    Friend WithEvents cobproveedorlist As ComboBox
    Friend WithEvents txtfacturad As TextBox
    Friend WithEvents calendariod As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnnuevoyaceptar As Button
    Friend WithEvents btnmodificarycancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents cobempleadod As ComboBox
    Friend WithEvents cobsucursald As ComboBox
    Friend WithEvents cobproveedord As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRespuestaTotal As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblRespuestaIva As Label
    Friend WithEvents lbliva As Label
    Friend WithEvents lblRespuestaSuma As Label
    Friend WithEvents lblsuma As Label
    Friend WithEvents grid As DataGridView
    Friend WithEvents cobid As ComboBox
    Friend WithEvents cobfecha As ComboBox
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents cu As DataGridViewTextBoxColumn
End Class
