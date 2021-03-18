Public Class TeacherProfile
    Sub SwitchPanel(ByVal panel As Form)
        TeacherForm.PnlContent.Controls.Clear()
        panel.TopLevel = False
        TeacherForm.PnlContent.Controls.Add(panel)
        panel.Show()
    End Sub
    Sub Kosongkan()

        q = "select * from tb_teacher where idteacher = '" & teacherid & "'"
        Cari(q)
        If dr.HasRows Then
            TbNama.Text = dr.Item("name")
            TbGender.Text = dr.Item("gender")
            TbPhoto.Text = dr.Item("photo")
        End If

        Dim PathPhoto As String = dr.Item("photo")
        If Not PathPhoto = "" Then
            PictureBox1.BackgroundImage = Image.FromFile(PathPhoto)

        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp"
            .FilterIndex = 1
            .Title = "Pilih Gambar"
        End With

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            TbPhoto.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub TeacherProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Kosongkan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not TbNama.Text = "" Or TbGender.Text = "" Or TbPhoto.Text = "" Then
            q = "update tb_teacher set name = '" & TbNama.Text & "', gender = '" & TbGender.Text & "',photo = '" & TbPhoto.Text & "' where idteacher = '" & teacherid & "'"
            executenonquery(q)
            MsgBox("Succes")
            Kosongkan()
        Else
            MsgBox("Data Tidak Lengkap")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SwitchPanel(TeacherHome)
    End Sub
End Class