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

'======== Using System Items.
Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Media.SystemSounds
Imports System.Collections
Imports System.Drawing.Color

#End Region

#Region "    CODE.BIN     "
'Private Sub ff()
'    'Data Table
'    Dim dt As New DataTable
'    'Data row array
'    Dim rows() As System.Data.DataRow
'    Dim row As DataRow

'    'Build Data Table in Memory
'    dt.Columns.Add("Employee_ID", GetType(System.Int32))
'    dt.Columns.Add("Employee_Name", GetType(System.String))

'    'Add Rows
'    dt.Rows.Add(New Object() {100, "ABCDE"})
'    dt.Rows.Add(New Object() {101, "ABCDF"})
'    dt.Rows.Add(New Object() {102, "ABCDD"})

'    'Filter Expression
'    rows = dt.Select("[Employee_ID] = 100")

'    'Display Filtered Rows
'    For Each row In rows
'        MsgBox(row("Employee_Name"))
'    Next

'    'Filter Expression 2
'    rows = dt.Select("[Employee_ID] >= 100 and [Employee_ID] <=101 ")

'    'Display Filtered Rows
'    For Each row In rows
'        MsgBox(row("Employee_Name"))
'    Next
'End Sub


'Public Shared Sub BoxSelectCase(ByRef Request As String)

'    Select Case Request
'        Case Is = "Phase_1_1"

'        Case Is = ""

'        Case Else

'    End Select

'End Sub

'Public Shared Sub GNumPress(ByRef PressedNumber As Short)

'    NumberMaster(PressedNumber, SamanthasGame.gbx_Phase_1, 1, 1)

'End Sub

'Public Shared Sub NumberMaster(ByRef GNum As Short, _
'                               ByRef PaseGbx As GroupBox, _
'                               ByRef Phase As Short, _
'                               ByRef Line As Short)



'    For Each Ctrl As Control In PaseGbx.Controls
'        If TypeOf Ctrl Is Label Then
'            If Ctrl.Text = Nothing Then
'                With TableLog_SamathGame
'                    .Rows(Line - 1)("Phase " + Phase.ToString()) = GNum
'                End With

'                ColorSelectCase(GNum, Ctrl)
'            End If
'        End If
'    Next






'    Dim GetSplitTag As New ArrayList()
'    'GetSplitTag.AddRange(Ctrl.Tag.ToString.Split("|"))
'    'If Phase = 1 Then

'    'End If
'    'If Phase = 2 Then

'    'End If
'    'If Phase = 3 Then

'    'End If
'    'If Phase = 4 Then

'    'End If

'    'ByRef Phase As Short, ByRef Line As Short, ByRef GNum As Short
'    'With TableLog_SamathGame
'    '    .Rows(Line - 1)("Phase " + Phase.ToString()) = GNum
'    'End With
'    'ColorSelectCase(GNum, SamanthasGame.lbl_Phase_1_1)

'End Sub

#End Region

Public Class SamsGame

#Region "      'LOAD'      "

    Private Sub SamsGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.Enabled = False

        ActivityDataGrid(Me.Name.ToString(), Globals.Activity.SamsGame, Me.dgd_Activity_Log)

        BuildTable()

        Try
            If My.Settings.set_SamsGame_Display = 0 Then
                Me.rdb_ShowBoth.Checked = True
            ElseIf My.Settings.set_SamsGame_Display = 1 Then
                Me.rdb_NumbersOnly.Checked = True
            ElseIf My.Settings.set_SamsGame_Display = 2 Then
                Me.rdb_ColorOnly.Checked = True
            End If
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_534D47_545259_SamsGame_Load, ex, ("EX_534D47_545259_SamsGame_Load").Replace("_", " "))
        End Try

    End Sub

#End Region

