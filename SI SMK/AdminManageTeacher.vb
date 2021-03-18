Public Class AdminManageTeacher
    Sub AutoId()
        q = "select * from tb_teacher order by idteacher desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "TCR" + Format(Microsoft.VisualBasic.Right(dr.Item("idteacher"), 6) + 1, "000000")
        Else
            TbId.Text = "TCR000001"
        End If
    End Sub
    Sub Tampilkan()
        q = "select * from tb_teacher "
        tampil(q)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub Kosongkan()
        TbName.Clear()
        TbPhoto.Clear()
        TbGender.ResetText()
        TbName.Focus()
        TbPhone.Clear()
        AutoId()
        Tampilkan()
    End Sub
    Sub Hapuskan()
        Dim r As String
        r = MsgBox("Yakin Hapus ?????", vbYesNo)
        If r = vbYes Then
            q = "delete from tb_teacher where idteacher = '" & TbId.Text & "'"
            executenonquery(q)
            Kosongkan()
        ElseIf r = vbNo Then
            Kosongkan()
        End If
    End Sub
    Sub Tambahkan()
        q = "select * from tb_teacher where idteacher = '" & TbId.Text & "'"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_teacher set name= '" & TbName.Text & "',gender = '" & TbGender.Text & "', nohp = '" & TbPhone.Text & "', photo = '" & TbPhoto.Text & "' where idteacher = '" & TbId.Text & "'"
            MsgBox(q)
            executenonquery(q)
            Kosongkan()
        Else
            q = "insert into tb_teacher(idteacher,name,gender,nohp,photo) values('" & TbId.Text & "','" & TbName.Text & "','" & TbGender.Text & "','" & TbPhone.Text & "','" & TbPhoto.Text & "')  "
            executenonquery(q)
            Kosongkan()

        End If
    End Sub
    Private Sub AdminManageTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Kosongkan()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp"
            .FilterIndex = 1
            .Title = "Pilih Gambar"
        End With

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TbPhoto.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        If TbName.Text = "" Or TbGender.Text = "" Or TbPhone.Text = "" Or TbPhoto.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Critical)

        Else
            Try
                Tambahkan()
                Kosongkan()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub


    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        Try
            TbId.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            TbName.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            TbGender.Text = DGV.Rows(e.RowIndex).Cells(2).Value

            TbPhone.Text = DGV.Rows(e.RowIndex).Cells(4).Value
            TbPhoto.Text = DGV.Rows(e.RowIndex).Cells(3).Value
            TbName.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Hapuskan()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Kosongkan()
    End Sub
End Class