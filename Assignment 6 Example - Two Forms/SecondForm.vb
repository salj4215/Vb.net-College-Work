Public Class frmSecondForm
    Dim intSeat As Integer      'variable used to represent the seat number
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If txtNameEntered.Text.Trim = String.Empty Then
            MessageBox.Show("Name is a required entry.", "User Message", MessageBoxButtons.OK)
            txtNameEntered.Focus()
            Exit Sub

        End If
        If txtPhoneNumber.Text Like "(###) ###-####" Then
            'good phone number
        Else
            MessageBox.Show("Phone number is required (999) 999-9999.", "User Message", MessageBoxButtons.OK)
            txtPhoneNumber.Focus()
            Exit Sub

        End If




        'Load array with data using seat number as index
        StudentSeat(intSeat).Name = txtNameEntered.Text.Trim
        StudentSeat(intSeat).Phone = txtPhoneNumber.Text

        'close form
        Me.Close()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click


        'Assign Student name and Phone to string empty for the correct array element
        StudentSeat(intSeat).Name = String.Empty
        StudentSeat(intSeat).Phone = String.Empty

        'close form
        Me.Close()

    End Sub

    Private Sub frmSecondForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Assign intSeat to the Seat Number

        intSeat = lblSeatSelected.Text

    End Sub
End Class