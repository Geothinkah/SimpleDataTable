Public Class FrmMain
#Region "Declare the variables"
    'Declare the datatable
    Private ReadOnly TheDataTable As New DataTable
    'Set the Data Directory's path name into DirData
    Private ReadOnly DirData As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
    'Declare the Input variables
    Private BillName As String
    Private BillDatedue As Date
    Private BillAmountDue As Long
    Private BillFrequency As String
#End Region

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDataTableColumns()
        FakeInformation()
    End Sub

    Public Sub CreateDataTableColumns()
        'Create the Columns in the table
        With TheDataTable
            .Columns.Add("Name", Type.GetType("System.String"))
            .Columns.Add("DateDue", Type.GetType("System.DateTime"))
            .Columns.Add("AmountDue", Type.GetType("System.Double"))
            .Columns.Add("Frequency", Type.GetType("System.String"))
        End With
        Text = "Created DataTable Columns"
        DataGridView1.DataSource = TheDataTable
    End Sub

    Public Sub AddTableRow()
        'Create the new table row (record)
        Dim newrow As DataRow = TheDataTable.NewRow
        newrow("Name") = BillName
        newrow("DateDue") = BillDatedue
        newrow("AmountDue") = BillAmountDue
        newrow("Frequency") = BillFrequency
        TheDataTable.Rows.Add(newrow)
    End Sub

    Public Sub FakeInformation()
        BillName = "Capital One"
        BillDatedue = Date.Now
        BillAmountDue = CLng(19.55)
        BillFrequency = "Monthly"
    End Sub

    Private Sub BtnFakeInfo_Click(sender As Object, e As EventArgs) Handles BtnFakeInfo.Click
        FakeInformation()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddTableRow()
    End Sub
End Class
