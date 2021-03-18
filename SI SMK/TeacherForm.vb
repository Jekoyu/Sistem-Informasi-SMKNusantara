Public Class TeacherForm
    Sub SwitchPanel(ByVal panel As Form)
        PnlContent.Controls.Clear()
        panel.TopLevel = False
        PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(TeacherHome)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SwitchPanel(TeacherHome)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SwitchPanel(TeacherScheduleform)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SwitchPanel(TeacherLogout)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SwitchPanel(TeacherProfile)
    End Sub


End Class