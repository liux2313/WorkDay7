Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click

        Dim population As Double = 7000000000
        Dim year As Integer = 2014

        Do While population > 6000000
            year = year - 50
            population = population / 2
        Loop


        MessageBox.Show("The answer is " & year)

    End Sub
End Class
