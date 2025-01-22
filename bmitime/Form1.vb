Public Class Form1




    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim dblBerat, dblTinggi, dblBmi As Double

        dblBerat = nudBerat.Value
        dblTinggi = nudTinggi.Value

        dblBmi = dblBerat / (dblTinggi ^ 2)

        If dblBmi < 18.5 Then
            lblArahan.Text = "Bmi = Kurus" & Environment.NewLine & "Bmi = " & dblBmi
        ElseIf dblBmi >= 18.5 AndAlso dblBmi < 24.9 Then
            lblArahan.Text = "Bmi = Normal" & Environment.NewLine & "Bmi = " & dblBmi
        ElseIf dblBmi >= 25 AndAlso dblBmi < 29.9 Then
            lblArahan.Text = "Bmi = Gemuk" & Environment.NewLine & "Bmi = " & dblBmi
        Else
            lblArahan.Text = "Bmi = Obesitas" & Environment.NewLine & "Bmi = " & dblBmi
        End If


    End Sub
End Class
