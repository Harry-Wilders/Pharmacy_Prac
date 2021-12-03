Imports System.Data.OleDb

Public Class Validate
    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Harry\Desktop\MsDatabase\PharmacyDB.accdb ")

    Private thisDataReader As OleDbDataReader


    Private Sub FillCombo()
        conn.Open()


        ValidateComboBox.Items.Add("All")
        ValidateComboBox.Items.Add("Valid")
        ValidateComboBox.Items.Add("Expired")



        conn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            ConnectionLabel.Text = "Connected"
            ConnectionLabel.ForeColor = Color.Blue
        Catch ex As Exception
            ConnectionLabel.Text = "Disconnected"
            ConnectionLabel.ForeColor = Color.Red
        End Try
        conn.Close()


        FillCombo()

    End Sub


    Private Sub LoadExpiry()

        Dim SQLString As String = "SELECT * FROM Medicine WHERE Medicine.ExpDate <= Date()"
        Try
            DataGridView1.Rows.Clear()
            conn.Open()

            Dim thisCommand As New OleDbCommand(SQLString, conn)

            thisDataReader = thisCommand.ExecuteReader
            While thisDataReader.Read
                DataGridView1.Rows.Add(thisDataReader.Item("MedicineID"), thisDataReader.Item("MedicineName"),
                                       thisDataReader.Item("BuyingPrice"), thisDataReader.Item("SellingPrice"),
                                        thisDataReader.Item("Quantity"), thisDataReader.Item("ExpDate"), thisDataReader.Item("Company"))


            End While




        Catch ex As Exception

            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Loading DatagridView Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub loadValid()



        Dim SQLString As String = "SELECT * FROM Medicine WHERE Medicine.ExpDate >= Date()"
        Try
            DataGridView1.Rows.Clear()
            conn.Open()

            Dim thisCommand As New OleDbCommand(SQLString, conn)

            thisDataReader = thisCommand.ExecuteReader
            While thisDataReader.Read
                DataGridView1.Rows.Add(thisDataReader.Item("MedicineID"), thisDataReader.Item("MedicineName"),
                                       thisDataReader.Item("BuyingPrice"), thisDataReader.Item("SellingPrice"),
                                        thisDataReader.Item("Quantity"), thisDataReader.Item("ExpDate"), thisDataReader.Item("Company"))


            End While



        Catch ex As Exception

            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Loading DatagridView Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub loadDataGridView()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()

            Dim thisCommand As New OleDbCommand("SELECT * FROM Medicine", conn)

            thisDataReader = thisCommand.ExecuteReader
            While thisDataReader.Read
                DataGridView1.Rows.Add(thisDataReader.Item("MedicineID"), thisDataReader.Item("MedicineName"),
                                       thisDataReader.Item("BuyingPrice"), thisDataReader.Item("SellingPrice"),
                                        thisDataReader.Item("Quantity"), thisDataReader.Item("ExpDate"), thisDataReader.Item("Company"))


            End While



        Catch ex As Exception

            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Loading DatagridView Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub ValidateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ValidateComboBox.SelectedIndexChanged
        If ValidateComboBox.SelectedIndex = 0 Then
            loadDataGridView()
        ElseIf ValidateComboBox.SelectedIndex = 1 Then
            loadValid()
        ElseIf ValidateComboBox.SelectedIndex = 2 Then
            LoadExpiry()
        End If
    End Sub

    Private Sub ExpButton_Click(sender As Object, e As EventArgs) Handles ExpButton.Click
        Me.Hide()

        Dim expMed = New ExpiredMedicinesReport
        expMed.Show()
    End Sub



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub MedicineButton_Click(sender As Object, e As EventArgs) Handles MedicineButton.Click
        Me.Hide()

        Dim med = New MedicineForm
        med.Show()
    End Sub

    Private Sub SupplierButton_Click(sender As Object, e As EventArgs) Handles SupplierButton.Click
        Me.Hide()

        Dim supplier = New SupplierForm
        supplier.Show()
    End Sub

    Private Sub AgentButton_Click(sender As Object, e As EventArgs) Handles AgentButton.Click
        Me.Hide()

        Dim agent = New AgentForm
        agent.Show()
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

    Private Sub ValidityButton_Click(sender As Object, e As EventArgs) Handles ValidityButton.Click
        Me.Show()
    End Sub

End Class