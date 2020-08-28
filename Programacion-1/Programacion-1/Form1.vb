Public Class Form1

    Dim objromanos = New conversor_romanos
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        lblresultado.Text = objromanos.conversor(txtnumero.Text)
    End Sub

End Class

Class conversor_romanos
    'array para los numeros
    Dim romanos()() As String = {
    New String() {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "XI"}, '0>unidades
    New String() {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"}, '1>decenas
    New String() {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCC", "DCCC", "CM"} '2>centenas
    }

    Dim u, d, c, temporal As Integer

    'funcion de conversor
    Public Function conversor(ByVal num As Integer)
        'num toma el valor enviado
        u = num Mod 10
        c = num \ 100
        temporal = num Mod 100
        d = temporal \ 10

        Return romanos(2)(c) + romanos(1)(d) + romanos(0)(u)
    End Function



End Class