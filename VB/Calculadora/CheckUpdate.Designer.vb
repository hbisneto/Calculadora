<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckUpdate))
        Me.AppIcon = New System.Windows.Forms.PictureBox()
        Me.NotaDeLancamentoLabel = New System.Windows.Forms.Label()
        Me.UpdateInfoLabel = New System.Windows.Forms.TextBox()
        Me.AtualizacaoInfo = New System.Windows.Forms.TextBox()
        Me.NaoIntalarButton = New System.Windows.Forms.Button()
        Me.InstallButton = New System.Windows.Forms.Button()
        Me.GroupBoxUpdate = New System.Windows.Forms.GroupBox()
        Me.UpdateDownLabel = New System.Windows.Forms.TextBox()
        Me.UpdateUpLabel = New System.Windows.Forms.TextBox()
        Me.UpdateProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DownloadGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxUpdate.SuspendLayout()
        Me.DownloadGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AppIcon
        '
        Me.AppIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.AppIcon.Image = CType(resources.GetObject("AppIcon.Image"), System.Drawing.Image)
        Me.AppIcon.Location = New System.Drawing.Point(12, 12)
        Me.AppIcon.Name = "AppIcon"
        Me.AppIcon.Size = New System.Drawing.Size(100, 100)
        Me.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppIcon.TabIndex = 30
        Me.AppIcon.TabStop = False
        Me.AppIcon.Visible = False
        '
        'NotaDeLancamentoLabel
        '
        Me.NotaDeLancamentoLabel.AutoSize = True
        Me.NotaDeLancamentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaDeLancamentoLabel.Location = New System.Drawing.Point(150, 99)
        Me.NotaDeLancamentoLabel.Name = "NotaDeLancamentoLabel"
        Me.NotaDeLancamentoLabel.Size = New System.Drawing.Size(129, 13)
        Me.NotaDeLancamentoLabel.TabIndex = 44
        Me.NotaDeLancamentoLabel.Text = "Nota de Lançamento:"
        Me.NotaDeLancamentoLabel.Visible = False
        '
        'UpdateInfoLabel
        '
        Me.UpdateInfoLabel.BackColor = System.Drawing.SystemColors.Control
        Me.UpdateInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UpdateInfoLabel.CausesValidation = False
        Me.UpdateInfoLabel.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.UpdateInfoLabel.Location = New System.Drawing.Point(118, 12)
        Me.UpdateInfoLabel.Multiline = True
        Me.UpdateInfoLabel.Name = "UpdateInfoLabel"
        Me.UpdateInfoLabel.ReadOnly = True
        Me.UpdateInfoLabel.ShortcutsEnabled = False
        Me.UpdateInfoLabel.Size = New System.Drawing.Size(299, 73)
        Me.UpdateInfoLabel.TabIndex = 43
        Me.UpdateInfoLabel.TabStop = False
        Me.UpdateInfoLabel.Text = "O servidor de atualização da Calculadora não pôde ser contatado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Verifique sua c" & _
    "onexão de internet ou tente novamente mais tarde." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.UpdateInfoLabel.Visible = False
        '
        'AtualizacaoInfo
        '
        Me.AtualizacaoInfo.BackColor = System.Drawing.SystemColors.Control
        Me.AtualizacaoInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AtualizacaoInfo.CausesValidation = False
        Me.AtualizacaoInfo.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.AtualizacaoInfo.Location = New System.Drawing.Point(6, 13)
        Me.AtualizacaoInfo.Multiline = True
        Me.AtualizacaoInfo.Name = "AtualizacaoInfo"
        Me.AtualizacaoInfo.ReadOnly = True
        Me.AtualizacaoInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AtualizacaoInfo.ShortcutsEnabled = False
        Me.AtualizacaoInfo.Size = New System.Drawing.Size(393, 231)
        Me.AtualizacaoInfo.TabIndex = 23
        Me.AtualizacaoInfo.TabStop = False
        Me.AtualizacaoInfo.Text = "O servidor de atualização do Tuíter não pôde ser contatado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Verifique sua conexã" & _
    "o de internet ou tente novamente mais tarde."
        Me.AtualizacaoInfo.Visible = False
        '
        'NaoIntalarButton
        '
        Me.NaoIntalarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NaoIntalarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.NaoIntalarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NaoIntalarButton.ForeColor = System.Drawing.Color.White
        Me.NaoIntalarButton.Location = New System.Drawing.Point(302, 374)
        Me.NaoIntalarButton.Name = "NaoIntalarButton"
        Me.NaoIntalarButton.Size = New System.Drawing.Size(115, 23)
        Me.NaoIntalarButton.TabIndex = 47
        Me.NaoIntalarButton.Text = "Não Instalar!"
        Me.NaoIntalarButton.UseVisualStyleBackColor = False
        Me.NaoIntalarButton.Visible = False
        '
        'InstallButton
        '
        Me.InstallButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstallButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.InstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InstallButton.ForeColor = System.Drawing.Color.White
        Me.InstallButton.Location = New System.Drawing.Point(181, 374)
        Me.InstallButton.Name = "InstallButton"
        Me.InstallButton.Size = New System.Drawing.Size(115, 23)
        Me.InstallButton.TabIndex = 46
        Me.InstallButton.Text = "Instalar atualização..."
        Me.InstallButton.UseVisualStyleBackColor = False
        Me.InstallButton.Visible = False
        '
        'GroupBoxUpdate
        '
        Me.GroupBoxUpdate.Controls.Add(Me.AtualizacaoInfo)
        Me.GroupBoxUpdate.Location = New System.Drawing.Point(12, 118)
        Me.GroupBoxUpdate.Name = "GroupBoxUpdate"
        Me.GroupBoxUpdate.Size = New System.Drawing.Size(405, 250)
        Me.GroupBoxUpdate.TabIndex = 45
        Me.GroupBoxUpdate.TabStop = False
        Me.GroupBoxUpdate.Visible = False
        '
        'UpdateDownLabel
        '
        Me.UpdateDownLabel.BackColor = System.Drawing.Color.White
        Me.UpdateDownLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UpdateDownLabel.CausesValidation = False
        Me.UpdateDownLabel.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.UpdateDownLabel.Location = New System.Drawing.Point(6, 54)
        Me.UpdateDownLabel.Name = "UpdateDownLabel"
        Me.UpdateDownLabel.ReadOnly = True
        Me.UpdateDownLabel.ShortcutsEnabled = False
        Me.UpdateDownLabel.Size = New System.Drawing.Size(393, 18)
        Me.UpdateDownLabel.TabIndex = 41
        Me.UpdateDownLabel.TabStop = False
        Me.UpdateDownLabel.Text = "Baixando: Calculando tamanho do arquivo..."
        Me.UpdateDownLabel.Visible = False
        '
        'UpdateUpLabel
        '
        Me.UpdateUpLabel.BackColor = System.Drawing.Color.White
        Me.UpdateUpLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UpdateUpLabel.CausesValidation = False
        Me.UpdateUpLabel.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.UpdateUpLabel.Location = New System.Drawing.Point(6, 14)
        Me.UpdateUpLabel.Name = "UpdateUpLabel"
        Me.UpdateUpLabel.ReadOnly = True
        Me.UpdateUpLabel.ShortcutsEnabled = False
        Me.UpdateUpLabel.Size = New System.Drawing.Size(393, 18)
        Me.UpdateUpLabel.TabIndex = 40
        Me.UpdateUpLabel.TabStop = False
        Me.UpdateUpLabel.Text = "Preparando para baixar a atualização..."
        Me.UpdateUpLabel.Visible = False
        '
        'UpdateProgressBar
        '
        Me.UpdateProgressBar.Location = New System.Drawing.Point(6, 38)
        Me.UpdateProgressBar.Name = "UpdateProgressBar"
        Me.UpdateProgressBar.Size = New System.Drawing.Size(300, 10)
        Me.UpdateProgressBar.TabIndex = 39
        '
        'DownloadGroupBox
        '
        Me.DownloadGroupBox.Controls.Add(Me.UpdateDownLabel)
        Me.DownloadGroupBox.Controls.Add(Me.UpdateUpLabel)
        Me.DownloadGroupBox.Controls.Add(Me.UpdateProgressBar)
        Me.DownloadGroupBox.Location = New System.Drawing.Point(12, 290)
        Me.DownloadGroupBox.Name = "DownloadGroupBox"
        Me.DownloadGroupBox.Size = New System.Drawing.Size(405, 78)
        Me.DownloadGroupBox.TabIndex = 48
        Me.DownloadGroupBox.TabStop = False
        Me.DownloadGroupBox.Text = "Processo de Atualização"
        Me.DownloadGroupBox.Visible = False
        '
        'CheckUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 406)
        Me.Controls.Add(Me.NotaDeLancamentoLabel)
        Me.Controls.Add(Me.UpdateInfoLabel)
        Me.Controls.Add(Me.NaoIntalarButton)
        Me.Controls.Add(Me.InstallButton)
        Me.Controls.Add(Me.GroupBoxUpdate)
        Me.Controls.Add(Me.DownloadGroupBox)
        Me.Controls.Add(Me.AppIcon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CheckUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckUpdate"
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxUpdate.ResumeLayout(False)
        Me.GroupBoxUpdate.PerformLayout()
        Me.DownloadGroupBox.ResumeLayout(False)
        Me.DownloadGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents NotaDeLancamentoLabel As System.Windows.Forms.Label
    Public WithEvents UpdateInfoLabel As System.Windows.Forms.TextBox
    Public WithEvents AtualizacaoInfo As System.Windows.Forms.TextBox
    Friend WithEvents NaoIntalarButton As System.Windows.Forms.Button
    Friend WithEvents InstallButton As System.Windows.Forms.Button
    Friend WithEvents GroupBoxUpdate As System.Windows.Forms.GroupBox
    Public WithEvents UpdateDownLabel As System.Windows.Forms.TextBox
    Public WithEvents UpdateUpLabel As System.Windows.Forms.TextBox
    Friend WithEvents UpdateProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents DownloadGroupBox As System.Windows.Forms.GroupBox
End Class
