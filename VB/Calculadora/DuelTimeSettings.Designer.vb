<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuelTimeSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DuelTimeSettings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtBoxTotalPontosP1 = New System.Windows.Forms.TextBox()
        Me.LblTotalPontosP1 = New System.Windows.Forms.Label()
        Me.TxtBoxNomeJogadorP1 = New System.Windows.Forms.TextBox()
        Me.LblNomeJogadorP1 = New System.Windows.Forms.Label()
        Me.TxtBoxPersonagemP1 = New System.Windows.Forms.ComboBox()
        Me.LblPersonagemP1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtBoxTotalPontosP2 = New System.Windows.Forms.TextBox()
        Me.LblTotalPontosP2 = New System.Windows.Forms.Label()
        Me.TxtBoxNomeJogadorP2 = New System.Windows.Forms.TextBox()
        Me.LblNomeJogadorP2 = New System.Windows.Forms.Label()
        Me.TxtBoxPersonagemP2 = New System.Windows.Forms.ComboBox()
        Me.LblPersonagemP2 = New System.Windows.Forms.Label()
        Me.DuelTimeApplyButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(268, 198)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.TxtBoxTotalPontosP1)
        Me.TabPage1.Controls.Add(Me.LblTotalPontosP1)
        Me.TabPage1.Controls.Add(Me.TxtBoxNomeJogadorP1)
        Me.TabPage1.Controls.Add(Me.LblNomeJogadorP1)
        Me.TabPage1.Controls.Add(Me.TxtBoxPersonagemP1)
        Me.TabPage1.Controls.Add(Me.LblPersonagemP1)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(260, 172)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Jogador 1"
        '
        'TxtBoxTotalPontosP1
        '
        Me.TxtBoxTotalPontosP1.BackColor = System.Drawing.Color.Red
        Me.TxtBoxTotalPontosP1.ForeColor = System.Drawing.Color.White
        Me.TxtBoxTotalPontosP1.Location = New System.Drawing.Point(133, 59)
        Me.TxtBoxTotalPontosP1.Name = "TxtBoxTotalPontosP1"
        Me.TxtBoxTotalPontosP1.Size = New System.Drawing.Size(121, 20)
        Me.TxtBoxTotalPontosP1.TabIndex = 9
        Me.TxtBoxTotalPontosP1.Text = "8000"
        '
        'LblTotalPontosP1
        '
        Me.LblTotalPontosP1.AutoSize = True
        Me.LblTotalPontosP1.BackColor = System.Drawing.Color.White
        Me.LblTotalPontosP1.ForeColor = System.Drawing.Color.Black
        Me.LblTotalPontosP1.Location = New System.Drawing.Point(6, 62)
        Me.LblTotalPontosP1.Name = "LblTotalPontosP1"
        Me.LblTotalPontosP1.Size = New System.Drawing.Size(85, 13)
        Me.LblTotalPontosP1.TabIndex = 8
        Me.LblTotalPontosP1.Text = "Total de Pontos:"
        '
        'TxtBoxNomeJogadorP1
        '
        Me.TxtBoxNomeJogadorP1.BackColor = System.Drawing.Color.Red
        Me.TxtBoxNomeJogadorP1.ForeColor = System.Drawing.Color.White
        Me.TxtBoxNomeJogadorP1.Location = New System.Drawing.Point(133, 6)
        Me.TxtBoxNomeJogadorP1.Name = "TxtBoxNomeJogadorP1"
        Me.TxtBoxNomeJogadorP1.Size = New System.Drawing.Size(121, 20)
        Me.TxtBoxNomeJogadorP1.TabIndex = 7
        '
        'LblNomeJogadorP1
        '
        Me.LblNomeJogadorP1.AutoSize = True
        Me.LblNomeJogadorP1.BackColor = System.Drawing.Color.White
        Me.LblNomeJogadorP1.ForeColor = System.Drawing.Color.Black
        Me.LblNomeJogadorP1.Location = New System.Drawing.Point(6, 9)
        Me.LblNomeJogadorP1.Name = "LblNomeJogadorP1"
        Me.LblNomeJogadorP1.Size = New System.Drawing.Size(94, 13)
        Me.LblNomeJogadorP1.TabIndex = 6
        Me.LblNomeJogadorP1.Text = "Nome do Jogador:"
        '
        'TxtBoxPersonagemP1
        '
        Me.TxtBoxPersonagemP1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.TxtBoxPersonagemP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtBoxPersonagemP1.ForeColor = System.Drawing.Color.White
        Me.TxtBoxPersonagemP1.FormattingEnabled = True
        Me.TxtBoxPersonagemP1.Items.AddRange(New Object() {"AkizaIzinski", "Alexis Rhodes", "Chazz Princeton", "Jaden Yuki", "Joey", "Mai Valentine", "Maximillion Pegasus", "Seto Kaiba", "Tea", "Yami Marik", "Yami Yugi", "Yugi Moto", "Yusei Fudo"})
        Me.TxtBoxPersonagemP1.Location = New System.Drawing.Point(133, 32)
        Me.TxtBoxPersonagemP1.Name = "TxtBoxPersonagemP1"
        Me.TxtBoxPersonagemP1.Size = New System.Drawing.Size(121, 21)
        Me.TxtBoxPersonagemP1.TabIndex = 8
        '
        'LblPersonagemP1
        '
        Me.LblPersonagemP1.AutoSize = True
        Me.LblPersonagemP1.BackColor = System.Drawing.Color.White
        Me.LblPersonagemP1.ForeColor = System.Drawing.Color.Black
        Me.LblPersonagemP1.Location = New System.Drawing.Point(6, 35)
        Me.LblPersonagemP1.Name = "LblPersonagemP1"
        Me.LblPersonagemP1.Size = New System.Drawing.Size(69, 13)
        Me.LblPersonagemP1.TabIndex = 4
        Me.LblPersonagemP1.Text = "Personagem:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Red
        Me.TabPage2.Controls.Add(Me.TxtBoxTotalPontosP2)
        Me.TabPage2.Controls.Add(Me.LblTotalPontosP2)
        Me.TabPage2.Controls.Add(Me.TxtBoxNomeJogadorP2)
        Me.TabPage2.Controls.Add(Me.LblNomeJogadorP2)
        Me.TabPage2.Controls.Add(Me.TxtBoxPersonagemP2)
        Me.TabPage2.Controls.Add(Me.LblPersonagemP2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(260, 172)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Jogador 2"
        '
        'TxtBoxTotalPontosP2
        '
        Me.TxtBoxTotalPontosP2.BackColor = System.Drawing.Color.Red
        Me.TxtBoxTotalPontosP2.ForeColor = System.Drawing.Color.Blue
        Me.TxtBoxTotalPontosP2.Location = New System.Drawing.Point(133, 59)
        Me.TxtBoxTotalPontosP2.Name = "TxtBoxTotalPontosP2"
        Me.TxtBoxTotalPontosP2.Size = New System.Drawing.Size(121, 20)
        Me.TxtBoxTotalPontosP2.TabIndex = 15
        Me.TxtBoxTotalPontosP2.Text = "8000"
        '
        'LblTotalPontosP2
        '
        Me.LblTotalPontosP2.AutoSize = True
        Me.LblTotalPontosP2.ForeColor = System.Drawing.Color.Blue
        Me.LblTotalPontosP2.Location = New System.Drawing.Point(6, 62)
        Me.LblTotalPontosP2.Name = "LblTotalPontosP2"
        Me.LblTotalPontosP2.Size = New System.Drawing.Size(85, 13)
        Me.LblTotalPontosP2.TabIndex = 14
        Me.LblTotalPontosP2.Text = "Total de Pontos:"
        '
        'TxtBoxNomeJogadorP2
        '
        Me.TxtBoxNomeJogadorP2.BackColor = System.Drawing.Color.Red
        Me.TxtBoxNomeJogadorP2.ForeColor = System.Drawing.Color.Blue
        Me.TxtBoxNomeJogadorP2.Location = New System.Drawing.Point(133, 6)
        Me.TxtBoxNomeJogadorP2.Name = "TxtBoxNomeJogadorP2"
        Me.TxtBoxNomeJogadorP2.Size = New System.Drawing.Size(121, 20)
        Me.TxtBoxNomeJogadorP2.TabIndex = 13
        '
        'LblNomeJogadorP2
        '
        Me.LblNomeJogadorP2.AutoSize = True
        Me.LblNomeJogadorP2.ForeColor = System.Drawing.Color.Blue
        Me.LblNomeJogadorP2.Location = New System.Drawing.Point(6, 9)
        Me.LblNomeJogadorP2.Name = "LblNomeJogadorP2"
        Me.LblNomeJogadorP2.Size = New System.Drawing.Size(94, 13)
        Me.LblNomeJogadorP2.TabIndex = 12
        Me.LblNomeJogadorP2.Text = "Nome do Jogador:"
        '
        'TxtBoxPersonagemP2
        '
        Me.TxtBoxPersonagemP2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.TxtBoxPersonagemP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtBoxPersonagemP2.ForeColor = System.Drawing.Color.White
        Me.TxtBoxPersonagemP2.FormattingEnabled = True
        Me.TxtBoxPersonagemP2.Items.AddRange(New Object() {"AkizaIzinski", "Alexis Rhodes", "Chazz Princeton", "Jaden Yuki", "Joey", "Mai Valentine", "Maximillion Pegasus", "Seto Kaiba", "Tea", "Yami Marik", "Yami Yugi", "Yugi Moto", "Yusei Fudo"})
        Me.TxtBoxPersonagemP2.Location = New System.Drawing.Point(133, 32)
        Me.TxtBoxPersonagemP2.Name = "TxtBoxPersonagemP2"
        Me.TxtBoxPersonagemP2.Size = New System.Drawing.Size(121, 21)
        Me.TxtBoxPersonagemP2.TabIndex = 14
        '
        'LblPersonagemP2
        '
        Me.LblPersonagemP2.AutoSize = True
        Me.LblPersonagemP2.ForeColor = System.Drawing.Color.Blue
        Me.LblPersonagemP2.Location = New System.Drawing.Point(6, 35)
        Me.LblPersonagemP2.Name = "LblPersonagemP2"
        Me.LblPersonagemP2.Size = New System.Drawing.Size(69, 13)
        Me.LblPersonagemP2.TabIndex = 10
        Me.LblPersonagemP2.Text = "Personagem:"
        '
        'DuelTimeApplyButton
        '
        Me.DuelTimeApplyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DuelTimeApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DuelTimeApplyButton.Location = New System.Drawing.Point(200, 216)
        Me.DuelTimeApplyButton.Name = "DuelTimeApplyButton"
        Me.DuelTimeApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.DuelTimeApplyButton.TabIndex = 5
        Me.DuelTimeApplyButton.Text = "Aplicar..."
        Me.DuelTimeApplyButton.UseVisualStyleBackColor = False
        '
        'DuelTimeSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(287, 248)
        Me.Controls.Add(Me.DuelTimeApplyButton)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(303, 287)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(303, 287)
        Me.Name = "DuelTimeSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hora do Duelo - Configurações"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TxtBoxTotalPontosP1 As System.Windows.Forms.TextBox
    Friend WithEvents LblTotalPontosP1 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxNomeJogadorP1 As System.Windows.Forms.TextBox
    Friend WithEvents LblNomeJogadorP1 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxPersonagemP1 As System.Windows.Forms.ComboBox
    Friend WithEvents LblPersonagemP1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TxtBoxTotalPontosP2 As System.Windows.Forms.TextBox
    Friend WithEvents LblTotalPontosP2 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxNomeJogadorP2 As System.Windows.Forms.TextBox
    Friend WithEvents LblNomeJogadorP2 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxPersonagemP2 As System.Windows.Forms.ComboBox
    Friend WithEvents LblPersonagemP2 As System.Windows.Forms.Label
    Friend WithEvents DuelTimeApplyButton As System.Windows.Forms.Button
End Class
