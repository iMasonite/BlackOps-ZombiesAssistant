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


Public Class Functions


#Region "     GLOBAL FUNCTIONAL MATH    "

    Public Shared Function DoGlobalTotals(Optional ByRef Sender As String = "") As Integer
        Try
            'COLLECT TABLE SUMS===============================================================
            If Not Globals.Activity.Home.Columns.Count <= 0 Then
                If Not Globals.Activity.Home.Rows.Count <= 0 Then

                    If Not IsDBNull(Globals.Activity.Home.Compute("sum(" + TCols.Home.Value + ")", "[" + TCols.Home.Action + "] <> '" + Actions.Manual + "'")) Then

                        Globals.Score.Spent = Globals.Activity.Home.Compute("sum(" + TCols.Home.Value + ")", "[" + TCols.Home.Action + "] <> '" + Actions.Manual + "'")
                    End If

                    If Not IsDBNull(Globals.Activity.Home.Compute("sum(" + TCols.Home.Value + ")", "[" + TCols.Home.Action + "] = '" + Actions.Manual + "'")) Then

                        Globals.Score.Manual = Globals.Activity.Home.Compute("sum(" + TCols.Home.Value + ")", "[" + TCols.Home.Action + "] = '" + Actions.Manual + "'")
                    End If
                Else
                    Globals.Score.Spent = 0
                    Globals.Score.Manual = 0
                End If
            End If

            If Not Globals.Activity.Downs.Columns.Count <= 0 Then
                If Not Globals.Activity.Downs.Rows.Count <= 0 Then
                    If Not IsDBNull(Globals.Activity.Downs.Compute("sum(" + TCols.Downs.Loss + ")", "")) Then
                        Globals.Score.Downs = Globals.Activity.Downs.Compute("sum(" + TCols.Downs.Loss + ")", "")
                    End If
                Else
                    Globals.Score.Downs = 0
                End If
            End If

            If Not Globals.Activity.Revive.Columns.Count <= 0 Then
                If Not Globals.Activity.Revive.Rows.Count <= 0 Then
                    If Not IsDBNull(Globals.Activity.Revive.Compute("sum(" + TCols.Revive.Differance + ")", "")) Then
                        Globals.Score.Revive = Globals.Activity.Revive.Compute("sum(" + TCols.Revive.Differance + ")", "")
                    End If
                Else
                    Globals.Score.Revive = 0
                End If
            End If

            Globals.Score.Grand = Globals.Score.Spent + Globals.Score.Manual + Globals.Score.Downs + Globals.Score.Revive + Globals.Score.Current

            Globals.Score.Maximum = MaximumStarter - Globals.Score.Grand

            Globals.Score.Should = Globals.Score.Maximum + Globals.Score.Current

            Home.lbl_Score_Grand.Text = Globals.Score.Grand.ToString("#,#")
            Home.lbl_Score_Maximum.Text = Globals.Score.Maximum.ToString("#,#")
            Home.lbl_Score_Revive.Text = (Globals.Score.Revive + Globals.Score.Manual).ToString("#,#")
            Home.lbl_Score_Down.Text = Globals.Score.Downs.ToString("#,#")
            Home.lbl_Score_Spent.Text = Globals.Score.Spent.ToString("#,#")
            Home.lbl_Score_Should.Text = Globals.Score.Should.ToString("#,#")

            If Sender = Home.Name.ToString() Then
                Home.lbl_Score_Current.Text = "Update Score"
                Home.lbl_Score_Should.Text = "Update Score"
                Globals.Score.Current = 0
            End If

            If Globals.Score.Maximum < 0 Then
                ControlColor(Home.lbl_Score_Maximum, 215, 0, 0)
            Else
                Home.lbl_Score_Maximum.BackColor = Transparent
            End If
            If Globals.Score.Grand > 1999990 Then
                ControlColor(Home.lbl_Score_Grand, 215, 0, 0)
            Else
                Home.lbl_Score_Grand.BackColor = Transparent
            End If

        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_46554E_545259_DoGlobalTotals, ex, ("EX_46554E_545259_DoGlobalTotals").Replace("_", " "))
        End Try
    End Function

#End Region

