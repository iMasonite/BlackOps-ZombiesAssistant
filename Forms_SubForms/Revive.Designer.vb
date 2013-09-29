<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Revive
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Revive))
        Me.btn_ReviveCalcs_Finished = New System.Windows.Forms.Button
        Me.dgd_Activity_Log = New System.Windows.Forms.DataGridView
        Me.ttp_Revive = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbx_Entry = New System.Windows.Forms.GroupBox
        Me.lbl_Score_End = New System.Windows.Forms.Label
        Me.lbl_Score_Start = New System.Windows.Forms.Label
        Me.btn_Calculate = New System.Windows.Forms.Button
        Me.lbl_Information_Start_Body = New System.Windows.Forms.Label
        Me.lbl_Information_End_Body = New System.Windows.Forms.Label
        Me.gbx_Information = New System.Windows.Forms.GroupBox
        Me.lbl_Information_End_Title = New System.Windows.Forms.Label
        Me.lbl_Information_Start_Title = New System.Windows.Forms.Label
        Me.lbl_Score_Revive = New System.Windows.Forms.Label
        Me.lbl_Score_Revive_Lable = New System.Windows.Forms.Label
        Me.lbl_Score_Maximum = New System.Windows.Forms.Label
        Me.lbl_Score_Maximum_Lable = New System.Windows.Forms.Label
        Me.btn_Clear_Selected = New System.Windows.Forms.Button
        Me.ntb_Score_End = New BO_Zombies.NumTextBox
        Me.ntb_Score_Start = New BO_Zombies.NumTextBox
        CType(Me.dgd_Activity_Log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Entry.SuspendLayout()
        Me.gbx_Information.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ReviveCalcs_Finished
        '
        Me.btn_ReviveCalcs_Finished.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ReviveCalcs_Finished.Location = New System.Drawing.Point(318, 489)
        Me.btn_ReviveCalcs_Finished.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ReviveCalcs_Finished.Name = "btn_ReviveCalcs_Finished"
        Me.btn_ReviveCalcs_Finished.Size = New System.Drawing.Size(184, 31)
        Me.btn_ReviveCalcs_Finished.TabIndex = 5
        Me.btn_ReviveCalcs_Finished.Text = "&Finished - (Save and Return)"
        Me.btn_ReviveCalcs_Finished.UseVisualStyleBackColor = True
        '
        'dgd_Activity_Log
        '
        Me.dgd_Activity_Log.AllowUserToAddRows = False
        Me.dgd_Activity_Log.AllowUserToDeleteRows = False
        Me.dgd_Activity_Log.AllowUserToResizeColumns = False
        Me.dgd_Activity_Log.AllowUserToResizeRows = False
        Me.dgd_Activity_Log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgd_Activity_Log.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgd_Activity_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgd_Activity_Log.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgd_Activity_Log.Location = New System.Drawing.Point(13, 277)
        Me.dgd_Activity_Log.Margin = New System.Windows.Forms.Padding(4)
        Me.dgd_Activity_Log.MultiSelect = False
        Me.dgd_Activity_Log.Name = "dgd_Activity_Log"
        Me.dgd_Activity_Log.ReadOnly = True
        Me.dgd_Activity_Log.RowHeadersVisible = False
        Me.dgd_Activity_Log.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgd_Activity_Log.Size = New System.Drawing.Size(490, 142)
        Me.dgd_Activity_Log.TabIndex = 199
        Me.dgd_Activity_Log.TabStop = False
        '
        'gbx_Entry
        '
        Me.gbx_Entry.Controls.Add(Me.lbl_Score_End)
        Me.gbx_Entry.Controls.Add(Me.ntb_Score_End)
        Me.gbx_Entry.Controls.Add(Me.lbl_Score_Start)
        Me.gbx_Entry.Controls.Add(Me.ntb_Score_Start)
        Me.gbx_Entry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Entry.Location = New System.Drawing.Point(13, 145)
        Me.gbx_Entry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.gbx_Entry.Name = "gbx_Entry"
        Me.gbx_Entry.Padding = New System.Windows.Forms.Padding(4)
        Me.gbx_Entry.Size = New System.Drawing.Size(490, 82)
        Me.gbx_Entry.TabIndex = 200
        Me.gbx_Entry.TabStop = False
        Me.gbx_Entry.Text = "Values Entry"
        '
        'lbl_Score_End
        '
        Me.lbl_Score_End.AutoSize = True
        Me.lbl_Score_End.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Score_End.Location = New System.Drawing.Point(277, 23)
        Me.lbl_Score_End.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_Score_End.Name = "lbl_Score_End"
        Me.lbl_Score_End.Size = New System.Drawing.Size(93, 20)
        Me.lbl_Score_End.TabIndex = 3
        Me.lbl_Score_End.Text = "Score End"
        Me.lbl_Score_End.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_Score_End.UseMnemonic = False
        '
        'lbl_Score_Start
        '
        Me.lbl_Score_Start.AutoSize = True
        Me.lbl_Score_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Score_Start.Location = New System.Drawing.Point(31, 23)
        Me.lbl_Score_Start.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_Score_Start.Name = "lbl_Score_Start"
        Me.lbl_Score_Start.Size = New System.Drawing.Size(101, 20)
        Me.lbl_Score_Start.TabIndex = 1
        Me.lbl_Score_Start.Text = "Score Start"
        Me.lbl_Score_Start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_Score_Start.UseMnemonic = False
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calculate.Location = New System.Drawing.Point(175, 231)
        Me.btn_Calculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(167, 38)
        Me.btn_Calculate.TabIndex = 202
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'lbl_Information_Start_Body
        '
        Me.lbl_Information_Start_Body.BackColor = System.Drawing.Color.LightGray
        Me.lbl_Information_Start_Body.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Information_Start_Body.Location = New System.Drawing.Point(7, 44)
        Me.lbl_Information_Start_Body.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_Information_Start_Body.Name = "lbl_Information_Start_Body"
        Me.lbl_Information_Start_Body.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_Information_Start_Body.Size = New System.Drawing.Size(231, 69)
        Me.lbl_Information_Start_Body.TabIndex = 202
        Me.lbl_Information_Start_Body.Text = "The value needed here is the value BEFORE you start to down yourself where your s" & _
            "core is at its highest.."
        Me.lbl_Information_Start_Body.UseMnemonic = False
        '
        'lbl_Information_End_Body
        '
        Me.lbl_Information_End_Body.BackColor = System.Drawing.Color.LightGray
        Me.lbl_Information_End_Body.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Information_End_Body.Location = New System.Drawing.Point(253, 44)
        Me.lbl_Information_End_Body.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_Information_End_Body.Name = "lbl_Information_End_Body"
        Me.lbl_Information_End_Body.Padding = New System.Windows.Forms.Padding(4)
        Me.lbl_Information_End_Body.Size = New System.Drawing.Size(231, 69)
        Me.lbl_Information_End_Body.TabIndex = 203
        Me.lbl_Information_End_Body.Text = "The value needed here is the value AFTER you have finished downing yourself, wher" & _
            "e your score is at its Lowest.."
        Me.lbl_Information_End_Body.UseMnemonic = False
        '
        'gbx_Information
        '
        Me.gbx_Information.Controls.Add(Me.lbl_Information_End_Title)
        Me.gbx_Information.Controls.Add(Me.lbl_Information_Start_Title)
        Me.gbx_Information.Controls.Add(Me.lbl_Information_Start_Body)
        Me.gbx_Information.Controls.Add(Me.lbl_Information_End_Body)
        Me.gbx_Information.Location = New System.Drawing.Point(12, 12)
        Me.gbx_Information.Name = "gbx_Information"
        Me.gbx_Information.Size = New System.Drawing.Size(491, 126)
        Me.gbx_Information.TabIndex = 204
        Me.gbx_Information.TabStop = False
        Me.gbx_Information.Text = "Information"
        '
        'lbl_Information_End_Title
        '
        Me.lbl_Information_End_Title.AutoSize = True
        Me.lbl_Information_End_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Information_End_Title.Location = New System.Drawing.Point(252, 18)
        Me.lbl_Information_End_Title.Name = "lbl_Information_End_Title"
        Me.lbl_Information_End_Title.Size = New System.Drawing.Size(93, 20)
        Me.lbl_Information_End_Title.TabIndex = 205
        Me.lbl_Information_End_Title.Text = "Score End"
        '
        'lbl_Information_Start_Title
        '
        Me.lbl_Information_Start_Title.AutoSize = True
        Me.lbl_Information_Start_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Information_Start_Title.Location = New System.Drawing.Point(6, 18)
        Me.lbl_Information_Start_Title.Name = "lbl_Information_Start_Title"
        Me.lbl_Information_Start_Title.Size = New System.Drawing.Size(101, 20)
        Me.lbl_Information_Start_Title.TabIndex = 204
        Me.lbl_Information_Start_Title.Text = "Score Start"
        '
        'lbl_Score_Revive
        '
        Me.lbl_Score_Revive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Score_Revive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Score_Revive.Location = New System.Drawing.Point(12, 454)
        Me.lbl_Score_Revive.Name = "lbl_Score_Revive"
        Me.lbl_Score_Revive.Size = New System.Drawing.Size(243, 27)
        Me.lbl_Score_Revive.TabIndex = 226
        Me.lbl_Score_Revive.Text = "9,999,999"
        Me.lbl_Score_Revive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Score_Revive_Lable
        '
        Me.lbl_Score_Revive_Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Score_Revive_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Score_Revive_Lable.Location = New System.Drawing.Point(12, 430)
        Me.lbl_Score_Revive_Lable.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.lbl_Score_Revive_Lable.Name = "lbl_Score_Revive_Lable"
        Me.lbl_Score_Revive_Lable.Size = New System.Drawing.Size(243, 27)
        Me.lbl_Score_Revive_Lable.TabIndex = 225
        Me.lbl_Score_Revive_Lable.Text = "Revive Glitch Total"
        Me.lbl_Score_Revive_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Score_Revive_Lable.UseMnemonic = False
        '
        'lbl_Score_Maximum
        '
        Me.lbl_Score_Maximum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Score_Maximum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Score_Maximum.Location = New System.Drawing.Point(259, 454)
        Me.lbl_Score_Maximum.Name = "lbl_Score_Maximum"
        Me.lbl_Score_Maximum.Size = New System.Drawing.Size(243, 27)
        Me.lbl_Score_Maximum.TabIndex = 228
        Me.lbl_Score_Maximum.Text = "9,999,999"
        Me.lbl_Score_Maximum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Score_Maximum_Lable
        '
        Me.lbl_Score_Maximum_Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Score_Maximum_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Score_Maximum_Lable.Location = New System.Drawing.Point(259, 430)
        Me.lbl_Score_Maximum_Lable.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.lbl_Score_Maximum_Lable.Name = "lbl_Score_Maximum_Lable"
        Me.lbl_Score_Maximum_Lable.Size = New System.Drawing.Size(243, 27)
        Me.lbl_Score_Maximum_Lable.TabIndex = 227
        Me.lbl_Score_Maximum_Lable.Text = "Points Needed"
        Me.lbl_Score_Maximum_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Clear_Selected
        '
        Me.btn_Clear_Selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear_Selected.Location = New System.Drawing.Point(164, 489)
        Me.btn_Clear_Selected.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Clear_Selected.Name = "btn_Clear_Selected"
        Me.btn_Clear_Selected.Size = New System.Drawing.Size(146, 31)
        Me.btn_Clear_Selected.TabIndex = 229
        Me.btn_Clear_Selected.Text = "Clear Selected Entry"
        Me.btn_Clear_Selected.UseVisualStyleBackColor = True
        '
        'ntb_Score_End
        '
        Me.ntb_Score_End.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntb_Score_End.Location = New System.Drawing.Point(281, 43)
        Me.ntb_Score_End.Margin = New System.Windows.Forms.Padding(4)
        Me.ntb_Score_End.Name = "ntb_Score_End"
        Me.ntb_Score_End.Size = New System.Drawing.Size(175, 31)
        Me.ntb_Score_End.TabIndex = 2
        Me.ntb_Score_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ntb_Score_Start
        '
        Me.ntb_Score_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntb_Score_Start.Location = New System.Drawing.Point(35, 45)
        Me.ntb_Score_Start.Margin = New System.Windows.Forms.Padding(4)
        Me.ntb_Score_Start.Name = "ntb_Score_Start"
        Me.ntb_Score_Start.Size = New System.Drawing.Size(175, 29)
        Me.ntb_Score_Start.TabIndex = 0
        Me.ntb_Score_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Revive
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(512, 528)
        Me.Controls.Add(Me.btn_Clear_Selected)
        Me.Controls.Add(Me.lbl_Score_Maximum)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.lbl_Score_Maximum_Lable)
        Me.Controls.Add(Me.lbl_Score_Revive)
        Me.Controls.Add(Me.lbl_Score_Revive_Lable)
        Me.Controls.Add(Me.gbx_Information)
        Me.Controls.Add(Me.gbx_Entry)
        Me.Controls.Add(Me.dgd_Activity_Log)
        Me.Controls.Add(Me.btn_ReviveCalcs_Finished)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(528, 564)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(528, 564)
        Me.Name = "Revive"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revive Glitch"
        Me.TopMost = True
        CType(Me.dgd_Activity_Log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Entry.ResumeLayout(False)
        Me.gbx_Entry.PerformLayout()
        Me.gbx_Information.ResumeLayout(False)
        Me.gbx_Information.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ReviveCalcs_Finished As System.Windows.Forms.Button
    Friend WithEvents dgd_Activity_Log As System.Windows.Forms.DataGridView
    Friend WithEvents ttp_Revive As System.Windows.Forms.ToolTip
    Friend WithEvents gbx_Entry As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Score_Start As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_End As System.Windows.Forms.Label
    Friend WithEvents ntb_Score_End As BO_Zombies.NumTextBox
    Friend WithEvents btn_Calculate As System.Windows.Forms.Button
    Friend WithEvents lbl_Information_Start_Body As System.Windows.Forms.Label
    Friend WithEvents lbl_Information_End_Body As System.Windows.Forms.Label
    Friend WithEvents gbx_Information As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Information_End_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_Information_Start_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Revive As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Revive_Lable As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Maximum As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Maximum_Lable As System.Windows.Forms.Label
    Friend WithEvents ntb_Score_Start As BO_Zombies.NumTextBox
    Friend WithEvents btn_Clear_Selected As System.Windows.Forms.Button
End Class
