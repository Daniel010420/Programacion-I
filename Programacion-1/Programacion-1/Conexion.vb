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
    Public Function obtenerDatos(ByVal tablaBd As String)
        ds.Clear()
        miCommand.Connection = miConexion
        'seleciona todos los datos de la tabla
        miCommand.CommandText = "select * from " + tablaBd
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "Empleados" para ser enviados
        miAdapter.Fill(ds, "DatosTabla")
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

                  Nombre='" + datos(1) + "',
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
                  Nombre='" + datos(1) + "',
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




    'Encargado de los comandos sql, no tocar
    Private Function executesql(ByVal sql As String)

        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function
End Class

