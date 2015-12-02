Public Class msg_in
    Private Sub msg_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“DB_book_manageDataSet3.BOOK”中。您可以根据需要移动或删除它。
        Me.BOOKTableAdapter.Fill(Me.DB_book_manageDataSet3.BOOK)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        add.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TODO: 这行代码将数据加载到表“DB_book_manageDataSet3.BOOK”中。您可以根据需要移动或删除它。
        Me.BOOKTableAdapter.Fill(Me.DB_book_manageDataSet3.BOOK)
    End Sub
End Class