Public Class Adminform
    Sub SwitchPanel(ByVal panel As Form)
        PnlContent.Controls.Clear()
        panel.TopLevel = False
        PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(AdminHome)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SwitchPanel(AdminHome)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SwitchPanel(AdminManageStudent)
        AdminManageStudent.Kosongkan()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SwitchPanel(AdminManageTeacher)
        AdminManageTeacher.Kosongkan()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SwitchPanel(AdminManageClass)
        AdminManageClass.Kosongkan()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SwitchPanel(AdminManageSchedule)
        AdminManageSchedule.Kosongkan()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SwitchPanel(AdminLogout)
    End Sub
End Class