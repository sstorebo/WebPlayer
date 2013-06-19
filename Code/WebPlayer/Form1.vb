Imports System.Text.RegularExpressions

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



    Private Sub OpenNetflixToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNetflixToolStripMenuItem.Click
        Me.Width = 1200
        Me.Height = 1000
        MoviePlayer.Visible = True
        MoviePlayer.Navigate("http://www.netflix.com")
    End Sub

    Private Sub MoviePlayer_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles MoviePlayer.DocumentCompleted
        Dim str As String = MoviePlayer.Url.ToString()
        lblURL.Text = MoviePlayer.Url.ToString()
        Dim m As Match = Regex.Match(str, "tctx=")
        If (m.Success) Then
            lblDebug.Text = m.Result("FOUND")
            Me.Width = 1200
            Me.Height = 700
        Else
            lblDebug.Text = "NOTFOUND"
            Me.Width = 1200
            Me.Height = 1000
        End If

    End Sub


    Private Sub EnableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableToolStripMenuItem.Click
        If lblDebug.Visible = False Or lblURL.Visible = False Then
            lblDebug.Visible = True
            lblURL.Visible = True
            EnableToolStripMenuItem.Checked = True
        Else
            lblDebug.Visible = False
            lblURL.Visible = False
            EnableToolStripMenuItem.Checked = False
        End If
    End Sub
End Class
