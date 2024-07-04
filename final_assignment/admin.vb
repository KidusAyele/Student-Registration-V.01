Imports System.Data.SqlClient
Public Class admin
    Public low As Integer = 0
    Public law As Integer = 0
    Dim test As String
    Dim reader As SqlDataReader
    Dim reader1 As SqlDataReader
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then

            If ComboBox1.Text <> "" Then




                Dim cnn1 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")

                Dim cmd1 As New SqlCommand

                Try
                    cnn1.Open()
                    If cnn1.State = ConnectionState.Open Then
                    End If
                Catch ex As Exception
                    MsgBox("Not Connected!!")
                End Try

                cmd1.Connection = cnn1

                cmd1.CommandType = CommandType.Text
                cmd1.CommandText = "Insert into UsersT(username,password,usertype,blockstate) Values (@parm1,@parm2,@parm3,@parm4)"
                cmd1.Parameters.AddWithValue("@parm1", TextBox1.Text)
                cmd1.Parameters.AddWithValue("@parm2", TextBox2.Text)
                Dim i As Integer = 0
                Dim user1 As New passwordv
                user1.myPassword = TextBox2.Text
                cmd1.Parameters.AddWithValue("@parm3", ComboBox1.Text)
                If RadioButton1.Checked Then
                    cmd1.Parameters.AddWithValue("@parm4", "active")
                ElseIf RadioButton2.Checked Then
                    cmd1.Parameters.AddWithValue("@parm4", "pending")
                End If
                If low = 0 Then
                    '   Try
                    cmd1.ExecuteNonQuery()
                        MsgBox("you registerd")
                        low = 0
                    ' Catch ex As Exception
                    'MsgBox("you try same username")
                    'End Try
                Else
                    MsgBox("you must try")
                    low = 0
                End If

                cnn1.Close()
                cmd1.Dispose()

            Else
                MsgBox(" you must select ")
            End If

        Else
            MsgBox(" cannot be empty")
        End If

    End Sub

    Private Sub admin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        login.Show()
    End Sub

    Private Sub admin_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd2 As New SqlCommand

        Dim cnn2 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")

        Try
            cnn2.Open()

        Catch ex As Exception
            MsgBox("Message failed")
        End Try
        cmd2.Connection = cnn2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "Select username,password,usertype,blockstate from UsersT "
        reader = cmd2.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                ComboBox3.Items.Add(reader.Item(0).ToString)
                ComboBox4.Items.Add(reader.Item(0).ToString)
            End While

        End If
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0

        cmd2.Dispose()
        cnn2.Close()

        Dim cnn4 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")

        Try
            cnn4.Open()

        Catch ex As Exception
            MsgBox("Message failed")
        End Try

        Dim cmd3 As New SqlCommand
        cmd3.Connection = cnn4
        cmd3.CommandType = CommandType.Text
        cmd3.CommandText = "Select  username  from UsersT where username <> 'agarbekele' "
        reader1 = cmd3.ExecuteReader
        If reader1.HasRows Then
            While reader1.Read
                ComboBox5.Items.Add(reader1.Item(0).ToString)
            End While

        End If
    
        ComboBox5.SelectedIndex = 0

        cmd3.Dispose()
        cnn4.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox4.Text <> "" And TextBox3.Text <> "" Then


            Dim i As Integer = 0
            Dim cnn2 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")

            Try
                cnn2.Open()

            Catch ex As Exception
                MsgBox("Message failed")
            End Try
            Dim cmd3 As New SqlCommand
            cmd3.Connection = cnn2
            cmd3.CommandType = CommandType.Text
            cmd3.CommandText = "UPDATE UsersT SET username=@parm1,password=@parm3 ,usertype=@parm4,blockstate=@parm5 where username like @parm2"
            cmd3.Parameters.AddWithValue("@parm1", TextBox4.Text)
            cmd3.Parameters.AddWithValue("@parm2", ComboBox3.SelectedItem.ToString)
            cmd3.Parameters.AddWithValue("@parm3", TextBox3.Text)
            Dim user1 As New passwordv
            user1.myPassword = TextBox3.Text
            cmd3.Parameters.AddWithValue("@parm4", ComboBox2.Text)
            If RadioButton3.Checked Then
                cmd3.Parameters.AddWithValue("@parm5", "active")
            ElseIf RadioButton4.Checked Then
                cmd3.Parameters.AddWithValue("@parm5", "pending")
            End If

            If law = 0 Then
                Try
                    i = cmd3.ExecuteNonQuery()
                    MsgBox(i.ToString & "Rows are Updated")
                    law = 0
                Catch ex As Exception
                    MsgBox("Message failed")
                End Try
            Else
                MsgBox("you must try")
                law = 0
            End If

            cmd3.Dispose()
            cnn2.Close()
        Else
            MsgBox("filled cannot be empty")

        End If


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer = 0
        Dim cnn2 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")

        Try
            cnn2.Open()

        Catch ex As Exception
            MsgBox("Message failed")
        End Try
        If ComboBox4.Text <> "" Then


            Dim cmd3 As New SqlCommand
            cmd3.Connection = cnn2
            cmd3.CommandType = CommandType.Text
            cmd3.CommandText = "UPDATE  UsersT SET blockstate=@parm4 where Username like @parm2"
            cmd3.Parameters.AddWithValue("@parm2", ComboBox4.SelectedItem.ToString)
            If RadioButton5.Checked Then
                cmd3.Parameters.AddWithValue("@parm4", "active")
            ElseIf RadioButton6.Checked Then
                cmd3.Parameters.AddWithValue("@parm4", "pending")
            End If
            Try
                i = cmd3.ExecuteNonQuery()
                MsgBox(i.ToString & "Rows are Updated")
            Catch ex As Exception
                MsgBox("Message failed")
            End Try

            cmd3.Dispose()
            cnn2.Close()
        Else
            MsgBox("you must select")

        End If


    End Sub

    Private Sub ComboBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox5.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True

        End If
        
        Dim i As Integer
        For i = 0 To ComboBox1.Items.Count - 1
            'required code
            e.Handled = True
        Next i

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim i As Integer = 0
        Dim cnn2 As New SqlConnection("server=localhost;data source=DDESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")

        Try
            cnn2.Open()

        Catch ex As Exception
            MsgBox("Message failed")
        End Try
        If ComboBox5.Text <> "" Then


            Dim cmd3 As New SqlCommand
            cmd3.Connection = cnn2
            cmd3.CommandType = CommandType.Text
            cmd3.CommandText = "Delete  from UsersT  where username like @parm2"
            cmd3.Parameters.AddWithValue("@parm2", ComboBox5.SelectedItem.ToString)
            i = cmd3.ExecuteNonQuery()
            MsgBox(i.ToString & "Rows are deleted")
            cmd3.Dispose()
            cnn2.Close()
        Else
            MsgBox("you must select")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Manage_users.Show()

        Me.Hide()



    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Manage_users.Show()

        Me.Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Manage_users.Show()

        Me.Hide()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Manage_users.Show()

        Me.Hide()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True

        End If
        Dim i As Integer
        For i = 0 To ComboBox1.Items.Count - 1
            'required code
            e.Handled = True
        Next i
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
        Dim i As Integer
        For i = 0 To ComboBox1.Items.Count - 1
            'required code
            e.Handled = True
        Next i
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
        Dim i As Integer
        For i = 0 To ComboBox1.Items.Count - 1
            'required code
            e.Handled = True
        Next i
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = False
        End If
        Dim i As Integer
        For i = 0 To ComboBox1.Items.Count - 1
            'required code
            e.Handled = True
        Next i
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button1_Enter(sender As Object, e As EventArgs) Handles Button1.Enter

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub
End Class