#Region "     STRUCTURE DATABASES     "

    Structure ItemDatabase
        Dim ItemDatabase As String

        Shared PurchaseValu As Integer
        Shared DisplayLable As Label
        Shared Hexadecimals As String
        Shared PurchaseActi As String

    End Structure

    Shared Function Item_Database(ByRef ItemNeeded As String) As ItemDatabase

        Dim ItemDatabase As ItemDatabase

        'Ensure the structure is clean before process!
        ItemDatabase.PurchaseValu = Nothing
        ItemDatabase.DisplayLable = Nothing
        ItemDatabase.Hexadecimals = Nothing
        ItemDatabase.PurchaseActi = Nothing
        Try
            Select Case ItemNeeded
                Case Is = "Manual_Entry"
                    ItemDatabase.PurchaseValu = TestForInvalid(Home.ntb_Manual_Entry)
                    ItemDatabase.DisplayLable = Nothing
                    ItemDatabase.Hexadecimals = "M0"
                    ItemDatabase.PurchaseActi = Actions.Manual
                Case Is = "Bowie_Knife"
                    ItemDatabase.PurchaseValu = 3000
                    ItemDatabase.DisplayLable = Home.lbl_Bowie_Knife
                    ItemDatabase.Hexadecimals = "N0"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Pack_A_Punch"
                    ItemDatabase.PurchaseValu = 5000
                    ItemDatabase.DisplayLable = Home.lbl_Pack_A_Punch
                    ItemDatabase.Hexadecimals = "N1"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Claymores"
                    ItemDatabase.PurchaseValu = 1000
                    ItemDatabase.DisplayLable = Home.lbl_Claymores
                    ItemDatabase.Hexadecimals = "N2"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Semtex"
                    ItemDatabase.PurchaseValu = 250
                    ItemDatabase.DisplayLable = Home.lbl_Semtex
                    ItemDatabase.Hexadecimals = "N3"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Buy_The_Box"
                    ItemDatabase.PurchaseValu = 950
                    ItemDatabase.DisplayLable = Home.lbl_Buy_The_Box
                    ItemDatabase.Hexadecimals = "N4"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Firesale_Box"
                    ItemDatabase.PurchaseValu = 10
                    ItemDatabase.DisplayLable = Home.lbl_Firesale_Box
                    ItemDatabase.Hexadecimals = "N5"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Upgraded_Ammo"
                    ItemDatabase.PurchaseValu = 4500
                    ItemDatabase.DisplayLable = Home.lbl_Upgraded_Ammo
                    ItemDatabase.Hexadecimals = "N6"
                    ItemDatabase.PurchaseActi = Actions.Buy
                    '
                    'DOORS
                    '
                Case Is = "Door_750"
                    ItemDatabase.PurchaseValu = 750
                    ItemDatabase.DisplayLable = Home.lbl_Door_750
                    ItemDatabase.Hexadecimals = "D0"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Door_1000"
                    ItemDatabase.PurchaseValu = 1000
                    ItemDatabase.DisplayLable = Home.lbl_Door_1000
                    ItemDatabase.Hexadecimals = "D1"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Door_1250"
                    ItemDatabase.PurchaseValu = 1250
                    ItemDatabase.DisplayLable = Home.lbl_Door_1250
                    ItemDatabase.Hexadecimals = "D2"
                    ItemDatabase.PurchaseActi = Actions.Buy
                    '
                    'HACKER
                    '
                Case Is = "Hack_The_Box"
                    ItemDatabase.PurchaseValu = 600
                    ItemDatabase.DisplayLable = Home.lbl_Hack_The_Box
                    ItemDatabase.Hexadecimals = "H0"
                    ItemDatabase.PurchaseActi = Actions.HakItem
                Case Is = "Teddy_Hack"
                    ItemDatabase.PurchaseValu = 1200
                    ItemDatabase.DisplayLable = Home.lbl_Teddy_Hack
                    ItemDatabase.Hexadecimals = "H1"
                    ItemDatabase.PurchaseActi = Actions.HakItem
                Case Is = "Hack_Door"
                    ItemDatabase.PurchaseValu = 200
                    ItemDatabase.DisplayLable = Home.lbl_Hack_Door
                    ItemDatabase.Hexadecimals = "H2"
                    ItemDatabase.PurchaseActi = Actions.HakItem
                Case Is = "Hack_Player"
                    ItemDatabase.PurchaseValu = 500
                    ItemDatabase.DisplayLable = Home.lbl_Hack_Player
                    ItemDatabase.Hexadecimals = "H3"
                    ItemDatabase.PurchaseActi = Actions.HakItem
                Case Is = "Max_Ammo_Hack"
                    ItemDatabase.PurchaseValu = 5000
                    ItemDatabase.DisplayLable = Home.lbl_Max_Ammo_Hack
                    ItemDatabase.Hexadecimals = "H4"
                    ItemDatabase.PurchaseActi = Actions.HakItem
                Case Is = "Easter_Egg_Button"
                    ItemDatabase.PurchaseValu = 500
                    ItemDatabase.DisplayLable = Home.lbl_Easter_Egg_Button
                    ItemDatabase.Hexadecimals = "H5"
                    ItemDatabase.PurchaseActi = Actions.HakItem
                    '
                    'PERKS
                    '
                Case Is = "Juggernog"
                    ItemDatabase.PurchaseValu = 2500
                    ItemDatabase.DisplayLable = Home.lbl_Juggernog
                    ItemDatabase.Hexadecimals = "P0"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Speed_Cola"
                    ItemDatabase.PurchaseValu = 3000
                    ItemDatabase.DisplayLable = Home.lbl_Speed_Cola
                    ItemDatabase.Hexadecimals = "P1"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Stammin_Up"
                    ItemDatabase.PurchaseValu = 2000
                    ItemDatabase.DisplayLable = Home.lbl_Stammin_Up
                    ItemDatabase.Hexadecimals = "P2"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Dead_Shot"
                    ItemDatabase.PurchaseValu = 1500
                    ItemDatabase.DisplayLable = Home.lbl_Dead_Shot
                    ItemDatabase.Hexadecimals = "P3"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Double_Tap"
                    ItemDatabase.PurchaseValu = 2000
                    ItemDatabase.DisplayLable = Home.lbl_Double_Tap
                    ItemDatabase.Hexadecimals = "P4"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Quick_Revive"
                    ItemDatabase.PurchaseValu = 1500
                    ItemDatabase.DisplayLable = Home.lbl_Quick_Revive
                    ItemDatabase.Hexadecimals = "P5"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "PHD_Flopper"
                    ItemDatabase.PurchaseValu = 2000
                    ItemDatabase.DisplayLable = Home.lbl_PHD_Flopper
                    ItemDatabase.Hexadecimals = "P6"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Mule_Kick"
                    ItemDatabase.PurchaseValu = 4000
                    ItemDatabase.DisplayLable = Home.lbl_Mule_Kick
                    ItemDatabase.Hexadecimals = "P7"
                    ItemDatabase.PurchaseActi = Actions.Buy
                    '
                    'WEAPONS
                    '
                Case Is = "AK74U"
                    ItemDatabase.PurchaseValu = 1200
                    ItemDatabase.DisplayLable = Home.lbl_AK74U
                    ItemDatabase.Hexadecimals = "W0"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "M14"
                    ItemDatabase.PurchaseValu = 500
                    ItemDatabase.DisplayLable = Home.lbl_M14
                    ItemDatabase.Hexadecimals = "W1"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "M16"
                    ItemDatabase.PurchaseValu = 1200
                    ItemDatabase.DisplayLable = Home.lbl_M16
                    ItemDatabase.Hexadecimals = "W2"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "MP5K"
                    ItemDatabase.PurchaseValu = 1000
                    ItemDatabase.DisplayLable = Home.lbl_MP5K
                    ItemDatabase.Hexadecimals = "W3"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "MPL"
                    ItemDatabase.PurchaseValu = 1000
                    ItemDatabase.DisplayLable = Home.lbl_MPL
                    ItemDatabase.Hexadecimals = "W4"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Olympia"
                    ItemDatabase.PurchaseValu = 500
                    ItemDatabase.DisplayLable = Home.lbl_Olympia
                    ItemDatabase.Hexadecimals = "W5"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "PM63"
                    ItemDatabase.PurchaseValu = 1000
                    ItemDatabase.DisplayLable = Home.lbl_PM63
                    ItemDatabase.Hexadecimals = "W6"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Stakeout"
                    ItemDatabase.PurchaseValu = 1500
                    ItemDatabase.DisplayLable = Home.lbl_Stakeout
                    ItemDatabase.Hexadecimals = "W7"
                    ItemDatabase.PurchaseActi = Actions.Buy
                    '
                    'WEAPONS AMMO
                    '
                Case Is = "AK74U_Ammo"
                    ItemDatabase.PurchaseValu = 600
                    ItemDatabase.DisplayLable = Home.lbl_AK74U_Ammo
                    ItemDatabase.Hexadecimals = "A0"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "M14_Ammo"
                    ItemDatabase.PurchaseValu = 500
                    ItemDatabase.DisplayLable = Home.lbl_M14_Ammo
                    ItemDatabase.Hexadecimals = "Actions"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "M16_Ammo"
                    ItemDatabase.PurchaseValu = 600
                    ItemDatabase.DisplayLable = Home.lbl_M16_Ammo
                    ItemDatabase.Hexadecimals = "A2"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "MP5K_Ammo"
                    ItemDatabase.PurchaseValu = 500
                    ItemDatabase.DisplayLable = Home.lbl_MP5K_Ammo
                    ItemDatabase.Hexadecimals = "A3"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "MPL_Ammo"
                    ItemDatabase.PurchaseValu = 500
                    ItemDatabase.DisplayLable = Home.lbl_MPL_Ammo
                    ItemDatabase.Hexadecimals = "A4"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Olympia_Ammo"
                    ItemDatabase.PurchaseValu = 500
                    ItemDatabase.DisplayLable = Home.lbl_Olympia_Ammo
                    ItemDatabase.Hexadecimals = "A5"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "PM63_Ammo"
                    ItemDatabase.PurchaseValu = 500
                    ItemDatabase.DisplayLable = Home.lbl_PM63_Ammo
                    ItemDatabase.Hexadecimals = "A6"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Is = "Stakeout_Ammo"
                    ItemDatabase.PurchaseValu = 600
                    ItemDatabase.DisplayLable = Home.lbl_Stakeout_Ammo
                    ItemDatabase.Hexadecimals = "A7"
                    ItemDatabase.PurchaseActi = Actions.Buy
                Case Else
                    ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                                EX_46554E_53454C_ItemDatabase_Items, Nothing, ("EX_46554E_53454C_ItemDatabase_Items").Replace("_", " "))
                    Return Nothing
                    'TODO: Some of the  ExcepHandle's may have no ex... instead is 'Nothing'
                    Exit Function
            End Select

            ItemDatabase.Hexadecimals = Hexadecimal(ItemDatabase.Hexadecimals)

        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_46554E_545259_ItemDatabase_Items, ex, ("EX_46554E_545259_ItemDatabase_Items").Replace("_", " "))
        End Try

        ItemDatabase.ItemDatabase = Nothing
        Return ItemDatabase
    End Function