#Region "    THE WORKING PARTS     "
    Private Sub BuildTable()
        Try
            Dim Rand As New Random

            If Globals.Activity.SamsGame.Rows.Count = 0 Then
                For i As Integer = 1 To 8
                    Dim AddNewRowOfData(3) As Object
                    If i = 1 Then
                        AddNewRowOfData(0) = 0
                    Else
                        AddNewRowOfData(0) = 6 'Rand.Next(1, 5)
                    End If
                    AddNewRowOfData(1) = 6 'Rand.Next(1, 5)
                    AddNewRowOfData(2) = 6 'Rand.Next(1, 5)
                    AddNewRowOfData(3) = 6 'Rand.Next(1, 5)
                    Globals.Activity.SamsGame.Rows.Add(AddNewRowOfData)
                Next

                With Globals.Activity.SamsGame
                    .Rows(6)(TCols.SamsGame.Phase_1) = 9
                    .Rows(7)(TCols.SamsGame.Phase_1) = 9
                    .Rows(6)(TCols.SamsGame.Phase_2) = 9
                    .Rows(7)(TCols.SamsGame.Phase_2) = 9
                    .Rows(7)(TCols.SamsGame.Phase_3) = 9
                End With
            End If

            DisplayFromTable(Globals.Activity.SamsGame)
            TheBusinessSub(Nothing, True)
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_534D47_545259_BuildTable, ex, ("EX_534D47_545259_BuildTable").Replace("_", " "))
        Finally
        End Try
    End Sub

    Private Sub DisplayFromTable(ByRef TableLog As System.Data.DataTable)

        Try
            For Each GroupBox As Control In Me.Controls
                If TypeOf GroupBox Is GroupBox Then
                    For Each Label As Control In GroupBox.Controls
                        If TypeOf Label Is Label Then
                            If Label.Tag = "PhaseBox" Then

                                Dim LblName As String = Label.Name.ToString()
                                Dim TColumn As String
                                Dim TRowsxx As Short

                                With LblName ' lbl_Phase_1_1
                                    TColumn = .Remove(0, 4).ToString().Remove(7, 2) ' lbl_{Phase_1}_1
                                    TRowsxx = .Remove(0, 12) ' 'lbl_Phase_1_{1}
                                End With

                                Dim NumberFromTable As Short = Globals.Activity.SamsGame.Rows(TRowsxx - 1)(TColumn)
                                If NumberFromTable < 7 Then
                                    ColorCursorSelectCase(NumberFromTable, Label)
                                End If
                            End If
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_534D47_545259_DisplayFromTable, ex, ("EX_534D47_545259_DisplayFromTable").Replace("_", " "))
        End Try

    End Sub

    Private Sub TheBusinessSub(ByRef SelectedNumber As Short, _
                             Optional ByRef FormLoad As Boolean = False, _
                             Optional ByRef ClearPhase As Boolean = False, _
                             Optional ByRef UndoArray As ArrayList = Nothing)

        Try
            Dim TableLog As System.Data.DataTable = Globals.Activity.SamsGame
            Dim CurrentPhase As String = Nothing


            For i As Integer = 1 To 4 ' Loop the Cols
                Dim SelectRows_0 As System.Data.DataRow() = Globals.Activity.SamsGame.Select("Phase_" + i.ToString() + " = 0")

                If SelectRows_0.Length = 1 Then
                    CurrentPhase = "Phase_" + i.ToString()

                    If FormLoad Then
                        PhasePicSelect(CurrentPhase)
                    End If

                    If ClearPhase Then
                        Dim SelectRows_CP = Globals.Activity.SamsGame.Select(CurrentPhase + " >= 0 AND " + CurrentPhase + " <= 6")
                        For ii As Integer = 1 To SelectRows_CP.Length
                            Dim DataRow_CP As DataRow = SelectRows_CP.GetValue(ii - 1)
                            DataRow_CP.Item(CurrentPhase) = SelectedNumber
                        Next
                        PhasePicSelect(CurrentPhase)
                    End If

                    If UndoArray IsNot Nothing Then

                        'RESET ALL NEXT PHASES
                        Dim PhaseClicked As Short = UndoArray.Item(2)
                        For ii As Integer = PhaseClicked To 4 ' Loop the Cols

                            Dim NextPhase As String = "Phase_" + (ii + 1).ToString()
                            If NextPhase = "Phase_5" Then
                                PhasePicSelect(CurrentPhase)
                                Exit For
                            End If

                            Dim SelectRows_02 As System.Data.DataRow() = Globals.Activity.SamsGame.Select(NextPhase + " >= 0 AND " + NextPhase + " <= 5")
                            If SelectRows_02.Length > 0 Then

                                For iii As Integer = 1 To SelectRows_02.Length
                                    With Globals.Activity.SamsGame
                                        .Rows(iii - 1)(NextPhase) = SelectedNumber
                                    End With
                                Next
                            End If
                        Next

                        'RESET THIS PHASE
                        Dim SelectRows_UA = Globals.Activity.SamsGame.Select(UndoArray.Item(0) + " >= 0 AND " + UndoArray.Item(0) + " <= 5")
                        For ii As Integer = UndoArray.Item(1) To SelectRows_UA.Length
                            With Globals.Activity.SamsGame
                                .Rows(ii - 1)(UndoArray.Item(0)) = SelectedNumber
                            End With
                        Next
                        Globals.Activity.SamsGame.Rows(UndoArray.Item(1) - 1)(UndoArray.Item(0)) = 0

                        'SHOW THE CURRENT PHASE ARROW
                        For iii As Integer = 1 To 4
                            Dim TrackBackPhase As String = "Phase_" + iii.ToString()
                            Dim SelectRows_TB As System.Data.DataRow() = Globals.Activity.SamsGame.Select(TrackBackPhase + " = 0")
                            If SelectRows_TB.Length = 1 Then
                                PhasePicSelect(TrackBackPhase)
                            End If
                        Next
                        Exit For
                    End If

                    If Not FormLoad AndAlso Not ClearPhase AndAlso UndoArray Is Nothing Then
                        Dim DataRow_0 As DataRow = SelectRows_0.GetValue(0)
                        DataRow_0.Item(CurrentPhase) = SelectedNumber
                    End If

                End If
            Next

            If CurrentPhase IsNot Nothing AndAlso UndoArray Is Nothing Then
                For i As Integer = 1 To 4 ' Loop the Cols
                    Dim SelectRows_6 As System.Data.DataRow() = Globals.Activity.SamsGame.Select(CurrentPhase + " = 6")

                    If SelectRows_6.Length > 0 Then
                        If FormLoad Then
                        End If

                        If Not FormLoad Then
                            Dim DataRow_6 As DataRow = SelectRows_6.GetValue(0)
                            DataRow_6.Item(CurrentPhase) = 0
                            PhasePicSelect(CurrentPhase)
                            Exit For
                        End If
                    Else
                        If CurrentPhase IsNot TCols.SamsGame.Phase_4 Then
                            CurrentPhase = "Phase_" + (i + 1).ToString()
                        End If
                    End If
                Next
            End If


            DisplayFromTable(Globals.Activity.SamsGame)
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_534D47_545259_TheBusinessSub, ex, ("EX_534D47_545259_TheBusinessSub").Replace("_", " "))
        Finally
        End Try

    End Sub

