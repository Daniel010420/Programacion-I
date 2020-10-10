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
    Public Function obtenerDatosEmpleados()
        ds.Clear()
        miCommand.Connection = miConexion
        'seleciona todos los datos de la tabla
        miCommand.CommandText = "select * from Empleados"
        miAdapter.SelectCommand = miCommand
        'carga los datos de esta tabla en la palabra "Empleados" para ser enviados
        miAdapter.Fill(ds, "Empleados")
        Return ds
    End Function



    'Alterar datos de una tabla
    Public Function mantenimientoEmpleados(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        'dato(0) sera el ID de cada tabla
        Select Case accion
            Case "nuevo"
                sql = "INSERT into Empleados (NombreCompleto,DUI,Telefono,Correo,Direccion) VALUES ('" + datos(1) + "', '" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "')"
            Case "modificar"
                sql = "UPDATE Empleados SET NombreCompleto='" + datos(1) + "',DUI='" + datos(2) + "',Telefono='" + datos(3) + "',Correo='" + datos(4) + "',Direccion='" + datos(5) + "' WHERE IdEmpleado='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Empleados WHERE IdEmpleado='" + datos(0) + "'"
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
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function
End Class

