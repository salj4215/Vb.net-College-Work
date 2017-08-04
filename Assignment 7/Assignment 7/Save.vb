Public Class Save
    Private _strCheckNumber As String
    Private _strDate As String
    Private _strAmount As String
    Private _strPayee As String

    'Check number property
    Public Property CheckNumber As String
        Get
            Return _strCheckNumber
        End Get
        Set(value As String)
            _strCheckNumber = value
        End Set
    End Property
    'Check date property
    Public Property CheckDate As String
        Get
            Return _strDate
        End Get
        Set(value As String)
            _strDate = value
        End Set
    End Property
    'Check amount property
    Public Property CheckAmount As String
        Get
            Return _strAmount
        End Get
        Set(value As String)
            _strAmount = value
        End Set
    End Property
    'Check payee property
    Public Property CheckPayee As String
        Get
            Return _strPayee
        End Get
        Set(value As String)
            _strPayee = value
        End Set
    End Property
    'returns amount of checks saved
    Public ReadOnly Property CheckCount As Integer
        Get
            _intSavedRecords = _intSavedRecords + 1
            Return _intSavedRecords
        End Get
    End Property
    'default constructor method
    Public Sub New()
        _strCheckNumber = String.Empty
        _strDate = String.Empty
        _strAmount = String.Empty
        _strPayee = String.Empty
    End Sub
    'constructor method to bring in user data
    Public Sub New(strCN As String, strCD As String, strCA As String, strCP As String)
        CheckNumber = strCN
        CheckDate = strCD
        CheckAmount = strCA
        CheckPayee = strCP
    End Sub

    'saves check to disk file
    Public Function saveCheck() As Boolean
        Dim outFile As IO.StreamWriter
        Dim strOutput As String

        outFile = IO.File.AppendText("Checks.txt")

        strOutput = CheckNumber.PadRight(6) & CheckDate.PadRight(12) & CheckAmount.PadLeft(9) & "   " & CheckPayee.PadRight(30)
        outFile.WriteLine(strOutput)

        outFile.Close()



        Return False


    End Function
End Class
