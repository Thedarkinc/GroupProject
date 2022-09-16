Public Class frmMenu
    Public _Work As Work


    Private numWorkers As Integer 'number of workers
    Public Shared numWomen As Integer 'number of women that work there
    Public Shared numDudes As Integer 'number of boys that work there
    Private namework As String  'name of the workplace




    Private Sub BtnWork_Click_1(sender As Object, e As EventArgs) Handles BtnWork.Click

        namework = CStr(InputBox("What is the name of the work Place?"))
        numWomen = CInt(InputBox("How many girls work at " + CStr(namework) + "?"))
        numDudes = CInt(InputBox("How many males work at " + CStr(namework) + "?"))
        numWorkers = numWomen + numDudes
        _Work = New Work(numWomen, numDudes)
        _Work.Names(0)


    End Sub
    Public Function namea() As String
        Return _Work.NameOfWork
    End Function
    Private Sub btnGirlMinions_Click(sender As Object, e As EventArgs) Handles btnGirlMinions.Click

        For i As Integer = 1 To numWomen
            _Work.setPerson(i)
        Next i

    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Dashboard.Show()
        Me.Hide()
        _Work.statsi()
    End Sub

    Private Sub btnMaleMinions_Click(sender As Object, e As EventArgs) Handles btnMaleMinions.Click
        _Work.setPerson()
        _Work.fillupMost()

        _Work.Humeniser()

        _Work.Salaries()
        _Work.TotalSalaray()
        _Work.Mistreatment()
    End Sub

    Private Sub btnSav_Click(sender As Object, e As EventArgs) Handles btnSav.Click
        _Work.Saviour() 'save to file
    End Sub
    'Testing upload
End Class
