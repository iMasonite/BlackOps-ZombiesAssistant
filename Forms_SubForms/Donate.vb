Public NotInheritable Class Donate

    Private Sub Donate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load




    End Sub


    Private Sub btn_Donate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Donate.Click
        If Me.ntb_DonateAmmount.Text = Nothing Or Me.ntb_DonateAmmount.Text = "" Then
            Me.ntb_DonateAmmount.Text = 1
        End If


        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=DASJWXCJAVUDC&lc=GB&item_name=AppreciationDonation&item_number=MoonScoreTracker2012&amount=" + Me.ntb_DonateAmmount.Text.ToString() + "&currency_code=GBP&no_note=1&no_shipping=1&rm=1&return=https%3a%2f%2fwww%2epentostar%2eco%2euk%2fsuccesstrans&cancel_return=https%3a%2f%2fwww%2epentostar%2eco%2euk%2fcanceltrans&currency_code=GBP&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted")
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.paypal.com/uk/cgi-bin/webscr?cmd=xpt/Merchant/popup/WaxAboutPaypal-outside")
    End Sub


    Private Sub pbx_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Close.Click
        Me.Close()
    End Sub

    Private Sub pbx_Close_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Close.MouseEnter
        Me.pbx_Close.BackgroundImage = Global.BO_Zombies.My.Resources.icn_window_close_white_light
    End Sub

    Private Sub pbx_Close_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbx_Close.MouseLeave
        Me.pbx_Close.BackgroundImage = Global.BO_Zombies.My.Resources.icn_window_close_white_dark
    End Sub
End Class
