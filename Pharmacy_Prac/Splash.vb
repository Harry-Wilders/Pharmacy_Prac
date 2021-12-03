Public Class SplashForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Interval = 150

        StartProgressBar.Value = StartProgressBar.Value + 1

        If StartProgressBar.Value >= 100 Then
            Timer1.Stop()
            Me.Hide()

            Dim log = New LoginForm
            log.Show()
            Timer1.Enabled = False


        End If

    End Sub



    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartProgressBar.Maximum = 100
        StartProgressBar.Minimum = 0

        Timer1.Enabled = True


    End Sub
End Class
