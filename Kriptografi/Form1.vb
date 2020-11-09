Public Class Form1
    Sub OnText1()
        TextBox2.Enabled = True
    End Sub
    Sub OnText2()
        TextBox4.Enabled = True
    End Sub
    Sub Reset()
        TextBox2.Enabled = False
        TextBox4.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Enkrip, Output, Inputan As String
        Dim Panjang_Input As Integer
        Inputan = TextBox1.Text
        Panjang_Input = Len(TextBox1.Text)

        For i = 1 To Panjang_Input
            Enkrip = Mid(Inputan, i, 1)
            Enkrip = Asc(Enkrip)
            Enkrip = (Enkrip + 20) - 40
            Enkrip = Chr(Enkrip)
            Output = Output & Enkrip
        Next i

        TextBox2.Text = Output
        Call OnText1()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Dekrip, Output, Inputan As String
        Dim Panjang_Input As Integer
        Inputan = TextBox3.Text
        Panjang_Input = Len(TextBox3.Text)

        For i = 1 To Panjang_Input
            Dekrip = Mid(Inputan, i, 1)
            Dekrip = Asc(Dekrip)
            Dekrip = (Dekrip - 20) + 40
            Dekrip = Chr(Dekrip)
            Output = Output & Dekrip
        Next i

        TextBox4.Text = Output
        Call OnText2()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Reset()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class