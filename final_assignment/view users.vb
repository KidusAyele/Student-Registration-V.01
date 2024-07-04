Imports System.Data.SqlClient
Public Class view_users

    Private Sub CmdView_Click(sender As Object, e As EventArgs) Handles CmdView.Click
        ViewData()
    End Sub
    Private Sub ViewData()
        Dim cnn2 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")
        Dim ViewQuery As String = "Select * from UsersT"
        Dim cmd As New SqlCommand(ViewQuery, cnn2)
        Dim DataAda As New SqlDataAdapter
        DataAda.SelectCommand = cmd
        Dim DataTab As New DataTable()
        DataAda.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub

    Private Sub view_users_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        login.Show()
        Me.Hide()
    End Sub

    Private Sub view_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Manage_users.Show()
        Me.Hide()

    End Sub
End Class