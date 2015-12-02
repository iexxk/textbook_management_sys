Imports System.Data.SqlClient

Public Class msg_search
    Dim book As New book_class
    Dim sy As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=DB_book_manage;Integrated Security=True")  '数据库设置
    Dim read_flag As Boolean = True


    Private Sub msg_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“DB_book_manageDataSet2.BOOK”中。您可以根据需要移动或删除它。
        Me.BOOKTableAdapter1.Fill(Me.DB_book_manageDataSet2.BOOK)
        sy.Open()   '数据库连接
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''''根据书名或作者查询
        Dim book_name, author As String
        book_name = TextBox1.Text
        author = TextBox3.Text
        Dim name_search As New SqlDataAdapter("select * from BOOK where 书名 like '%" + book_name.Trim + "%' and 作者 like '%" + author.Trim + "%'", sy)      '根据书名和作者查询
        Dim dataset As New DataSet
        name_search.Fill(dataset, "name")
        DataGridView1.DataSource = dataset.Tables("name")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''''模糊查询
        Dim mainkey As String = TextBox2.Text.Trim
        Dim mainkey_search As New SqlDataAdapter("select * from BOOK where ISBN like '%" + mainkey + "%' or 书名 like '%" + mainkey + "%' or 作者 like '%" + mainkey + "%' or 出版社 like '%" + mainkey + "%' or 价格 like '%" + mainkey + "%' or 复本量 like '%" + mainkey + "%' or 库存量 like '%" + mainkey + "%'
", sy)      '根据关键字查询
        Dim dataset As New DataSet
        mainkey_search.Fill(dataset, "key")
        DataGridView1.DataSource = dataset.Tables("key")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ''''单元格点击事件
        If (e.ColumnIndex = 8) Then '操作列事件
            'MsgBox（"行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; 被点击了"）
            book.set_book(DataGridView1.Rows(e.RowIndex).Cells(0).Value,
                          DataGridView1.Rows(e.RowIndex).Cells(1).Value,
                          DataGridView1.Rows(e.RowIndex).Cells(2).Value,
                          DataGridView1.Rows(e.RowIndex).Cells(3).Value,
                          DataGridView1.Rows(e.RowIndex).Cells(4).Value,
                          DataGridView1.Rows(e.RowIndex).Cells(5).Value,
                          DataGridView1.Rows(e.RowIndex).Cells(6).Value,
                          DataGridView1.Rows(e.RowIndex).Cells(7).Value)
            edit.book_rows(book) '向子窗口edit传值
            edit.StartPosition = StartPosition.CenterParent '设置在父布局中居中
            edit.ShowDialog()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'TODO: 这行代码将数据加载到表“DB_book_manageDataSet2.BOOK”中。您可以根据需要移动或删除它。
        Me.BOOKTableAdapter1.Fill(Me.DB_book_manageDataSet2.BOOK)
    End Sub
End Class