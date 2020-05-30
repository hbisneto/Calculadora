Public Class MyTheme

    Public DefaultTheme As String = "#2C5899"
    Public NightTheme As String = "#292929"
    Public DarkGrayTheme As String = "#6D6D6D"
    Public GrayTheme As String = "#B1B1B1"
    Public Foreground As String = "#FFFFFF"
    Public Sub MainWindow()

        ' ============ Main Window ===========
        Form1.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.GroupBox1.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Panel2.BackColor = ColorTranslator.FromHtml(NightTheme)
        ' ============ Main Window Foreground ===========
        Form1.LblVisor.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.LblVisor.ForeColor = ColorTranslator.FromHtml(GrayTheme)
        Form1.HistoryTextBox.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.HistoryTextBox.ForeColor = ColorTranslator.FromHtml(GrayTheme)
        ' ============ Main Window ===========

        '1: ============ Operation Buttons ===========
        Form1.BtnDivide.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnIgual.BackColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnSubtrai.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnSoma.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnMultiplica.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnDividePorVisor.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnPotencia.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnRaiz.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        '1.1: ============ Operation Foreground Buttons ===========
        Form1.BtnDivide.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.BtnIgual.ForeColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnSubtrai.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.BtnSoma.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.BtnMultiplica.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.BtnDividePorVisor.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.BtnPotencia.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.BtnRaiz.ForeColor = ColorTranslator.FromHtml(Foreground)
        '1.2: ============ Operation Border Buttons ===========
        Form1.BtnDivide.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnMultiplica.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnSubtrai.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnSoma.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnIgual.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnDividePorVisor.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnPotencia.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        Form1.BtnRaiz.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        '1: ============ Operation Buttons ===========

        '2: ============ Action Buttons ===========
        Form1.BtnPonto.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnLimpar.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnPorcent.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.PlusAndMinusBtn.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnMLimpa.BackColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnMMostra.BackColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnMMais.BackColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnMMenos.BackColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnPorcent.BackColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnCorrige.BackColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnLimpar.BackColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnBackSpace.BackColor = ColorTranslator.FromHtml(DarkGrayTheme)

        '2.1: ============ Action Foreground Buttons ===========
        Form1.BtnPonto.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.BtnLimpar.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.BtnPorcent.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.PlusAndMinusBtn.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.BtnMLimpa.ForeColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnMMostra.ForeColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnMMais.ForeColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnMMenos.ForeColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnPorcent.ForeColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnCorrige.ForeColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnLimpar.ForeColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnBackSpace.ForeColor = ColorTranslator.FromHtml(NightTheme)
        '2.2: ============ Action Border Buttons ===========
        Form1.BtnPonto.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnLimpar.FlatAppearance.BorderColor = ColorTranslator.FromHtml(GrayTheme)
        Form1.BtnPorcent.FlatAppearance.BorderColor = ColorTranslator.FromHtml(GrayTheme)
        Form1.PlusAndMinusBtn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.BtnMLimpa.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnMMostra.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnMMais.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnMMenos.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnPorcent.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnCorrige.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnLimpar.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DarkGrayTheme)
        Form1.BtnBackSpace.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DarkGrayTheme)
        '2: ============ Action Buttons ===========

        '3: ============ Number Buttons ===========
        Form1.Btn0.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn1.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn2.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn3.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn4.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn5.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn6.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn7.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn8.BackColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn9.BackColor = ColorTranslator.FromHtml(NightTheme)
        '3.1: ============ Number Foreground Buttons ===========
        Form1.Btn0.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.Btn1.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.Btn2.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.Btn3.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.Btn4.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.Btn5.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.Btn6.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.Btn7.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.Btn8.ForeColor = ColorTranslator.FromHtml(Foreground)
        Form1.Btn9.ForeColor = ColorTranslator.FromHtml(Foreground)
        '3.2: ============ Number Buttons ===========
        Form1.Btn0.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn1.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn2.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn3.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn4.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn5.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn6.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn7.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn8.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        Form1.Btn9.FlatAppearance.BorderColor = ColorTranslator.FromHtml(NightTheme)
        '3: ============ Number Buttons ===========
    End Sub

    Public Sub AboutAppTheme()
        AboutApp.BackColor = ColorTranslator.FromHtml(NightTheme)

        AboutApp.AppName.BackColor = ColorTranslator.FromHtml(NightTheme)
        AboutApp.AppName.ForeColor = ColorTranslator.FromHtml(Foreground)

        AboutApp.Version.BackColor = ColorTranslator.FromHtml(NightTheme)
        AboutApp.Version.ForeColor = ColorTranslator.FromHtml(Foreground)

        AboutApp.Copyright.BackColor = ColorTranslator.FromHtml(NightTheme)
        AboutApp.Copyright.ForeColor = ColorTranslator.FromHtml(Foreground)

        AboutApp.ProjectNameTextBox.BackColor = ColorTranslator.FromHtml(NightTheme)
        AboutApp.ProjectNameTextBox.ForeColor = ColorTranslator.FromHtml(Foreground)
    End Sub
    Public Sub CheckForUpdateTheme()

        Dim PicControl = CheckUpdate.AppIcon
        CheckUpdate.Controls.Add(PicControl)
        PicControl.BackColor = ColorTranslator.FromHtml(NightTheme)

        CheckUpdate.BackColor = ColorTranslator.FromHtml(NightTheme)
        CheckUpdate.UpdateInfoLabel.BackColor = ColorTranslator.FromHtml(NightTheme)
        CheckUpdate.UpdateInfoLabel.ForeColor = Color.White
        CheckUpdate.NotaDeLancamentoLabel.BackColor = ColorTranslator.FromHtml(NightTheme)
        CheckUpdate.NotaDeLancamentoLabel.ForeColor = Color.White
        CheckUpdate.GroupBoxUpdate.ForeColor = Color.White
        CheckUpdate.GroupBoxUpdate.BackColor = ColorTranslator.FromHtml(NightTheme)
        CheckUpdate.AtualizacaoInfo.ForeColor = Color.White
        CheckUpdate.AtualizacaoInfo.BackColor = ColorTranslator.FromHtml(NightTheme)
        CheckUpdate.UpdateUpLabel.BackColor = ColorTranslator.FromHtml(NightTheme)
        CheckUpdate.UpdateUpLabel.ForeColor = Color.White
        CheckUpdate.UpdateProgressBar.BackColor = ColorTranslator.FromHtml(NightTheme)
        CheckUpdate.UpdateDownLabel.BackColor = ColorTranslator.FromHtml(NightTheme)
        CheckUpdate.UpdateDownLabel.ForeColor = Color.White
        CheckUpdate.DownloadGroupBox.BackColor = ColorTranslator.FromHtml(NightTheme)
        CheckUpdate.DownloadGroupBox.ForeColor = Color.White

        CheckUpdate.InstallButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        CheckUpdate.NaoIntalarButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
    End Sub
    Public Sub CMDTheme()
        CMD.BackColor = ColorTranslator.FromHtml(NightTheme)
        CMD.ForeColor = ColorTranslator.FromHtml(Foreground)

        CMD.Label1.BackColor = ColorTranslator.FromHtml(NightTheme)
        CMD.Label1.ForeColor = ColorTranslator.FromHtml(Foreground)

        CMD.InputCode.BackColor = ColorTranslator.FromHtml(NightTheme)
        CMD.InputCode.ForeColor = ColorTranslator.FromHtml(Foreground)

        CMD.WarningLabel.BackColor = ColorTranslator.FromHtml(NightTheme)
        CMD.WarningLabel.ForeColor = ColorTranslator.FromHtml(Foreground)

        CMD.ExeButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
    End Sub

    Public Sub DuelLogTheme()
        Dim DL = DuelLog

        ' ============ Window ===========
        DL.BackColor = ColorTranslator.FromHtml(NightTheme)
        DL.BtnOk.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        ' ============ Window ===========
        ' ============ P1 Controller ===========
        DL.ProfilePicP1.BackColor = ColorTranslator.FromHtml(NightTheme)
        DL.LblP1Name.BackColor = ColorTranslator.FromHtml(NightTheme)
        DL.ListViewP1.BackColor = ColorTranslator.FromHtml(NightTheme)

        DL.LblP1Name.ForeColor = ColorTranslator.FromHtml(Foreground)
        DL.ListViewP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        ' ============ P1 Controller ===========

        ' ============ P2 Controller ===========
        DL.ProfilePicP2.BackColor = ColorTranslator.FromHtml(NightTheme)
        DL.LblP2Name.BackColor = ColorTranslator.FromHtml(NightTheme)
        DL.ListViewP2.BackColor = ColorTranslator.FromHtml(NightTheme)

        DL.LblP2Name.ForeColor = ColorTranslator.FromHtml(Foreground)
        DL.ListViewP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        ' ============ P2 Controller ===========
    End Sub

    Public Sub DuelTimeTheme()
        Dim DT = DuelTime

        ' ============ Window ===========
        DT.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.ProfilePicP1.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.ProfilePicP2.BackColor = ColorTranslator.FromHtml(NightTheme)
        ' ============ Window ===========

        ' ============ P1 Controllers ===========
        DT.LblP1Name.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.LblP1Life.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.LblPointsP1.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.TxtBoxPointsP1.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.BtnAddLP1.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        DT.BtnAddLP1.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        DT.BtnSubLP1.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        DT.BtnSubLP1.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)

        DT.LblP1Name.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.LblP1Life.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.LblPointsP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.TxtBoxPointsP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.BtnAddLP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.BtnSubLP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        ' ============ P1 Controllers ===========

        ' ============ P2 Controllers ===========
        DT.LblP2Name.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.LblP2Life.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.LblPointsP2.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.TxtBoxPointsP2.BackColor = ColorTranslator.FromHtml(NightTheme)
        DT.BtnAddLP2.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        DT.BtnAddLP2.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        DT.BtnSubLP2.BackColor = ColorTranslator.FromHtml(DefaultTheme)
        DT.BtnSubLP2.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)

        DT.LblP2Name.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.LblP2Life.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.LblPointsP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.TxtBoxPointsP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.BtnAddLP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        DT.BtnSubLP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        ' ============ P2 Controllers ===========
    End Sub

    Public Sub DuelTimeSettingsTheme()
        Dim DS = DuelTimeSettings

        ' ============ DuelSettings Window ===========
        DS.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.TabPage1.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.TabPage2.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.DuelTimeApplyButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml(DefaultTheme)
        ' ============ DuelSettings Window ===========

        ' ============ Personagem1 BackColor ===========
        DS.LblNomeJogadorP1.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.LblPersonagemP1.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.LblTotalPontosP1.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.TxtBoxNomeJogadorP1.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.TxtBoxTotalPontosP1.BackColor = ColorTranslator.FromHtml(NightTheme)
        ' ============ Personagem1 BackColor ===========

        ' ============ Personagem1 ForeColor ===========
        DS.LblNomeJogadorP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        DS.LblPersonagemP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        DS.LblTotalPontosP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        DS.TxtBoxNomeJogadorP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        DS.TxtBoxTotalPontosP1.ForeColor = ColorTranslator.FromHtml(Foreground)
        ' ============ Personagem1 ForeColor ===========

        ' ============ Personagem2 BackColor ===========
        DS.LblNomeJogadorP2.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.LblPersonagemP2.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.LblTotalPontosP2.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.TxtBoxNomeJogadorP2.BackColor = ColorTranslator.FromHtml(NightTheme)
        DS.TxtBoxTotalPontosP2.BackColor = ColorTranslator.FromHtml(NightTheme)
        ' ============ Personagem2 BackColor ===========

        ' ============ Personagem2 ForeColor ===========
        DS.LblNomeJogadorP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        DS.LblPersonagemP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        DS.LblTotalPontosP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        DS.TxtBoxNomeJogadorP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        DS.TxtBoxTotalPontosP2.ForeColor = ColorTranslator.FromHtml(Foreground)
        ' ============ Personagem2 ForeColor ===========
    End Sub
End Class
