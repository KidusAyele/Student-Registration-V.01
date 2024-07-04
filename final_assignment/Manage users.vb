Public Class Manage_users

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Manage_users_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        login.Show()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        admin.Show()
        admin.GroupBox3.Enabled = False
        admin.GroupBox4.Enabled = False
        admin.GroupBox5.Enabled = False
        admin.GroupBox1.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        admin.Show()
        admin.GroupBox1.Enabled = False
        admin.GroupBox4.Enabled = False
        admin.GroupBox5.Enabled = False
        admin.GroupBox3.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        admin.Show()
       
        admin.GroupBox3.Enabled = False
        admin.GroupBox1.Enabled = False
        admin.GroupBox5.Enabled = False
        admin.GroupBox4.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        admin.Show()
       
        admin.GroupBox3.Enabled = False
        admin.GroupBox4.Enabled = False
        admin.GroupBox1.Enabled = False
        admin.GroupBox5.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        view_users.Show()
        Me.Hide()

    End Sub
End Class