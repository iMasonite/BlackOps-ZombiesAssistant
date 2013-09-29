<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KillTracker
    Inherits Telerik.WinControls.UI.RadForm

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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
		Me.Rad_gbx_Entry = New Telerik.WinControls.UI.RadGroupBox()
		Me.Rad_cbx_AutoRound = New Telerik.WinControls.UI.RadCheckBox()
		Me.Rad_btn_SubmitNew = New Telerik.WinControls.UI.RadButton()
		Me.lbl_CurrentKills = New System.Windows.Forms.Label()
		Me.Rad_ntb_Curr_Kills = New Telerik.WinControls.UI.RadMaskedEditBox()
		Me.lbl_Rounds = New System.Windows.Forms.Label()
		Me.lbl_Init_Kills = New System.Windows.Forms.Label()
		Me.Rad_ntb_Init_Kills = New Telerik.WinControls.UI.RadMaskedEditBox()
		Me.Rad_nud_Round = New Telerik.WinControls.UI.RadSpinEditor()
		Me.Rad_btn_ResetAll = New Telerik.WinControls.UI.RadButton()
		Me.Rad_FinishClose = New Telerik.WinControls.UI.RadButton()
		Me.dgd_Activity_Log = New System.Windows.Forms.DataGridView()
		Me.Rad_gbx_Results = New Telerik.WinControls.UI.RadGroupBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lbl_KillsInCurrRound = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Rad_btn_ClearSelected = New Telerik.WinControls.UI.RadButton()
		CType(Me.Rad_gbx_Entry, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Rad_gbx_Entry.SuspendLayout()
		CType(Me.Rad_cbx_AutoRound, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Rad_btn_SubmitNew, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Rad_ntb_Curr_Kills, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Rad_ntb_Init_Kills, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Rad_nud_Round, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Rad_btn_ResetAll, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Rad_FinishClose, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgd_Activity_Log, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Rad_gbx_Results, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Rad_gbx_Results.SuspendLayout()
		CType(Me.Rad_btn_ClearSelected, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Rad_gbx_Entry
		'
		Me.Rad_gbx_Entry.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
		Me.Rad_gbx_Entry.Controls.Add(Me.Rad_cbx_AutoRound)
		Me.Rad_gbx_Entry.Controls.Add(Me.Rad_btn_SubmitNew)
		Me.Rad_gbx_Entry.Controls.Add(Me.lbl_CurrentKills)
		Me.Rad_gbx_Entry.Controls.Add(Me.Rad_ntb_Curr_Kills)
		Me.Rad_gbx_Entry.Controls.Add(Me.lbl_Rounds)
		Me.Rad_gbx_Entry.Controls.Add(Me.lbl_Init_Kills)
		Me.Rad_gbx_Entry.Controls.Add(Me.Rad_ntb_Init_Kills)
		Me.Rad_gbx_Entry.Controls.Add(Me.Rad_nud_Round)
		Me.Rad_gbx_Entry.Font = New System.Drawing.Font("BankGothic Md BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Rad_gbx_Entry.FooterImageIndex = -1
		Me.Rad_gbx_Entry.FooterImageKey = Global.BO_Zombies.My.Resources.Blanks.String1
		Me.Rad_gbx_Entry.HeaderImageIndex = -1
		Me.Rad_gbx_Entry.HeaderImageKey = Global.BO_Zombies.My.Resources.Blanks.String1
		Me.Rad_gbx_Entry.HeaderMargin = New System.Windows.Forms.Padding(0)
		Me.Rad_gbx_Entry.HeaderText = "Kill Tracking..."
		Me.Rad_gbx_Entry.Location = New System.Drawing.Point(9, 9)
		Me.Rad_gbx_Entry.Margin = New System.Windows.Forms.Padding(0)
		Me.Rad_gbx_Entry.Name = "Rad_gbx_Entry"
		Me.Rad_gbx_Entry.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
		'
		'
		'
		Me.Rad_gbx_Entry.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
		Me.Rad_gbx_Entry.Size = New System.Drawing.Size(267, 136)
		Me.Rad_gbx_Entry.TabIndex = 207
		Me.Rad_gbx_Entry.Text = "Kill Tracking..."
		Me.Rad_gbx_Entry.ThemeName = "Office2010Black"
		'
		'Rad_cbx_AutoRound
		'
		Me.Rad_cbx_AutoRound.CheckAlignment = System.Drawing.ContentAlignment.TopLeft
		Me.Rad_cbx_AutoRound.Font = New System.Drawing.Font("Klavika", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Rad_cbx_AutoRound.Location = New System.Drawing.Point(8, 75)
		Me.Rad_cbx_AutoRound.Margin = New System.Windows.Forms.Padding(0)
		Me.Rad_cbx_AutoRound.Name = "Rad_cbx_AutoRound"
		Me.Rad_cbx_AutoRound.Size = New System.Drawing.Size(198, 18)
		Me.Rad_cbx_AutoRound.TabIndex = 215
		Me.Rad_cbx_AutoRound.Text = "Auto Increment Round Number"
		Me.Rad_cbx_AutoRound.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
		'
		'Rad_btn_SubmitNew
		'
		Me.Rad_btn_SubmitNew.AutoSize = True
		Me.Rad_btn_SubmitNew.Font = New System.Drawing.Font("Klavika", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Rad_btn_SubmitNew.Location = New System.Drawing.Point(117, 98)
		Me.Rad_btn_SubmitNew.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me.Rad_btn_SubmitNew.Name = "Rad_btn_SubmitNew"
		Me.Rad_btn_SubmitNew.Padding = New System.Windows.Forms.Padding(5)
		'
		'
		'
		Me.Rad_btn_SubmitNew.RootElement.Padding = New System.Windows.Forms.Padding(5)
		Me.Rad_btn_SubmitNew.Size = New System.Drawing.Size(145, 31)
		Me.Rad_btn_SubmitNew.TabIndex = 213
		Me.Rad_btn_SubmitNew.Text = "&Submit New Values"
		Me.Rad_btn_SubmitNew.ThemeName = "Office2010Black"
		'
		'lbl_CurrentKills
		'
		Me.lbl_CurrentKills.AutoSize = True
		Me.lbl_CurrentKills.Font = New System.Drawing.Font("Klavika", 12.0!, System.Drawing.FontStyle.Bold)
		Me.lbl_CurrentKills.Location = New System.Drawing.Point(170, 23)
		Me.lbl_CurrentKills.Name = "lbl_CurrentKills"
		Me.lbl_CurrentKills.Size = New System.Drawing.Size(92, 18)
		Me.lbl_CurrentKills.TabIndex = 212
		Me.lbl_CurrentKills.Text = "Current Kills"
		'
		'Rad_ntb_Curr_Kills
		'
		Me.Rad_ntb_Curr_Kills.AllowPromptAsInput = False
		Me.Rad_ntb_Curr_Kills.AutoSize = True
		Me.Rad_ntb_Curr_Kills.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
		Me.Rad_ntb_Curr_Kills.Location = New System.Drawing.Point(173, 41)
		Me.Rad_ntb_Curr_Kills.Margin = New System.Windows.Forms.Padding(0)
		Me.Rad_ntb_Curr_Kills.MaskType = Telerik.WinControls.UI.MaskType.Numeric
		Me.Rad_ntb_Curr_Kills.Name = "Rad_ntb_Curr_Kills"
		Me.Rad_ntb_Curr_Kills.Size = New System.Drawing.Size(77, 27)
		Me.Rad_ntb_Curr_Kills.TabIndex = 211
		Me.Rad_ntb_Curr_Kills.TabStop = False
		Me.Rad_ntb_Curr_Kills.Text = "0"
		Me.Rad_ntb_Curr_Kills.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
		Me.Rad_ntb_Curr_Kills.ThemeName = "Office2010Black"
		Me.Rad_ntb_Curr_Kills.Value = "0"
		'
		'lbl_Rounds
		'
		Me.lbl_Rounds.AutoSize = True
		Me.lbl_Rounds.Font = New System.Drawing.Font("Klavika", 12.0!, System.Drawing.FontStyle.Bold)
		Me.lbl_Rounds.Location = New System.Drawing.Point(101, 23)
		Me.lbl_Rounds.Name = "lbl_Rounds"
		Me.lbl_Rounds.Size = New System.Drawing.Size(53, 18)
		Me.lbl_Rounds.TabIndex = 210
		Me.lbl_Rounds.Text = "Round"
		'
		'lbl_Init_Kills
		'
		Me.lbl_Init_Kills.AutoSize = True
		Me.lbl_Init_Kills.Font = New System.Drawing.Font("Klavika", 12.0!, System.Drawing.FontStyle.Bold)
		Me.lbl_Init_Kills.Location = New System.Drawing.Point(5, 23)
		Me.lbl_Init_Kills.Name = "lbl_Init_Kills"
		Me.lbl_Init_Kills.Size = New System.Drawing.Size(80, 18)
		Me.lbl_Init_Kills.TabIndex = 209
		Me.lbl_Init_Kills.Text = "Initial Kills"
		'
		'Rad_ntb_Init_Kills
		'
		Me.Rad_ntb_Init_Kills.AllowPromptAsInput = False
		Me.Rad_ntb_Init_Kills.AutoSize = True
		Me.Rad_ntb_Init_Kills.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
		Me.Rad_ntb_Init_Kills.Location = New System.Drawing.Point(8, 41)
		Me.Rad_ntb_Init_Kills.Margin = New System.Windows.Forms.Padding(0)
		Me.Rad_ntb_Init_Kills.MaskType = Telerik.WinControls.UI.MaskType.Numeric
		Me.Rad_ntb_Init_Kills.Name = "Rad_ntb_Init_Kills"
		Me.Rad_ntb_Init_Kills.NullText = "Init Kills"
		Me.Rad_ntb_Init_Kills.Size = New System.Drawing.Size(77, 27)
		Me.Rad_ntb_Init_Kills.TabIndex = 207
		Me.Rad_ntb_Init_Kills.TabStop = False
		Me.Rad_ntb_Init_Kills.Text = "0"
		Me.Rad_ntb_Init_Kills.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
		Me.Rad_ntb_Init_Kills.ThemeName = "Office2010Black"
		Me.Rad_ntb_Init_Kills.Value = "0"
		'
		'Rad_nud_Round
		'
		Me.Rad_nud_Round.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
		Me.Rad_nud_Round.Location = New System.Drawing.Point(104, 41)
		Me.Rad_nud_Round.Margin = New System.Windows.Forms.Padding(0)
		Me.Rad_nud_Round.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
		Me.Rad_nud_Round.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.Rad_nud_Round.Name = "Rad_nud_Round"
		Me.Rad_nud_Round.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
		'
		'
		'
		Me.Rad_nud_Round.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
		Me.Rad_nud_Round.RootElement.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.Rad_nud_Round.ShowBorder = True
		Me.Rad_nud_Round.Size = New System.Drawing.Size(50, 27)
		Me.Rad_nud_Round.TabIndex = 206
		Me.Rad_nud_Round.TabStop = False
		Me.Rad_nud_Round.ThemeName = "Office2010Black"
		Me.Rad_nud_Round.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Rad_btn_ResetAll
		'
		Me.Rad_btn_ResetAll.AutoSize = True
		Me.Rad_btn_ResetAll.Font = New System.Drawing.Font("Klavika", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Rad_btn_ResetAll.Location = New System.Drawing.Point(124, 354)
		Me.Rad_btn_ResetAll.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
		Me.Rad_btn_ResetAll.Name = "Rad_btn_ResetAll"
		Me.Rad_btn_ResetAll.Padding = New System.Windows.Forms.Padding(5)
		'
		'
		'
		Me.Rad_btn_ResetAll.RootElement.Padding = New System.Windows.Forms.Padding(5)
		Me.Rad_btn_ResetAll.Size = New System.Drawing.Size(76, 31)
		Me.Rad_btn_ResetAll.TabIndex = 214
		Me.Rad_btn_ResetAll.Text = "Rese&t All"
		Me.Rad_btn_ResetAll.ThemeName = "Office2010Black"
		'
		'Rad_FinishClose
		'
		Me.Rad_FinishClose.AutoSize = True
		Me.Rad_FinishClose.Font = New System.Drawing.Font("Klavika", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Rad_FinishClose.Location = New System.Drawing.Point(334, 354)
		Me.Rad_FinishClose.Name = "Rad_FinishClose"
		Me.Rad_FinishClose.Padding = New System.Windows.Forms.Padding(5)
		'
		'
		'
		Me.Rad_FinishClose.RootElement.Padding = New System.Windows.Forms.Padding(5)
		Me.Rad_FinishClose.Size = New System.Drawing.Size(203, 31)
		Me.Rad_FinishClose.TabIndex = 208
		Me.Rad_FinishClose.Text = "&Finished - (Save and Return)"
		Me.Rad_FinishClose.ThemeName = "Office2010Black"
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
		Me.dgd_Activity_Log.Location = New System.Drawing.Point(9, 150)
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
		Me.dgd_Activity_Log.Size = New System.Drawing.Size(528, 199)
		Me.dgd_Activity_Log.TabIndex = 209
		Me.dgd_Activity_Log.TabStop = False
		'
		'Rad_gbx_Results
		'
		Me.Rad_gbx_Results.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
		Me.Rad_gbx_Results.Controls.Add(Me.Label4)
		Me.Rad_gbx_Results.Controls.Add(Me.Label3)
		Me.Rad_gbx_Results.Controls.Add(Me.lbl_KillsInCurrRound)
		Me.Rad_gbx_Results.Controls.Add(Me.Label1)
		Me.Rad_gbx_Results.Font = New System.Drawing.Font("BankGothic Md BT", 14.25!, System.Drawing.FontStyle.Bold)
		Me.Rad_gbx_Results.FooterImageIndex = -1
		Me.Rad_gbx_Results.FooterImageKey = Global.BO_Zombies.My.Resources.Blanks.String1
		Me.Rad_gbx_Results.HeaderImageIndex = -1
		Me.Rad_gbx_Results.HeaderImageKey = Global.BO_Zombies.My.Resources.Blanks.String1
		Me.Rad_gbx_Results.HeaderMargin = New System.Windows.Forms.Padding(0)
		Me.Rad_gbx_Results.HeaderText = "Info - Round {0}"
		Me.Rad_gbx_Results.Location = New System.Drawing.Point(280, 9)
		Me.Rad_gbx_Results.Name = "Rad_gbx_Results"
		Me.Rad_gbx_Results.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
		'
		'
		'
		Me.Rad_gbx_Results.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
		Me.Rad_gbx_Results.Size = New System.Drawing.Size(257, 136)
		Me.Rad_gbx_Results.TabIndex = 210
		Me.Rad_gbx_Results.Text = "Info - Round {0}"
		Me.Rad_gbx_Results.ThemeName = "Office2010Black"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Paz", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(15, 91)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(158, 27)
		Me.Label4.TabIndex = 216
		Me.Label4.Text = "{00h:00m:00s}"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Klavika", 12.0!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(5, 73)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(111, 18)
		Me.Label3.TabIndex = 215
		Me.Label3.Text = "Time In Round."
		'
		'lbl_KillsInCurrRound
		'
		Me.lbl_KillsInCurrRound.AutoSize = True
		Me.lbl_KillsInCurrRound.Font = New System.Drawing.Font("Paz", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_KillsInCurrRound.Location = New System.Drawing.Point(15, 41)
		Me.lbl_KillsInCurrRound.Name = "lbl_KillsInCurrRound"
		Me.lbl_KillsInCurrRound.Size = New System.Drawing.Size(78, 27)
		Me.lbl_KillsInCurrRound.TabIndex = 214
		Me.lbl_KillsInCurrRound.Text = "{0000}"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Klavika", 12.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(5, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(106, 18)
		Me.Label1.TabIndex = 213
		Me.Label1.Text = "Kills In Round."
		'
		'Rad_btn_ClearSelected
		'
		Me.Rad_btn_ClearSelected.AutoSize = True
		Me.Rad_btn_ClearSelected.Font = New System.Drawing.Font("Klavika", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Rad_btn_ClearSelected.Location = New System.Drawing.Point(9, 354)
		Me.Rad_btn_ClearSelected.Name = "Rad_btn_ClearSelected"
		Me.Rad_btn_ClearSelected.Padding = New System.Windows.Forms.Padding(5)
		'
		'
		'
		Me.Rad_btn_ClearSelected.RootElement.Padding = New System.Windows.Forms.Padding(5)
		Me.Rad_btn_ClearSelected.Size = New System.Drawing.Size(109, 31)
		Me.Rad_btn_ClearSelected.TabIndex = 211
		Me.Rad_btn_ClearSelected.Text = "Clear Selected"
		Me.Rad_btn_ClearSelected.ThemeName = "Office2010Black"
		'
		'KillTracker
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(549, 390)
		Me.Controls.Add(Me.Rad_btn_ClearSelected)
		Me.Controls.Add(Me.Rad_btn_ResetAll)
		Me.Controls.Add(Me.Rad_gbx_Results)
		Me.Controls.Add(Me.dgd_Activity_Log)
		Me.Controls.Add(Me.Rad_FinishClose)
		Me.Controls.Add(Me.Rad_gbx_Entry)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "KillTracker"
		'
		'
		'
		Me.RootElement.ApplyShapeToControl = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "KillTracker"
		Me.ThemeName = "Office2010Black"
		CType(Me.Rad_gbx_Entry, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Rad_gbx_Entry.ResumeLayout(False)
		Me.Rad_gbx_Entry.PerformLayout()
		CType(Me.Rad_cbx_AutoRound, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Rad_btn_SubmitNew, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Rad_ntb_Curr_Kills, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Rad_ntb_Init_Kills, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Rad_nud_Round, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Rad_btn_ResetAll, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Rad_FinishClose, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgd_Activity_Log, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Rad_gbx_Results, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Rad_gbx_Results.ResumeLayout(False)
		Me.Rad_gbx_Results.PerformLayout()
		CType(Me.Rad_btn_ClearSelected, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
	Friend WithEvents Rad_gbx_Entry As Telerik.WinControls.UI.RadGroupBox
	Friend WithEvents Rad_ntb_Init_Kills As Telerik.WinControls.UI.RadMaskedEditBox
	Friend WithEvents Rad_nud_Round As Telerik.WinControls.UI.RadSpinEditor
	Friend WithEvents Rad_FinishClose As Telerik.WinControls.UI.RadButton
	Friend WithEvents lbl_CurrentKills As System.Windows.Forms.Label
	Friend WithEvents Rad_ntb_Curr_Kills As Telerik.WinControls.UI.RadMaskedEditBox
	Friend WithEvents lbl_Rounds As System.Windows.Forms.Label
	Friend WithEvents lbl_Init_Kills As System.Windows.Forms.Label
	Friend WithEvents Rad_btn_SubmitNew As Telerik.WinControls.UI.RadButton
	Friend WithEvents dgd_Activity_Log As System.Windows.Forms.DataGridView
	Friend WithEvents Rad_btn_ResetAll As Telerik.WinControls.UI.RadButton
	Friend WithEvents Rad_gbx_Results As Telerik.WinControls.UI.RadGroupBox
	Friend WithEvents Rad_cbx_AutoRound As Telerik.WinControls.UI.RadCheckBox
	Friend WithEvents Rad_btn_ClearSelected As Telerik.WinControls.UI.RadButton
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents lbl_KillsInCurrRound As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

