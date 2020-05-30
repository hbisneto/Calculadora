Imports System.IO
Imports System.Net

Public Class CheckUpdate
    Dim MyTheme As MyTheme = New MyTheme()
    Dim MySystem As MySystem = New MySystem()

    Public LocationToDownload As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\"
    Public AppExe As String = "Calculadora " & Form1.ServerVersion & ".exe"

    Private Sub CheckUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTheme.CheckForUpdateTheme()
        MySystem.CheckUpdateSettings()

        If UpdateInfoLabel.Text.Contains("Ocorreu um erro ao verificar atualizações...") Then
            Me.Text = "Buscando Atualizações..."
        Else
            Me.Text = "Buscando Atualizações..."
        End If

        If Directory.Exists(LocationToDownload) Then

        Else
            Directory.CreateDirectory(LocationToDownload)
        End If
    End Sub

    Private Sub InstallButton_Click(sender As Object, e As EventArgs) Handles InstallButton.Click
        InstallButton.Enabled = False
        GroupBoxUpdate.Size = New Size(405, 166)
        GroupBoxUpdate.Location = New Point(12, 118)

        AtualizacaoInfo.Size = New Size(393, 147)
        AtualizacaoInfo.Location = New Point(6, 13)

        DownloadGroupBox.Visible = True
        UpdateUpLabel.Visible = True
        UpdateProgressBar.Visible = True
        UpdateDownLabel.Visible = True

        If File.Exists(LocationToDownload & AppExe) Then
            Dim wc As New WebClient
            AddHandler wc.DownloadProgressChanged, AddressOf DownloadProgressChanged
            AddHandler wc.DownloadFileCompleted, AddressOf DownloadFileCompleted
            wc.DownloadFileAsync(New System.Uri(MySystem.GetServerApp), LocationToDownload & AppExe)
        Else
            Dim wc As New WebClient
            AddHandler wc.DownloadProgressChanged, AddressOf DownloadProgressChanged
            AddHandler wc.DownloadFileCompleted, AddressOf DownloadFileCompleted
            wc.DownloadFileAsync(New System.Uri(MySystem.GetServerApp), LocationToDownload & AppExe)
        End If
    End Sub

    Public Sub DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        Try
            UpdateProgressBar.Style = ProgressBarStyle.Continuous
            Dim SizeReceived = e.BytesReceived
            Dim TotalSizeToReceive = e.TotalBytesToReceive
            Dim FileSizeLabel = String.Format("{0} MB", (TotalSizeToReceive / 1024 / 1024).ToString("0.00"))
            UpdateProgressBar.Value = e.ProgressPercentage
            UpdateUpLabel.Text = "Baixando Atualização. Aguarde..."
            UpdateDownLabel.Text = String.Format("{0} MB", (SizeReceived / 1024 / 1024).ToString("0.00")) & " / " & FileSizeLabel & " (" & e.ProgressPercentage & "%)"
        Catch ex As Exception
        End Try
    End Sub

    Public Sub DownloadFileCompleted(sender As Object, e As EventArgs)
        UpdateProgressBar.Value = "0"
        UpdateProgressBar.Visible = False
        UpdateUpLabel.Text = "Download Concluído"
        UpdateUpLabel.ForeColor = Color.White
        UpdateDownLabel.Visible = False

        MessageBox.Show("Seu download foi concluido!" & vbCrLf & "Para verificar o arquivo baixado, vá até a Área de Trabalho", "Download Concluído", MessageBoxButtons.OK)
        Me.Close()

    End Sub

    Private Sub NaoIntalarButton_Click(sender As Object, e As EventArgs) Handles NaoIntalarButton.Click
        Me.Close()
    End Sub
End Class