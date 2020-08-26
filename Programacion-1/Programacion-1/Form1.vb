Public Class Form1

    Dim objinteres As New interes()

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'envio de datos a clase interes
        objinteres.interesdado = txtinteres.Text
        objinteres.tiempodado = txttiempo.Text
        objinteres.capitaldado = txtcapital.Text

        lblsimple.Text = "Interes Simple: $" & objinteres.interesSimple()
        lblcompuesto.Text = "Interes Compuesto: $" & objinteres.interesCompuesto()
    End Sub


    Class interes

        Dim _interesrecibido As Double
        Dim _tiemporecibido As Int16
        Dim _capitalrecibido As Double

        'obtener valor enviado por el boton
        Public Property interesdado
            'tomar el valor recibido de el boton en la variable value, para comparar.
            Set(value)
                If value >= 0 And value <= 100 Then
                    _interesrecibido = value
                Else
                    MessageBox.Show("El valor del interes no es valido", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Set

            'asignar valor a _interesrecibido si es mayor o igual a 0, y igual o menor que 100
            Get
                Return _interesrecibido
            End Get
        End Property


        Public Property tiempodado
            'tomar el valor recibido de el boton en la variable value, para comparar.
            Set(value)
                If value >= 1 And value <= 120 Then
                    _tiemporecibido = value
                Else
                    MessageBox.Show("Tiempo no es valido", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Set

            'asignar valor a _tiemporecibido si es mayor o igual a 0, y igual o menor que 100
            Get
                Return _tiemporecibido
            End Get
        End Property


        Public Property capitaldado
            'tomar el valor recibido de el boton en la variable value, para comparar.
            Set(value)
                If value >= 1 Then
                    _capitalrecibido = value
                Else
                    MessageBox.Show("El capital debe ser mayor a 0", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Set

            'asignar valor a _tiemporecibido si es mayor o igual a 0, y igual o menor que 100
            Get
                Return _capitalrecibido
            End Get
        End Property


        Public Function interesSimple()
            Dim resultadointeressimple = _capitalrecibido * (_interesrecibido / 100) * (_tiemporecibido / 12)
            Return Math.Round(resultadointeressimple, 2)
        End Function


        Public Function interesCompuesto()
            Dim resultadointerescompuesto = _capitalrecibido * (1 + _interesrecibido / 100) ^ _tiemporecibido
            Return Math.Round(resultadointerescompuesto, 2)
        End Function
    End Class


End Class

