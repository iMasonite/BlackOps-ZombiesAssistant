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
Imports Telerik.WinControls.UI
#End Region

Public Class Subroutine

#Region "    PURCHASE ACTIVITY SUBROUTINES    "

    Public Shared Sub SubmitAndUpdateItem(Optional ByRef Sender As Button = Nothing, Optional ByRef StringVal As String = Nothing)

        Try
            'COLLECT INFORMATION = ADD ROW OF DATA TO ACTIVITY LOG AND DATAGRID ==============
            '
            Dim SenderName_Under As String = Nothing
            Dim SenderName_Space As String = Nothing

            If Not StringVal = Nothing Then
                SenderName_Under = StringVal.Replace(" ", "_")
                SenderName_Space = StringVal.Replace("_", " ")

                Item_Database(SenderName_Under)
            Else
                SenderName_Under = ControlNameString(Sender).Item(0)
                SenderName_Space = ControlNameString(Sender).Item(1)

                Item_Database(SenderName_Under)

                Dim ANRODTT(5) As Object 'Add New Row Of Data To Table = ANRODTT
                ANRODTT(1) = TimeStamp()
                ANRODTT(2) = ItemDatabase.PurchaseActi
                ANRODTT(3) = SenderName_Space
                ANRODTT(4) = ItemDatabase.PurchaseValu
                ANRODTT(5) = ItemDatabase.Hexadecimals

                Globals.Activity.Home.Rows.Add(ANRODTT)
            End If

            Select_Last_Row(Home.dgd_Activity_Log, Globals.Activity.Home)
            '
            'UPDATE LABLES BY COMPUTING THE ROWS USING SUM OR COUNT FROM MY.SETTINGS BOOLEAN==
            '
            Dim ComputeItems As Integer = 0

            If Not IsDBNull(Globals.Activity.Home.Compute(SC + "(" + TCols.Home.Value + ")", "[" + TCols.Home.Item + "] = '" + SenderName_Space + "'")) Then
                ComputeItems = Globals.Activity.Home.Compute(SC + "(" + TCols.Home.Value + ")", "[" + TCols.Home.Item + "] = '" + SenderName_Space + "'")
            End If

            If Not ItemDatabase.DisplayLable Is Nothing Then
                If Not ComputeItems = 0 Then
                    ItemDatabase.DisplayLable.Text = ComputeItems.ToString("#,#")
                Else
                    ItemDatabase.DisplayLable.Text = ComputeItems.ToString()
                End If
            ElseIf SenderName_Under = "Manual_Entry" Then
                If Not ItemDatabase.PurchaseValu = 0 Then
                    Home.lbl_Manual_Entry.Text = ItemDatabase.PurchaseValu.ToString("#,#")
                Else
                    Home.lbl_Manual_Entry.Text = ItemDatabase.PurchaseValu.ToString()
                End If
            End If
            '
            'FINALISE ====================================================================
            'Play a system sound to ensure the user knows the input was successful
            Asterisk.Play()

            DoGlobalTotals(Home.Name.ToString())

        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_535542_545259_SubmitAndUpdateItem, ex, ("EX_535542_545259_SubmitAndUpdateItem").Replace("_", " "))
        End Try
    End Sub

#End Region

#Region "    MENU FUNCTIONS     "

    Public Shared Sub ShowValuesNeeded(ByRef Control As Control, ByRef SumCount As String)
        Dim StrArray As New ArrayList()
        Dim Label As Label

        Try
            For Each Control In Control.Controls
                If TypeOf Control Is Label Then
                    Label = CType(Control, Label)
                    If Label.Tag = Nothing Or Label.Tag = "" Then
                    ElseIf Label.Tag.ToString() = "Summarizable" Then

                        StrArray.Add(Label.Name.ToString().Remove(3))
                        StrArray.Add(Label.Name.ToString().Remove(0, 4))

                        If StrArray.Item(0) = "Lbl" Or StrArray.Item(0) = "lbl" Then
                            If Label.Text <= 0 Or Label.Text = "Null" Or Label.Text = Nothing Then
                            Else
                                Dim ComputeItems As Integer = Globals.Activity.Home.Compute(SumCount + "(Value)", "[Item Name] = '" + StrArray.Item(1).Replace("_", " ") + "'")
                                Label.Text = ComputeItems
                            End If
                        End If
                        StrArray.Clear()
                    End If
                End If
            Next
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_535542_545259_ShowValuesNeeded, ex, ("EX_535542_545259_ShowValuesNeeded").Replace("_", " "))
        Finally
        End Try

    End Sub 'Exceptions Handled

