Public Class Form1

    Private Sub btnmostrarpareseimpares_Click(sender As Object, e As EventArgs) Handles btnmostrarpareseimpares.Click

        'se limpia la caja
        ltbmostrar.Items.Clear()

        'se imprime un mensaje de imofrmacion
        ltbmostrar.Items.Add("Numero pares del 0 al 20")

        'ciclo for para escribir los numeros pares en caja dirrectamente
        For i = 2 To 20 Step 2
            ltbmostrar.Items.Add(i)
        Next

        'se imprime un mensaje de imofrmacion
        ltbmostrar.Items.Add("Numero impares del 0 al 20")

        'ciclo for para escribir los numeros impares en caja dirrectamente
        For i = 1 To 20 Step 2
            ltbmostrar.Items.Add(i)
        Next
    End Sub


    Private Sub btnparoimpar_Click(sender As Object, e As EventArgs) Handles btnparoimpar.Click

        Dim numero
        'se asigna el valor del txt a la variable numero
        numero = txtnumero.Text

        'se saca el residuo del numero entre dos para saber si es par o no
        If numero Mod 2 = 0 Then

            MessageBox.Show("El numero " + numero + " es par")
        Else
            MessageBox.Show("El numero " + numero + " es impar")
        End If

    End Sub

    Private Sub btnprimo_Click(sender As Object, e As EventArgs) Handles btnprimo.Click

        Dim numero = txtnumero.Text
        Dim contador = 1
        Dim i = 0

        'ciclo para dividir todos los numeros anteriores e iguales al numero escrito
        'si el residuo es igual a 0 en mas de 2 veces no es un numero primo
        While i < 3 And contador <= numero

            If numero Mod contador = 0 Then
                i = i + 1
            End If

            'contador para no dividir numeros mayores a el ingresado
            contador = contador + 1
        End While

        If i <= 2 Then
            MessageBox.Show("Es primo")
        Else
            MessageBox.Show("No es primo")
        End If

    End Sub

    Private Sub btncajero_Click(sender As Object, e As EventArgs) Handles btncajero.Click
        'declarar un array
        Dim dinero() = {100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01}

        Dim total = txtnumero.Text
        Dim cantidad = 0
        Dim moneda As String
        ltbmostrar.Items.Clear()


        'ciclo for para recorer array
        'i toma el valor de la posicion 0 del array
        For Each i In dinero
            'mientras se deba dinero y el valor de i sea igual o menor a la cantidad que se debe
            While total > 0 And i <= total
                total = (total - i)
                'contador de cuantos dolares del mismo tipo se necesitan
                cantidad = cantidad + 1
            End While

            'si hay al menos una moneda o dolar usado
            If cantidad >= 1 Then
                'se especifica si es menor de 1 dolar como moneda 
                If i <= 1 Then
                    moneda = " moneda de "
                Else
                    moneda = " billete de "
                End If

                'se imprimer los datos optenidos
                ltbmostrar.Items.Add(cantidad.ToString() + moneda + i.ToString())
                cantidad = 0
            End If
        Next


    End Sub
End Class