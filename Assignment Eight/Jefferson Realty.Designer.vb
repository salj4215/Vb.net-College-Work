<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDataBase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataBase))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.JeffersonRealtyDataSet = New Assignment_Eight.JeffersonRealtyDataSet()
        Me.TblHomesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblHomesTableAdapter = New Assignment_Eight.JeffersonRealtyDataSetTableAdapters.tblHomesTableAdapter()
        Me.TableAdapterManager = New Assignment_Eight.JeffersonRealtyDataSetTableAdapters.TableAdapterManager()
        Me.TblHomesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblHomesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ddbNarrowResults = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBathroom1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBathroom2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBathroom3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBathroom4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBathroom5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBedroom1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBedroom2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBedroom3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBedroom4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbBedroom5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbZipcode4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbZipcode6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbZipcode8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbDisplayAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbAvg = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ddbAverageAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByZipcodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbAvgZip4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbAvgZip6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddbAvgZip8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblHomesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.JeffersonRealtyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblHomesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblHomesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblHomesBindingNavigator.SuspendLayout()
        CType(Me.TblHomesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JeffersonRealtyDataSet
        '
        Me.JeffersonRealtyDataSet.DataSetName = "JeffersonRealtyDataSet"
        Me.JeffersonRealtyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblHomesBindingSource
        '
        Me.TblHomesBindingSource.DataMember = "tblHomes"
        Me.TblHomesBindingSource.DataSource = Me.JeffersonRealtyDataSet
        '
        'TblHomesTableAdapter
        '
        Me.TblHomesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblHomesTableAdapter = Me.TblHomesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Assignment_Eight.JeffersonRealtyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblHomesBindingNavigator
        '
        Me.TblHomesBindingNavigator.AddNewItem = Nothing
        Me.TblHomesBindingNavigator.BindingSource = Me.TblHomesBindingSource
        Me.TblHomesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblHomesBindingNavigator.DeleteItem = Nothing
        Me.TblHomesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TblHomesBindingNavigatorSaveItem, Me.ddbNarrowResults, Me.ddbAvg})
        Me.TblHomesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblHomesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblHomesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblHomesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblHomesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblHomesBindingNavigator.Name = "TblHomesBindingNavigator"
        Me.TblHomesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblHomesBindingNavigator.Size = New System.Drawing.Size(518, 25)
        Me.TblHomesBindingNavigator.TabIndex = 0
        Me.TblHomesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblHomesBindingNavigatorSaveItem
        '
        Me.TblHomesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblHomesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblHomesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblHomesBindingNavigatorSaveItem.Name = "TblHomesBindingNavigatorSaveItem"
        Me.TblHomesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblHomesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ddbNarrowResults
        '
        Me.ddbNarrowResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ddbNarrowResults.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ddbDisplayAll})
        Me.ddbNarrowResults.Image = CType(resources.GetObject("ddbNarrowResults.Image"), System.Drawing.Image)
        Me.ddbNarrowResults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbNarrowResults.Name = "ddbNarrowResults"
        Me.ddbNarrowResults.Size = New System.Drawing.Size(130, 22)
        Me.ddbNarrowResults.Text = "&Display Properties By"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ddbBathroom1, Me.ddbBathroom2, Me.ddbBathroom3, Me.ddbBathroom4, Me.ddbBathroom5})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem2.Text = "Number Of Bathrooms"
        '
        'ddbBathroom1
        '
        Me.ddbBathroom1.Name = "ddbBathroom1"
        Me.ddbBathroom1.Size = New System.Drawing.Size(80, 22)
        Me.ddbBathroom1.Tag = "1.0"
        Me.ddbBathroom1.Text = "1"
        '
        'ddbBathroom2
        '
        Me.ddbBathroom2.Name = "ddbBathroom2"
        Me.ddbBathroom2.Size = New System.Drawing.Size(80, 22)
        Me.ddbBathroom2.Tag = "2.0"
        Me.ddbBathroom2.Text = "2"
        '
        'ddbBathroom3
        '
        Me.ddbBathroom3.Name = "ddbBathroom3"
        Me.ddbBathroom3.Size = New System.Drawing.Size(80, 22)
        Me.ddbBathroom3.Tag = "3.0"
        Me.ddbBathroom3.Text = "3"
        '
        'ddbBathroom4
        '
        Me.ddbBathroom4.Name = "ddbBathroom4"
        Me.ddbBathroom4.Size = New System.Drawing.Size(80, 22)
        Me.ddbBathroom4.Tag = "4.0"
        Me.ddbBathroom4.Text = "4"
        '
        'ddbBathroom5
        '
        Me.ddbBathroom5.Name = "ddbBathroom5"
        Me.ddbBathroom5.Size = New System.Drawing.Size(80, 22)
        Me.ddbBathroom5.Tag = "5.0"
        Me.ddbBathroom5.Text = "5"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ddbBedroom1, Me.ddbBedroom2, Me.ddbBedroom3, Me.ddbBedroom4, Me.ddbBedroom5})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem3.Text = "Number Of Bedrooms"
        '
        'ddbBedroom1
        '
        Me.ddbBedroom1.Name = "ddbBedroom1"
        Me.ddbBedroom1.Size = New System.Drawing.Size(80, 22)
        Me.ddbBedroom1.Tag = "1"
        Me.ddbBedroom1.Text = "1"
        '
        'ddbBedroom2
        '
        Me.ddbBedroom2.Name = "ddbBedroom2"
        Me.ddbBedroom2.Size = New System.Drawing.Size(80, 22)
        Me.ddbBedroom2.Tag = "2"
        Me.ddbBedroom2.Text = "2"
        '
        'ddbBedroom3
        '
        Me.ddbBedroom3.Name = "ddbBedroom3"
        Me.ddbBedroom3.Size = New System.Drawing.Size(80, 22)
        Me.ddbBedroom3.Tag = "3"
        Me.ddbBedroom3.Text = "3"
        '
        'ddbBedroom4
        '
        Me.ddbBedroom4.Name = "ddbBedroom4"
        Me.ddbBedroom4.Size = New System.Drawing.Size(80, 22)
        Me.ddbBedroom4.Tag = "4"
        Me.ddbBedroom4.Text = "4"
        '
        'ddbBedroom5
        '
        Me.ddbBedroom5.Name = "ddbBedroom5"
        Me.ddbBedroom5.Size = New System.Drawing.Size(80, 22)
        Me.ddbBedroom5.Tag = "5"
        Me.ddbBedroom5.Text = "5"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ddbZipcode4, Me.ddbZipcode6, Me.ddbZipcode8})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem4.Text = "Zipcode"
        '
        'ddbZipcode4
        '
        Me.ddbZipcode4.Name = "ddbZipcode4"
        Me.ddbZipcode4.Size = New System.Drawing.Size(104, 22)
        Me.ddbZipcode4.Tag = "48124"
        Me.ddbZipcode4.Text = "48124"
        '
        'ddbZipcode6
        '
        Me.ddbZipcode6.Name = "ddbZipcode6"
        Me.ddbZipcode6.Size = New System.Drawing.Size(104, 22)
        Me.ddbZipcode6.Tag = "48126"
        Me.ddbZipcode6.Text = "48126"
        '
        'ddbZipcode8
        '
        Me.ddbZipcode8.Name = "ddbZipcode8"
        Me.ddbZipcode8.Size = New System.Drawing.Size(104, 22)
        Me.ddbZipcode8.Tag = "48128"
        Me.ddbZipcode8.Text = "48128"
        '
        'ddbDisplayAll
        '
        Me.ddbDisplayAll.Name = "ddbDisplayAll"
        Me.ddbDisplayAll.Size = New System.Drawing.Size(195, 22)
        Me.ddbDisplayAll.Text = "Display All"
        '
        'ddbAvg
        '
        Me.ddbAvg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ddbAvg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ddbAverageAll, Me.ByZipcodeToolStripMenuItem})
        Me.ddbAvg.Image = CType(resources.GetObject("ddbAvg.Image"), System.Drawing.Image)
        Me.ddbAvg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbAvg.Name = "ddbAvg"
        Me.ddbAvg.Size = New System.Drawing.Size(128, 22)
        Me.ddbAvg.Text = "A&verage Home Price"
        '
        'ddbAverageAll
        '
        Me.ddbAverageAll.Name = "ddbAverageAll"
        Me.ddbAverageAll.Size = New System.Drawing.Size(152, 22)
        Me.ddbAverageAll.Text = "All Homes"
        '
        'ByZipcodeToolStripMenuItem
        '
        Me.ByZipcodeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ddbAvgZip4, Me.ddbAvgZip6, Me.ddbAvgZip8})
        Me.ByZipcodeToolStripMenuItem.Name = "ByZipcodeToolStripMenuItem"
        Me.ByZipcodeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ByZipcodeToolStripMenuItem.Text = "By Zipcode"
        '
        'ddbAvgZip4
        '
        Me.ddbAvgZip4.Name = "ddbAvgZip4"
        Me.ddbAvgZip4.Size = New System.Drawing.Size(152, 22)
        Me.ddbAvgZip4.Tag = "48124"
        Me.ddbAvgZip4.Text = "48124"
        '
        'ddbAvgZip6
        '
        Me.ddbAvgZip6.Name = "ddbAvgZip6"
        Me.ddbAvgZip6.Size = New System.Drawing.Size(152, 22)
        Me.ddbAvgZip6.Tag = "48126"
        Me.ddbAvgZip6.Text = "48126"
        '
        'ddbAvgZip8
        '
        Me.ddbAvgZip8.Name = "ddbAvgZip8"
        Me.ddbAvgZip8.Size = New System.Drawing.Size(152, 22)
        Me.ddbAvgZip8.Tag = "48128"
        Me.ddbAvgZip8.Text = "48128"
        '
        'TblHomesDataGridView
        '
        Me.TblHomesDataGridView.AllowUserToAddRows = False
        Me.TblHomesDataGridView.AllowUserToDeleteRows = False
        Me.TblHomesDataGridView.AutoGenerateColumns = False
        Me.TblHomesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblHomesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblHomesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblHomesDataGridView.DataSource = Me.TblHomesBindingSource
        Me.TblHomesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblHomesDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.TblHomesDataGridView.Name = "TblHomesDataGridView"
        Me.TblHomesDataGridView.Size = New System.Drawing.Size(518, 290)
        Me.TblHomesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Zipcode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Zipcode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumberOfBedrooms"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bedrooms"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumberOfBathrooms"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Bathrooms"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AskingPrice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Asking Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'frmDataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 315)
        Me.Controls.Add(Me.TblHomesDataGridView)
        Me.Controls.Add(Me.TblHomesBindingNavigator)
        Me.Name = "frmDataBase"
        Me.Text = "Jefferson Realty"
        CType(Me.JeffersonRealtyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblHomesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblHomesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblHomesBindingNavigator.ResumeLayout(False)
        Me.TblHomesBindingNavigator.PerformLayout()
        CType(Me.TblHomesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JeffersonRealtyDataSet As Assignment_Eight.JeffersonRealtyDataSet
    Friend WithEvents TblHomesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblHomesTableAdapter As Assignment_Eight.JeffersonRealtyDataSetTableAdapters.tblHomesTableAdapter
    Friend WithEvents TableAdapterManager As Assignment_Eight.JeffersonRealtyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblHomesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblHomesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblHomesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ddbNarrowResults As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ddbBathroom3 As ToolStripMenuItem
    Friend WithEvents ddbBathroom4 As ToolStripMenuItem
    Friend WithEvents ddbBathroom5 As ToolStripMenuItem
    Friend WithEvents ddbBedroom1 As ToolStripMenuItem
    Friend WithEvents ddbBedroom2 As ToolStripMenuItem
    Friend WithEvents ddbBedroom3 As ToolStripMenuItem
    Friend WithEvents ddbBedroom4 As ToolStripMenuItem
    Friend WithEvents ddbBedroom5 As ToolStripMenuItem
    Friend WithEvents ddbZipcode4 As ToolStripMenuItem
    Friend WithEvents ddbZipcode6 As ToolStripMenuItem
    Friend WithEvents ddbZipcode8 As ToolStripMenuItem
    Friend WithEvents ddbBathroom2 As ToolStripMenuItem
    Friend WithEvents ddbBathroom1 As ToolStripMenuItem
    Friend WithEvents ddbDisplayAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ddbAvg As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ddbAverageAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByZipcodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ddbAvgZip4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ddbAvgZip6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ddbAvgZip8 As System.Windows.Forms.ToolStripMenuItem
End Class
