<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MoviePlayer = New System.Windows.Forms.WebBrowser()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlInstructions = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenYoutubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenNetflixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblURL = New System.Windows.Forms.Label()
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.EnableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlControl.SuspendLayout()
        Me.pnlInstructions.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MoviePlayer
        '
        Me.MoviePlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MoviePlayer.Location = New System.Drawing.Point(0, 24)
        Me.MoviePlayer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MoviePlayer.Name = "MoviePlayer"
        Me.MoviePlayer.Size = New System.Drawing.Size(730, 403)
        Me.MoviePlayer.TabIndex = 0
        Me.MoviePlayer.Visible = False
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(3, 58)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(128, 42)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(6, 32)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(195, 20)
        Me.txtUrl.TabIndex = 2
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlControl.Controls.Add(Me.Button1)
        Me.pnlControl.Controls.Add(Me.Label1)
        Me.pnlControl.Controls.Add(Me.btnLoad)
        Me.pnlControl.Controls.Add(Me.txtUrl)
        Me.pnlControl.Location = New System.Drawing.Point(48, 93)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(215, 110)
        Me.pnlControl.TabIndex = 3
        Me.pnlControl.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the Youtube Code: <yF00hjC2Xeg>"
        '
        'pnlInstructions
        '
        Me.pnlInstructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlInstructions.Controls.Add(Me.Button2)
        Me.pnlInstructions.Controls.Add(Me.Label2)
        Me.pnlInstructions.Location = New System.Drawing.Point(301, 58)
        Me.pnlInstructions.Name = "pnlInstructions"
        Me.pnlInstructions.Size = New System.Drawing.Size(350, 276)
        Me.pnlInstructions.TabIndex = 4
        Me.pnlInstructions.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 42)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "How to use:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMenuToolStripMenuItem, Me.HelpToolStripMenuItem, Me.HelpToolStripMenuItem1, Me.DebugToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(730, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenMenuToolStripMenuItem
        '
        Me.OpenMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenYoutubeToolStripMenuItem, Me.OpenNetflixToolStripMenuItem})
        Me.OpenMenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.OpenMenuToolStripMenuItem.Name = "OpenMenuToolStripMenuItem"
        Me.OpenMenuToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.OpenMenuToolStripMenuItem.Text = "File"
        '
        'OpenYoutubeToolStripMenuItem
        '
        Me.OpenYoutubeToolStripMenuItem.Name = "OpenYoutubeToolStripMenuItem"
        Me.OpenYoutubeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OpenYoutubeToolStripMenuItem.Text = "Open Youtube"
        '
        'OpenNetflixToolStripMenuItem
        '
        Me.OpenNetflixToolStripMenuItem.Name = "OpenNetflixToolStripMenuItem"
        Me.OpenNetflixToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OpenNetflixToolStripMenuItem.Text = "Open Netflix"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysOnTopToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.HelpToolStripMenuItem.Text = "Options"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always on Top"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableToolStripMenuItem})
        Me.DebugToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'lblURL
        '
        Me.lblURL.AutoSize = True
        Me.lblURL.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblURL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblURL.Location = New System.Drawing.Point(259, 5)
        Me.lblURL.Name = "lblURL"
        Me.lblURL.Size = New System.Drawing.Size(49, 16)
        Me.lblURL.TabIndex = 5
        Me.lblURL.Text = "DEBUG:"
        Me.lblURL.Visible = False
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebug.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDebug.Location = New System.Drawing.Point(258, 24)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(49, 16)
        Me.lblDebug.TabIndex = 7
        Me.lblDebug.Text = "DEBUG:"
        Me.lblDebug.Visible = False
        '
        'EnableToolStripMenuItem
        '
        Me.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem"
        Me.EnableToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnableToolStripMenuItem.Text = "Enable"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(730, 427)
        Me.Controls.Add(Me.lblDebug)
        Me.Controls.Add(Me.lblURL)
        Me.Controls.Add(Me.pnlInstructions)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.MoviePlayer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "WebPlayer"
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        Me.pnlInstructions.ResumeLayout(False)
        Me.pnlInstructions.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MoviePlayer As System.Windows.Forms.WebBrowser
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlInstructions As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenYoutubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenNetflixToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblURL As System.Windows.Forms.Label
    Friend WithEvents lblDebug As System.Windows.Forms.Label
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
