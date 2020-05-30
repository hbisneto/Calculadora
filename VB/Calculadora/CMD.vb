Public Class CMD
    Dim MyTheme As MyTheme = New MyTheme()
    Dim MySystem As MySystem = New MySystem()
    
    Private Sub CMD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTheme.CMDTheme()
        Me.AcceptButton = ExeButton
    End Sub

    Private Sub ExeButton_Click(sender As Object, e As EventArgs) Handles ExeButton.Click
        If InputCode.Text = "" Then
            MySystem.CommandMessage = "Campo Vazio. Digite 'Commands' para ver a lista de comandos disponíveis..."
            Timer1.Enabled = True
            Timer1.Start()
        ElseIf InputCode.Text = "Commands" Or InputCode.Text = "commands" Then
            MessageBox.Show("Bem-vindo a janela de comandos da Calculadora. Aqui você pode encontrar alguns dos comandos usados pela CMD da Calculadora." & vbCrLf & vbCrLf & "DuelTime: Abre a janela de contador de pontos" & vbCrLf & "DuelTimeSettings: Abre a janela de configurações do contador de pontos" & vbCrLf & "CurrentTime: Mostra o horário atual em dia, mês e ano. Além de relógio com horas, minutos e segundos", "Comandos Válidos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf InputCode.Text = "DuelTime" Or InputCode.Text = "Dueltime" Or InputCode.Text = "dueltime" Or InputCode.Text = "DUELTIME" Or InputCode.Text = "Duel Time" Or InputCode.Text = "duel time" Or InputCode.Text = "DUEL TIME" Then
            DuelTime.Show()
            Me.Close()
        ElseIf InputCode.Text = "DuelTimeSettings" Or InputCode.Text = "dueltimesettings" Or InputCode.Text = "DUELTIMESETTINGS" Or InputCode.Text = "Duel Time Settings" Or InputCode.Text = "duel time settings" Or InputCode.Text = "DUEL TIME SETTINGS" Or InputCode.Text = "Duel time settings" Or InputCode.Text = "Duel Time settings" Or InputCode.Text = "Duel time Settings" Or InputCode.Text = "duel Time Settings" Then
            DuelTimeSettings.Show()
            Me.Close()
        ElseIf InputCode.Text = "CurrentTime" Or InputCode.Text = "Currenttime" Or InputCode.Text = "currenttime" Or InputCode.Text = "CURRENTTIME" Or InputCode.Text = "Current Time" Or InputCode.Text = "current time" Or InputCode.Text = "CURRENT TIME" Then
            MySystem.SetTimer = True
            MySystem.CommandMessage = "Horário Atual: "
            Timer1.Enabled = True
            Timer1.Start()
        Else
            MySystem.CommandMessage = "Comando Inválido. Digite 'Commands' para ver a lista de comandos disponíveis..."
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub

    Private Sub FecharJanelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharJanelaToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim CurrentTime As String = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss")
        
        MySystem.Count += 1

        If MySystem.Count = 1 Then
            If MySystem.SetTimer = True Then
                WarningLabel.Text = MySystem.CommandMessage & CurrentTime
                WarningLabel.Visible = True
                Form1.LblVisor.Text = CurrentTime
            Else
                WarningLabel.Text = MySystem.CommandMessage
                WarningLabel.Visible = True
            End If
        End If

        If MySystem.Count = 2 Then
            If MySystem.SetTimer = True Then
                WarningLabel.Text = MySystem.CommandMessage & CurrentTime
                WarningLabel.Visible = True
                Form1.LblVisor.Text = CurrentTime
            Else
                WarningLabel.Text = MySystem.CommandMessage
                WarningLabel.Visible = True
            End If
        End If

        If MySystem.Count = 3 Then
            If MySystem.SetTimer = True Then
                WarningLabel.Text = MySystem.CommandMessage & CurrentTime
                WarningLabel.Visible = True
                Form1.LblVisor.Text = CurrentTime
            Else
                WarningLabel.Text = MySystem.CommandMessage
                WarningLabel.Visible = True
            End If
        End If

        If MySystem.Count = 4 Then
            If MySystem.SetTimer = True Then
                WarningLabel.Text = MySystem.CommandMessage & CurrentTime
                WarningLabel.Visible = True
                Form1.LblVisor.Text = CurrentTime
            Else
                WarningLabel.Text = MySystem.CommandMessage
                WarningLabel.Visible = True
            End If
        End If

        If MySystem.Count = 5 Then
            MySystem.Count = 0
            WarningLabel.Visible = False
            MySystem.SetTimer = False
            WarningLabel.Text = ""
            Form1.LblVisor.Text = Form1.visor
            Timer1.Enabled = False
            Timer1.Stop()
        End If
    End Sub
End Class