<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customize))
        Me.tab_Container = New System.Windows.Forms.TabControl()
        Me.tab_Default = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Ssp_SubStatus1 = New BO_Zombies.ssp_SubStatus()
        Me.tab_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_Container
        '
        Me.tab_Container.Controls.Add(Me.tab_Default)
        Me.tab_Container.Controls.Add(Me.TabPage2)
        Me.tab_Container.Dock = System.Windows.Forms.DockStyle.Top
        Me.tab_Container.ItemSize = New System.Drawing.Size(103, 25)
        Me.tab_Container.Location = New System.Drawing.Point(0, 0)
        Me.tab_Container.Name = "tab_Container"
        Me.tab_Container.SelectedIndex = 0
        Me.tab_Container.Size = New System.Drawing.Size(784, 261)
        Me.tab_Container.TabIndex = 0
        '
        'tab_Default
        '
        Me.tab_Default.BackColor = System.Drawing.Color.Silver
        Me.tab_Default.Location = New System.Drawing.Point(4, 29)
        Me.tab_Default.Name = "tab_Default"
        Me.tab_Default.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Default.Size = New System.Drawing.Size(776, 228)
        Me.tab_Default.TabIndex = 0
        Me.tab_Default.Text = "Default Settings"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 228)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Ssp_SubStatus1
        '
        Me.Ssp_SubStatus1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Ssp_SubStatus1.Location = New System.Drawing.Point(0, 442)
        Me.Ssp_SubStatus1.Name = "Ssp_SubStatus1"
        Me.Ssp_SubStatus1.Size = New System.Drawing.Size(784, 22)
        Me.Ssp_SubStatus1.TabIndex = 1
        '
        'Customize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 464)
        Me.Controls.Add(Me.Ssp_SubStatus1)
        Me.Controls.Add(Me.tab_Container)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Customize"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home/Menu/ Customize"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Crimson
        Me.tab_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_Container As System.Windows.Forms.TabControl
    Friend WithEvents tab_Default As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Ssp_SubStatus1 As BO_Zombies.ssp_SubStatus
End Class
