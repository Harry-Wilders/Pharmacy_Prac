Public Class HomeForm
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()

    End Sub


    Private Sub MedicineButton_Click_1(sender As Object, e As EventArgs) Handles MedicineButton.Click
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
        Me.Hide()
        Dim valid = New Validate
        valid.Show()
    End Sub
End Class