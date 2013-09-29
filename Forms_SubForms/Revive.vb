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

Public Class Revive

    'TODO: MANAGE THE UPDATE VALUE FROM 'Revive' TO INCLUDE STARTING VALUE UPDATE ON REVIVING NOT DOWNING
    '      TO KEEP ALL VALUES UPDATED. MAYBE A SEND BUTTON FOR ONLY THE START BOX

    'TODO: Expand, Colourise and web link this form hiding the main Home form
    'TODO: Add a status bar to the form
    'TODO: add more global updates to this form
    'TODO: add other players to this form

#Region "      'LOAD'      "

    Private Sub Revive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.Enabled = False

        ActivityDataGrid(Me.Name.ToString(), Globals.Activity.Revive, Me.dgd_Activity_Log)

        Me.ntb_Score_End.Text = 0

        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        Try
            If Not dgd_Activity_Log.Columns.Count = 0 Then
                If Not dgd_Activity_Log.Rows.Count = 0 Then
                    Globals.Score.Revive = Globals.Activity.Revive.Compute("sum(" + TCols.Revive.Differance + ")", "")
                End If
            End If
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_525645_545259_Revive_Load, ex, ("EX_525645_545259_Revive_Load").Replace("_", " "))
        End Try

        DoGlobalTotals(Me.Name.ToString())
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        If Not Globals.Score.Current = 0 Then
            Me.ntb_Score_Start.Text = Globals.Score.Current
        Else
            Me.ntb_Score_Start.Text = 0
        End If

        If Not Globals.Score.Revive = 0 Then
            Me.lbl_Score_Revive.Text = Globals.Score.Revive.ToString("#,#")
        Else
            Me.lbl_Score_Revive.Text = 0
        End If

        Me.lbl_Score_Maximum.Text = Globals.Score.Maximum.ToString("#,#")
        If Globals.Score.Maximum > 50000 Then
            ControlColor(Me.lbl_Score_Maximum, 51, 153, 0)
        ElseIf Globals.Score.Maximum < 50000 And Globals.Score.Maximum > 25000 Then
            ControlColor(Me.lbl_Score_Maximum, 244, 204, 51)
        ElseIf Globals.Score.Maximum < 25000 Then
            ControlColor(Me.lbl_Score_Maximum, 215, 0, 0)
        End If

    End Sub

#End Region

