Public Class TeacherLogout
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoginForm.Show()
        LoginForm.Kosongkan()
        TeacherForm.Close()

    End Sub
End Class