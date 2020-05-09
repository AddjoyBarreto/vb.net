Imports Oracle.DataAccess.Client

Public Class add_train
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I As Integer
    Dim reader2 As OracleDataReader
    Dim seats As Integer

    Public Sub NEWRECORD()      ' USER DEFINED FUNCTION TO GET THE NEXT VALID ID
        Dim query2 As String
        Dim ID As String
        query2 = "Select max(ID) from SCHEDULE"
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

    Private Sub NewStationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStationToolStripMenuItem.Click
        Call NEWRECORD()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        con1.Open()
        query = "Insert into SCHEDULE values(" & TextBox1.Text & ",'" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Text & "'," & TextBox2.Text & ",'" & ComboBox3.Text & "')"
        cmd = New OracleCommand(query, con1)
        cmd.CommandType = CommandType.Text
        temp = cmd.ExecuteNonQuery()
        If temp > 0 Then
            MsgBox(" RECORD ADDED SUCESSFULLY", vbOKOnly, "MESSAGE")
            TextBox2.Text = ""
            TextBox1.Text = ""
            ComboBox1.ResetText()
            ComboBox2.ResetText()
            ComboBox3.ResetText()

        Else
            MsgBox(" INSERT OPERATION FAILED", vbOKOnly + vbCritical, "ERROR")
        End If
        con1.Close()


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub add_train_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = " dd-MMM-yyyy  "
        con1 = New OracleConnection("Data Source=localhost;User ID=vedang;password=softwareengg")
        Call NEWRECORD()

        Dim search As String
        Dim id1 As Integer
        id1 = 1
        search = "select * from TRAINS where STN_ID=" & id1 & ""
        cmd = New OracleCommand(search, con1)

        con1.Open()
        reader2 = cmd.ExecuteReader()

        Do While reader2.Read()
            ComboBox1.Items.Add(reader2("CITY"))
            ComboBox2.Items.Add(reader2("CITY"))
            id1 = id1 + 1
            search = "select * from TRAINS where STN_ID=" & id1 & ""
            cmd = New OracleCommand(search, con1)
            reader2 = cmd.ExecuteReader()

        Loop
        reader2.Close()
        con1.Close()


    End Sub
End Class