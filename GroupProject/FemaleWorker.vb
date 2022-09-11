Option Strict On
Option Explicit On
Option Infer Off

Public Class FemaleWorker
    Inherits Worker
    Private _MeternityLeaveDays As Integer 'Meternity leave days
    Private _NormalLeaveDays As Integer    'Normal leave days for women
    Private _Pregnancy As Boolean          'Is she pregnant or not?
    Public Property MeternityLeaveDays() As Integer
        Get
            Return _MeternityLeaveDays
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _MeternityLeaveDays = value
            Else _meternityLeaveDays = 0
            End If
        End Set
    End Property
    Public Property NormalLeaveDays() As Integer
        Get
            Return _NormalLeaveDays
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _NormalLeaveDays = value
            Else
                _NormalLeaveDays = 0
            End If
        End Set
    End Property
    Public Property Pregnancy() As Boolean
        Get
            Return _Pregnancy
        End Get
        Set(value As Boolean)
            _Pregnancy = value
        End Set
    End Property
End Class
