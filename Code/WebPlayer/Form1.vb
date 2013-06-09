Public Class Form1

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim URL As String
        URL = "http://www.youtube.com/embed/" + txtUrl.Text
        pnlInstructions.Visible = False
        pnlControl.Visible = False
        MoviePlayer.Visible = True
        MoviePlayer.Navigate(URL)

    End Sub



    Private Sub OpenYoutubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenYoutubeToolStripMenuItem.Click
        pnlControl.Visible = True
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        pnlInstructions.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlControl.Visible = False
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlInstructions.Visible = False
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        If Me.TopMost = True Then
            Me.TopMost = False
            AlwaysOnTopToolStripMenuItem.Checked = False
        Else
            Me.TopMost = True
            AlwaysOnTopToolStripMenuItem.Checked = True
        End If
    End Sub
End Class
