<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.chkSummary = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPlayer1Total = New System.Windows.Forms.Label()
        Me.lblPlayer2Total = New System.Windows.Forms.Label()
        Me.picDie2Player2 = New System.Windows.Forms.PictureBox()
        Me.picDie1Player2 = New System.Windows.Forms.PictureBox()
        Me.picDie2Player1 = New System.Windows.Forms.PictureBox()
        Me.picDie1Player1 = New System.Windows.Forms.PictureBox()
        Me.picSixDots = New System.Windows.Forms.PictureBox()
        Me.picFiveDots = New System.Windows.Forms.PictureBox()
        Me.picFourDots = New System.Windows.Forms.PictureBox()
        Me.picThreeDots = New System.Windows.Forms.PictureBox()
        Me.picTwoDots = New System.Windows.Forms.PictureBox()
        Me.picOneDot = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPlayer1Wins = New System.Windows.Forms.Label()
        Me.lblPlayer2Wins = New System.Windows.Forms.Label()
        Me.lblTies = New System.Windows.Forms.Label()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.lblHighestNumberRolledPlayer2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblHighestNumberRolledPlayer1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPlayer1Name = New System.Windows.Forms.Label()
        Me.lblPlayer2Name = New System.Windows.Forms.Label()
        CType(Me.picDie2Player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1Player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie2Player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1Player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSixDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFiveDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFourDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThreeDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwoDots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOneDot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player 2:"
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(352, 149)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "&Roll Dice"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'chkSummary
        '
        Me.chkSummary.AutoSize = True
        Me.chkSummary.Location = New System.Drawing.Point(634, 12)
        Me.chkSummary.Name = "chkSummary"
        Me.chkSummary.Size = New System.Drawing.Size(134, 17)
        Me.chkSummary.TabIndex = 9
        Me.chkSummary.Text = "Display player statistics"
        Me.chkSummary.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(437, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Total:"
        '
        'lblPlayer1Total
        '
        Me.lblPlayer1Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer1Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1Total.ForeColor = System.Drawing.Color.Lime
        Me.lblPlayer1Total.Location = New System.Drawing.Point(437, 57)
        Me.lblPlayer1Total.Name = "lblPlayer1Total"
        Me.lblPlayer1Total.Size = New System.Drawing.Size(100, 93)
        Me.lblPlayer1Total.TabIndex = 15
        Me.lblPlayer1Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer2Total
        '
        Me.lblPlayer2Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer2Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2Total.ForeColor = System.Drawing.Color.Lime
        Me.lblPlayer2Total.Location = New System.Drawing.Point(437, 186)
        Me.lblPlayer2Total.Name = "lblPlayer2Total"
        Me.lblPlayer2Total.Size = New System.Drawing.Size(100, 93)
        Me.lblPlayer2Total.TabIndex = 16
        Me.lblPlayer2Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picDie2Player2
        '
        Me.picDie2Player2.Location = New System.Drawing.Point(241, 186)
        Me.picDie2Player2.Name = "picDie2Player2"
        Me.picDie2Player2.Size = New System.Drawing.Size(100, 93)
        Me.picDie2Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDie2Player2.TabIndex = 13
        Me.picDie2Player2.TabStop = False
        '
        'picDie1Player2
        '
        Me.picDie1Player2.Location = New System.Drawing.Point(67, 186)
        Me.picDie1Player2.Name = "picDie1Player2"
        Me.picDie1Player2.Size = New System.Drawing.Size(100, 93)
        Me.picDie1Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDie1Player2.TabIndex = 12
        Me.picDie1Player2.TabStop = False
        '
        'picDie2Player1
        '
        Me.picDie2Player1.Location = New System.Drawing.Point(241, 57)
        Me.picDie2Player1.Name = "picDie2Player1"
        Me.picDie2Player1.Size = New System.Drawing.Size(100, 93)
        Me.picDie2Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDie2Player1.TabIndex = 11
        Me.picDie2Player1.TabStop = False
        '
        'picDie1Player1
        '
        Me.picDie1Player1.Location = New System.Drawing.Point(67, 57)
        Me.picDie1Player1.Name = "picDie1Player1"
        Me.picDie1Player1.Size = New System.Drawing.Size(100, 93)
        Me.picDie1Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDie1Player1.TabIndex = 10
        Me.picDie1Player1.TabStop = False
        '
        'picSixDots
        '
        Me.picSixDots.Image = Global.Assignment_3.My.Resources.Resources.Dice_6
        Me.picSixDots.Location = New System.Drawing.Point(376, 416)
        Me.picSixDots.Name = "picSixDots"
        Me.picSixDots.Size = New System.Drawing.Size(100, 93)
        Me.picSixDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSixDots.TabIndex = 8
        Me.picSixDots.TabStop = False
        Me.picSixDots.Visible = False
        '
        'picFiveDots
        '
        Me.picFiveDots.Image = Global.Assignment_3.My.Resources.Resources.Dice_5
        Me.picFiveDots.Location = New System.Drawing.Point(241, 416)
        Me.picFiveDots.Name = "picFiveDots"
        Me.picFiveDots.Size = New System.Drawing.Size(100, 93)
        Me.picFiveDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFiveDots.TabIndex = 7
        Me.picFiveDots.TabStop = False
        Me.picFiveDots.Visible = False
        '
        'picFourDots
        '
        Me.picFourDots.Image = Global.Assignment_3.My.Resources.Resources.Dice_4
        Me.picFourDots.Location = New System.Drawing.Point(100, 416)
        Me.picFourDots.Name = "picFourDots"
        Me.picFourDots.Size = New System.Drawing.Size(100, 93)
        Me.picFourDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFourDots.TabIndex = 6
        Me.picFourDots.TabStop = False
        Me.picFourDots.Visible = False
        '
        'picThreeDots
        '
        Me.picThreeDots.Image = Global.Assignment_3.My.Resources.Resources.Dice_3
        Me.picThreeDots.Location = New System.Drawing.Point(376, 305)
        Me.picThreeDots.Name = "picThreeDots"
        Me.picThreeDots.Size = New System.Drawing.Size(100, 93)
        Me.picThreeDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThreeDots.TabIndex = 5
        Me.picThreeDots.TabStop = False
        Me.picThreeDots.Visible = False
        '
        'picTwoDots
        '
        Me.picTwoDots.Image = Global.Assignment_3.My.Resources.Resources.Dice_2
        Me.picTwoDots.Location = New System.Drawing.Point(241, 305)
        Me.picTwoDots.Name = "picTwoDots"
        Me.picTwoDots.Size = New System.Drawing.Size(100, 93)
        Me.picTwoDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTwoDots.TabIndex = 4
        Me.picTwoDots.TabStop = False
        Me.picTwoDots.Visible = False
        '
        'picOneDot
        '
        Me.picOneDot.Image = Global.Assignment_3.My.Resources.Resources.Dice_1
        Me.picOneDot.Location = New System.Drawing.Point(100, 305)
        Me.picOneDot.Name = "picOneDot"
        Me.picOneDot.Size = New System.Drawing.Size(100, 93)
        Me.picOneDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOneDot.TabIndex = 3
        Me.picOneDot.TabStop = False
        Me.picOneDot.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Player 1 wins:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Player 2 wins:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Ties:"
        '
        'lblPlayer1Wins
        '
        Me.lblPlayer1Wins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer1Wins.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1Wins.Location = New System.Drawing.Point(39, 38)
        Me.lblPlayer1Wins.Name = "lblPlayer1Wins"
        Me.lblPlayer1Wins.Size = New System.Drawing.Size(115, 23)
        Me.lblPlayer1Wins.TabIndex = 20
        '
        'lblPlayer2Wins
        '
        Me.lblPlayer2Wins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer2Wins.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2Wins.Location = New System.Drawing.Point(39, 99)
        Me.lblPlayer2Wins.Name = "lblPlayer2Wins"
        Me.lblPlayer2Wins.Size = New System.Drawing.Size(115, 23)
        Me.lblPlayer2Wins.TabIndex = 21
        '
        'lblTies
        '
        Me.lblTies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTies.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTies.Location = New System.Drawing.Point(39, 166)
        Me.lblTies.Name = "lblTies"
        Me.lblTies.Size = New System.Drawing.Size(115, 23)
        Me.lblTies.TabIndex = 22
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.lblHighestNumberRolledPlayer2)
        Me.grpStats.Controls.Add(Me.Label8)
        Me.grpStats.Controls.Add(Me.lblHighestNumberRolledPlayer1)
        Me.grpStats.Controls.Add(Me.Label10)
        Me.grpStats.Controls.Add(Me.lblPlayer1Wins)
        Me.grpStats.Controls.Add(Me.lblTies)
        Me.grpStats.Controls.Add(Me.Label5)
        Me.grpStats.Controls.Add(Me.lblPlayer2Wins)
        Me.grpStats.Controls.Add(Me.Label6)
        Me.grpStats.Controls.Add(Me.Label7)
        Me.grpStats.Location = New System.Drawing.Point(580, 50)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.Size = New System.Drawing.Size(352, 250)
        Me.grpStats.TabIndex = 23
        Me.grpStats.TabStop = False
        '
        'lblHighestNumberRolledPlayer2
        '
        Me.lblHighestNumberRolledPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighestNumberRolledPlayer2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestNumberRolledPlayer2.Location = New System.Drawing.Point(183, 99)
        Me.lblHighestNumberRolledPlayer2.Name = "lblHighestNumberRolledPlayer2"
        Me.lblHighestNumberRolledPlayer2.Size = New System.Drawing.Size(163, 23)
        Me.lblHighestNumberRolledPlayer2.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(180, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Highest number rolled by player 2:"
        '
        'lblHighestNumberRolledPlayer1
        '
        Me.lblHighestNumberRolledPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighestNumberRolledPlayer1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestNumberRolledPlayer1.Location = New System.Drawing.Point(183, 38)
        Me.lblHighestNumberRolledPlayer1.Name = "lblHighestNumberRolledPlayer1"
        Me.lblHighestNumberRolledPlayer1.Size = New System.Drawing.Size(163, 23)
        Me.lblHighestNumberRolledPlayer1.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(180, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Highest number rolled by player 1:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(495, 305)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPlayer1Name
        '
        Me.lblPlayer1Name.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1Name.Location = New System.Drawing.Point(154, 25)
        Me.lblPlayer1Name.Name = "lblPlayer1Name"
        Me.lblPlayer1Name.Size = New System.Drawing.Size(100, 19)
        Me.lblPlayer1Name.TabIndex = 25
        Me.lblPlayer1Name.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblPlayer2Name
        '
        Me.lblPlayer2Name.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2Name.Location = New System.Drawing.Point(154, 156)
        Me.lblPlayer2Name.Name = "lblPlayer2Name"
        Me.lblPlayer2Name.Size = New System.Drawing.Size(100, 19)
        Me.lblPlayer2Name.TabIndex = 26
        Me.lblPlayer2Name.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'frmGame
        '
        Me.AcceptButton = Me.btnRoll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 358)
        Me.Controls.Add(Me.lblPlayer2Name)
        Me.Controls.Add(Me.lblPlayer1Name)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpStats)
        Me.Controls.Add(Me.lblPlayer2Total)
        Me.Controls.Add(Me.lblPlayer1Total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picDie2Player2)
        Me.Controls.Add(Me.picDie1Player2)
        Me.Controls.Add(Me.picDie2Player1)
        Me.Controls.Add(Me.picDie1Player1)
        Me.Controls.Add(Me.chkSummary)
        Me.Controls.Add(Me.picSixDots)
        Me.Controls.Add(Me.picFiveDots)
        Me.Controls.Add(Me.picFourDots)
        Me.Controls.Add(Me.picThreeDots)
        Me.Controls.Add(Me.picTwoDots)
        Me.Controls.Add(Me.picOneDot)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGame"
        Me.Text = "Dice Game"
        CType(Me.picDie2Player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1Player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie2Player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1Player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSixDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFiveDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFourDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThreeDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwoDots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOneDot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStats.ResumeLayout(False)
        Me.grpStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents picOneDot As System.Windows.Forms.PictureBox
    Friend WithEvents picTwoDots As System.Windows.Forms.PictureBox
    Friend WithEvents picThreeDots As System.Windows.Forms.PictureBox
    Friend WithEvents picFourDots As System.Windows.Forms.PictureBox
    Friend WithEvents picFiveDots As System.Windows.Forms.PictureBox
    Friend WithEvents picSixDots As System.Windows.Forms.PictureBox
    Friend WithEvents chkSummary As System.Windows.Forms.CheckBox
    Friend WithEvents picDie1Player1 As System.Windows.Forms.PictureBox
    Friend WithEvents picDie2Player1 As System.Windows.Forms.PictureBox
    Friend WithEvents picDie1Player2 As System.Windows.Forms.PictureBox
    Friend WithEvents picDie2Player2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1Total As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2Total As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1Wins As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2Wins As System.Windows.Forms.Label
    Friend WithEvents lblTies As System.Windows.Forms.Label
    Friend WithEvents grpStats As System.Windows.Forms.GroupBox
    Friend WithEvents lblHighestNumberRolledPlayer1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblHighestNumberRolledPlayer2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPlayer1Name As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2Name As System.Windows.Forms.Label

End Class
