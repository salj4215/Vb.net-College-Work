'Pig Latin Conversion Program (assignment 5)
'This program converts words entered by user to pig latin
'Created by Salleh Jahaf
'Version 1.02 last updated 11/24/2015

Public Class frmMain

    'Code to exit program when user clicks exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'Code to display word converted to pig latin
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim strUserWord As String
        Dim strConvertedWord As String

        'if no word is entered in the text box, show message to user and give text box focus
        If txtUserWord.Text = String.Empty Then
            MessageBox.Show("Please enter a word into the text box.", "No Word Entered", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUserWord.Focus()
            Exit Sub
        End If

        'assign user word to variable after trimming spaces and making all letters upper case
        strUserWord = txtUserWord.Text.Trim
        strUserWord = strUserWord.ToUpper

        'give variable that will hold converted word any value
        strConvertedWord = strUserWord

        'Call sub procedure to convert user word to converted word
        Call Convert_to_Pig_Latin(strUserWord, strConvertedWord)

        'Display converted word
        lblConvertedWord.Text = strConvertedWord



    End Sub

    'Code to convert user word to pig latin
    Private Sub Convert_to_Pig_Latin(ByVal WordToConvert As String, ByRef PigLatinWord As String)

        Dim intNumChars As Integer
        Dim strChar As String

        'count how many letters users word consists of and assign to variable
        intNumChars = WordToConvert.Length

        'if user word begins with a vowel or Y, add "-way" to the end of user's word and exit procedure
        If WordToConvert Like "[AEIOUY]*" Then
            PigLatinWord = PigLatinWord.Insert(intNumChars, "-WAY")
            Exit Sub
        End If

        'If word contains a vowel or "Y", add a dash to the end of the word then send consonants at the beginning of the word to the end until a vowel or "Y" is at the beginning, then add "ay" to the end
        If WordToConvert.Contains("A") OrElse WordToConvert.Contains("E") OrElse WordToConvert.Contains("I") OrElse WordToConvert.Contains("O") OrElse WordToConvert.Contains("U") OrElse WordToConvert.Contains("Y") Then
            PigLatinWord = PigLatinWord.Insert(intNumChars, "-")
            For intIndex As Integer = 0 To intNumChars - 1
                strChar = WordToConvert.Substring(intIndex, 1)
                If strChar Like "[!AEIOUY]" Then
                    PigLatinWord = PigLatinWord.Remove(0, 1)
                    PigLatinWord = PigLatinWord.Insert(intNumChars, strChar)
                Else
                    PigLatinWord = PigLatinWord & "AY"
                    Exit For
                End If
            Next intIndex
            Exit Sub
        End If

        'Add "-way" at the end if no vowels or "Y" is in user's word
        PigLatinWord = PigLatinWord & "-WAY"

    End Sub

    'Code to select all text within text box when user tabs into field
    Private Sub txtUserWord_Enter(sender As Object, e As EventArgs) Handles txtUserWord.Enter

        txtUserWord.SelectAll()

    End Sub

    'Clear output when user types changes contents of text field
    Private Sub txtUserWord_TextChanged(sender As Object, e As EventArgs) Handles txtUserWord.TextChanged

        lblConvertedWord.Text = String.Empty

    End Sub
End Class
