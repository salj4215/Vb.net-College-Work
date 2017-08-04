'Created by Salleh Jahaf
'Program: Assignment 8 Jefferson Realty
'Program was created to show houses on the market with various details to sort by
'Version 1.01 last updated on 12/17/2015
Option Infer On

Public Class frmDataBase

    'Save button in navigator
    Private Sub TblHomesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblHomesBindingNavigatorSaveItem.Click
        'Show connection error to user
        Try
            Me.Validate()
            Me.TblHomesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.JeffersonRealtyDataSet)
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Jefferson Realty", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JeffersonRealtyDataSet.tblHomes' table. You can move, or remove it, as needed.
        Try
            Me.TblHomesTableAdapter.Fill(Me.JeffersonRealtyDataSet.tblHomes)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Jefferson Realty", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try


    End Sub

    'Only show houses with a certain number of bathrooms selected by user
    Private Sub Number_Of_Bathrooms(sender As Object, e As EventArgs) Handles ddbBathroom1.Click, ddbBathroom2.Click, ddbBathroom3.Click, ddbBathroom4.Click, ddbBathroom5.Click
        Dim tsmSelection As ToolStripMenuItem
        Dim intBathrooms As Integer

        tsmSelection = sender
        intBathrooms = tsmSelection.Tag
        Dim records = From Houses In JeffersonRealtyDataSet.tblHomes
                      Where Houses.NumberOfBathrooms = intBathrooms
                      Select Houses

        TblHomesBindingSource.DataSource = records.AsDataView
    End Sub

    'Show all houses
    Private Sub ddbDisplayAll_Click(sender As Object, e As EventArgs) Handles ddbDisplayAll.Click
        Dim records = From Houses In JeffersonRealtyDataSet.tblHomes
                      Order By Houses.ID
                      Select Houses

        TblHomesBindingSource.DataSource = records.AsDataView
    End Sub

    'Only show houses with a certain number of bedrooms selected by user
    Private Sub ddbBedroom1_Click(sender As Object, e As EventArgs) Handles ddbBedroom1.Click, ddbBedroom2.Click, ddbBedroom3.Click, ddbBedroom4.Click, ddbBedroom5.Click
        Dim tsmSelection As ToolStripMenuItem
        Dim intBedrooms As Integer

        tsmSelection = sender
        intBedrooms = tsmSelection.Tag
        Dim records = From Houses In JeffersonRealtyDataSet.tblHomes
                      Where Houses.NumberOfBedrooms = intBedrooms
                      Select Houses

        TblHomesBindingSource.DataSource = records.AsDataView
    End Sub

    'Only show houses with a certain zipcode selected by user
    Private Sub ddbZipcode4_Click(sender As Object, e As EventArgs) Handles ddbZipcode4.Click, ddbZipcode6.Click, ddbZipcode8.Click
        Dim tsmSelection As ToolStripMenuItem
        Dim intZipcode As Integer

        tsmSelection = sender
        intZipcode = tsmSelection.Tag
        Dim records = From Houses In JeffersonRealtyDataSet.tblHomes
                      Where Houses.Zipcode = intZipcode
                      Select Houses

        TblHomesBindingSource.DataSource = records.AsDataView
    End Sub

    'Display average asking price of all houses
    Private Sub ddbAverageAll_Click(sender As Object, e As EventArgs) Handles ddbAverageAll.Click
        Dim dblAvgHomes As Double =
            Aggregate Houses In JeffersonRealtyDataSet.tblHomes
            Select Houses.AskingPrice Into Average()

        MessageBox.Show("Average asking price for all homes is " & dblAvgHomes.ToString("C2"), "Jefferson Realty", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Display average asking price of houses with a certain zipcode selected by user
    Private Sub ddbAvgZip4_Click(sender As Object, e As EventArgs) Handles ddbAvgZip4.Click, ddbAvgZip6.Click, ddbAvgZip8.Click
        Dim tsmSelection As ToolStripMenuItem
        Dim intZipcode As Integer

        tsmSelection = sender
        intZipcode = tsmSelection.Tag
        Dim dblAvgHomes As Double =
            Aggregate Houses In JeffersonRealtyDataSet.tblHomes
            Where Houses.Zipcode = intZipcode
            Select Houses.AskingPrice Into Average()

        MessageBox.Show("Average asking price in zipcode " & intZipcode.ToString & " is " & dblAvgHomes.ToString("C2"), "Jefferson Realty", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
