Public Class Form1
    Dim num, num2, num3, num4, num5 As Integer
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub



    Dim suma = 0, resta = 0, multi = 1, div, coci, exp As Double

    Private Sub Limpiarbtn_Click(sender As Object, e As EventArgs) Handles Limpiarbtn.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        sumaTxt.Clear()
        restaTxt.Clear()
        MultiTxt.Clear()
        DiviTxt.Clear()
        CociTxt.Clear()
        ExpTxt.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'INGRESION DE DATOS'
        num = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        num3 = Val(TextBox3.Text)
        num4 = Val(TextBox4.Text)
        num5 = Val(TextBox5.Text)
        'OPERACIONES'
        suma = num + num2 + num3 + num4 + num5
        resta = num - num2 - num3 - num4 - num5
        multi = num * num2 * num3 * num4 * num5
        div = suma / 5
        coci = suma Mod 5
        exp = num ^ num2 ^ num3 ^ num4 ^ num5
        'Impresion'
        sumaTxt.Text = suma
        restaTxt.Text = resta
        MultiTxt.Text = multi
        DiviTxt.Text = div
        CociTxt.Text = coci
        ExpTxt.Text = exp

    End Sub


End Class
