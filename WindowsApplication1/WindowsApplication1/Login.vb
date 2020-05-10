Imports Oracle.DataAccess.Client
Public Class Login
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((TextBox1.Text = " ") Or (TextBox2.Text = "")) Or ((TextBox1.Text = "lab") And (TextBox2.Text = "")) Or ((TextBox1.Text = "") And (TextBox2.Text = "lab")) Then
            MsgBox(" Enter the login_id and password ")
        Else

            Dim search As String
            Dim flag As Integer = 0
            con1 = New OracleConnection("Data Source=localhost;User ID=supermarket;Password=supermarket;")
            search = "select * from login where username ='" & TextBox1.Text & "' "
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
                MsgBox(" login_id doesnt exist", vbOKOnly + vbCritical, "ERROR")

            ElseIf TextBox2.Text = query Then
                Dim r As New user
                r.Show()
                Me.Hide()

            Else
                MsgBox("login_id and Password doesnt match.Please enter correct login_id and Password")
                TextBox2.Text = " "
                TextBox2.Focus()
            End If

        End If

        'My.Forms.user.Text = Now.ToString
        ' My.Forms.user.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim r As New register
        r.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        My.Forms.create1.Text = Now.ToString
        My.Forms.create1.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


End Class
