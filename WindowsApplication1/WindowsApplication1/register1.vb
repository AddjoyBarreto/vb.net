Imports Oracle.DataAccess.Client
Public Class register
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I As Integer
    Dim reader2 As OracleDataReader

    Private Sub Register(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=supermarket;password=supermarket")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            temp = MsgBox("Enter All the Details", vbOKOnly + vbCritical, "ERROR")
        Else
            If TextBox2.Text = TextBox3.Text Then
                'I = 0

                'query = "select * from login where username='" & TextBox1.Text & "' "
                'con1.Open()
                'cmd = New OracleCommand(query, con1)


                'reader2 = cmd.ExecuteReader()

                'Do While reader2.Read()
                '    If (reader2("username") = TextBox1.Text) Then
                '        I = I
                '    Else
                '        I = 1
                '    End If
                'Loop
                'reader2.Close()
                'con1.Close()


                'If I = 1 Then
                '    MsgBox(" username exists", vbOKOnly + vbCritical, "ERROR")
                '    TextBox1.Text = " "
                '    TextBox1.Focus()
                'Else
                '    con1.Open()
                '    query = "Update login Set password='" & TextBox2.Text & "',confirm_password='" & TextBox3.Text & "'"

                '    cmd = New OracleCommand(query, con1)
                '    cmd.CommandType = CommandType.Text

                '    'con1.Open()
                '    cmd.ExecuteNonQuery()
                '    MsgBox("Record updated successfully", vbOKOnly, "MESSAGE")
                '    Dim op As New Login
                '    op.Show()
                '    Me.Hide()

                '    con1.Close()


                'End If
                '    TextBox1.Text = ""
                '    TextBox2.Text = ""
                '    TextBox3.Text = ""

                query = "Update login Set PASSWORD='" & TextBox2.Text & "' Where USERNAME='" & TextBox1.Text & "'"

                cmd = New OracleCommand(query, con1)
                cmd.CommandType = CommandType.Text

                con1.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Password Changed successfully", vbOKOnly, "MESSAGE")
                Dim op As New Login
                op.Show()
                Me.Hide()

                con1.Close()



            Else
                temp = MsgBox("PASSWORDS DO NOT MATCH", vbOKOnly + vbCritical, "ERROR")
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox2.Focus()

            End If

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim op As New Login
        op.Show()
        Me.Hide()
    End Sub
End Class