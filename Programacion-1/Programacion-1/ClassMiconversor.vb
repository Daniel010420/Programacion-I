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

