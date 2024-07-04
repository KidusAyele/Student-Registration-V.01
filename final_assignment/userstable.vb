Imports System.Data.SqlClient
Public Class userstable
    Public flag As Integer
    'student attribute 
    Dim x As Integer = 0
    Dim j As Integer = 0
    Dim dep As String = Nothing
    Dim gen As Boolean = False
    Structure student
        'to view recorded students
        Dim name1 As String
        Dim name2 As String
        Dim id As String
    End Structure
    Dim che As Integer = 0
    Dim index As Integer = 0
    Dim ext As String = Nothing
    Dim studinfod(100) As student
    Structure studinfo
        Dim idtxt As String
        Dim idchar As Char
        Dim idnum As Integer
        Dim fname, lname As String
    End Structure
    Dim nameofstud As New studinfo
    Dim reader As SqlDataReader
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub idtext_Click(sender As Object, e As EventArgs) Handles idtext.Click

    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click

        nameofstud.fname = firstname.Text
        nameofstud.lname = lastname.Text
        If nameofstud.fname <> "" And nameofstud.lname <> "" Then
            If ext = "Regular" Then
                If che = 0 Then
                    che += 1
                    idtext.Text = dep + "/R/000" + che.ToString + "/2014"
                ElseIf che > 0 And che <= 9 Then

                    che += 1
                    If che = 10 Then
                        idtext.Text = dep + "/R/00" + che.ToString + "/2014"
                    Else
                        idtext.Text = dep + "/R/000" + che.ToString + "/2014"
                    End If


                ElseIf che >= 10 And che < 99 Then
                    che += 1
                    idtext.Text = dep + "/R/00" + che.ToString + "/2014"
                ElseIf che >= 99 And che < 999 Then
                    che += 1
                    idtext.Text = dep + "/R/0" + che.ToString + "/2014"
                End If
            ElseIf ext = "Weeknend" Then
                If che = 0 Then
                    che += 1
                    idtext.Text = dep + "/w/000" + che.ToString + "/2014"
                ElseIf che > 0 And che <= 9 Then

                    che += 1
                    If che = 10 Then
                        idtext.Text = dep + "/w/00" + che.ToString + "/2014"
                    Else
                        idtext.Text = dep + "/w/000" + che.ToString + "/2014"
                    End If


                ElseIf che >= 10 And che < 99 Then
                    che += 1
                    idtext.Text = dep + "/w/00" + che.ToString + "/2014"
                ElseIf che >= 99 And che < 999 Then
                    che += 1
                    idtext.Text = dep + "/w/0" + che.ToString + "/2014"
                End If
            ElseIf ext = "Extension" Then
                If che = 0 Then
                    che += 1
                    idtext.Text = dep + "/E/000" + che.ToString + "/2014"
                ElseIf che > 0 And che <= 9 Then

                    che += 1
                    If che = 10 Then
                        idtext.Text = dep + "/E/00" + che.ToString + "/2014"
                    Else
                        idtext.Text = dep + "/E/000" + che.ToString + "/2014"
                    End If
                End If


            ElseIf che >= 10 And che < 99 Then
                che += 1
                idtext.Text = dep + "/E/00" + che.ToString + "/2014"
            ElseIf che >= 99 And che < 999 Then
                che += 1
                idtext.Text = dep + "/E/0" + che.ToString + "/2014"
               
            End If
            studinfod(index).name1 = nameofstud.fname
            studinfod(index).name2 = nameofstud.lname
            studinfod(index).id = idtext.Text
            index += 1

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
            cmd1.CommandText = "Insert into StudentT(Firstname,Lastname,ID,department) Values (@parm1,@parm2,@parm3,@parm4)"
            cmd1.Parameters.AddWithValue("@parm1", firstname.Text)
            cmd1.Parameters.AddWithValue("@parm2", lastname.Text)
            cmd1.Parameters.AddWithValue("@parm3", idtext.Text)
            cmd1.Parameters.AddWithValue("@parm4", dep)

            Try
                Dim i As Integer = 0
                i = cmd1.ExecuteNonQuery()
                gen = True
            Catch ex As Exception
                Dim i As Integer = 0
                GoToStatementDemo()
            End Try
         
        Else
            Empty()
        End If

       
    End Sub

    Private Function Empty()
        MsgBox("the filled cannot be empty")
        Return Nothing
    End Function

    Sub GoToStatementDemo()
        If gen = False And x = 0 Then GoTo Line1 Else GoTo Line2
