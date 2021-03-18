Public Class StudentProfile
    Sub kosongkan()
        q = "select * from tb_student where idstudent = '" & studentid & "'"
        Cari(q)
        If dr.HasRows Then
            TbNama.Text = dr.Item("name")
            TbAddress.Text = dr.Item("address")
            CbGender.Text = dr.Item("gender")
            DTPBirth.Text = dr.Item("dateofbirth")
            TbPhone.Text = dr.Item("nohp")
            TbPhoto.Text = dr.Item("photo")
            PictureBox1.BackgroundImage = Image.FromFile(dr.Item("photo"))
        End If
        DTPBirth.Format = DateTimePickerFormat.Custom
        DTPBirth.CustomFormat = "dd MMM yyyy hh:mm"
    End Sub
    Private Sub StudentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        kosongkan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp"
            .FilterIndex = 1
            .Title = "Pilih Gambar"
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            TbPhoto.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        q = "update tb_student set name='" & TbNama.Text & "',address = '" & TbAddress.Text & "',gender = '" & CbGender.Text & "',dateofbirth='" & Format(DTPBirth.Value, "dd MMM yyyy hh:mm") & "',nohp='" & TbPhone.Text & "',photo ='" & TbPhoto.Text & "' where idstudent='" & studentid & "'"
        executenonquery(q)
        MsgBox("Success")
        kosongkan()
    End Sub
End Class