Imports Oracle.DataAccess.Client

Public Class Itemstockinput
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I, quantity As Integer
    Dim reader2 As OracleDataReader
    Dim id1 As Integer

    Private Sub Itemstockinput(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost; User ID=supermarket; password=supermarket")
    End Sub

    Public Sub NEWRECORD()      ' USER DEFINED FUNCTION TO GET THE NEXT VALID ID
        Dim query2 As String
        Dim ID As String
        query2 = "Select max(ID) from STOCK_INPUT"
        con1.Open()
        cmd = New OracleCommand(query2, con1)
        cmd.CommandText = query2
        ID = cmd.ExecuteScalar().ToString
        If (ID.Equals("")) Then
            id1 = 1
        Else
            id1 = Val(ID) + 1
        End If
        con1.Close()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim io As New inventorymain
        io.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub


    Private Sub Itemstockinput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Itemstockinput_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Call NEWRECORD()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            temp = MsgBox("Enter All the Details", vbOKOnly + vbCritical, "ERROR")


        Else


                con1.Open()
            query = "INSERT into STOCK_INPUT values('" & TextBox2.Text & "'," & TextBox3.Text & "," & TextBox4.Text & "," & id1 & ")"
            cmd = New OracleCommand(query, con1)
            cmd.CommandType = CommandType.Text
            temp = cmd.ExecuteNonQuery()
            If temp > 0 Then
                MsgBox(" RECORD ADDED SUCESSFULLY", vbOKOnly, "MESSAGE")
                Dim op As New inventorymain
                op.Show()
                Me.Hide()

            Else
                MsgBox(" INSERT OPERATION FAILED", vbOKOnly + vbCritical, "ERROR")
            End If
            con1.Close()

        End If


    End Sub
End Class