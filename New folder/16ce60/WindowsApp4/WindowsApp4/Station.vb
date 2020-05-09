Imports Oracle.DataAccess.Client
Public Class Station
    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I As Integer
    Dim reader2 As OracleDataReader
    Dim seats As Integer
    Private Sub Station_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=vedang;password=softwareengg")
        Dim da As OracleDataAdapter
        Dim d As DataSet

        con1.Open()
        query = "select * from TRAINS "

        cmd = New OracleCommand(query, con1)

        da = New OracleDataAdapter(query, con1)
        d = New DataSet()
        da.Fill(d, "test")
        DataGridView1.DataSource = d.Tables(0)

        con1.Close()

    End Sub
End Class