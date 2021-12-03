Imports System.Data.OleDb


Public Class LoginForm

    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Harry\Desktop\MsDatabase\PharmacyDB.accdb ")
    Private thisDataReader As OleDbDataReader


    Private Sub Fetch()
        conn.Open()

        Dim query = "SELECT *  FROM Login WHERE Username = '" & Trim(UserNameTextBox.Text) & "' AND Password = '" & Trim(PasswordTextBox.Text) & "'"

        Dim thisCommand As New OleDbCommand(query, conn)

        Dim thisDatatable As New DataTable()
        Dim thisAdapter As New OleDb.OleDbDataAdapter(thisCommand)


        thisAdapter.Fill(thisDatatable)



        thisDataReader = thisCommand.ExecuteReader


        If thisDataReader.Read = True Then


            MsgBox("Login Successful", vbOKOnly + vbInformation + vbDefaultButton2, "Login")
            Me.Hide()

            Dim home = New HomeForm
            home.Show()

        ElseIf UserNameTextBox.Text = "" Or PasswordTextBox.Text = "" Then

            MsgBox("Username or Password cannot be empty", vbOKOnly + vbCritical + vbDefaultButton2, "Login")

        Else

            MsgBox("Invalid input", vbOKOnly + vbCritical + vbDefaultButton2, "Login")
        End If

        conn.Close()
    End Sub
    Private Sub LoginButton_Click_1(sender As Object, e As EventArgs) Handles LoginButton.Click

        Fetch()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Application.Exit()
    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        PasswordTextBox.PasswordChar = If(CheckBoxShowPassword.Checked, vbNullChar, "*"c)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        UserNameTextBox.Text = String.Empty
        PasswordTextBox.Text = String.Empty
    End Sub

End Class