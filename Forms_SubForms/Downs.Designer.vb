<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downs
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Downs))
        Me.dgd_Activity_Log = New System.Windows.Forms.DataGridView()
        Me.btn_Finished = New System.Windows.Forms.Button()
        Me.btn_RemoveSelected = New System.Windows.Forms.Button()
        Me.ttp_DownAndBleed = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.cbx_DownFirst = New System.Windows.Forms.CheckBox()
        Me.gbx_Value_Entry = New System.Windows.Forms.GroupBox()
        Me.lbl_Information = New System.Windows.Forms.Label()
        Me.rdb_Player = New System.Windows.Forms.RadioButton()
        Me.rdb_Self = New System.Windows.Forms.RadioButton()
        Me.ntb_Entry_Value = New BO_Zombies.NumTextBox()
        CType(Me.dgd_Activity_Log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Value_Entry.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgd_Activity_Log
        '
        Me.dgd_Activity_Log.AllowUserToAddRows = False
        Me.dgd_Activity_Log.AllowUserToDeleteRows = False
        Me.dgd_Activity_Log.AllowUserToResizeColumns = False
        Me.dgd_Activity_Log.AllowUserToResizeRows = False
        Me.dgd_Activity_Log.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgd_Activity_Log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgd_Activity_Log.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgd_Activity_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgd_Activity_Log.Location = New System.Drawing.Point(12, 289)
        Me.dgd_Activity_Log.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgd_Activity_Log.MultiSelect = False
        Me.dgd_Activity_Log.Name = "dgd_Activity_Log"
        Me.dgd_Activity_Log.ReadOnly = True
        Me.dgd_Activity_Log.RowHeadersVisible = False
        Me.dgd_Activity_Log.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgd_Activity_Log.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgd_Activity_Log.ShowCellToolTips = False
        Me.dgd_Activity_Log.ShowEditingIcon = False
        Me.dgd_Activity_Log.ShowRowErrors = False
        Me.dgd_Activity_Log.Size = New System.Drawing.Size(402, 175)
        Me.dgd_Activity_Log.TabIndex = 202
        Me.dgd_Activity_Log.TabStop = False
        '
        'btn_Finished
        '
        Me.btn_Finished.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Finished.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Finished.Location = New System.Drawing.Point(208, 468)
        Me.btn_Finished.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Finished.Name = "btn_Finished"
        Me.btn_Finished.Size = New System.Drawing.Size(206, 31)
        Me.btn_Finished.TabIndex = 204
        Me.btn_Finished.Text = "Save and Return"
        Me.btn_Finished.UseVisualStyleBackColor = True
        '
        'btn_RemoveSelected
        '
        Me.btn_RemoveSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_RemoveSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_RemoveSelected.Location = New System.Drawing.Point(12, 468)
        Me.btn_RemoveSelected.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_RemoveSelected.Name = "btn_RemoveSelected"
        Me.btn_RemoveSelected.Size = New System.Drawing.Size(190, 31)
        Me.btn_RemoveSelected.TabIndex = 205
        Me.btn_RemoveSelected.Text = "&Remove Selected Item"
        Me.ttp_DownAndBleed.SetToolTip(Me.btn_RemoveSelected, "Removes the currently selected item in the table (by default the last item is sel" & _
                "ected)")
        Me.btn_RemoveSelected.UseVisualStyleBackColor = True
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_Calculate.Location = New System.Drawing.Point(251, 234)
        Me.btn_Calculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(145, 29)
        Me.btn_Calculate.TabIndex = 206
        Me.btn_Calculate.Text = "Calculate"
        Me.ttp_DownAndBleed.SetToolTip(Me.btn_Calculate, "Removes the currently selected item in the table (by default the last item is sel" & _
                "ected)")
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'cbx_DownFirst
        '
        Me.cbx_DownFirst.AutoSize = True
        Me.cbx_DownFirst.Checked = True
        Me.cbx_DownFirst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_DownFirst.Location = New System.Drawing.Point(251, 209)
        Me.cbx_DownFirst.Name = "cbx_DownFirst"
        Me.cbx_DownFirst.Size = New System.Drawing.Size(86, 20)
        Me.cbx_DownFirst.TabIndex = 210
        Me.cbx_DownFirst.Text = "{ Mode }"
        Me.ttp_DownAndBleed.SetToolTip(Me.cbx_DownFirst, "Check this box if the score to be calculated After the down or Bleedout...")
        Me.cbx_DownFirst.UseVisualStyleBackColor = True
        '
        'gbx_Value_Entry
        '
        Me.gbx_Value_Entry.Controls.Add(Me.cbx_DownFirst)
        Me.gbx_Value_Entry.Controls.Add(Me.rdb_Self)
        Me.gbx_Value_Entry.Controls.Add(Me.rdb_Player)
        Me.gbx_Value_Entry.Controls.Add(Me.lbl_Information)
        Me.gbx_Value_Entry.Controls.Add(Me.btn_Calculate)
        Me.gbx_Value_Entry.Controls.Add(Me.ntb_Entry_Value)
        Me.gbx_Value_Entry.Location = New System.Drawing.Point(12, 12)
        Me.gbx_Value_Entry.MaximumSize = New System.Drawing.Size(402, 272)
        Me.gbx_Value_Entry.MinimumSize = New System.Drawing.Size(402, 272)
        Me.gbx_Value_Entry.Name = "gbx_Value_Entry"
        Me.gbx_Value_Entry.Size = New System.Drawing.Size(402, 272)
        Me.gbx_Value_Entry.TabIndex = 206
        Me.gbx_Value_Entry.TabStop = False
        Me.gbx_Value_Entry.Text = "Value Entry"
        '
        'lbl_Information
        '
        Me.lbl_Information.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Information.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Information.Location = New System.Drawing.Point(7, 22)
        Me.lbl_Information.Name = "lbl_Information"
        Me.lbl_Information.Size = New System.Drawing.Size(389, 183)
        Me.lbl_Information.TabIndex = 209
        Me.lbl_Information.Text = "lbl_Information > Information from RESX"
        '
        'rdb_Player
        '
        Me.rdb_Player.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdb_Player.AutoSize = True
        Me.rdb_Player.Location = New System.Drawing.Point(107, 208)
        Me.rdb_Player.Name = "rdb_Player"
        Me.rdb_Player.Size = New System.Drawing.Size(137, 20)
        Me.rdb_Player.TabIndex = 208
        Me.rdb_Player.Text = "Player Bleedout"
        Me.rdb_Player.UseVisualStyleBackColor = True
        '
        'rdb_Self
        '
        Me.rdb_Self.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdb_Self.AutoSize = True
        Me.rdb_Self.Checked = True
        Me.rdb_Self.Location = New System.Drawing.Point(6, 208)
        Me.rdb_Self.Name = "rdb_Self"
        Me.rdb_Self.Size = New System.Drawing.Size(95, 20)
        Me.rdb_Self.TabIndex = 207
        Me.rdb_Self.TabStop = True
        Me.rdb_Self.Text = "Self Down"
        Me.rdb_Self.UseVisualStyleBackColor = True
        '
        'ntb_Entry_Value
        '
        Me.ntb_Entry_Value.AllowDrop = True
        Me.ntb_Entry_Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ntb_Entry_Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntb_Entry_Value.Location = New System.Drawing.Point(6, 234)
        Me.ntb_Entry_Value.Name = "ntb_Entry_Value"
        Me.ntb_Entry_Value.Size = New System.Drawing.Size(239, 29)
        Me.ntb_Entry_Value.TabIndex = 0
        Me.ntb_Entry_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Downs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(426, 510)
        Me.Controls.Add(Me.gbx_Value_Entry)
        Me.Controls.Add(Me.btn_RemoveSelected)
        Me.Controls.Add(Me.btn_Finished)
        Me.Controls.Add(Me.dgd_Activity_Log)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Downs"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downs and Bleedout"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Crimson
        CType(Me.dgd_Activity_Log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Value_Entry.ResumeLayout(False)
        Me.gbx_Value_Entry.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgd_Activity_Log As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Finished As System.Windows.Forms.Button
    Friend WithEvents btn_RemoveSelected As System.Windows.Forms.Button
    Friend WithEvents ttp_DownAndBleed As System.Windows.Forms.ToolTip
    Friend WithEvents gbx_Value_Entry As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents ntb_Entry_Value As BO_Zombies.NumTextBox
    Friend WithEvents lbl_Information As System.Windows.Forms.Label
    Friend WithEvents rdb_Player As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Self As System.Windows.Forms.RadioButton
    Friend WithEvents cbx_DownFirst As System.Windows.Forms.CheckBox
End Class