#End Region

#Region "    SAMANTHA'S GAME BUTTONS AND BOXES     "

#Region "    COMPUTER BUTTONS     "
    Private Sub btn_Samantha_Game_Ctrl_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_1.Click
        TheBusinessSub(1)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_2.Click
        TheBusinessSub(2)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_3.Click
        TheBusinessSub(3)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_4.Click
        TheBusinessSub(4)
    End Sub
#End Region

#Region "    ARROW COMPLETE BUTTONS     "
    Private Sub pbx_Phase_1_Arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Phase_1_Arrow.Click
        TheBusinessSub(5, , True)
    End Sub

    Private Sub pbx_Phase_2_Arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Phase_2_Arrow.Click
        TheBusinessSub(5, , True)
    End Sub

    Private Sub pbx_Phase_3_Arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Phase_3_Arrow.Click
        TheBusinessSub(5, , True)
    End Sub

    Private Sub pbx_Phase_4_Arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Phase_4_Arrow.Click
        TheBusinessSub(5, , True)
    End Sub
#End Region

#Region "    BOXES CLICK TO UNDO     "
    Private Sub CollectSenderInformation(ByRef Lable As System.Windows.Forms.Label)
        Try
            Dim LblName As String = Lable.Name.ToString()
            Dim ItemArray As New ArrayList(3)

            Dim TColumn As String
            Dim PhaseNu As String
            Dim LineNum As Short

            With LblName ' lbl_Phase_1_1
                TColumn = .Remove(0, 4).ToString().Remove(7, 2) ' lbl_{Phase_1}_1
                LineNum = .Remove(0, 12) 'lbl_Phase_1_{1}
                PhaseNu = .Remove(0, 10).ToString().Remove(1, 2) 'lbl_Phase_{1}_1
            End With

            ItemArray.Add(TColumn)
            ItemArray.Add(LineNum)
            ItemArray.Add(PhaseNu)

            TheBusinessSub(6, , , ItemArray)
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_534D47_545259_CollectSenderInformation, ex, ("EX_534D47_545259_CollectSenderInformation").Replace("_", " "))
        Finally
        End Try
    End Sub

