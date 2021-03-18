Public Class TeacherScheduleform
    Sub Tampilkan()
        q = "select * from tb_headerschedule where idteacher = '" & teacherid & "'"
        tampil(q)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub TeacherScheduleform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Tampilkan()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            Dim Subject As String
            Subject = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            q = "select * from tb_subject where idsubject= '" & Subject & "'"
            Cari(q)
            If dr.HasRows Then
                InfoSubject.LblSubject.Text = dr.Item("name")
                InfoSubject.LblDesc.Text = dr.Item("description")
                InfoSubject.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim classid As String
            classid = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            ' MsgBox(classid)
            q = "select * from tb_student where idclass = '" & classid & "'"
            tampil(q)
            DataGridView2.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub


End Class