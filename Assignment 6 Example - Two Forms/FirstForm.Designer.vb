<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirstForm))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tolDisplayPhone = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.tbrMain = New System.Windows.Forms.ToolStrip()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.tbrMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1.Location = New System.Drawing.Point(145, 65)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(71, 15)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Tag = "1"
        Me.lbl1.Text = "Not assigned"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2.Location = New System.Drawing.Point(145, 109)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(71, 15)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Tag = "2"
        Me.lbl2.Text = "Not assigned"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3.Location = New System.Drawing.Point(145, 153)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(71, 15)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Tag = "3"
        Me.lbl3.Text = "Not assigned"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Click a seat:"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(64, 65)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 6
        Me.btn1.Tag = "1"
        Me.btn1.Text = "Seat 1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(64, 109)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 7
        Me.btn2.Tag = "2"
        Me.btn2.Text = "Seat 2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(64, 153)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 8
        Me.btn3.Tag = "3"
        Me.btn3.Text = "Seat 3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'tbrMain
        '
        Me.tbrMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.btnSave, Me.btnExit})
        Me.tbrMain.Location = New System.Drawing.Point(0, 0)
        Me.tbrMain.Name = "tbrMain"
        Me.tbrMain.Size = New System.Drawing.Size(284, 25)
        Me.tbrMain.TabIndex = 9
        Me.tbrMain.Text = "ToolStrip1"
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(40, 22)
        Me.btnOpen.Text = "Open"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(35, 22)
        Me.btnSave.Text = "Save"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(29, 22)
        Me.btnExit.Text = "Exit"
        '
        'frmFirstForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.tbrMain)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "frmFirstForm"
        Me.Text = "Form #1"
        Me.tbrMain.ResumeLayout(False)
        Me.tbrMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tolDisplayPhone As System.Windows.Forms.ToolTip
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents tbrMain As System.Windows.Forms.ToolStrip
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton

End Class
