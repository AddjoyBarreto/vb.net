Imports Oracle.DataAccess.Client
Public Class Reservation
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I As Integer
    Dim reader2 As OracleDataReader
    Dim seats As Integer
    Private train As DataGridViewRow
    Dim doj As DateTimePicker
    Dim train_id As Integer

    Dim sg As searchgrid

    Public Sub NEWRECORD()      ' USER DEFINED FUNCTION TO GET THE NEXT VALID ID
        Dim query2 As String
        Dim ID As String
        query2 = "Select max(ID) from RESERVATIONS"
        con1.Open()
        cmd = New OracleCommand(query2, con1)
        cmd.CommandText = query2
        ID = cmd.ExecuteScalar().ToString
        If (ID.Equals("")) Then
            pidlabel.Text = 1
        Else
            pidlabel.Text = Val(ID) + 1
        End If
        con1.Close()
    End Sub

    Public Sub New(train As DataGridViewRow, dateTimePicker1 As DateTimePicker)
        MyBase.New()

        InitializeComponent()
        doj = dateTimePicker1
        Me.train = train
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        con1.Open()
        query = "Insert into RESERVATIONS values('" & pidlabel.Text & "','" & NameBox.Text & "','" & doj.Text & "','" & sourcelabel.Text & "','" & destlabel.Text & "','" & idlabel.Text & "')"




        cmd = New OracleCommand(query, con1)
        cmd.CommandType = CommandType.Text

        temp = cmd.ExecuteNonQuery()
        If temp > 0 Then
            MsgBox(" RECORD ADDED SUCESSFULLY", vbOKOnly, "MESSAGE")


            Dim cmd2 As OracleCommand
            Dim cmd3 As OracleCommand
            Dim query2 As String
            Dim reader3 As OracleDataReader
            Dim search As String
            search = "select * from SCHEDULE where ID=" & train_id & ""
            cmd3 = New OracleCommand(search, con1)


            reader3 = cmd3.ExecuteReader()

            Do While reader3.Read()
                seats = reader3("SEATS")

            Loop
            reader3.Close()




            query2 = "Update SCHEDULE Set SEATS=" & (seats - 1) & " Where ID=" & train_id & ""

            cmd2 = New OracleCommand(query2, con1)
            cmd2.CommandType = CommandType.Text


            cmd2.ExecuteNonQuery()

            MsgBox("Record updated successfully, seats remaining " + (seats - 1).ToString, vbOKOnly, "MESSAGE")

            con1.Close()




        Else
            MsgBox(" INSERT OPERATION FAILED", vbOKOnly + vbCritical, "ERROR")
        End If
        Call NEWRECORD()
        NameBox.Text = ""

        con1.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click


    End Sub

    Private Sub NewEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEntryToolStripMenuItem.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click

        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=vedang;password=softwareengg")



        Call NEWRECORD()

        idlabel.Text = train.Cells(0).Value
        sourcelabel.Text = train.Cells(1).Value
        destlabel.Text = train.Cells(2).Value
        datelabel.Text = train.Cells(3).Value
        typelabel.Text = train.Cells(5).Value
        train_id = idlabel.Text






    End Sub
End Class
