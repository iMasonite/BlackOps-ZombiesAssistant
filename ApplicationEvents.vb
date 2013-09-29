Imports System.Net.NetworkInformation

Namespace My

	' The following events are available for MyApplication:
	' 
	' Start-up: Raised when the application starts, before the start-up form is created.
	' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
	' UnhandledException: Raised if the application encounters an unhandled exception.
	' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
	' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
	Partial Friend Class MyApplication

		Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
			'set the new value of SavedSetting1
			MySettings.Default.MacAddress = GetMACAddress()
			'apply the changes to the settings file
			MySettings.Default.Save()
		End Sub


		Public Function GetMACAddress() As String
			Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
			Dim sMacAddress As [String] = String.Empty
			For Each adapter As NetworkInterface In nics
				If sMacAddress = [String].Empty Then
					' only return MAC Address from first card  
					Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
					sMacAddress = adapter.GetPhysicalAddress().ToString()
				End If
			Next
			Return sMacAddress
		End Function
	End Class

End Namespace
