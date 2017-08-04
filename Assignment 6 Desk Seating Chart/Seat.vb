Public Class frmSeat
    Dim intSeat As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' if data validated ok then load SeatChart array with data from textbox controls
        If Data_Validated_OK() = True Then
            SeatChart(intSeat).StudentName = txtName.Text.Trim
            SeatChart(intSeat).HomePhone = txtHomePhone.Text
        End If

        'set DirtyData to True
        DirtyData = True

        Me.Close()
    End Sub




    Private Function Data_Validated_OK() As Boolean
        'if student name is blank(empty) then display error, set focus to control, return false
        If txtName.Text.Trim = String.Empty Then
            MessageBox.Show("Name is required.", "Seating Chart Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtName.Focus()
            Return False
            Exit Function
        End If

        'if Home phone is blank(empty) then display error, set focus to control, return false
        If txtHomePhone.Text Like "(###) ###-####" Then
            'good phone number
        Else
            MessageBox.Show("Phone number is required.", "Seating Chart Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtHomePhone.Focus()
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        'Remove student from seat by loading SeatChart array with empty string values for name and phone
        SeatChart(intSeat).StudentName = String.Empty
        SeatChart(intSeat).HomePhone = String.Empty

        'Set DirtyData to True
        DirtyData = True

        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close form
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSeat.TextChanged
        intSeat = txtSeat.Text

    End Sub


    Private Sub frmSeat_Load(sender As Object, e As EventArgs) Handles Me.Load
        intSeat = txtSeat.Text

    End Sub
End Class