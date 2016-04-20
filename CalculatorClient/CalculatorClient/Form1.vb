Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objConv As New Calculator.Calculator
        Dim a As Double
        Dim b As Double
        a = CDbl(TextBox1.Text)
        b = CDbl(TextBox2.Text)
        TextBox1.Text = objConv.add(a, b)
        TextBox3.Text = objConv.add(a, b)
        TextBox2.Text = "0"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objConv As New Calculator.Calculator
        Dim a As Double
        Dim b As Double
        a = CDbl(TextBox1.Text)
        b = CDbl(TextBox2.Text)
        TextBox1.Text = objConv.subtract(a, b)
        TextBox3.Text = objConv.subtract(a, b)
        TextBox2.Text = "0"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim objConv As New Calculator.Calculator
        Dim a As Double
        Dim b As Double
        a = CDbl(TextBox1.Text)
        b = CDbl(TextBox2.Text)
        TextBox1.Text = objConv.multiply(a, b)
        TextBox3.Text = objConv.multiply(a, b)
        TextBox2.Text = "0"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim objConv As New Calculator.Calculator
        Dim a As Double
        Dim b As Double
        a = CDbl(TextBox1.Text)
        b = CDbl(TextBox2.Text)
        If b = 0 Then
            MsgBox("Cannot Divide By Zero", 0, "ERROR!")
            Return
        End If
        TextBox1.Text = objConv.divide(a, b)
        TextBox3.Text = objConv.divide(a, b)
        TextBox2.Text = "0"

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"
    End Sub
End Class
