Public Class Form1

    Private Sub tntusername_Click(sender As Object, e As EventArgs) Handles tntUserName.Click
        Dim tb As TextBox = CType(sender, TextBox)

        If (String.IsNullOrEmpty(tb.Text)) Then
            tb.BackColor = Color.MistyRose
        Else
            tb.BackColor = Color.MistyRose
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("帳戶密碼正確")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

End Class
