Class conversor
    Public convertirde() As String = {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea"}
    Public convertira() As String = {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea"}
    Dim datos()() = {
     New String() {"1", "0.1111", "0.111111", "0.092903", "0.00014774656489", "0.000013188960818", "9.2903e-6"}, ' para pie cuadrado, orden de combobox
     New String() {"1", "1", "1", "1", "1", "1", "1"}, ' para vara cuadrado, orden de combobox
     New String() {"1", "1", "1", "1", "1", "1", "1"}, ' para yarda cuadrado, orden de combobox
     New String() {"1", "1", "1", "1", "1", "1", "1"}, ' para metro cuadrado, orden de combobox
     New String() {"1", "1", "1", "1", "1", "1", "1"}, ' para tareas, orden de combobox
     New String() {"1", "1", "1", "1", "1", "1", "1"}, ' para manzana, orden de combobox
     New String() {"1", "1", "1", "1", "1", "1", "1"} ' para hectarea, orden de combobox
        }

    Dim _cantidad As Integer
    Dim _posicionde, _posiciona As SByte

    Public Property enviocantidadacalcular
        Set(value)
            'asignar valor a la variable _cantidad
            _cantidad = value
        End Set
        Get
            Return _cantidad
        End Get
    End Property

    Public Property envioposicioncobde
        Set(value)
            'asignar valor a la variable _posicionde
            _posicionde = value
        End Set
        Get
            Return _posicionde
        End Get
    End Property

    Public Property envioposicioncoba
        Set(value)
            'asignar valor a la variable _posiciona
            _posiciona = value
        End Set
        Get
            Return _posiciona
        End Get
    End Property



    Public Function calculodearea()

        Dim s = ((datos(_posicionde)(_posiciona)) * _cantidad)
        Return s
    End Function


End Class