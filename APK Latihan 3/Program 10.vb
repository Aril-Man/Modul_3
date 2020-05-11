Public Class Program_10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalr1.Text = Val(tv1.Text) + Val(lemari1.Text) + Val(ac1.Text) + Val(mesin1.Text)
        Terpakai.Text = Val(totalr1.Text) + Val(totalr2.Text) + Val(totalr3.Text)
        sisa.Text = Val(total.Text) - (Val(totalr1.Text) + Val(totalr2.Text) + Val(totalr3.Text))

        If Val(totalr1.Text) < Val(total.Text) Then
            Panel1.BackColor = Color.Green
        Else
            Panel1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalr2.Text = Val(tv2.Text) + Val(lemari2.Text) + Val(ac2.Text) + Val(mesin2.Text)
        Terpakai.Text = Val(totalr1.Text) + Val(totalr2.Text) + Val(totalr3.Text)
        sisa.Text = Val(total.Text) - (Val(totalr1.Text) + Val(totalr2.Text) + Val(totalr3.Text))

        If Val(totalr2.Text) < Val(total.Text) Then
            Panel3.BackColor = Color.Green
        Else
            Panel3.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        totalr3.Text = Val(tv3.Text) + Val(lemari3.Text) + Val(ac3.Text) + Val(mesin3.Text)
        Terpakai.Text = Val(totalr1.Text) + Val(totalr2.Text) + Val(totalr3.Text)
        sisa.Text = Val(total.Text) - (Val(totalr1.Text) + Val(totalr2.Text) + Val(totalr3.Text))

        If Val(totalr3.Text) < Val(total.Text) Then
            Panel5.BackColor = Color.Green
        Else
            Panel5.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Awal.Show()
    End Sub

    Sub reset()
        total.Text = ""
        totalr1.Text = ""
        totalr2.Text = ""
        totalr3.Text = ""
        tv1.Text = ""
        tv2.Text = ""
        tv3.Text = ""
        lemari1.Text = ""
        lemari2.Text = ""
        lemari3.Text = ""
        ac1.Text = ""
        ac2.Text = ""
        ac3.Text = ""
        mesin1.Text = ""
        mesin2.Text = ""
        mesin3.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call reset()
    End Sub
End Class