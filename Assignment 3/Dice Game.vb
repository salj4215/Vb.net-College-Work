'Dice simulation game
'Created by Salleh Jahaf
'Game that simulates two players rolling two dice and determining who won
'Last updated on 10/22/2015 Version 1.0

Public Class frmGame

    'declare class-level variables
    Dim strPlayer1 As String
    Dim strPlayer2 As String

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'simulates a game of rolling dice

        Dim randGen As New Random
        Dim intPlayer1Num1 As Integer
        Dim intPlayer1Num2 As Integer
        Dim intPlayer2Num1 As Integer
        Dim intPlayer2Num2 As Integer
        Dim intPlayer1Sum As Integer
        Dim intPlayer2Sum As Integer
        Static intPlayer1Wins As Integer
        Static intPlayer2Wins As Integer
        Static intPlayer1MaxRoll As Integer
        Static intPlayer2MaxRoll As Integer
        Static intTies As Integer

        'assign random integer from 1 through 6
        intPlayer1Num1 = randGen.Next(1, 7)
        intPlayer1Num2 = randGen.Next(1, 7)
        intPlayer2Num1 = randGen.Next(1, 7)
        intPlayer2Num2 = randGen.Next(1, 7)

        'display appropriate image in picDie1Player1
        Select Case intPlayer1Num1
            Case 1
                picDie1Player1.Image = picOneDot.Image
            Case 2
                picDie1Player1.Image = picTwoDots.Image
            Case 3
                picDie1Player1.Image = picThreeDots.Image
            Case 4
                picDie1Player1.Image = picFourDots.Image
            Case 5
                picDie1Player1.Image = picFiveDots.Image
            Case 6
                picDie1Player1.Image = picSixDots.Image
        End Select

        'display appropriate image in picDie2Player1
        Select Case intPlayer1Num2
            Case 1
                picDie2Player1.Image = picOneDot.Image
            Case 2
                picDie2Player1.Image = picTwoDots.Image
            Case 3
                picDie2Player1.Image = picThreeDots.Image
            Case 4
                picDie2Player1.Image = picFourDots.Image
            Case 5
                picDie2Player1.Image = picFiveDots.Image
            Case 6
                picDie2Player1.Image = picSixDots.Image
        End Select

        'display appropriate image in picDie1Player2
        Select Case intPlayer2Num1
            Case 1
                picDie1Player2.Image = picOneDot.Image
            Case 2
                picDie1Player2.Image = picTwoDots.Image
            Case 3
                picDie1Player2.Image = picThreeDots.Image
            Case 4
                picDie1Player2.Image = picFourDots.Image
            Case 5
                picDie1Player2.Image = picFiveDots.Image
            Case 6
                picDie1Player2.Image = picSixDots.Image
        End Select

        'display appropriate image in picDie2Player2
        Select Case intPlayer2Num2
            Case 1
                picDie2Player2.Image = picOneDot.Image
            Case 2
                picDie2Player2.Image = picTwoDots.Image
            Case 3
                picDie2Player2.Image = picThreeDots.Image
            Case 4
                picDie2Player2.Image = picFourDots.Image
            Case 5
                picDie2Player2.Image = picFiveDots.Image
            Case 6
                picDie2Player2.Image = picSixDots.Image
        End Select

        'determine sum of rolls for player 1 and player 2
        intPlayer1Sum = intPlayer1Num1 + intPlayer1Num2
        intPlayer2Sum = intPlayer2Num1 + intPlayer2Num2

        'Display sums
        lblPlayer1Total.Text = intPlayer1Sum.ToString
        lblPlayer2Total.Text = intPlayer2Sum.ToString

        'Display who won or if it was a tie using message box
        If intPlayer1Sum > intPlayer2Sum Then
            MessageBox.Show(strPlayer1 & " wins!", "Game Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            intPlayer1Wins = intPlayer1Wins + 1
        ElseIf intPlayer2Sum > intPlayer1Sum Then
            MessageBox.Show(strPlayer2 & " wins!", "Game Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            intPlayer2Wins = intPlayer2Wins + 1
        Else
            MessageBox.Show("Tie", "Game Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            intTies = intTies + 1
        End If

        'Calculate Player statistics
        If intPlayer1MaxRoll < intPlayer1Sum Then
            intPlayer1MaxRoll = intPlayer1Sum
        End If

        If intPlayer2MaxRoll < intPlayer2Sum Then
            intPlayer2MaxRoll = intPlayer2Sum
        End If

        'output player statistics to labels
        lblPlayer1Wins.Text = intPlayer1Wins.ToString
        lblPlayer2Wins.Text = intPlayer2Wins.ToString
        lblTies.Text = intTies.ToString
        lblHighestNumberRolledPlayer1.Text = intPlayer1MaxRoll.ToString
        lblHighestNumberRolledPlayer2.Text = intPlayer2MaxRoll.ToString

    End Sub

    'Exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Confirm with user if they want to exit
    Private Sub frmGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult

        dlgButton = MessageBox.Show("Are you sure you want to exit?", "End Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    'User will enter players' names'
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles Me.Load
        Const strPromptPlayer1 As String = "Please enter a name for player 1"
        Const strPromptPlayer2 As String = "Please enter a name for player 2"
        Const strTitlePlayer1 As String = "Enter Name For Player 1"
        Const strTitlePlayer2 As String = "Enter Name For Player 2"

        strPlayer1 = InputBox(strPromptPlayer1, strTitlePlayer1)
        strPlayer2 = InputBox(strPromptPlayer2, strTitlePlayer2)

        lblPlayer1Name.Text = strPlayer1
        lblPlayer2Name.Text = strPlayer2

        grpStats.Visible = False

    End Sub

    'display summary if check box is checked
    Private Sub chkSummary_CheckedChanged(sender As Object, e As EventArgs) Handles chkSummary.CheckedChanged

        If chkSummary.Checked Then
            grpStats.Visible = True
        Else
            grpStats.Visible = False
        End If

    End Sub
End Class
