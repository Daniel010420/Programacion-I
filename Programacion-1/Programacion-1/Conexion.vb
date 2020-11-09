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

        miCommand.CommandText = "select * from Cargos"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra especificada para ser enviados
        miAdapter.Fill(ds, "Cargos")

        miCommand.CommandText = "select * from MotivosDaño"
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


        miCommand.CommandText = "select Clientes.IdClientes, TipoCliente.TipoCliente, Clientes.Nombre, Clientes.Telefono, Clientes.Direccion, TipoCliente.IdTipoCliente from Clientes inner join TipoCliente on TipoCliente.IdTipoCliente = Clientes.IdTipoCliente"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Clientes")

        miCommand.CommandText = "select PorcientoGanancia.IdPorcientoGanancia, TipoCliente.TipoCliente, PorcientoGanancia.MargenGanancia, TipoCliente.IdTipoCliente from PorcientoGanancia inner join TipoCliente on TipoCliente.IdTipoCliente = PorcientoGanancia.IdTipoCliente"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Ganancia")

        miCommand.CommandText = "select Precios.IdPrecios, Solicitudes.Codigo, Precios.PrecioCompra from Precios inner join Solicitudes on Solicitudes.IdSolicitudes = Precios.IdSolicitudes"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Precio")


        miCommand.CommandText = "select Solicitudes.IdSolicitudes, Solicitudes.Codigo, Proveedores.Proveedor, RegistroMedicamento.NombreMedicamento,Presentacion.Presentacion, Laboratorio.Laboratorio, Solicitudes.Cantidad from Solicitudes inner join Proveedores on Proveedores.IdProveedores = Solicitudes.IdProveedor inner join RegistroMedicamento on RegistroMedicamento.IdRegistroMedicamento = Solicitudes.IdRegistroMedicamento inner join Laboratorio on RegistroMedicamento.IdLaboratorio = Laboratorio.IdLaboratorio inner join Presentacion on Presentacion.IdPresentacion = RegistroMedicamento.IdPresentacion"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Solicitudes")

        miCommand.CommandText = "Select Descuentos.IdDescuentos, TipoCliente.TipoCliente, Descuentos.MargenDescuento, TipoCliente.IdTipoCliente from Descuentos inner join TipoCliente on TipoCliente.IdTipoCliente = Descuentos.IdTipoClientes"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Descuentos")


        miCommand.CommandText = "select Usuarios.IdUsuarios,Usuarios.Usuario, Usuarios.Contrasena, Empleados.NombreCompleto, Empleados.IdEmpleado from Usuarios inner join Empleados on Empleados.IdEmpleado = Usuarios.IdEmpleado"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "datostabla" para ser enviados
        miAdapter.Fill(ds, "Usuarios")


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
                  MotivoDaño='" + datos(1) + "'
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

