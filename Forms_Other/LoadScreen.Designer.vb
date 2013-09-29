<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadScreen
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
        Me.components = New System.ComponentModel.Container
        Me.Version = New System.Windows.Forms.Label
        Me.Copyright = New System.Windows.Forms.Label
        Me.ApplicationTitle = New System.Windows.Forms.Label
        Me.Name1Info = New System.Windows.Forms.Label
        Me.Name1 = New System.Windows.Forms.Label
        Me.Name2info = New System.Windows.Forms.Label
        Me.Name2 = New System.Windows.Forms.Label
        Me.pgb_LoadTimer = New System.Windows.Forms.ProgressBar
        Me.tmr_LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Loading = New System.Windows.Forms.Label
        Me.btn_Continue = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_ExitApp = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_Close = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.White
        Me.Version.Location = New System.Drawing.Point(12, 82)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(774, 66)
        Me.Version.TabIndex = 26
        Me.Version.Text = "Version {0}.{1:00}"
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.Location = New System.Drawing.Point(12, 53)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(774, 29)
        Me.Copyright.TabIndex = 25
        Me.Copyright.Text = "Copyright"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.White
        Me.ApplicationTitle.Location = New System.Drawing.Point(12, 24)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(774, 29)
        Me.ApplicationTitle.TabIndex = 27
        Me.ApplicationTitle.Text = "Application Title"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Name1Info
        '
        Me.Name1Info.BackColor = System.Drawing.Color.Transparent
        Me.Name1Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1Info.ForeColor = System.Drawing.Color.White
        Me.Name1Info.Location = New System.Drawing.Point(7, 44)
        Me.Name1Info.Name = "Name1Info"
        Me.Name1Info.Size = New System.Drawing.Size(209, 16)
        Me.Name1Info.TabIndex = 28
        Me.Name1Info.Text = "PSN: INSURRECTION1ST"
        '
        'Name1
        '
        Me.Name1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Name1.BackColor = System.Drawing.Color.Transparent
        Me.Name1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1.ForeColor = System.Drawing.Color.White
        Me.Name1.Location = New System.Drawing.Point(250, 18)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(209, 26)
        Me.Name1.TabIndex = 29
        Me.Name1.Text = "C. Kravitz"
        '
        'Name2info
        '
        Me.Name2info.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Name2info.BackColor = System.Drawing.Color.Transparent
        Me.Name2info.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name2info.ForeColor = System.Drawing.Color.White
        Me.Name2info.Location = New System.Drawing.Point(272, 60)
        Me.Name2info.Name = "Name2info"
        Me.Name2info.Size = New System.Drawing.Size(209, 16)
        Me.Name2info.TabIndex = 30
        Me.Name2info.Text = "Designer and Researcher"
        '
        'Name2
        '
        Me.Name2.BackColor = System.Drawing.Color.Transparent
        Me.Name2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name2.ForeColor = System.Drawing.Color.White
        Me.Name2.Location = New System.Drawing.Point(6, 18)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(209, 26)
        Me.Name2.TabIndex = 31
        Me.Name2.Text = "M. J. Mason."
        '
        'pgb_LoadTimer
        '
        Me.pgb_LoadTimer.Location = New System.Drawing.Point(16, 415)
        Me.pgb_LoadTimer.Name = "pgb_LoadTimer"
        Me.pgb_LoadTimer.Size = New System.Drawing.Size(770, 23)
        Me.pgb_LoadTimer.TabIndex = 32
        '
        'tmr_LoadTimer
        '
        '
        'Loading
        '
        Me.Loading.BackColor = System.Drawing.Color.Transparent
        Me.Loading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loading.ForeColor = System.Drawing.Color.White
        Me.Loading.Location = New System.Drawing.Point(13, 396)
        Me.Loading.Name = "Loading"
        Me.Loading.Size = New System.Drawing.Size(197, 15)
        Me.Loading.TabIndex = 33
        Me.Loading.Text = "Loading Info..."
        '
        'btn_Continue
        '
        Me.btn_Continue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Continue.Location = New System.Drawing.Point(647, 444)
        Me.btn_Continue.Name = "btn_Continue"
        Me.btn_Continue.Size = New System.Drawing.Size(139, 30)
        Me.btn_Continue.TabIndex = 34
        Me.btn_Continue.Text = "Open Home"
        Me.btn_Continue.UseVisualStyleBackColor = True
        Me.btn_Continue.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Designer and Developer"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(251, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "PSN: cremoney"
        '
        'btn_ExitApp
        '
        Me.btn_ExitApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExitApp.Location = New System.Drawing.Point(16, 444)
        Me.btn_ExitApp.Name = "btn_ExitApp"
        Me.btn_ExitApp.Size = New System.Drawing.Size(139, 30)
        Me.btn_ExitApp.TabIndex = 37
        Me.btn_ExitApp.Text = "Exit Application"
        Me.btn_ExitApp.UseVisualStyleBackColor = True
        Me.btn_ExitApp.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Name2)
        Me.GroupBox1.Controls.Add(Me.Name1Info)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Name1)
        Me.GroupBox1.Controls.Add(Me.Name2info)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 89)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credits  To:"
        '
        'btn_Close
        '
        Me.btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.Location = New System.Drawing.Point(502, 444)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(139, 30)
        Me.btn_Close.TabIndex = 39
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        Me.btn_Close.Visible = False
        '
        'LoadScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Zombies_MOON.My.Resources.Resources.SplashScreenBG
        Me.ClientSize = New System.Drawing.Size(798, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_ExitApp)
        Me.Controls.Add(Me.btn_Continue)
        Me.Controls.Add(Me.Loading)
        Me.Controls.Add(Me.pgb_LoadTimer)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Copyright)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoadScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Name1Info As System.Windows.Forms.Label
    Friend WithEvents Name1 As System.Windows.Forms.Label
    Friend WithEvents Name2info As System.Windows.Forms.Label
    Friend WithEvents Name2 As System.Windows.Forms.Label
    Friend WithEvents pgb_LoadTimer As System.Windows.Forms.ProgressBar
    Friend WithEvents tmr_LoadTimer As System.Windows.Forms.Timer
    Friend WithEvents Loading As System.Windows.Forms.Label
    Friend WithEvents btn_Continue As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_ExitApp As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Close As System.Windows.Forms.Button

End Class
