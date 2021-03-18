Public Class STudentSchedule
    Sub kosongkan()
        q = "select * from tb_headerschedule where idclass = '" & studentclass & "'"
        tampil(q)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub STudentSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        kosongkan()
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
End Class