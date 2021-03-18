Public Class AdminManageClass
    Dim idclass As String
    Dim idstudent As String
    Sub TambahCb()
        q = "select * from tb_class"
        cmd = New SqlClient.SqlCommand(q, conn)
        dr = cmd.ExecuteReader
        CBclass.Items.Clear()

        While dr.Read
            CBclass.Items.Add(dr.Item("idclass") + "-" + dr.Item("name"))

        End While
    End Sub
    Sub Tampilkan()
        q = "select idstudent,name from tb_student"
        tampil(q)
        DGV1.DataSource = ds.Tables(0)
        q = "select idstudent,name from tb_student  where idclass = '" & idclass & "'"
        tampil(q)
        DGV2.DataSource = ds.Tables(0)
    End Sub
    Sub Kosongkan()
        TambahCb()
        Tampilkan()
    End Sub

    Private Sub AdminManageClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Kosongkan()

    End Sub

    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles BtnUp.Click
        q = "update tb_student set idclass ='" & idclass & "' where idstudent = '" & idstudent & "'"
        executenonquery(q)
        Kosongkan()
    End Sub



    Private Sub CBclass_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBclass.SelectedValueChanged
        Tampilkan()
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        BtnUp.Visible = True
        Btndown.Visible = True
        idstudent = DGV1.Rows(e.RowIndex).Cells(0).Value
    End Sub



    Private Sub DGV2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellContentClick
        BtnUp.Visible = True
        Btndown.Visible = True
        idstudent = DGV1.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub CBclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBclass.SelectedIndexChanged
        Dim st As String = CBclass.Text
        Dim sta As String = st.Substring(0, 6)
        MsgBox(sta)
        idclass = sta
        Tampilkan()
    End Sub
End Class