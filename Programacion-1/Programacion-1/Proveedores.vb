﻿Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BDFarmacia_SantaFeDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me._BDFarmacia_SantaFeDataSet.Proveedores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class