#Region "    PHASE 1     "
    Private Sub lbl_Phase_1_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_1_1.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_1_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_1_2.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_1_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_1_3.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_1_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_1_4.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_1_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_1_5.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_1_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_1_6.Click
        CollectSenderInformation(sender)
    End Sub
#End Region
#Region "    PHASE 2     "
    Private Sub lbl_Phase_2_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_2_1.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_2_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_2_2.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_2_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_2_3.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_2_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_2_4.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_2_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_2_5.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_2_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_2_6.Click
        CollectSenderInformation(sender)
    End Sub
#End Region
#Region "    PHASE 3     "
    Private Sub lbl_Phase_3_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_3_1.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_3_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_3_2.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_3_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_3_3.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_3_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_3_4.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_3_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_3_5.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_3_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_3_6.Click
        CollectSenderInformation(sender)
    End Sub
    Private Sub lbl_Phase_3_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_3_7.Click
        CollectSenderInformation(sender)
    End Sub
#End Region
#Region "    PHASE 4     "
    Private Sub lbl_Phase_4_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_4_1.Click
        CollectSenderInformation(sender)
    End Sub

    Private Sub lbl_Phase_4_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_4_2.Click
        CollectSenderInformation(sender)
    End Sub

    Private Sub lbl_Phase_4_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_4_3.Click
        CollectSenderInformation(sender)
    End Sub

    Private Sub lbl_Phase_4_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_4_4.Click
        CollectSenderInformation(sender)
    End Sub

    Private Sub lbl_Phase_4_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_4_5.Click
        CollectSenderInformation(sender)
    End Sub

    Private Sub lbl_Phase_4_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_4_6.Click
        CollectSenderInformation(sender)
    End Sub

    Private Sub lbl_Phase_4_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_4_7.Click
        CollectSenderInformation(sender)
    End Sub

    Private Sub lbl_Phase_4_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Phase_4_8.Click
        Try
            Globals.Activity.SamsGame.Rows(7)(TCols.SamsGame.Phase_4) = 0
            DisplayFromTable(Globals.Activity.SamsGame)
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_534D47_545259_lbl_Phase_4_8_Click, ex, ("EX_534D47_545259_lbl_Phase_4_8_Click").Replace("_", " "))
        End Try
    End Sub

#End Region

#End Region

#End Region

#Region "    DYNAMIC CONTROLS     "

