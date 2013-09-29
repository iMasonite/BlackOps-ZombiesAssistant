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

#End Region

Public Class KillTracker

	Private Sub Me_Initialized(sender As Object, e As System.EventArgs) Handles Me.Initialized
		Me.Icon = ZombieLabs
		Me.FormElement.TitleBar.IconPrimitive.ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
		Me.FormElement.TitleBar.IconPrimitive.ScaleSize = New Size(16, 16)
	End Sub

	Private Sub KillTracker_Load(sender As Object, e As System.EventArgs) Handles Me.Load
		Home.Enabled = False
		ActivityDataGrid(Me.Name.ToString(), Globals.Activity.KillTracker, Me.dgd_Activity_Log)


		If Not Me.dgd_Activity_Log.Columns.Count = 0 Then
			If Not Me.dgd_Activity_Log.Rows.Count = 0 Then

				LastTimeStamp = dgd_Activity_Log.Item(2, dgd_Activity_Log.Rows.Count - 1).Value
				LastKills = dgd_Activity_Log.Item(1, dgd_Activity_Log.Rows.Count - 1).Value
				Me.Rad_nud_Round.Value = dgd_Activity_Log.Item(0, dgd_Activity_Log.Rows.Count - 1).Value


				Me.Rad_ntb_Init_Kills.Enabled = True
				Me.Rad_ntb_Init_Kills.Text = dgd_Activity_Log.Item(1, dgd_Activity_Log.Rows.Count - 1).Value
				Me.Rad_ntb_Init_Kills.Enabled = False


			End If
		Else
			Me.Rad_ntb_Init_Kills.Enabled = True
			Me.Rad_ntb_Init_Kills.Text = 0

			LastTimeStamp = Nothing
			LastKills = Convert.ToInt64(Replace(Me.Rad_ntb_Curr_Kills.Text, ",", ""))
			Me.Rad_nud_Round.Value = 1
		End If

		Me.lbl_KillsInCurrRound.Text = KillsInRound

	End Sub

#Region "     MAIN BUTTONS     "

	Private Sub Rad_btn_SubmitNew_Click(sender As System.Object, e As System.EventArgs) Handles Rad_btn_SubmitNew.Click
		CurrentTimeStamp = DateTime.Now()
		If LastTimeStamp = Nothing Then LastTimeStamp = DateTime.Now
		If Me.Rad_ntb_Init_Kills.Enabled Then LastKills = Convert.ToInt64(Replace(Me.Rad_ntb_Init_Kills.Text, ",", ""))

		Dim TimeSpan As TimeSpan = CurrentTimeStamp.Subtract(LastTimeStamp)
		LastTimeStamp = CurrentTimeStamp ' Reset to current time

		Dim ANRODTT(4) As Object 'Add New Row Of Data To Table = ANRODTT
		ANRODTT(0) = Convert.ToInt64(Replace(Me.Rad_nud_Round.Value, ",", ""))
		ANRODTT(1) = Convert.ToInt64(Replace(Me.Rad_ntb_Curr_Kills.Text, ",", ""))
		ANRODTT(2) = CurrentTimeStamp
		ANRODTT(3) = Convert.ToInt64(Replace(Me.Rad_ntb_Curr_Kills.Text, ",", "")) - LastKills
		ANRODTT(4) = String.Format("{0}h:{1}m:{2}s", TimeSpan.Hours, TimeSpan.Minutes, TimeSpan.Seconds)

		LastKills = Convert.ToInt64(Replace(Me.Rad_ntb_Curr_Kills.Text, ",", ""))

		Globals.Activity.KillTracker.Rows.Add(ANRODTT)
		Select_Last_Row(Me.dgd_Activity_Log, Globals.Activity.KillTracker)


		Me.Rad_ntb_Init_Kills.Enabled = False

		If Not Me.Rad_cbx_AutoRound.Checked Then
			Me.lbl_KillsInCurrRound.Text = KillsInRound
		End If

		If Me.Rad_cbx_AutoRound.Checked Then Me.Rad_nud_Round.Value = Me.Rad_nud_Round.Value + 1

	End Sub

	Private Sub Rad_nud_Round_ValueChanged(sender As System.Object, e As System.EventArgs) Handles Rad_nud_Round.ValueChanged

		Me.lbl_KillsInCurrRound.Text = KillsInRound

	End Sub

	Private Sub Rad_btn_ResetAll_Click(sender As System.Object, e As System.EventArgs) Handles Rad_btn_ResetAll.Click

	End Sub

#End Region

#Region "     Public Property     "
	Private Property_KillsInRound As Integer
	Public ReadOnly Property KillsInRound() As Integer
		Get
			If Not Me.dgd_Activity_Log.Columns.Count = 0 Then
				If Not Me.dgd_Activity_Log.Rows.Count = 0 Then
					Try
						Dim Expression As String = "[R-Num] = " + Convert.ToInt64(Me.Rad_nud_Round.Value.ToString()).ToString()
						Dim FoundRows() As DataRow

						' Use the Select method to find all rows matching the filter.
						FoundRows = Globals.Activity.KillTracker.Select(Expression)

						Dim SumCells As Integer
						For Each EachDataRow As DataRow In FoundRows
							SumCells = SumCells + EachDataRow.ItemArray(3)
						Next
						Property_KillsInRound = SumCells.ToString()

					Catch ex As Exception
					End Try
				End If
			End If
			Return Property_KillsInRound
		End Get
		'Set(ByVal value As Integer)
		'	Property_KillsInRound = value
		'End Set
	End Property

	Private Property_LastKills As Integer
	Public Property LastKills() As Integer
		Get
			Return Property_LastKills
		End Get
		Set(ByVal value As Integer)
			Property_LastKills = value
		End Set
	End Property

	Private Property_LastTimeStamp As DateTime = Nothing
	Public Property LastTimeStamp() As DateTime
		Get
			Return Property_LastTimeStamp
		End Get
		Set(ByVal value As DateTime)
			Property_LastTimeStamp = value
		End Set
	End Property

	Private Property_CurrentTimeStamp As DateTime
	Public Property CurrentTimeStamp() As DateTime
		Get
			Return Property_CurrentTimeStamp
		End Get
		Set(ByVal value As DateTime)
			Property_CurrentTimeStamp = value
		End Set
	End Property


#End Region


#Region "     OTHER BUTTONS    "

	Private Sub Rad_FinishClose_Click(sender As System.Object, e As System.EventArgs) Handles Rad_FinishClose.Click
		Me.Close()
	End Sub

	Private Sub Rad_btn_ClearSelected_Click(sender As System.Object, e As System.EventArgs)
		If Not Globals.Activity.KillTracker.Columns.Count <= 0 Then
			If Not Globals.Activity.KillTracker.Rows.Count <= 0 Then
				Dim CurrentInt As Integer = Me.dgd_Activity_Log.CurrentRow.Index

				Me.dgd_Activity_Log.Rows.Remove(Me.dgd_Activity_Log.CurrentRow)
				If Not Globals.Activity.KillTracker.Rows.Count <= 1 Then
					Select_Last_Row(Me.dgd_Activity_Log, Globals.Activity.KillTracker)
				End If
			End If
		End If

	End Sub

#End Region

#Region "      'FORM CLOSING'      "

	Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Home.Enabled = True

		'TODO: Revive: Check no cleaning is needed
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

End Class