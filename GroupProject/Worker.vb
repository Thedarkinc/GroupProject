Public Class Worker

    Protected _Name As String
    Protected _Age As Integer
    Protected _Salary As Double
    Protected _JobName As String
    Protected _YearsExperiance As Integer
    Protected _AbsentDays As Integer

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


End Class
