Option Strict On
Option Explicit On
Option Infer Off

Public MustInherit Class Worker

    Protected _Name As String          'Name of worker
    Protected _Age As Integer             'age of worker
    Protected _Salary() As Double           'salary of worker
    Protected _JobName As String          'JobName or the career
    Protected _YearsExperiance As Integer 'ExPERIANCE IN YEARS
    Protected _AbsentDays As Integer  'Days absent

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
    Public Property AbsentDays() As Integer
        Get
            Return _AbsentDays
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _AbsentDays = value
            Else
                _AbsentDays = 0
            End If
        End Set
    End Property
End Class
