﻿Imports Oracle.DataAccess.Client
Public Class search

    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp, I As Integer
    Dim reader2 As OracleDataReader
    Dim seats As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As searchgrid
        r = New searchgrid(ComboBox1.Text, ComboBox2.Text, DateTimePicker1, ComboBox3.Text)

        r.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con1 = New OracleConnection("Data Source=localhost;User ID=vedang;password=softwareengg")

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