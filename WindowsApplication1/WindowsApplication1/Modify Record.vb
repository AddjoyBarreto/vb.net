Imports Oracle.DataAccess.Client
Public Class Modify_Record
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp As Integer
    Dim reader2 As OracleDataReader

    Private Sub Modify_Record(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=supermarket;password=supermarket")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim po As New inventorymain
        po.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub




    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        query = "Update STOCK_INPUT Set PRICE=" & TextBox3.Text & " Where ITEM_NAME='" & ComboBox1.Text & "'"

        cmd = New OracleCommand(query, con1)
        cmd.CommandType = CommandType.Text

        con1.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Record updated successfully", vbOKOnly, "MESSAGE")
        Dim op As New inventorymain
        op.Show()
        Me.Hide()
        con1.Close()

    End Sub

    Private Sub Modify_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim search As String
        Dim id1 As Integer
        id1 = 1
        search = "select * from STOCK_INPUT"
        cmd = New OracleCommand(search, con1)

        con1.Open()
        reader2 = cmd.ExecuteReader()

        Do While reader2.Read()
            ComboBox1.Items.Add(reader2("ITEM_NAME"))


        Loop
        reader2.Close()
        con1.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class