#Region "    CONTROL COLOR CHANGE     "


    Private Sub ColorCursorSelectCase(ByRef GmeNum As Short, _
                                      ByRef Control As Control)

        Dim Display_Color As Boolean = False
        Dim Display_Numbers As Boolean = False

        If My.Settings.set_SamsGame_Display = 0 Then
            Display_Color = True
            Display_Numbers = True
        ElseIf My.Settings.set_SamsGame_Display = 1 Then
            Display_Numbers = True
        ElseIf My.Settings.set_SamsGame_Display = 2 Then
            Display_Color = True
        End If

        Try
            'COLOR IS IN R.G.B.
            Select Case GmeNum
                Case Is = 1 'RED
                    If Display_Color Then ControlColor(Control, 215, 0, 0)
                    If Not Display_Color Then Control.BackColor = System.Drawing.Color.DarkGray
                    If Display_Numbers Then Control.Text = 1
                    If Not Display_Numbers Then Control.Text = ""
                    Control.Cursor = Cursors.No
                Case Is = 2 'GREEN
                    If Display_Color Then ControlColor(Control, 51, 153, 0)
                    If Not Display_Color Then Control.BackColor = System.Drawing.Color.DarkGray
                    If Display_Numbers Then Control.Text = 2
                    If Not Display_Numbers Then Control.Text = ""
                    Control.Cursor = Cursors.No
                Case Is = 3 'BLUE
                    If Display_Color Then ControlColor(Control, 0, 51, 204)
                    If Not Display_Color Then Control.BackColor = System.Drawing.Color.DarkGray
                    If Display_Numbers Then Control.Text = 3
                    If Not Display_Numbers Then Control.Text = ""
                    Control.Cursor = Cursors.No
                Case Is = 4 'YELLOW
                    If Display_Color Then ControlColor(Control, 244, 204, 51)
                    If Not Display_Color Then Control.BackColor = System.Drawing.Color.DarkGray
                    If Display_Numbers Then Control.Text = 4
                    If Not Display_Numbers Then Control.Text = ""
                    Control.Cursor = Cursors.No
                Case Is = 5
                    Control.BackColor = System.Drawing.Color.DarkGray
                    Control.Text = "X"
                    Control.Cursor = Cursors.Arrow
                Case Is = 0
                    Control.BackColor = System.Drawing.Color.DarkGray
                    Control.Text = ""
                    Control.Cursor = Cursors.Arrow
                Case Is = 6
                    Control.BackColor = System.Drawing.Color.DarkGray
                    Control.Text = ""
                    Control.Cursor = Cursors.Arrow
            End Select
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_534D47_545259_ColorCursorSelectCase, ex, ("EX_534D47_545259_ColorCursorSelectCase").Replace("_", " "))
        Finally
        End Try
    End Sub

    Private Function PhasePicSelect(ByRef Phase As String)

        Dim PictureBox As System.Windows.Forms.PictureBox = Nothing
        pbx_Phase_1_Arrow.Visible = False
        pbx_Phase_2_Arrow.Visible = False
        pbx_Phase_3_Arrow.Visible = False
        pbx_Phase_4_Arrow.Visible = False

        Try
            Select Case Phase
                Case Is = "Phase_1"
                    PictureBox = pbx_Phase_1_Arrow
                Case Is = "Phase_2"
                    PictureBox = pbx_Phase_2_Arrow
                Case Is = "Phase_3"
                    PictureBox = pbx_Phase_3_Arrow
                Case Is = "Phase_4"
                    PictureBox = pbx_Phase_4_Arrow
                Case Else
                    ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                                EX_534D47_53454C_PhasePicSelect, Nothing, ("EX_534D47_53454C_PhasePicSelect").Replace("_", " "))
                    Return Nothing
                    Exit Function
            End Select

            With PictureBox
                .Visible = True
                .Image = Global.BO_Zombies.My.Resources.Resources.arrow_l
                .BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            End With

        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_534D47_545259_PhasePicSelect, ex, ("EX_534D47_545259_PhasePicSelect").Replace("_", " "))
        Finally
        End Try
        Return PictureBox

    End Function

