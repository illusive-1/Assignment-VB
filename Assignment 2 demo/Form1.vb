Public Class Form1
    Private lblTitle As Label
    Private btnCtoF As Button
    Private btnFtoC As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Temperature Converter"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ClientSize = New Drawing.Size(340, 170)

        lblTitle = New Label() With {
            .Text = "Choose conversion:",
            .AutoSize = True,
            .Location = New Drawing.Point(20, 20),
            .Font = New Drawing.Font("Segoe UI", 10, Drawing.FontStyle.Bold)
        }

        btnCtoF = New Button() With {
            .Text = "Celsius -> Fahrenheit",
            .Size = New Drawing.Size(280, 36),
            .Location = New Drawing.Point(20, 50)
        }
        AddHandler btnCtoF.Click, AddressOf BtnCtoF_Click

        btnFtoC = New Button() With {
            .Text = "Fahrenheit -> Celsius",
            .Size = New Drawing.Size(280, 36),
            .Location = New Drawing.Point(20, 95)
        }
        AddHandler btnFtoC.Click, AddressOf BtnFtoC_Click

        Me.Controls.Add(lblTitle)
        Me.Controls.Add(btnCtoF)
        Me.Controls.Add(btnFtoC)
    End Sub

    Private Sub BtnCtoF_Click(sender As Object, e As EventArgs)
        Dim f As New FormCtoF()
        f.ShowDialog()
    End Sub

    Private Sub BtnFtoC_Click(sender As Object, e As EventArgs)
        Dim f As New FormFtoC()
        f.ShowDialog()
    End Sub
End Class
