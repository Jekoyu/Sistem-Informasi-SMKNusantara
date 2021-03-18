Public Class LoginForm
    Sub Kosongkan()
        TbPassword.Clear()
        TbUsername.Clear()
        TbUsername.Focus()

    End Sub
    Sub loginkan()
        q = "select * from tb_user where username = '" & TbUsername.Text & "' and password = '" & TbPassword.Text & "'"
        Cari(q)
        If dr.HasRows Then
            role = dr.Item("role")
            If role = "student" Then
                q = "select * from tb_student where idstudent='" & dr.Item("username") & "'"
                Cari(q)
                If dr.HasRows Then
                    studentclass = dr.Item("idclass")
                    studentid = dr.Item("idstudent")
                    StudentHome.LabelNama.Text = dr.Item("name")
                    StudentLogout.LblNama.Text = dr.Item("name")
                End If
                StudentForm.Show()
                Me.Visible = False

            ElseIf role = "teacher" Then
                q = "select * from tb_teacher where idteacher='" & TbUsername.Text & "'"
                'MsgBox(q)
                Cari(q)
                ' MsgBox(dr.Item("name"))
                If dr.HasRows Then
                    teacherid = dr.Item("idteacher")
                    TeacherHome.LabelNama.Text = dr.Item("name")
                    TeacherLogout.LblNama.Text = dr.Item("name")
                End If
                TeacherForm.Show()
                Me.Visible = False
            ElseIf role = "admin" Then

                AdminHome.LabelNama.Text = dr.Item("username")
                AdminLogout.LblNama.Text = dr.Item("username")
                Me.Visible = False
                Adminform.Show()
            Else
                MessageBox.Show("role tidak ditemukan hubungi admin")
            End If

        Else
            MessageBox.Show("username/Password Salah")
        End If
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Kosongkan()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TbPassword.Text = "" Or TbUsername.Text = "" Then
            MsgBox("Terdapa Kolom Kosong", MsgBoxStyle.Critical)
        Else
            loginkan()
        End If
    End Sub
End Class
