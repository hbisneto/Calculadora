<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutApp))
        Me.Version = New System.Windows.Forms.TextBox()
        Me.AppName = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FecharJanelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copyright = New System.Windows.Forms.TextBox()
        Me.ProjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.CodeNamePic = New System.Windows.Forms.PictureBox()
        Me.AppIcon = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CodeNamePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Version
        '
        Me.Version.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Version.BackColor = System.Drawing.Color.White
        Me.Version.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Version.CausesValidation = False
        Me.Version.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Version.Location = New System.Drawing.Point(12, 177)
        Me.Version.Name = "Version"
        Me.Version.ReadOnly = True
        Me.Version.ShortcutsEnabled = False
        Me.Version.Size = New System.Drawing.Size(260, 17)
        Me.Version.TabIndex = 33
        Me.Version.TabStop = False
        Me.Version.Text = "My.Application.Info.Version.ToString"
        Me.Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AppName
        '
        Me.AppName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppName.BackColor = System.Drawing.Color.White
        Me.AppName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AppName.CausesValidation = False
        Me.AppName.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.AppName.Location = New System.Drawing.Point(12, 146)
        Me.AppName.Name = "AppName"
        Me.AppName.ReadOnly = True
        Me.AppName.ShortcutsEnabled = False
        Me.AppName.Size = New System.Drawing.Size(260, 25)
        Me.AppName.TabIndex = 32
        Me.AppName.TabStop = False
        Me.AppName.Text = "My.Computer.Info.AssemblyName"
        Me.AppName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FecharJanelaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'FecharJanelaToolStripMenuItem
        '
        Me.FecharJanelaToolStripMenuItem.Name = "FecharJanelaToolStripMenuItem"
        Me.FecharJanelaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.FecharJanelaToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.FecharJanelaToolStripMenuItem.Text = "Fechar Janela..."
        '
        'Copyright
        '
        Me.Copyright.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Copyright.BackColor = System.Drawing.Color.White
        Me.Copyright.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Copyright.CausesValidation = False
        Me.Copyright.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Copyright.Location = New System.Drawing.Point(12, 200)
        Me.Copyright.Multiline = True
        Me.Copyright.Name = "Copyright"
        Me.Copyright.ReadOnly = True
        Me.Copyright.ShortcutsEnabled = False
        Me.Copyright.Size = New System.Drawing.Size(260, 34)
        Me.Copyright.TabIndex = 34
        Me.Copyright.TabStop = False
        Me.Copyright.Text = "My.Application.Info.Copyright"
        Me.Copyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProjectNameTextBox.BackColor = System.Drawing.Color.White
        Me.ProjectNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProjectNameTextBox.CausesValidation = False
        Me.ProjectNameTextBox.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ProjectNameTextBox.Location = New System.Drawing.Point(12, 240)
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.ReadOnly = True
        Me.ProjectNameTextBox.ShortcutsEnabled = False
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(260, 17)
        Me.ProjectNameTextBox.TabIndex = 37
        Me.ProjectNameTextBox.TabStop = False
        Me.ProjectNameTextBox.Text = "My.Application.Info.Version.ToString"
        '
        'CodeNamePic
        '
        Me.CodeNamePic.Location = New System.Drawing.Point(222, 90)
        Me.CodeNamePic.Name = "CodeNamePic"
        Me.CodeNamePic.Size = New System.Drawing.Size(50, 50)
        Me.CodeNamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CodeNamePic.TabIndex = 36
        Me.CodeNamePic.TabStop = False
        '
        'AppIcon
        '
        Me.AppIcon.Image = CType(resources.GetObject("AppIcon.Image"), System.Drawing.Image)
        Me.AppIcon.Location = New System.Drawing.Point(12, 12)
        Me.AppIcon.Name = "AppIcon"
        Me.AppIcon.Size = New System.Drawing.Size(260, 128)
        Me.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppIcon.TabIndex = 31
        Me.AppIcon.TabStop = False
        '
        'AboutApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ProjectNameTextBox)
        Me.Controls.Add(Me.CodeNamePic)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.AppName)
        Me.Controls.Add(Me.AppIcon)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "AboutApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sobre Calculadora"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CodeNamePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Version As System.Windows.Forms.TextBox
    Public WithEvents AppName As System.Windows.Forms.TextBox
    Friend WithEvents AppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FecharJanelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeNamePic As System.Windows.Forms.PictureBox
    Public WithEvents Copyright As System.Windows.Forms.TextBox
    Public WithEvents ProjectNameTextBox As System.Windows.Forms.TextBox
End Class
