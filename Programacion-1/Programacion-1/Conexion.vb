Imports System.Data
Imports System.Data.SqlClient


Public Class Conexion
    Dim miConexion As New SqlConnection 'Conectarse a BD
    Dim miCommand As New SqlCommand 'Ejecutar consultas
    Dim miAdapter As New SqlDataAdapter 'Es un intermediario 
    Dim ds As New DataSet 'Representa una copia de la arquitectura

    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BDFarmacia-SantaFe.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion
        miConexion.Open()
    End Sub


    'Obtener datos de una tabla, en este ejemplo de la tabla empleados
    Public Function obtenerDatos()
        ds.Clear()
        miCommand.Connection = miConexion

        miCommand.CommandText = "select * from Empleados"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "Empleados")

        miCommand.CommandText = "select * from Laboratorio"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "Laboratorio")

        miCommand.CommandText = "select * from Proveedores"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "Proveedores")

        miCommand.CommandText = "select * from Sucursal"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "Sucursal")


        miCommand.CommandText = "select * from Formapago"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "formapago")


        miCommand.CommandText = "select * from Tipofactura"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "Factura")


        miCommand.CommandText = "select * from Cargos"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "Cargos")

        miCommand.CommandText = "select * from MotivosDano"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "MotivosDaño")


        miCommand.CommandText = "select * from TipoCliente"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "TipoCliente")

        miCommand.CommandText = "select * from Presentacion"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "Presentacion")


        miCommand.CommandText = "select RegistroMedicamento.IdRegistroMedicamento, RegistroMedicamento.NombreMedicamento, Presentacion.Presentacion, Laboratorio.Laboratorio, Presentacion.IdPresentacion, Laboratorio.IdLaboratorio from RegistroMedicamento inner join Presentacion on Presentacion.IdPresentacion = RegistroMedicamento.IdPresentacion inner join Laboratorio on Laboratorio.IdLaboratorio=RegistroMedicamento.IdLaboratorio"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "RegistroMedicamento")

        miCommand.CommandText = "select MedicamentoDanado.IdMedicamentoDanado,RegistroMedicamento.NombreMedicamento,Presentacion.Presentacion, Laboratorio.Laboratorio, MotivosDano.MotivoDano, MotivosDano.IdMotivoDano, MedicamentoDanado.Cantidad, MedicamentoDanado.FechaDeReporte, RegistroMedicamento.IdRegistroMedicamento, Presentacion.IdPresentacion, Laboratorio.IdLaboratorio from MedicamentoDanado inner join RegistroMedicamento on RegistroMedicamento.IdRegistroMedicamento = MedicamentoDanado.IdRegistroMedicamento inner join Laboratorio on RegistroMedicamento.IdLaboratorio = Laboratorio.IdLaboratorio inner join Presentacion on Presentacion.IdPresentacion = RegistroMedicamento.IdPresentacion inner join MotivosDano on MotivosDano.IdMotivoDano = MedicamentoDanado.IdMotivoDanado"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Medicamentodanado")


        miCommand.CommandText = "select Clientes.IdClientes, TipoCliente.TipoCliente, Clientes.Nombre, Clientes.Telefono, Clientes.Direccion, TipoCliente.IdTipoCliente from Clientes inner join TipoCliente on TipoCliente.IdTipoCliente = Clientes.IdTipoCliente"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Clientes")

        miCommand.CommandText = "select PorcientoGanancia.IdPorcientoGanancia, TipoCliente.TipoCliente, PorcientoGanancia.MargenGanancia, TipoCliente.IdTipoCliente from PorcientoGanancia inner join TipoCliente on TipoCliente.IdTipoCliente = PorcientoGanancia.IdTipoCliente"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Ganancia")


        miCommand.CommandText = "select Clientes.IdClientes, Clientes.Nombre, Descuentos.IdDescuentos, Descuentos.MargenDescuento, PorcientoGanancia.IdPorcientoGanancia, PorcientoGanancia.MargenGanancia from Clientes inner join Descuentos on Descuentos.IdTipoClientes = Clientes.IdTipoCliente inner join PorcientoGanancia on PorcientoGanancia.IdTipoCliente = Clientes.IdTipoCliente"
        '                               Descuentos.IdDescuentos, TipoCliente.TipoCliente, Descuentos.MargenDescuento, TipoCliente.IdTipoCliente from Descuentos inner join TipoCliente on TipoCliente.IdTipoCliente = Descuentos.IdTipoClientes"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Gananciadescuentocliente")



        'miCommand.CommandText = "select Precios.IdPrecios, Solicitudes.Codigo, Precios.PrecioCompra from Precios inner join Solicitudes on Solicitudes.IdSolicitudes = Precios.IdSolicitudes"
        'miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        'miAdapter.Fill(ds, "Precio")


        miCommand.CommandText = "select detallecompra.Iddetallecompra,RegistroMedicamento.NombreMedicamento,Presentacion.Presentacion, Laboratorio.Laboratorio, detallecompra.Cantidad, detallecompra.PrecioCompra, detallecompra.CosteAdicional, Compras.IdCompra, Compras.nunfactura, RegistroMedicamento.IdRegistroMedicamento, Presentacion.IdPresentacion, Laboratorio.IdLaboratorio from detallecompra inner join RegistroMedicamento on RegistroMedicamento.IdRegistroMedicamento = detallecompra.IdRegistroMedicamento inner join Laboratorio on RegistroMedicamento.IdLaboratorio = Laboratorio.IdLaboratorio inner join Presentacion on Presentacion.IdPresentacion = RegistroMedicamento.IdPresentacion inner join Compras on Compras.IdCompra = detallecompra.IdCompra"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Compras")

        miCommand.CommandText = "select Compras.IdCompra, Compras.nunfactura, Proveedores.IdProveedores,Proveedores.Proveedor, Tipofactura.Idtipofactura, TipoFactura.tipofactura, Compras.fecha, Formapago.Formapago,Formapago.Idformapago, Sucursal.IdSucursal,Sucursal.Ubicacion from Compras inner join Proveedores on Proveedores.IdProveedores = Compras.IdProveedor inner join Tipofactura on Tipofactura.Idtipofactura = Compras.IdTipoFactura inner join Formapago on Formapago.Idformapago = Compras.IdFormaPago inner join Sucursal on Sucursal.IdSucursal = Compras.IdSucursal"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "FacturaCompras")



        miCommand.CommandText = "Select Descuentos.IdDescuentos, TipoCliente.TipoCliente, Descuentos.MargenDescuento, TipoCliente.IdTipoCliente from Descuentos inner join TipoCliente on TipoCliente.IdTipoCliente = Descuentos.IdTipoClientes"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Descuentos")


        miCommand.CommandText = "select Usuarios.IdUsuarios,Usuarios.Usuario, Usuarios.Contrasena, Empleados.NombreCompleto, Empleados.IdEmpleado from Usuarios inner join Empleados on Empleados.IdEmpleado = Usuarios.IdEmpleado"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Usuarios")


        miCommand.CommandText = "select Solicitudes.IdSolicitudes, Solicitudes.Codigo, Proveedores.IdProveedores,Proveedores.Proveedor, Empleados.IdEmpleado, Empleados.NombreCompleto, Solicitudes.Fecha_Registro, Sucursal.IdSucursal,Sucursal.Ubicacion from Solicitudes inner join Proveedores on Proveedores.IdProveedores = Solicitudes.IdProveedor inner join Empleados on Empleados.IdEmpleado = Solicitudes.IdEmpleado inner join Sucursal on Sucursal.IdSucursal = Solicitudes.IdSucursal"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "nuevasolicitud")

        miCommand.CommandText = "select detallesolicitud.Iddsolicitud,RegistroMedicamento.NombreMedicamento,Presentacion.Presentacion, Laboratorio.Laboratorio, detallesolicitud.Cantidadsolicitada, detallesolicitud.Precio, Solicitudes.IdSolicitudes, Solicitudes.Codigo, RegistroMedicamento.IdRegistroMedicamento, Presentacion.IdPresentacion, Laboratorio.IdLaboratorio from detallesolicitud inner join RegistroMedicamento on RegistroMedicamento.IdRegistroMedicamento = detallesolicitud.IdRegistroMedicamento inner join Laboratorio on RegistroMedicamento.IdLaboratorio = Laboratorio.IdLaboratorio inner join Presentacion on Presentacion.IdPresentacion = RegistroMedicamento.IdPresentacion inner join Solicitudes on Solicitudes.IdSolicitudes = detallesolicitud.IdSolicitud"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "detallesolicitud")


        miCommand.CommandText = "select detallesventa.Iddventas,RegistroMedicamento.NombreMedicamento,Presentacion.Presentacion, Laboratorio.Laboratorio, detallesventa.Cantidad,detallesventa.Ingreso, Ventas.IdVentas, Ventas.numfactura, RegistroMedicamento.IdRegistroMedicamento, Presentacion.IdPresentacion, Laboratorio.IdLaboratorio from detallesventa inner join RegistroMedicamento on RegistroMedicamento.IdRegistroMedicamento = detallesventa.IdRegistroMedicamento inner join Laboratorio on RegistroMedicamento.IdLaboratorio = Laboratorio.IdLaboratorio inner join Presentacion on Presentacion.IdPresentacion = RegistroMedicamento.IdPresentacion inner join Ventas on Ventas.IdVentas = detallesventa.IdVenta"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "detalleventa")

        miCommand.CommandText = "select Ventas.IdVentas, Ventas.numfactura, Ventas.fechaventa, Formapago.Formapago,Formapago.Idformapago, Clientes.Nombre,Clientes.IdClientes, Tipofactura.Idtipofactura, TipoFactura.tipofactura,Empleados.NombreCompleto, Empleados.IdEmpleado, Sucursal.IdSucursal,Sucursal.Ubicacion from Ventas inner join Formapago on Formapago.Idformapago = Ventas.IdFormapago inner join Clientes on Clientes.IdClientes = Ventas.IdCliente inner join Tipofactura on Tipofactura.Idtipofactura = Ventas.Idtipofactura inner join Empleados on Empleados.IdEmpleado = Ventas.IdEmpleado inner join Sucursal on Sucursal.IdSucursal = Ventas.Idsucursal"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "nuevaventa")


        Return ds
    End Function



    'Alterar datos de una tabla
    Public Function mantenimientoEmpleados(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "',
                  '" + datos(3) + "',
                  '" + datos(4) + "',
                  '" + datos(5) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 

                  NombreCompleto='" + datos(1) + "',
                  DUI           ='" + datos(2) + "',
                  Telefono      ='" + datos(3) + "',
                  Correo        ='" + datos(4) + "',
                  Direccion     ='" + datos(5) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function


    Public Function mantenimientoProveedores(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "',
                  '" + datos(3) + "',
                  '" + datos(4) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 

                  Proveedor='" + datos(1) + "',
                  Telefono           ='" + datos(2) + "',
                  Direccion      ='" + datos(3) + "',
                  Correo        ='" + datos(4) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function

    Public Function mantenimientomedicamentodanado(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "',
                  '" + datos(3) + "',
                  '" + datos(4) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  IdRegistroMedicamento='" + datos(1) + "',
                  IdMotivoDanado     ='" + datos(2) + "',
                  Cantidad      ='" + datos(3) + "',
                  FechaDeReporte       ='" + datos(4) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function


    Public Function mantenimientoLaboratorios(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "',
                  '" + datos(3) + "',
                  '" + datos(4) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  Laboratorio='" + datos(1) + "',
                  Telefono='" + datos(2) + "',
                  Ubicacion='" + datos(3) + "',
                  Correo='" + datos(4) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function


    Public Function mantenimientoMotivosDaño(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  MotivoDano='" + datos(1) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function


    Public Function mantenimientoPresentacion(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  Presentacion='" + datos(1) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function


    Public Function mantenimientoCargo(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "'
                 )"
            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  Cargo='" + datos(1) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function


    Public Function mantenimientoTiposCliente(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "'
                 )"
            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  TipoCliente='" + datos(1) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function


    Public Function mantenimientoformapago(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "'
                 )"
            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  Formapago='" + datos(1) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function

    Public Function mantenimientotipofactura(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "'
                 )"
            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  tipofactura='" + datos(1) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select
        If (executesql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function

    Public Function mantenimientoMedicamentoGeneral(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "',
                  '" + datos(3) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  NombreMedicamento='" + datos(1) + "',
                  IdPresentacion='" + datos(2) + "',
                  IdLaboratorio='" + datos(3) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function


    Public Function mantenimientoClientes(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "',
                   '" + datos(3) + "',
                  '" + datos(4) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  IdTipoCliente='" + datos(1) + "',
                  Nombre='" + datos(2) + "',
                  Telefono='" + datos(3) + "',
                  Direccion='" + datos(4) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function

    Public Function mantenimientoGanancia(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  IdTipoCliente='" + datos(1) + "',
                  MargenGanancia='" + datos(2) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select


        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function

    Public Function mantenimientoPrecio(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                  PrecioCompra='" + datos(1) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function



    Public Function mantenimientoDescuentos(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                 IdTipoClientes='" + datos(1) + "',
                  MargenDescuento='" + datos(2) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function

    Public Function mantenimientoUsuarios(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "', 
                  '" + datos(3) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                 Usuario='" + datos(1) + "',
                 Contrasena='" + datos(2) + "',
                 IdEmpleado='" + datos(3) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function

    Public Function mantenimientosucursales(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "', 
                  '" + datos(3) + "', 
                  '" + datos(4) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                 CodigoSucursal='" + datos(1) + "',
                 Ubicacion='" + datos(2) + "',
                 Telefono='" + datos(3) + "',
                 Fax='" + datos(4) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function




    Public Function user(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion


            Case "modificar"



                miCommand.Connection = miConexion
                miCommand.CommandText = "select (IdEmpleado) from Usuarios where Usuario = '" + datos(0) + "' and Contrasena = '" + datos(1) + "'"



                Dim j = miCommand.ExecuteScalar()
                If (j > 0) Then
                    Module1.idempleado = j
                    msg = "realizada"

                ElseIf msg = "error en el proceso" Then
                End If



                Return msg






        End Select



    End Function






    Public Function mantenimientodetallecompra(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "', 
                  '" + datos(3) + "', 
                  '" + datos(4) + "', 
                  '" + datos(5) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                 IdRegistroMedicamento='" + datos(1) + "',
                 Cantidad='" + datos(2) + "',
                 PrecioCompra='" + datos(3) + "',
                 CosteAdicional='" + datos(4) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function

    Public Function mantenimientodetallesolicitudes(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "', 
                  '" + datos(3) + "', 
                  '" + datos(4) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                 IdRegistroMedicamento='" + datos(1) + "',
                 Cantidadsolicitada='" + datos(2) + "',
                 Precio='" + datos(3) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function


    Public Function mantenimientodetallesventa(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "', 
                  '" + datos(3) + "', 
                  '" + datos(4) + "'
                 )"

            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                 IdRegistroMedicamento='" + datos(1) + "',
                 Cantidad='" + datos(2) + "',
                 ingreso='" + datos(3) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
            msg = "Error en el proceso"
        End If
        Return msg
    End Function




    Public Function mantenimientocompra(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "', 
                  '" + datos(3) + "', 
                  '" + datos(4) + "', 
                  '" + datos(5) + "', 
                  '" + datos(6) + "'
                 )"


                If (executesql(sql) > 0) Then
                    msg = "Accion realizada"

                    miCommand.Connection = miConexion
                    miCommand.CommandText = "select MAX(IdCompra) AS IdCompra from Compras"
                    datos(0) = miCommand.ExecuteScalar().ToString()
                    Module1.idcompra = datos(0)
                    Module1.factura = datos(1)
                Else
                    msg = "Error en el proceso"
                End If
                Return msg


            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                 IdProveedor='" + datos(2) + "',
                 IdTipoFactura='" + datos(3) + "',
                 fecha='" + datos(4) + "',
                 IdFormaPago='" + datos(5) + "',
                 IdSucursal='" + datos(6) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

                If (executesql(sql) > 0) Then
                    msg = "Accion realizada"
                Else
                    msg = "Error en el proceso"

                End If
                Return msg
            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"

                If (executesql(sql) > 0) Then
                    msg = "Accion realizada"
                Else
                    msg = "Error en el proceso"
                End If
                Return msg
        End Select


    End Function




    Public Function mantenimientosolicitudes(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "', 
                  '" + datos(3) + "', 
                  '" + datos(4) + "',  
                  '" + datos(5) + "'
                 )"


                If (executesql(sql) > 0) Then
                    msg = "Accion realizada"

                    miCommand.Connection = miConexion
                    miCommand.CommandText = "select MAX(IdSolicitudes) AS IdSolicitudes from Solicitudes"
                    datos(0) = miCommand.ExecuteScalar().ToString()
                    Module1.idcompra = datos(0)
                    Module1.factura = datos(1)
                Else
                    msg = "Error en el proceso"
                End If
                Return msg


            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                 IdProveedor='" + datos(2) + "',
                 IdEmpleado='" + datos(3) + "',
                 fecha_Registro='" + datos(4) + "',
                 IdSucursal='" + datos(5) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

                If (executesql(sql) > 0) Then
                    msg = "Accion realizada"
                Else
                    msg = "Error en el proceso"

                End If
                Return msg
            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"

                If (executesql(sql) > 0) Then
                    msg = "Accion realizada"
                Else
                    msg = "Error en el proceso"
                End If
                Return msg
        End Select


    End Function

    Public Function mantenimientoventas(ByVal datos As String(), ByVal accion As String, ByVal comandosql As String, ByVal id As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into " + comandosql + " VALUES 
                (
                  '" + datos(1) + "', 
                  '" + datos(2) + "', 
                  '" + datos(3) + "', 
                  '" + datos(4) + "',  
                  '" + datos(5) + "',  
                  '" + datos(6) + "',  
                  '" + datos(7) + "'
                 )"


                If (executesql(sql) > 0) Then
                    msg = "Accion realizada"

                    miCommand.Connection = miConexion
                    miCommand.CommandText = "select MAX(IdVentas) AS IdVentas from Ventas"
                    datos(0) = miCommand.ExecuteScalar().ToString()
                    Module1.idcompra = datos(0)
                    Module1.factura = datos(1)
                Else
                    msg = "Error en el proceso"
                End If

                Return msg


            Case "modificar"
                sql = "UPDATE " + comandosql + " SET 
                 fechaventa='" + datos(2) + "',
                 IdFormapago='" + datos(3) + "',
                 IdCliente='" + datos(4) + "',
                 Idtipofactura='" + datos(5) + "',
                 IdEmpleado='" + datos(6) + "',
                 IdSucursal='" + datos(7) + "'
            WHERE " + id + "    ='" + datos(0) + "'"

                If (executesql(sql) > 0) Then
                    msg = "Accion realizada"
                Else
                    msg = "Error en el proceso"

                End If
                Return msg
            Case "eliminar"
                sql = "DELETE FROM " + comandosql + " WHERE " + id + "='" + datos(0) + "'"

                If (executesql(sql) > 0) Then
                    msg = "Accion realizada"
                Else
                    msg = "Error en el proceso"
                End If
                Return msg
        End Select


    End Function




    'Encargado de los comandos sql, no tocar
    Private Function executesql(ByVal sql As String)
        Try
            miCommand.Connection = miConexion
            miCommand.CommandText = sql
            Return miCommand.ExecuteNonQuery()

        Catch ex As Exception

            Return 0
        End Try
    End Function
End Class

