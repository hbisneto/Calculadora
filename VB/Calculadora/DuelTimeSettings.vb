Public Class DuelTimeSettings

    Public MyTheme As MyTheme = New MyTheme()
    Public MySystem As MySystem = New MySystem()

    Private Sub DuelTimeSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = DuelTimeApplyButton
        MyTheme.DuelTimeSettingsTheme()
    End Sub

    Public Sub DuelTimeApplyButton_Click(sender As Object, e As EventArgs) Handles DuelTimeApplyButton.Click
        DuelTime.Show()
        DuelTime.BringToFront()

        MySystem.PlayerOneName = TxtBoxNomeJogadorP1.Text
        'MySystem.P1StartedPoint = TxtBoxTotalPontosP1.Text

        DuelTime.LblP1Name.Text = MySystem.PlayerOneName
        DuelTime.LblP1Life.Text = TxtBoxTotalPontosP1.Text

        DuelTime.P1StartedPoint = TxtBoxTotalPontosP1.Text
        DuelTime.P1Life = DuelTime.P1StartedPoint
        
        If TxtBoxPersonagemP1.Text = "" Then
            ' Default Profile Pic
            DuelTime.ProfilePicP1.Image = MySystem.DefaultPlayer
        End If

        If TxtBoxPersonagemP1.Text = "AkizaIzinski" Then
            DuelTime.ProfilePicP1.Image = MySystem.AkizaIzinski
        End If

        If TxtBoxPersonagemP1.Text = "Alexis Rhodes" Then
            DuelTime.ProfilePicP1.Image = MySystem.AlexisRhodes
        End If

        If TxtBoxPersonagemP1.Text = "Chazz Princeton" Then
            DuelTime.ProfilePicP1.Image = MySystem.ChazzPrinceton
        End If

        If TxtBoxPersonagemP1.Text = "Jaden Yuki" Then
            DuelTime.ProfilePicP1.Image = MySystem.JadenYuki
        End If

        If TxtBoxPersonagemP1.Text = "Joey" Then
            DuelTime.ProfilePicP1.Image = MySystem.Joey
        End If

        If TxtBoxPersonagemP1.Text = "Mai Valentine" Then
            DuelTime.ProfilePicP1.Image = MySystem.MaiValentine
        End If

        If TxtBoxPersonagemP1.Text = "Maximillion Pegasus" Then
            DuelTime.ProfilePicP1.Image = MySystem.MaximillionPegasus
        End If

        If TxtBoxPersonagemP1.Text = "Seto Kaiba" Then
            DuelTime.ProfilePicP1.Image = MySystem.SetoKaiba
        End If

        If TxtBoxPersonagemP1.Text = "Tea" Then
            DuelTime.ProfilePicP1.Image = MySystem.Tea
        End If

        If TxtBoxPersonagemP1.Text = "Yami Marik" Then
            DuelTime.ProfilePicP1.Image = MySystem.YamiMarik
        End If

        If TxtBoxPersonagemP1.Text = "Yami Yugi" Then
            DuelTime.ProfilePicP1.Image = MySystem.YamiYugi
        End If

        If TxtBoxPersonagemP1.Text = "Yugi Moto" Then
            DuelTime.ProfilePicP1.Image = MySystem.Yugi
        End If

        If TxtBoxPersonagemP1.Text = "Yusei Fudo" Then
            DuelTime.ProfilePicP1.Image = MySystem.YuseiFudo
        End If

        ' Player 2

        MySystem.PlayerTwoName = TxtBoxNomeJogadorP2.Text
        DuelTime.LblP2Name.Text = MySystem.PlayerTwoName
        DuelTime.LblP2Life.Text = TxtBoxTotalPontosP2.Text
        DuelTime.P2StartedPoint = TxtBoxTotalPontosP2.Text
        DuelTime.P2Life = DuelTime.P2StartedPoint

        If TxtBoxPersonagemP2.Text = "" Then
            ' Default Profile Pic
            DuelTime.ProfilePicP2.Image = MySystem.DefaultPlayer
        End If

        If TxtBoxPersonagemP2.Text = "AkizaIzinski" Then
            DuelTime.ProfilePicP2.Image = MySystem.AkizaIzinski
        End If

        If TxtBoxPersonagemP2.Text = "Alexis Rhodes" Then
            DuelTime.ProfilePicP2.Image = MySystem.AlexisRhodes
        End If

        If TxtBoxPersonagemP2.Text = "Chazz Princeton" Then
            DuelTime.ProfilePicP2.Image = MySystem.ChazzPrinceton
        End If

        If TxtBoxPersonagemP2.Text = "Jaden Yuki" Then
            DuelTime.ProfilePicP2.Image = MySystem.JadenYuki
        End If

        If TxtBoxPersonagemP2.Text = "Joey" Then
            DuelTime.ProfilePicP2.Image = MySystem.Joey
        End If

        If TxtBoxPersonagemP2.Text = "Mai Valentine" Then
            DuelTime.ProfilePicP2.Image = MySystem.MaiValentine
        End If

        If TxtBoxPersonagemP2.Text = "Maximillion Pegasus" Then
            DuelTime.ProfilePicP2.Image = MySystem.MaximillionPegasus
        End If

        If TxtBoxPersonagemP2.Text = "Seto Kaiba" Then
            DuelTime.ProfilePicP2.Image = MySystem.SetoKaiba
        End If

        If TxtBoxPersonagemP2.Text = "Tea" Then
            DuelTime.ProfilePicP2.Image = MySystem.Tea
        End If

        If TxtBoxPersonagemP2.Text = "Yami Marik" Then
            DuelTime.ProfilePicP2.Image = MySystem.YamiMarik
        End If

        If TxtBoxPersonagemP2.Text = "Yami Yugi" Then
            DuelTime.ProfilePicP2.Image = MySystem.YamiYugi
        End If

        If TxtBoxPersonagemP2.Text = "Yugi Moto" Then
            DuelTime.ProfilePicP2.Image = MySystem.Yugi
        End If

        If TxtBoxPersonagemP2.Text = "Yusei Fudo" Then
            DuelTime.ProfilePicP2.Image = MySystem.YuseiFudo
        End If

        DuelLog.ProfilePicP1.Image = DuelTime.ProfilePicP1.Image
        DuelLog.LblP1Name.Text = MySystem.PlayerOneName

        DuelLog.ProfilePicP2.Image = DuelTime.ProfilePicP2.Image
        DuelLog.LblP2Name.Text = MySystem.PlayerTwoName

        'If TxtBoxTotalPontosP1.Text = MySystem.P1StartedPoint Then
        'Else
        '    If TxtBoxNomeJogadorP2.Text = MySystem.P2StartedPoint Then
        '    Else
        '        DuelLog.ListViewP1.Items.Clear()
        '        DuelLog.ListViewP2.Items.Clear()
        '    End If
        'End If
        Me.Close()
    End Sub
End Class