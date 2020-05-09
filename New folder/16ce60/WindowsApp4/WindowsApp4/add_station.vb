Imports Oracle.DataAccess.Client
Public Class add_station
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I As Integer
    Dim reader2 As OracleDataReader
    Dim seats As Integer


    Public Sub NEWRECORD()      ' USER DEFINED FUNCTION TO GET THE NEXT VALID ID
        Dim query2 As String
        Dim ID As String
        query2 = "Select max(STN_ID) from TRAINS"
        con1.Open()
        cmd = New OracleCommand(query2, con1)
        cmd.CommandText = query2
        ID = cmd.ExecuteScalar().ToString
        If (ID.Equals("")) Then
            TextBox1.Text = 1
        Else
            TextBox1.Text = Val(ID) + 1
        End If
        con1.Close()
    End Sub


    Private Sub add_station_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=vedang;password=softwareengg")
        Call NEWRECORD()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con1.Open()
        query = "Insert into TRAINS values(" & TextBox1.Text & ",'" & TextBox2.Text & "')"
        cmd = New OracleCommand(query, con1)
        cmd.CommandType = CommandType.Text
        temp = cmd.ExecuteNonQuery()
        If temp > 0 Then
            MsgBox(" RECORD ADDED SUCESSFULLY", vbOKOnly, "MESSAGE")
            TextBox2.Text = ""
            TextBox1.Text = ""

        Else
            MsgBox(" INSERT OPERATION FAILED", vbOKOnly + vbCritical, "ERROR")
        End If
        con1.Close()

    End Sub

    Private Sub NewStationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStationToolStripMenuItem.Click
        Call NEWRECORD()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Hide()
    End Sub
End Class