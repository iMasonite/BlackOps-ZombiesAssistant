Public Class NumTextBox
    Inherits System.Windows.Forms.TextBox
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        e.Handled = KillKeys(Asc(e.KeyChar))

    End Sub

    Protected Function KillKeys(ByVal KeyCode As String) As Boolean

        If (KeyCode >= 48 And KeyCode <= 57) Or KeyCode = 8 Or KeyCode = 13 Then
            'The AsCII values for numbers are between 48 to 57 and ASCII value 8 is for BackSpace.
            KillKeys = False
        Else
            KillKeys = True
        End If
    End Function
End Class