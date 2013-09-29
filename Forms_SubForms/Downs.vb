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

Public Class Downs

#Region "    FORM LOAD     "
    Private Sub Downs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.Enabled = False

        ActivityDataGrid(Me.Name.ToString(), Globals.Activity.Downs, Me.dgd_Activity_Log)

        Me.ntb_Entry_Value.Text = 0
        Me.rdb_Self.Checked = True


    End Sub

#End Region

#Region "     MAIN BUTTONS     "
    Private Sub btn_Calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Calculate.Click
        Try
            Dim CheckedVal As Integer = Convert.ToInt32(TestForInvalid(Me.ntb_Entry_Value))

            'Test For Zero
            If CheckedVal = 0 Then
                ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                            IF_49464D_Invalid_Values2, Nothing, ("IF_49464D_Invalid_Values2").Replace("_", " "))
                Exit Sub
            End If

            '@ DO THE CALCULATION @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Dim Calculated As Integer
            Dim Self_Times As Double
            Dim Play_Times As Double

            If Not Me.cbx_DownFirst.Checked Then Self_Times = 0.05
            If Me.cbx_DownFirst.Checked Then Self_Times = 0.0526315729
            If Not Me.cbx_DownFirst.Checked Then Play_Times = 0.1
            If Me.cbx_DownFirst.Checked Then Play_Times = 0.1111111111


            Dim NumberReques As Double
            If Me.rdb_Self.Checked Then NumberReques = CheckedVal * Self_Times
            If Me.rdb_Player.Checked Then NumberReques = CheckedVal * Play_Times

            Dim DecimalPoint As Double = NumberReques / 10
            Dim RoundingMath As Double = Math.Ceiling(DecimalPoint)
            Dim IntegerPoint As Integer = RoundingMath * 10

            Dim Correction As Integer

            Dim FilterVal As String = (CheckedVal + IntegerPoint).ToString()
            If Me.cbx_DownFirst.Checked Then
                If FilterVal = FilterVal.EndsWith("00") Then
                    Correction = 10
                Else
                    Correction = 0
                End If
            End If

            Calculated = IntegerPoint + Correction
            '@ ADD THE DATA TO THE TABLE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

			Dim ANRODTT(4) As Object 'Add New Row Of Data To Table = ANRODTT
			ANRODTT(1) = TimeStamp()
			If Me.rdb_Self.Checked Then ANRODTT(2) = Actions.SelfDown.ToString()
			If Me.rdb_Player.Checked Then ANRODTT(2) = Actions.PlayerDown.ToString()
			ANRODTT(3) = CheckedVal
			ANRODTT(4) = Calculated

            Globals.Activity.Downs.Rows.Add(ANRODTT)

            Select_Last_Row(Me.dgd_Activity_Log, Globals.Activity.Downs)

            '@ UPDATE THE GLOBALS AND SHOW NEW INFO @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            If Not Me.dgd_Activity_Log.Columns.Count = 0 Then
                If Not Me.dgd_Activity_Log.Rows.Count = 0 Then
                    Globals.Score.Downs = Globals.Activity.Downs.Compute("sum(" + TCols.Downs.Loss + ")", "")
                End If
            End If
            '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            Home.lbl_Score_Down.Text = Globals.Score.Downs.ToString("#,#")

            DoGlobalTotals(Me.Name.ToString())

        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_44574E_545259_btn_Calculate_Click, ex, ("EX_44574E_545259_btn_Calculate_Click").Replace("_", " "))
        End Try
    End Sub

    Private Sub btn_RemoveSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RemoveSelected.Click
        Try

            If Not Globals.Activity.Downs.Columns.Count <= 0 Then
                If Not Globals.Activity.Downs.Rows.Count <= 0 Then
                    Dim CurrentInt As Integer = Me.dgd_Activity_Log.CurrentRow.Index

                    Me.dgd_Activity_Log.Rows.Remove(Me.dgd_Activity_Log.CurrentRow)
                    If Not Globals.Activity.Downs.Rows.Count <= 1 Then
                        Select_Last_Row(Me.dgd_Activity_Log, Globals.Activity.Downs)
                    End If
                End If
            End If


            '@ UPDATE THE GLOBALS AND SHOW NEW INFO @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            If Not Me.dgd_Activity_Log.Columns.Count = 0 Then
                If Not Me.dgd_Activity_Log.Rows.Count = 0 Then
                    Globals.Score.Downs = Globals.Activity.Downs.Compute("sum(" + TCols.Downs.Loss + ")", "")
                End If
            End If
            '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            Home.lbl_Score_Down.Text = Globals.Score.Downs.ToString("#,#")

            DoGlobalTotals(Me.Name.ToString())


        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_44574E_545259_btn_Clear_Selected_Click, ex, ("EX_44574E_545259_btn_Clear_Selected_Click").Replace("_", " "))
        End Try
    End Sub
#End Region

#Region "     FOCUS LEAVE ACTIONS     "

    Private Sub ntb_Entry_Value_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Entry_Value.Enter
        Me.ntb_Entry_Value.Text = Nothing
    End Sub

    Private Sub ntb_Entry_Value_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Entry_Value.Leave
        If Me.ntb_Entry_Value.Text = Nothing Then Me.ntb_Entry_Value.Text = 0
    End Sub


#End Region

#Region "     OTHER BUTTONS     "
    Private Sub rdb_Self_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Self.CheckedChanged
        If Me.rdb_Self.Checked Then Me.lbl_Information.Text = IF_49464D_SelfDown.ToString()
        If Me.rdb_Self.Checked Then Me.cbx_DownFirst.Text = "After Down?"

    End Sub

    Private Sub rdb_Player_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Player.CheckedChanged
        If Me.rdb_Player.Checked Then Me.lbl_Information.Text = IF_49464D_PlayerDown.ToString()
        If Me.rdb_Player.Checked Then Me.cbx_DownFirst.Text = "After Bleedout?"
    End Sub

    Private Sub btn_DownBleedout_Finished_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Finished.Click
        Me.Close()
    End Sub

#End Region

#Region "     KEYDOWN EVENTS     "

    Private Sub Home_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'Select Case e.KeyCode
        '    Case Is = ShortKeys.Juggernog
        '        btn_Juggernog.PerformClick()
        'End Select

    End Sub

#Region "     KILLKEYED TEXTBOXES     "

#End Region

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

        'TODO: Downs: Check no cleaning is needed
    End Sub

#End Region
End Class