<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donate))
        Me.pbx_Close = New System.Windows.Forms.PictureBox()
        Me.btn_Donate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_DonateInfo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ntb_DonateAmmount = New BO_Zombies.NumTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.pbx_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbx_Close
        '
        Me.pbx_Close.BackColor = System.Drawing.Color.Transparent
        Me.pbx_Close.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_window_close_white_dark
        Me.pbx_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx_Close.Location = New System.Drawing.Point(458, 2)
        Me.pbx_Close.Margin = New System.Windows.Forms.Padding(0)
        Me.pbx_Close.Name = "pbx_Close"
        Me.pbx_Close.Padding = New System.Windows.Forms.Padding(3)
        Me.pbx_Close.Size = New System.Drawing.Size(30, 30)
        Me.pbx_Close.TabIndex = 0
        Me.pbx_Close.TabStop = False
        '
        'btn_Donate
        '
        Me.btn_Donate.BackColor = System.Drawing.Color.Transparent
        Me.btn_Donate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Donate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Donate.FlatAppearance.BorderSize = 0
        Me.btn_Donate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Donate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_Donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Donate.ForeColor = System.Drawing.Color.Transparent
        Me.btn_Donate.Image = Global.BO_Zombies.My.Resources.Resources.ppb_donate
        Me.btn_Donate.Location = New System.Drawing.Point(346, 138)
        Me.btn_Donate.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Donate.Name = "btn_Donate"
        Me.btn_Donate.Size = New System.Drawing.Size(142, 35)
        Me.btn_Donate.TabIndex = 1
        Me.btn_Donate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Donate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Donate ammount?"
        '
        'lbl_DonateInfo
        '
        Me.lbl_DonateInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_DonateInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DonateInfo.ForeColor = System.Drawing.Color.White
        Me.lbl_DonateInfo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_DonateInfo.Name = "lbl_DonateInfo"
        Me.lbl_DonateInfo.Size = New System.Drawing.Size(443, 82)
        Me.lbl_DonateInfo.TabIndex = 4
        Me.lbl_DonateInfo.Text = "If you like our work on this program then you could give a small token of appreci" & _
            "ation the developing team; you can donate from £1 to any amount you like..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.BO_Zombies.My.Resources.Resources.pp_secure
        Me.PictureBox1.Location = New System.Drawing.Point(139, 191)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 37)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ntb_DonateAmmount
        '
        Me.ntb_DonateAmmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntb_DonateAmmount.Location = New System.Drawing.Point(194, 141)
        Me.ntb_DonateAmmount.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.ntb_DonateAmmount.Name = "ntb_DonateAmmount"
        Me.ntb_DonateAmmount.Size = New System.Drawing.Size(104, 29)
        Me.ntb_DonateAmmount.TabIndex = 2
        Me.ntb_DonateAmmount.Text = "1"
        Me.ntb_DonateAmmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(295, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = ".00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(167, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "£"
        '
        'Donate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.SplashScreenBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(494, 244)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_DonateInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ntb_DonateAmmount)
        Me.Controls.Add(Me.btn_Donate)
        Me.Controls.Add(Me.pbx_Close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 250)
        Me.Name = "Donate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Crimson
        CType(Me.pbx_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbx_Close As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Donate As System.Windows.Forms.Button
    Friend WithEvents ntb_DonateAmmount As BO_Zombies.NumTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_DonateInfo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
