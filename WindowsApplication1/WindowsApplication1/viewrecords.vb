Imports Oracle.DataAccess.Client
Public Class viewrecords
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I As Integer
    Dim reader2 As OracleDataReader

    Private Sub viewrecords(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=supermarket;password=supermarket")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim op As New inventorymain
        op.Show()
        Me.Hide()

    End Sub





    Private Sub viewrecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As OracleDataAdapter
        Dim d As DataSet

        con1.Open()
        query = "select * from STOCK_INPUT "

        cmd = New OracleCommand(query, con1)

        da = New OracleDataAdapter(query, con1)
        d = New DataSet()
        da.Fill(d, "test")
        DataGridView1.DataSource = d.Tables(0)

        con1.Close()

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class