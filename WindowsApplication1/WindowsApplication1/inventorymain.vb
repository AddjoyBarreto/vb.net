Imports Oracle.DataAccess.Client
Public Class inventorymain
    Dim ADD1 As New Itemstockinput
    Dim modify As New Modify_Record
    Dim del As New Delete_Record
    Dim view As New viewrecords

    Dim con1 As OracleConnection
    Dim cmd As OracleCommand
    Dim query As String
    Dim temp As Integer

    Private Sub inventorymain(sender As Object, e As EventArgs) Handles MyBase.Load
        con1 = New OracleConnection("Data Source=localhost; User ID=supermarket ;password=supermarket")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If RadioButton1.Checked = True And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            ADD1.Show()
            Me.Hide()

        End If

        If RadioButton2.Checked = True And RadioButton1.Checked = False And RadioButton3.Checked = False Then

            del.Show()
            Me.Hide()
        End If

        If RadioButton3.Checked = True And RadioButton2.Checked = False And RadioButton1.Checked = False Then

            modify.Show()
            Me.Hide()
        End If

        If RadioButton4.Checked = True And RadioButton2.Checked = False And RadioButton1.Checked = False Then

            View.Show()
            Me.Hide()
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim op As New user
        op.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub inventorymain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class