Line1:
        nameofstud.fname = firstname.Text
        nameofstud.lname = lastname.Text
        If nameofstud.fname <> "" And nameofstud.lname <> "" Then
            If ext = "Regular" Then
                If che = 0 Then
                    che += 1
                    idtext.Text = dep + "/R/000" + che.ToString + "/2014"
                ElseIf che > 0 And che <= 9 Then

                    che += 1
                    If che = 10 Then
                        idtext.Text = dep + "/R/00" + che.ToString + "/2014"
                    Else
                        idtext.Text = dep + "/R/000" + che.ToString + "/2014"
                    End If


                ElseIf che >= 10 And che < 99 Then
                    che += 1
                    idtext.Text = dep + "/R/00" + che.ToString + "/2014"
                ElseIf che >= 99 And che < 999 Then
                    che += 1
                    idtext.Text = dep + "/R/0" + che.ToString + "/2014"
                End If
            ElseIf ext = "Weeknend" Then
                If che = 0 Then
                    che += 1
                    idtext.Text = dep + "/w/000" + che.ToString + "/2014"
                ElseIf che > 0 And che <= 9 Then

                    che += 1
                    If che = 10 Then
                        idtext.Text = dep + "/w/00" + che.ToString + "/2014"
                    Else
                        idtext.Text = dep + "/w/000" + che.ToString + "/2014"
                    End If


                ElseIf che >= 10 And che < 99 Then
                    che += 1
                    idtext.Text = dep + "/w/00" + che.ToString + "/2014"
                ElseIf che >= 99 And che < 999 Then
                    che += 1
                    idtext.Text = dep + "/w/0" + che.ToString + "/2014"
                End If
            ElseIf ext = "Extension" Then
                If che = 0 Then
                    che += 1
                    idtext.Text = dep + "/E/000" + che.ToString + "/2014"
                ElseIf che > 0 And che <= 9 Then

                    che += 1
                    If che = 10 Then
                        idtext.Text = dep + "/E/00" + che.ToString + "/2014"
                    Else
                        idtext.Text = dep + "/E/000" + che.ToString + "/2014"
                    End If
                End If


            ElseIf che >= 10 And che < 99 Then
                che += 1
                idtext.Text = dep + "/E/00" + che.ToString + "/2014"
            ElseIf che >= 99 And che < 999 Then
                che += 1
                idtext.Text = dep + "/E/0" + che.ToString + "/2014"
            End If
        End If
        Try
            studinfod(index).name1 = nameofstud.fname
            studinfod(index).name2 = nameofstud.lname
            studinfod(index).id = idtext.Text
            index += 1


        Catch ex As Exception
            MsgBox("not allow empty")
            Me.Hide()
            Me.Show()

        End Try


        Dim i As Integer = 0
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
        cmd1.CommandText = "Insert into StudentT(Firstname,Lastname,ID,department) Values (@parm1,@parm2,@parm3,@parm4)"
        cmd1.Parameters.AddWithValue("@parm1", firstname.Text)
        cmd1.Parameters.AddWithValue("@parm2", lastname.Text)
        cmd1.Parameters.AddWithValue("@parm3", idtext.Text)
        cmd1.Parameters.AddWithValue("@parm4", dep)

        Try
            i = cmd1.ExecuteNonQuery()
            gen = True
        Catch ex As Exception
            GoTo Line1
        End Try
Line2:
        ' The following statement never gets executed because number = 1.
        MsgBox("success ")
        x = 0
LastLine:

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        Dim i As Integer
        For i = 0 To ComboBox1.Items.Count - 1
            'required code
            e.Handled = True
        Next i
    End Sub

  

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        dep = ComboBox1.Text

        If ComboBox1.Text = "computer science" Then
            dep = "computer"
        ElseIf ComboBox1.Text = "accounting " Then
            dep = "acc"
        ElseIf ComboBox1.Text = "markating" Then
            dep = "mark"
        End If

    End Sub

    Private Sub r_CheckedChanged(sender As Object, e As EventArgs) Handles r.CheckedChanged
        r.Text = "Regular"
        ext = r.Text
    End Sub

    Private Sub ext1_CheckedChanged(sender As Object, e As EventArgs) Handles ext1.CheckedChanged
        w.Text = "Weeknend"
        ext = w.Text
    End Sub

    Private Sub w_CheckedChanged(sender As Object, e As EventArgs) Handles w.CheckedChanged
        ext1.Text = "Extension"
        ext = ext1.Text
    End Sub

    Private Sub userstable_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        login.Show()
    End Sub

    Private Sub userstable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd2 As New SqlCommand
        ComboBox1.Text = "cosc"
        Dim cnn2 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")

        Try
            cnn2.Open()

        Catch ex As Exception
            MsgBox("Message failed")
        End Try
        cmd2.Connection = cnn2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "Select ID, Firstname,Lastname,department from StudentT"
        reader = cmd2.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                ComboBox2.Items.Add(reader.Item(0).ToString)
            End While

        End If
        ' ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim cnn2 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then

            Try
                cnn2.Open()

            Catch ex As Exception
                MsgBox("Message failed")
            End Try
            Dim cmd3 As New SqlCommand
            cmd3.Connection = cnn2
            cmd3.CommandType = CommandType.Text
            cmd3.CommandText = "UPDATE StudentT SET Firstname=@parm1,Lastname=@parm3 where ID like @parm2"
            cmd3.Parameters.AddWithValue("@parm2", ComboBox2.SelectedItem.ToString)
            cmd3.Parameters.AddWithValue("@parm1", TextBox1.Text)
            cmd3.Parameters.AddWithValue("@parm3", TextBox1.Text)
            i = cmd3.ExecuteNonQuery()
            MsgBox(i.ToString & "Rows are Updated")
            cmd3.Dispose()
            cnn2.Close()
        Else
            MsgBox("the filled cannot be empty")

        End If

    End Sub

    Private Sub CmdView_Click(sender As Object, e As EventArgs) Handles CmdView.Click
        ViewData()
    End Sub
    Private Sub ViewData()
        Dim cnn2 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")
        Dim ViewQuery As String = "Select * from StudentT"
        Dim cmd As New SqlCommand(ViewQuery, cnn2)
        Dim DataAda As New SqlDataAdapter
        DataAda.SelectCommand = cmd
        Dim DataTab As New DataTable()
        DataAda.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub

    Private Sub exitform_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Close()
    End Sub

    Private Sub exitform_Click_1(sender As Object, e As EventArgs) Handles exitform.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub firstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles firstname.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub firstname_TextChanged(sender As Object, e As EventArgs) Handles firstname.TextChanged

    End Sub

    Private Sub lastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lastname.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub lastname_TextChanged(sender As Object, e As EventArgs) Handles lastname.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True

        End If
     
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        Dim i As Integer
        For i = 0 To ComboBox1.Items.Count - 1
            'required code
            e.Handled = True
        Next i
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class