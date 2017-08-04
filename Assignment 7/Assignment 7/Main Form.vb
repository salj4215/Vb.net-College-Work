'Created by Salleh Jahaf
'Program: Assignment 7 Serenity Photos
'Program was created to save checks written by company to a disk file
'Version 1.01 last updated on 12/17/2015
Public Class frmCheckInput
    Private intChecks As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the application
        Me.Close()

    End Sub

    'ask user if they want unsaved check entry to save before exiting
    Private Sub frmCheckInput_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If DirtyData = True Then
            Dim dlgButton As DialogResult
            dlgButton = MessageBox.Show("Do you want to save your last record?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dlgButton = Windows.Forms.DialogResult.Yes Then
                btnSave.PerformClick()
            End If
        End If
        'show how many checks were written
        MessageBox.Show(intChecks & " checks were saved to the disk file.", "Serenity Photos", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub save_Changes(sender As Object, e As EventArgs) Handles txtCheckAmount.TextChanged, txtCheckNumber.TextChanged, txtPayable.TextChanged
        'If user adds a record and exits without saving
        If txtCheckNumber.Text <> String.Empty AndAlso txtDate.Text <> String.Empty AndAlso txtCheckAmount.Text <> String.Empty AndAlso txtPayable.Text <> String.Empty Then
            DirtyData = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'check if data entered is valid
        If Data_Validated_OK() = False Then Exit Sub

        Dim strCheckNumber As String
        Dim strCheckDate As String
        Dim strCheckAmount As String
        Dim strCheckPayee As String
        Dim check As Save

        'Assign variables
        strCheckNumber = txtCheckNumber.Text
        strCheckDate = txtDate.Text
        strCheckAmount = txtCheckAmount.Text
        strCheckPayee = txtPayable.Text

        'Create an instance of the save class
        check = New Save(strCheckNumber, strCheckDate, strCheckAmount, strCheckPayee)

        'Assign returning boolean to dirty data(sets to false after save is complete)
        DirtyData = check.saveCheck

        'Assign CheckCount to variable (keeps track of how many checks were written)
        intChecks = check.CheckCount

        'Clear all fields for new check entry
        txtCheckNumber.Text = String.Empty
        txtDate.Text = String.Empty
        txtCheckAmount.Text = String.Empty
        txtPayable.Text = String.Empty

        txtCheckNumber.Focus()
    End Sub

    'Validates data input
    Private Function Data_Validated_OK() As Boolean
        Dim dateCheck As Boolean
        Dim dblCheckAmount As Double

        If txtCheckNumber.Text = String.Empty Then
            MessageBox.Show("Please enter check number.", "Serenity Photos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCheckNumber.Focus()
            Return False
            Exit Function
        ElseIf txtDate.Text = String.Empty Then
            MessageBox.Show("Please enter check date.", "Serenity Photos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDate.Focus()
            Return False
            Exit Function
        End If

        dateCheck = IsDate(txtDate.Text)

        If dateCheck = False Then
            MessageBox.Show("Please enter a valid date.", "Serenity Photos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDate.Focus()
            Return False
            Exit Function
        ElseIf txtCheckAmount.Text = String.Empty Then
            MessageBox.Show("Please enter check amount.", "Serenity Photos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCheckAmount.Focus()
            Return False
            Exit Function
        End If

        Double.TryParse(txtCheckAmount.Text, dblCheckAmount)

        If dblCheckAmount <= 0 Then
            MessageBox.Show("Please enter a check amount greater than 0.", "Serenity Photos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCheckAmount.Focus()
            Return False
            Exit Function
        End If

        If txtPayable.Text = String.Empty Then
            MessageBox.Show("Please enter name of payee.", "Serenity Photos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPayable.Focus()
            Return False
            Exit Function
        End If

        Return True

    End Function

    'user can only enter numbers for check number
    Private Sub txtCheckNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCheckNumber.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    'user can only enter numeric monetary amount 
    Private Sub txtCheckAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCheckAmount.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
