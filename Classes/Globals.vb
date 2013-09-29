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


Public Class Globals







#Region "     GLOBAL VARIABLES    "

    Public Shared SC As String

    Structure Score
        'Dim Score As Integer

        Shared Grand As Integer
        Shared Maximum As Integer
        Shared Spent As Integer
        Shared Manual As Integer

        Shared Current As Integer
        Shared Should As Integer

        Shared Downs As Integer
        Shared Revive As Integer
    End Structure
#End Region

#Region "     GLOBAL DATATABLES     "

    Structure Activity
        Dim Activity As DataTable()
        Shared Home As New DataTable()
        Shared Revive As New DataTable()
        Shared Downs As New DataTable()
		Shared SamsGame As New DataTable()
		Shared KillTracker As New DataTable()
	End Structure

#End Region

#Region "     GLOBAL STRINGBUILDER     "

    Structure HexSave
        Dim HexSaveString As StringBuilder
        Shared Home As New StringBuilder()
        Shared Revive As New StringBuilder()
        Shared Downs As New StringBuilder()
        Shared SamsGame As New StringBuilder()
    End Structure

#End Region
End Class