#End Region

#Region "     CALCULATOR     "

    Public Shared Function Collect_And_Compute_Numbers(ByRef vStart As TextBox, _
                                             ByRef vEnd As TextBox, _
                                             ByRef GroupBox As GroupBox) As Integer

        Try
            Dim RadioValue As String = Nothing

            For Each Control As Control In GroupBox.Controls
                If TypeOf Control Is RadioButton Then
                    Dim RadioButton As RadioButton = Control
                    If RadioButton.Checked Then
                        RadioValue = RadioButton.Tag.ToString()
                        Exit For
                    End If
                End If
            Next

            Dim Spl_vStart As Integer = Convert.ToInt32(Replace(vStart.Text, " ", ""))
            Dim Spl_vEnd As Integer = Convert.ToInt32(Replace(vEnd.Text, " ", ""))
            Dim LargerValue As Integer
            Dim SmalleValue As Integer

            Select Case RadioValue
                Case Is = "Add", "Minus"
                    LargerValue = Spl_vStart
                    SmalleValue = Spl_vEnd
                Case Is = "Divide", "Times"
                    If Spl_vStart > Spl_vEnd Then
                        LargerValue = Spl_vStart
                        SmalleValue = Spl_vEnd
                    Else
                        LargerValue = Spl_vEnd
                        SmalleValue = Spl_vStart
                    End If
                Case Else
                    ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                                EX_46554E_545259_Collect_And_Compute_Numbers, Nothing, ("EX_46554E_545259_Collect_And_Compute_Numbers").Replace("_", " "))
                    Return Nothing
                    Exit Function
            End Select

            Return SimpleMath(RadioValue, LargerValue, SmalleValue)

        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_46554E_545259_Collect_And_Compute_Numbers, ex, ("EX_46554E_545259_CollectAndComputeNumbers").Replace("_", " "))
        End Try
    End Function

