Imports System.Data.SqlClient

Public Class Form1
    Dim msg_search As msg_search
    Dim msg_in As msg_in
    Dim msg_out As msg_out
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.ShowDialog()  '加载登陆窗口
        msg_search = New msg_search
        msg_search.MdiParent = Me
        msg_search.SetBounds(0, -MenuStrip1.Height, Me.Width, Me.Height)
        msg_in = New msg_in
        msg_in.MdiParent = Me
        msg_in.SetBounds(0, -MenuStrip1.Height, Me.Width, Me.Height)
        msg_out = New msg_out
        msg_out.MdiParent = Me
        msg_out.SetBounds(0, -MenuStrip1.Height, Me.Width, Me.Height)
        msg_search.Show()
    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If (IsNothing(msg_out)) Then
        Else
            msg_out.Hide()
        End If
        If (IsNothing(msg_in)) Then
        Else
            msg_in.Hide()
        End If

        msg_search.Show()



    End Sub

    Private Sub 入库管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 入库管理ToolStripMenuItem.Click
        If (IsNothing(msg_out)) Then
        Else
            msg_out.Hide()
        End If
        If (IsNothing(msg_search)) Then
        Else
            msg_search.Hide()
        End If

        msg_in.Show()


    End Sub

    Private Sub 出库管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 出库管理ToolStripMenuItem.Click
        If (IsNothing(msg_search)) Then
        Else
            msg_search.Hide()
        End If
        If (IsNothing(msg_in)) Then
        Else
            msg_in.Hide()
        End If

        msg_out.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        '注册
        sigin.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        '退出
        Me.Hide()
        login.ShowDialog()

    End Sub
End Class
