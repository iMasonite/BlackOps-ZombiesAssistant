#Region "     IMPORTS    "

'======== Using My Classes.
Imports BO_Zombies.Constants
Imports BO_Zombies.Functions
Imports BO_Zombies.Subroutine
Imports BO_Zombies.Globals
Imports BO_Zombies.StaticWork

'======== Using My Resources.
Imports BO_Zombies.My.Resources.Infomation
Imports BO_Zombies.My.Resources.Exception
Imports BO_Zombies.My.Resources.ArtWork

'======== Using System Items.
Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Media.SystemSounds
Imports System.Collections
Imports System.Drawing.Color
Imports System.Diagnostics

#End Region

Public Class Home

#Region "     FORM LOAD     "

	Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Check_DisplayResolution()
		Set_OnLoad_Vars()

		ActivityDataGrid(Me.Name.ToString(), Globals.Activity.Home, Me.dgd_Activity_Log)

		Globals.SC = SumCount()

		'FTPUpload.FileUpload_All("Uploads")


	End Sub

    Private Sub Set_OnLoad_Vars()

        Globals.Score.Grand = 0
        Globals.Score.Maximum = MaximumStarter

        Me.ntb_Manual_Entry.Text = 0
        Me.lbl_Manual_Entry.Text = 0
        Me.lbl_Manual_Entry_Info.Text = IF_49464D_ManualEntry

        Me.ntb_Score_Current.Text = 0
        Me.lbl_Score_Current.Text = 0
        Me.lbl_CurrentScoreInfo.Text = IF_49464D_CurrentScore

        Me.lbl_Score_Calculator_Result.Text = 0
        Me.ntb_Calculator_Start.Text = 0
        Me.ntb_Calculator_End.Text = 0

        Me.lbl_Juggernog.Text = 0
        Me.lbl_Stammin_Up.Text = 0
        Me.lbl_PHD_Flopper.Text = 0
        Me.lbl_Mule_Kick.Text = 0
        Me.lbl_Speed_Cola.Text = 0
        Me.lbl_Quick_Revive.Text = 0
        Me.lbl_Double_Tap.Text = 0
        Me.lbl_Dead_Shot.Text = 0

        Me.lbl_AK74U.Text = 0
        Me.lbl_M14.Text = 0
        Me.lbl_M16.Text = 0
        Me.lbl_MP5K.Text = 0
        Me.lbl_MPL.Text = 0
        Me.lbl_Olympia.Text = 0
        Me.lbl_PM63.Text = 0
        Me.lbl_Stakeout.Text = 0

        Me.lbl_AK74U_Ammo.Text = 0
        Me.lbl_M14_Ammo.Text = 0
        Me.lbl_M16_Ammo.Text = 0
        Me.lbl_MP5K_Ammo.Text = 0
        Me.lbl_MPL_Ammo.Text = 0
        Me.lbl_Olympia_Ammo.Text = 0
        Me.lbl_PM63_Ammo.Text = 0
        Me.lbl_Stakeout_Ammo.Text = 0

        Me.lbl_Max_Ammo_Hack.Text = 0
        Me.lbl_Upgraded_Ammo.Text = 0

        Me.lbl_Bowie_Knife.Text = 0
        Me.lbl_Claymores.Text = 0
        Me.lbl_Pack_A_Punch.Text = 0
        Me.lbl_Semtex.Text = 0

        Me.lbl_Hack_Door.Text = 0
        Me.lbl_Door_750.Text = 0
        Me.lbl_Door_1000.Text = 0
        Me.lbl_Door_1250.Text = 0

        Me.lbl_Easter_Egg_Button.Text = 0
        Me.lbl_Buy_The_Box.Text = 0
        Me.lbl_Hack_Player.Text = 0
        Me.lbl_Firesale_Box.Text = 0
        Me.lbl_Teddy_Hack.Text = 0
        Me.lbl_Hack_The_Box.Text = 0

        Me.lbl_Score_Maximum.Text = Globals.Score.Maximum.ToString("#,#")
        Me.lbl_Score_Spent.Text = ""
        Me.lbl_Score_Grand.Text = ""
        Me.lbl_Score_Down.Text = ""
        Me.lbl_Score_Revive.Text = ""
        Me.lbl_Score_Should.Text = "Update Score"

        'RADIO CHECKBUTTONS
        Me.rdb_Calculator_Math_Minus.Checked = True

    End Sub

