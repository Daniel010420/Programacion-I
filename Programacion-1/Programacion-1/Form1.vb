Public Class Form1

    'clases
    Dim objcalculos = New calculos
    Dim objconvertidor = New conversor


    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim serie() = txtresultado.Text.Split("/")




        'si al menos un campo esta con datos
        If txtcantidad.Text <> "" Or txtresultado.Text <> "" Or txtunidad.Text <> "" Then
            'si cantidad esta vacia, y hay unidades y grupos, calcular la cantidad
            If txtcantidad.Text = "" And txtunidad.Text <> "" And txtresultado.Text <> "" Then
                'enviar datos a la clase llamada mi conversor con la variable enviounidad
                objcalculos.enviounidad = txtunidad.Text
                'enviar arreglo dividido con / y hacer llamado de la funcion rcantidad
                txtcantidad.Text = objcalculos.rcantidad(serie)

                'si solo tiene datos el campo de resultado
            ElseIf txtresultado.Text <> "" And txtcantidad.Text = "" And txtunidad.Text = "" Then
                Dim j As Integer
                For Each ewe In serie
                    j = j + ewe
                Next
                txtcantidad.Text = j
                txtunidad.Text = 1

                'si unidades esta vacio y resultado esta vacio
            ElseIf txtunidad.Text = "" And txtcantidad.Text <> "" Then
                'resultados tomara el valor de cantidad, y 0 unidades
                txtresultado.Text = (txtcantidad.Text).ToString + "/" + (0).ToString

                'si resultado esta vacio y cantidad y unidades tiene datos
            ElseIf txtresultado.Text = "" And txtcantidad.Text <> "" And txtunidad.Text <> "" Then
                'resultado tomara el valor correspondiente
                txtresultado.Text = (txtcantidad.Text \ txtunidad.Text).ToString + "/" + (txtcantidad.Text Mod txtunidad.Text).ToString


            End If
            'si todos los campos estan vacios, enviar un mensaje
        ElseIf txtcantidad.Text = "" And txtresultado.Text = "" And txtunidad.Text = "" Then
            MessageBox.Show("Por favor rellena algunos datos")
        End If
    End Sub

    'limpiar campos
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtcantidad.Clear()
        txtresultado.Clear()
        txtunidad.Clear()
    End Sub




    '///////////////////////////////////////////////////////////////////////////////////////////////////////////



    'cargar datos a combobox de conversor de area
    Private Sub cobde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobde.SelectedIndexChanged
        coba.Items.Clear()
        coba.Items.AddRange(objconvertidor.convertira)
    End Sub

    'cargar datos a combobox de conversor de area
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cobde.Items.Clear()
        cobde.Items.AddRange(objconvertidor.convertirde)
    End Sub


    'calcular conversion de area, los datos son enviados a la clase convertidor
    Private Sub btncalcularsuperficie_Click(sender As Object, e As EventArgs) Handles btncalcularsuperficie.Click

        If txtcantidadsuperficie.Text <> "" And cobde.SelectedIndex >= 0 And coba.SelectedIndex >= 0 Then
            Dim posicioncobde, posicioncoba As SByte
            'toma la posicion selecionada
            posicioncobde = cobde.SelectedIndex
            posicioncoba = coba.SelectedIndex

            'enviar datos a la clase
            objconvertidor.enviocantidadacalcular = txtcantidadsuperficie.Text
            objconvertidor.envioposicioncobde = posicioncobde
            objconvertidor.envioposicioncoba = posicioncoba
            'hace llamado a la funcion calculo area dentro de la calse convertidor
            lblresultado.Text = objconvertidor.calculodearea

        ElseIf txtcantidadsuperficie.Text = "" Or cobde.SelectedIndex < 0 Or coba.SelectedIndex < 0 Then
            MessageBox.Show("Por favor rellena todos los datos")
        End If




    End Sub
End Class



