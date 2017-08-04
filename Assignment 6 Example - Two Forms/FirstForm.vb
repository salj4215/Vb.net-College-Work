Public Class frmFirstForm

    Dim LabelNames(3) As Label

    Private Sub Seat_was_clicked(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click


        Dim btnSelected As Button               'this variable will be assigned to the Sender object
        Dim intSeat As Integer                  'this variable will represent the seat number selected




        'Assign btnSelected to the sender object
        btnSelected = sender
        'Assign intSeat to the seat that was selected
        intSeat = btnSelected.Tag
        'Declare an instance of the second form
        Dim frmSecond As New frmSecondForm
        'Assign data from Array to controls on second form
        frmSecond.lblSeatSelected.Text = intSeat
        frmSecond.txtNameEntered.Text = StudentSeat(intSeat).Name
        frmSecond.txtPhoneNumber.Text = StudentSeat(intSeat).Phone
        'Display the Second form as a Dialog form
        frmSecond.ShowDialog()

        'After returning from Second Form load controls on FirstForm from Array
        LabelNames(intSeat).Text = StudentSeat(intSeat).Name

        'Assign ToolTip value of selected
        tolDisplayPhone.SetToolTip(btnSelected, StudentSeat(intSeat).Phone)






    End Sub

   
    Private Sub frmFirstForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabelNames = {lbl1, lbl1, lbl2, lbl3}

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim outFile As IO.StreamWriter
        Dim strOutput As String

        outFile = IO.File.CreateText("AssignedSeat.dat")

        For i As Integer = 1 To 3
            If StudentSeat(i).Name = String.Empty Then
                'do nothing
            Else
                strOutput = i.ToString.PadLeft(2) & StudentSeat(i).Name.PadRight(20) & StudentSeat(i).Phone.PadRight(15)
                outFile.WriteLine(strOutput)
            End If
        Next
        outFile.Close()
    End Sub

End Class