#End Region

#Region "     ITEM BUTTONS     "
#Region "      OTHER OTHER      "
    Private Sub btn_Manual_EntryClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Manual_Entry.Click

        If Me.ntb_Manual_Entry.Text = "" Or Me.ntb_Manual_Entry.Text = 0 Then Exit Sub

        SubmitAndUpdateItem(sender)
        Me.ntb_Manual_Entry.Text = 0
    End Sub
    Private Sub btn_Buy_And_Hack_BoxClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buy_And_Hack_Box.Click
        Me.btn_Buy_The_Box.PerformClick()
        Me.btn_Hack_The_Box.PerformClick()
    End Sub
#End Region
#Region "     PERKS      "
    Private Sub btn_JuggernogClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Juggernog.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Stammin_UpClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stammin_Up.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_PHD_FlopperClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PHD_Flopper.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Mule_KickClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mule_Kick.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Speed_ColaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Speed_Cola.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Quick_ReviveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Quick_Revive.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Double_TapClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Double_Tap.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Dead_ShotClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dead_Shot.Click
        SubmitAndUpdateItem(sender)
    End Sub
#End Region
#Region "     WALL GUNS     "
#Region "      WALL GUNS / GUNS      "
    Private Sub btn_AK74UClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AK74U.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_M14Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_M14.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_M16Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_M16.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_MP5KClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MP5K.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_MPLClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MPL.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_OlympiaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Olympia.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_PM63Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PM63.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_StakeoutClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stakeout.Click
        SubmitAndUpdateItem(sender)
    End Sub
#End Region
#Region "      WALL GUNS / AMMO      "
    Private Sub btn_AK74U_AmmoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AK74U_Ammo.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_M14_AmmoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_M14_Ammo.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_M16_AmmoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_M16_Ammo.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_MP5K_AmmoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MP5K_Ammo.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_MPL_AmmoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MPL_Ammo.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Olympia_AmmoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Olympia_Ammo.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_PM63_AmmoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PM63_Ammo.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Stakeout_AmmoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stakeout_Ammo.Click
        SubmitAndUpdateItem(sender)
    End Sub
#End Region

#End Region
#Region "      NORMAL/OTHER      "
    Private Sub btn_Upgraded_AmmoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Upgraded_Ammo.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Bowie_KnifeClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bowie_Knife.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_ClaymoresClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Claymores.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Pack_A_PunchClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pack_A_Punch.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_SemtexClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Semtex.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Buy_The_BoxClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buy_The_Box.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Firesale_BoxClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Firesale_Box.Click
        SubmitAndUpdateItem(sender)
    End Sub
#End Region
#Region "      HACKS      "
    Private Sub btn_Easter_Egg_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Easter_Egg_Button.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Hack_PlayerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hack_Player.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Teddy_HackClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Teddy_Hack.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Hack_The_BoxClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hack_The_Box.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Max_Ammo_HackClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Max_Ammo_Hack.Click
        SubmitAndUpdateItem(sender)
    End Sub
#End Region
#Region "      DOORS      "
    Private Sub btn_Hack_DoorClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hack_Door.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Door_750Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Door_750.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Door_1000Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Door_1000.Click
        SubmitAndUpdateItem(sender)
    End Sub
    Private Sub btn_Door_1250Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Door_1250.Click
        SubmitAndUpdateItem(sender)
    End Sub
#End Region
#End Region

