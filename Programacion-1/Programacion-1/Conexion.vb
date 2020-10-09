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
        miCommand.CommandText = "select * from Empleados"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Empleados")
        Return ds

    End Function

    Public Function obtenerDatosInventario()
        ds.Clear()
        miCommand.Connection = miConexion
        miCommand.CommandText = "select * from Empleados"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Empleados")
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


End Class

