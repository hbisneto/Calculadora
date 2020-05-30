<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMD
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CMD))
        Me.ExeButton = New System.Windows.Forms.Button()
        Me.InputCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharJanelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExeButton
        '
        Me.ExeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ExeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExeButton.ForeColor = System.Drawing.Color.White
        Me.ExeButton.Location = New System.Drawing.Point(205, 126)
        Me.ExeButton.Name = "ExeButton"
        Me.ExeButton.Size = New System.Drawing.Size(75, 23)
        Me.ExeButton.TabIndex = 5
        Me.ExeButton.Text = "Executar..."
        Me.ExeButton.UseVisualStyleBackColor = False
        '
        'InputCode
        '
        Me.InputCode.BackColor = System.Drawing.Color.White
        Me.InputCode.ForeColor = System.Drawing.Color.Black
        Me.InputCode.Location = New System.Drawing.Point(12, 70)
        Me.InputCode.Name = "InputCode"
        Me.InputCode.Size = New System.Drawing.Size(460, 20)
        Me.InputCode.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(177, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Insira um comando válido:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FecharJanelaToolStripMenuItem, Me.EnterToolStripMenuItem})
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'FecharJanelaToolStripMenuItem
        '
        Me.FecharJanelaToolStripMenuItem.Name = "FecharJanelaToolStripMenuItem"
        Me.FecharJanelaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.FecharJanelaToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.FecharJanelaToolStripMenuItem.Text = "Fechar Janela..."
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLabel.ForeColor = System.Drawing.Color.Black
        Me.WarningLabel.Location = New System.Drawing.Point(9, 93)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(101, 13)
        Me.WarningLabel.TabIndex = 7
        Me.WarningLabel.Text = "@/:""Mensagem"""
        Me.WarningLabel.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'EnterToolStripMenuItem
        '
        Me.EnterToolStripMenuItem.Name = "EnterToolStripMenuItem"
        Me.EnterToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EnterToolStripMenuItem.Text = "Enter..."
        '
        'CMD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(484, 161)
        Me.Controls.Add(Me.WarningLabel)
        Me.Controls.Add(Me.ExeButton)
        Me.Controls.Add(Me.InputCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 200)
        Me.Name = "CMD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CMD"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExeButton As System.Windows.Forms.Button
    Friend WithEvents InputCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecharJanelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WarningLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents EnterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
