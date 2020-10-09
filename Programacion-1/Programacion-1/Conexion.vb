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

    Public Function obtenerDatosEmpleados()
        ds.Clear()
        miCommand.Connection = miConexion
        miCommand.CommandText = "select * from Empleados"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Empleados")
        Return ds

    End Function

    Public Function obtenerDatosClientes()
        ds.Clear()
        miCommand.Connection = miConexion
        miCommand.CommandText = "select * from Clientes"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Clientes")
        Return ds

    End Function

    Public Function obtenerDatosInventario()
        ds.Clear()
        miCommand.Connection = miConexion
        miCommand.CommandText = "select * from Inventario"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Inventario")
        Return ds

    End Function

    Public Function obtenerDatosProveedor()
        ds.Clear()
        miCommand.Connection = miConexion
        miCommand.CommandText = "select * from Proveedor"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Proveedor")
        Return ds

    End Function



    Public Function mantenimientoDatosInventario(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT into Inventario (NombreMedicamento,Proveedor,Laboratorio,Presentacion,Vencimiento_Lote,Precio_Presentacion,Unidades_Presentacion) VALUES ('" + datos(1) + "', '" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "')"
            Case "modificar"
                sql = "UPDATE Inventario SET NombreMedicamento='" + datos(1) + "',Proveedor='" + datos(2) + "',Laboratorio='" + datos(3) + "',Presentacion='" + datos(4) + "',Vencimiento_Lote='" + datos(5) + "',Precio_Presentacion='" + datos(6) + "',Unidades_Presentacion='" + datos(7) + "' WHERE IdRegistro='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Inventario WHERE IdRegistro='" + datos(0) + "'"
        End Select

        If (executesql(sql) > 0) Then
            msg = "Accion realizada"
        Else
        msg = "error en el proceso"
        End If

        Return msg

    End Function

    Private Function executesql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function

End Class

