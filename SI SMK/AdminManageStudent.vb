Public Class AdminManageStudent
    Sub AutoId()
        q = "select * from tb_student order by idstudent desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "STD" + Format(Microsoft.VisualBasic.Right(dr.Item("idstudent"), 6) + 1, "000000")
        Else
            TbId.Text = "STD000001"
        End If
    End Sub
    Sub Tampilkan()
        q = "select * from tb_class order by idclass asc"
        cmd = New SqlClient.SqlCommand(q, conn)
        dr = cmd.ExecuteReader
        CbKelas.Items.Clear()
        While dr.Read
            CbKelas.Items.Add(dr.Item("idclass") + "-" + dr.Item("name"))
        End While
        q = "select * from tb_student"
        tampil(q)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub Kosongkan()
        AutoId()
        Tampilkan()
        TbName.Clear()
        TbGender.ResetText()
        TbAddress.Clear()
        TbPhone.Clear()
        DTPBirth.ResetText()
        TbPhoto.Clear()
        CbKelas.ResetText()
        TbName.Focus()
    End Sub
    Sub Hapuskan()
        Dim r As String
        r = MsgBox("Yakin Hapus ?????", vbYesNo)
        If r = vbYes Then
            q = "delete from tb_student where idstudent = '" & TbId.Text & "'"
            executenonquery(q)
        ElseIf r = vbNo Then
            Kosongkan()

        End If
    End Sub
    Sub Tambahkan()
        q = "select * from tb_student where idstudent = '" & TbId.Text & "'"
        Cari(q)
        Dim st As String = CbKelas.Text
        Dim idkelas As String
        If Not CbKelas.Text = "" Then
            idkelas = st.Substring(0, 6)
        End If

        If dr.HasRows Then
            q = "update tb_student set name= '" & TbName.Text & "', address = '" & TbAddress.Text & "',gender = '" & TbGender.Text & "',dateofbirth = '" & Format(DTPBirth.Value, "yyyy-MM-dd") & "',idclass = '" & idkelas & "' ,nohp = '" & TbPhone.Text & "', photo = '" & TbPhoto.Text & "' where idstudent = '" & TbId.Text & "'"
            'MsgBox(q)
            executenonquery(q)
            Kosongkan()
        Else
            q = "insert into tb_student(idstudent,name,address,gender,dateofbirth,nohp,photo,idclass) values('" & TbId.Text & "','" & TbName.Text & "','" & TbAddress.Text & "','" & TbGender.Text & "','" & Format(DTPBirth.Value, "yyyy-MM-dd") & "','" & TbPhone.Text & "','" & TbPhoto.Text & "','" & idkelas & "')  "
            executenonquery(q)
            Kosongkan()
        End If
    End Sub
    Private Sub AdminManageStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Tampilkan()
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


    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Kosongkan()
    End Sub

    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick

        Try
            TbId.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            TbName.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            TbAddress.Text = DGV.Rows(e.RowIndex).Cells(2).Value
            TbGender.Text = DGV.Rows(e.RowIndex).Cells(3).Value
            DTPBirth.Text = DGV.Rows(e.RowIndex).Cells(4).Value
            TbPhone.Text = DGV.Rows(e.RowIndex).Cells(5).Value
            TbPhoto.Text = DGV.Rows(e.RowIndex).Cells(6).Value
            Dim cbkelaskan As String
            cbkelaskan = DGV.Rows(e.RowIndex).Cells(7).Value
            MsgBox(cbkelaskan)
            q = "select * from tb_class where idclass = '" & cbkelaskan & "'"
            cmd = New SqlClient.SqlCommand(q, conn)
            dr = cmd.ExecuteReader
            CbKelas.Items.Clear()
            While dr.Read
                CbKelas.Text = dr.Item("idclass") + "-" + dr.Item("name")
            End While
            Tampilkan()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDelete_Click_1(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Hapuskan()
        Kosongkan()
    End Sub

    Private Sub BtnInput_Click_1(sender As Object, e As EventArgs) Handles BtnInput.Click
        If TbName.Text = "" Or TbAddress.Text = "" Or TbGender.Text = "" Or TbPhone.Text = "" Or TbPhoto.Text = "" Then
            MsgBox("Data Belum Lengkap ", MsgBoxStyle.Critical)
        Else

            Tambahkan()
        End If
    End Sub

    Private Sub BtnCancel_Click_1(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Kosongkan()
    End Sub

    Private Sub CbKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbKelas.SelectedIndexChanged

    End Sub
End Class