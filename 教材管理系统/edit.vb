Imports System.Data.SqlClient

Public Class edit
    Dim book As New book_class
    Dim sy As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=DB_book_manage;Integrated Security=True")  '数据库设置
    Dim id As New Integer
    Public Function book_rows(book As book_class)
        Me.book = book
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sy.Close()
        Me.Close()

    End Sub

    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sy.Open()   '数据库连接
        TextBox1.Text = book.ISBN
        TextBox2.Text = book.name
        TextBox3.Text = book.author
        TextBox4.Text = book.press
        TextBox5.Text = book.price
        TextBox6.Text = book.duplicate
        TextBox7.Text = book.repertory
        Label9.Text = book.id
        id = book.id
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alter_book As New book_class
        alter_book.ISBN = TextBox1.Text.Trim
        alter_book.name = TextBox2.Text.Trim
        alter_book.author = TextBox3.Text.Trim
        alter_book.press = TextBox4.Text.Trim
        alter_book.price = Val(TextBox5.Text.Trim)
        alter_book.duplicate = Val(TextBox6.Text.Trim)
        alter_book.repertory = Val(TextBox7.Text.Trim)
        '  MsgBox("update BOOK set ISBN='" + alter_book.ISBN + "',
        ' 书名 ='" + alter_book.name + "',
        '作者 ='" + alter_book.author + "',
        '出版社 ='" + alter_book.press + "',
        '价格 ='" + alter_book.price.ToString + "',
        '复本量 ='" + alter_book.duplicate.ToString + "',
        '库存量 ='" + alter_book.repertory.ToString + "' where 
        'id =" + id.ToString)
        Dim alter As New SqlCommand("update BOOK set ISBN='" + alter_book.ISBN + "',
                                                        书名 ='" + alter_book.name + "',
                                                        作者 ='" + alter_book.author + "',
                                                        出版社 ='" + alter_book.press + "',
                                                        价格 ='" + alter_book.price.ToString + "',
                                                        复本量 ='" + alter_book.duplicate.ToString + "',
                                                        库存量 ='" + alter_book.repertory.ToString + "' where 
                                                        id = " + id.ToString, sy)      '根据用户名查询密码
        Dim alter_result As Integer = alter.ExecuteNonQuery '执行查询命名
        If (alter_result = 1) Then
            sy.Close()
            Me.Close()
        End If
    End Sub
    Private Sub check()

    End Sub

End Class