Imports System.Data.SqlClient

Public Class msg_out
    Dim sy As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=DB_book_manage;Integrated Security=True")  '数据库设置
    Private Sub msg_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“DB_book_manageDataSet4.BOOK”中。您可以根据需要移动或删除它。
        Me.BOOKTableAdapter.Fill(Me.DB_book_manageDataSet4.BOOK)
        sy.Open()   '数据库连接
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ''''单元格点击事件
        If (e.ColumnIndex = 8) Then '操作列事件
            'MsgBox（"行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; 被点击了"）
            Dim delete As New SqlCommand("delete from book where id=" + DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString, sy)      '根据用户名查询密码
            Dim delete_result As Integer = delete.ExecuteNonQuery '执行查询命名
            If (delete_result = 1) Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'TODO: 这行代码将数据加载到表“DB_book_manageDataSet4.BOOK”中。您可以根据需要移动或删除它。
        Me.BOOKTableAdapter.Fill(Me.DB_book_manageDataSet4.BOOK)
    End Sub
End Class