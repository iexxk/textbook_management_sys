Imports System.Data.SqlClient

Public Class sigin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user_name As String, user_password As String, e_mail As String, user_password2 As String
        user_name = TextBox1.Text
        user_password = TextBox2.Text
        user_password2 = TextBox3.Text
        e_mail = TextBox4.Text
        Dim sigin_msg As String
        sigin_msg = sigin(user_name, user_password, user_password2, e_mail)
        If (sigin_msg.Equals("true")) Then
            MsgBox("注册成功，请重新登陆")
            Me.Close()
        Else
            MsgBox(sigin_msg)
        End If


    End Sub
    Private Function sigin(user_name As String, password As String, password2 As String, email As String) As String
        If (user_name = "") Then
            Return "用户名错误"
        ElseIf (password = "")
            Return "密码输入为空"
        ElseIf (Not password.Equals(password2))
            Return "密码输入不一致"
        ElseIf (email = "")
            Return "邮箱输入有误"
        Else
            '添加user用户名检查重复
            Dim sy As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=DB_book_manage;Integrated Security=True")  '数据库设置
            sy.Open()   '数据库连接
            Dim name_search As New SqlCommand("select user_name from tb_user where user_name='" + user_name + "'", sy)      '根据用户名查询用户
            Dim email_search As New SqlCommand("select user_name from tb_user where user_email='" + email + "'", sy)      '根据邮箱查询用户
            Dim name_object As Object = name_search.ExecuteScalar() '执行查询命名
            Dim email_object As Object = email_search.ExecuteScalar() '执行查询命名

            If (Not IsNothing(name_object)) Then '判断查询结果是否为空
                Return "该" + name_object.ToString.TrimEnd() + "用户名被注册"
            ElseIf (Not IsNothing(email_object))
                Return "该邮箱已被" + email_object.ToString.TrimEnd() + "用户注册"
            Else
                Dim add_user As New SqlCommand("insert into tb_user (user_name,user_password,user_email) values('" + user_name + "','" + password + "','" + email + "')", sy)      '根据邮箱查询用户
                Dim num As Integer = add_user.ExecuteNonQuery
                If (num = 1) Then
                    '写入数据库
                    Return "true"
                Else
                    Return "写入数据错误"
                End If
            End If
        End If
    End Function
End Class