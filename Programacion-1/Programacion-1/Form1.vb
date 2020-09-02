Public Class Form1

    'clase
    Dim objcalculos = New calculos

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim serie() = txtresultado.Text.Split("/")

        'si al menos un campo esta con datos
        If txtcantidad.Text <> "" Or txtresultado.Text <> "" Or txtunidad.Text <> "" Then
            'si cantidad esta vacia, y hay unidades y grupos, calcular la cantidad
            If txtcantidad.Text = "" And txtunidad.Text <> "" And txtresultado.Text <> "" Then
                'enviar datos a la clase con la variable enviounidad
                objcalculos.enviounidad = txtunidad.Text
                'enviar arreglo dividido con /
                txtcantidad.Text = objcalculos.rcantidad(serie)

                'si unidades esta vacio y resultado esta vacio
            ElseIf txtunidad.Text = "" And txtresultado.Text = "" Then
                'resultados tomara el valor de cantidad, y 0 unidades
                txtresultado.Text = (txtcantidad.Text).ToString + "/" + (0).ToString

                'si resultado esta vacio y cantidad y unidades tiene datos
            ElseIf txtresultado.Text = "" And txtcantidad.Text <> "" And txtunidad.Text <> "" Then
                'resultado tomara el valor correspondiente
                txtresultado.Text = (txtcantidad.Text \ txtunidad.Text).ToString + "/" + (txtcantidad.Text Mod txtunidad.Text).ToString

                'si solo tiene datos el campo de resultado
            ElseIf txtresultado.Text <> "" And txtcantidad.Text = "" And txtunidad.Text = "" Then
                Dim j As Integer
                For Each ewe In serie
                    j = j + ewe
                Next
                txtcantidad.Text = j
            End If
            'si todos los campos estan vacios, enviar un mensaje
        ElseIf txtcantidad.Text = "" And txtresultado.Text = "" And txtunidad.Text = "" Then
            MessageBox.Show("Por favor rellena algunos datos")
        End If
    End Sub
End Class


Class calculos

    Dim _unidad, _resultado1, _resultado2 As Integer
    ' atrapar el valor enviounidad 
    Public Property enviounidad
        Set(value)
            'asignar valor a la variable _unidad
            _unidad = value
        End Set
        Get
            Return _unidad
        End Get
    End Property


    'funcion para calcular cantidad
    Public Function rcantidad(serie() As String)
        'serie es el array que atrapa los datos de txt resultado
        'i es un contadoe para asignar valores
        Dim i As SByte
        i = 1
        'recorrer el array
        For Each e In serie
            If i = 1 Then
                _resultado1 = e
            End If
            If i = 2 Then
                _resultado2 = e
            End If
            i = i + 1
        Next
        'retornar el resultado
        Return ((_unidad * _resultado1) + _resultado2)
    End Function


End Class
