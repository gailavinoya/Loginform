Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "abcd" And txtpassword.Text = "123" Then
            MsgBox("You login successfully")
            Form2.Show()
        Else
            MsgBox("Wrong Username or paswword")

        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
