Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim side1 As Double = CDbl(txtSideOne.Text)
        Dim side2 As Double = CDbl(txtSideTwo.Text)
        Dim hypo As Double

        ' create the funtion
        hypo = Hypotenuse(side1, side2)
        txtHyp.Text = CStr(hypo)

    End Sub
    Function Hypotenuse(ByVal side1 As Double, ByVal side2 As Double) As Double
        Dim h As Double
        h = Math.Sqrt(side1 ^ 2 + side2 ^ 2)
        Return h


    End Function
End Class
