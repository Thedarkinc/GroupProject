Option Strict On
Option Infer Off
Option Explicit On


Public Class Work

    Private _NumWorkers As Integer 'Number of workers
    Private _NumWorkdays As Integer 'Number of workdays per month default
    Private _Manager As String 'Name of manager
    Private _BonusMargin As Double 'a percentage for bonuses paid to workers
    Private _NumFemaleWorkers As Integer 'number of female workers
    Private _NumMaleworkers As Integer    'number of male workers
    Public Property NumWorkers() As Integer
        Get
            Return _NumWorkers
        End Get
        Set(value As Integer)
            If value > 0 Then
                _NumWorkers = value
            End If
        End Set
    End Property
    Public Property NumWorkDays() As Integer
        Get
            Return _NumWorkdays
        End Get
        Set(value As Integer)
            If value > 0 Then
                _NumWorkdays = value
            End If
        End Set
    End Property
    Public Property Manager() As String
        Get
            Return _Manager
        End Get
        Set(value As String)
            _Manager = value
        End Set
    End Property
    Public Property BonusMargin() As Double
        Get
            Return _BonusMargin
        End Get
        Set(value As Double)
            If value >= 0 Then
                _BonusMargin = value
            Else
                _BonusMargin = 0
            End If

        End Set
    End Property
    Public Property NumFemaleWorkers() As Integer
        Get
            Return _NumFemaleWorkers
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _NumFemaleWorkers = value
            End If
        End Set
    End Property
    Public Property NumMaleWorkers() As Integer
        Get
            Return _NumMaleworkers
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _NumMaleworkers = value
            End If
        End Set
    End Property



End Class
