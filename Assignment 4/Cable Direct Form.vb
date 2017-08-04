'Cable Direct Due Calculator (assignment 4)
'This program displays a customer's total due owed to Cable Direct
'Created by Salleh Jahaf
'Version 1.01 last updated 11/04/2015

Option Strict On
Option Explicit On

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'verify that the user wants to exit the application

        Dim dlgButton As DialogResult

        dlgButton = MessageBox.Show("Are you sure you want to exit?", "Cable Direct", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        'if the No button was clicked, don't close the form

        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Display numbers 0 - 20 in the lstPremium listbox control

        For intPremiumChannels As Integer = 0 To 20
            lstPremium.Items.Add(intPremiumChannels.ToString("N0"))
        Next intPremiumChannels

        'Display numbers 0 - 100 in the lstConnections listbox control
        For intConnections As Integer = 0 To 100
            lstConnections.Items.Add(intConnections.ToString("N0"))
        Next intConnections
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim intChannels As Integer
        Dim intConnections As Integer
        Dim dblTotalDue As Double

        'Data validation

        If Data_Validated_OK() = False Then Exit Sub

        'assign variables to user selection

        intChannels = Convert.ToInt32(lstPremium.SelectedItem.ToString)
        intConnections = Convert.ToInt32(lstConnections.SelectedItem.ToString)

        'If residential customer, calculate cable bill 

        If radResidential.Checked Then
            dblTotalDue = getResTotalDue(intChannels)
        Else
            dblTotalDue = getBusTotalDue(intChannels, intConnections)
        End If

        dblTotalDue = Math.Round(dblTotalDue, 2)

        lblTotalDue.Text = dblTotalDue.ToString("C2")

    End Sub

    'Data Validation function
    Private Function Data_Validated_OK() As Boolean

        'make sure user selected customer type

        If radBusiness.Checked = False And radResidential.Checked = False Then
            MessageBox.Show("Please select what type of customer you are.", "Cable Direct", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        'make sure user selects number of premium channels

        If lstPremium.SelectedIndex = -1 Then
            MessageBox.Show("Please choose how many channels you are subscribed to.", "Cable Direct", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lstPremium.Focus()
            Return False
        End If

        'make sure business customer selects number of connections

        If radBusiness.Checked And lstConnections.SelectedIndex <= 0 Then
            MessageBox.Show("Please choose how many connections you have. You must have at least one connection.", "Cable Direct", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True
    End Function
    Private Function getResTotalDue(intPremium As Integer) As Double
        'Calculates and returns total due for residential customers

        Const dblPROCESSING_FEE As Double = 4.5
        Const intBASIC_SERVICE_FEE As Integer = 30
        Const intPREMIUM_PER_CHANNEL As Integer = 5
        Dim dblTotal As Double

        dblTotal = intPremium * intPREMIUM_PER_CHANNEL + dblPROCESSING_FEE + intBASIC_SERVICE_FEE

        If lstConnections.SelectedIndex > 0 Then
            lstConnections.SelectedIndex = 0
        End If

        Return dblTotal

    End Function
    Private Function getBusTotalDue(intPrem As Integer, intConnects As Integer) As Double
        'Calculates and returns total due for business customers

        Const dblPROCESSING_FEE As Double = 16.5
        Const intPREMIUM_PER_CHANNEL As Integer = 50
        Const intADDITIONAL_CONNECT As Integer = 4
        Dim intBasicServiceFee As Integer
        Dim dblTotal As Double

        'Any number of connections up to 10 have a flat fee of $80
        If intConnects <= 10 Then
            intBasicServiceFee = 80
        Else
            'Each connection over 10 connections are $4 each, on top of flat fee of $80
            intBasicServiceFee = (intConnects - 10) * intADDITIONAL_CONNECT + 80
        End If

        dblTotal = intPrem * intPREMIUM_PER_CHANNEL + intBasicServiceFee + dblPROCESSING_FEE

        Return dblTotal
    End Function

    Private Sub radResidential_CheckedChanged(sender As Object, e As EventArgs) Handles radResidential.CheckedChanged

        'Set connections to 0 if residential customer
        'Have customer select number of premium channels

        If radResidential.Checked Then
            lstConnections.SelectedIndex = 0
            lstPremium.SelectedIndex = -1
            'Have user select number of connections and premium channels if business customer
        Else
            lstConnections.SelectedIndex = -1
            lstPremium.SelectedIndex = -1
        End If

    End Sub
    'Clear labels if user changes input
    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles lstPremium.SelectedValueChanged, lstConnections.SelectedValueChanged, radBusiness.CheckedChanged,
        radResidential.CheckedChanged

        lblTotalDue.Text = String.Empty

    End Sub
End Class
