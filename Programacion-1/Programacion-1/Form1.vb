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
                arraydeinformacion = {1, 68.03, 0.88, 2.82, 3.98, 0.11, 0.23, 0.11, 8.36, 0.15}


            ElseIf cobdato1.SelectedItem = "Colón Costarricense" Then
                arraydeinformacion = {0.015, 1, 0.013, 0.041, 0.059, 0.0017, 0.0034, 0.0017, 0.12, 0.0022}


            ElseIf cobdato1.SelectedItem = "Quetzal" Then
                arraydeinformacion = {1.14, 77.34, 1, 3.2, 4.53, 0.13, 0.26, 0.13, 9.51, 0.17}


            ElseIf cobdato1.SelectedItem = "Lempira" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Córdoba" Then
                arraydeinformacion = {0, 0, 0, 0, 5, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Balboa" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Dólar Beliceño" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Dólar Estadounidense" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Peso Argentino" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Dólar Canadiense" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Tonelada" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Kilogramo" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Gramo" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Miligramo" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Microgramo" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Tonelada larga" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Tonelada corta" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Stone" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Libra" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Onza" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


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
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}



            ElseIf cobdato1.SelectedItem = "Kilometro" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Metro" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Centimetro" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Milimetro" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Micrometro" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Nanometro" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Yarda" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Pie" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Pulgada" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Bit" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Kilobit" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Megabit" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Gigabit" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Terabit" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Byte" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Kilobyte" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Megabyte" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Gigabyte" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Terabyte" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Semana" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Dia" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Hora" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Minuto" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Segundo" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Lustro" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Milenio" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Decada" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Siglo" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            ElseIf cobdato1.SelectedItem = "Año" Then
                arraydeinformacion = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


            End If

            'el resultado es igual a la multiplicacion de la cantidad que se quiere convertir por el valor que este
            'en la posicion x del array, la cual la posicion es tomada del combobox 2
            resultado = cantidad * (arraydeinformacion(posicion))
            lblresultado.Text = resultado

            lblinformacion.Text = "La conversion de " + txtcantidad.Text + " " + cobdato1.SelectedItem.ToString + " a "
            lblinformacion2.Text = cobdato2.SelectedItem.ToString + " es igual a " + resultado.ToString




            'Esto se borrara
            lbl2.Text = "categ" + cobtipodeconversion.SelectedItem
            lbl4.Text = "a " + cobdato2.SelectedItem
            lbl5.Text = "Va " + arraydeinformacion(posicion).ToString + " lu " + posicion.ToString




        ElseIf txtcantidad.Text = "" Or cobtipodeconversion.SelectedItem = "" Or cobdato1.SelectedItem = "" Or cobdato2.SelectedItem = "" Then
            MessageBox.Show("Por favor ingresa todos los datos")
        End If

    End Sub

End Class