#Region "     BUTTONS    "
    Private Sub btn_Calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Calculate.Click

        Dim StartValue As Integer = Convert.ToInt32(TestForInvalid(Me.ntb_Score_Start))
        Dim EndxxValue As Integer = Convert.ToInt32(TestForInvalid(Me.ntb_Score_End))

        'Test For Zero
        If StartValue = 0 Then
            ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                        IF_49464D_Invalid_Values2, Nothing, ("IF_49464D_Invalid_Values2").Replace("_", " "))
            Exit Sub
        End If

        If StartValue < EndxxValue Then
            ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, _
                        IF_49464D_Invalid_Values1, Nothing, ("IF_49464D_Invalid_Values1").Replace("_", " "))
            Exit Sub
        End If

        Dim Calculated As Integer = StartValue - EndxxValue

        Dim ANRODTT(4) As Object 'Add New Row Of Data To Table = ANRODTT
        ANRODTT(1) = TimeStamp()
        ANRODTT(2) = StartValue
        ANRODTT(3) = EndxxValue
        ANRODTT(4) = Calculated

        Globals.Activity.Revive.Rows.Add(ANRODTT)

        Select_Last_Row(Me.dgd_Activity_Log, Globals.Activity.Revive)

        '==========================================================================================

        Try
            If Not Me.dgd_Activity_Log.Columns.Count = 0 Then
                If Not Me.dgd_Activity_Log.Rows.Count = 0 Then
                    Globals.Score.Revive = Globals.Activity.Revive.Compute("sum(" + TCols.Revive.Differance + ")", "")
                End If
            End If
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_525645_545259_btn_Calculate_Click, ex, ("EX_525645_545259_btn_Calculate_Click").Replace("_", " "))
        End Try

        '==========================================================================================


        If Not Globals.Score.Revive = 0 Then
            Me.lbl_Score_Revive.Text = Globals.Score.Revive.ToString("#,#")
        Else
            Me.lbl_Score_Revive.Text = 0
        End If


        Me.ntb_Score_Start.Text = 0
        Me.ntb_Score_End.Text = 0

        '==========================================================================================
        Globals.Score.Current = EndxxValue
        Home.lbl_Score_Current.Text = Globals.Score.Current.ToString("#,#")
        Home.ntb_Score_Current.Text = 0

        DoGlobalTotals(Me.Name.ToString())

        Me.lbl_Score_Maximum.Text = Globals.Score.Maximum.ToString("#,#")

        If Globals.Score.Maximum > 50000 Then
            ControlColor(Me.lbl_Score_Maximum, 51, 153, 0)
        ElseIf Globals.Score.Maximum < 50000 And Globals.Score.Maximum > 25000 Then
            ControlColor(Me.lbl_Score_Maximum, 244, 204, 51)
        ElseIf Globals.Score.Maximum < 25000 Then
            ControlColor(Me.lbl_Score_Maximum, 215, 0, 0)
        End If
    End Sub

    Private Sub btn_Clear_Selected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear_Selected.Click

        Try
            If Not Globals.Activity.Revive.Columns.Count <= 0 Then
                If Not Globals.Activity.Revive.Rows.Count <= 0 Then
                    Dim CurrentInt As Integer = Me.dgd_Activity_Log.CurrentRow.Index

                    Me.dgd_Activity_Log.Rows.Remove(Me.dgd_Activity_Log.CurrentRow)
                    If Not Globals.Activity.Revive.Rows.Count <= 1 Then
                        Select_Last_Row(Me.dgd_Activity_Log, Globals.Activity.Revive)
                    End If
                End If
            End If

            '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            If Not Me.dgd_Activity_Log.Columns.Count = 0 Then
                If Not Me.dgd_Activity_Log.Rows.Count = 0 Then
                    Globals.Score.Revive = Globals.Activity.Revive.Compute("sum(" + TCols.Revive.Differance + ")", "")
                End If
            End If


            If Not Globals.Score.Revive = 0 Then
                Me.lbl_Score_Revive.Text = Globals.Score.Revive.ToString("#,#")
            Else
                Me.lbl_Score_Revive.Text = 0
            End If


            Me.ntb_Score_Start.Text = 0
            Me.ntb_Score_End.Text = 0

            Globals.Score.Current = 0
            Home.lbl_Score_Current.Text = 0
            Home.ntb_Score_Current.Text = 0

            DoGlobalTotals(Me.Name.ToString())

            Me.lbl_Score_Maximum.Text = Globals.Score.Maximum.ToString("#,#")

            If Globals.Score.Maximum > 50000 Then
                ControlColor(Me.lbl_Score_Maximum, 51, 153, 0)
            ElseIf Globals.Score.Maximum < 50000 And Globals.Score.Maximum > 25000 Then
                ControlColor(Me.lbl_Score_Maximum, 244, 204, 51)
            ElseIf Globals.Score.Maximum < 25000 Then
                ControlColor(Me.lbl_Score_Maximum, 215, 0, 0)
            End If
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_525645_545259_btn_Clear_Selected_Click, ex, ("EX_525645_545259_btn_Clear_Selected_Click").Replace("_", " "))
        End Try
    End Sub

#End Region

#Region "     FOCUS LEAVE ACTIONS     "
    Private Sub ntb_Score_Start_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Score_Start.Enter
        Me.ntb_Score_Start.Text = Nothing
    End Sub

    Private Sub ntb_Score_Start_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Score_Start.Leave
        If Me.ntb_Score_Start.Text = Nothing Then Me.ntb_Score_Start.Text = 0
    End Sub

    Private Sub ntb_Score_End_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Score_End.Enter
        Me.ntb_Score_End.Text = Nothing
    End Sub

    Private Sub ntb_Score_End_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ntb_Score_End.Leave
        If Me.ntb_Score_End.Text = Nothing Then Me.ntb_Score_End.Text = 0
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

#Region "     OTHER BUTTONS    "

    Private Sub btn_ReviveCalcs_Finished_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ReviveCalcs_Finished.Click
        Me.Close()
    End Sub

#End Region

#Region "      'FORM CLOSING'      "

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Enabled = True

        'TODO: Revive: Check no cleaning is needed
    End Sub

#End Region
End Class