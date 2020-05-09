Imports Oracle.DataAccess.Client

Public Class Delete_Record
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp As Integer

    Dim reader2 As OracleDataReader
    Private Sub Delete_Record(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=supermarket;password=supermarket")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim op As New inventorymain
        op.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub



    Private Sub Delete_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim search1 As String
        Dim reader2 As OracleDataReader
        Dim quantity, I As Integer
        search1 = "select * from STOCK_INPUT where ITEM_NAME='" & ComboBox1.Text & "'"
        cmd = New OracleCommand(search1, con1)

        con1.Open()
        reader2 = cmd.ExecuteReader()

        Do While reader2.Read()
            quantity = reader2("QUANTITY")


        Loop
        reader2.Close()
        con1.Close()

        If quantity = 1 Then
            con1.Open()
            Dim del As String
            del = "delete from STOCK_INPUT where ITEM_NAME='" & ComboBox1.Text & "' "
            cmd = New OracleCommand(del, con1)
            I = cmd.ExecuteNonQuery()
            MessageBox.Show("Item Successfully Deleted")
            Dim op As New inventorymain
            op.Show()
            Me.Hide()
            con1.Close()


        ElseIf quantity = Val(TextBox2.Text) < 0 Then
            quantity = 0
            query = "Update STOCK_INPUT Set QUANTITY=" & quantity & " Where ITEM_NAME ='" & ComboBox1.Text & "'"

            cmd = New OracleCommand(query, con1)
            cmd.CommandType = CommandType.Text

            con1.Open()
            cmd.ExecuteNonQuery()
            MsgBox("iteam got over", vbOKOnly, "MESSAGE")
            Dim op As New inventorymain
            op.Show()
            Me.Hide()
            con1.Close()

        Else
            quantity = quantity - Val(TextBox2.Text)


            query = "Update STOCK_INPUT Set QUANTITY=" & quantity & " Where ITEM_NAME ='" & ComboBox1.Text & "'"

                cmd = New OracleCommand(query, con1)
                cmd.CommandType = CommandType.Text

                con1.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Record updated successfully", vbOKOnly, "MESSAGE")
                Dim op As New inventorymain
                op.Show()
                Me.Hide()
                con1.Close()



        End If



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class