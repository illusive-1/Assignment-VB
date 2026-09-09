Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class MainForm
    Inherits Form

    Private btnCtoF As Button
    Private btnFtoC As Button
    Private lblTitle As Label

    Public Sub New()
        Me.Text = "Temperature Converter"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ClientSize = New Size(320, 160)

        lblTitle = New Label() With {
            .Text = "Choose conversion:",
            .AutoSize = True,
            .Location = New Point(20, 20),
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
        }

        btnCtoF = New Button() With {
            .Text = "Celsius -> Fahrenheit",
            .Size = New Size(260, 36),
            .Location = New Point(20, 50)
        }
        AddHandler btnCtoF.Click, AddressOf BtnCtoF_Click

        btnFtoC = New Button() With {
            .Text = "Fahrenheit -> Celsius",
            .Size = New Size(260, 36),
            .Location = New Point(20, 95)
        }
        AddHandler btnFtoC.Click, AddressOf BtnFtoC_Click

        Me.Controls.Add(lblTitle)
        Me.Controls.Add(btnCtoF)
        Me.Controls.Add(btnFtoC)
    End Sub

    Private Sub BtnCtoF_Click(sender As Object, e As EventArgs)
        Dim f As New CtoFForm()
        f.ShowDialog()
    End Sub

    Private Sub BtnFtoC_Click(sender As Object, e As EventArgs)
        Dim f As New FtoCForm()
        f.ShowDialog()
    End Sub
End Class
