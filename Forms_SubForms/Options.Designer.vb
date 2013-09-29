<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.Ssp_SubStatus1 = New BO_Zombies.ssp_SubStatus()
        Me.SuspendLayout()
        '
        'Ssp_SubStatus1
        '
        Me.Ssp_SubStatus1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Ssp_SubStatus1.Location = New System.Drawing.Point(0, 442)
        Me.Ssp_SubStatus1.Name = "Ssp_SubStatus1"
        Me.Ssp_SubStatus1.Size = New System.Drawing.Size(784, 22)
        Me.Ssp_SubStatus1.TabIndex = 0
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 464)
        Me.Controls.Add(Me.Ssp_SubStatus1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home/Menu/ Options"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Crimson
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ssp_SubStatus1 As BO_Zombies.ssp_SubStatus
End Class