#Region "     FORM VS TEXTBOX BUTTONS     "

    Private Sub btn_Score_Current_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Score_Current.Click

        If Me.ntb_Score_Current.Text = "" Then
            ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                        IF_49464D_ntb_CurrentScoreValue, Nothing, ("IF_49464D_ntb_CurrentScoreValue").Replace("_", " "))
            Exit Sub
        End If
        If Not Me.ntb_Score_Current.Text.ToString() = "0" Then
            Globals.Score.Current = TestForInvalid(Me.ntb_Score_Current)
            Me.lbl_Score_Current.Text = Globals.Score.Current.ToString("#,#")
            Me.ntb_Score_Current.Text = 0
        Else
            Score.Current = 0
            Me.lbl_Score_Current.Text = 0
            Me.ntb_Score_Current.Text = 0
        End If
        DoGlobalTotals()
        'Play a system sound to ensure the user knows the input was successful
        Asterisk.Play()
    End Sub

    Private Sub btn_Calculator_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Calculator_Submit.Click

        Try
            If Me.ntb_Calculator_Start.Text = "" Or Me.ntb_Calculator_Start.Text = Nothing Then
                ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                            IF_49464D_ntb_CalculatorStartValue, Nothing, ("IF_49464D_ntb_CalculatorStartValue").Replace("_", " "))
                Exit Sub
            End If
            If Me.ntb_Calculator_End.Text = "" Or Me.ntb_Calculator_End.Text = Nothing Then
                ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                            IF_49464D_ntb_CalculatorEndValue, Nothing, ("IF_49464D_ntb_CalculatorEndValue").Replace("_", " "))
                Exit Sub
            End If

            Dim NumberRequest As Integer = Collect_And_Compute_Numbers(Me.ntb_Calculator_Start, _
                                                                       Me.ntb_Calculator_End, _
                                                                       Me.gbx_Calculator)

            If NumberRequest < 10 Then
                ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                            IF_49464D_IfMathTheRequest10Then, Nothing, ("IF_49464D_IfMathTheRequest10Then").Replace("_", " "))
                Exit Sub
            End If


            Dim FinalNumber As Integer
            If Not NumberRequest.ToString.EndsWith("0") Then
                Dim DecimalPoint As Double = NumberRequest / 10
                Dim RoundingMath As Double = Math.Ceiling(DecimalPoint)
                Dim IntegerPoint As Integer = RoundingMath * 10

                FinalNumber = IntegerPoint

                Me.lbl_Score_Calculator_Result.Text = (FinalNumber.ToString("#,#") + " - R").ToString()
            Else
                FinalNumber = NumberRequest

                Me.lbl_Score_Calculator_Result.Text = FinalNumber.ToString("#,#")
            End If


            If Me.cbx_Calculator_To_Manual.Checked Then
                Me.ntb_Manual_Entry.Text = FinalNumber
                Me.ntb_Score_Current.Text = Me.ntb_Calculator_End.Text
            End If

            If Me.cbx_Calculator_Auto_Manual.Checked Then
                Me.ntb_Manual_Entry.Text = FinalNumber
                Me.ntb_Score_Current.Text = Me.ntb_Calculator_End.Text

                btn_Manual_Entry.PerformClick()
                btn_Score_Current.PerformClick()
            End If
            'Play a system sound to ensure the user knows the input was successful
            Asterisk.Play()
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_484D45_545259_btn_Calculator_Submit_Click, ex, ("EX_484D45_545259_btn_Calculator_Submit_Click").Replace("_", " "))
        End Try
    End Sub

#End Region

#Region "     RADIO BUTTON CHANGED     "
    Private Sub rdb_Calculator_Math_Add_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Calculator_Math_Add.CheckedChanged
        Me.lbl_Calculator_Type.Text = "Add"
    End Sub
    Private Sub rdb_Calculator_Math_Minus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Calculator_Math_Minus.CheckedChanged
        Me.lbl_Calculator_Type.Text = "Subtract"
    End Sub
    Private Sub rdb_Calculator_Math_Divide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Calculator_Math_Divide.CheckedChanged
        Me.lbl_Calculator_Type.Text = "Divide"
    End Sub
    Private Sub rdb_Calculator_Math_Multiply_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Calculator_Math_Multiply.CheckedChanged
        Me.lbl_Calculator_Type.Text = "Multiply"
    End Sub
#End Region

#Region "     SHOW AND HIDER CONTROLS    "

    Private Sub btn_Wall_Weapons_More_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Wall_Weapons_More.Click
        ControlViewSwitcher(Me.gbx_WallWeapons)
    End Sub

    Private Sub btn_Perks_More_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Perks_More.Click
        ControlViewSwitcher(Me.gbx_Perks)
    End Sub

#End Region

