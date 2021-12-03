﻿
Imports System.Data.OleDb


Public Class AgentForm

    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Harry\Desktop\MsDatabase\PharmacyDB.accdb ")

    Private thisDataReader As OleDbDataReader
    Private myNumber As Integer

    Private Sub Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conn.Open()
            ConnectionLabel.Text = "Connected"
            ConnectionLabel.ForeColor = Color.Blue
        Catch ex As Exception
            ConnectionLabel.Text = "Disconnected"
            ConnectionLabel.ForeColor = Color.Red
        End Try
        conn.Close()

        EmpIDTextBox.Text = "[ Auto ]"
        EmpIDTextBox.Enabled = False


        loadDataGridView()
    End Sub

    Private Sub loadDataGridView()

        Try

            DataGridView1.Rows.Clear()

            conn.Open()

            Dim thisCommand As New OleDbCommand("SELECT * FROM Agent", conn)

            thisDataReader = thisCommand.ExecuteReader
            While thisDataReader.Read
                DataGridView1.Rows.Add(thisDataReader.Item("EmployeeID"), thisDataReader.Item("EmployeeName"),
                                       thisDataReader.Item("Age"), thisDataReader.Item("Salary"),
                                        thisDataReader.Item("PhoneNumber"), thisDataReader.Item("Password"))

            End While



        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Loading DatagridView Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        conn.Close()


    End Sub


    Private Sub clearFunction()
        EmpIDTextBox.Text = "[ AUTO ]"
        EmpNameTextBox.Clear()
        EmpAgeTextBox.Clear()
        SalaryTextBox.Clear()
        PhoneNumberTextBox.Clear()
        PasswordTextBox.Clear()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        clearFunction()
    End Sub




    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            conn.Open()

            If MsgBox("Are you sure you want to insert this record", vbQuestion + vbYesNo + vbDefaultButton2, "Insert new item") = vbYes Then
                Dim thisCommand As New OleDbCommand("INSERT INTO Agent" + "([EmployeeName], [Age], [Salary],
                                               [PhoneNumber], [Password])" & "VALUES(@EmployeeName, @Age, @Salary, @PhoneNumber, @Password)", conn)

                thisCommand.Parameters.Clear()
                thisCommand.Parameters.AddWithValue("@EmployeeName", EmpNameTextBox.Text)
                thisCommand.Parameters.AddWithValue("@Age", EmpAgeTextBox.Text)
                thisCommand.Parameters.AddWithValue("@Salary", SalaryTextBox.Text)
                thisCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                thisCommand.Parameters.AddWithValue("@Password", PasswordTextBox.Text)

                myNumber = thisCommand.ExecuteNonQuery
                If myNumber > 0 Then

                    MsgBox("Record Save Success", vbOKOnly + vbInformation + vbDefaultButton2, "Insert")
                Else

                    MsgBox("Failed", vbOKOnly + vbCritical + vbDefaultButton2, "Insert")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Insert Item Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        conn.Close()
        loadDataGridView()
        clearFunction()
    End Sub



    Sub Delete()
        Try
            conn.Open()

            If MsgBox("Are you sure you want to Delete this record", vbQuestion + vbYesNo + vbDefaultButton2, "Delete record") = vbYes Then
                Dim thisCommand As New OleDbCommand("DELETE FROM Agent WHERE" + "([EmployeeID])=(@EmployeeID)", conn)


                thisCommand.Parameters.Clear()
                thisCommand.Parameters.AddWithValue("@EmployeeID", EmpIDTextBox.Text)


                myNumber = thisCommand.ExecuteNonQuery
                If myNumber > 0 Then

                    MsgBox("Record Delete Success", vbOKOnly + vbInformation + vbDefaultButton2, "Delete")
                Else

                    MsgBox("Failed", vbOKOnly + vbCritical + vbDefaultButton2, "Delete")
                End If

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadDataGridView()
        clearFunction()

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If EmpIDTextBox.Text = "" Then
            MsgBox("No Agent Selected", vbOKOnly + vbCritical + vbDefaultButton2, "Delete")

        Else
            Delete()
        End If


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Me.DataGridView1.Rows(e.RowIndex)
            EmpIDTextBox.Text = row.Cells(0).Value.ToString()
            EmpNameTextBox.Text = row.Cells(1).Value.ToString()
            EmpAgeTextBox.Text = row.Cells(2).Value.ToString()
            SalaryTextBox.Text = row.Cells(3).Value.ToString()
            PhoneNumberTextBox.Text = row.Cells(4).Value.ToString()
            PasswordTextBox.Text = row.Cells(5).Value.ToString()
        End If
    End Sub


    Sub edit()
        Try
            conn.Open()
            If MsgBox("Are you sure you want to Update this record", vbQuestion + vbYesNo + vbDefaultButton2, "Update record") = vbYes Then
                Dim thisCommand As New OleDbCommand("UPDATE Agent SET [EmployeeName] = @EmployeeName, [Age] = @Age,
                                     [Salary] = @Salary, [PhoneNumber] = @PhoneNumber, [Password] = @Password
                                      WHERE EmployeeID = @EmployeeID", conn)
                thisCommand.Parameters.Clear()
                thisCommand.Parameters.AddWithValue("@EmployeeName", EmpNameTextBox.Text)
                thisCommand.Parameters.AddWithValue("@Age", EmpAgeTextBox.Text)
                thisCommand.Parameters.AddWithValue("@Salary", SalaryTextBox.Text)
                thisCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTextBox.Text)
                thisCommand.Parameters.AddWithValue("@Password", PasswordTextBox.Text)
                thisCommand.Parameters.AddWithValue("@EmployeeID", EmpIDTextBox.Text)

                myNumber = thisCommand.ExecuteNonQuery
                If myNumber > 0 Then

                    MsgBox("Record Update Success", vbOKOnly + vbInformation + vbDefaultButton2, "Update")
                Else

                    MsgBox("Failed", vbOKOnly + vbCritical + vbDefaultButton2, "Update")
                End If

            End If



        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Update Item Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conn.Close()
        loadDataGridView()
        clearFunction()

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        edit()

    End Sub

    Sub SearchFunction()
        Dim mySearch As String

        Try
            DataGridView1.Rows.Clear()
            conn.Open()


            mySearch = "Select * from Agent where EmployeeName like '%" & SearchTextBox.Text & "%' or Age LIKE '%" & SearchTextBox.Text & "%' Or  Salary LIKE '%" & SearchTextBox.Text & "%'"
            Dim thisCommand As New OleDbCommand(mySearch, conn)

            thisDataReader = thisCommand.ExecuteReader
            While thisDataReader.Read
                DataGridView1.Rows.Add(thisDataReader.Item("EmployeeID"), thisDataReader.Item("EmployeeName"),
                                       thisDataReader.Item("Age"), thisDataReader.Item("Salary"),
                                        thisDataReader.Item("PhoneNumber"), thisDataReader.Item("Password"))

            End While




        Catch ex As Exception


        End Try
        conn.Close()

    End Sub
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        SearchFunction()
    End Sub

    Private Sub ValidityButton_Click(sender As Object, e As EventArgs) Handles ValidityButton.Click
        Me.Hide()

        Dim valid = New Validate
        valid.Show()
    End Sub

    Private Sub MedicineButton_Click(sender As Object, e As EventArgs) Handles MedicineButton.Click
        Me.Hide()

        Dim medicine = New MedicineForm
        medicine.Show()
    End Sub


    Private Sub SupplierButton_Click(sender As Object, e As EventArgs) Handles SupplierButton.Click
        Me.Hide()

        Dim supplier = New SupplierForm
        supplier.Show()
    End Sub

    Private Sub AgentButton_Click(sender As Object, e As EventArgs) Handles AgentButton.Click
        Me.Show()
    End Sub

    Private Sub BillingButton_Click(sender As Object, e As EventArgs) Handles BillingButton.Click
        Me.Hide()
        Dim bill = New BillingForm
        bill.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        Dim back = New HomeForm
        back.Show()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
End Class