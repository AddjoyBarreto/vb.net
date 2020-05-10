Imports Oracle.DataAccess.Client

Public Class billing

    Private bitmap As Bitmap
    Dim da As OracleDataAdapter
    Dim d As DataSet
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I, id1 As Integer
    Dim reader2 As OracleDataReader
    Dim quantity1, price As New Integer

    Private Sub billing(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=supermarket;password=supermarket")
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim op As New user
        op.Show()
        Me.Hide()

    End Sub

    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ab As DataGridViewComboBoxColumn
        Call NEWRECORD()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = " dd-MMM-yyyy  "
        ab = DataGridView1.Columns(0)
        Dim search As String
        Dim id1 As Integer
        id1 = 1
        search = "select * from STOCK_INPUT"
        cmd = New OracleCommand(search, con1)

        con1.Open()
        reader2 = cmd.ExecuteReader()

        Do While reader2.Read()
            ab.Items.Add(reader2("ITEM_NAME"))


        Loop
        reader2.Close()
        con1.Close()



    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        'Print the contents.
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub



    Public Sub NEWRECORD()      ' USER DEFINED FUNCTION TO GET THE NEXT VALID ID
        Dim query2 As String

        Dim ID As String
        query2 = "Select max(ID) from BILLING"
        con1.Open()
        cmd = New OracleCommand(query2, con1)
        cmd.CommandText = query2
        ID = cmd.ExecuteScalar().ToString
        If (ID.Equals("")) Then
            id1 = 1
            TextBox2.Text = id1
        Else
            id1 = Val(ID) + 1
            TextBox2.Text = id1
        End If
        con1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id1 = TextBox2.Text
        con1.Open()
        query = "INSERT into BILLING values('" & TextBox1.Text & "'," & TextBox3.Text & ",'" & DateTimePicker1.Text & "'," & id1 & ")"
        cmd = New OracleCommand(query, con1)
        cmd.CommandType = CommandType.Text
        temp = cmd.ExecuteNonQuery()
        If temp > 0 Then
            MsgBox(" RECORD ADDED SUCESSFULLY", vbOKOnly, "MESSAGE")


        Else
            MsgBox(" INSERT OPERATION FAILED", vbOKOnly + vbCritical, "ERROR")
        End If
        con1.Close()

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        'Add a Panel control.
        Dim panel As New Panel()
        Me.Controls.Add(panel)

        'Create a Bitmap of size same as that of the Form.
        Dim grp As Graphics = panel.CreateGraphics()
        Dim formSize As Size = Me.ClientSize
        bitmap = New Bitmap(formSize.Width, formSize.Height, grp)
        grp = Graphics.FromImage(bitmap)

        'Copy screen area that that the Panel covers.
        Dim panelLocation As Point = PointToScreen(panel.Location)
        grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize)

        'Show the Print Preview Dialog.
        PrintPreviewDialog2.Document = PrintDocument2
        PrintPreviewDialog2.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog2.ShowDialog()

        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True


        Dim op As New billing
        op.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click




        Dim i, total As Integer
        i = 0
        total = 0
        While DataGridView1.Rows(i).Cells(1).Value <> 0
            Dim search, name As String
            name = DataGridView1.Rows(i).Cells(0).Value.ToString

            quantity1 = DataGridView1.Rows(i).Cells(1).Value

            Dim reader2 As OracleDataReader
            search = "select * from STOCK_INPUT where ITEM_NAME='" & name & "' "
            cmd = New OracleCommand(search, con1)

            con1.Open()
            reader2 = cmd.ExecuteReader()

            Do While reader2.Read()
                DataGridView1.Rows(i).Cells(2).Value = reader2("PRICE")


            Loop
            reader2.Close()
            con1.Close()


            price = DataGridView1.Rows(i).Cells(2).Value

            DataGridView1.Rows(i).Cells(3).Value = price * quantity1
            total = total + price * quantity1
            i = i + 1
        End While

        TextBox3.Text = total




    End Sub


End Class

