
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Printing



Public Class BillingForm


    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Harry\Desktop\MsDatabase\PharmacyDB.accdb ")

    Private thisDataReader As OleDbDataReader
    Private myNumber As Integer
    Private stock, unitPrice, subTotal As Integer
    Private myQuantity As Integer

    Private mRow As Integer = 0
    Private newpage As Boolean = True


    Private Sub FillCombo()
        conn.Open()

        Dim thisCommand As New OleDbCommand("SELECT * FROM Medicine WHERE Medicine.ExpDate >= Date()", conn)
        Dim thisDatatable As New DataTable()
        Dim thisAdapter As New OleDb.OleDbDataAdapter(thisCommand)


        thisAdapter.Fill(thisDatatable)

        MedicineComboBox.DataSource = thisDatatable
        MedicineComboBox.DisplayMember = "MedicineName"
        MedicineComboBox.ValueMember = "MedicineName"

        conn.Close()
    End Sub

    Private Sub FetchQuantity()
        conn.Open()

        Dim query = "SELECT Quantity,BuyingPrice  FROM Medicine WHERE MedicineName = '" & MedicineComboBox.SelectedValue.ToString & "'"

        Dim thisCommand As New OleDbCommand(query, conn)

        Dim thisDatatable As New DataTable()
        Dim thisAdapter As New OleDb.OleDbDataAdapter(thisCommand)


        thisAdapter.Fill(thisDatatable)



        thisDataReader = thisCommand.ExecuteReader
        While thisDataReader.Read

            stock = thisDataReader(0)
            unitPrice = thisDataReader(1)

            AvalilableStockLabel.Text = "Available Stock is: " & thisDataReader(0).ToString



        End While




        conn.Close()
    End Sub


    Private Sub BillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.Hide()

        Dim agent = New AgentForm
        agent.Show()
    End Sub

    Private Sub BillingButton_Click(sender As Object, e As EventArgs) Handles BillingButton.Click
        Me.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        Dim back = New HomeForm
        back.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub MedicineComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MedicineComboBox.SelectionChangeCommitted
        FetchQuantity()
    End Sub

    Private Sub UpdateOtherFieldBySubtract(ByVal myQuant As Integer)
        conn.Open()

        Dim query = "UPDATE Medicine SET Quantity = Quantity -  (" & myQuant.ToString & ") WHERE MedicineName = '" & MedicineComboBox.SelectedValue.ToString & "'"

        Dim thisCommand As New OleDbCommand(query, conn)

        Dim thisAdapter As New OleDb.OleDbDataAdapter(thisCommand)

        thisCommand.ExecuteReader()

        conn.Close()

    End Sub

    Private Sub UpdateOtherFieldByAdd(ByVal myQuant As Integer)
        conn.Open()

        Dim query = "UPDATE Medicine SET Quantity = Quantity +  (" & myQuant.ToString & ") WHERE MedicineName = '" & MedicineComboBox.SelectedValue.ToString & "'"

        Dim thisCommand As New OleDbCommand(query, conn)

        Dim thisAdapter As New OleDb.OleDbDataAdapter(thisCommand)

        thisCommand.ExecuteReader()

        conn.Close()

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click


        If QuantityTextBox.Text = "" Then

            MsgBox("You must enter the Quantity value", vbOKOnly + vbCritical + vbDefaultButton2, "Insert")
        ElseIf QuantityTextBox.Text > stock Then

            MsgBox("No Enough Stock to complete transaction", vbOKOnly + vbCritical + vbDefaultButton2, "Insert")
        Else
            Dim rowNumber, i As Integer



            myQuantity = Convert.ToInt32(QuantityTextBox.Text)
            rowNumber = DataGridView1.Rows.Add()

            For i = 0 To DataGridView1.Rows.Count - 1 Step +1

                DataGridView1.Rows(rowNumber).Cells("Column1").Value = (i + 1)
                DataGridView1.Rows(rowNumber).Cells("Column2").Value = MedicineComboBox.SelectedValue.ToString()
                DataGridView1.Rows(rowNumber).Cells("Column3").Value = QuantityTextBox.Text
                DataGridView1.Rows(rowNumber).Cells("Column4").Value = unitPrice
                DataGridView1.Rows(rowNumber).Cells("Column5").Value = Convert.ToInt32(QuantityTextBox.Text) * unitPrice



                subTotal += DataGridView1.Rows(i).Cells(4).Value


            Next
            UpdateOtherFieldBySubtract(myQuantity)

            TotalLabel.Text = "Total Amount is: " & subTotal

        End If


    End Sub










    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Try

            Dim isRemoved As Boolean
            isRemoved = False
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If MsgBox("Are you sure you want to Remove this record", vbQuestion + vbYesNo + vbDefaultButton2, "Remove Item") = vbYes Then
                    DataGridView1.Rows.Remove(row)
                    UpdateOtherFieldByAdd(myQuantity)
                    isRemoved = True

                End If

            Next

            If isRemoved Then
                MsgBox("Record Removed Successfully", vbInformation + vbOK + vbDefaultButton2, "Removed")
                isRemoved = False
            Else
                MsgBox("Failed", vbCritical + vbOK + vbDefaultButton2, "Removed")
            End If




        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ControlChars.NewLine & ex.Message, "Remove Record Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc, myRC As Rectangle
        Dim x As Int32 = e.MarginBounds.Left
        Dim h As Int32 = 0
        Dim row As DataGridViewRow
        Dim myY As Integer = e.MarginBounds.Bottom
        Dim myY_Top As Integer = e.MarginBounds.Top
        Dim myX As Integer = e.MarginBounds.Left
        Dim font1 As New Font("arial", 16, FontStyle.Regular)

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            row = DataGridView1.Rows(mRow)
            x = e.MarginBounds.Left

            e.Graphics.DrawString("Equator Pharmacy", font1, Brushes.Black, x, y)

            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x, (y + 50), cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText,
                                                DataGridView1.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To DataGridView1.RowCount - 1
            ' no need to try to print the new row
            If DataGridView1.Rows(thisNDX).IsNewRow Then Exit For

            row = DataGridView1.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then

                    rc = New Rectangle(x, y + 50, cell.Size.Width, cell.Size.Height)

                    myRC = New Rectangle(rc.X, rc.Y + 30, cell.Size.Width, cell.Size.Height)
                    ' SAMPLE CODE: How To 
                    ' up a RowPrePaint rule
                    'If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                          DataGridView1.Font, Brushes.Black, rc, fmt)


                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next

            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
        Dim CellValue As String


        With DataGridView1
            CellValue = .Rows(.RowCount - 1).Cells(.ColumnCount - 1).Value
            If CellValue <> String.Empty Then

                e.Graphics.DrawString("Total Amount is: " & subTotal,
                                          DataGridView1.Font, Brushes.Black, myRC, fmt)

            End If
        End With

    End Sub




    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Dim PrintersDialog As New PrintDialog()
        Dim custom As New PaperSize("custom", 800, 800)

        If PrintersDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Try

                mRow = 0
                newpage = True

                Dim pd As New PrintDocument()
                PrintersDialog.Document = PrintDocument1
                PrintDocument1.OriginAtMargins = True
                PrintDocument1.DefaultPageSettings.PaperSize = custom
                AddHandler pd.PrintPage, AddressOf Me.PrintDocument1_PrintPage
                pd.Print()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub


    Private Sub ValidityButton_Click(sender As Object, e As EventArgs) Handles ValidityButton.Click
        Me.Hide()

        Dim valid = New Validate
        valid.Show()
    End Sub


End Class