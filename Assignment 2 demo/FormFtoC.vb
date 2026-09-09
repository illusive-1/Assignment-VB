Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormFtoC
    Inherits Form

    Private lblPrompt As Label
    Private txtInput As TextBox
    Private btnConvert As Button
    Private lblResult As Label
    Private btnClose As Button

    Public Sub New()
        Me.Text = "Fahrenheit to Celsius"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.ClientSize = New Size(380, 160)

        lblPrompt = New Label() With {
            .Text = "Enter temperature in Fahrenheit:",
            .AutoSize = True,
            .Location = New Point(12, 15)
        }

        txtInput = New TextBox() With {
            .Location = New Point(15, 40),
            .Size = New Size(240, 24)
        }

        btnConvert = New Button() With {
            .Text = "Convert",
            .Location = New Point(265, 38),
            .Size = New Size(90, 28)
        }
        AddHandler btnConvert.Click, AddressOf BtnConvert_Click

        lblResult = New Label() With {
            .Text = "",
            .AutoSize = True,
            .Location = New Point(15, 80)
        }

        btnClose = New Button() With {
            .Text = "Close",
            .Location = New Point(265, 100),
            .Size = New Size(90, 28)
        }
        AddHandler btnClose.Click, AddressOf BtnClose_Click

        Me.Controls.Add(lblPrompt)
        Me.Controls.Add(txtInput)
        Me.Controls.Add(btnConvert)
        Me.Controls.Add(lblResult)
        Me.Controls.Add(btnClose)
    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs)
        Dim input As String = txtInput.Text.Trim()
        Dim f As Double
        If Double.TryParse(input, Globalization.NumberStyles.Float, Globalization.CultureInfo.InvariantCulture, f) Then
            Dim c As Double = (f - 32.0) * 5.0 / 9.0
            lblResult.Text = String.Format(Globalization.CultureInfo.InvariantCulture, "{0} °F = {1:0.##} °C", f, c)
        ElseIf Double.TryParse(input, Globalization.NumberStyles.Float, Globalization.CultureInfo.CurrentCulture, f) Then
            Dim c As Double = (f - 32.0) * 5.0 / 9.0
            lblResult.Text = String.Format(Globalization.CultureInfo.CurrentCulture, "{0} °F = {1:0.##} °C", f, c)
        Else
            MessageBox.Show("Please enter a valid number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
