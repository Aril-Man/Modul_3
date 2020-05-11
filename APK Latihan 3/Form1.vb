Public Class Form1
    Dim a, b As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Awal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        If a > b Then
            MsgBox("Nilai A terbesar")

        ElseIf b > a Then
            MsgBox("Nilai B terbesar")

        Else
            MsgBox("Niali A & B sama")
        End If
    End Sub
End Class
