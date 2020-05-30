<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuelTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DuelTime))
        Me.BtnAddLP1 = New System.Windows.Forms.Button()
        Me.BtnSubLP1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblP1Name = New System.Windows.Forms.TextBox()
        Me.TxtBoxPointsP1 = New System.Windows.Forms.TextBox()
        Me.LblPointsP1 = New System.Windows.Forms.Label()
        Me.LblP1Life = New System.Windows.Forms.Label()
        Me.SeparatorLabel = New System.Windows.Forms.Label()
        Me.LblP2Life = New System.Windows.Forms.Label()
        Me.LblPointsP2 = New System.Windows.Forms.Label()
        Me.TxtBoxPointsP2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblP2Name = New System.Windows.Forms.TextBox()
        Me.BtnSubLP2 = New System.Windows.Forms.Button()
        Me.BtnAddLP2 = New System.Windows.Forms.Button()
        Me.ProfilePicP2 = New System.Windows.Forms.PictureBox()
        Me.ProfilePicP1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HoraDoDueloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarDueloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogDeDueloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ProfilePicP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilePicP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAddLP1
        '
        Me.BtnAddLP1.BackColor = System.Drawing.Color.White
        Me.BtnAddLP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddLP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnAddLP1.ForeColor = System.Drawing.Color.Black
        Me.BtnAddLP1.Location = New System.Drawing.Point(248, 137)
        Me.BtnAddLP1.Name = "BtnAddLP1"
        Me.BtnAddLP1.Size = New System.Drawing.Size(59, 45)
        Me.BtnAddLP1.TabIndex = 2
        Me.BtnAddLP1.Text = "+"
        Me.BtnAddLP1.UseVisualStyleBackColor = False
        '
        'BtnSubLP1
        '
        Me.BtnSubLP1.BackColor = System.Drawing.Color.White
        Me.BtnSubLP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubLP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnSubLP1.ForeColor = System.Drawing.Color.Black
        Me.BtnSubLP1.Location = New System.Drawing.Point(313, 137)
        Me.BtnSubLP1.Name = "BtnSubLP1"
        Me.BtnSubLP1.Size = New System.Drawing.Size(59, 45)
        Me.BtnSubLP1.TabIndex = 3
        Me.BtnSubLP1.Text = "-"
        Me.BtnSubLP1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblP1Name)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(128, 21)
        Me.Panel1.TabIndex = 7
        '
        'LblP1Name
        '
        Me.LblP1Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblP1Name.BackColor = System.Drawing.SystemColors.Control
        Me.LblP1Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblP1Name.CausesValidation = False
        Me.LblP1Name.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LblP1Name.ForeColor = System.Drawing.Color.Black
        Me.LblP1Name.Location = New System.Drawing.Point(3, 2)
        Me.LblP1Name.Name = "LblP1Name"
        Me.LblP1Name.ReadOnly = True
        Me.LblP1Name.ShortcutsEnabled = False
        Me.LblP1Name.Size = New System.Drawing.Size(122, 17)
        Me.LblP1Name.TabIndex = 29
        Me.LblP1Name.TabStop = False
        Me.LblP1Name.Text = "Jogador 1"
        Me.LblP1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBoxPointsP1
        '
        Me.TxtBoxPointsP1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBoxPointsP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBoxPointsP1.ForeColor = System.Drawing.Color.Black
        Me.TxtBoxPointsP1.Location = New System.Drawing.Point(246, 111)
        Me.TxtBoxPointsP1.Name = "TxtBoxPointsP1"
        Me.TxtBoxPointsP1.Size = New System.Drawing.Size(126, 20)
        Me.TxtBoxPointsP1.TabIndex = 8
        '
        'LblPointsP1
        '
        Me.LblPointsP1.AutoSize = True
        Me.LblPointsP1.ForeColor = System.Drawing.Color.Black
        Me.LblPointsP1.Location = New System.Drawing.Point(146, 114)
        Me.LblPointsP1.Name = "LblPointsP1"
        Me.LblPointsP1.Size = New System.Drawing.Size(94, 13)
        Me.LblPointsP1.TabIndex = 10
        Me.LblPointsP1.Text = "Pontos Adicionais:"
        '
        'LblP1Life
        '
        Me.LblP1Life.AutoSize = True
        Me.LblP1Life.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LblP1Life.ForeColor = System.Drawing.Color.Black
        Me.LblP1Life.Location = New System.Drawing.Point(146, 54)
        Me.LblP1Life.Name = "LblP1Life"
        Me.LblP1Life.Size = New System.Drawing.Size(127, 54)
        Me.LblP1Life.TabIndex = 13
        Me.LblP1Life.Text = "8000"
        '
        'SeparatorLabel
        '
        Me.SeparatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SeparatorLabel.Location = New System.Drawing.Point(15, 279)
        Me.SeparatorLabel.Name = "SeparatorLabel"
        Me.SeparatorLabel.Size = New System.Drawing.Size(350, 2)
        Me.SeparatorLabel.TabIndex = 23
        Me.SeparatorLabel.Text = "Label1"
        '
        'LblP2Life
        '
        Me.LblP2Life.AutoSize = True
        Me.LblP2Life.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LblP2Life.ForeColor = System.Drawing.Color.Black
        Me.LblP2Life.Location = New System.Drawing.Point(146, 401)
        Me.LblP2Life.Name = "LblP2Life"
        Me.LblP2Life.Size = New System.Drawing.Size(127, 54)
        Me.LblP2Life.TabIndex = 30
        Me.LblP2Life.Text = "8000"
        '
        'LblPointsP2
        '
        Me.LblPointsP2.AutoSize = True
        Me.LblPointsP2.ForeColor = System.Drawing.Color.Black
        Me.LblPointsP2.Location = New System.Drawing.Point(146, 461)
        Me.LblPointsP2.Name = "LblPointsP2"
        Me.LblPointsP2.Size = New System.Drawing.Size(94, 13)
        Me.LblPointsP2.TabIndex = 29
        Me.LblPointsP2.Text = "Pontos Adicionais:"
        '
        'TxtBoxPointsP2
        '
        Me.TxtBoxPointsP2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBoxPointsP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBoxPointsP2.ForeColor = System.Drawing.Color.Black
        Me.TxtBoxPointsP2.Location = New System.Drawing.Point(246, 458)
        Me.TxtBoxPointsP2.Name = "TxtBoxPointsP2"
        Me.TxtBoxPointsP2.Size = New System.Drawing.Size(126, 20)
        Me.TxtBoxPointsP2.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblP2Name)
        Me.Panel2.Location = New System.Drawing.Point(12, 374)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(128, 21)
        Me.Panel2.TabIndex = 27
        '
        'LblP2Name
        '
        Me.LblP2Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblP2Name.BackColor = System.Drawing.SystemColors.Control
        Me.LblP2Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblP2Name.CausesValidation = False
        Me.LblP2Name.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LblP2Name.ForeColor = System.Drawing.Color.Black
        Me.LblP2Name.Location = New System.Drawing.Point(3, 2)
        Me.LblP2Name.Name = "LblP2Name"
        Me.LblP2Name.ReadOnly = True
        Me.LblP2Name.ShortcutsEnabled = False
        Me.LblP2Name.Size = New System.Drawing.Size(122, 17)
        Me.LblP2Name.TabIndex = 30
        Me.LblP2Name.TabStop = False
        Me.LblP2Name.Text = "Jogador 2"
        Me.LblP2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSubLP2
        '
        Me.BtnSubLP2.BackColor = System.Drawing.Color.White
        Me.BtnSubLP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubLP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnSubLP2.ForeColor = System.Drawing.Color.Black
        Me.BtnSubLP2.Location = New System.Drawing.Point(313, 484)
        Me.BtnSubLP2.Name = "BtnSubLP2"
        Me.BtnSubLP2.Size = New System.Drawing.Size(59, 45)
        Me.BtnSubLP2.TabIndex = 25
        Me.BtnSubLP2.Text = "-"
        Me.BtnSubLP2.UseVisualStyleBackColor = False
        '
        'BtnAddLP2
        '
        Me.BtnAddLP2.BackColor = System.Drawing.Color.White
        Me.BtnAddLP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddLP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnAddLP2.ForeColor = System.Drawing.Color.Black
        Me.BtnAddLP2.Location = New System.Drawing.Point(248, 484)
        Me.BtnAddLP2.Name = "BtnAddLP2"
        Me.BtnAddLP2.Size = New System.Drawing.Size(59, 45)
        Me.BtnAddLP2.TabIndex = 24
        Me.BtnAddLP2.Text = "+"
        Me.BtnAddLP2.UseVisualStyleBackColor = False
        '
        'ProfilePicP2
        '
        Me.ProfilePicP2.BackColor = System.Drawing.SystemColors.Control
        Me.ProfilePicP2.Location = New System.Drawing.Point(12, 401)
        Me.ProfilePicP2.Name = "ProfilePicP2"
        Me.ProfilePicP2.Size = New System.Drawing.Size(128, 128)
        Me.ProfilePicP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProfilePicP2.TabIndex = 26
        Me.ProfilePicP2.TabStop = False
        '
        'ProfilePicP1
        '
        Me.ProfilePicP1.BackColor = System.Drawing.SystemColors.Control
        Me.ProfilePicP1.Location = New System.Drawing.Point(12, 54)
        Me.ProfilePicP1.Name = "ProfilePicP1"
        Me.ProfilePicP1.Size = New System.Drawing.Size(128, 128)
        Me.ProfilePicP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProfilePicP1.TabIndex = 6
        Me.ProfilePicP1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HoraDoDueloToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HoraDoDueloToolStripMenuItem
        '
        Me.HoraDoDueloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurarDueloToolStripMenuItem, Me.LogDeDueloToolStripMenuItem})
        Me.HoraDoDueloToolStripMenuItem.Name = "HoraDoDueloToolStripMenuItem"
        Me.HoraDoDueloToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.HoraDoDueloToolStripMenuItem.Text = "Hora do Duelo"
        '
        'ConfigurarDueloToolStripMenuItem
        '
        Me.ConfigurarDueloToolStripMenuItem.Name = "ConfigurarDueloToolStripMenuItem"
        Me.ConfigurarDueloToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ConfigurarDueloToolStripMenuItem.Text = "Configurar Duelo..."
        '
        'LogDeDueloToolStripMenuItem
        '
        Me.LogDeDueloToolStripMenuItem.Name = "LogDeDueloToolStripMenuItem"
        Me.LogDeDueloToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogDeDueloToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.LogDeDueloToolStripMenuItem.Text = "Abrir Log de Duelo"
        '
        'DuelTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(384, 541)
        Me.Controls.Add(Me.LblP2Life)
        Me.Controls.Add(Me.LblPointsP2)
        Me.Controls.Add(Me.TxtBoxPointsP2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ProfilePicP2)
        Me.Controls.Add(Me.BtnSubLP2)
        Me.Controls.Add(Me.BtnAddLP2)
        Me.Controls.Add(Me.SeparatorLabel)
        Me.Controls.Add(Me.LblP1Life)
        Me.Controls.Add(Me.LblPointsP1)
        Me.Controls.Add(Me.TxtBoxPointsP1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProfilePicP1)
        Me.Controls.Add(Me.BtnSubLP1)
        Me.Controls.Add(Me.BtnAddLP1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 580)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 580)
        Me.Name = "DuelTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hora do Duelo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ProfilePicP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilePicP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddLP1 As System.Windows.Forms.Button
    Friend WithEvents BtnSubLP1 As System.Windows.Forms.Button
    Friend WithEvents ProfilePicP1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtBoxPointsP1 As System.Windows.Forms.TextBox
    Friend WithEvents LblPointsP1 As System.Windows.Forms.Label
    Friend WithEvents LblP1Life As System.Windows.Forms.Label
    Friend WithEvents SeparatorLabel As System.Windows.Forms.Label
    Friend WithEvents LblP2Life As System.Windows.Forms.Label
    Friend WithEvents LblPointsP2 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxPointsP2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProfilePicP2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSubLP2 As System.Windows.Forms.Button
    Friend WithEvents BtnAddLP2 As System.Windows.Forms.Button
    Public WithEvents LblP1Name As System.Windows.Forms.TextBox
    Public WithEvents LblP2Name As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HoraDoDueloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogDeDueloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurarDueloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
