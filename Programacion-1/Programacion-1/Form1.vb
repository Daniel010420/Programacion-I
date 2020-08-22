Public Class Form1
    Private Sub cobtipodeconversion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobtipodeconversion.SelectedIndexChanged



        'Si selecciona monedas
        If cobtipodeconversion.SelectedItem = "Monedas" Then
            cobdato1.Items.Clear()
            cobdato1.Items.Add("Colón Salvadoreño")
            cobdato1.Items.Add("Colón Costarricense")
            cobdato1.Items.Add("Quetzal")
            cobdato1.Items.Add("Lempira")
            cobdato1.Items.Add("Córdoba")
            cobdato1.Items.Add("Balboa")
            cobdato1.Items.Add("Dólar Beliceño")
            cobdato1.Items.Add("Dólar Estadounidense")
            cobdato1.Items.Add("Peso Argentino")
            cobdato1.Items.Add("Dólar Canadiense")

            cobdato2.Items.Clear()
            cobdato2.Items.Add("Colón Salvadoreño")
            cobdato2.Items.Add("Colón Costarricense")
            cobdato2.Items.Add("Quetzal")
            cobdato2.Items.Add("Lempira")
            cobdato2.Items.Add("Córdoba")
            cobdato2.Items.Add("Balboa")
            cobdato2.Items.Add("Dólar Beliceño")
            cobdato2.Items.Add("Dólar Estadounidense")
            cobdato2.Items.Add("Peso Argentino")
            cobdato2.Items.Add("Dólar Canadiense")

            'Si selecciona Masa
        ElseIf cobtipodeconversion.SelectedItem = "Masa" Then
            cobdato1.Items.Clear()
            cobdato1.Items.Add("Tonelada")
            cobdato1.Items.Add("Kilogramo")
            cobdato1.Items.Add("Gramo")
            cobdato1.Items.Add("Miligramo")
            cobdato1.Items.Add("Microgramo")
            cobdato1.Items.Add("Tonelada larga")
            cobdato1.Items.Add("Tonelada corta")
            cobdato1.Items.Add("Stone")
            cobdato1.Items.Add("Libra")
            cobdato1.Items.Add("Onza")

            cobdato2.Items.Clear()
            cobdato2.Items.Add("Tonelada")
            cobdato2.Items.Add("Kilogramo")
            cobdato2.Items.Add("Gramo")
            cobdato2.Items.Add("Miligramo")
            cobdato2.Items.Add("Microgramo")
            cobdato2.Items.Add("Tonelada larga")
            cobdato2.Items.Add("Tonelada corta")
            cobdato2.Items.Add("Stone")
            cobdato2.Items.Add("Libra")
            cobdato2.Items.Add("Onza")

            'Si selecciona volumen
        ElseIf cobtipodeconversion.SelectedItem = "Volumen" Then
            cobdato1.Items.Clear()
            cobdato1.Items.Add("Pulgada cubica")
            cobdato1.Items.Add("Pie cubico")
            cobdato1.Items.Add("Mililitro")
            cobdato1.Items.Add("Litro")
            cobdato1.Items.Add("Metro cubico")
            cobdato1.Items.Add("Kilometro cubico")
            cobdato1.Items.Add("Galon")
            cobdato1.Items.Add("Barril")
            cobdato1.Items.Add("Yarda cubica")
            cobdato1.Items.Add("Milimetro cubico")

            cobdato2.Items.Clear()
            cobdato2.Items.Add("Pulgada cubica")
            cobdato2.Items.Add("Pie cubico")
            cobdato2.Items.Add("Mililitro")
            cobdato2.Items.Add("Litro")
            cobdato2.Items.Add("Metro cubico")
            cobdato2.Items.Add("Kilometro cubico")
            cobdato2.Items.Add("Galon")
            cobdato2.Items.Add("Barril")
            cobdato2.Items.Add("Yarda cubica")
            cobdato2.Items.Add("Milimetro cubico")

            'Si selecciona longitud
        ElseIf cobtipodeconversion.SelectedItem = "Longitud" Then
            cobdato1.Items.Clear()
            cobdato1.Items.Add("Milla")
            cobdato1.Items.Add("Kilometro")
            cobdato1.Items.Add("Metro")
            cobdato1.Items.Add("Centimetro")
            cobdato1.Items.Add("Milimetro")
            cobdato1.Items.Add("Micrometro")
            cobdato1.Items.Add("Nanometro")
            cobdato1.Items.Add("Yarda")
            cobdato1.Items.Add("Pie")
            cobdato1.Items.Add("Pulgada")

            cobdato2.Items.Clear()
            cobdato2.Items.Add("Milla")
            cobdato2.Items.Add("Kilometro")
            cobdato2.Items.Add("Metro")
            cobdato2.Items.Add("Centimetro")
            cobdato2.Items.Add("Milimetro")
            cobdato2.Items.Add("Micrometro")
            cobdato2.Items.Add("Nanometro")
            cobdato2.Items.Add("Yarda")
            cobdato2.Items.Add("Pie")
            cobdato2.Items.Add("Pulgada")

            'Si selecciona almacenamiento
        ElseIf cobtipodeconversion.SelectedItem = "Almacenamiento" Then
            cobdato1.Items.Clear()
            cobdato1.Items.Add("Bit")
            cobdato1.Items.Add("Kilobit")
            cobdato1.Items.Add("Megabit")
            cobdato1.Items.Add("Gigabit")
            cobdato1.Items.Add("Terabit")
            cobdato1.Items.Add("Byte")
            cobdato1.Items.Add("Kilobyte")
            cobdato1.Items.Add("Megabyte")
            cobdato1.Items.Add("Gigabyte")
            cobdato1.Items.Add("Terabyte")

            cobdato2.Items.Clear()
            cobdato2.Items.Add("Bit")
            cobdato2.Items.Add("Kilobit")
            cobdato2.Items.Add("Megabit")
            cobdato2.Items.Add("Gigabit")
            cobdato2.Items.Add("Terabit")
            cobdato2.Items.Add("Byte")
            cobdato2.Items.Add("Kilobyte")
            cobdato2.Items.Add("Megabyte")
            cobdato2.Items.Add("Gigabyte")
            cobdato2.Items.Add("Terabyte")

            'Si selecciona tiempo
        ElseIf cobtipodeconversion.SelectedItem = "Tiempo" Then
            cobdato1.Items.Clear()
            cobdato1.Items.Add("Semana")
            cobdato1.Items.Add("Dia")
            cobdato1.Items.Add("Hora")
            cobdato1.Items.Add("Minuto")
            cobdato1.Items.Add("Segundo")
            cobdato1.Items.Add("Lustro")
            cobdato1.Items.Add("Milenio")
            cobdato1.Items.Add("Decada")
            cobdato1.Items.Add("Siglo")
            cobdato1.Items.Add("Año")

            cobdato2.Items.Clear()
            cobdato2.Items.Add("Semana")
            cobdato2.Items.Add("Dia")
            cobdato2.Items.Add("Hora")
            cobdato2.Items.Add("Minuto")
            cobdato2.Items.Add("Segundo")
            cobdato2.Items.Add("Lustro")
            cobdato2.Items.Add("Milenio")
            cobdato2.Items.Add("Decada")
            cobdato2.Items.Add("Siglo")
            cobdato2.Items.Add("Año")

        End If

    End Sub




    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click

        If txtcantidad.Text <> "" And cobtipodeconversion.SelectedItem <> "" And cobdato1.SelectedItem <> "" And cobdato2.SelectedItem <> "" Then

            'cantidad: variable que toma el valor que el usuario quiere convertir
            Dim cantidad As Double
            'resultado: variable que guarda el resultado del proceso
            Dim resultado As Double
            'posicion: variable que toma la posicion que a selecionado la persona en el combobox para seleccionar esa posicon en el array 
            Dim posicion As Double


            'array que guardara los datos de los campos
            Dim arraydeinformacion()


            'se le asigna el valor del txtbox a la variable cantidad
            cantidad = txtcantidad.Text
            'se le asigna la posicion del combobox al que se convertira a la variable posicion
            posicion = cobdato2.SelectedIndex





            'si seleciona 
            If cobdato1.SelectedItem = "Colón Salvadoreño" Then
                arraydeinformacion = {1, 68.05, 0.88, 2.82, 3.98, 0.11, 0.23, 0.11, 8.36, 0.15}


            ElseIf cobdato1.SelectedItem = "Colón Costarricense" Then
                arraydeinformacion = {0.015, 1, 0.013, 0.041, 0.059, 0.0017, 0.0034, 0.0017, 0.12, 0.0022}


            ElseIf cobdato1.SelectedItem = "Quetzal" Then
                arraydeinformacion = {1.14, 77.34, 1, 3.2, 4.53, 0.13, 0.26, 0.13, 9.51, 0.17}


            ElseIf cobdato1.SelectedItem = "Lempira" Then
                arraydeinformacion = {0.36, 24.15, 0.31, 1, 1.41, 0.041, 0.082, 0.041, 2.98, 0.053}


            ElseIf cobdato1.SelectedItem = "Córdoba" Then
                arraydeinformacion = {0.25, 17.09, 0.22, 0.71, 1, 0.029, 0.058, 0.029, 2.11, 0.038}


            ElseIf cobdato1.SelectedItem = "Balboa" Then
                arraydeinformacion = {8.75, 595.37, 7.7, 24.66, 34.84, 1, 2.02, 1, 73.58, 1.32}


            ElseIf cobdato1.SelectedItem = "Dólar Beliceño" Then
                arraydeinformacion = {4.34, 295.37, 3.82, 12.19, 17.24, 0.5, 1, 0.5, 36.49, 0.65}


            ElseIf cobdato1.SelectedItem = "Dólar Estadounidense" Then
                arraydeinformacion = {8.75, 595.4, 7.7, 24.66, 34.84, 1, 2.02, 1, 73.56, 1.32}


            ElseIf cobdato1.SelectedItem = "Peso Argentino" Then
                arraydeinformacion = {0.12, 8.09, 0.1, 0.34, 0.47, 0.014, 0.027, 0.014, 1, 0.018}



            ElseIf cobdato1.SelectedItem = "Dólar Canadiense" Then
                arraydeinformacion = {6.64, 451.88, 5.85, 18.72, 26.44, 0.76, 1.53, 0.76, 55.84, 1}



            ElseIf cobdato1.SelectedItem = "Tonelada" Then
                arraydeinformacion = {1, 1000, 1000000, 1000000000, 1000000000000, 0.984207, 1.10231, 157.473, 2204.62199992473, 35274}


            ElseIf cobdato1.SelectedItem = "Kilogramo" Then
                arraydeinformacion = {0.001, 1, 1000, 1000000, 1000000000, 0.000984207, 0.00110231, 0.157473, 2.20462, 35.274}


            ElseIf cobdato1.SelectedItem = "Gramo" Then
                arraydeinformacion = {0.000001, 0.001, 1, 1000, 1000000.0, 0.00000098421, 0.0000011023, 0.000157473, 0.00220462, 0.035274}


            ElseIf cobdato1.SelectedItem = "Miligramo" Then
                arraydeinformacion = {0.000000001, 0.000001, 0.001, 1, 1000, 0.00000000098421, 0.0000000011023, 0.00000015747, 0.0000022046, 0.000035274}


            ElseIf cobdato1.SelectedItem = "Microgramo" Then
                arraydeinformacion = {0.000000000001, 0.000000001, 0.000001, 0.001, 1, 0.00000000000098421, 0.0000000000011023, 0.00000000015747, 0.0000000022046, 0.000000035274}


            ElseIf cobdato1.SelectedItem = "Tonelada larga" Then
                arraydeinformacion = {1.01605, 1016.05, 1016000.0, 1016000000.0, 1016000000000.0, 1, 1.12, 160, 2240, 35840}


            ElseIf cobdato1.SelectedItem = "Tonelada corta" Then
                arraydeinformacion = {0.907185, 907.185, 907185, 907200000.0, 907200000000.0, 0.892857, 1, 142.857, 2000, 32000}


            ElseIf cobdato1.SelectedItem = "Stone" Then
                arraydeinformacion = {0.00635029, 6.35029, 6350.29, 6350000.0, 6350000000.0, 0.00625, 0.007, 1, 14, 224}


            ElseIf cobdato1.SelectedItem = "Libra" Then
                arraydeinformacion = {0.000453592, 0.453592, 453.592, 453592, 453600000.0, 0.000446429, 0.0005, 0.0714286, 14, 224}


            ElseIf cobdato1.SelectedItem = "Onza" Then
                arraydeinformacion = {0.00002835, 0.0283495, 28.3495, 28349.5, 28350000.0, 0.000027902, 0.00003125, 0.00446429, 0.0625, 16}


            ElseIf cobdato1.SelectedItem = "Pulgada cubica" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Pie cubico" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Mililitro" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Litro" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Metro cubico" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Kilometro cubico" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Galon" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Barril" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Yarda cubica" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Milimetro cubico" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Milla" Then
                arraydeinformacion = {1, 1.60934, 1609.34, 160934, 1609000.0, 1609000.0, 1609000000000.0, 1760, 5280, 63360}



            ElseIf cobdato1.SelectedItem = "Kilometro" Then
                arraydeinformacion = {0.621371, 1, 1000, 100000, 1000000.0, 1000000000.0, 1000000000000.0, 1093.61, 3280.84, 39370.1}


            ElseIf cobdato1.SelectedItem = "Metro" Then
                arraydeinformacion = {0.000621371, 0.001, 1, 100, 1000, 1000000.0, 1000000000.0, 1.09361, 3.28084, 39.3701}


            ElseIf cobdato1.SelectedItem = "Centimetro" Then
                arraydeinformacion = {0.0000062137, 0.00001, 0.01, 1, 10, 10000, 10000000.0, 0.0109361, 0.0328084, 0.393701}


            ElseIf cobdato1.SelectedItem = "Milimetro" Then
                arraydeinformacion = {0.00000062137, 0.000001, 0.001, 0.1, 1, 1000, 1000000.0, 0.00109361, 0.00328084, 0.0393701}


            ElseIf cobdato1.SelectedItem = "Micrometro" Then
                arraydeinformacion = {0.00000000062137, 0.000000001, 0.000001, 0.0001, 0.001, 1, 1000, 0.0000010936, 0.0000032808, 0.00003937}


            ElseIf cobdato1.SelectedItem = "Nanometro" Then
                arraydeinformacion = {0.00000000000062137, 0.000000000001, 0.000000001, 0.0000001, 0.000001, 0.001, 1, 0.0000000010936, 0.0000000032808, 0.00000003937}


            ElseIf cobdato1.SelectedItem = "Yarda" Then
                arraydeinformacion = {0.000568182, 0.0009144, 0.9144, 0.9144, 914.4, 914400, 914400000.0, 1, 3, 36}


            ElseIf cobdato1.SelectedItem = "Pie" Then
                arraydeinformacion = {0.000189394, 0.0003048, 0.3048, 30.48, 304.8, 304800, 304800000.0, 0.333333, 1, 12}


            ElseIf cobdato1.SelectedItem = "Pulgada" Then
                arraydeinformacion = {0.000015783, 0.0000254, 0.0254, 2.54, 25.4, 25400, 25400000.0, 0.0277778, 0.0833334, 1}


            ElseIf cobdato1.SelectedItem = "Bit" Then
                arraydeinformacion = {1, 0.001, 0.000001, 0.000000001, 0.000000000001, 0.125, 0.000125, 0.000000125, 0.000000000125, 0.000000000000125}


            ElseIf cobdato1.SelectedItem = "Kilobit" Then
                arraydeinformacion = {1000, 1, 0.001, 0.000001, 0.000000001, 125, 0.125, 0.000125, 0.000125, 0.000000000125}


            ElseIf cobdato1.SelectedItem = "Megabit" Then
                arraydeinformacion = {1000000.0, 1000, 1, 0.001, 0.000001, 125000, 125, 0.125, 0.000125, 0.000000125}


            ElseIf cobdato1.SelectedItem = "Gigabit" Then
                arraydeinformacion = {1000000000.0, 1000000.0, 1000, 1, 0.001, 125000000.0, 125000, 125, 0.125, 0.000125}


            ElseIf cobdato1.SelectedItem = "Terabit" Then
                arraydeinformacion = {1000000000000.0, 1000000000.0, 1000000.0, 1000, 0.001, 125000000.0, 125000, 125, 0.125, 0.000125}


            ElseIf cobdato1.SelectedItem = "Byte" Then
                arraydeinformacion = {8, 0.008, 0.000008, 0.000000008, 0.000000008, 1, 0.001, 0.000001, 0.000000001, 0.000000000001}


            ElseIf cobdato1.SelectedItem = "Kilobyte" Then
                arraydeinformacion = {8000, 8, 0.008, 0.000008, 0.000000008, 1000, 1, 0.001, 0.000001, 0.000000001}


            ElseIf cobdato1.SelectedItem = "Megabyte" Then
                arraydeinformacion = {8000000, 8000, 8, 0.008, 0.000008, 1000000, 1000, 1, 0.001, 0.000001}


            ElseIf cobdato1.SelectedItem = "Gigabyte" Then
                arraydeinformacion = {8000000000, 8000000, 8000, 8, 0.008, 1000000000, 1000000, 1000, 1, 0.001}


            ElseIf cobdato1.SelectedItem = "Terabyte" Then
                arraydeinformacion = {8000000000000, 8000000000, 8000000, 8000, 8, 1000000000000, 1000000000, 1000000, 1000, 1}


            ElseIf cobdato1.SelectedItem = "Semana" Then
                arraydeinformacion = {1, 7, 168, 10080, 604800, 0.00383562, 0.0000191781, 0.00191781, 0.000191781, 0.0191781}


            ElseIf cobdato1.SelectedItem = "Dia" Then
                arraydeinformacion = {0.142857, 1, 24, 1440, 86400, 0.000547945, 0.00000273973, 0.000273973, 0.000027397, 0.00273973}


            ElseIf cobdato1.SelectedItem = "Hora" Then
                arraydeinformacion = {0.00595238, 0.0416667, 1, 60, 3600, 0.0000228311, 0.00000011415999999999999, 0.000011415999999999999, 0.0000011415999999999998, 0.000114155}


            ElseIf cobdato1.SelectedItem = "Minuto" Then
                arraydeinformacion = {0.000099206, 0.000694444, 0.0166667, 1, 60, 0.00000038052, 0.00000000190259, 0.00000019026, 0.000000019026, 0.0000019026}


            ElseIf cobdato1.SelectedItem = "Segundo" Then
                arraydeinformacion = {0.0000016534, 0.000011574, 0.000277778, 0.0166667, 1, 0.000000006342, 0.000000000031709999999999993, 0.000000003171, 0.00000000031709999999999997, 0.00000003171}


            ElseIf cobdato1.SelectedItem = "Lustro" Then
                arraydeinformacion = {260.714, 1825, 43800, 2628000, 15770000000000000, 1, 0.005, 0.5, 0.05, 5}


            ElseIf cobdato1.SelectedItem = "Milenio" Then
                arraydeinformacion = {52142.9, 365000, 8760000, 525600000, 31540000000, 200, 1, 100, 10, 1000}


            ElseIf cobdato1.SelectedItem = "Decada" Then
                arraydeinformacion = {521.429, 3650, 87600, 5256000, 315400000, 2, 0.01, 1, 0.1, 10}


            ElseIf cobdato1.SelectedItem = "Siglo" Then
                arraydeinformacion = {5214.29, 36500, 876000, 52560000, 3154000000, 20, 0.1, 10, 1, 100}


            ElseIf cobdato1.SelectedItem = "Año" Then
                arraydeinformacion = {52.1429, 365, 8760, 525600, 31540000, 0.2, 0.001, 0.1, 0.01, 1}


            End If

            'el resultado es igual a la multiplicacion de la cantidad que se quiere convertir por el valor que este
            'en la posicion x del array, la cual la posicion es tomada del combobox 2
            resultado = cantidad * (arraydeinformacion(posicion))
            lblresultado.Text = resultado




        ElseIf txtcantidad.Text = "" Or cobtipodeconversion.SelectedItem = "" Or cobdato1.SelectedItem = "" Or cobdato2.SelectedItem = "" Then
            MessageBox.Show("Por favor ingresa todos los datos")
        End If

    End Sub

End Class
