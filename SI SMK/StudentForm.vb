Public Class StudentForm
    Sub SwitchPanel(ByVal panel As Form)
        PNLCONTENREAL.Controls.Clear()
        panel.TopLevel = False
        PNLCONTENREAL.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(StudentHome)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SwitchPanel(StudentHome)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SwitchPanel(STudentSchedule)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SwitchPanel(StudentLogout)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SwitchPanel(StudentProfile)
    End Sub
End Class