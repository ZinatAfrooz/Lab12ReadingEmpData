Imports System.IO

Public Class Form1

    ' Declare  variables
    Dim recordNumber As Integer = 1
    Dim filename As String
    Dim sr As StreamReader
    Dim message As String
    Dim fileValid As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filename = InputBox("File Name", "Enter the name of the file.")
        If File.Exists(filename) Then
            sr = File.OpenText(filename)
            fileValid = True
        Else
            MessageBox.Show("File not found!!", "File Not Found")
            fileValid = False
        End If
    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click
        If sr.EndOfStream = True Then
            MessageBox.Show("End of file")
        Else
            lblRecordNum.Text = CStr(recordNumber)
            lblFirstName.Text = sr.ReadLine
            lblMiddleName.Text = sr.ReadLine
            lblLastName.Text = sr.ReadLine
            lblEmployeeNum.Text = sr.ReadLine
            lblDept.Text = sr.ReadLine
            lblTelephone.Text = sr.ReadLine
            lblExtension.Text = sr.ReadLine
            lblEmail.Text = sr.ReadLine
            recordNumber += 1
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears the fields 
        lblRecordNum.Text = ""
        lblFirstName.Text = ""
        lblMiddleName.Text = ""
        lblLastName.Text = ""
        lblEmployeeNum.Text = ""
        lblDept.Text = ""
        lblTelephone.Text = ""
        lblExtension.Text = ""
        lblEmail.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
