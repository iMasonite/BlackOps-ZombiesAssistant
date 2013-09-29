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

Public Class Constants
    Public Const MaximumStarter As Integer = 1999990

#Region "    TABLE COLUMNS    "
    Structure TCols
        Structure Home
            Shared ID As String = "ID"
            Shared Time As String = "Time"
            Shared Action As String = "Action"
            Shared Item As String = "Item Name"
            Shared Value As String = "Value"
            Shared HEX As String = "HEX"
        End Structure
        Structure Downs
            Shared ID As String = "ID"
            Shared Time As String = "Time"
            Shared Player As String = "Action"
            Shared Score As String = "Input"
            Shared Loss As String = "Loss"
        End Structure
        Structure Revive
            Shared ID As String = "ID"
            Shared Time As String = "Time"
            Shared Start As String = "Start Value"
            Shared Endd As String = "End Value"
            Shared Differance As String = "Difference"
        End Structure
		Structure SamsGame
			Shared Phase_1 As String = "Phase_1"
			Shared Phase_2 As String = "Phase_2"
			Shared Phase_3 As String = "Phase_3"
			Shared Phase_4 As String = "Phase_4"
		End Structure
		Structure KillTracker
			Shared Round As String = "R-Num"
			Shared Kills As String = "Kills"
			Shared RoundTime As String = "TimeStamp"
			Shared Elapsed As String = "Elapsed"
			Shared KillsInRound As String = "Kills/R"
		End Structure
	End Structure
#End Region

#Region "    ACTIONS    "
    Structure Actions
        Shared Buy As String = "Buy Item"
        Shared Perks As String = "Perks Glitch"
        Shared Revive As String = "Revive Glitch"
        Shared Manual As String = "Manual Value"
        Shared HakItem As String = "Hack Item"
        Shared HakPlay As String = "Hack Player"
        Shared HakDoor As String = "Hack Door"
        Shared PlayerDown As String = "Player Down"
        Shared SelfDown As String = "Self Down"
    End Structure
#End Region

#Region "    SHORTKEYS    "
    Structure ShortKeys
        Shared Juggernog As String = Keys.F1
        Shared Stammin_Up As String = Keys.F2
        Shared PHD_Flopper As String = Keys.F3
        Shared Mule_Kick As String = Keys.F4
        Shared Speed_Cola As String = Keys.F5
        Shared Quick_Revive As String = Keys.F6
        Shared Double_Tap As String = Keys.F7
        Shared Dead_Shot As String = Keys.F8

        Shared AK74U As String = Keys.A
        Shared AK74U_Ammo As String = Keys.S
        Shared MPL As String = Keys.M
        Shared MPL_Ammo As String = Keys.Oemcomma

        Shared Max_Ammo_Hack As String = Keys.ShiftKey
        Shared Bowie_Knife As String = Keys.B
        Shared Pack_A_Punch As String = Keys.K
        Shared Hack_Player As String = Keys.P

        Shared Buy_The_Box_0_Hack_The_Box As String = Keys.V

        Shared RemoveLogEntry As String = Keys.Delete
        'TODO: Make Sure the keys are not MenuStrip Shorts
    End Structure
#End Region

#Region "    EXCEPTION MESSAGE STRUCTURES    "
    Structure Exceptions
        Structure Body
            Shared Critical As String = "A Critical Internal Error has occurred!" + vbNewLine + "(This Programmer must be on Crack...)"
            Shared External As String = "A External Error has occurred!" + vbNewLine + "(Put down your Crack Pipe and try again.. Yeah??)"
            Shared Unknownn As String = "An Unknown Error has occurred! This event has been raised due to an unknown error." + vbNewLine + "(Looks like its not just the Programmer that is on crack... you And your computer are too...)"
            Shared Information As String = "There is Information that needs to be noted:"
        End Structure
        Structure Title
            Shared Critical As String = "A Critical Internal Error has occurred!"
            Shared External As String = "A External Error has occurred!"
            Shared Unknownn As String = "An Unknown Error has occurred!"
            Shared Information As String = "Information..."
        End Structure
    End Structure
#End Region

End Class
