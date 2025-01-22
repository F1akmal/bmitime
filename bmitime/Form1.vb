Public Class Form1




    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim decBerat, decTinggi, decBmi As Decimal

        decBerat = nudBerat.Value
        decTinggi = nudTinggi.Value

        decBmi = decBerat / (decTinggi ^ 2)

        If decBmi < 18.5 Then
            lblArahan.Text = "Bmi = Kurus" & Environment.NewLine & "Bmi = " & decBmi
        ElseIf decBmi >= 18.5 AndAlso decBmi < 24.9 Then
            lblArahan.Text = "Bmi = Normal" & Environment.NewLine & "Bmi = " & decBmi
        ElseIf decBmi >= 25 AndAlso decBmi < 29.9 Then
            lblArahan.Text = "Bmi = Gemuk" & Environment.NewLine & "Bmi = " & decBmi
        Else
            lblArahan.Text = "Bmi = Obesitas" & Environment.NewLine & "Bmi = " & decBmi
        End If


    End Sub
End Class
