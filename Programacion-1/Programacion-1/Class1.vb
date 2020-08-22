Public Class Estadistica
    'calcular media, la media es la suma de todos los valores dividido entre la cantidad de numeros
    Public Function CalcularMedia(cadena() As String)
        'media = suma de todos los valores
        'cannumero = suma de la cantidad de los valores
        Dim media, cannumero, resultadomedia As Double
        media = 0
        cannumero = 0
        resultadomedia = 0
        'para num, recorrer desde la posicion 0 el array cadena
        For Each num In cadena
            media = media + num
            cannumero = cannumero + 1
        Next
        resultadomedia = media / cannumero
        'devolver el resultado del proceso
        'math.round redondea valores
        Return Math.Round(resultadomedia, 2)
    End Function



    'calcular varianza, se calcula como la suma de los residuos al cuadrado divididos entre el total de observaciones.
    Public Function CalcularVarianza(cadena() As String)
        'total de media
        Dim media = CalcularMedia(cadena)
        'sumador de total de varianza
        Dim varianza As Double
        'cannumero = suma de la cantidad de los valores
        Dim cannumero As Double
        Dim resultadovarianza As Double
        varianza = 0
        cannumero = 0
        resultadovarianza = 0
        'para x1, recorrer desde la posicion 0 el array cadena
        For Each x1 In cadena
            varianza = varianza + (x1 - media) ^ 2
            cannumero = cannumero + 1
        Next
        resultadovarianza = varianza / cannumero
        Return resultadovarianza
    End Function


    'des tipica La desviación típica se define como la raíz cuadrada de la varianza
    Public Function CalcularDesvTipica(cadena() As String)
        'resultado de la varianza
        Dim var = CalcularVarianza(cadena)
        Dim resultadodestipica As Double

        ' num ^ (1/x)  num elevado a 1/x donde al aplicar un metodo
        ' x pasa a ser la raiz y 1 un exponente de num
        ' por lo que 6 ^ (1/3) es igual a tener la raiz cubica de 6

        resultadodestipica = var ^ (1 / 2)
        Return Math.Round(resultadodestipica, 2)
    End Function
End Class
