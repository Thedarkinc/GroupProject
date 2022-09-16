Option Strict On
Option Explicit On
Option Infer Off

Public MustInherit Class Worker

    Protected _Name As String          'Name of worker
    Protected _Age As Integer             'age of worker
    Protected _Salary As Double           'salary of worker
    Protected _JobName As String          'JobName or the career
    Protected _YearsExperiance As Integer 'ExPERIANCE IN YEARS
    Protected _AbsentDays() As Integer  'Days absent permonth
    Protected _AverageSalary As Double 'Average salary
    Protected _TotalSalary As Double 'Total salary
    Protected _Mistreated As Boolean
    Protected _Monthly() As Double

    Public Property Monthly(index As Integer) As Double
        Get
            Return _Monthly(index)
        End Get
        Set(value As Double)
            _Monthly(index) = value
        End Set
    End Property
    Public Property Mistreated() As Boolean
        Get
            Return _Mistreated
        End Get
        Set(value As Boolean)
            _Mistreated = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property
    Public Property Age() As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            _Age = value
        End Set
    End Property
    Public Property Salary() As Double
        Get
            Return _Salary
        End Get
        Set(value As Double)
            If value >= 0 Then
                _Salary = value
            Else
                _Salary = 0
            End If
        End Set
    End Property
    Public Property JobName() As String
        Get
            Return _JobName
        End Get
        Set(value As String)
            _JobName = value
        End Set
    End Property
    Public Property YearsExperiance() As Integer
        Get
            Return _YearsExperiance
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _YearsExperiance = value
            Else
                _YearsExperiance = 0
            End If
        End Set
    End Property
    Public Property AbsentDays(index As Integer) As Integer
        Get
            Return _AbsentDays(index)
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _AbsentDays(index) = value
            Else
                _AbsentDays(index) = 0
            End If
        End Set
    End Property
    Public ReadOnly Property AverageSalary() As Double
        Get
            Return _AverageSalary
        End Get
    End Property

    Public ReadOnly Property TotalSalary() As Double
        Get
            Return _TotalSalary
        End Get
    End Property
    Public Overridable Sub Average() 'Called

        For i As Integer = 1 To 12
            _AverageSalary += (_Salary - ((_Salary / 30) * _AbsentDays(i))) / 12
        Next i

    End Sub

    Public Overridable Sub TotalSalaray() 'Called
        ReDim _Monthly(12)

        For i As Integer = 1 To 12
            Monthly(i) = _Salary - (_Salary / 30) * _AbsentDays(1)
        Next i
        _TotalSalary = _AverageSalary * 12
    End Sub
    Public Overridable Sub Names(n As Integer) 'called
        ReDim _AbsentDays(12)
        _Name = CStr(InputBox("What is the name of worker " + CStr(n) + "?"))
        _JobName = CStr(InputBox("What Job does " + _Name + " do?"))
        _Age = CInt(InputBox("What Age is " + CStr(_Name) + "?"))
        _Salary = CDbl(InputBox("How much does " + _Name + " Earn?"))
        For i As Integer = 1 To 12
            _AbsentDays(i) = CInt(InputBox("How many days was " + CStr(_Name) + " Absent in month " + CStr(i)))
        Next i
    End Sub
End Class
