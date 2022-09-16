Public Class infomation
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim outFile As IO.StreamWriter
        outFile = IO.File.AppendText("Empower.txt")
        outFile.Write(CStr(txtboxinfo.Text))
        outFile.Close()

    End Sub
End Class