#Region "     MENU FUNCTIONS     "

    'TODO: Program these menu items // ITEMS REMAIN [9]
    Private Sub tsm_ViewQuantity_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_ViewQuantity.Click
        My.Settings.set_ShowAccumulative = False
        My.Settings.Save()

        Globals.SC = SumCount()

        For Each GroupBox In Me.Controls
            ShowValuesNeeded(GroupBox, "count")
        Next
    End Sub

    Private Sub tsm_ViewAccumulative_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_ViewAccumulative.Click
        My.Settings.set_ShowAccumulative = True
        My.Settings.Save()

        Globals.SC = SumCount()

        For Each GroupBox In Me.Controls
            ShowValuesNeeded(GroupBox, "sum")
        Next
    End Sub

    Private Sub tsm_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_New.Click

    End Sub

    Private Sub tsm_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Open.Click

    End Sub

    Private Sub tsm_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Save.Click

    End Sub

    Private Sub tsm_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Exit.Click

        Dim Message_Result As MsgBoxResult = MessageBox.Show("Are you sure you want to exit the program losing all data?", _
                                                     "Are you sure?...", _
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Message_Result = MsgBoxResult.Yes Then

            Me.Close()

        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsm_Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Undo.Click
        Try
            If Not Globals.Activity.Home.Columns.Count <= 0 Then
                If Not Globals.Activity.Home.Rows.Count <= 0 Then
                    Dim CurrentInt As Integer = Me.dgd_Activity_Log.CurrentRow.Index
                    Dim Removing As String
                    Removing = Me.dgd_Activity_Log.Rows(CurrentInt).Cells(TCols.Home.Item).Value.ToString()

                    Me.dgd_Activity_Log.Rows.Remove(Me.dgd_Activity_Log.CurrentRow)
                    SubmitAndUpdateItem(Nothing, Removing)
                    If Not Globals.Activity.Home.Rows.Count <= 1 Then
                        Me.dgd_Activity_Log.CurrentCell = Me.dgd_Activity_Log.Item(0, Me.dgd_Activity_Log.Rows.Count - 1)
                    End If
                End If
            End If
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_484D45_545259_tsm_UndoLastLogEntry_Click, ex, ("EX_484D45_545259_tsm_UndoLastLogEntry_Click").Replace("_", " "))
        End Try
    End Sub

    Private Sub tsm_ClearEntireForm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_ClearEntireForm.Click
        Dim Message_Result As MsgBoxResult = MessageBox.Show("Are you sure you want to clear ALL data?", _
                                                     "Are you sure?...", _
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Message_Result = MsgBoxResult.Yes Then
            Score.Current = 0
            Score.Downs = 0
            Score.Grand = 0
            Score.Manual = 0
            Score.Maximum = MaximumStarter
            Score.Revive = 0
            Score.Should = 0
            Score.Spent = 0

            Activity.Downs.Clear()
            Activity.Home.Clear()
            Activity.Revive.Clear()
            Activity.SamsGame.Clear()


            Set_OnLoad_Vars()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsm_Customize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Customize.Click
        Customize.Show()
    End Sub

    Private Sub tsm_Options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Options.Click
        'TODO: Create form to request permission to access internet before connection attempt is made with server

        Options.Show()
    End Sub

    Private Sub RegisterProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Register.Click

    End Sub

    Private Sub tsm_Contents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Contents.Click

    End Sub

    Private Sub tsm_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_About.Click

    End Sub

    Private Sub tsm_Donate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Donate.Click
        Donate.Show()
    End Sub

#End Region

#Region "     CLEAR TEXT BOXES ON FOCUS     "
    Private Sub ntb_Current_Score_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Score_Current.Enter
        Me.ntb_Score_Current.Text = Nothing
    End Sub
    Private Sub ntb_Manual_Entry_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Manual_Entry.Enter
        Me.ntb_Manual_Entry.Text = Nothing
    End Sub
    Private Sub ntb_Calculator_Start_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Calculator_Start.Enter
        Me.ntb_Calculator_Start.Text = Nothing
    End Sub
    Private Sub ntb_Calculator_End_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Calculator_End.Enter
        Me.ntb_Calculator_End.Text = Nothing
    End Sub
#End Region

#Region "     INFORMATION PICTURE BOXES     "

    Private Sub ptb_Score_Grand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Grand.Click
        ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, IF_49464D_Score_Grand, Nothing, Nothing)
    End Sub

    Private Sub ptb_Score_Maximum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Maximum.Click
        ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, IF_49464D_Score_Maximum, Nothing, Nothing)
    End Sub

    Private Sub ptb_Score_Should_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Should.Click
        ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, IF_49464D_Score_Should, Nothing, Nothing)
    End Sub

    Private Sub ptb_Score_Calculated_Result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Calculated_Result.Click
        ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, IF_49464D_Score_Calculated_Result, Nothing, Nothing)
    End Sub

