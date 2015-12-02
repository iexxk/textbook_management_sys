Imports System.Data.SqlClient

Public Class login
    Dim close_button As Boolean = True
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim user As String, password As String
        user = TextBox1.Text
        password = TextBox2.Text

        If (login(user, password)) Then
            close_button = False
            Form1.Show()
            Me.Close()

        Else
            MsgBox("密码或用户名错误")
            'MsgBox("调试" + user + "," + password)
        End If

    End Sub

    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (close_button) Then
            End
        End If

    End Sub

    Private Function login(name As String, password As String) As Boolean
        Dim sy As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=DB_book_manage;Integrated Security=True")  '数据库设置
        sy.Open()   '数据库连接
        Dim password_search As New SqlCommand("select user_password from tb_user where user_name='" + name + "'", sy)      '根据用户名查询密码
        Dim password_object As Object = password_search.ExecuteScalar() '执行查询命名
        Dim password_string As String
        If (IsNothing(password_object)) Then '判断查询结果是否为空
            Return False
        Else
            password_string = password_object.ToString.TrimEnd()    '将不为空的密码结果转换为string并去除空格
            If (password_string.Equals(password)) Then      '判断数据库密码是否和输入密码相同
                Return True
            Else
                Return False
            End If
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sigin.ShowDialog()
    End Sub
End Class