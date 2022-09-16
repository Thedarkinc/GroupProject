Option Strict On
Option Infer Off
Option Explicit On


Public Class Work
    Inherits Worker
    Public Shared mostpaid As mostpaid
    Public Shared Statistics As stats
    Public Shared mostpaidbt2 As mostpaid
    Public Shared mostunpaid As mostpaid

    Private _NumWorkers As Integer        'Number of workers
    Private _NameOfWork As String
    Private _NumWorkdays As Integer       'Number of workdays per month default
    Private _Manager As String            'Name of manager
    Private _BonusMargin As Double        'A percentage for bonuses paid to workers
    Private _NumFemaleWorkers As Integer  'number of female workers
    Private _NumMaleworkers As Integer    'number of male workers
    Public Shared _Female() As FemaleWorker     'composition of femaleworker
    Public Shared _Male() As MaleWorker         'composition of maleworker
    Private _AverageMale As Double        'Male average
    Private _AverageFemale As Double      'Femi average
    Private _TotMale As Double            'Total earning
    Private _TotGirl As Double            'Total earning
    Public Sub New(numFemale As Integer, numMales As Integer)
        ReDim _Female(numFemale)
        ReDim _Male(numMales)
        For i As Integer = 1 To numFemale
            _Female(i) = New FemaleWorker
        Next i
        For r As Integer = 1 To numMales
            _Male(r) = New MaleWorker
        Next r
        _NumFemaleWorkers = numFemale
        _NumMaleworkers = numMales
        mostpaid = New mostpaid
        mostpaidbt2 = New mostpaid
        mostunpaid = New mostpaid

    End Sub
    Public Property NameOfWork() As String
        Get
            Return _NameOfWork
        End Get
        Set(value As String)
            _NameOfWork = value
        End Set
    End Property

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
    Public ReadOnly Property AverageMale() As Double
        Get
            Return _AverageMale
        End Get
    End Property
    Public ReadOnly Property AverageFemale() As Double
        Get
            Return _AverageFemale
        End Get
    End Property
    Public ReadOnly Property TotMale() As Double
        Get
            Return _TotMale
        End Get
    End Property
    Public ReadOnly Property TotGirl() As Double
        Get
            Return _TotGirl
        End Get
    End Property
    Public Overrides Sub Names(n As Integer)


        _Manager = CStr(InputBox("What is the name of the Manager ?"))

    End Sub
    Public Overrides Sub Average()
        For i As Integer = 1 To _NumFemaleWorkers
            _AverageFemale += _Female(i).AverageSalary
        Next i
        For i As Integer = 1 To _NumMaleworkers
            _AverageMale += _Male(i).AverageSalary
        Next i


    End Sub
    Public Sub Salaries()
        For i As Integer = 1 To NumFemaleWorkers


            _Female(i).TotalSalaray()
        Next i
        For i As Integer = 1 To NumMaleWorkers

            _Male(i).TotalSalaray()
        Next i

    End Sub
    Public Overrides Sub TotalSalaray()
        For i As Integer = 1 To NumFemaleWorkers

            _TotGirl += _Female(i).TotalSalary
            _Female(i).TotalSalaray()
        Next i
        For i As Integer = 1 To NumMaleWorkers
            _TotMale += _Male(i).TotalSalary
            _Male(i).TotalSalaray()
        Next i

    End Sub
    Public Sub setPerson(n As Integer)
        Dim Bpregnancy As String
        _Female(n).Names(n)
        _Female(n).MeternityLeaveDays = CInt(InputBox("How many Meternity leave days does " + CStr(_Female(n).Name) + " get?"))
        _Female(n).NormalLeaveDays = CInt(InputBox("How many Normal leave days does " + CStr(_Female(n).Name) + " get?"))
        Bpregnancy = CStr(InputBox("Is she pregnant Though? Enter Y for yes OR N for no"))
        If Bpregnancy.ToLower = "y" Then
            _Female(n).Pregnancy = True
        Else
            _Female(n).Pregnancy = False
        End If

    End Sub

    Public Sub setPerson()
        For i As Integer = 1 To NumMaleWorkers
            _Male(i).Names(i)
            _Male(i).MetenityLeaveDays = CInt(InputBox("How many Meternity leave days does " + CStr(_Male(i).Name) + " get?"))
            _Male(i).NormalLeaveDays = CInt(InputBox("How many Normal leave days does " + CStr(_Male(i).Name) + " get?"))

        Next i
    End Sub


    Public Sub fillupMost()
        For i As Integer = 1 To NumFemaleWorkers
            mostpaid.ComboGirl.Items.Add(_Female(i).Name)
            If _Female(i).Mistreated = True Then
                mostunpaid.ComboGirl.Items.Add(_Female(i).Name)
            Else
                mostpaidbt2.ComboGirl.Items.Add(_Female(i).Name)
            End If
        Next
        For i As Integer = 1 To NumFemaleWorkers
            mostpaid.ComboMale.Items.Add(_Male(i).Name)
        Next




    End Sub

    Public Sub Humeniser()

        For i As Integer = 1 To NumFemaleWorkers
            _Female(i).Average()
        Next i
        For i As Integer = 1 To NumMaleWorkers
            _Male(i).Average()
        Next i
    End Sub

    Public Sub Mistreatment()
        For i As Integer = 1 To NumFemaleWorkers
            If _Female(i).AverageSalary < (_AverageMale + _AverageFemale) / 2 Then
                _Female(i).Mistreated = True
            Else
                Mistreated = False
            End If
        Next i

        For i As Integer = 1 To NumMaleWorkers
            If _Male(i).AverageSalary < (_AverageMale + _AverageFemale) / 2 Then
                _Male(i).Mistreated = True
            Else
                Mistreated = False
            End If
        Next i
    End Sub



    Public Sub statsi()
        Dim pcounter As Integer = 0
        Dim lgCounter As Integer = 0
        Dim womenn As Integer = 0
        Dim wgcounter As Integer = 0
        Dim wmcounter As Integer = 0

        Statistics = New stats

        Statistics.GunaBarDataset3.DataPoints.Update(0, "Males", _TotMale)
        Statistics.GunaBarDataset3.DataPoints.Update(1, "Female", _TotGirl)
        Statistics.InequalityChart.Update()

        For i As Integer = 1 To _NumFemaleWorkers
            Statistics.SalariesDataset.DataPoints.Add(CStr(_Female(i).Name), Math.Round(_Female(i).TotalSalary, 0))
            If _Female(i).Pregnancy = True Then
                pcounter += 1
            End If
            If _Female(i).Mistreated = True Then
                lgCounter += 1
                womenn += 1
            End If
            If _Female(i).AverageSalary < (_TotMale + _TotGirl) * 0.25 Then
                wgcounter += 1
            End If
        Next i

        For i As Integer = 1 To _NumMaleworkers
            Statistics.SalariesDataset.DataPoints.Add(CStr(_Male(i).Name), Math.Round(_Male(i).TotalSalary, 0))
            If _Male(i).Mistreated = True Then
                lgCounter += 1
            End If
            If _Male(i).AverageSalary < (_TotMale + _TotGirl) * 0.25 Then
                wmcounter += 1
            End If
        Next i
        Statistics.payments.Update()
        Statistics.lblPreg.Text = CStr(pcounter) + " women are pregnant"
        Statistics.lblMoreMoney.Text = CStr(_NumMaleworkers + _NumFemaleWorkers - lgCounter) + " people earned more money than others"
        Statistics.lblLessMoneyWomen.Text = CStr(womenn) + " women earned less Money"
        Statistics.lblEarnedLess.Text = CStr(wgcounter + wmcounter) + " earned way less"

    End Sub
    Public Sub Saviour()
        Dim outFile As IO.StreamWriter
        For i As Integer = 1 To _NumFemaleWorkers
            outFile = IO.File.AppendText("Workers.txt")
            outFile.WriteLine(CStr(_Female(i).Name))
            outFile.Close()
        Next i

        For i As Integer = 1 To _NumMaleworkers
            outFile = IO.File.AppendText("Workers.txt")
            outFile.WriteLine(CStr(_Male(i).Name))
            outFile.Close()
        Next i
    End Sub
End Class
