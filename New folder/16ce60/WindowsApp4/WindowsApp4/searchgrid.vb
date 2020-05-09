Imports Oracle.DataAccess.Client
Public Class searchgrid
    Dim da As OracleDataAdapter
    Dim d As DataSet


    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I As Integer
    Dim reader2 As OracleDataReader
    Dim seats As Integer
    Dim row, column As Integer

    Private source As String
    Private destination As String
    Private dateTimePicker1 As DateTimePicker
    Private type As String

    Dim train As DataGridViewRow



    Public Sub New(text1 As String, text2 As String, dateTimePicker1 As DateTimePicker, text3 As String)
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.source = text1
        Me.destination = text2
        Me.dateTimePicker1 = dateTimePicker1
        Me.type = text3
    End Sub





    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        row = e.RowIndex
        column = e.ColumnIndex
        train = DataGridView1.Rows.Item(row)
        Console.WriteLine(row)
        Console.WriteLine(column)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Reservation
        r = New Reservation(train, dateTimePicker1)
        r.Show()
        Me.Hide()
    End Sub

    Private Sub searchgrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost;User ID=vedang;password=softwareengg")
        dateTimePicker1.Format = DateTimePickerFormat.Custom
        dateTimePicker1.CustomFormat = " dd-MMM-yyyy  "
        query = "select * from SCHEDULE WHERE SOURCE='" & source & "' and DESTINATION='" & destination & "' and DATE_OF_JOURNEY='" & dateTimePicker1.Text & "' and TYPE='" & type & "'"

        cmd = New OracleCommand(query, con1)

        ' DataGridView1.Rows(0).Cells(0).Selected = False


        Try
            con1.Open()
            da = New OracleDataAdapter(query, con1)
            d = New DataSet()
            da.Fill(d, "test")
            DataGridView1.DataSource = d.Tables(0)
        Catch EX As Exception
            MsgBox(EX.ToString, vbOK)

        End Try
        con1.Close()


    End Sub
End Class