Imports Oracle.DataAccess.Client

Public Class LoginForm1



    Dim con1 As OracleConnection
        Dim cmd As OracleCommand
        Dim query As String
        Dim temp As Integer





        Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If ((TextBox1.Text = " ") Or (TextBox2.Text = "")) Or ((TextBox1.Text = "lab") And (TextBox2.Text = "")) Or ((TextBox1.Text = "") And (TextBox2.Text = "lab")) Then
            MsgBox(" Enter the username and password ")
        Else

            Dim search As String
            Dim flag As Integer = 0
            con1 = New OracleConnection("Data Source=localhost;User ID=vedang;password=softwareengg")
            search = "select * from LOGIN_TABLE where username ='" & TextBox1.Text & "' "
            cmd = New OracleCommand(search, con1)
            Dim reader2 As OracleDataReader

            con1.Open()
            reader2 = cmd.ExecuteReader()

            Do While reader2.Read()
                query = reader2("password")
                flag = 1
            Loop
            reader2.Close()

            con1.Close()
            If flag = 0 Then
                MsgBox(" username doesnt exist", vbOKOnly + vbCritical, "ERROR")

            ElseIf TextBox2.Text = query Then


                Dim r As Form2
                r = New Form2
                Me.Hide()
                r.Show()



            Else
                MsgBox("Username and Password doesnt match.Please enter correct username and Password")
                TextBox2.Text = " "
                TextBox2.Focus()
            End If

        End If



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim l As New Register
        l.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