#Region "    RADIO BUTTON SELECTIONS    "
    Private Sub rdb_ShowBoth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_ShowBoth.CheckedChanged
        My.Settings.set_SamsGame_Display = 0
        DisplayFromTable(Globals.Activity.SamsGame)
    End Sub
    Private Sub rdb_NumbersOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_NumbersOnly.CheckedChanged
        My.Settings.set_SamsGame_Display = 1
        DisplayFromTable(Globals.Activity.SamsGame)
    End Sub
    Private Sub rdb_ColorOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_ColorOnly.CheckedChanged
        My.Settings.set_SamsGame_Display = 2
        DisplayFromTable(Globals.Activity.SamsGame)
    End Sub
#End Region

#Region "    MOUSE HOVER    "
    Private Sub btn_Samantha_Game_Ctrl_1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_1.MouseEnter
        ControlColor(sender, 255, 0, 0)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_1.MouseLeave
        ControlColor(sender, 215, 0, 0)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_2.MouseEnter
        ControlColor(sender, 51, 177, 0)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_2.MouseLeave
        ControlColor(sender, 51, 153, 0)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_3.MouseEnter
        ControlColor(sender, 0, 51, 255)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_3.MouseLeave
        ControlColor(sender, 0, 51, 204)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_4.MouseEnter
        ControlColor(sender, 244, 220, 51)
    End Sub

    Private Sub btn_Samantha_Game_Ctrl_4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Game_Ctrl_4.MouseLeave
        ControlColor(sender, 244, 204, 51)
    End Sub
#End Region

#End Region

#End Region

#Region "     OTHER BUTTONS     "

    Private Sub btn_Samantha_Finished_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Samantha_Finished.Click

        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub btn_ResetForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ResetForm.Click

        Globals.Activity.SamsGame.Clear()

        BuildTable()

    End Sub

#End Region

#Region "     KEYDOWN EVENTS     "

    Private Sub SamsGame_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        '[F] THE F1,F2,F3,F4 KEY USAGE
        Select Case e.KeyCode
            Case Is = Keys.F1
                btn_Samantha_Game_Ctrl_1.PerformClick()
            Case Is = Keys.F2
                btn_Samantha_Game_Ctrl_2.PerformClick()
            Case Is = Keys.F3
                btn_Samantha_Game_Ctrl_3.PerformClick()
            Case Is = Keys.F4
                btn_Samantha_Game_Ctrl_4.PerformClick()
            Case Else
        End Select

        '[1234567890] STANDARD NUMBERKEY USAGE
        Select Case e.KeyCode
            Case Is = Keys.D1
                btn_Samantha_Game_Ctrl_1.PerformClick()
            Case Is = Keys.D2
                btn_Samantha_Game_Ctrl_2.PerformClick()
            Case Is = Keys.D3
                btn_Samantha_Game_Ctrl_3.PerformClick()
            Case Is = Keys.D4
                btn_Samantha_Game_Ctrl_4.PerformClick()
            Case Else
        End Select

        '[NUMPAD] STANDARD NUMBERPAD USAGE
        Select Case e.KeyCode
            Case Is = Keys.NumPad1
                btn_Samantha_Game_Ctrl_1.PerformClick()
            Case Is = Keys.NumPad2
                btn_Samantha_Game_Ctrl_2.PerformClick()
            Case Is = Keys.NumPad3
                btn_Samantha_Game_Ctrl_3.PerformClick()
            Case Is = Keys.NumPad4
                btn_Samantha_Game_Ctrl_4.PerformClick()
            Case Else

        End Select

    End Sub

#End Region

#Region "     DISABLE CONTROLS     "

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

#End Region

#Region "      'FORM CLOSING'      "

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Enabled = True

        'TODO: SamsGame: Check no cleaning is needed
    End Sub

#End Region
End Class