<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim NfacturaLabel As System.Windows.Forms.Label
        Dim Fecha_vtaLabel As System.Windows.Forms.Label
        Dim IdTipofacturaLabel As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.calendario = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnnuevoyaceptar = New System.Windows.Forms.Button()
        Me.btnmodificarycancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.cobpago = New System.Windows.Forms.ComboBox()
        Me.cobfactura = New System.Windows.Forms.ComboBox()
        Me.cobsucursal = New System.Windows.Forms.ComboBox()
        Me.cobcliente = New System.Windows.Forms.ComboBox()
        Me.cobfacturas = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRespuestaTotal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblRespuestaIva = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.lblRespuestaSuma = New System.Windows.Forms.Label()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cobid = New System.Windows.Forms.ComboBox()
        Me.cobfecha = New System.Windows.Forms.ComboBox()
        Me.cobempleado = New System.Windows.Forms.ComboBox()
        Label2 = New System.Windows.Forms.Label()
        NfacturaLabel = New System.Windows.Forms.Label()
        Fecha_vtaLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calendario
        '
        Me.calendario.Location = New System.Drawing.Point(58, 40)
        Me.calendario.Name = "calendario"
        Me.calendario.Size = New System.Drawing.Size(222, 20)
        Me.calendario.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(832, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(913, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 50)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Editar detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnnuevoyaceptar)
        Me.GroupBox2.Controls.Add(Me.btnmodificarycancelar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 471)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 84)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro Factura"
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
        'cobpago
        '
        Me.cobpago.FormattingEnabled = True
        Me.cobpago.Location = New System.Drawing.Point(575, 38)
        Me.cobpago.Name = "cobpago"
        Me.cobpago.Size = New System.Drawing.Size(147, 21)
        Me.cobpago.TabIndex = 56
        '
        'cobfactura
        '
        Me.cobfactura.FormattingEnabled = True
        Me.cobfactura.Location = New System.Drawing.Point(473, 7)
        Me.cobfactura.Name = "cobfactura"
        Me.cobfactura.Size = New System.Drawing.Size(127, 21)
        Me.cobfactura.TabIndex = 55
        '
        'cobsucursal
        '
        Me.cobsucursal.FormattingEnabled = True
        Me.cobsucursal.Location = New System.Drawing.Point(255, 6)
        Me.cobsucursal.Name = "cobsucursal"
        Me.cobsucursal.Size = New System.Drawing.Size(147, 21)
        Me.cobsucursal.TabIndex = 53
        '
        'cobcliente
        '
        Me.cobcliente.FormattingEnabled = True
        Me.cobcliente.Location = New System.Drawing.Point(58, 5)
        Me.cobcliente.Name = "cobcliente"
        Me.cobcliente.Size = New System.Drawing.Size(147, 21)
        Me.cobcliente.TabIndex = 52
        '
        'cobfacturas
        '
        Me.cobfacturas.FormattingEnabled = True
        Me.cobfacturas.Location = New System.Drawing.Point(678, 5)
        Me.cobfacturas.Name = "cobfacturas"
        Me.cobfacturas.Size = New System.Drawing.Size(147, 21)
        Me.cobfacturas.TabIndex = 51
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(206, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 13)
        Label2.TabIndex = 49
        Label2.Text = "Sucursal"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblRespuestaTotal)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.lblRespuestaIva)
        Me.Panel1.Controls.Add(Me.lbliva)
        Me.Panel1.Controls.Add(Me.lblRespuestaSuma)
        Me.Panel1.Controls.Add(Me.lblsuma)
        Me.Panel1.Location = New System.Drawing.Point(730, 471)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 104)
        Me.Panel1.TabIndex = 48
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
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subtotal})
        Me.grid.Location = New System.Drawing.Point(18, 89)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(912, 371)
        Me.grid.TabIndex = 47
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
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(606, 9)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(69, 13)
        NfacturaLabel.TabIndex = 41
        NfacturaLabel.Text = "Factura: No.:"
        '
        'Fecha_vtaLabel
        '
        Fecha_vtaLabel.AutoSize = True
        Fecha_vtaLabel.Location = New System.Drawing.Point(12, 42)
        Fecha_vtaLabel.Name = "Fecha_vtaLabel"
        Fecha_vtaLabel.Size = New System.Drawing.Size(40, 13)
        Fecha_vtaLabel.TabIndex = 42
        Fecha_vtaLabel.Text = "Fecha:"
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(404, 11)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(67, 13)
        IdTipofacturaLabel.TabIndex = 44
        IdTipofacturaLabel.Text = "Tipo factura:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(503, 42)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(66, 13)
        IdPagoLabel.TabIndex = 45
        IdPagoLabel.Text = "Forma pago:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(39, 13)
        Label1.TabIndex = 46
        Label1.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "IdMedicamento"
        '
        'cobid
        '
        Me.cobid.FormattingEnabled = True
        Me.cobid.Location = New System.Drawing.Point(255, 7)
        Me.cobid.Name = "cobid"
        Me.cobid.Size = New System.Drawing.Size(147, 21)
        Me.cobid.TabIndex = 54
        '
        'cobfecha
        '
        Me.cobfecha.FormattingEnabled = True
        Me.cobfecha.Location = New System.Drawing.Point(58, 39)
        Me.cobfecha.Name = "cobfecha"
        Me.cobfecha.Size = New System.Drawing.Size(222, 21)
        Me.cobfecha.TabIndex = 60
        '
        'cobempleado
        '
        Me.cobempleado.FormattingEnabled = True
        Me.cobempleado.Location = New System.Drawing.Point(343, 39)
        Me.cobempleado.Name = "cobempleado"
        Me.cobempleado.Size = New System.Drawing.Size(147, 21)
        Me.cobempleado.TabIndex = 62
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(286, 43)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(54, 13)
        Label4.TabIndex = 61
        Label4.Text = "Empleado"
        '
        'NuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 590)
        Me.Controls.Add(Me.cobempleado)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.calendario)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cobpago)
        Me.Controls.Add(Me.cobfactura)
        Me.Controls.Add(Me.cobsucursal)
        Me.Controls.Add(Me.cobcliente)
        Me.Controls.Add(Me.cobfacturas)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(NfacturaLabel)
        Me.Controls.Add(Fecha_vtaLabel)
        Me.Controls.Add(IdTipofacturaLabel)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cobfecha)
        Me.Controls.Add(Me.cobid)
        Me.Name = "NuevaVenta"
        Me.Text = "Nueva Venta"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calendario As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnnuevoyaceptar As Button
    Friend WithEvents btnmodificarycancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents cobpago As ComboBox
    Friend WithEvents cobfactura As ComboBox
    Friend WithEvents cobsucursal As ComboBox
    Friend WithEvents cobcliente As ComboBox
    Friend WithEvents cobfacturas As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRespuestaTotal As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblRespuestaIva As Label
    Friend WithEvents lbliva As Label
    Friend WithEvents lblRespuestaSuma As Label
    Friend WithEvents lblsuma As Label
    Friend WithEvents grid As DataGridView
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents cobid As ComboBox
    Friend WithEvents cobfecha As ComboBox
    Friend WithEvents cobempleado As ComboBox
End Class
