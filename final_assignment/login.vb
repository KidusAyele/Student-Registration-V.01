Imports System.Data.SqlClient
Public Class login


    Dim usertype As String
    Dim test As String
    Dim control As Integer = 1
    Dim cnn As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")
    ' Dim cnn As New SqlConnection("Data Source = DESKTOP-E7LNEBH\dell;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False")
    '  Dim connectionString As String = "Data Source=DESKTOP-E7LNEBH\dell;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;Connect Timeout=30;"
    ' Dim cnn As New SqlConnection(connectionString)


    Function getform(ByVal usertype As String)
        If test <> "pending" Then

            Select Case usertype
                Case "admin"
                    Manage_users.Show()
                    Me.TextBox2.Text = ""
                    Me.Hide()

                Case "user1"
                    userstable.Show()

                    userstable.GroupBox1.Enabled = False
                    userstable.GroupBox2.Enabled = False
                    Me.TextBox2.Text = ""

                    Me.Hide()
                Case "user2"
                    userstable.Show()
                    userstable.GroupBox2.Enabled = False
                    Me.TextBox2.Text = ""
                    Me.Hide()
                    'user3.Button3.Enabled = False
                Case "user3"
                    userstable.Show()
                    Me.TextBox2.Text = ""
                    Me.Hide()
                Case "student"
                    student.Show()
                    Me.TextBox2.Text = ""
                    Me.Hide()
                Case Else
                    MsgBox("you was not fulfill the information from you exepected")
            End Select

        Else
            MsgBox("you are blocked by admin")
        End If
        Return True
    End Function

   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub login_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress2(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress2(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Ctrl_KeyUp(sender As Object, e As KeyEventArgs) Handles Button2.KeyUp, TextBox2.KeyUp, TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub TextBox1_KeyPress1(sender As Object, e As KeyPressEventArgs)
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyUp1(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_KeyPress1(sender As Object, e As KeyPressEventArgs)
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_3(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim reader As SqlDataReader
        Dim cmd1 As New SqlCommand
        cmd1.Connection = cnn
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "select username,password,usertype,blockstate from UsersT where username like '" & TextBox1.Text & "' and password like '" & TextBox2.Text & "'"
        reader = cmd1.ExecuteReader
        Dim control As Integer = 0
        If reader.HasRows Then
            While reader.Read
                If reader.Item("username").ToString = TextBox1.Text And reader.Item("password").ToString = TextBox2.Text Then

                    test = reader.Item("blockstate").ToString
                    usertype = reader.Item("usertype").ToString
                    getform(usertype)
                    control = 1


                    Exit While
                End If
            End While
        Else
            control = 0
            MsgBox("Wrong username and password")
        End If
        cmd1.Dispose()
        cnn.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = False Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
