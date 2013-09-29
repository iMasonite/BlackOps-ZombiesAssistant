<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssp_SubStatus
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.ssp_MiniStatus = New System.Windows.Forms.StatusStrip()
        Me.ttp_MiniStatus = New System.Windows.Forms.ToolTip(Me.components)
        Me.tsm_MiniStatus = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsm_EnableConnection = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_DisableConnection = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssp_Server = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssp_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssp_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.ssp_MiniStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssp_MiniStatus
        '
        Me.ssp_MiniStatus.BackColor = System.Drawing.Color.LightGray
        Me.ssp_MiniStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ssp_MiniStatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssp_MiniStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssp_Progress, Me.ssp_Server, Me.ssp_Status, Me.tsm_MiniStatus})
        Me.ssp_MiniStatus.Location = New System.Drawing.Point(0, 0)
        Me.ssp_MiniStatus.Name = "ssp_MiniStatus"
        Me.ssp_MiniStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ssp_MiniStatus.Size = New System.Drawing.Size(784, 22)
        Me.ssp_MiniStatus.SizingGrip = False
        Me.ssp_MiniStatus.TabIndex = 0
        Me.ssp_MiniStatus.Text = "Status"
        '
        'ttp_MiniStatus
        '
        Me.ttp_MiniStatus.UseFading = False
        '
        'tsm_MiniStatus
        '
        Me.tsm_MiniStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsm_MiniStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_EnableConnection, Me.tsm_DisableConnection})
        Me.tsm_MiniStatus.Image = Global.BO_Zombies.My.Resources.Resources.icn_settings
        Me.tsm_MiniStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_MiniStatus.Name = "tsm_MiniStatus"
        Me.tsm_MiniStatus.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.tsm_MiniStatus.Size = New System.Drawing.Size(72, 20)
        Me.tsm_MiniStatus.Text = "ToolStripSplitButton1"
        Me.tsm_MiniStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsm_MiniStatus.ToolTipText = "Change Settings..."
        '
        'tsm_EnableConnection
        '
        Me.tsm_EnableConnection.Image = Global.BO_Zombies.My.Resources.Resources.icn_yes
        Me.tsm_EnableConnection.Name = "tsm_EnableConnection"
        Me.tsm_EnableConnection.Size = New System.Drawing.Size(215, 22)
        Me.tsm_EnableConnection.Text = "Enable  Connection"
        '
        'tsm_DisableConnection
        '
        Me.tsm_DisableConnection.Image = Global.BO_Zombies.My.Resources.Resources.icn_no
        Me.tsm_DisableConnection.Name = "tsm_DisableConnection"
        Me.tsm_DisableConnection.Size = New System.Drawing.Size(215, 22)
        Me.tsm_DisableConnection.Text = "Disable Connection"
        '
        'ssp_Server
        '
        Me.ssp_Server.AutoToolTip = True
        Me.ssp_Server.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ssp_Server.Image = Global.BO_Zombies.My.Resources.Resources.icn_server_no
        Me.ssp_Server.Name = "ssp_Server"
        Me.ssp_Server.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ssp_Server.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.ssp_Server.Size = New System.Drawing.Size(214, 17)
        Me.ssp_Server.Text = "Server is - Offline"
        Me.ssp_Server.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ssp_Server.ToolTipText = "Server Connection Status..."
        '
        'ssp_Status
        '
        Me.ssp_Status.AutoToolTip = True
        Me.ssp_Status.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ssp_Status.Image = Global.BO_Zombies.My.Resources.Resources.icn_database
        Me.ssp_Status.Name = "ssp_Status"
        Me.ssp_Status.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.ssp_Status.Size = New System.Drawing.Size(243, 17)
        Me.ssp_Status.Text = "Database is - Installed"
        Me.ssp_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ssp_Status.ToolTipText = "Local Database Connection Status"
        '
        'ssp_Progress
        '
        Me.ssp_Progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ssp_Progress.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.ssp_Progress.Maximum = 200
        Me.ssp_Progress.Name = "ssp_Progress"
        Me.ssp_Progress.Size = New System.Drawing.Size(200, 16)
        Me.ssp_Progress.Step = 2
        Me.ssp_Progress.ToolTipText = "Current Progress of an operation"
        '
        'ssp_SubStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ssp_MiniStatus)
        Me.Name = "ssp_SubStatus"
        Me.Size = New System.Drawing.Size(784, 22)
        Me.ssp_MiniStatus.ResumeLayout(False)
        Me.ssp_MiniStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ssp_MiniStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ssp_Server As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssp_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ttp_MiniStatus As System.Windows.Forms.ToolTip
    Friend WithEvents tsm_MiniStatus As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsm_EnableConnection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_DisableConnection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssp_Progress As System.Windows.Forms.ToolStripProgressBar

End Class
