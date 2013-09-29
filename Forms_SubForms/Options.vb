Public Class Options

#Region "      'LOAD'      "

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.Enabled = False
    End Sub

#End Region

#Region "      'FORM CLOSING'      "

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Enabled = True

        'TODO: Options: Check no cleaning is needed
    End Sub

#End Region
End Class