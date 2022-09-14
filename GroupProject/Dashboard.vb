Public Class Dashboard
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        setcol(1)

    End Sub
    Private Sub setcol(ByVal butt As Integer)

        If butt = 1 Then
            Guna2Button1.FillColor = Color.White
            Guna2Button1.ForeColor = Color.Black

            'Button 4
            Guna2Button4.FillColor = Color.RoyalBlue
            Guna2Button4.ForeColor = Color.White
            'Button 2
            Guna2Button2.FillColor = Color.RoyalBlue
            Guna2Button2.ForeColor = Color.White
            'Button 3
            Guna2Button3.FillColor = Color.RoyalBlue
            Guna2Button3.ForeColor = Color.White

        End If
        If butt = 2 Then
            Guna2Button2.FillColor = Color.White
            Guna2Button2.ForeColor = Color.Black



            'Button 1
            Guna2Button1.FillColor = Color.RoyalBlue
            Guna2Button1.ForeColor = Color.White
            'Button 3
            Guna2Button3.FillColor = Color.RoyalBlue
            Guna2Button3.ForeColor = Color.White
            'Button 4
            Guna2Button4.FillColor = Color.RoyalBlue
            Guna2Button4.ForeColor = Color.White





        End If
        If butt = 3 Then
            Guna2Button3.FillColor = Color.White
            Guna2Button3.ForeColor = Color.Black


            'Button 1
            Guna2Button1.FillColor = Color.RoyalBlue
            Guna2Button1.ForeColor = Color.White
            'Button 2
            Guna2Button2.FillColor = Color.RoyalBlue
            Guna2Button2.ForeColor = Color.White
            'Button 4
            Guna2Button4.FillColor = Color.RoyalBlue
            Guna2Button4.ForeColor = Color.White

        End If
        If butt = 4 Then
            Guna2Button4.FillColor = Color.White
            Guna2Button4.ForeColor = Color.Black


            'Button 1
            Guna2Button1.FillColor = Color.RoyalBlue
            Guna2Button1.ForeColor = Color.White
            'Button 2
            Guna2Button2.FillColor = Color.RoyalBlue
            Guna2Button2.ForeColor = Color.White
            'Button 3
            Guna2Button3.FillColor = Color.RoyalBlue
            Guna2Button3.ForeColor = Color.White



        End If

    End Sub




    Private Sub Dashboard_Load(sender As Object, e As EventArgs)
        Guna2Button1.PerformClick()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        setcol(2)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        setcol(3)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        setcol(4)
    End Sub




End Class