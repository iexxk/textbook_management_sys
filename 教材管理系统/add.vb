Imports System.Data.SqlClient

Public Class add
    Dim sy As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=DB_book_manage;Integrated Security=True")  '数据库设置
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sy.Close()
        Me.Close()

    End Sub

    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sy.Open()   '数据库连接
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (check()) Then
            Dim add_book As New book_class
            add_book.ISBN = TextBox1.Text.Trim
            add_book.name = TextBox2.Text.Trim
            add_book.author = TextBox3.Text.Trim
            add_book.press = TextBox4.Text.Trim
            add_book.price = Val(TextBox5.Text.Trim)
            add_book.duplicate = Val(TextBox6.Text.Trim)
            add_book.repertory = Val(TextBox7.Text.Trim)
            '  MsgBox("update BOOK set ISBN='" + add_book.ISBN + "',
            ' 书名 ='" + add_book.name + "',
            '作者 ='" + add_book.author + "',
            '出版社 ='" + add_book.press + "',
            '价格 ='" + add_book.price.ToString + "',
            '复本量 ='" + add_book.duplicate.ToString + "',
            '库存量 ='" + add_book.repertory.ToString + "' where 
            'id =" + id.ToString)
            Dim add As New SqlCommand("insert into BOOK (ISBN,书名,作者,出版社,价格,复本量,库存量) values('" + add_book.ISBN + "','" + add_book.name + "','" + add_book.author + "','" + add_book.press + "','" + add_book.price.ToString + "','" + add_book.duplicate.ToString + "','" + add_book.repertory.ToString + "')", sy)      '根据用户名查询密码
            Dim add_result As Integer = add.ExecuteNonQuery '执行查询命名
            If (add_result = 1) Then
                sy.Close()
                Me.Close()
            End If
        End If
    End Sub
    Private Function check() As Boolean
        If (TextBox1.Text.Trim = "") Then
            MsgBox("ISBN输入为空")
            Return False
        ElseIf (TextBox2.Text.Trim = "")
            MsgBox("书名输入为空")
            Return False
        ElseIf (TextBox3.Text.Trim = "")
            MsgBox("作者输入为空")
            Return False
        ElseIf (TextBox4.Text.Trim = "")
            MsgBox("出版社输入为空")
            Return False
        ElseIf (TextBox5.Text.Trim = "")
            MsgBox("价格输入为空")
            Return False
        ElseIf (TextBox6.Text.Trim = "")
            MsgBox("复本量输入为空")
            Return False
        ElseIf (TextBox7.Text.Trim = "")
            MsgBox("库存量输入为空")
            Return False
        ElseIf (Not IsNumeric(TextBox5.Text.Trim))
            MsgBox("价格应为数字")
            Return False
        ElseIf (Not IsNumeric(TextBox6.Text.Trim))
            MsgBox("复本量应为数字")
            Return False
        ElseIf (Not IsNumeric(TextBox7.Text.Trim))
            MsgBox("库存量应为数字")
            Return False
        End If
        Return True
    End Function

    Private Sub add_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        sy.Close()
    End Sub
End Class