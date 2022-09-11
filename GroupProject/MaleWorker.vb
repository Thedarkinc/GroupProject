Option Strict On
Option Explicit On
Option Infer Off


Public Class MaleWorker
    Inherits Worker

    Private _NormalLeaveDays As Integer 'Normal leave days for males
    Private _MetenityLeaveDays As Integer 'To take care of the wife because men dont get pregnant
    Sub New()

    End Sub

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
    Public Property MetenityLeaveDays() As Integer
        Get
            Return _MetenityLeaveDays
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _MetenityLeaveDays = value
            Else
                _MetenityLeaveDays = 0
            End If
        End Set
    End Property
End Class
