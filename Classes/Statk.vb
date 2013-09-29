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


Public Class StaticWork







#Region "    CONVERTERS AND CHAR MANIPULATION    "

    Public Shared Function Hexadecimal(ByRef StringText As String) As String

        Dim ByteArray() As Byte
        Dim HexNumbers As New StringBuilder

        Try
            ByteArray = ASCIIEncoding.ASCII.GetBytes(StringText)

            For i As Integer = 0 To ByteArray.Length - 1
                HexNumbers.Append(ByteArray(i).ToString("x").ToUpper)
            Next
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_535441_545259_Hexadecimal, ex, ("EX_535441_545259_Hexadecimal").Replace("_", " "))
        End Try

        Return HexNumbers.ToString()

    End Function
#End Region

#Region "    COMPUTER CHECKS     "

    Public Shared Sub Check_DisplayResolution()
        Dim Height As Integer = My.Computer.Screen.Bounds.Height
        Dim Width As Integer = My.Computer.Screen.Bounds.Width
        Try
            If Height < 768 Or Width < 1150 Then
                Subroutine.ExcepHandle(Exceptions.Body.Information, Exceptions.Title.Information, IF_49464D_Check_DisplayResolution, , "IF_49464D_Check_DisplayResolution" + vbNewLine + vbNewLine + "Your Screen Bounds are: Hight." + Height.ToString() + " x Width." + Width.ToString())
            End If
        Catch ex As Exception
            ExcepHandle(Exceptions.Body.Critical, Exceptions.Title.Critical, _
                        EX_535441_545259_Check_DisplayResolution, ex, ("EX_535441_545259_Check_DisplayResolution").Replace("_", " "))
        End Try
    End Sub

#End Region

End Class