#End Region

#Region "     NUMBER MANIPULATION & MATH    "

    Public Shared Function TestForInvalid(ByRef TextBox As TextBox) As Integer

        Try
            Dim NumberReques As String = Convert.ToInt32(TextBox.Text)
            Dim DecimalPoint As Double = NumberReques / 10
            Dim RoundingMath As Double = Math.Ceiling(DecimalPoint)
            Dim IntegerPoint As Integer = RoundingMath * 10

            If Not NumberReques.ToString.EndsWith("0") Then
                Dim V0 As Integer = NumberReques
                Dim V1 As Integer = NumberReques.ToString.Last.ToString()
                Dim V2 As Integer = IntegerPoint

                Dim ChangedMsgStr As String
                ChangedMsgStr = IF_49464D_WrongNumber.Replace("{0}", V0).Replace("{1}", V1).Replace("{2}", V2)

                'TODO: Customise more Information messages with this type of replace formatting.

                Dim Message_Result As MsgBoxResult = MessageBox.Show(ChangedMsgStr, _
                                                                     "Certain 'User Error' in values...", _
                                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If Message_Result = MsgBoxResult.Ok Then
                    Return IntegerPoint
                Else
                    Exit Function
                End If
            Else
                Return NumberReques
            End If
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_46554E_545259_TestForInvalid, ex, ("EX_46554E_545259_TestForInvalid").Replace("_", " "))
        End Try
    End Function

    Public Shared Function SimpleMath(ByRef iMathTypeIn As String, _
                                      ByRef LargerValue As Integer, _
                                      ByRef SmalleValue As Integer) As Integer
        Dim iMathResult As Integer
        Try
            Select Case iMathTypeIn
                Case Is = "Add", 1
                    iMathResult = LargerValue + SmalleValue
                Case Is = "Minus", 2
                    iMathResult = LargerValue - SmalleValue
                Case Is = "Divide", 3
                    iMathResult = LargerValue / SmalleValue
                Case Is = "Times", 4
                    iMathResult = LargerValue * SmalleValue
                Case Else
                    ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                                EX_46554E_53454C_SimpleMath, Nothing, ("EX_46554E_53454C_SimpleMath").Replace("_", " "))
            End Select
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_46554E_545259_SimpleMath, ex, ("EX_46554E_545259_SimpleMath").Replace("_", " "))
        End Try
        Return iMathResult
    End Function

