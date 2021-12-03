Imports System.Data.OleDb
Public Class ExpiredMedicinesReport
    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Harry\Desktop\MsDatabase\PharmacyDB.accdb ")

    Private thisDataReader As OleDbDataReader

    Private Sub ExpiredMedicinesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadExpiry()
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


    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            conn.Open()


            Dim thisCommand As New OleDbCommand("INSERT INTO ExpiredMedicine ([MedicineName], [BuyingPrice],
                                               [Quantity], [ExpDate], [DateRemoved]) VALUES(@MedicineName, @BuyingPrice, 
                                        @Quantity, @ExpDate, @DateRemoved)", conn)

            thisCommand.Parameters.Clear()
            thisCommand.Parameters.AddWithValue("@MedicineName", DataGridView1.CurrentRow.Cells(1).Value)
            thisCommand.Parameters.AddWithValue("@BuyingPrice", DataGridView1.CurrentRow.Cells(2).Value)
            thisCommand.Parameters.AddWithValue("@Quantity", DataGridView1.CurrentRow.Cells(4).Value)
            thisCommand.Parameters.AddWithValue("@ExpDate", DataGridView1.CurrentRow.Cells(5).Value)
            thisCommand.Parameters.AddWithValue("@DateRemoved", String.Format("{0:dd/MM/yyyy}", Now()))



            thisCommand.ExecuteNonQuery()
            conn.Close()

            Dim del As New OleDbCommand("DELETE FROM Medicine WHERE MedicineID=" & Me.DataGridView1.CurrentRow.Cells(0).Value & ";", conn)
            conn.Open()
            del.ExecuteNonQuery()
            conn.Close()

            LoadExpiry()
            MessageBox.Show("Successfully deleted from Inventory!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Insert Item Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        conn.Close()


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub ShowDelButton_Click(sender As Object, e As EventArgs) Handles ShowDelButton.Click
        Me.Hide()

        Dim expRep = New ExpiredReport
        expRep.Show()
    End Sub



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub



    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        Dim back = New Validate
        back.Show()
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


    Private Sub ValidityButton_Click(sender As Object, e As EventArgs) Handles ValidityButton.Click
        Me.Show()
    End Sub



End Class