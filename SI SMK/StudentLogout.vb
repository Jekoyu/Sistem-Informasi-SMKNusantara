Public Class StudentLogout
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoginForm.Show()
        LoginForm.Kosongkan()
        StudentForm.Close()
    End Sub


End Class