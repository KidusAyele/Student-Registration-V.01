Public Class passwordv
        Dim i, k, j As Byte 'to count number of character
        Dim c As Char 'to track every password character
        Private userName As String
        Private password As String
        Property myPassword As String
            Get
                myPassword = password
            End Get
            Set(value As String)
                If value.Length < 4 Then
                    MsgBox("password has to be between 4-20 characters")
                ElseIf value.Length > 20 Then
                    MsgBox("password has to be between 4-20 characters")
                Else
                    For Each Me.c In value
                        If Not Char.IsLetterOrDigit(c.ToString(), 0) Then
                            'Will count special characters
                            i += 1
                        ElseIf Char.IsLetter(c.ToString(), 0) Then
                            'Will count characters
                            j += 1
                        ElseIf Char.IsDigit(c.ToString(), 0) Then
                            'Will count numbers
                            k += 1
                        End If
                    Next
                    If i >= 1 And k >= 1 And j >= 1 Then
                        password = value
                        admin.low = 0
                        admin.law = 0
                    Else
                        admin.low = 1
                        admin.law = 1
                        MsgBox("Password is Weak")
                    End If

                End If

            End Set

        End Property



        Shared Function l() As Integer
            Throw New NotImplementedException
        End Function

    End Class