#End Region

#Region "    ACTIVITY TABLES / DATAGRID COLUMNS SETTINGS    "

	Public Shared Sub ActivityDataGrid(ByRef Form As String, _
									   ByRef Activity As DataTable, _
									   ByRef DataGrid As DataGridView)

		'BUILDING THE ACTIVITY TABLES / COLUMNS, FOR THE DATAGRIDVIEW.DATASOURCE
		Try
			If Activity.Columns.Count <= 0 Then
				Select Case Form
					Case Is = "Home"
						Activity.Columns.Add(TCols.Home.ID, GetType(Integer))
						Activity.Columns(TCols.Home.ID).AutoIncrement = True
						Activity.Columns(TCols.Home.ID).AutoIncrementSeed = 1
						Activity.Columns(TCols.Home.ID).AutoIncrementStep = 1

						Activity.Columns.Add(TCols.Home.Time, GetType(String))
						Activity.Columns.Add(TCols.Home.Action, GetType(String))
						Activity.Columns.Add(TCols.Home.Item, GetType(String))
						Activity.Columns.Add(TCols.Home.Value, GetType(Integer))

						Activity.Columns.Add(TCols.Home.HEX, GetType(String))

					Case Is = "Revive"
						Activity.Columns.Add(TCols.Revive.ID, GetType(Integer))
						Activity.Columns(TCols.Revive.ID).AutoIncrement = True
						Activity.Columns(TCols.Revive.ID).AutoIncrementSeed = 1
						Activity.Columns(TCols.Revive.ID).AutoIncrementStep = 1

						Activity.Columns.Add(TCols.Revive.Time, GetType(String))
						Activity.Columns.Add(TCols.Revive.Start, GetType(Integer))
						Activity.Columns.Add(TCols.Revive.Endd, GetType(Integer))
						Activity.Columns.Add(TCols.Revive.Differance, GetType(Integer))

					Case Is = "Downs"
						Activity.Columns.Add(TCols.Downs.ID, GetType(Integer))
						Activity.Columns(TCols.Downs.ID).AutoIncrement = True
						Activity.Columns(TCols.Downs.ID).AutoIncrementSeed = 1
						Activity.Columns(TCols.Downs.ID).AutoIncrementStep = 1

						Activity.Columns.Add(TCols.Downs.Time, GetType(String))
						Activity.Columns.Add(TCols.Downs.Player, GetType(String))
						Activity.Columns.Add(TCols.Downs.Score, GetType(Integer))
						Activity.Columns.Add(TCols.Downs.Loss, GetType(Integer))

					Case Is = "SamsGame"
						Activity.Columns.Add(TCols.SamsGame.Phase_1, GetType(Short))
						Activity.Columns.Add(TCols.SamsGame.Phase_2, GetType(Short))
						Activity.Columns.Add(TCols.SamsGame.Phase_3, GetType(Short))
						Activity.Columns.Add(TCols.SamsGame.Phase_4, GetType(Short))

					Case Is = "KillTracker"
						Activity.Columns.Add(TCols.KillTracker.Round, GetType(Integer))
						Activity.Columns.Add(TCols.KillTracker.Kills, GetType(Integer))
						Activity.Columns.Add(TCols.KillTracker.RoundTime, GetType(DateTime))
						Activity.Columns.Add(TCols.KillTracker.KillsInRound, GetType(Integer))
						Activity.Columns.Add(TCols.KillTracker.Elapsed, GetType(String))

				End Select

				DataGrid.DataSource = Activity

			End If

			'DATAGRID COLUMNS SETTINGS AND SELECTIONS
			If Activity.Columns.Count > 0 Then

				Select Case Form
					Case Is = "Home"
						If Activity.Rows.Count > 0 Then
							DataGrid.CurrentCell = DataGrid.Item(0, DataGrid.Rows.Count - 1)
						End If

						DataGrid.Columns(TCols.Home.ID).Width = 27
						DataGrid.Columns(TCols.Home.ID).MinimumWidth = 27

						DataGrid.Columns(TCols.Home.Time).Width = 65
						DataGrid.Columns(TCols.Home.Time).MinimumWidth = 65

						DataGrid.Columns(TCols.Home.Action).Width = 90
						DataGrid.Columns(TCols.Home.Action).MinimumWidth = 90

						DataGrid.Columns(TCols.Home.Value).Width = 50
						DataGrid.Columns(TCols.Home.Value).MinimumWidth = 50

						DataGrid.Columns(TCols.Home.HEX).Visible = False
						DataGrid.Columns(TCols.Home.HEX).Width = 50
						DataGrid.Columns(TCols.Home.HEX).MinimumWidth = 50

					Case Is = "Revive"
						DataGrid.DataSource = Activity

						If Activity.Rows.Count > 0 Then
							DataGrid.CurrentCell = DataGrid.Item(0, DataGrid.Rows.Count - 1)
						End If

						DataGrid.Columns(TCols.Revive.ID).Width = 40
						DataGrid.Columns(TCols.Revive.ID).MinimumWidth = 40

						DataGrid.Columns(TCols.Revive.Time).Width = 80
						DataGrid.Columns(TCols.Revive.Time).MinimumWidth = 80

					Case Is = "Downs"
						DataGrid.DataSource = Activity

						If Activity.Rows.Count > 0 Then
							DataGrid.CurrentCell = DataGrid.Item(0, DataGrid.Rows.Count - 1)
						End If

						DataGrid.Columns(TCols.Downs.ID).Width = 30
						DataGrid.Columns(TCols.Downs.ID).MinimumWidth = 30

						DataGrid.Columns(TCols.Downs.Time).Width = 65
						DataGrid.Columns(TCols.Downs.Time).MinimumWidth = 65

						DataGrid.Columns(TCols.Downs.Score).Width = 70
						DataGrid.Columns(TCols.Downs.Score).MinimumWidth = 70

						DataGrid.Columns(TCols.Downs.Loss).Width = 70
						DataGrid.Columns(TCols.Downs.Loss).MinimumWidth = 70

					Case Is = "SamsGame"
						''''
						'SETTINGS
						''''
					Case Is = "KillTracker"
						DataGrid.DataSource = Activity

						If Activity.Rows.Count > 0 Then
							DataGrid.CurrentCell = DataGrid.Item(0, DataGrid.Rows.Count - 1)
						End If
						DataGrid.Columns(TCols.KillTracker.Round).Width = 45
						DataGrid.Columns(TCols.KillTracker.Round).MinimumWidth = 45

						DataGrid.Columns(TCols.KillTracker.Kills).Width = 80
						DataGrid.Columns(TCols.KillTracker.Kills).MinimumWidth = 80

						DataGrid.Columns(TCols.KillTracker.KillsInRound).Width = 80
						DataGrid.Columns(TCols.KillTracker.KillsInRound).MinimumWidth = 80

						DataGrid.Columns(TCols.KillTracker.Elapsed).Width = 100
						DataGrid.Columns(TCols.KillTracker.Elapsed).MinimumWidth = 100
				End Select
			End If

			'DISABLE SORT OF COLUMNS
			For i As Integer = 0 To DataGrid.Columns.Count - 1
				DataGrid.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
			Next

		Catch ex As Exception
			ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
			   EX_535542_545259_ActivityDataGrid, ex, ("EX_535542_545259_ActivityDataGrid").Replace("_", " "))
		End Try
	End Sub

