<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuelLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DuelLog))
        Me.ListViewP1 = New System.Windows.Forms.ListView()
        Me.P1ActionColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.P1ProcessColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.P1LifePointsColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewP2 = New System.Windows.Forms.ListView()
        Me.P2ActionColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.P2ProcessColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.P2LifePointsColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProfilePicP2 = New System.Windows.Forms.PictureBox()
        Me.ProfilePicP1 = New System.Windows.Forms.PictureBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.LblP1Name = New System.Windows.Forms.TextBox()
        Me.LblP2Name = New System.Windows.Forms.TextBox()
        CType(Me.ProfilePicP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilePicP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListViewP1
        '
        Me.ListViewP1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.P1ActionColumn, Me.P1ProcessColumn, Me.P1LifePointsColumn})
        Me.ListViewP1.Location = New System.Drawing.Point(118, 12)
        Me.ListViewP1.Name = "ListViewP1"
        Me.ListViewP1.Size = New System.Drawing.Size(554, 200)
        Me.ListViewP1.TabIndex = 1
        Me.ListViewP1.UseCompatibleStateImageBehavior = False
        Me.ListViewP1.View = System.Windows.Forms.View.Details
        '
        'P1ActionColumn
        '
        Me.P1ActionColumn.Text = "Ação No."
        '
        'P1ProcessColumn
        '
        Me.P1ProcessColumn.Text = "Processo"
        Me.P1ProcessColumn.Width = 370
        '
        'P1LifePointsColumn
        '
        Me.P1LifePointsColumn.Text = "Pontos de Vida"
        Me.P1LifePointsColumn.Width = 100
        '
        'ListViewP2
        '
        Me.ListViewP2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.P2ActionColumn, Me.P2ProcessColumn, Me.P2LifePointsColumn})
        Me.ListViewP2.Location = New System.Drawing.Point(118, 218)
        Me.ListViewP2.Name = "ListViewP2"
        Me.ListViewP2.Size = New System.Drawing.Size(554, 200)
        Me.ListViewP2.TabIndex = 3
        Me.ListViewP2.UseCompatibleStateImageBehavior = False
        Me.ListViewP2.View = System.Windows.Forms.View.Details
        '
        'P2ActionColumn
        '
        Me.P2ActionColumn.Text = "Ação No."
        '
        'P2ProcessColumn
        '
        Me.P2ProcessColumn.Text = "Processo"
        Me.P2ProcessColumn.Width = 370
        '
        'P2LifePointsColumn
        '
        Me.P2LifePointsColumn.Text = "Pontos de Vida"
        Me.P2LifePointsColumn.Width = 100
        '
        'ProfilePicP2
        '
        Me.ProfilePicP2.Location = New System.Drawing.Point(12, 218)
        Me.ProfilePicP2.Name = "ProfilePicP2"
        Me.ProfilePicP2.Size = New System.Drawing.Size(100, 100)
        Me.ProfilePicP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProfilePicP2.TabIndex = 2
        Me.ProfilePicP2.TabStop = False
        '
        'ProfilePicP1
        '
        Me.ProfilePicP1.Location = New System.Drawing.Point(12, 12)
        Me.ProfilePicP1.Name = "ProfilePicP1"
        Me.ProfilePicP1.Size = New System.Drawing.Size(100, 100)
        Me.ProfilePicP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProfilePicP1.TabIndex = 0
        Me.ProfilePicP1.TabStop = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(597, 426)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 23)
        Me.BtnOk.TabIndex = 6
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = False
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
        Me.LblP1Name.Location = New System.Drawing.Point(12, 118)
        Me.LblP1Name.Name = "LblP1Name"
        Me.LblP1Name.ReadOnly = True
        Me.LblP1Name.ShortcutsEnabled = False
        Me.LblP1Name.Size = New System.Drawing.Size(100, 17)
        Me.LblP1Name.TabIndex = 30
        Me.LblP1Name.TabStop = False
        Me.LblP1Name.Text = "Jogador 1"
        Me.LblP1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.LblP2Name.Location = New System.Drawing.Point(12, 324)
        Me.LblP2Name.Name = "LblP2Name"
        Me.LblP2Name.ReadOnly = True
        Me.LblP2Name.ShortcutsEnabled = False
        Me.LblP2Name.Size = New System.Drawing.Size(100, 17)
        Me.LblP2Name.TabIndex = 31
        Me.LblP2Name.TabStop = False
        Me.LblP2Name.Text = "Jogador 2"
        Me.LblP2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DuelLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.LblP2Name)
        Me.Controls.Add(Me.LblP1Name)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.ListViewP2)
        Me.Controls.Add(Me.ProfilePicP2)
        Me.Controls.Add(Me.ListViewP1)
        Me.Controls.Add(Me.ProfilePicP1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "DuelLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log de Duelo"
        CType(Me.ProfilePicP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilePicP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProfilePicP1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListViewP1 As System.Windows.Forms.ListView
    Friend WithEvents ProfilePicP2 As System.Windows.Forms.PictureBox
    Friend WithEvents ListViewP2 As System.Windows.Forms.ListView
    Friend WithEvents P1ActionColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents P1ProcessColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents P2ActionColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents P2ProcessColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents P1LifePointsColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents P2LifePointsColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Public WithEvents LblP1Name As System.Windows.Forms.TextBox
    Public WithEvents LblP2Name As System.Windows.Forms.TextBox
End Class
