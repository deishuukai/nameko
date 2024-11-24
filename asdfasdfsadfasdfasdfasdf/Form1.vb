Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtUsername As String
        Dim txtPassword As String
        txtUsername = "Mark"
        txtPassword = "013006"
        If (txtUsername = txtUsername And txtPassword = txtPassword) Then


            MsgBox("WELCOME MASTER")
            Form2.Show()
        Else

            MsgBox("YOU'RE NOT MY MASTER SORRY")
        End If
    End Sub
End Class
