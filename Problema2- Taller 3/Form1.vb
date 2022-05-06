Public Class Form1
    'CONSTANTES'
    Dim PI = 3.1415926535897931
    'VARIABLES'
    'VALORES PARA REALZIAR LOS CALCULOS'
    Dim radio, altura As String
    Dim area, vol As Double
    Public Sub Cilindro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Do
            radio = InputBox("Ingrese el radio del cilindro")
        Loop Until IsNumeric(radio)
        Do
            altura = InputBox("Ingresa la altura del cilindro")
        Loop Until IsNumeric(altura)
        'CALCULO AREA'
        area = 2 * PI * CDbl(radio) * (CDbl(altura) + CDbl(radio))
        'CALCULO VOLUMEN'
        vol = PI * (CDbl(radio) ^ 2) * CDbl(altura)
        MsgBox("El area del cilindro es: " & Math.Round(area, 2) & vbCrLf & "El volumen del cilindro es: " & Math.Round(vol, 2))

    End Sub

End Class
