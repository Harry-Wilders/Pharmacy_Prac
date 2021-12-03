Imports System.Data.OleDb
Public Class ExpiredReport
    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Harry\Desktop\MsDatabase\PharmacyDB.accdb ")

    Private Sub ExpiredReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dba As New OleDbDataAdapter("SELECT * FROM ExpiredMedicine", conn)
        Dim dbset As New DataSet
        dba.Fill(dbset)
        Me.DataGridView1.DataSource = dbset.Tables(0).DefaultView
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub


    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        Dim back = New ExpiredMedicinesReport
        back.Show()
    End Sub


End Class