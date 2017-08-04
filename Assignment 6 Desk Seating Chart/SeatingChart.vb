'Programmer: Salleh Jahaf
'Program name: Assignment 6 Desk Seating Chart
'Program is designed to keep track of assigned seats in a classroom
'Version 1.01 Last Updated 12/08/2015

Public Class frmSeatingChart
    Dim NameLabels(12) As Label
    Dim SeatPictureBox(12) As PictureBox



    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim inFile As IO.StreamReader
        Dim strInput As String
        Dim intSeat As Integer
        Dim strName As String
        Dim strHomePhone As String

        'If disk file does not exist then 
        If IO.File.Exists("SeatingChart.dat") = False Then
            '           inform user a new file will be created
            MessageBox.Show("File does not exist. A new file named SeatingChart.dat will be created", "Seating Chart", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '           exit procedure
            Exit Sub
        End If

        'Open disk file using StreamReader object
        inFile = IO.File.OpenText("SeatingChart.dat")
        'Do this loop as long as there is data
        Do Until inFile.Peek = -1
            '------------------>Read record into string variable strInput
            strInput = inFile.ReadLine
            '------------------>Strip off Seat number and assign to intSeat
            intSeat = strInput.Substring(0, 2)
            '------------------>Strip off Student name and assign to strName
            strName = strInput.Substring(2, 20)
            '------------------>Strip off Home phone and assign to strHomePhone
            strHomePhone = strInput.Substring(22, 14)
            '------------------>Load SeatChart array with strName using correct seat index
            SeatChart(intSeat).StudentName = strName.Trim
            '------------------>Load SeatChart array with strHomePhone using correct seat index
            SeatChart(intSeat).HomePhone = strHomePhone
            '------------------>Load Student Name in the correct label using NameLabels array
            NameLabels(intSeat).Text = SeatChart(intSeat).StudentName
            '------------------>Load Home Phone number in ToolTip control for the correct PictureBox using SeatPictureBox array
            ToolTipPhone.SetToolTip(SeatPictureBox(intSeat), SeatChart(intSeat).HomePhone)

            'end loop
        Loop


        'Disable File Open button
        btnOpen.Visible = False

        'Close file
        inFile.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim outFile As IO.StreamWriter
        Dim strOutput As String

        'Open Disk file for Output (not Append) using StreamWriter object
        outFile = IO.File.CreateText("SeatingChart.dat")

        'Loop Through SeatChart Array
        For i As Integer = 1 To 12
            '------------------If Student Name is not empty then assign strOutput to seat(2 chars) + StudentName(20 chars) + HomePhone(10 chars) + Newline(2 chars) and Write strOutput to disk file.
            If SeatChart(i).StudentName <> String.Empty Then
                strOutput = i.ToString.PadLeft(2) & SeatChart(i).StudentName.PadRight(20) & SeatChart(i).HomePhone.PadRight(14)
                outFile.WriteLine(strOutput)
            End If
            'end loop
        Next
        'close disk file
        outFile.Close()
        'set DirtyData to False
        DirtyData = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub frmSeatingChart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult

        'If DirtyData is true ask if they want to save unsaved changes?
        If DirtyData = True Then
            dlgButton = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End If
        '   If they want to save unsaved changes then Call btnSave.PerformClick method
        If dlgButton = Windows.Forms.DialogResult.Yes Then
            btnSave.PerformClick()
        End If

    End Sub

    Private Sub Seat_DoubleClicked(sender As Object, e As EventArgs) Handles picSeat1.DoubleClick, picSeat2.DoubleClick, picSeat3.DoubleClick, picSeat4.DoubleClick, picSeat5.DoubleClick, picSeat6.DoubleClick, picSeat7.DoubleClick, picSeat8.DoubleClick, picSeat9.DoubleClick, picSeat10.DoubleClick, picSeat11.DoubleClick, picSeat12.DoubleClick

        Dim picSeatDblClicked As PictureBox
        Dim intSeat As Integer

        picSeatDblClicked = sender
        intSeat = picSeatDblClicked.Tag

        'Create an instance of the Seat form
        Dim frmSeatInfo As New frmSeat

        'Load controls from Seat form to data from SeatChart array
        frmSeatInfo.txtSeat.Text = intSeat
        frmSeatInfo.txtName.Text = SeatChart(intSeat).StudentName
        frmSeatInfo.txtHomePhone.Text = SeatChart(intSeat).HomePhone

        'Display the Seat Form by calling the ShowDialog method
        frmSeatInfo.ShowDialog()

        'Load LabelArray with Student Name
        NameLabels(intSeat).Text = SeatChart(intSeat).StudentName

        'Load PictureBox Tooltip with Student home phone
        ToolTipPhone.SetToolTip(SeatPictureBox(intSeat), SeatChart(intSeat).HomePhone)

    End Sub

    Private Sub frmSeatingChart_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameLabels = {Label1, lblSeat1, lblSeat2, lblSeat3, lblSeat4, lblSeat5, lblSeat6, lblSeat7, lblSeat8, lblSeat9, lblSeat10, lblSeat11, lblSeat12}
        SeatPictureBox = {picSeat1, picSeat1, picSeat2, picSeat3, picSeat4, picSeat5, picSeat6, picSeat7, picSeat8, picSeat9, picSeat10, picSeat11, picSeat12}

    End Sub
End Class
