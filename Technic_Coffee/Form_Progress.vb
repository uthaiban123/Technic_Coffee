Public Class Form_Progress
    Private Sub Form_Progress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progressBar()
    End Sub
    Private Sub progressBar()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rt As Boolean = False
        Timer1.Interval = 50
        If ProgressBar1.Value <= 100 Then
            ProgressBar1.Value += 1
            Me.Text = "Loading..." & ProgressBar1.Value & "%"
            If ProgressBar1.Value = 100 Then
                ProgressBar1.Value = 0
                Timer1.Stop()
                Form1.Show()
                Me.Dispose()
            End If
        End If
    End Sub
End Class