#End Region

#Region "    DYNAMIC CONTROLS     "

    Public Shared Sub ControlColor(ByRef Control As Control, ByRef R As Integer, ByRef G As Integer, ByRef B As Integer)
        Try
            Control.BackColor = FromArgb(CType(CType(R, Byte), Integer), CType(CType(G, Byte), Integer), CType(CType(B, Byte), Integer))
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_535542_545259_ControlColor, ex, ("EX_535542_545259_ControlColor").Replace("_", " "))
        End Try
    End Sub

    Public Shared Sub ControlViewSwitcher(ByRef GroupBox As GroupBox)

        Try
            For Each Control As Control In GroupBox.Controls

                If Not Control.Tag = "NonDynamic" Then
                    If Not Control.Visible Then
                        Control.Visible = True
                    Else
                        Control.Visible = False
                    End If
                End If
            Next
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_535542_545259_ControlViewSwitcher, ex, ("EX_535542_545259_ControlViewSwitcher").Replace("_", " "))
        End Try
    End Sub

#End Region

#Region "    EXCEPTION HANDLING     "
    Public Shared Sub ExcepHandle(ByRef Criticality As String, _
                                ByRef TitleString As String, _
                                ByRef MessageBodyText As String, _
                       Optional ByRef Exception As System.Exception = Nothing, _
                       Optional ByRef ErrorCode As String = Nothing)

        'See ERROR MESSAGE STRUCTURES for Vars

        Dim MessageString As New StringBuilder
        Dim Seperator As Char = Chr(Asc("-"))

        Try
            MessageString.Append(Criticality + vbNewLine + vbNewLine)
            MessageString.Append(vbNewLine)
            MessageString.Append(Seperator, 40)
            MessageString.Append(vbNewLine)
            MessageString.Append(MessageBodyText)
            MessageString.Append(vbNewLine)
            MessageString.Append(Seperator, 40)
            MessageString.Append(vbNewLine + vbNewLine)
            If Exception IsNot Nothing Then
                MessageString.Append(Seperator, 40)
                MessageString.Append(vbNewLine + vbNewLine)
                MessageString.Append(Exception.Message)
            End If
            If ErrorCode IsNot Nothing Then
                MessageString.Append(Seperator, 40)
                MessageString.Append(vbNewLine + vbNewLine)
                MessageString.Append("Error [Code][Name]: // " + ErrorCode)
            End If

            Dim MessageBoxIcon As MessageBoxIcon

            If TitleString = "Information..." Then
                MessageBoxIcon = MessageBoxIcon.Information
            Else
                MessageBoxIcon = MessageBoxIcon.Stop
            End If

            MessageBox.Show(MessageString.ToString, _
                            TitleString, _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon)

        Catch ex As Exception
            MessageBox.Show("Error in... Error Message???!!!" _
                            + vbNewLine _
                            + "(This Programmer must be on Crack...)" + _
                            vbNewLine + vbNewLine _
                            + ex.ToString, _
                            "Error in Error Message!!! What A Fail!!!", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "     MISCELLANEOUS SUBROUTINES     "

    Public Shared Sub Select_Last_Row(ByRef DataGridView As DataGridView, ByVal Globals_Activity As DataTable)

        Try
            If Globals_Activity.Columns.Count > 0 AndAlso Globals_Activity.Rows.Count > 0 Then
                DataGridView.CurrentCell = DataGridView.Item(0, DataGridView.Rows.Count - 1)
            End If
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_535542_545259_Select_Last_Row, ex, ("EX_535542_545259_Select_Last_Row").Replace("_", " "))
        End Try
    End Sub

#End Region

End Class
