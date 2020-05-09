Imports Oracle.DataAccess.Client
Public Class schedule
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I As Integer
    Dim reader2 As OracleDataReader
    Dim seats, ok As Integer

    Dim row, column As Integer

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        row = e.RowIndex
        column = e.ColumnIndex


        Console.WriteLine(row)
        Console.WriteLine(column)
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ByDateToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Public Sub reloaddata()
        Dim da As OracleDataAdapter
        Dim d As DataSet

        query = "select * from SCHEDULE "

        cmd = New OracleCommand(query, con1)

        da = New OracleDataAdapter(query, con1)
        d = New DataSet()
        da.Fill(d, "test")
        DataGridView1.DataSource = d.Tables(0)

        con1.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ok = MsgBox(" ARE YOU SURE YOU WANT TO CACEL THIS TRAIN!!!? " & Environment.NewLine & "Train ID: " + DataGridView1.Rows.Item(row).Cells(0).Value.ToString, vbOKCancel + vbCritical, "CONFIRMATION!!!")
        If ok = 1 Then
            con1.Open()
            Dim del As String
            del = "delete from SCHEDULE where ID='" & DataGridView1.Rows.Item(row).Cells(0).Value.ToString & "' "
            cmd = New OracleCommand(del, con1)
            I = cmd.ExecuteNonQuery()
            MessageBox.Show("Train Successfully Deleted")
            Call reloaddata()
            con1.Close()





        End If


    End Sub

    Private Sub schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=vedang;password=softwareengg")
        Dim da As OracleDataAdapter
        Dim d As DataSet

        query = "select * from SCHEDULE "

        cmd = New OracleCommand(query, con1)

        da = New OracleDataAdapter(query, con1)
        d = New DataSet()
        da.Fill(d, "test")
        DataGridView1.DataSource = d.Tables(0)

        con1.Close()
    End Sub
End Class