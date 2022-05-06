Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dinero, conver As Double
        Dim opcion, opcion1 As Integer
        Dim contador1 As Integer
        Dim salir As String
        contador1 = 0

        'Inicio'
        Do
            contador1 = 0
            Do While (contador1 = 0)
                Try
                    opcion = InputBox("Ingresa el numero de la conversion que deseas hacer" & vbCrLf & "1. De Euro a dolares" & vbCrLf & "2. De dolares a euro" & vbCrLf & "3.De yen a dolares" & vbCrLf & "4.De dolares a yen" & vbCrLf & "5.De pesetas a dolares" & vbCrLf & "6.De dolares a pesetas" & vbCrLf & "7.De libras a dolares" & vbCrLf & "8. De dolares a libras")
                    If opcion >= 1 And opcion <= 8 Then
                        opcion1 = opcion
                    Else
                        contador1 -= 1
                    End If
                Catch ex As Exception
                    contador1 -= 1
                End Try
                contador1 += 1
            Loop
            dinero = InputBox("Ingrese la cantidad a convertir")
            'Seleccion y calculos'
            Select Case opcion1
                Case 1
                    conver = dinero * 1.1
                    MsgBox(dinero & " euros son " & conver & " dolares")
                Case 2
                    conver = dinero * 0.91
                    MsgBox(dinero & " dolares son " & conver & " euros")
                Case 3
                    conver = dinero * 122.51
                    MsgBox(dinero & " dolares son " & conver & " yenes")
                Case 4
                    conver = dinero * 0.0082
                    MsgBox(dinero & " yenes son " & conver & " dolares")
                Case 5
                    conver = dinero * 0.01
                    MsgBox(dinero & " dolares son " & conver & " pesetas")
                Case 6
                    conver = dinero * 100
                    MsgBox(dinero & " pesetas son " & conver & " dolares")
                Case 7
                    conver = dinero * 0.76
                    MsgBox(dinero & " dolares son " & conver & " libras esterlinas")
                Case 8
                    conver = dinero * 1.31
                    MsgBox(dinero & " libras esterlinas son " & conver & " dolares")
            End Select

            Do
                salir = InputBox("1. Ingrese 1 para salir" & vbCrLf &
                    "2. Ingrese 2 para realizar otro calculo")
            Loop Until IsNumeric(salir)

        Loop Until IsNumeric(salir) And CInt(salir) = 1
    End Sub
End Class
