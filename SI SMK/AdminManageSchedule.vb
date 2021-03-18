
Public Class AdminManageSchedule

    Sub AutoId()
        q = "select * from tb_headerschedule order by idschedule desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "SCH" + Format(Microsoft.VisualBasic.Right(dr.Item("idschedule"), 6) + 1, "000000")
        Else
            TbId.Text = "SCH000001"
        End If
    End Sub
    Sub Tampilkan()
        q = "select * from AdminManageSchedule"
        tampil(q)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        DTPDay.Format = DateTimePickerFormat.Custom
        DTPDay.CustomFormat = "dd MMM yyyy hh:mm"
        q = "select * from tb_subject order by idsubject asc"
        cmd = New SqlClient.SqlCommand(q, conn)
        dr = cmd.ExecuteReader
        CbSubject.Items.Clear()
        While dr.Read
            CbSubject.Items.Add(dr.Item("name"))
        End While
        q = "select * from tb_class order by idclass asc"
        cmd = New SqlClient.SqlCommand(q, conn)
        dr = cmd.ExecuteReader
        CbClass.Items.Clear()
        While dr.Read
            CbClass.Items.Add(dr.Item("name"))
        End While
        q = "select * from tb_teacher order by idteacher asc"
        cmd = New SqlClient.SqlCommand(q, conn)
        dr = cmd.ExecuteReader
        Cbteacher.Items.Clear()
        While dr.Read
            Cbteacher.Items.Add(dr.Item("name"))
        End While
    End Sub
    Sub Kosongkan()
        TbTeacher.Clear()
        Cbteacher.ResetText()
        TbSubject.Clear()
        CbSubject.ResetText()
        TbClass.Clear()
        CbClass.ResetText()
        AutoId()
        Tampilkan()
        DTPDay.ResetText()
        CbSubject.Focus()

    End Sub
    Sub Tambahkan()
        q = "select * from tb_headerschedule where idschedule = '" & TbId.Text & "'"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_headerschedule set idsubject ='" & TbSubject.Text & "',idteacher = '" & TbTeacher.Text & "',idclass = '" & TbClass.Text & "',day = '" & Format(DTPDay.Value, "dd MM yyyy hh:mm") & "' where idschedule = '" & TbId.Text & "' "
            MsgBox(q)
            'executenonquery(q)
            Kosongkan()
        Else
            q = "insert into tb_headerschedule values('" & TbId.Text & "','" & TbSubject.Text & "','" & TbTeacher.Text & "','" & TbClass.Text & "','" & Format(DTPDay.Value, "dd MMM yyyy hh:mm") & "')  "
            'MsgBox(q)
            executenonquery(q)
            Kosongkan()
        End If
    End Sub


    Private Sub AdminManageSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Kosongkan()
    End Sub



    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        Try
            TbId.Text = DGV.Rows(e.RowIndex).Cells(0).Value
            Cbteacher.Text = DGV.Rows(e.RowIndex).Cells(3).Value
            CbSubject.Text = DGV.Rows(e.RowIndex).Cells(1).Value
            CbClass.Text = DGV.Rows(e.RowIndex).Cells(4).Value
            DTPDay.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        If Not CbSubject.Text = "" Or TbTeacher.Text = "" Or TbClass.Text = "" Or TbId.Text = "" Then
            Tambahkan()
            Kosongkan()
        Else
            MsgBox("Data Belum Lengkap")
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim r As String
        r = MsgBox("Yakin Hapus???", vbYesNo)
        If r = vbYes Then
            q = "delete from tb_headerschedule where idschedule='" & TbId.Text & "' "
            executenonquery(q)
            Kosongkan()
        ElseIf r = vbNo Then
            Kosongkan()
        End If
    End Sub

    Private Sub TbClass_TextChanged(sender As Object, e As EventArgs) Handles TbClass.TextChanged
        Try
            q = "select * from tb_class where idclass = '" & TbClass.Text & " '"
            Cari(q)
            If dr.HasRows Then
                CbClass.Text = dr.Item("name")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TbTeacher_TextChanged(sender As Object, e As EventArgs) Handles TbTeacher.TextChanged
        Try
            q = "select * from tb_teacher where idteacher = '" & TbTeacher.Text & " '"
            Cari(q)
            If dr.HasRows Then
                Cbteacher.Text = dr.Item("name")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cbteacher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbteacher.SelectedIndexChanged
        Try
            q = "select * from tb_teacher where name = '" & Cbteacher.Text & " '"
            Cari(q)
            If dr.HasRows Then
                TbTeacher.Text = dr.Item("idteacher")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbClass.SelectedIndexChanged
        Try
            q = "select * from tb_class where name = '" & CbClass.Text & " '"
            Cari(q)
            If dr.HasRows Then
                TbClass.Text = dr.Item("idclass")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Kosongkan()
    End Sub

    Private Sub CbSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbSubject.SelectedIndexChanged
        Try
            q = "select * from tb_subject where name = '" & CbSubject.Text & " '"
            Cari(q)
            If dr.HasRows Then
                TbSubject.Text = dr.Item("idsubject")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TbSubject_TextChanged(sender As Object, e As EventArgs) Handles TbSubject.TextChanged
        Try
            q = "select * from tb_subject where idsubject = '" & TbSubject.Text & " '"
            Cari(q)
            If dr.HasRows Then
                CbSubject.Text = dr.Item("name")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class