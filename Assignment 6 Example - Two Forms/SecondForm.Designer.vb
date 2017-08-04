<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecondForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNameEntered = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSeatSelected = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter name:"
        '
        'txtNameEntered
        '
        Me.txtNameEntered.Location = New System.Drawing.Point(111, 67)
        Me.txtNameEntered.Name = "txtNameEntered"
        Me.txtNameEntered.Size = New System.Drawing.Size(100, 20)
        Me.txtNameEntered.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(47, 175)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblSeatSelected
        '
        Me.lblSeatSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeatSelected.Location = New System.Drawing.Point(197, 9)
        Me.lblSeatSelected.Name = "lblSeatSelected"
        Me.lblSeatSelected.Size = New System.Drawing.Size(43, 23)
        Me.lblSeatSelected.TabIndex = 1
        Me.lblSeatSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "You selected the following seat..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(111, 109)
        Me.txtPhoneNumber.Mask = "(000) 000-0000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter phone:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(136, 175)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'frmSecondForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSeatSelected)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNameEntered)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSecondForm"
        Me.Text = "Form #2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNameEntered As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblSeatSelected As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
End Class
