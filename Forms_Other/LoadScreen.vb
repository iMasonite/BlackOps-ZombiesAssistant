#Region "     Imports    "

'======== Using My Classes.
Imports Zombies_MOON.Func
Imports Zombies_MOON.Subs
Imports Zombies_MOON.Cons
Imports Zombies_MOON.Tables

'======== Using My Resources.
Imports Zombies_MOON.My.Resources.Str
Imports Zombies_MOON.My.Resources.Errors
Imports Zombies_MOON.My.Resources.Infom
'======== Using System Items.
Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Collections
Imports System.Configuration
Imports System.Deployment
#End Region
Public NotInheritable Class LoadScreen

#Region "     Local Var's Dec    "

#End Region

    Private Sub LoadScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Dim StringBuild As New StringBuilder
        Dim VersionStr = System.String.Format(Version.Text, _
                                           My.Application.Info.Version.Major, _
                                           My.Application.Info.Version.Minor)
        StringBuild.Append(VersionStr)

        If My.Settings.set_AppRegistered = True Then
            StringBuild.Append(vbNewLine + "Registered Email: " + My.Settings.set_AppRegistered.ToString())
        Else
            StringBuild.Append(vbNewLine + "Registered Email: " + My.Settings.set_AppRegistered.ToString())
        End If
        StringBuild.Append(vbNewLine + "Beta")
        Version.Text = StringBuild.ToString()

        Copyright.Text = My.Application.Info.Copyright

        pgb_LoadTimer.Step = 0.5
        tmr_LoadTimer.Enabled = True
    End Sub

    Dim MyProgress As Double
    'This is Only Aesthetics!!!
    'This is Only Aesthetics!!!
    'This is Only Aesthetics!!!
    'This is Only Aesthetics!!!
    Private Sub tmr_LoadTimer_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_LoadTimer.Tick


        If MyProgress < 100 Then MyProgress = MyProgress + 3.147483648

        Me.Loading.Text = "Loding Program... " + MyProgress.ToString("0.00") + "%"

        If (MyProgress >= 20 AndAlso MyProgress <= 23) Then
            Threading.Thread.Sleep(1000)
        End If
        If (MyProgress >= 80 AndAlso MyProgress <= 83) Then
            Threading.Thread.Sleep(1000)
        End If

        If MyProgress >= 100 Then
            MyProgress = 100
            Loading.Text = "Complete"
            Me.btn_Continue.Visible = True
            Me.btn_ExitApp.Visible = True
            Me.btn_Close.Visible = True
        End If

        If MyProgress >= 100 Then MyProgress = 100

        Me.pgb_LoadTimer.Value = MyProgress
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Continue.Click
        Home.Show()
        'Me.Close()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_ExitApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExitApp.Click
        Application.Exit()
    End Sub

End Class