#End Region

#Region "     STRING MANIPULATION     "

    Shared Function ControlNameString(ByRef Control As Control) As ArrayList

        Dim Control_Name As String = Control.Name.ToString()
        Dim Breakdown As New ArrayList()

        Try
            With Control_Name 'Btn_Hack_The_Box
                Breakdown.Add(.Remove(0, 4).ToString()) '"Hack_The_Box"
                Breakdown.Add(.Remove(0, 4).ToString().Replace("_", " ")) '"Hack The Box"
            End With
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_46554E_545259_Get_ControlNameString, ex, ("EX_46554E_545259_Get_ControlNameString").Replace("_", " "))
        End Try
        Return Breakdown

    End Function

#End Region

#Region "     MISCELLANEOUS FUNCTIONS     "

    Public Shared Function TimeStamp(Optional ByRef eFormat As String = "HH:mm:ss") As String
        Dim CurreDate As DateTime
        Try
            CurreDate = Now()
            'TODO: TimeStamp: if there is to be sync information between apps then there needs to be time settings more compatible
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_46554E_545259_TimeStamp, ex, ("EX_46554E_545259_TimeStamp").Replace("_", " "))
        End Try
        Return CurreDate.ToString(eFormat)
    End Function

    Public Shared Function SumCount() As String

        Dim Selected As String = Nothing
        Try
            Select Case My.Settings.set_ShowAccumulative
                Case Is = True
                    Selected = "sum"
                Case Is = False
                    Selected = "count"
                Case Else
                    ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                                EX_46554E_545259_SumCount, Nothing, ("EX_46554E_545259_SumCount").Replace("_", " "))
            End Select
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_46554E_545259_SumCount, ex, ("EX_46554E_545259_SumCount").Replace("_", " "))
        End Try
        Return Selected
    End Function

#End Region

End Class