#End Region

#Region "     KEYDOWN EVENTS     "

    Private Sub Home_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Is = ShortKeys.Juggernog
                '    btn_Juggernog.PerformClick()
                'Case Is = ShortKeys.Stammin_Up
                '    btn_Stammin_Up.PerformClick()
                'Case Is = ShortKeys.PHD_Flopper
                '    btn_PHD_Flopper.PerformClick()
                'Case Is = ShortKeys.Mule_Kick
                '    btn_Mule_Kick.PerformClick()
                'Case Is = ShortKeys.Speed_Cola
                '    btn_Speed_Cola.PerformClick()
                'Case Is = ShortKeys.Quick_Revive
                '    btn_Quick_Revive.PerformClick()
                'Case Is = ShortKeys.Double_Tap
                '    btn_Double_Tap.PerformClick()
                'Case Is = ShortKeys.Dead_Shot
                '    btn_Dead_Shot.PerformClick()

                'Case Is = ShortKeys.AK74U
                '    btn_AK74U.PerformClick()
                'Case Is = ShortKeys.AK74U_Ammo
                '    btn_AK74U_Ammo.PerformClick()
                'Case Is = ShortKeys.MPL
                '    btn_MPL.PerformClick()
                'Case Is = ShortKeys.MPL_Ammo
                '    btn_MPL_Ammo.PerformClick()

                'Case Is = ShortKeys.Max_Ammo_Hack
                '    btn_Max_Ammo_Hack.PerformClick()
                'Case Is = ShortKeys.Bowie_Knife
                '    btn_Bowie_Knife.PerformClick()
                'Case Is = ShortKeys.Pack_A_Punch
                '    btn_Pack_A_Punch.PerformClick()
                'Case Is = ShortKeys.Hack_Player
                '    btn_Hack_Player.PerformClick()
                'Case Is = ShortKeys.Buy_The_Box_0_Hack_The_Box
                '    btn_Buy_The_Box.PerformClick()
                '    btn_Hack_The_Box.PerformClick()
                'Case Is = ShortKeys.RemoveLogEntry
                'TODO:'tsm_UndoLastLogEntry.PerformClick()
        End Select

    End Sub

#End Region

#Region "     OTHER FORMS     "

    Private Sub btn_Samanthas_Game_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SamsGame.Click
        SamsGame.Show()
    End Sub
    Private Sub btn_Revive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Revive.Click
        Revive.Show()
    End Sub
    Private Sub btn_Downs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Downs.Click
        Downs.Show()
    End Sub
    Private Sub btn_Weapons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Weapons.Click
        'Weapons.Show()
    End Sub
    Private Sub btn_KillTracker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KillTracker.Click
		KillTracker.Show()
    End Sub

#End Region

    Private Sub ptb_Score_Calculated_Result_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Calculated_Result.MouseEnter
        Me.ptb_Score_Calculated_Result.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_dark
    End Sub

    Private Sub ptb_Score_Calculated_Result_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Calculated_Result.MouseLeave
        Me.ptb_Score_Calculated_Result.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_light
    End Sub

    Private Sub ptb_Score_Grand_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Grand.MouseEnter
        Me.ptb_Score_Grand.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_dark
    End Sub

    Private Sub ptb_Score_Grand_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Grand.MouseLeave
        Me.ptb_Score_Grand.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_light
    End Sub
    Private Sub ptb_Score_Maximum_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Maximum.MouseEnter
        Me.ptb_Score_Maximum.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_dark
    End Sub

    Private Sub ptb_Score_Maximum_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Maximum.MouseLeave
        Me.ptb_Score_Maximum.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_light
    End Sub
    Private Sub ptb_Score_Should_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Should.MouseEnter
        Me.ptb_Score_Should.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_dark
    End Sub

    Private Sub ptb_Score_Should_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb_Score_Should.MouseLeave
        Me.ptb_Score_Should.BackgroundImage = Global.BO_Zombies.My.Resources.Resources.icn_info_light
    End Sub
End Class
