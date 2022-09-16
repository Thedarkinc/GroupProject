Option Strict On
Option Explicit On
Option Infer Off


Public Class mostpaid


    Private Sub ComboWorkers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboGirl.SelectedIndexChanged
        lblWorkerName.Text = Work._Female(Work.mostpaid.ComboGirl.SelectedIndex + 1).Name
        lblJobName.Text = Work._Female(Work.mostpaid.ComboGirl.SelectedIndex + 1).JobName
        lblSalaryPrice.Text = "R" + CStr(Work._Female(Work.mostpaid.ComboGirl.SelectedIndex + 1).Salary)
        lblGendername.Text = "FEMALE"
        lblBoolshit.Text = CStr(Work._Female(Work.mostpaid.ComboGirl.SelectedIndex + 1).Mistreated)
        lblAge.Text = CStr(Work._Female(Work.mostpaid.ComboGirl.SelectedIndex + 1).Age)



    End Sub

    Private Sub mostpaid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboMale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMale.SelectedIndexChanged
        lblWorkerName.Text = Work._Male(Work.mostpaid.ComboMale.SelectedIndex + 1).Name
        lblJobName.Text = Work._Male(Work.mostpaid.ComboMale.SelectedIndex + 1).JobName
        lblSalaryPrice.Text = "R" + CStr(Work._Male(Work.mostpaid.ComboMale.SelectedIndex + 1).Salary)
        lblGendername.Text = "MALE"
        lblBoolshit.Text = CStr(Work._Male(Work.mostpaid.ComboMale.SelectedIndex + 1).Mistreated)
        lblAge.Text = CStr(Work._Male(Work.mostpaid.ComboMale.SelectedIndex + 1).Age)
    End Sub
End Class