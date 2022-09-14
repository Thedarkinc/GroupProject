Public Class frmMenu
    Shared _Work As Work
    Private numWorkers As Integer 'number of workers
    Private numWomen As Integer 'number of women that work there
    Private numDudes As Integer 'number of boys that work there
    Private namework As String  'name of the workplace




    Private Sub BtnWork_Click_1(sender As Object, e As EventArgs) Handles BtnWork.Click
        namework = CStr(InputBox("What is the name of the workplace?"))
        numWomen = CInt(InputBox("How many girls work at " + CStr(namework) + "?"))
        numDudes = CInt(InputBox("How many males work at " + CStr(namework) + "?"))
        numWorkers = numWomen + numDudes
        _Work = New Work(numWomen, numDudes)

    End Sub
    'Testing upload
End Class
