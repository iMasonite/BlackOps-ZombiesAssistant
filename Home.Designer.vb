<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.ttp_MainForm = New System.Windows.Forms.ToolTip(Me.components)
		Me.lbl_Score_Calculator_Result = New System.Windows.Forms.Label()
		Me.cbx_Calculator_To_Manual = New System.Windows.Forms.CheckBox()
		Me.rdb_Calculator_Math_Multiply = New System.Windows.Forms.RadioButton()
		Me.rdb_Calculator_Math_Divide = New System.Windows.Forms.RadioButton()
		Me.rdb_Calculator_Math_Minus = New System.Windows.Forms.RadioButton()
		Me.rdb_Calculator_Math_Add = New System.Windows.Forms.RadioButton()
		Me.cbx_Calculator_Auto_Manual = New System.Windows.Forms.CheckBox()
		Me.lbl_Score_Maximum_Lable = New System.Windows.Forms.Label()
		Me.lbl_Score_Should_Lable = New System.Windows.Forms.Label()
		Me.btn_KillTracker = New System.Windows.Forms.Button()
		Me.btn_Weapons = New System.Windows.Forms.Button()
		Me.tsm_MainMenuStrip = New System.Windows.Forms.MenuStrip()
		Me.tsm_top_File = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_New = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Open = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Save = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Separator_File = New System.Windows.Forms.ToolStripSeparator()
		Me.tsm_Exit = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_top_Edit = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Undo = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Separator_Edit = New System.Windows.Forms.ToolStripSeparator()
		Me.tsm_ClearEntireForm = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_top_Tools = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Customize = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Options = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Separator_Tool = New System.Windows.Forms.ToolStripSeparator()
		Me.tsm_ViewQuantity = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_ViewAccumulative = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_top_Forms = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_top_Chat = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_OpenChat = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_top_Help = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Register = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Separator_Help1 = New System.Windows.Forms.ToolStripSeparator()
		Me.tsm_Contents = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_About = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_BugReport = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_Separator_Help2 = New System.Windows.Forms.ToolStripSeparator()
		Me.tsm_Donate = New System.Windows.Forms.ToolStripMenuItem()
		Me.btn_Manual_Entry = New System.Windows.Forms.Button()
		Me.gbx_TotalLables = New System.Windows.Forms.GroupBox()
		Me.lbl_Score_Revive = New System.Windows.Forms.Label()
		Me.lbl_Score_Revive_Lable = New System.Windows.Forms.Label()
		Me.lbl_Score_Down = New System.Windows.Forms.Label()
		Me.lbl_Score_Down_Lable = New System.Windows.Forms.Label()
		Me.lbl_Score_Spent = New System.Windows.Forms.Label()
		Me.lbl_Score_Spent_Lable = New System.Windows.Forms.Label()
		Me.ptb_Score_Grand = New System.Windows.Forms.PictureBox()
		Me.lbl_Score_Grand_Lable = New System.Windows.Forms.Label()
		Me.ptb_Score_Maximum = New System.Windows.Forms.PictureBox()
		Me.ptb_Score_Should = New System.Windows.Forms.PictureBox()
		Me.lbl_Score_Grand = New System.Windows.Forms.Label()
		Me.lbl_Score_Maximum = New System.Windows.Forms.Label()
		Me.lbl_Score_Should = New System.Windows.Forms.Label()
		Me.gbx_OtherForms = New System.Windows.Forms.GroupBox()
		Me.btn_SamsGame = New System.Windows.Forms.Button()
		Me.btn_Downs = New System.Windows.Forms.Button()
		Me.btn_Revive = New System.Windows.Forms.Button()
		Me.gbx_Other_Items = New System.Windows.Forms.GroupBox()
		Me.btn_Bowie_Knife = New System.Windows.Forms.Button()
		Me.btn_Semtex = New System.Windows.Forms.Button()
		Me.btn_Claymores = New System.Windows.Forms.Button()
		Me.btn_Easter_Egg_Button = New System.Windows.Forms.Button()
		Me.lbl_Easter_Egg_Button = New System.Windows.Forms.Label()
		Me.lbl_Semtex = New System.Windows.Forms.Label()
		Me.lbl_Bowie_Knife = New System.Windows.Forms.Label()
		Me.lbl_Claymores = New System.Windows.Forms.Label()
		Me.btn_Score_Current = New System.Windows.Forms.Button()
		Me.gbx_Activity_Log = New System.Windows.Forms.GroupBox()
		Me.dgd_Activity_Log = New System.Windows.Forms.DataGridView()
		Me.gbx_Upgrades = New System.Windows.Forms.GroupBox()
		Me.btn_Pack_A_Punch = New System.Windows.Forms.Button()
		Me.btn_Upgraded_Ammo = New System.Windows.Forms.Button()
		Me.lbl_Upgraded_Ammo = New System.Windows.Forms.Label()
		Me.lbl_Pack_A_Punch = New System.Windows.Forms.Label()
		Me.gbx_Doors = New System.Windows.Forms.GroupBox()
		Me.btn_Hack_Door = New System.Windows.Forms.Button()
		Me.btn_Door_750 = New System.Windows.Forms.Button()
		Me.btn_Door_1250 = New System.Windows.Forms.Button()
		Me.btn_Door_1000 = New System.Windows.Forms.Button()
		Me.lbl_Door_1000 = New System.Windows.Forms.Label()
		Me.lbl_Door_1250 = New System.Windows.Forms.Label()
		Me.lbl_Door_750 = New System.Windows.Forms.Label()
		Me.lbl_Hack_Door = New System.Windows.Forms.Label()
		Me.gbx_The_Mystery_box = New System.Windows.Forms.GroupBox()
		Me.btn_Teddy_Hack = New System.Windows.Forms.Button()
		Me.btn_Firesale_Box = New System.Windows.Forms.Button()
		Me.btn_Hack_The_Box = New System.Windows.Forms.Button()
		Me.btn_Buy_The_Box = New System.Windows.Forms.Button()
		Me.btn_Buy_And_Hack_Box = New System.Windows.Forms.Button()
		Me.lbl_Hack_The_Box = New System.Windows.Forms.Label()
		Me.lbl_Buy_The_Box = New System.Windows.Forms.Label()
		Me.lbl_Teddy_Hack = New System.Windows.Forms.Label()
		Me.lbl_Firesale_Box = New System.Windows.Forms.Label()
		Me.gbx_MajorHacks = New System.Windows.Forms.GroupBox()
		Me.btn_Max_Ammo_Hack = New System.Windows.Forms.Button()
		Me.lbl_Max_Ammo_Hack = New System.Windows.Forms.Label()
		Me.btn_Hack_Player = New System.Windows.Forms.Button()
		Me.lbl_Hack_Player = New System.Windows.Forms.Label()
		Me.gbx_Perks = New System.Windows.Forms.GroupBox()
		Me.btn_Juggernog = New System.Windows.Forms.Button()
		Me.btn_Stammin_Up = New System.Windows.Forms.Button()
		Me.btn_Mule_Kick = New System.Windows.Forms.Button()
		Me.btn_PHD_Flopper = New System.Windows.Forms.Button()
		Me.btn_Perks_More = New System.Windows.Forms.Button()
		Me.btn_Speed_Cola = New System.Windows.Forms.Button()
		Me.btn_Double_Tap = New System.Windows.Forms.Button()
		Me.btn_Quick_Revive = New System.Windows.Forms.Button()
		Me.btn_Dead_Shot = New System.Windows.Forms.Button()
		Me.lbl_Juggernog = New System.Windows.Forms.Label()
		Me.lbl_Speed_Cola = New System.Windows.Forms.Label()
		Me.lbl_Stammin_Up = New System.Windows.Forms.Label()
		Me.lbl_Dead_Shot = New System.Windows.Forms.Label()
		Me.lbl_PHD_Flopper = New System.Windows.Forms.Label()
		Me.lbl_Double_Tap = New System.Windows.Forms.Label()
		Me.lbl_Mule_Kick = New System.Windows.Forms.Label()
		Me.lbl_Quick_Revive = New System.Windows.Forms.Label()
		Me.gbx_WallWeapons = New System.Windows.Forms.GroupBox()
		Me.btn_MPL = New System.Windows.Forms.Button()
		Me.btn_MPL_Ammo = New System.Windows.Forms.Button()
		Me.btn_AK74U = New System.Windows.Forms.Button()
		Me.btn_MP5K = New System.Windows.Forms.Button()
		Me.btn_M14 = New System.Windows.Forms.Button()
		Me.btn_AK74U_Ammo = New System.Windows.Forms.Button()
		Me.btn_M14_Ammo = New System.Windows.Forms.Button()
		Me.btn_MP5K_Ammo = New System.Windows.Forms.Button()
		Me.btn_Wall_Weapons_More = New System.Windows.Forms.Button()
		Me.btn_Stakeout_Ammo = New System.Windows.Forms.Button()
		Me.btn_Stakeout = New System.Windows.Forms.Button()
		Me.btn_PM63_Ammo = New System.Windows.Forms.Button()
		Me.btn_PM63 = New System.Windows.Forms.Button()
		Me.btn_Olympia_Ammo = New System.Windows.Forms.Button()
		Me.btn_Olympia = New System.Windows.Forms.Button()
		Me.btn_M16_Ammo = New System.Windows.Forms.Button()
		Me.btn_M16 = New System.Windows.Forms.Button()
		Me.lbl_AK74U = New System.Windows.Forms.Label()
		Me.lbl_AK74U_Ammo = New System.Windows.Forms.Label()
		Me.lbl_Olympia_Ammo = New System.Windows.Forms.Label()
		Me.lbl_Olympia = New System.Windows.Forms.Label()
		Me.lbl_MPL = New System.Windows.Forms.Label()
		Me.lbl_MPL_Ammo = New System.Windows.Forms.Label()
		Me.lbl_M16_Ammo = New System.Windows.Forms.Label()
		Me.lbl_M16 = New System.Windows.Forms.Label()
		Me.lbl_M14_Ammo = New System.Windows.Forms.Label()
		Me.lbl_M14 = New System.Windows.Forms.Label()
		Me.lbl_PM63_Ammo = New System.Windows.Forms.Label()
		Me.lbl_PM63 = New System.Windows.Forms.Label()
		Me.lbl_MP5K_Ammo = New System.Windows.Forms.Label()
		Me.lbl_MP5K = New System.Windows.Forms.Label()
		Me.lbl_Stakeout_Ammo = New System.Windows.Forms.Label()
		Me.lbl_Stakeout = New System.Windows.Forms.Label()
		Me.lbl_CurrentScoreInfo = New System.Windows.Forms.Label()
		Me.lbl_Manual_Entry_Info = New System.Windows.Forms.Label()
		Me.lbl_Score_Current = New System.Windows.Forms.Label()
		Me.lbl_Score_Current_Name = New System.Windows.Forms.Label()
		Me.lbl_Manual_Entry = New System.Windows.Forms.Label()
		Me.lbl_Manual_Entry_Name = New System.Windows.Forms.Label()
		Me.ptb_Score_Calculated_Result = New System.Windows.Forms.PictureBox()
		Me.lbl_Calculator_Type = New System.Windows.Forms.Label()
		Me.lbl_Score_Calculator_Result_Name = New System.Windows.Forms.Label()
		Me.btn_Calculator_Submit = New System.Windows.Forms.Button()
		Me.lbl_Calculator_End = New System.Windows.Forms.Label()
		Me.lbl_Calculator_Start = New System.Windows.Forms.Label()
		Me.gbx_ManualEntry = New System.Windows.Forms.GroupBox()
		Me.ntb_Score_Current = New BO_Zombies.NumTextBox()
		Me.ntb_Manual_Entry = New BO_Zombies.NumTextBox()
		Me.gbx_Calculator = New System.Windows.Forms.GroupBox()
		Me.ntb_Calculator_End = New BO_Zombies.NumTextBox()
		Me.ntb_Calculator_Start = New BO_Zombies.NumTextBox()
		Me.gbx_Grand_Totals = New System.Windows.Forms.GroupBox()
		Me.mus_MainMenuStrip = New System.Windows.Forms.MenuStrip()
		Me.AdsdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsm_MainMenuStrip.SuspendLayout()
		Me.gbx_TotalLables.SuspendLayout()
		CType(Me.ptb_Score_Grand, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ptb_Score_Maximum, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ptb_Score_Should, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbx_OtherForms.SuspendLayout()
		Me.gbx_Other_Items.SuspendLayout()
		Me.gbx_Activity_Log.SuspendLayout()
		CType(Me.dgd_Activity_Log, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbx_Upgrades.SuspendLayout()
		Me.gbx_Doors.SuspendLayout()
		Me.gbx_The_Mystery_box.SuspendLayout()
		Me.gbx_MajorHacks.SuspendLayout()
		Me.gbx_Perks.SuspendLayout()
		Me.gbx_WallWeapons.SuspendLayout()
		CType(Me.ptb_Score_Calculated_Result, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbx_ManualEntry.SuspendLayout()
		Me.gbx_Calculator.SuspendLayout()
		Me.gbx_Grand_Totals.SuspendLayout()
		Me.SuspendLayout()
		'
		'ttp_MainForm
		'
		Me.ttp_MainForm.AutoPopDelay = 5000000
		Me.ttp_MainForm.InitialDelay = 500
		Me.ttp_MainForm.ReshowDelay = 100
		'
		'lbl_Score_Calculator_Result
		'
		Me.lbl_Score_Calculator_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Calculator_Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Calculator_Result.Location = New System.Drawing.Point(36, 169)
		Me.lbl_Score_Calculator_Result.Name = "lbl_Score_Calculator_Result"
		Me.lbl_Score_Calculator_Result.Size = New System.Drawing.Size(246, 27)
		Me.lbl_Score_Calculator_Result.TabIndex = 228
		Me.lbl_Score_Calculator_Result.Text = "9,999,999"
		Me.lbl_Score_Calculator_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ttp_MainForm.SetToolTip(Me.lbl_Score_Calculator_Result, "{R} Means Rounded UP to the Next 10.. this is how Zombies Score works")
		Me.lbl_Score_Calculator_Result.UseMnemonic = False
		'
		'cbx_Calculator_To_Manual
		'
		Me.cbx_Calculator_To_Manual.AutoSize = True
		Me.cbx_Calculator_To_Manual.Checked = True
		Me.cbx_Calculator_To_Manual.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbx_Calculator_To_Manual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
		Me.cbx_Calculator_To_Manual.Location = New System.Drawing.Point(20, 113)
		Me.cbx_Calculator_To_Manual.Name = "cbx_Calculator_To_Manual"
		Me.cbx_Calculator_To_Manual.Size = New System.Drawing.Size(145, 19)
		Me.cbx_Calculator_To_Manual.TabIndex = 234
		Me.cbx_Calculator_To_Manual.Text = "Add to ""Entry Values""?"
		Me.ttp_MainForm.SetToolTip(Me.cbx_Calculator_To_Manual, resources.GetString("cbx_Calculator_To_Manual.ToolTip"))
		Me.cbx_Calculator_To_Manual.UseVisualStyleBackColor = True
		'
		'rdb_Calculator_Math_Multiply
		'
		Me.rdb_Calculator_Math_Multiply.AutoSize = True
		Me.rdb_Calculator_Math_Multiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdb_Calculator_Math_Multiply.Location = New System.Drawing.Point(225, 86)
		Me.rdb_Calculator_Math_Multiply.Name = "rdb_Calculator_Math_Multiply"
		Me.rdb_Calculator_Math_Multiply.Size = New System.Drawing.Size(67, 19)
		Me.rdb_Calculator_Math_Multiply.TabIndex = 232
		Me.rdb_Calculator_Math_Multiply.Tag = "Times"
		Me.rdb_Calculator_Math_Multiply.Text = "Multiply"
		Me.ttp_MainForm.SetToolTip(Me.rdb_Calculator_Math_Multiply, "This will Multiply the Larger number by the Smaller number.")
		Me.rdb_Calculator_Math_Multiply.UseVisualStyleBackColor = True
		'
		'rdb_Calculator_Math_Divide
		'
		Me.rdb_Calculator_Math_Divide.AutoSize = True
		Me.rdb_Calculator_Math_Divide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdb_Calculator_Math_Divide.Location = New System.Drawing.Point(158, 86)
		Me.rdb_Calculator_Math_Divide.Name = "rdb_Calculator_Math_Divide"
		Me.rdb_Calculator_Math_Divide.Size = New System.Drawing.Size(59, 19)
		Me.rdb_Calculator_Math_Divide.TabIndex = 231
		Me.rdb_Calculator_Math_Divide.Tag = "Divide"
		Me.rdb_Calculator_Math_Divide.Text = "Divide"
		Me.ttp_MainForm.SetToolTip(Me.rdb_Calculator_Math_Divide, "This will Divide the Larger number by the Smaller number.")
		Me.rdb_Calculator_Math_Divide.UseVisualStyleBackColor = True
		'
		'rdb_Calculator_Math_Minus
		'
		Me.rdb_Calculator_Math_Minus.AutoSize = True
		Me.rdb_Calculator_Math_Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdb_Calculator_Math_Minus.Location = New System.Drawing.Point(80, 86)
		Me.rdb_Calculator_Math_Minus.Name = "rdb_Calculator_Math_Minus"
		Me.rdb_Calculator_Math_Minus.Size = New System.Drawing.Size(70, 19)
		Me.rdb_Calculator_Math_Minus.TabIndex = 230
		Me.rdb_Calculator_Math_Minus.Tag = "Minus"
		Me.rdb_Calculator_Math_Minus.Text = "Subtract"
		Me.ttp_MainForm.SetToolTip(Me.rdb_Calculator_Math_Minus, "This will Subtract the Smaller number from the Larger number.")
		Me.rdb_Calculator_Math_Minus.UseVisualStyleBackColor = True
		'
		'rdb_Calculator_Math_Add
		'
		Me.rdb_Calculator_Math_Add.AutoSize = True
		Me.rdb_Calculator_Math_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdb_Calculator_Math_Add.Location = New System.Drawing.Point(26, 86)
		Me.rdb_Calculator_Math_Add.Name = "rdb_Calculator_Math_Add"
		Me.rdb_Calculator_Math_Add.Size = New System.Drawing.Size(46, 19)
		Me.rdb_Calculator_Math_Add.TabIndex = 229
		Me.rdb_Calculator_Math_Add.Tag = "Add"
		Me.rdb_Calculator_Math_Add.Text = "Add"
		Me.ttp_MainForm.SetToolTip(Me.rdb_Calculator_Math_Add, "This will Add the Smaller number to the Larger number.")
		Me.rdb_Calculator_Math_Add.UseVisualStyleBackColor = True
		'
		'cbx_Calculator_Auto_Manual
		'
		Me.cbx_Calculator_Auto_Manual.AutoSize = True
		Me.cbx_Calculator_Auto_Manual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
		Me.cbx_Calculator_Auto_Manual.Location = New System.Drawing.Point(176, 113)
		Me.cbx_Calculator_Auto_Manual.Name = "cbx_Calculator_Auto_Manual"
		Me.cbx_Calculator_Auto_Manual.Size = New System.Drawing.Size(123, 19)
		Me.cbx_Calculator_Auto_Manual.TabIndex = 235
		Me.cbx_Calculator_Auto_Manual.Text = "Full Auto Update?"
		Me.ttp_MainForm.SetToolTip(Me.cbx_Calculator_Auto_Manual, "When Checked, This will automatically add the results to the ""Activity Log"" and u" & _
			  "pdate your ""Current Score"" with the value in the ""Value End"" Box.")
		Me.cbx_Calculator_Auto_Manual.UseVisualStyleBackColor = True
		'
		'lbl_Score_Maximum_Lable
		'
		Me.lbl_Score_Maximum_Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Maximum_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Maximum_Lable.Location = New System.Drawing.Point(7, 95)
		Me.lbl_Score_Maximum_Lable.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.lbl_Score_Maximum_Lable.Name = "lbl_Score_Maximum_Lable"
		Me.lbl_Score_Maximum_Lable.Size = New System.Drawing.Size(513, 24)
		Me.lbl_Score_Maximum_Lable.TabIndex = 13
		Me.lbl_Score_Maximum_Lable.Text = "Score needed to reach the 2 Million Max"
		Me.lbl_Score_Maximum_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ttp_MainForm.SetToolTip(Me.lbl_Score_Maximum_Lable, "Score needed to reach the 2 Million Max")
		'
		'lbl_Score_Should_Lable
		'
		Me.lbl_Score_Should_Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Should_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Should_Lable.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
		Me.lbl_Score_Should_Lable.Location = New System.Drawing.Point(7, 161)
		Me.lbl_Score_Should_Lable.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.lbl_Score_Should_Lable.Name = "lbl_Score_Should_Lable"
		Me.lbl_Score_Should_Lable.Size = New System.Drawing.Size(513, 24)
		Me.lbl_Score_Should_Lable.TabIndex = 14
		Me.lbl_Score_Should_Lable.Text = "Your OnScreen Score Should Look Like..."
		Me.lbl_Score_Should_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ttp_MainForm.SetToolTip(Me.lbl_Score_Should_Lable, "Your OnScreen Score Should Look Like...")
		'
		'btn_KillTracker
		'
		Me.btn_KillTracker.BackColor = System.Drawing.Color.Transparent
		Me.btn_KillTracker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
		Me.btn_KillTracker.Location = New System.Drawing.Point(119, 102)
		Me.btn_KillTracker.Name = "btn_KillTracker"
		Me.btn_KillTracker.Size = New System.Drawing.Size(108, 36)
		Me.btn_KillTracker.TabIndex = 4
		Me.btn_KillTracker.Text = "Kill Tracker"
		Me.ttp_MainForm.SetToolTip(Me.btn_KillTracker, "In Development (Coming Soon)")
		Me.btn_KillTracker.UseVisualStyleBackColor = False
		'
		'btn_Weapons
		'
		Me.btn_Weapons.BackColor = System.Drawing.Color.Transparent
		Me.btn_Weapons.Enabled = False
		Me.btn_Weapons.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
		Me.btn_Weapons.Location = New System.Drawing.Point(120, 63)
		Me.btn_Weapons.Name = "btn_Weapons"
		Me.btn_Weapons.Size = New System.Drawing.Size(108, 36)
		Me.btn_Weapons.TabIndex = 3
		Me.btn_Weapons.Text = "Weapon Efficiency"
		Me.ttp_MainForm.SetToolTip(Me.btn_Weapons, "In Development (Coming Soon)")
		Me.btn_Weapons.UseVisualStyleBackColor = False
		'
		'tsm_MainMenuStrip
		'
		Me.tsm_MainMenuStrip.BackColor = System.Drawing.Color.LightGray
		Me.tsm_MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_top_File, Me.tsm_top_Edit, Me.tsm_top_Tools, Me.tsm_top_Forms, Me.tsm_top_Chat, Me.tsm_top_Help})
		Me.tsm_MainMenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.tsm_MainMenuStrip.Name = "tsm_MainMenuStrip"
		Me.tsm_MainMenuStrip.Size = New System.Drawing.Size(1150, 25)
		Me.tsm_MainMenuStrip.TabIndex = 0
		Me.tsm_MainMenuStrip.Text = "Home_MenuStrip"
		'
		'tsm_top_File
		'
		Me.tsm_top_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_New, Me.tsm_Open, Me.tsm_Save, Me.tsm_Separator_File, Me.tsm_Exit})
		Me.tsm_top_File.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
		Me.tsm_top_File.Image = Global.BO_Zombies.My.Resources.Resources.icn_file
		Me.tsm_top_File.Name = "tsm_top_File"
		Me.tsm_top_File.Size = New System.Drawing.Size(58, 21)
		Me.tsm_top_File.Text = "File"
		'
		'tsm_New
		'
		Me.tsm_New.Enabled = False
		Me.tsm_New.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tsm_New.Image = Global.BO_Zombies.My.Resources.Resources.icn_doc_new
		Me.tsm_New.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsm_New.Name = "tsm_New"
		Me.tsm_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.tsm_New.Size = New System.Drawing.Size(179, 26)
		Me.tsm_New.Text = "New"
		'
		'tsm_Open
		'
		Me.tsm_Open.Enabled = False
		Me.tsm_Open.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_Open.Image = Global.BO_Zombies.My.Resources.Resources.icn_doc_import
		Me.tsm_Open.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsm_Open.Name = "tsm_Open"
		Me.tsm_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.tsm_Open.Size = New System.Drawing.Size(179, 26)
		Me.tsm_Open.Text = "Open"
		'
		'tsm_Save
		'
		Me.tsm_Save.Enabled = False
		Me.tsm_Save.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_Save.Image = Global.BO_Zombies.My.Resources.Resources.icn_doc_export
		Me.tsm_Save.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsm_Save.Name = "tsm_Save"
		Me.tsm_Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.tsm_Save.Size = New System.Drawing.Size(179, 26)
		Me.tsm_Save.Text = "Save"
		'
		'tsm_Separator_File
		'
		Me.tsm_Separator_File.Name = "tsm_Separator_File"
		Me.tsm_Separator_File.Size = New System.Drawing.Size(176, 6)
		'
		'tsm_Exit
		'
		Me.tsm_Exit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_Exit.Image = Global.BO_Zombies.My.Resources.Resources.icn_close
		Me.tsm_Exit.Name = "tsm_Exit"
		Me.tsm_Exit.Size = New System.Drawing.Size(179, 26)
		Me.tsm_Exit.Text = "Exit"
		'
		'tsm_top_Edit
		'
		Me.tsm_top_Edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Undo, Me.tsm_Separator_Edit, Me.tsm_ClearEntireForm})
		Me.tsm_top_Edit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
		Me.tsm_top_Edit.Image = Global.BO_Zombies.My.Resources.Resources.icn_edit
		Me.tsm_top_Edit.Name = "tsm_top_Edit"
		Me.tsm_top_Edit.Size = New System.Drawing.Size(60, 21)
		Me.tsm_top_Edit.Text = "Edit"
		'
		'tsm_Undo
		'
		Me.tsm_Undo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_Undo.Image = Global.BO_Zombies.My.Resources.Resources.icn_undo
		Me.tsm_Undo.Name = "tsm_Undo"
		Me.tsm_Undo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
		Me.tsm_Undo.Size = New System.Drawing.Size(259, 26)
		Me.tsm_Undo.Text = "Undo (Selected)"
		Me.tsm_Undo.ToolTipText = "Clear the last item that was submitted."
		'
		'tsm_Separator_Edit
		'
		Me.tsm_Separator_Edit.Name = "tsm_Separator_Edit"
		Me.tsm_Separator_Edit.Size = New System.Drawing.Size(256, 6)
		'
		'tsm_ClearEntireForm
		'
		Me.tsm_ClearEntireForm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_ClearEntireForm.Image = Global.BO_Zombies.My.Resources.Resources.icn_bin
		Me.tsm_ClearEntireForm.Name = "tsm_ClearEntireForm"
		Me.tsm_ClearEntireForm.Size = New System.Drawing.Size(259, 26)
		Me.tsm_ClearEntireForm.Text = "Clear Entire Form!"
		Me.tsm_ClearEntireForm.ToolTipText = "This will CLEAR ALL DATA, only use this if you really want to start from scratch." & _
		  ".."
		'
		'tsm_top_Tools
		'
		Me.tsm_top_Tools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Customize, Me.tsm_Options, Me.tsm_Separator_Tool, Me.tsm_ViewQuantity, Me.tsm_ViewAccumulative})
		Me.tsm_top_Tools.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
		Me.tsm_top_Tools.Image = Global.BO_Zombies.My.Resources.Resources.icn_tools
		Me.tsm_top_Tools.Name = "tsm_top_Tools"
		Me.tsm_top_Tools.Size = New System.Drawing.Size(70, 21)
		Me.tsm_top_Tools.Text = "Tools"
		'
		'tsm_Customize
		'
		Me.tsm_Customize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_Customize.Image = Global.BO_Zombies.My.Resources.Resources.icn_custom
		Me.tsm_Customize.Name = "tsm_Customize"
		Me.tsm_Customize.Size = New System.Drawing.Size(261, 26)
		Me.tsm_Customize.Text = "Customize"
		Me.tsm_Customize.ToolTipText = "Customize the form layout options and other display properties..."
		'
		'tsm_Options
		'
		Me.tsm_Options.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_Options.Image = Global.BO_Zombies.My.Resources.Resources.icn_settings
		Me.tsm_Options.Name = "tsm_Options"
		Me.tsm_Options.Size = New System.Drawing.Size(261, 26)
		Me.tsm_Options.Text = "Options"
		Me.tsm_Options.ToolTipText = "Change the options available in the program..."
		'
		'tsm_Separator_Tool
		'
		Me.tsm_Separator_Tool.Name = "tsm_Separator_Tool"
		Me.tsm_Separator_Tool.Size = New System.Drawing.Size(258, 6)
		'
		'tsm_ViewQuantity
		'
		Me.tsm_ViewQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_ViewQuantity.Image = Global.BO_Zombies.My.Resources.Resources.icn_view_qty
		Me.tsm_ViewQuantity.Name = "tsm_ViewQuantity"
		Me.tsm_ViewQuantity.ShortcutKeys = System.Windows.Forms.Keys.F9
		Me.tsm_ViewQuantity.Size = New System.Drawing.Size(261, 26)
		Me.tsm_ViewQuantity.Text = "View Quantity"
		Me.tsm_ViewQuantity.ToolTipText = "Show all the values for each item as the amount of times clicked..."
		'
		'tsm_ViewAccumulative
		'
		Me.tsm_ViewAccumulative.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_ViewAccumulative.Image = Global.BO_Zombies.My.Resources.Resources.icn_view_acum
		Me.tsm_ViewAccumulative.Name = "tsm_ViewAccumulative"
		Me.tsm_ViewAccumulative.ShortcutKeys = System.Windows.Forms.Keys.F10
		Me.tsm_ViewAccumulative.Size = New System.Drawing.Size(261, 26)
		Me.tsm_ViewAccumulative.Text = "View Accumulative"
		Me.tsm_ViewAccumulative.ToolTipText = "Show all the values for each item as the sum of all the clicks per item..."
		'
		'tsm_top_Forms
		'
		Me.tsm_top_Forms.Enabled = False
		Me.tsm_top_Forms.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
		Me.tsm_top_Forms.Image = Global.BO_Zombies.My.Resources.Resources.icn_forms
		Me.tsm_top_Forms.Name = "tsm_top_Forms"
		Me.tsm_top_Forms.Size = New System.Drawing.Size(74, 21)
		Me.tsm_top_Forms.Text = "Forms"
		'
		'tsm_top_Chat
		'
		Me.tsm_top_Chat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_OpenChat})
		Me.tsm_top_Chat.Enabled = False
		Me.tsm_top_Chat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
		Me.tsm_top_Chat.Image = Global.BO_Zombies.My.Resources.Resources.icn_multiplayer
		Me.tsm_top_Chat.Name = "tsm_top_Chat"
		Me.tsm_top_Chat.Size = New System.Drawing.Size(64, 21)
		Me.tsm_top_Chat.Text = "Chat"
		'
		'tsm_OpenChat
		'
		Me.tsm_OpenChat.Enabled = False
		Me.tsm_OpenChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_OpenChat.Image = Global.BO_Zombies.My.Resources.Resources.icn_chat_bubble
		Me.tsm_OpenChat.Name = "tsm_OpenChat"
		Me.tsm_OpenChat.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.tsm_OpenChat.Size = New System.Drawing.Size(216, 24)
		Me.tsm_OpenChat.Text = "Open Chat"
		'
		'tsm_top_Help
		'
		Me.tsm_top_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Register, Me.tsm_Separator_Help1, Me.tsm_Contents, Me.tsm_About, Me.tsm_BugReport, Me.tsm_Separator_Help2, Me.tsm_Donate})
		Me.tsm_top_Help.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
		Me.tsm_top_Help.Image = Global.BO_Zombies.My.Resources.Resources.icn_help
		Me.tsm_top_Help.Name = "tsm_top_Help"
		Me.tsm_top_Help.Size = New System.Drawing.Size(65, 21)
		Me.tsm_top_Help.Text = "Help"
		'
		'tsm_Register
		'
		Me.tsm_Register.Enabled = False
		Me.tsm_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_Register.Image = Global.BO_Zombies.My.Resources.Resources.icn_register
		Me.tsm_Register.Name = "tsm_Register"
		Me.tsm_Register.Size = New System.Drawing.Size(224, 26)
		Me.tsm_Register.Text = "{Register Product}"
		'
		'tsm_Separator_Help1
		'
		Me.tsm_Separator_Help1.Name = "tsm_Separator_Help1"
		Me.tsm_Separator_Help1.Size = New System.Drawing.Size(221, 6)
		'
		'tsm_Contents
		'
		Me.tsm_Contents.Enabled = False
		Me.tsm_Contents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_Contents.Image = Global.BO_Zombies.My.Resources.Resources.icn_content
		Me.tsm_Contents.Name = "tsm_Contents"
		Me.tsm_Contents.Size = New System.Drawing.Size(224, 26)
		Me.tsm_Contents.Text = "Contents"
		'
		'tsm_About
		'
		Me.tsm_About.Enabled = False
		Me.tsm_About.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_About.Image = Global.BO_Zombies.My.Resources.Resources.icn_about
		Me.tsm_About.Name = "tsm_About"
		Me.tsm_About.Size = New System.Drawing.Size(224, 26)
		Me.tsm_About.Text = "About..."
		'
		'tsm_BugReport
		'
		Me.tsm_BugReport.Enabled = False
		Me.tsm_BugReport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_BugReport.Image = Global.BO_Zombies.My.Resources.Resources.icn_bugreport
		Me.tsm_BugReport.Name = "tsm_BugReport"
		Me.tsm_BugReport.Size = New System.Drawing.Size(224, 26)
		Me.tsm_BugReport.Text = "Send Bug Report"
		'
		'tsm_Separator_Help2
		'
		Me.tsm_Separator_Help2.Name = "tsm_Separator_Help2"
		Me.tsm_Separator_Help2.Size = New System.Drawing.Size(221, 6)
		'
		'tsm_Donate
		'
		Me.tsm_Donate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.tsm_Donate.Image = Global.BO_Zombies.My.Resources.Resources.icn_donate
		Me.tsm_Donate.Name = "tsm_Donate"
		Me.tsm_Donate.Size = New System.Drawing.Size(224, 26)
		Me.tsm_Donate.Text = "Donate"
		'
		'btn_Manual_Entry
		'
		Me.btn_Manual_Entry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Manual_Entry.Location = New System.Drawing.Point(201, 48)
		Me.btn_Manual_Entry.MaximumSize = New System.Drawing.Size(183, 26)
		Me.btn_Manual_Entry.Name = "btn_Manual_Entry"
		Me.btn_Manual_Entry.Size = New System.Drawing.Size(151, 26)
		Me.btn_Manual_Entry.TabIndex = 35
		Me.btn_Manual_Entry.Text = "Submit to Log"
		Me.btn_Manual_Entry.UseVisualStyleBackColor = True
		'
		'gbx_TotalLables
		'
		Me.gbx_TotalLables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbx_TotalLables.BackColor = System.Drawing.Color.Transparent
		Me.gbx_TotalLables.Controls.Add(Me.lbl_Score_Revive)
		Me.gbx_TotalLables.Controls.Add(Me.lbl_Score_Revive_Lable)
		Me.gbx_TotalLables.Controls.Add(Me.lbl_Score_Down)
		Me.gbx_TotalLables.Controls.Add(Me.lbl_Score_Down_Lable)
		Me.gbx_TotalLables.Controls.Add(Me.lbl_Score_Spent)
		Me.gbx_TotalLables.Controls.Add(Me.lbl_Score_Spent_Lable)
		Me.gbx_TotalLables.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_TotalLables.Location = New System.Drawing.Point(593, 391)
		Me.gbx_TotalLables.Name = "gbx_TotalLables"
		Me.gbx_TotalLables.Size = New System.Drawing.Size(545, 94)
		Me.gbx_TotalLables.TabIndex = 43
		Me.gbx_TotalLables.TabStop = False
		Me.gbx_TotalLables.Text = "Global Totals"
		'
		'lbl_Score_Revive
		'
		Me.lbl_Score_Revive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Revive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Revive.Location = New System.Drawing.Point(181, 52)
		Me.lbl_Score_Revive.Name = "lbl_Score_Revive"
		Me.lbl_Score_Revive.Size = New System.Drawing.Size(166, 27)
		Me.lbl_Score_Revive.TabIndex = 224
		Me.lbl_Score_Revive.Text = "9,999,999"
		Me.lbl_Score_Revive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Score_Revive_Lable
		'
		Me.lbl_Score_Revive_Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Revive_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Revive_Lable.Location = New System.Drawing.Point(181, 28)
		Me.lbl_Score_Revive_Lable.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.lbl_Score_Revive_Lable.Name = "lbl_Score_Revive_Lable"
		Me.lbl_Score_Revive_Lable.Size = New System.Drawing.Size(166, 25)
		Me.lbl_Score_Revive_Lable.TabIndex = 223
		Me.lbl_Score_Revive_Lable.Text = "Revive & Manual."
		Me.lbl_Score_Revive_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Score_Revive_Lable.UseMnemonic = False
		'
		'lbl_Score_Down
		'
		Me.lbl_Score_Down.BackColor = System.Drawing.Color.Transparent
		Me.lbl_Score_Down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Down.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Down.Location = New System.Drawing.Point(353, 52)
		Me.lbl_Score_Down.Name = "lbl_Score_Down"
		Me.lbl_Score_Down.Size = New System.Drawing.Size(166, 27)
		Me.lbl_Score_Down.TabIndex = 222
		Me.lbl_Score_Down.Text = "9,999,999"
		Me.lbl_Score_Down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Score_Down_Lable
		'
		Me.lbl_Score_Down_Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Down_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Down_Lable.Location = New System.Drawing.Point(353, 28)
		Me.lbl_Score_Down_Lable.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.lbl_Score_Down_Lable.Name = "lbl_Score_Down_Lable"
		Me.lbl_Score_Down_Lable.Size = New System.Drawing.Size(166, 25)
		Me.lbl_Score_Down_Lable.TabIndex = 221
		Me.lbl_Score_Down_Lable.Text = "Down & Bleedout"
		Me.lbl_Score_Down_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Score_Down_Lable.UseMnemonic = False
		'
		'lbl_Score_Spent
		'
		Me.lbl_Score_Spent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Spent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Spent.Location = New System.Drawing.Point(9, 52)
		Me.lbl_Score_Spent.Name = "lbl_Score_Spent"
		Me.lbl_Score_Spent.Size = New System.Drawing.Size(166, 27)
		Me.lbl_Score_Spent.TabIndex = 220
		Me.lbl_Score_Spent.Text = "9,999,999"
		Me.lbl_Score_Spent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Score_Spent_Lable
		'
		Me.lbl_Score_Spent_Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Spent_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Spent_Lable.Location = New System.Drawing.Point(9, 28)
		Me.lbl_Score_Spent_Lable.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.lbl_Score_Spent_Lable.Name = "lbl_Score_Spent_Lable"
		Me.lbl_Score_Spent_Lable.Size = New System.Drawing.Size(166, 25)
		Me.lbl_Score_Spent_Lable.TabIndex = 219
		Me.lbl_Score_Spent_Lable.Text = "Items Bought/Hacked."
		Me.lbl_Score_Spent_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ptb_Score_Grand
		'
		Me.ptb_Score_Grand.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_light
		Me.ptb_Score_Grand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ptb_Score_Grand.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ptb_Score_Grand.Location = New System.Drawing.Point(485, 53)
		Me.ptb_Score_Grand.Name = "ptb_Score_Grand"
		Me.ptb_Score_Grand.Size = New System.Drawing.Size(34, 34)
		Me.ptb_Score_Grand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.ptb_Score_Grand.TabIndex = 218
		Me.ptb_Score_Grand.TabStop = False
		'
		'lbl_Score_Grand_Lable
		'
		Me.lbl_Score_Grand_Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Grand_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Grand_Lable.Location = New System.Drawing.Point(7, 29)
		Me.lbl_Score_Grand_Lable.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
		Me.lbl_Score_Grand_Lable.Name = "lbl_Score_Grand_Lable"
		Me.lbl_Score_Grand_Lable.Size = New System.Drawing.Size(513, 24)
		Me.lbl_Score_Grand_Lable.TabIndex = 12
		Me.lbl_Score_Grand_Lable.Text = "Total Over All Score"
		Me.lbl_Score_Grand_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ptb_Score_Maximum
		'
		Me.ptb_Score_Maximum.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_light
		Me.ptb_Score_Maximum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ptb_Score_Maximum.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ptb_Score_Maximum.Location = New System.Drawing.Point(485, 119)
		Me.ptb_Score_Maximum.Name = "ptb_Score_Maximum"
		Me.ptb_Score_Maximum.Size = New System.Drawing.Size(34, 34)
		Me.ptb_Score_Maximum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.ptb_Score_Maximum.TabIndex = 217
		Me.ptb_Score_Maximum.TabStop = False
		'
		'ptb_Score_Should
		'
		Me.ptb_Score_Should.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_light
		Me.ptb_Score_Should.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ptb_Score_Should.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ptb_Score_Should.Location = New System.Drawing.Point(485, 185)
		Me.ptb_Score_Should.Name = "ptb_Score_Should"
		Me.ptb_Score_Should.Size = New System.Drawing.Size(34, 34)
		Me.ptb_Score_Should.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.ptb_Score_Should.TabIndex = 216
		Me.ptb_Score_Should.TabStop = False
		'
		'lbl_Score_Grand
		'
		Me.lbl_Score_Grand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Grand.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Grand.Location = New System.Drawing.Point(7, 52)
		Me.lbl_Score_Grand.Name = "lbl_Score_Grand"
		Me.lbl_Score_Grand.Size = New System.Drawing.Size(513, 36)
		Me.lbl_Score_Grand.TabIndex = 4
		Me.lbl_Score_Grand.Text = "9,999,999"
		Me.lbl_Score_Grand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Score_Maximum
		'
		Me.lbl_Score_Maximum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Maximum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_Score_Maximum.Location = New System.Drawing.Point(7, 118)
		Me.lbl_Score_Maximum.Name = "lbl_Score_Maximum"
		Me.lbl_Score_Maximum.Size = New System.Drawing.Size(513, 36)
		Me.lbl_Score_Maximum.TabIndex = 5
		Me.lbl_Score_Maximum.Text = "9,999,999"
		Me.lbl_Score_Maximum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Score_Should
		'
		Me.lbl_Score_Should.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Should.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_Score_Should.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
		Me.lbl_Score_Should.Location = New System.Drawing.Point(7, 184)
		Me.lbl_Score_Should.Name = "lbl_Score_Should"
		Me.lbl_Score_Should.Size = New System.Drawing.Size(513, 36)
		Me.lbl_Score_Should.TabIndex = 6
		Me.lbl_Score_Should.Text = "9,999,999"
		Me.lbl_Score_Should.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'gbx_OtherForms
		'
		Me.gbx_OtherForms.BackColor = System.Drawing.Color.Transparent
		Me.gbx_OtherForms.Controls.Add(Me.btn_KillTracker)
		Me.gbx_OtherForms.Controls.Add(Me.btn_Weapons)
		Me.gbx_OtherForms.Controls.Add(Me.btn_SamsGame)
		Me.gbx_OtherForms.Controls.Add(Me.btn_Downs)
		Me.gbx_OtherForms.Controls.Add(Me.btn_Revive)
		Me.gbx_OtherForms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_OtherForms.Location = New System.Drawing.Point(352, 339)
		Me.gbx_OtherForms.Name = "gbx_OtherForms"
		Me.gbx_OtherForms.Size = New System.Drawing.Size(235, 146)
		Me.gbx_OtherForms.TabIndex = 42
		Me.gbx_OtherForms.TabStop = False
		Me.gbx_OtherForms.Text = "Quick Form Access"
		'
		'btn_SamsGame
		'
		Me.btn_SamsGame.BackColor = System.Drawing.Color.Transparent
		Me.btn_SamsGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_SamsGame.Location = New System.Drawing.Point(120, 25)
		Me.btn_SamsGame.Name = "btn_SamsGame"
		Me.btn_SamsGame.Size = New System.Drawing.Size(108, 36)
		Me.btn_SamsGame.TabIndex = 2
		Me.btn_SamsGame.Text = "Samantha's Game"
		Me.btn_SamsGame.UseVisualStyleBackColor = False
		'
		'btn_Downs
		'
		Me.btn_Downs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Downs.Location = New System.Drawing.Point(6, 85)
		Me.btn_Downs.Name = "btn_Downs"
		Me.btn_Downs.Size = New System.Drawing.Size(108, 53)
		Me.btn_Downs.TabIndex = 0
		Me.btn_Downs.Text = "Down and Bleedout"
		Me.btn_Downs.UseVisualStyleBackColor = True
		'
		'btn_Revive
		'
		Me.btn_Revive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Revive.Location = New System.Drawing.Point(6, 25)
		Me.btn_Revive.Name = "btn_Revive"
		Me.btn_Revive.Size = New System.Drawing.Size(108, 53)
		Me.btn_Revive.TabIndex = 1
		Me.btn_Revive.Text = "Revive Glitch"
		Me.btn_Revive.UseVisualStyleBackColor = True
		'
		'gbx_Other_Items
		'
		Me.gbx_Other_Items.BackColor = System.Drawing.Color.Transparent
		Me.gbx_Other_Items.Controls.Add(Me.btn_Bowie_Knife)
		Me.gbx_Other_Items.Controls.Add(Me.btn_Semtex)
		Me.gbx_Other_Items.Controls.Add(Me.btn_Claymores)
		Me.gbx_Other_Items.Controls.Add(Me.btn_Easter_Egg_Button)
		Me.gbx_Other_Items.Controls.Add(Me.lbl_Easter_Egg_Button)
		Me.gbx_Other_Items.Controls.Add(Me.lbl_Semtex)
		Me.gbx_Other_Items.Controls.Add(Me.lbl_Bowie_Knife)
		Me.gbx_Other_Items.Controls.Add(Me.lbl_Claymores)
		Me.gbx_Other_Items.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_Other_Items.Location = New System.Drawing.Point(12, 339)
		Me.gbx_Other_Items.Name = "gbx_Other_Items"
		Me.gbx_Other_Items.Size = New System.Drawing.Size(204, 146)
		Me.gbx_Other_Items.TabIndex = 41
		Me.gbx_Other_Items.TabStop = False
		Me.gbx_Other_Items.Text = "Other Items"
		'
		'btn_Bowie_Knife
		'
		Me.btn_Bowie_Knife.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Bowie_Knife.Location = New System.Drawing.Point(6, 25)
		Me.btn_Bowie_Knife.Name = "btn_Bowie_Knife"
		Me.btn_Bowie_Knife.Size = New System.Drawing.Size(92, 39)
		Me.btn_Bowie_Knife.TabIndex = 14
		Me.btn_Bowie_Knife.Text = "Bowie Knife"
		Me.btn_Bowie_Knife.UseVisualStyleBackColor = True
		'
		'btn_Semtex
		'
		Me.btn_Semtex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Semtex.Location = New System.Drawing.Point(6, 85)
		Me.btn_Semtex.Name = "btn_Semtex"
		Me.btn_Semtex.Size = New System.Drawing.Size(92, 39)
		Me.btn_Semtex.TabIndex = 15
		Me.btn_Semtex.Text = "Semtex"
		Me.btn_Semtex.UseVisualStyleBackColor = True
		'
		'btn_Claymores
		'
		Me.btn_Claymores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Claymores.Location = New System.Drawing.Point(104, 25)
		Me.btn_Claymores.Name = "btn_Claymores"
		Me.btn_Claymores.Size = New System.Drawing.Size(92, 39)
		Me.btn_Claymores.TabIndex = 16
		Me.btn_Claymores.Text = "Claymores"
		Me.btn_Claymores.UseVisualStyleBackColor = True
		'
		'btn_Easter_Egg_Button
		'
		Me.btn_Easter_Egg_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Easter_Egg_Button.Location = New System.Drawing.Point(104, 85)
		Me.btn_Easter_Egg_Button.Name = "btn_Easter_Egg_Button"
		Me.btn_Easter_Egg_Button.Size = New System.Drawing.Size(92, 39)
		Me.btn_Easter_Egg_Button.TabIndex = 19
		Me.btn_Easter_Egg_Button.Text = "Easter Egg"
		Me.btn_Easter_Egg_Button.UseVisualStyleBackColor = True
		'
		'lbl_Easter_Egg_Button
		'
		Me.lbl_Easter_Egg_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Easter_Egg_Button.Location = New System.Drawing.Point(104, 122)
		Me.lbl_Easter_Egg_Button.Name = "lbl_Easter_Egg_Button"
		Me.lbl_Easter_Egg_Button.Size = New System.Drawing.Size(92, 20)
		Me.lbl_Easter_Egg_Button.TabIndex = 9
		Me.lbl_Easter_Egg_Button.Tag = "Summarizable"
		Me.lbl_Easter_Egg_Button.Text = "99999"
		Me.lbl_Easter_Egg_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Semtex
		'
		Me.lbl_Semtex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Semtex.Location = New System.Drawing.Point(6, 122)
		Me.lbl_Semtex.Name = "lbl_Semtex"
		Me.lbl_Semtex.Size = New System.Drawing.Size(92, 20)
		Me.lbl_Semtex.TabIndex = 5
		Me.lbl_Semtex.Tag = "Summarizable"
		Me.lbl_Semtex.Text = "99999"
		Me.lbl_Semtex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Bowie_Knife
		'
		Me.lbl_Bowie_Knife.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Bowie_Knife.Location = New System.Drawing.Point(6, 62)
		Me.lbl_Bowie_Knife.Name = "lbl_Bowie_Knife"
		Me.lbl_Bowie_Knife.Size = New System.Drawing.Size(92, 20)
		Me.lbl_Bowie_Knife.TabIndex = 4
		Me.lbl_Bowie_Knife.Tag = "Summarizable"
		Me.lbl_Bowie_Knife.Text = "99999"
		Me.lbl_Bowie_Knife.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Claymores
		'
		Me.lbl_Claymores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Claymores.Location = New System.Drawing.Point(104, 62)
		Me.lbl_Claymores.Name = "lbl_Claymores"
		Me.lbl_Claymores.Size = New System.Drawing.Size(92, 20)
		Me.lbl_Claymores.TabIndex = 6
		Me.lbl_Claymores.Tag = "Summarizable"
		Me.lbl_Claymores.Text = "99999"
		Me.lbl_Claymores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btn_Score_Current
		'
		Me.btn_Score_Current.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Score_Current.Location = New System.Drawing.Point(201, 112)
		Me.btn_Score_Current.MaximumSize = New System.Drawing.Size(183, 26)
		Me.btn_Score_Current.Name = "btn_Score_Current"
		Me.btn_Score_Current.Size = New System.Drawing.Size(151, 26)
		Me.btn_Score_Current.TabIndex = 37
		Me.btn_Score_Current.Text = "Update Score"
		Me.btn_Score_Current.UseVisualStyleBackColor = True
		'
		'gbx_Activity_Log
		'
		Me.gbx_Activity_Log.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.gbx_Activity_Log.BackColor = System.Drawing.Color.Transparent
		Me.gbx_Activity_Log.Controls.Add(Me.dgd_Activity_Log)
		Me.gbx_Activity_Log.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbx_Activity_Log.Location = New System.Drawing.Point(12, 491)
		Me.gbx_Activity_Log.Name = "gbx_Activity_Log"
		Me.gbx_Activity_Log.Size = New System.Drawing.Size(575, 229)
		Me.gbx_Activity_Log.TabIndex = 39
		Me.gbx_Activity_Log.TabStop = False
		Me.gbx_Activity_Log.Text = "  Activity Log     "
		'
		'dgd_Activity_Log
		'
		Me.dgd_Activity_Log.AllowUserToAddRows = False
		Me.dgd_Activity_Log.AllowUserToDeleteRows = False
		Me.dgd_Activity_Log.AllowUserToResizeColumns = False
		Me.dgd_Activity_Log.AllowUserToResizeRows = False
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
		Me.dgd_Activity_Log.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgd_Activity_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgd_Activity_Log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgd_Activity_Log.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dgd_Activity_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgd_Activity_Log.Location = New System.Drawing.Point(6, 20)
		Me.dgd_Activity_Log.MultiSelect = False
		Me.dgd_Activity_Log.Name = "dgd_Activity_Log"
		Me.dgd_Activity_Log.ReadOnly = True
		Me.dgd_Activity_Log.RowHeadersVisible = False
		Me.dgd_Activity_Log.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgd_Activity_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgd_Activity_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgd_Activity_Log.ShowCellErrors = False
		Me.dgd_Activity_Log.ShowCellToolTips = False
		Me.dgd_Activity_Log.ShowEditingIcon = False
		Me.dgd_Activity_Log.ShowRowErrors = False
		Me.dgd_Activity_Log.Size = New System.Drawing.Size(562, 203)
		Me.dgd_Activity_Log.TabIndex = 0
		Me.dgd_Activity_Log.TabStop = False
		'
		'gbx_Upgrades
		'
		Me.gbx_Upgrades.BackColor = System.Drawing.Color.Transparent
		Me.gbx_Upgrades.Controls.Add(Me.btn_Pack_A_Punch)
		Me.gbx_Upgrades.Controls.Add(Me.btn_Upgraded_Ammo)
		Me.gbx_Upgrades.Controls.Add(Me.lbl_Upgraded_Ammo)
		Me.gbx_Upgrades.Controls.Add(Me.lbl_Pack_A_Punch)
		Me.gbx_Upgrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_Upgrades.Location = New System.Drawing.Point(222, 339)
		Me.gbx_Upgrades.Name = "gbx_Upgrades"
		Me.gbx_Upgrades.Size = New System.Drawing.Size(124, 146)
		Me.gbx_Upgrades.TabIndex = 38
		Me.gbx_Upgrades.TabStop = False
		Me.gbx_Upgrades.Text = "Upgrades"
		'
		'btn_Pack_A_Punch
		'
		Me.btn_Pack_A_Punch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Pack_A_Punch.Location = New System.Drawing.Point(6, 25)
		Me.btn_Pack_A_Punch.Name = "btn_Pack_A_Punch"
		Me.btn_Pack_A_Punch.Size = New System.Drawing.Size(112, 39)
		Me.btn_Pack_A_Punch.TabIndex = 17
		Me.btn_Pack_A_Punch.Text = "Pack a Punch"
		Me.btn_Pack_A_Punch.UseVisualStyleBackColor = True
		'
		'btn_Upgraded_Ammo
		'
		Me.btn_Upgraded_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Upgraded_Ammo.Location = New System.Drawing.Point(6, 85)
		Me.btn_Upgraded_Ammo.Name = "btn_Upgraded_Ammo"
		Me.btn_Upgraded_Ammo.Size = New System.Drawing.Size(112, 39)
		Me.btn_Upgraded_Ammo.TabIndex = 18
		Me.btn_Upgraded_Ammo.Text = "Ammo (4500)"
		Me.btn_Upgraded_Ammo.UseVisualStyleBackColor = True
		'
		'lbl_Upgraded_Ammo
		'
		Me.lbl_Upgraded_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Upgraded_Ammo.Location = New System.Drawing.Point(6, 122)
		Me.lbl_Upgraded_Ammo.Name = "lbl_Upgraded_Ammo"
		Me.lbl_Upgraded_Ammo.Size = New System.Drawing.Size(112, 20)
		Me.lbl_Upgraded_Ammo.TabIndex = 8
		Me.lbl_Upgraded_Ammo.Tag = "Summarizable"
		Me.lbl_Upgraded_Ammo.Text = "99999"
		Me.lbl_Upgraded_Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Pack_A_Punch
		'
		Me.lbl_Pack_A_Punch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Pack_A_Punch.Location = New System.Drawing.Point(6, 62)
		Me.lbl_Pack_A_Punch.Name = "lbl_Pack_A_Punch"
		Me.lbl_Pack_A_Punch.Size = New System.Drawing.Size(112, 20)
		Me.lbl_Pack_A_Punch.TabIndex = 7
		Me.lbl_Pack_A_Punch.Tag = "Summarizable"
		Me.lbl_Pack_A_Punch.Text = "99999"
		Me.lbl_Pack_A_Punch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'gbx_Doors
		'
		Me.gbx_Doors.BackColor = System.Drawing.Color.Transparent
		Me.gbx_Doors.Controls.Add(Me.btn_Hack_Door)
		Me.gbx_Doors.Controls.Add(Me.btn_Door_750)
		Me.gbx_Doors.Controls.Add(Me.btn_Door_1250)
		Me.gbx_Doors.Controls.Add(Me.btn_Door_1000)
		Me.gbx_Doors.Controls.Add(Me.lbl_Door_1000)
		Me.gbx_Doors.Controls.Add(Me.lbl_Door_1250)
		Me.gbx_Doors.Controls.Add(Me.lbl_Door_750)
		Me.gbx_Doors.Controls.Add(Me.lbl_Hack_Door)
		Me.gbx_Doors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_Doors.Location = New System.Drawing.Point(352, 239)
		Me.gbx_Doors.Name = "gbx_Doors"
		Me.gbx_Doors.Size = New System.Drawing.Size(235, 94)
		Me.gbx_Doors.TabIndex = 31
		Me.gbx_Doors.TabStop = False
		Me.gbx_Doors.Text = "Doors"
		'
		'btn_Hack_Door
		'
		Me.btn_Hack_Door.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Hack_Door.Location = New System.Drawing.Point(11, 25)
		Me.btn_Hack_Door.Margin = New System.Windows.Forms.Padding(0)
		Me.btn_Hack_Door.Name = "btn_Hack_Door"
		Me.btn_Hack_Door.Size = New System.Drawing.Size(50, 39)
		Me.btn_Hack_Door.TabIndex = 4
		Me.btn_Hack_Door.Text = "Hack"
		Me.btn_Hack_Door.UseVisualStyleBackColor = True
		'
		'btn_Door_750
		'
		Me.btn_Door_750.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Door_750.Location = New System.Drawing.Point(65, 25)
		Me.btn_Door_750.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
		Me.btn_Door_750.Name = "btn_Door_750"
		Me.btn_Door_750.Size = New System.Drawing.Size(50, 39)
		Me.btn_Door_750.TabIndex = 5
		Me.btn_Door_750.Text = "750"
		Me.btn_Door_750.UseMnemonic = False
		Me.btn_Door_750.UseVisualStyleBackColor = True
		'
		'btn_Door_1250
		'
		Me.btn_Door_1250.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Door_1250.Location = New System.Drawing.Point(173, 25)
		Me.btn_Door_1250.Margin = New System.Windows.Forms.Padding(0)
		Me.btn_Door_1250.Name = "btn_Door_1250"
		Me.btn_Door_1250.Size = New System.Drawing.Size(50, 39)
		Me.btn_Door_1250.TabIndex = 7
		Me.btn_Door_1250.Text = "1250"
		Me.btn_Door_1250.UseVisualStyleBackColor = True
		'
		'btn_Door_1000
		'
		Me.btn_Door_1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Door_1000.Location = New System.Drawing.Point(119, 25)
		Me.btn_Door_1000.Margin = New System.Windows.Forms.Padding(0)
		Me.btn_Door_1000.Name = "btn_Door_1000"
		Me.btn_Door_1000.Size = New System.Drawing.Size(50, 39)
		Me.btn_Door_1000.TabIndex = 6
		Me.btn_Door_1000.Text = "1000"
		Me.btn_Door_1000.UseVisualStyleBackColor = True
		'
		'lbl_Door_1000
		'
		Me.lbl_Door_1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Door_1000.Location = New System.Drawing.Point(119, 62)
		Me.lbl_Door_1000.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbl_Door_1000.Name = "lbl_Door_1000"
		Me.lbl_Door_1000.Size = New System.Drawing.Size(50, 20)
		Me.lbl_Door_1000.TabIndex = 2
		Me.lbl_Door_1000.Tag = "Summarizable"
		Me.lbl_Door_1000.Text = "9,999"
		Me.lbl_Door_1000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Door_1250
		'
		Me.lbl_Door_1250.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Door_1250.Location = New System.Drawing.Point(173, 62)
		Me.lbl_Door_1250.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbl_Door_1250.Name = "lbl_Door_1250"
		Me.lbl_Door_1250.Size = New System.Drawing.Size(50, 20)
		Me.lbl_Door_1250.TabIndex = 3
		Me.lbl_Door_1250.Tag = "Summarizable"
		Me.lbl_Door_1250.Text = "9,999"
		Me.lbl_Door_1250.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Door_750
		'
		Me.lbl_Door_750.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Door_750.Location = New System.Drawing.Point(65, 62)
		Me.lbl_Door_750.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbl_Door_750.Name = "lbl_Door_750"
		Me.lbl_Door_750.Size = New System.Drawing.Size(50, 20)
		Me.lbl_Door_750.TabIndex = 1
		Me.lbl_Door_750.Tag = "Summarizable"
		Me.lbl_Door_750.Text = "9,999"
		Me.lbl_Door_750.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Door_750.UseMnemonic = False
		'
		'lbl_Hack_Door
		'
		Me.lbl_Hack_Door.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Hack_Door.Location = New System.Drawing.Point(11, 62)
		Me.lbl_Hack_Door.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lbl_Hack_Door.Name = "lbl_Hack_Door"
		Me.lbl_Hack_Door.Size = New System.Drawing.Size(50, 20)
		Me.lbl_Hack_Door.TabIndex = 0
		Me.lbl_Hack_Door.Tag = "Summarizable"
		Me.lbl_Hack_Door.Text = "9,999"
		Me.lbl_Hack_Door.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'gbx_The_Mystery_box
		'
		Me.gbx_The_Mystery_box.BackColor = System.Drawing.Color.Transparent
		Me.gbx_The_Mystery_box.Controls.Add(Me.btn_Teddy_Hack)
		Me.gbx_The_Mystery_box.Controls.Add(Me.btn_Firesale_Box)
		Me.gbx_The_Mystery_box.Controls.Add(Me.btn_Hack_The_Box)
		Me.gbx_The_Mystery_box.Controls.Add(Me.btn_Buy_The_Box)
		Me.gbx_The_Mystery_box.Controls.Add(Me.btn_Buy_And_Hack_Box)
		Me.gbx_The_Mystery_box.Controls.Add(Me.lbl_Hack_The_Box)
		Me.gbx_The_Mystery_box.Controls.Add(Me.lbl_Buy_The_Box)
		Me.gbx_The_Mystery_box.Controls.Add(Me.lbl_Teddy_Hack)
		Me.gbx_The_Mystery_box.Controls.Add(Me.lbl_Firesale_Box)
		Me.gbx_The_Mystery_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_The_Mystery_box.Location = New System.Drawing.Point(352, 28)
		Me.gbx_The_Mystery_box.Name = "gbx_The_Mystery_box"
		Me.gbx_The_Mystery_box.Size = New System.Drawing.Size(235, 205)
		Me.gbx_The_Mystery_box.TabIndex = 28
		Me.gbx_The_Mystery_box.TabStop = False
		Me.gbx_The_Mystery_box.Text = "The Mystery Box"
		'
		'btn_Teddy_Hack
		'
		Me.btn_Teddy_Hack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Teddy_Hack.Location = New System.Drawing.Point(6, 143)
		Me.btn_Teddy_Hack.Name = "btn_Teddy_Hack"
		Me.btn_Teddy_Hack.Size = New System.Drawing.Size(108, 40)
		Me.btn_Teddy_Hack.TabIndex = 3
		Me.btn_Teddy_Hack.Text = "Teddy Hack"
		Me.btn_Teddy_Hack.UseVisualStyleBackColor = True
		'
		'btn_Firesale_Box
		'
		Me.btn_Firesale_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Firesale_Box.Location = New System.Drawing.Point(120, 143)
		Me.btn_Firesale_Box.Name = "btn_Firesale_Box"
		Me.btn_Firesale_Box.Size = New System.Drawing.Size(108, 40)
		Me.btn_Firesale_Box.TabIndex = 4
		Me.btn_Firesale_Box.Text = "Fire Sale "
		Me.btn_Firesale_Box.UseVisualStyleBackColor = True
		'
		'btn_Hack_The_Box
		'
		Me.btn_Hack_The_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Hack_The_Box.Location = New System.Drawing.Point(120, 84)
		Me.btn_Hack_The_Box.Name = "btn_Hack_The_Box"
		Me.btn_Hack_The_Box.Size = New System.Drawing.Size(108, 40)
		Me.btn_Hack_The_Box.TabIndex = 2
		Me.btn_Hack_The_Box.Text = "Hack The Box"
		Me.btn_Hack_The_Box.UseVisualStyleBackColor = True
		'
		'btn_Buy_The_Box
		'
		Me.btn_Buy_The_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Buy_The_Box.Location = New System.Drawing.Point(6, 84)
		Me.btn_Buy_The_Box.Name = "btn_Buy_The_Box"
		Me.btn_Buy_The_Box.Size = New System.Drawing.Size(108, 40)
		Me.btn_Buy_The_Box.TabIndex = 1
		Me.btn_Buy_The_Box.Text = "Buy The Box"
		Me.btn_Buy_The_Box.UseVisualStyleBackColor = True
		'
		'btn_Buy_And_Hack_Box
		'
		Me.btn_Buy_And_Hack_Box.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btn_Buy_And_Hack_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Buy_And_Hack_Box.Location = New System.Drawing.Point(6, 25)
		Me.btn_Buy_And_Hack_Box.Name = "btn_Buy_And_Hack_Box"
		Me.btn_Buy_And_Hack_Box.Size = New System.Drawing.Size(222, 56)
		Me.btn_Buy_And_Hack_Box.TabIndex = 0
		Me.btn_Buy_And_Hack_Box.Text = "Buy & Hack the Mystery Box (Standard Hit & Hack)"
		Me.btn_Buy_And_Hack_Box.UseMnemonic = False
		Me.btn_Buy_And_Hack_Box.UseVisualStyleBackColor = True
		'
		'lbl_Hack_The_Box
		'
		Me.lbl_Hack_The_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Hack_The_Box.Location = New System.Drawing.Point(120, 121)
		Me.lbl_Hack_The_Box.Name = "lbl_Hack_The_Box"
		Me.lbl_Hack_The_Box.Size = New System.Drawing.Size(108, 20)
		Me.lbl_Hack_The_Box.TabIndex = 6
		Me.lbl_Hack_The_Box.Tag = "Summarizable"
		Me.lbl_Hack_The_Box.Text = "99999"
		Me.lbl_Hack_The_Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Buy_The_Box
		'
		Me.lbl_Buy_The_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_Buy_The_Box.Location = New System.Drawing.Point(6, 121)
		Me.lbl_Buy_The_Box.Name = "lbl_Buy_The_Box"
		Me.lbl_Buy_The_Box.Size = New System.Drawing.Size(108, 20)
		Me.lbl_Buy_The_Box.TabIndex = 5
		Me.lbl_Buy_The_Box.Tag = "Summarizable"
		Me.lbl_Buy_The_Box.Text = "99999"
		Me.lbl_Buy_The_Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Teddy_Hack
		'
		Me.lbl_Teddy_Hack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Teddy_Hack.Location = New System.Drawing.Point(6, 181)
		Me.lbl_Teddy_Hack.Name = "lbl_Teddy_Hack"
		Me.lbl_Teddy_Hack.Size = New System.Drawing.Size(108, 20)
		Me.lbl_Teddy_Hack.TabIndex = 7
		Me.lbl_Teddy_Hack.Tag = "Summarizable"
		Me.lbl_Teddy_Hack.Text = "99999"
		Me.lbl_Teddy_Hack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Firesale_Box
		'
		Me.lbl_Firesale_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_Firesale_Box.Location = New System.Drawing.Point(120, 181)
		Me.lbl_Firesale_Box.Name = "lbl_Firesale_Box"
		Me.lbl_Firesale_Box.Size = New System.Drawing.Size(108, 20)
		Me.lbl_Firesale_Box.TabIndex = 8
		Me.lbl_Firesale_Box.Tag = "Summarizable"
		Me.lbl_Firesale_Box.Text = "99999"
		Me.lbl_Firesale_Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'gbx_MajorHacks
		'
		Me.gbx_MajorHacks.BackColor = System.Drawing.Color.Transparent
		Me.gbx_MajorHacks.Controls.Add(Me.btn_Max_Ammo_Hack)
		Me.gbx_MajorHacks.Controls.Add(Me.lbl_Max_Ammo_Hack)
		Me.gbx_MajorHacks.Controls.Add(Me.btn_Hack_Player)
		Me.gbx_MajorHacks.Controls.Add(Me.lbl_Hack_Player)
		Me.gbx_MajorHacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_MajorHacks.Location = New System.Drawing.Point(593, 28)
		Me.gbx_MajorHacks.Name = "gbx_MajorHacks"
		Me.gbx_MajorHacks.Size = New System.Drawing.Size(204, 205)
		Me.gbx_MajorHacks.TabIndex = 30
		Me.gbx_MajorHacks.TabStop = False
		Me.gbx_MajorHacks.Text = "Major Hacks"
		'
		'btn_Max_Ammo_Hack
		'
		Me.btn_Max_Ammo_Hack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btn_Max_Ammo_Hack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Max_Ammo_Hack.Location = New System.Drawing.Point(7, 26)
		Me.btn_Max_Ammo_Hack.Name = "btn_Max_Ammo_Hack"
		Me.btn_Max_Ammo_Hack.Size = New System.Drawing.Size(190, 53)
		Me.btn_Max_Ammo_Hack.TabIndex = 4
		Me.btn_Max_Ammo_Hack.Text = "HACK MAX AMMO"
		Me.btn_Max_Ammo_Hack.UseVisualStyleBackColor = True
		'
		'lbl_Max_Ammo_Hack
		'
		Me.lbl_Max_Ammo_Hack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_Max_Ammo_Hack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Max_Ammo_Hack.Location = New System.Drawing.Point(8, 82)
		Me.lbl_Max_Ammo_Hack.Name = "lbl_Max_Ammo_Hack"
		Me.lbl_Max_Ammo_Hack.Size = New System.Drawing.Size(190, 23)
		Me.lbl_Max_Ammo_Hack.TabIndex = 1
		Me.lbl_Max_Ammo_Hack.Tag = "Summarizable"
		Me.lbl_Max_Ammo_Hack.Text = "999,999"
		Me.lbl_Max_Ammo_Hack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btn_Hack_Player
		'
		Me.btn_Hack_Player.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btn_Hack_Player.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Hack_Player.Location = New System.Drawing.Point(8, 108)
		Me.btn_Hack_Player.Name = "btn_Hack_Player"
		Me.btn_Hack_Player.Size = New System.Drawing.Size(190, 53)
		Me.btn_Hack_Player.TabIndex = 5
		Me.btn_Hack_Player.Text = "HACK A PLAYER"
		Me.btn_Hack_Player.UseVisualStyleBackColor = True
		'
		'lbl_Hack_Player
		'
		Me.lbl_Hack_Player.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_Hack_Player.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Hack_Player.Location = New System.Drawing.Point(8, 164)
		Me.lbl_Hack_Player.Name = "lbl_Hack_Player"
		Me.lbl_Hack_Player.Size = New System.Drawing.Size(190, 23)
		Me.lbl_Hack_Player.TabIndex = 2
		Me.lbl_Hack_Player.Tag = "Summarizable"
		Me.lbl_Hack_Player.Text = "999,999"
		Me.lbl_Hack_Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'gbx_Perks
		'
		Me.gbx_Perks.BackColor = System.Drawing.Color.Transparent
		Me.gbx_Perks.Controls.Add(Me.btn_Juggernog)
		Me.gbx_Perks.Controls.Add(Me.btn_Stammin_Up)
		Me.gbx_Perks.Controls.Add(Me.btn_Mule_Kick)
		Me.gbx_Perks.Controls.Add(Me.btn_PHD_Flopper)
		Me.gbx_Perks.Controls.Add(Me.btn_Perks_More)
		Me.gbx_Perks.Controls.Add(Me.btn_Speed_Cola)
		Me.gbx_Perks.Controls.Add(Me.btn_Double_Tap)
		Me.gbx_Perks.Controls.Add(Me.btn_Quick_Revive)
		Me.gbx_Perks.Controls.Add(Me.btn_Dead_Shot)
		Me.gbx_Perks.Controls.Add(Me.lbl_Juggernog)
		Me.gbx_Perks.Controls.Add(Me.lbl_Speed_Cola)
		Me.gbx_Perks.Controls.Add(Me.lbl_Stammin_Up)
		Me.gbx_Perks.Controls.Add(Me.lbl_Dead_Shot)
		Me.gbx_Perks.Controls.Add(Me.lbl_PHD_Flopper)
		Me.gbx_Perks.Controls.Add(Me.lbl_Double_Tap)
		Me.gbx_Perks.Controls.Add(Me.lbl_Mule_Kick)
		Me.gbx_Perks.Controls.Add(Me.lbl_Quick_Revive)
		Me.gbx_Perks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_Perks.Location = New System.Drawing.Point(222, 28)
		Me.gbx_Perks.Name = "gbx_Perks"
		Me.gbx_Perks.Size = New System.Drawing.Size(124, 305)
		Me.gbx_Perks.TabIndex = 27
		Me.gbx_Perks.TabStop = False
		Me.gbx_Perks.Text = "Perks"
		'
		'btn_Juggernog
		'
		Me.btn_Juggernog.BackColor = System.Drawing.Color.Transparent
		Me.btn_Juggernog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Juggernog.Location = New System.Drawing.Point(6, 24)
		Me.btn_Juggernog.Name = "btn_Juggernog"
		Me.btn_Juggernog.Size = New System.Drawing.Size(112, 39)
		Me.btn_Juggernog.TabIndex = 0
		Me.btn_Juggernog.Text = "Juggernog"
		Me.btn_Juggernog.UseVisualStyleBackColor = False
		'
		'btn_Stammin_Up
		'
		Me.btn_Stammin_Up.BackColor = System.Drawing.Color.Transparent
		Me.btn_Stammin_Up.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Stammin_Up.Location = New System.Drawing.Point(6, 84)
		Me.btn_Stammin_Up.Name = "btn_Stammin_Up"
		Me.btn_Stammin_Up.Size = New System.Drawing.Size(112, 39)
		Me.btn_Stammin_Up.TabIndex = 1
		Me.btn_Stammin_Up.Text = "Stammin Up"
		Me.btn_Stammin_Up.UseVisualStyleBackColor = False
		'
		'btn_Mule_Kick
		'
		Me.btn_Mule_Kick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Mule_Kick.Location = New System.Drawing.Point(6, 204)
		Me.btn_Mule_Kick.Name = "btn_Mule_Kick"
		Me.btn_Mule_Kick.Size = New System.Drawing.Size(112, 39)
		Me.btn_Mule_Kick.TabIndex = 3
		Me.btn_Mule_Kick.Text = "Mule Kick"
		Me.btn_Mule_Kick.UseVisualStyleBackColor = True
		'
		'btn_PHD_Flopper
		'
		Me.btn_PHD_Flopper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_PHD_Flopper.Location = New System.Drawing.Point(6, 144)
		Me.btn_PHD_Flopper.Name = "btn_PHD_Flopper"
		Me.btn_PHD_Flopper.Size = New System.Drawing.Size(112, 39)
		Me.btn_PHD_Flopper.TabIndex = 2
		Me.btn_PHD_Flopper.Text = "PHD Flopper"
		Me.btn_PHD_Flopper.UseVisualStyleBackColor = True
		'
		'btn_Perks_More
		'
		Me.btn_Perks_More.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btn_Perks_More.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.btn_Perks_More.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Perks_More.Location = New System.Drawing.Point(6, 268)
		Me.btn_Perks_More.Name = "btn_Perks_More"
		Me.btn_Perks_More.Size = New System.Drawing.Size(112, 31)
		Me.btn_Perks_More.TabIndex = 16
		Me.btn_Perks_More.Tag = "NonDynamic"
		Me.btn_Perks_More.Text = "Load More"
		Me.btn_Perks_More.UseVisualStyleBackColor = True
		'
		'btn_Speed_Cola
		'
		Me.btn_Speed_Cola.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Speed_Cola.Location = New System.Drawing.Point(6, 24)
		Me.btn_Speed_Cola.Name = "btn_Speed_Cola"
		Me.btn_Speed_Cola.Size = New System.Drawing.Size(112, 39)
		Me.btn_Speed_Cola.TabIndex = 4
		Me.btn_Speed_Cola.Text = "Speed Cola"
		Me.btn_Speed_Cola.UseVisualStyleBackColor = True
		Me.btn_Speed_Cola.Visible = False
		'
		'btn_Double_Tap
		'
		Me.btn_Double_Tap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Double_Tap.Location = New System.Drawing.Point(6, 144)
		Me.btn_Double_Tap.Name = "btn_Double_Tap"
		Me.btn_Double_Tap.Size = New System.Drawing.Size(112, 39)
		Me.btn_Double_Tap.TabIndex = 6
		Me.btn_Double_Tap.Text = "Double Tap"
		Me.btn_Double_Tap.UseVisualStyleBackColor = True
		Me.btn_Double_Tap.Visible = False
		'
		'btn_Quick_Revive
		'
		Me.btn_Quick_Revive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Quick_Revive.Location = New System.Drawing.Point(6, 204)
		Me.btn_Quick_Revive.Name = "btn_Quick_Revive"
		Me.btn_Quick_Revive.Size = New System.Drawing.Size(112, 39)
		Me.btn_Quick_Revive.TabIndex = 7
		Me.btn_Quick_Revive.Text = "Quick Revive"
		Me.btn_Quick_Revive.UseVisualStyleBackColor = True
		Me.btn_Quick_Revive.Visible = False
		'
		'btn_Dead_Shot
		'
		Me.btn_Dead_Shot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.btn_Dead_Shot.Location = New System.Drawing.Point(6, 84)
		Me.btn_Dead_Shot.Name = "btn_Dead_Shot"
		Me.btn_Dead_Shot.Size = New System.Drawing.Size(112, 39)
		Me.btn_Dead_Shot.TabIndex = 5
		Me.btn_Dead_Shot.Text = "Dead Shot"
		Me.btn_Dead_Shot.UseVisualStyleBackColor = True
		Me.btn_Dead_Shot.Visible = False
		'
		'lbl_Juggernog
		'
		Me.lbl_Juggernog.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Juggernog.Location = New System.Drawing.Point(6, 61)
		Me.lbl_Juggernog.Name = "lbl_Juggernog"
		Me.lbl_Juggernog.Size = New System.Drawing.Size(112, 20)
		Me.lbl_Juggernog.TabIndex = 8
		Me.lbl_Juggernog.Tag = "Summarizable"
		Me.lbl_Juggernog.Text = "99999"
		Me.lbl_Juggernog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Speed_Cola
		'
		Me.lbl_Speed_Cola.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Speed_Cola.Location = New System.Drawing.Point(6, 61)
		Me.lbl_Speed_Cola.Name = "lbl_Speed_Cola"
		Me.lbl_Speed_Cola.Size = New System.Drawing.Size(112, 20)
		Me.lbl_Speed_Cola.TabIndex = 12
		Me.lbl_Speed_Cola.Tag = "Summarizable"
		Me.lbl_Speed_Cola.Text = "99999"
		Me.lbl_Speed_Cola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Speed_Cola.Visible = False
		'
		'lbl_Stammin_Up
		'
		Me.lbl_Stammin_Up.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Stammin_Up.Location = New System.Drawing.Point(6, 121)
		Me.lbl_Stammin_Up.Name = "lbl_Stammin_Up"
		Me.lbl_Stammin_Up.Size = New System.Drawing.Size(112, 20)
		Me.lbl_Stammin_Up.TabIndex = 9
		Me.lbl_Stammin_Up.Tag = "Summarizable"
		Me.lbl_Stammin_Up.Text = "99999"
		Me.lbl_Stammin_Up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Dead_Shot
		'
		Me.lbl_Dead_Shot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Dead_Shot.Location = New System.Drawing.Point(6, 121)
		Me.lbl_Dead_Shot.Name = "lbl_Dead_Shot"
		Me.lbl_Dead_Shot.Size = New System.Drawing.Size(112, 20)
		Me.lbl_Dead_Shot.TabIndex = 13
		Me.lbl_Dead_Shot.Tag = "Summarizable"
		Me.lbl_Dead_Shot.Text = "99999"
		Me.lbl_Dead_Shot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Dead_Shot.Visible = False
		'
		'lbl_PHD_Flopper
		'
		Me.lbl_PHD_Flopper.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_PHD_Flopper.Location = New System.Drawing.Point(6, 181)
		Me.lbl_PHD_Flopper.Name = "lbl_PHD_Flopper"
		Me.lbl_PHD_Flopper.Size = New System.Drawing.Size(112, 20)
		Me.lbl_PHD_Flopper.TabIndex = 10
		Me.lbl_PHD_Flopper.Tag = "Summarizable"
		Me.lbl_PHD_Flopper.Text = "99999"
		Me.lbl_PHD_Flopper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Double_Tap
		'
		Me.lbl_Double_Tap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Double_Tap.Location = New System.Drawing.Point(6, 181)
		Me.lbl_Double_Tap.Name = "lbl_Double_Tap"
		Me.lbl_Double_Tap.Size = New System.Drawing.Size(112, 20)
		Me.lbl_Double_Tap.TabIndex = 14
		Me.lbl_Double_Tap.Tag = "Summarizable"
		Me.lbl_Double_Tap.Text = "99999"
		Me.lbl_Double_Tap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Double_Tap.Visible = False
		'
		'lbl_Mule_Kick
		'
		Me.lbl_Mule_Kick.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Mule_Kick.Location = New System.Drawing.Point(6, 241)
		Me.lbl_Mule_Kick.Name = "lbl_Mule_Kick"
		Me.lbl_Mule_Kick.Size = New System.Drawing.Size(112, 20)
		Me.lbl_Mule_Kick.TabIndex = 11
		Me.lbl_Mule_Kick.Tag = "Summarizable"
		Me.lbl_Mule_Kick.Text = "99999"
		Me.lbl_Mule_Kick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Quick_Revive
		'
		Me.lbl_Quick_Revive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Quick_Revive.Location = New System.Drawing.Point(6, 241)
		Me.lbl_Quick_Revive.Name = "lbl_Quick_Revive"
		Me.lbl_Quick_Revive.Size = New System.Drawing.Size(112, 20)
		Me.lbl_Quick_Revive.TabIndex = 15
		Me.lbl_Quick_Revive.Tag = "Summarizable"
		Me.lbl_Quick_Revive.Text = "99999"
		Me.lbl_Quick_Revive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Quick_Revive.Visible = False
		'
		'gbx_WallWeapons
		'
		Me.gbx_WallWeapons.BackColor = System.Drawing.Color.Transparent
		Me.gbx_WallWeapons.Controls.Add(Me.btn_MPL)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_MPL_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_AK74U)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_MP5K)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_M14)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_AK74U_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_M14_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_MP5K_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_Wall_Weapons_More)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_Stakeout_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_Stakeout)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_PM63_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_PM63)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_Olympia_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_Olympia)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_M16_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.btn_M16)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_AK74U)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_AK74U_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_Olympia_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_Olympia)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_MPL)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_MPL_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_M16_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_M16)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_M14_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_M14)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_PM63_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_PM63)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_MP5K_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_MP5K)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_Stakeout_Ammo)
		Me.gbx_WallWeapons.Controls.Add(Me.lbl_Stakeout)
		Me.gbx_WallWeapons.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_WallWeapons.Location = New System.Drawing.Point(12, 28)
		Me.gbx_WallWeapons.Name = "gbx_WallWeapons"
		Me.gbx_WallWeapons.Size = New System.Drawing.Size(204, 305)
		Me.gbx_WallWeapons.TabIndex = 1
		Me.gbx_WallWeapons.TabStop = False
		Me.gbx_WallWeapons.Text = "Wall Weapons"
		'
		'btn_MPL
		'
		Me.btn_MPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_MPL.Location = New System.Drawing.Point(10, 24)
		Me.btn_MPL.Name = "btn_MPL"
		Me.btn_MPL.Size = New System.Drawing.Size(102, 39)
		Me.btn_MPL.TabIndex = 0
		Me.btn_MPL.Tag = "Summarizable"
		Me.btn_MPL.Text = "MPL"
		Me.btn_MPL.UseVisualStyleBackColor = True
		'
		'btn_MPL_Ammo
		'
		Me.btn_MPL_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_MPL_Ammo.Location = New System.Drawing.Point(118, 24)
		Me.btn_MPL_Ammo.Name = "btn_MPL_Ammo"
		Me.btn_MPL_Ammo.Size = New System.Drawing.Size(75, 39)
		Me.btn_MPL_Ammo.TabIndex = 1
		Me.btn_MPL_Ammo.Text = "Ammo"
		Me.btn_MPL_Ammo.UseVisualStyleBackColor = True
		'
		'btn_AK74U
		'
		Me.btn_AK74U.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_AK74U.Location = New System.Drawing.Point(10, 84)
		Me.btn_AK74U.Name = "btn_AK74U"
		Me.btn_AK74U.Size = New System.Drawing.Size(102, 39)
		Me.btn_AK74U.TabIndex = 4
		Me.btn_AK74U.Text = "AK74U"
		Me.btn_AK74U.UseVisualStyleBackColor = True
		'
		'btn_MP5K
		'
		Me.btn_MP5K.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_MP5K.Location = New System.Drawing.Point(10, 204)
		Me.btn_MP5K.Name = "btn_MP5K"
		Me.btn_MP5K.Size = New System.Drawing.Size(102, 39)
		Me.btn_MP5K.TabIndex = 12
		Me.btn_MP5K.Text = "MP5K"
		Me.btn_MP5K.UseVisualStyleBackColor = True
		'
		'btn_M14
		'
		Me.btn_M14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_M14.Location = New System.Drawing.Point(10, 144)
		Me.btn_M14.Name = "btn_M14"
		Me.btn_M14.Size = New System.Drawing.Size(102, 39)
		Me.btn_M14.TabIndex = 8
		Me.btn_M14.Text = "M14"
		Me.btn_M14.UseVisualStyleBackColor = True
		'
		'btn_AK74U_Ammo
		'
		Me.btn_AK74U_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_AK74U_Ammo.Location = New System.Drawing.Point(118, 84)
		Me.btn_AK74U_Ammo.Name = "btn_AK74U_Ammo"
		Me.btn_AK74U_Ammo.Size = New System.Drawing.Size(75, 39)
		Me.btn_AK74U_Ammo.TabIndex = 5
		Me.btn_AK74U_Ammo.Text = "Ammo"
		Me.btn_AK74U_Ammo.UseVisualStyleBackColor = True
		'
		'btn_M14_Ammo
		'
		Me.btn_M14_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_M14_Ammo.Location = New System.Drawing.Point(118, 144)
		Me.btn_M14_Ammo.Name = "btn_M14_Ammo"
		Me.btn_M14_Ammo.Size = New System.Drawing.Size(75, 39)
		Me.btn_M14_Ammo.TabIndex = 9
		Me.btn_M14_Ammo.Text = "Ammo"
		Me.btn_M14_Ammo.UseVisualStyleBackColor = True
		'
		'btn_MP5K_Ammo
		'
		Me.btn_MP5K_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_MP5K_Ammo.Location = New System.Drawing.Point(118, 204)
		Me.btn_MP5K_Ammo.Name = "btn_MP5K_Ammo"
		Me.btn_MP5K_Ammo.Size = New System.Drawing.Size(75, 39)
		Me.btn_MP5K_Ammo.TabIndex = 13
		Me.btn_MP5K_Ammo.Text = "Ammo"
		Me.btn_MP5K_Ammo.UseVisualStyleBackColor = True
		'
		'btn_Wall_Weapons_More
		'
		Me.btn_Wall_Weapons_More.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Wall_Weapons_More.Location = New System.Drawing.Point(10, 268)
		Me.btn_Wall_Weapons_More.Name = "btn_Wall_Weapons_More"
		Me.btn_Wall_Weapons_More.Size = New System.Drawing.Size(183, 31)
		Me.btn_Wall_Weapons_More.TabIndex = 16
		Me.btn_Wall_Weapons_More.Tag = "NonDynamic"
		Me.btn_Wall_Weapons_More.Text = "Load More"
		Me.btn_Wall_Weapons_More.UseVisualStyleBackColor = True
		'
		'btn_Stakeout_Ammo
		'
		Me.btn_Stakeout_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Stakeout_Ammo.Location = New System.Drawing.Point(118, 204)
		Me.btn_Stakeout_Ammo.Name = "btn_Stakeout_Ammo"
		Me.btn_Stakeout_Ammo.Size = New System.Drawing.Size(75, 39)
		Me.btn_Stakeout_Ammo.TabIndex = 15
		Me.btn_Stakeout_Ammo.Text = "Ammo"
		Me.btn_Stakeout_Ammo.UseVisualStyleBackColor = True
		Me.btn_Stakeout_Ammo.Visible = False
		'
		'btn_Stakeout
		'
		Me.btn_Stakeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Stakeout.Location = New System.Drawing.Point(10, 204)
		Me.btn_Stakeout.Name = "btn_Stakeout"
		Me.btn_Stakeout.Size = New System.Drawing.Size(102, 39)
		Me.btn_Stakeout.TabIndex = 14
		Me.btn_Stakeout.Text = "Stakeout"
		Me.btn_Stakeout.UseVisualStyleBackColor = True
		Me.btn_Stakeout.Visible = False
		'
		'btn_PM63_Ammo
		'
		Me.btn_PM63_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_PM63_Ammo.Location = New System.Drawing.Point(118, 144)
		Me.btn_PM63_Ammo.Name = "btn_PM63_Ammo"
		Me.btn_PM63_Ammo.Size = New System.Drawing.Size(75, 39)
		Me.btn_PM63_Ammo.TabIndex = 13
		Me.btn_PM63_Ammo.Text = "Ammo"
		Me.btn_PM63_Ammo.UseVisualStyleBackColor = True
		Me.btn_PM63_Ammo.Visible = False
		'
		'btn_PM63
		'
		Me.btn_PM63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_PM63.Location = New System.Drawing.Point(10, 144)
		Me.btn_PM63.Name = "btn_PM63"
		Me.btn_PM63.Size = New System.Drawing.Size(102, 39)
		Me.btn_PM63.TabIndex = 12
		Me.btn_PM63.Text = "PM-63"
		Me.btn_PM63.UseVisualStyleBackColor = True
		Me.btn_PM63.Visible = False
		'
		'btn_Olympia_Ammo
		'
		Me.btn_Olympia_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Olympia_Ammo.Location = New System.Drawing.Point(118, 84)
		Me.btn_Olympia_Ammo.Name = "btn_Olympia_Ammo"
		Me.btn_Olympia_Ammo.Size = New System.Drawing.Size(75, 39)
		Me.btn_Olympia_Ammo.TabIndex = 11
		Me.btn_Olympia_Ammo.Text = "Ammo"
		Me.btn_Olympia_Ammo.UseVisualStyleBackColor = True
		Me.btn_Olympia_Ammo.Visible = False
		'
		'btn_Olympia
		'
		Me.btn_Olympia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Olympia.Location = New System.Drawing.Point(10, 84)
		Me.btn_Olympia.Name = "btn_Olympia"
		Me.btn_Olympia.Size = New System.Drawing.Size(102, 39)
		Me.btn_Olympia.TabIndex = 10
		Me.btn_Olympia.Text = "Olympia"
		Me.btn_Olympia.UseVisualStyleBackColor = True
		Me.btn_Olympia.Visible = False
		'
		'btn_M16_Ammo
		'
		Me.btn_M16_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_M16_Ammo.Location = New System.Drawing.Point(118, 24)
		Me.btn_M16_Ammo.Name = "btn_M16_Ammo"
		Me.btn_M16_Ammo.Size = New System.Drawing.Size(75, 39)
		Me.btn_M16_Ammo.TabIndex = 9
		Me.btn_M16_Ammo.Text = "Ammo"
		Me.btn_M16_Ammo.UseVisualStyleBackColor = True
		Me.btn_M16_Ammo.Visible = False
		'
		'btn_M16
		'
		Me.btn_M16.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btn_M16.FlatAppearance.BorderSize = 5
		Me.btn_M16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_M16.Location = New System.Drawing.Point(10, 24)
		Me.btn_M16.Name = "btn_M16"
		Me.btn_M16.Size = New System.Drawing.Size(102, 39)
		Me.btn_M16.TabIndex = 8
		Me.btn_M16.Text = "M16"
		Me.btn_M16.UseVisualStyleBackColor = True
		Me.btn_M16.Visible = False
		'
		'lbl_AK74U
		'
		Me.lbl_AK74U.BackColor = System.Drawing.Color.Transparent
		Me.lbl_AK74U.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_AK74U.Location = New System.Drawing.Point(10, 121)
		Me.lbl_AK74U.Name = "lbl_AK74U"
		Me.lbl_AK74U.Size = New System.Drawing.Size(102, 20)
		Me.lbl_AK74U.TabIndex = 6
		Me.lbl_AK74U.Tag = "Summarizable"
		Me.lbl_AK74U.Text = "999,999"
		Me.lbl_AK74U.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_AK74U_Ammo
		'
		Me.lbl_AK74U_Ammo.BackColor = System.Drawing.Color.Transparent
		Me.lbl_AK74U_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_AK74U_Ammo.Location = New System.Drawing.Point(118, 121)
		Me.lbl_AK74U_Ammo.Name = "lbl_AK74U_Ammo"
		Me.lbl_AK74U_Ammo.Size = New System.Drawing.Size(75, 20)
		Me.lbl_AK74U_Ammo.TabIndex = 7
		Me.lbl_AK74U_Ammo.Tag = "Summarizable"
		Me.lbl_AK74U_Ammo.Text = "999,999"
		Me.lbl_AK74U_Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Olympia_Ammo
		'
		Me.lbl_Olympia_Ammo.BackColor = System.Drawing.Color.Transparent
		Me.lbl_Olympia_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_Olympia_Ammo.Location = New System.Drawing.Point(118, 121)
		Me.lbl_Olympia_Ammo.Name = "lbl_Olympia_Ammo"
		Me.lbl_Olympia_Ammo.Size = New System.Drawing.Size(75, 20)
		Me.lbl_Olympia_Ammo.TabIndex = 27
		Me.lbl_Olympia_Ammo.Tag = "Summarizable"
		Me.lbl_Olympia_Ammo.Text = "999,999"
		Me.lbl_Olympia_Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Olympia_Ammo.Visible = False
		'
		'lbl_Olympia
		'
		Me.lbl_Olympia.BackColor = System.Drawing.Color.Transparent
		Me.lbl_Olympia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_Olympia.Location = New System.Drawing.Point(10, 121)
		Me.lbl_Olympia.Name = "lbl_Olympia"
		Me.lbl_Olympia.Size = New System.Drawing.Size(102, 20)
		Me.lbl_Olympia.TabIndex = 26
		Me.lbl_Olympia.Tag = "Summarizable"
		Me.lbl_Olympia.Text = "999,999"
		Me.lbl_Olympia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Olympia.Visible = False
		'
		'lbl_MPL
		'
		Me.lbl_MPL.BackColor = System.Drawing.Color.Transparent
		Me.lbl_MPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_MPL.Location = New System.Drawing.Point(10, 61)
		Me.lbl_MPL.Name = "lbl_MPL"
		Me.lbl_MPL.Size = New System.Drawing.Size(102, 20)
		Me.lbl_MPL.TabIndex = 2
		Me.lbl_MPL.Tag = "Summarizable"
		Me.lbl_MPL.Text = "999,999"
		Me.lbl_MPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_MPL_Ammo
		'
		Me.lbl_MPL_Ammo.BackColor = System.Drawing.Color.Transparent
		Me.lbl_MPL_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_MPL_Ammo.Location = New System.Drawing.Point(118, 61)
		Me.lbl_MPL_Ammo.Name = "lbl_MPL_Ammo"
		Me.lbl_MPL_Ammo.Size = New System.Drawing.Size(75, 20)
		Me.lbl_MPL_Ammo.TabIndex = 3
		Me.lbl_MPL_Ammo.Tag = "Summarizable"
		Me.lbl_MPL_Ammo.Text = "999,999"
		Me.lbl_MPL_Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_M16_Ammo
		'
		Me.lbl_M16_Ammo.BackColor = System.Drawing.Color.Transparent
		Me.lbl_M16_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_M16_Ammo.Location = New System.Drawing.Point(118, 61)
		Me.lbl_M16_Ammo.Name = "lbl_M16_Ammo"
		Me.lbl_M16_Ammo.Size = New System.Drawing.Size(75, 20)
		Me.lbl_M16_Ammo.TabIndex = 25
		Me.lbl_M16_Ammo.Tag = "Summarizable"
		Me.lbl_M16_Ammo.Text = "999,999"
		Me.lbl_M16_Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_M16_Ammo.Visible = False
		'
		'lbl_M16
		'
		Me.lbl_M16.BackColor = System.Drawing.Color.Transparent
		Me.lbl_M16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_M16.Location = New System.Drawing.Point(10, 61)
		Me.lbl_M16.Name = "lbl_M16"
		Me.lbl_M16.Size = New System.Drawing.Size(102, 20)
		Me.lbl_M16.TabIndex = 24
		Me.lbl_M16.Tag = "Summarizable"
		Me.lbl_M16.Text = "999,999"
		Me.lbl_M16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_M16.Visible = False
		'
		'lbl_M14_Ammo
		'
		Me.lbl_M14_Ammo.BackColor = System.Drawing.Color.Transparent
		Me.lbl_M14_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_M14_Ammo.Location = New System.Drawing.Point(118, 181)
		Me.lbl_M14_Ammo.Name = "lbl_M14_Ammo"
		Me.lbl_M14_Ammo.Size = New System.Drawing.Size(75, 20)
		Me.lbl_M14_Ammo.TabIndex = 11
		Me.lbl_M14_Ammo.Tag = "Summarizable"
		Me.lbl_M14_Ammo.Text = "999,999"
		Me.lbl_M14_Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_M14
		'
		Me.lbl_M14.BackColor = System.Drawing.Color.Transparent
		Me.lbl_M14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_M14.Location = New System.Drawing.Point(10, 181)
		Me.lbl_M14.Name = "lbl_M14"
		Me.lbl_M14.Size = New System.Drawing.Size(102, 20)
		Me.lbl_M14.TabIndex = 10
		Me.lbl_M14.Tag = "Summarizable"
		Me.lbl_M14.Text = "999,999"
		Me.lbl_M14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_PM63_Ammo
		'
		Me.lbl_PM63_Ammo.BackColor = System.Drawing.Color.Transparent
		Me.lbl_PM63_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_PM63_Ammo.Location = New System.Drawing.Point(118, 181)
		Me.lbl_PM63_Ammo.Name = "lbl_PM63_Ammo"
		Me.lbl_PM63_Ammo.Size = New System.Drawing.Size(75, 20)
		Me.lbl_PM63_Ammo.TabIndex = 29
		Me.lbl_PM63_Ammo.Tag = "Summarizable"
		Me.lbl_PM63_Ammo.Text = "999,999"
		Me.lbl_PM63_Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_PM63_Ammo.Visible = False
		'
		'lbl_PM63
		'
		Me.lbl_PM63.BackColor = System.Drawing.Color.Transparent
		Me.lbl_PM63.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_PM63.Location = New System.Drawing.Point(10, 181)
		Me.lbl_PM63.Name = "lbl_PM63"
		Me.lbl_PM63.Size = New System.Drawing.Size(102, 20)
		Me.lbl_PM63.TabIndex = 28
		Me.lbl_PM63.Tag = "Summarizable"
		Me.lbl_PM63.Text = "999,999"
		Me.lbl_PM63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_PM63.Visible = False
		'
		'lbl_MP5K_Ammo
		'
		Me.lbl_MP5K_Ammo.BackColor = System.Drawing.Color.Transparent
		Me.lbl_MP5K_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_MP5K_Ammo.Location = New System.Drawing.Point(118, 241)
		Me.lbl_MP5K_Ammo.Name = "lbl_MP5K_Ammo"
		Me.lbl_MP5K_Ammo.Size = New System.Drawing.Size(75, 20)
		Me.lbl_MP5K_Ammo.TabIndex = 15
		Me.lbl_MP5K_Ammo.Tag = "Summarizable"
		Me.lbl_MP5K_Ammo.Text = "999,999"
		Me.lbl_MP5K_Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_MP5K
		'
		Me.lbl_MP5K.BackColor = System.Drawing.Color.Transparent
		Me.lbl_MP5K.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_MP5K.Location = New System.Drawing.Point(10, 241)
		Me.lbl_MP5K.Name = "lbl_MP5K"
		Me.lbl_MP5K.Size = New System.Drawing.Size(102, 20)
		Me.lbl_MP5K.TabIndex = 14
		Me.lbl_MP5K.Tag = "Summarizable"
		Me.lbl_MP5K.Text = "999,999"
		Me.lbl_MP5K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Stakeout_Ammo
		'
		Me.lbl_Stakeout_Ammo.BackColor = System.Drawing.Color.Transparent
		Me.lbl_Stakeout_Ammo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_Stakeout_Ammo.Location = New System.Drawing.Point(118, 241)
		Me.lbl_Stakeout_Ammo.Name = "lbl_Stakeout_Ammo"
		Me.lbl_Stakeout_Ammo.Size = New System.Drawing.Size(75, 20)
		Me.lbl_Stakeout_Ammo.TabIndex = 31
		Me.lbl_Stakeout_Ammo.Tag = "Summarizable"
		Me.lbl_Stakeout_Ammo.Text = "999,999"
		Me.lbl_Stakeout_Ammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Stakeout_Ammo.Visible = False
		'
		'lbl_Stakeout
		'
		Me.lbl_Stakeout.BackColor = System.Drawing.Color.Transparent
		Me.lbl_Stakeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lbl_Stakeout.Location = New System.Drawing.Point(10, 241)
		Me.lbl_Stakeout.Name = "lbl_Stakeout"
		Me.lbl_Stakeout.Size = New System.Drawing.Size(102, 20)
		Me.lbl_Stakeout.TabIndex = 30
		Me.lbl_Stakeout.Tag = "Summarizable"
		Me.lbl_Stakeout.Text = "999,999"
		Me.lbl_Stakeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl_Stakeout.Visible = False
		'
		'lbl_CurrentScoreInfo
		'
		Me.lbl_CurrentScoreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_CurrentScoreInfo.Location = New System.Drawing.Point(6, 91)
		Me.lbl_CurrentScoreInfo.Name = "lbl_CurrentScoreInfo"
		Me.lbl_CurrentScoreInfo.Size = New System.Drawing.Size(189, 51)
		Me.lbl_CurrentScoreInfo.TabIndex = 230
		Me.lbl_CurrentScoreInfo.Text = "lbl_CurrentScoreInfo"
		'
		'lbl_Manual_Entry_Info
		'
		Me.lbl_Manual_Entry_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Manual_Entry_Info.Location = New System.Drawing.Point(7, 22)
		Me.lbl_Manual_Entry_Info.Name = "lbl_Manual_Entry_Info"
		Me.lbl_Manual_Entry_Info.Size = New System.Drawing.Size(188, 69)
		Me.lbl_Manual_Entry_Info.TabIndex = 229
		Me.lbl_Manual_Entry_Info.Text = "lbl_Manual_Entry_Info"
		'
		'lbl_Score_Current
		'
		Me.lbl_Score_Current.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_Score_Current.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Current.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Current.Location = New System.Drawing.Point(365, 107)
		Me.lbl_Score_Current.Name = "lbl_Score_Current"
		Me.lbl_Score_Current.Size = New System.Drawing.Size(174, 27)
		Me.lbl_Score_Current.TabIndex = 228
		Me.lbl_Score_Current.Text = "9,999,999"
		Me.lbl_Score_Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Score_Current_Name
		'
		Me.lbl_Score_Current_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_Score_Current_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Current_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Current_Name.Location = New System.Drawing.Point(365, 83)
		Me.lbl_Score_Current_Name.Name = "lbl_Score_Current_Name"
		Me.lbl_Score_Current_Name.Size = New System.Drawing.Size(174, 25)
		Me.lbl_Score_Current_Name.TabIndex = 227
		Me.lbl_Score_Current_Name.Text = "Current Score"
		Me.lbl_Score_Current_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Manual_Entry
		'
		Me.lbl_Manual_Entry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_Manual_Entry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Manual_Entry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Manual_Entry.Location = New System.Drawing.Point(365, 43)
		Me.lbl_Manual_Entry.Name = "lbl_Manual_Entry"
		Me.lbl_Manual_Entry.Size = New System.Drawing.Size(174, 27)
		Me.lbl_Manual_Entry.TabIndex = 226
		Me.lbl_Manual_Entry.Tag = Global.BO_Zombies.My.Resources.Blanks.IF_49464D_
		Me.lbl_Manual_Entry.Text = "9,999,999"
		Me.lbl_Manual_Entry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Manual_Entry_Name
		'
		Me.lbl_Manual_Entry_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_Manual_Entry_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Manual_Entry_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Manual_Entry_Name.Location = New System.Drawing.Point(365, 19)
		Me.lbl_Manual_Entry_Name.Name = "lbl_Manual_Entry_Name"
		Me.lbl_Manual_Entry_Name.Size = New System.Drawing.Size(174, 25)
		Me.lbl_Manual_Entry_Name.TabIndex = 225
		Me.lbl_Manual_Entry_Name.Text = "Manual Value Entry"
		Me.lbl_Manual_Entry_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ptb_Score_Calculated_Result
		'
		Me.ptb_Score_Calculated_Result.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_light
		Me.ptb_Score_Calculated_Result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ptb_Score_Calculated_Result.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ptb_Score_Calculated_Result.Location = New System.Drawing.Point(256, 144)
		Me.ptb_Score_Calculated_Result.Name = "ptb_Score_Calculated_Result"
		Me.ptb_Score_Calculated_Result.Size = New System.Drawing.Size(25, 25)
		Me.ptb_Score_Calculated_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.ptb_Score_Calculated_Result.TabIndex = 236
		Me.ptb_Score_Calculated_Result.TabStop = False
		'
		'lbl_Calculator_Type
		'
		Me.lbl_Calculator_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Calculator_Type.Location = New System.Drawing.Point(232, 26)
		Me.lbl_Calculator_Type.Name = "lbl_Calculator_Type"
		Me.lbl_Calculator_Type.Size = New System.Drawing.Size(77, 24)
		Me.lbl_Calculator_Type.TabIndex = 233
		Me.lbl_Calculator_Type.Text = "{Subtract}"
		Me.lbl_Calculator_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbl_Score_Calculator_Result_Name
		'
		Me.lbl_Score_Calculator_Result_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_Score_Calculator_Result_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Score_Calculator_Result_Name.Location = New System.Drawing.Point(36, 143)
		Me.lbl_Score_Calculator_Result_Name.Name = "lbl_Score_Calculator_Result_Name"
		Me.lbl_Score_Calculator_Result_Name.Size = New System.Drawing.Size(246, 27)
		Me.lbl_Score_Calculator_Result_Name.TabIndex = 227
		Me.lbl_Score_Calculator_Result_Name.Text = "Calculated Result"
		Me.lbl_Score_Calculator_Result_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btn_Calculator_Submit
		'
		Me.btn_Calculator_Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_Calculator_Submit.Location = New System.Drawing.Point(232, 56)
		Me.btn_Calculator_Submit.Name = "btn_Calculator_Submit"
		Me.btn_Calculator_Submit.Size = New System.Drawing.Size(77, 24)
		Me.btn_Calculator_Submit.TabIndex = 39
		Me.btn_Calculator_Submit.Text = "Compute"
		Me.btn_Calculator_Submit.UseVisualStyleBackColor = True
		'
		'lbl_Calculator_End
		'
		Me.lbl_Calculator_End.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Calculator_End.Location = New System.Drawing.Point(6, 56)
		Me.lbl_Calculator_End.Name = "lbl_Calculator_End"
		Me.lbl_Calculator_End.Size = New System.Drawing.Size(101, 24)
		Me.lbl_Calculator_End.TabIndex = 37
		Me.lbl_Calculator_End.Tag = "NonDynamic"
		Me.lbl_Calculator_End.Text = "Value End"
		Me.lbl_Calculator_End.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lbl_Calculator_Start
		'
		Me.lbl_Calculator_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_Calculator_Start.Location = New System.Drawing.Point(6, 26)
		Me.lbl_Calculator_Start.Name = "lbl_Calculator_Start"
		Me.lbl_Calculator_Start.Size = New System.Drawing.Size(101, 24)
		Me.lbl_Calculator_Start.TabIndex = 36
		Me.lbl_Calculator_Start.Tag = "NonDynamic"
		Me.lbl_Calculator_Start.Text = "Value Start"
		Me.lbl_Calculator_Start.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'gbx_ManualEntry
		'
		Me.gbx_ManualEntry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbx_ManualEntry.BackColor = System.Drawing.Color.Transparent
		Me.gbx_ManualEntry.Controls.Add(Me.ntb_Score_Current)
		Me.gbx_ManualEntry.Controls.Add(Me.ntb_Manual_Entry)
		Me.gbx_ManualEntry.Controls.Add(Me.lbl_CurrentScoreInfo)
		Me.gbx_ManualEntry.Controls.Add(Me.lbl_Manual_Entry_Info)
		Me.gbx_ManualEntry.Controls.Add(Me.lbl_Score_Current)
		Me.gbx_ManualEntry.Controls.Add(Me.lbl_Score_Current_Name)
		Me.gbx_ManualEntry.Controls.Add(Me.lbl_Manual_Entry)
		Me.gbx_ManualEntry.Controls.Add(Me.lbl_Manual_Entry_Name)
		Me.gbx_ManualEntry.Controls.Add(Me.btn_Manual_Entry)
		Me.gbx_ManualEntry.Controls.Add(Me.btn_Score_Current)
		Me.gbx_ManualEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_ManualEntry.Location = New System.Drawing.Point(593, 239)
		Me.gbx_ManualEntry.Name = "gbx_ManualEntry"
		Me.gbx_ManualEntry.Size = New System.Drawing.Size(545, 146)
		Me.gbx_ManualEntry.TabIndex = 44
		Me.gbx_ManualEntry.TabStop = False
		Me.gbx_ManualEntry.Text = "Entry Values"
		'
		'ntb_Score_Current
		'
		Me.ntb_Score_Current.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.ntb_Score_Current.Location = New System.Drawing.Point(201, 80)
		Me.ntb_Score_Current.Name = "ntb_Score_Current"
		Me.ntb_Score_Current.Size = New System.Drawing.Size(151, 24)
		Me.ntb_Score_Current.TabIndex = 232
		Me.ntb_Score_Current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ntb_Manual_Entry
		'
		Me.ntb_Manual_Entry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.ntb_Manual_Entry.Location = New System.Drawing.Point(201, 17)
		Me.ntb_Manual_Entry.Name = "ntb_Manual_Entry"
		Me.ntb_Manual_Entry.Size = New System.Drawing.Size(151, 24)
		Me.ntb_Manual_Entry.TabIndex = 231
		Me.ntb_Manual_Entry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'gbx_Calculator
		'
		Me.gbx_Calculator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbx_Calculator.BackColor = System.Drawing.Color.Transparent
		Me.gbx_Calculator.Controls.Add(Me.ntb_Calculator_End)
		Me.gbx_Calculator.Controls.Add(Me.ntb_Calculator_Start)
		Me.gbx_Calculator.Controls.Add(Me.ptb_Score_Calculated_Result)
		Me.gbx_Calculator.Controls.Add(Me.lbl_Calculator_Type)
		Me.gbx_Calculator.Controls.Add(Me.lbl_Score_Calculator_Result)
		Me.gbx_Calculator.Controls.Add(Me.lbl_Score_Calculator_Result_Name)
		Me.gbx_Calculator.Controls.Add(Me.btn_Calculator_Submit)
		Me.gbx_Calculator.Controls.Add(Me.lbl_Calculator_End)
		Me.gbx_Calculator.Controls.Add(Me.lbl_Calculator_Start)
		Me.gbx_Calculator.Controls.Add(Me.cbx_Calculator_Auto_Manual)
		Me.gbx_Calculator.Controls.Add(Me.cbx_Calculator_To_Manual)
		Me.gbx_Calculator.Controls.Add(Me.rdb_Calculator_Math_Multiply)
		Me.gbx_Calculator.Controls.Add(Me.rdb_Calculator_Math_Divide)
		Me.gbx_Calculator.Controls.Add(Me.rdb_Calculator_Math_Minus)
		Me.gbx_Calculator.Controls.Add(Me.rdb_Calculator_Math_Add)
		Me.gbx_Calculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_Calculator.Location = New System.Drawing.Point(803, 28)
		Me.gbx_Calculator.Name = "gbx_Calculator"
		Me.gbx_Calculator.Size = New System.Drawing.Size(335, 205)
		Me.gbx_Calculator.TabIndex = 45
		Me.gbx_Calculator.TabStop = False
		Me.gbx_Calculator.Text = "Quick Calculator"
		'
		'ntb_Calculator_End
		'
		Me.ntb_Calculator_End.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.ntb_Calculator_End.Location = New System.Drawing.Point(113, 56)
		Me.ntb_Calculator_End.Name = "ntb_Calculator_End"
		Me.ntb_Calculator_End.Size = New System.Drawing.Size(113, 24)
		Me.ntb_Calculator_End.TabIndex = 238
		Me.ntb_Calculator_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ntb_Calculator_Start
		'
		Me.ntb_Calculator_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.ntb_Calculator_Start.Location = New System.Drawing.Point(113, 26)
		Me.ntb_Calculator_Start.Name = "ntb_Calculator_Start"
		Me.ntb_Calculator_Start.Size = New System.Drawing.Size(113, 24)
		Me.ntb_Calculator_Start.TabIndex = 237
		Me.ntb_Calculator_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'gbx_Grand_Totals
		'
		Me.gbx_Grand_Totals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbx_Grand_Totals.BackColor = System.Drawing.Color.Transparent
		Me.gbx_Grand_Totals.Controls.Add(Me.ptb_Score_Should)
		Me.gbx_Grand_Totals.Controls.Add(Me.ptb_Score_Maximum)
		Me.gbx_Grand_Totals.Controls.Add(Me.ptb_Score_Grand)
		Me.gbx_Grand_Totals.Controls.Add(Me.lbl_Score_Grand_Lable)
		Me.gbx_Grand_Totals.Controls.Add(Me.lbl_Score_Should_Lable)
		Me.gbx_Grand_Totals.Controls.Add(Me.lbl_Score_Should)
		Me.gbx_Grand_Totals.Controls.Add(Me.lbl_Score_Maximum)
		Me.gbx_Grand_Totals.Controls.Add(Me.lbl_Score_Grand)
		Me.gbx_Grand_Totals.Controls.Add(Me.lbl_Score_Maximum_Lable)
		Me.gbx_Grand_Totals.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.gbx_Grand_Totals.Location = New System.Drawing.Point(593, 491)
		Me.gbx_Grand_Totals.Name = "gbx_Grand_Totals"
		Me.gbx_Grand_Totals.Size = New System.Drawing.Size(545, 229)
		Me.gbx_Grand_Totals.TabIndex = 219
		Me.gbx_Grand_Totals.TabStop = False
		Me.gbx_Grand_Totals.Text = "Grand Totals"
		'
		'mus_MainMenuStrip
		'
		Me.mus_MainMenuStrip.BackColor = System.Drawing.Color.LightGray
		Me.mus_MainMenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.mus_MainMenuStrip.Name = "mus_MainMenuStrip"
		Me.mus_MainMenuStrip.Size = New System.Drawing.Size(1150, 24)
		Me.mus_MainMenuStrip.TabIndex = 0
		Me.mus_MainMenuStrip.Text = "Home_MenuStrip"
		'
		'AdsdToolStripMenuItem
		'
		Me.AdsdToolStripMenuItem.Name = "AdsdToolStripMenuItem"
		Me.AdsdToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.AdsdToolStripMenuItem.Text = "adsd"
		'
		'Home
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(1150, 732)
		Me.Controls.Add(Me.gbx_Grand_Totals)
		Me.Controls.Add(Me.gbx_MajorHacks)
		Me.Controls.Add(Me.gbx_TotalLables)
		Me.Controls.Add(Me.gbx_Calculator)
		Me.Controls.Add(Me.gbx_ManualEntry)
		Me.Controls.Add(Me.gbx_OtherForms)
		Me.Controls.Add(Me.gbx_Other_Items)
		Me.Controls.Add(Me.gbx_Activity_Log)
		Me.Controls.Add(Me.gbx_Upgrades)
		Me.Controls.Add(Me.gbx_Doors)
		Me.Controls.Add(Me.gbx_The_Mystery_box)
		Me.Controls.Add(Me.gbx_Perks)
		Me.Controls.Add(Me.gbx_WallWeapons)
		Me.Controls.Add(Me.tsm_MainMenuStrip)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.KeyPreview = True
		Me.MainMenuStrip = Me.tsm_MainMenuStrip
		Me.MaximizeBox = False
		Me.MinimumSize = New System.Drawing.Size(1150, 758)
		Me.Name = "Home"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Zombies Moon Score Tracker 2012  |  App Version 1.0.0.1 R  | Game Patch 64.6.3 | " & _
		  "Developers, INSURRECTION1ST & Cremoney @ PlayStation® Network | " + My.Settings.MacAddress
		Me.TransparencyKey = System.Drawing.Color.Crimson
		Me.tsm_MainMenuStrip.ResumeLayout(False)
		Me.tsm_MainMenuStrip.PerformLayout()
		Me.gbx_TotalLables.ResumeLayout(False)
		CType(Me.ptb_Score_Grand, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ptb_Score_Maximum, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ptb_Score_Should, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbx_OtherForms.ResumeLayout(False)
		Me.gbx_Other_Items.ResumeLayout(False)
		Me.gbx_Activity_Log.ResumeLayout(False)
		CType(Me.dgd_Activity_Log, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbx_Upgrades.ResumeLayout(False)
		Me.gbx_Doors.ResumeLayout(False)
		Me.gbx_The_Mystery_box.ResumeLayout(False)
		Me.gbx_MajorHacks.ResumeLayout(False)
		Me.gbx_Perks.ResumeLayout(False)
		Me.gbx_WallWeapons.ResumeLayout(False)
		CType(Me.ptb_Score_Calculated_Result, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbx_ManualEntry.ResumeLayout(False)
		Me.gbx_ManualEntry.PerformLayout()
		Me.gbx_Calculator.ResumeLayout(False)
		Me.gbx_Calculator.PerformLayout()
		Me.gbx_Grand_Totals.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents ttp_MainForm As System.Windows.Forms.ToolTip
    Friend WithEvents tsm_MainMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents btn_Manual_Entry As System.Windows.Forms.Button
    Friend WithEvents gbx_TotalLables As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Score_Revive As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Revive_Lable As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Down As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Down_Lable As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Spent As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Spent_Lable As System.Windows.Forms.Label
    Friend WithEvents ptb_Score_Grand As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Score_Grand_Lable As System.Windows.Forms.Label
    Friend WithEvents ptb_Score_Maximum As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Score_Maximum_Lable As System.Windows.Forms.Label
    Friend WithEvents ptb_Score_Should As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Score_Grand As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Maximum As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Should As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Should_Lable As System.Windows.Forms.Label
    Friend WithEvents gbx_OtherForms As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Weapons As System.Windows.Forms.Button
    Friend WithEvents btn_SamsGame As System.Windows.Forms.Button
    Friend WithEvents btn_Downs As System.Windows.Forms.Button
    Friend WithEvents btn_Revive As System.Windows.Forms.Button
    Friend WithEvents gbx_Other_Items As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Bowie_Knife As System.Windows.Forms.Button
    Friend WithEvents lbl_Bowie_Knife As System.Windows.Forms.Label
    Friend WithEvents lbl_Easter_Egg_Button As System.Windows.Forms.Label
    Friend WithEvents btn_Semtex As System.Windows.Forms.Button
    Friend WithEvents lbl_Semtex As System.Windows.Forms.Label
    Friend WithEvents btn_Claymores As System.Windows.Forms.Button
    Friend WithEvents btn_Easter_Egg_Button As System.Windows.Forms.Button
    Friend WithEvents lbl_Claymores As System.Windows.Forms.Label
    Friend WithEvents btn_Score_Current As System.Windows.Forms.Button
    Friend WithEvents gbx_Activity_Log As System.Windows.Forms.GroupBox
    Friend WithEvents dgd_Activity_Log As System.Windows.Forms.DataGridView
    Friend WithEvents gbx_Upgrades As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Pack_A_Punch As System.Windows.Forms.Button
    Friend WithEvents btn_Upgraded_Ammo As System.Windows.Forms.Button
    Friend WithEvents lbl_Pack_A_Punch As System.Windows.Forms.Label
    Friend WithEvents lbl_Upgraded_Ammo As System.Windows.Forms.Label
    Friend WithEvents gbx_Doors As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Hack_Door As System.Windows.Forms.Button
    Friend WithEvents lbl_Door_1000 As System.Windows.Forms.Label
    Friend WithEvents lbl_Door_1250 As System.Windows.Forms.Label
    Friend WithEvents btn_Door_750 As System.Windows.Forms.Button
    Friend WithEvents lbl_Door_750 As System.Windows.Forms.Label
    Friend WithEvents lbl_Hack_Door As System.Windows.Forms.Label
    Friend WithEvents btn_Door_1250 As System.Windows.Forms.Button
    Friend WithEvents btn_Door_1000 As System.Windows.Forms.Button
    Friend WithEvents gbx_The_Mystery_box As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Teddy_Hack As System.Windows.Forms.Button
    Friend WithEvents lbl_Teddy_Hack As System.Windows.Forms.Label
    Friend WithEvents btn_Firesale_Box As System.Windows.Forms.Button
    Friend WithEvents lbl_Firesale_Box As System.Windows.Forms.Label
    Friend WithEvents btn_Hack_The_Box As System.Windows.Forms.Button
    Friend WithEvents lbl_Hack_The_Box As System.Windows.Forms.Label
    Friend WithEvents btn_Buy_The_Box As System.Windows.Forms.Button
    Friend WithEvents lbl_Buy_The_Box As System.Windows.Forms.Label
    Friend WithEvents btn_Buy_And_Hack_Box As System.Windows.Forms.Button
    Friend WithEvents gbx_MajorHacks As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Max_Ammo_Hack As System.Windows.Forms.Button
    Friend WithEvents lbl_Max_Ammo_Hack As System.Windows.Forms.Label
    Friend WithEvents btn_Hack_Player As System.Windows.Forms.Button
    Friend WithEvents lbl_Hack_Player As System.Windows.Forms.Label
    Friend WithEvents gbx_Perks As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Stammin_Up As System.Windows.Forms.Label
    Friend WithEvents btn_Juggernog As System.Windows.Forms.Button
    Friend WithEvents lbl_Juggernog As System.Windows.Forms.Label
    Friend WithEvents btn_Stammin_Up As System.Windows.Forms.Button
    Friend WithEvents btn_Mule_Kick As System.Windows.Forms.Button
    Friend WithEvents lbl_Mule_Kick As System.Windows.Forms.Label
    Friend WithEvents btn_PHD_Flopper As System.Windows.Forms.Button
    Friend WithEvents lbl_PHD_Flopper As System.Windows.Forms.Label
    Friend WithEvents btn_Perks_More As System.Windows.Forms.Button
    Friend WithEvents lbl_Double_Tap As System.Windows.Forms.Label
    Friend WithEvents lbl_Quick_Revive As System.Windows.Forms.Label
    Friend WithEvents lbl_Dead_Shot As System.Windows.Forms.Label
    Friend WithEvents btn_Speed_Cola As System.Windows.Forms.Button
    Friend WithEvents btn_Double_Tap As System.Windows.Forms.Button
    Friend WithEvents btn_Quick_Revive As System.Windows.Forms.Button
    Friend WithEvents btn_Dead_Shot As System.Windows.Forms.Button
    Friend WithEvents lbl_Speed_Cola As System.Windows.Forms.Label
    Friend WithEvents gbx_WallWeapons As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_MPL As System.Windows.Forms.Label
    Friend WithEvents lbl_MP5K_Ammo As System.Windows.Forms.Label
    Friend WithEvents lbl_MPL_Ammo As System.Windows.Forms.Label
    Friend WithEvents btn_MPL As System.Windows.Forms.Button
    Friend WithEvents lbl_MP5K As System.Windows.Forms.Label
    Friend WithEvents lbl_M14_Ammo As System.Windows.Forms.Label
    Friend WithEvents btn_MPL_Ammo As System.Windows.Forms.Button
    Friend WithEvents btn_AK74U As System.Windows.Forms.Button
    Friend WithEvents btn_MP5K As System.Windows.Forms.Button
    Friend WithEvents btn_M14 As System.Windows.Forms.Button
    Friend WithEvents lbl_M14 As System.Windows.Forms.Label
    Friend WithEvents lbl_AK74U As System.Windows.Forms.Label
    Friend WithEvents btn_AK74U_Ammo As System.Windows.Forms.Button
    Friend WithEvents lbl_AK74U_Ammo As System.Windows.Forms.Label
    Friend WithEvents btn_M14_Ammo As System.Windows.Forms.Button
    Friend WithEvents btn_MP5K_Ammo As System.Windows.Forms.Button
    Friend WithEvents btn_Wall_Weapons_More As System.Windows.Forms.Button
    Friend WithEvents lbl_Stakeout_Ammo As System.Windows.Forms.Label
    Friend WithEvents lbl_Stakeout As System.Windows.Forms.Label
    Friend WithEvents btn_Stakeout_Ammo As System.Windows.Forms.Button
    Friend WithEvents btn_Stakeout As System.Windows.Forms.Button
    Friend WithEvents lbl_PM63_Ammo As System.Windows.Forms.Label
    Friend WithEvents lbl_PM63 As System.Windows.Forms.Label
    Friend WithEvents btn_PM63_Ammo As System.Windows.Forms.Button
    Friend WithEvents btn_PM63 As System.Windows.Forms.Button
    Friend WithEvents lbl_Olympia_Ammo As System.Windows.Forms.Label
    Friend WithEvents btn_Olympia_Ammo As System.Windows.Forms.Button
    Friend WithEvents lbl_Olympia As System.Windows.Forms.Label
    Friend WithEvents btn_Olympia As System.Windows.Forms.Button
    Friend WithEvents lbl_M16_Ammo As System.Windows.Forms.Label
    Friend WithEvents lbl_M16 As System.Windows.Forms.Label
    Friend WithEvents btn_M16_Ammo As System.Windows.Forms.Button
    Friend WithEvents btn_M16 As System.Windows.Forms.Button
    Friend WithEvents gbx_ManualEntry As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Score_Current As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Current_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Manual_Entry As System.Windows.Forms.Label
    Friend WithEvents lbl_Manual_Entry_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_CurrentScoreInfo As System.Windows.Forms.Label
    Friend WithEvents lbl_Manual_Entry_Info As System.Windows.Forms.Label
    Friend WithEvents gbx_Calculator As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Calculator_Submit As System.Windows.Forms.Button
    Friend WithEvents lbl_Calculator_End As System.Windows.Forms.Label
    Friend WithEvents lbl_Calculator_Start As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Calculator_Result As System.Windows.Forms.Label
    Friend WithEvents lbl_Score_Calculator_Result_Name As System.Windows.Forms.Label
    Friend WithEvents rdb_Calculator_Math_Add As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Calculator_Math_Multiply As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Calculator_Math_Divide As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Calculator_Math_Minus As System.Windows.Forms.RadioButton
    Friend WithEvents cbx_Calculator_To_Manual As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Calculator_Type As System.Windows.Forms.Label
    Friend WithEvents cbx_Calculator_Auto_Manual As System.Windows.Forms.CheckBox
    Friend WithEvents ptb_Score_Calculated_Result As System.Windows.Forms.PictureBox
    Friend WithEvents gbx_Grand_Totals As System.Windows.Forms.GroupBox
    Friend WithEvents ntb_Manual_Entry As BO_Zombies.NumTextBox
    Friend WithEvents ntb_Score_Current As BO_Zombies.NumTextBox
    Friend WithEvents ntb_Calculator_End As BO_Zombies.NumTextBox
    Friend WithEvents ntb_Calculator_Start As BO_Zombies.NumTextBox
    Friend WithEvents btn_KillTracker As System.Windows.Forms.Button
    Friend WithEvents tsm_top_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_New As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Open As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_top_Edit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Undo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_ClearEntireForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_top_Tools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Customize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Options As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_top_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Contents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Register As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_ViewQuantity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_ViewAccumulative As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_BugReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Donate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_top_Forms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_top_Chat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_OpenChat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mus_MainMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AdsdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Separator_File As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsm_Separator_Edit As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsm_Separator_Tool As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsm_Separator_Help1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsm_Separator_Help2 As System.Windows.Forms.ToolStripSeparator

End Class
