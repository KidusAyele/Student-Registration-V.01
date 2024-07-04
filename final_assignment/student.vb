Imports System.Data.SqlClient
Public Class student
    Dim cmd2 As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub student_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        login.Show()
    End Sub
    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim cnn2 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")

        Try
            cnn2.Open()

        Catch ex As Exception
            MsgBox("Message failed")
        End Try
        cmd2.Connection = cnn2
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "Select ID,Firstname,Lastname,department from StudentT"
        reader = cmd2.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                ComboBox1.Items.Add(reader.Item(0).ToString)
            End While

        End If
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ViewData()
    End Sub
    Private Sub ViewData()
        Dim cnn2 As New SqlConnection("server=localhost;data source=DESKTOP-E7LNEBH;database=STUDENT;integrated security=sspi")
        Dim ViewQuery As String = "Select * from StudentT where ID like '" & ComboBox1.Text & "'"
        Dim cmd As New SqlCommand(ViewQuery, cnn2)
        Dim DataAda As New SqlDataAdapter
        DataAda.SelectCommand = cmd
        Dim DataTab As New DataTable()
        DataAda.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If (Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = False
        End If

        Dim i As Integer
        For i = 0 To ComboBox1.Items.Count - 1
            'required code
            e.Handled = True
        Next i
    End Sub

    Private Sub ComboBox1_QueryContinueDrag(sender As Object, e As QueryContinueDragEventArgs) Handles ComboBox1.QueryContinueDrag

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Me.Close()
    End Sub
End Class