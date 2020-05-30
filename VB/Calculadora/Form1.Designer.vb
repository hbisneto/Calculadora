<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HistoryTextBox = New System.Windows.Forms.TextBox()
        Me.LblVisor = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreCalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcurarAtualiaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarCalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraDoDueloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirContadorDePontosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddComandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnMMenos = New System.Windows.Forms.Button()
        Me.BtnMMais = New System.Windows.Forms.Button()
        Me.BtnMMostra = New System.Windows.Forms.Button()
        Me.BtnMLimpa = New System.Windows.Forms.Button()
        Me.BtnBackSpace = New System.Windows.Forms.Button()
        Me.BtnCorrige = New System.Windows.Forms.Button()
        Me.BtnRaiz = New System.Windows.Forms.Button()
        Me.BtnDividePorVisor = New System.Windows.Forms.Button()
        Me.BtnPotencia = New System.Windows.Forms.Button()
        Me.BtnDivide = New System.Windows.Forms.Button()
        Me.BtnPorcent = New System.Windows.Forms.Button()
        Me.PlusAndMinusBtn = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnMultiplica = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.BtnSubtrai = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.BtnSoma = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.BtnIgual = New System.Windows.Forms.Button()
        Me.BtnPonto = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.KeyBoardPress = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.HistoryTextBox)
        Me.Panel2.Controls.Add(Me.LblVisor)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(6, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 75)
        Me.Panel2.TabIndex = 1
        '
        'HistoryTextBox
        '
        Me.HistoryTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.HistoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HistoryTextBox.Enabled = False
        Me.HistoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.HistoryTextBox.HideSelection = False
        Me.HistoryTextBox.Location = New System.Drawing.Point(3, 2)
        Me.HistoryTextBox.Multiline = True
        Me.HistoryTextBox.Name = "HistoryTextBox"
        Me.HistoryTextBox.ReadOnly = True
        Me.HistoryTextBox.Size = New System.Drawing.Size(243, 12)
        Me.HistoryTextBox.TabIndex = 1
        Me.HistoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HistoryTextBox.WordWrap = False
        '
        'LblVisor
        '
        Me.LblVisor.AutoSize = True
        Me.LblVisor.BackColor = System.Drawing.SystemColors.Control
        Me.LblVisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LblVisor.ForeColor = System.Drawing.Color.Black
        Me.LblVisor.Location = New System.Drawing.Point(3, 10)
        Me.LblVisor.Name = "LblVisor"
        Me.LblVisor.Size = New System.Drawing.Size(257, 54)
        Me.LblVisor.TabIndex = 0
        Me.LblVisor.Text = "123456789"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.HoraDoDueloToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreCalculadoraToolStripMenuItem, Me.ProcurarAtualiaçõesToolStripMenuItem, Me.EncerrarCalculadoraToolStripMenuItem})
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'SobreCalculadoraToolStripMenuItem
        '
        Me.SobreCalculadoraToolStripMenuItem.Name = "SobreCalculadoraToolStripMenuItem"
        Me.SobreCalculadoraToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.SobreCalculadoraToolStripMenuItem.Text = "Sobre Calculadora"
        '
        'ProcurarAtualiaçõesToolStripMenuItem
        '
        Me.ProcurarAtualiaçõesToolStripMenuItem.Name = "ProcurarAtualiaçõesToolStripMenuItem"
        Me.ProcurarAtualiaçõesToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ProcurarAtualiaçõesToolStripMenuItem.Text = "Procurar Atualiações..."
        '
        'EncerrarCalculadoraToolStripMenuItem
        '
        Me.EncerrarCalculadoraToolStripMenuItem.Name = "EncerrarCalculadoraToolStripMenuItem"
        Me.EncerrarCalculadoraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.EncerrarCalculadoraToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.EncerrarCalculadoraToolStripMenuItem.Text = "Encerrar Calculadora"
        '
        'HoraDoDueloToolStripMenuItem
        '
        Me.HoraDoDueloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirContadorDePontosToolStripMenuItem, Me.AddComandoToolStripMenuItem})
        Me.HoraDoDueloToolStripMenuItem.Name = "HoraDoDueloToolStripMenuItem"
        Me.HoraDoDueloToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.HoraDoDueloToolStripMenuItem.Text = "Hora do Duelo!"
        Me.HoraDoDueloToolStripMenuItem.Visible = False
        '
        'AbrirContadorDePontosToolStripMenuItem
        '
        Me.AbrirContadorDePontosToolStripMenuItem.Name = "AbrirContadorDePontosToolStripMenuItem"
        Me.AbrirContadorDePontosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AbrirContadorDePontosToolStripMenuItem.Text = "Abrir Contador de Pontos"
        '
        'AddComandoToolStripMenuItem
        '
        Me.AddComandoToolStripMenuItem.Name = "AddComandoToolStripMenuItem"
        Me.AddComandoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.AddComandoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AddComandoToolStripMenuItem.Text = "Add Comando..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnMMenos)
        Me.Panel1.Controls.Add(Me.BtnMMais)
        Me.Panel1.Controls.Add(Me.BtnMMostra)
        Me.Panel1.Controls.Add(Me.BtnMLimpa)
        Me.Panel1.Controls.Add(Me.BtnBackSpace)
        Me.Panel1.Controls.Add(Me.BtnCorrige)
        Me.Panel1.Controls.Add(Me.BtnRaiz)
        Me.Panel1.Controls.Add(Me.BtnDividePorVisor)
        Me.Panel1.Controls.Add(Me.BtnPotencia)
        Me.Panel1.Controls.Add(Me.BtnDivide)
        Me.Panel1.Controls.Add(Me.BtnPorcent)
        Me.Panel1.Controls.Add(Me.PlusAndMinusBtn)
        Me.Panel1.Controls.Add(Me.BtnLimpar)
        Me.Panel1.Controls.Add(Me.BtnMultiplica)
        Me.Panel1.Controls.Add(Me.Btn9)
        Me.Panel1.Controls.Add(Me.Btn8)
        Me.Panel1.Controls.Add(Me.Btn7)
        Me.Panel1.Controls.Add(Me.BtnSubtrai)
        Me.Panel1.Controls.Add(Me.Btn6)
        Me.Panel1.Controls.Add(Me.Btn5)
        Me.Panel1.Controls.Add(Me.Btn4)
        Me.Panel1.Controls.Add(Me.BtnSoma)
        Me.Panel1.Controls.Add(Me.Btn3)
        Me.Panel1.Controls.Add(Me.Btn2)
        Me.Panel1.Controls.Add(Me.Btn1)
        Me.Panel1.Controls.Add(Me.BtnIgual)
        Me.Panel1.Controls.Add(Me.BtnPonto)
        Me.Panel1.Controls.Add(Me.Btn0)
        Me.Panel1.Location = New System.Drawing.Point(12, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 332)
        Me.Panel1.TabIndex = 2
        '
        'BtnMMenos
        '
        Me.BtnMMenos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnMMenos.BackColor = System.Drawing.SystemColors.Control
        Me.BtnMMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnMMenos.ForeColor = System.Drawing.Color.Black
        Me.BtnMMenos.Location = New System.Drawing.Point(198, 13)
        Me.BtnMMenos.Name = "BtnMMenos"
        Me.BtnMMenos.Size = New System.Drawing.Size(59, 40)
        Me.BtnMMenos.TabIndex = 30
        Me.BtnMMenos.Text = "M-"
        Me.BtnMMenos.UseVisualStyleBackColor = False
        '
        'BtnMMais
        '
        Me.BtnMMais.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnMMais.BackColor = System.Drawing.SystemColors.Control
        Me.BtnMMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMMais.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnMMais.ForeColor = System.Drawing.Color.Black
        Me.BtnMMais.Location = New System.Drawing.Point(133, 13)
        Me.BtnMMais.Name = "BtnMMais"
        Me.BtnMMais.Size = New System.Drawing.Size(59, 40)
        Me.BtnMMais.TabIndex = 29
        Me.BtnMMais.Text = "M+"
        Me.BtnMMais.UseVisualStyleBackColor = False
        '
        'BtnMMostra
        '
        Me.BtnMMostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnMMostra.BackColor = System.Drawing.SystemColors.Control
        Me.BtnMMostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMMostra.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnMMostra.ForeColor = System.Drawing.Color.Black
        Me.BtnMMostra.Location = New System.Drawing.Point(68, 13)
        Me.BtnMMostra.Name = "BtnMMostra"
        Me.BtnMMostra.Size = New System.Drawing.Size(59, 40)
        Me.BtnMMostra.TabIndex = 28
        Me.BtnMMostra.Text = "MR"
        Me.BtnMMostra.UseVisualStyleBackColor = False
        '
        'BtnMLimpa
        '
        Me.BtnMLimpa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnMLimpa.BackColor = System.Drawing.SystemColors.Control
        Me.BtnMLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMLimpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnMLimpa.ForeColor = System.Drawing.Color.Black
        Me.BtnMLimpa.Location = New System.Drawing.Point(3, 13)
        Me.BtnMLimpa.Name = "BtnMLimpa"
        Me.BtnMLimpa.Size = New System.Drawing.Size(59, 40)
        Me.BtnMLimpa.TabIndex = 27
        Me.BtnMLimpa.Text = "MC"
        Me.BtnMLimpa.UseVisualStyleBackColor = False
        '
        'BtnBackSpace
        '
        Me.BtnBackSpace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnBackSpace.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackSpace.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBackSpace.ForeColor = System.Drawing.Color.Black
        Me.BtnBackSpace.Location = New System.Drawing.Point(198, 59)
        Me.BtnBackSpace.Name = "BtnBackSpace"
        Me.BtnBackSpace.Size = New System.Drawing.Size(59, 40)
        Me.BtnBackSpace.TabIndex = 26
        Me.BtnBackSpace.Text = "⌫"
        Me.BtnBackSpace.UseVisualStyleBackColor = False
        '
        'BtnCorrige
        '
        Me.BtnCorrige.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCorrige.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCorrige.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCorrige.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnCorrige.ForeColor = System.Drawing.Color.Black
        Me.BtnCorrige.Location = New System.Drawing.Point(68, 59)
        Me.BtnCorrige.Name = "BtnCorrige"
        Me.BtnCorrige.Size = New System.Drawing.Size(59, 40)
        Me.BtnCorrige.TabIndex = 25
        Me.BtnCorrige.Text = "CE"
        Me.BtnCorrige.UseVisualStyleBackColor = False
        '
        'BtnRaiz
        '
        Me.BtnRaiz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRaiz.BackColor = System.Drawing.SystemColors.Control
        Me.BtnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnRaiz.ForeColor = System.Drawing.Color.Black
        Me.BtnRaiz.Location = New System.Drawing.Point(133, 105)
        Me.BtnRaiz.Name = "BtnRaiz"
        Me.BtnRaiz.Size = New System.Drawing.Size(59, 40)
        Me.BtnRaiz.TabIndex = 24
        Me.BtnRaiz.Text = "²√×"
        Me.BtnRaiz.UseVisualStyleBackColor = False
        '
        'BtnDividePorVisor
        '
        Me.BtnDividePorVisor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDividePorVisor.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDividePorVisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDividePorVisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnDividePorVisor.ForeColor = System.Drawing.Color.Black
        Me.BtnDividePorVisor.Location = New System.Drawing.Point(3, 105)
        Me.BtnDividePorVisor.Name = "BtnDividePorVisor"
        Me.BtnDividePorVisor.Size = New System.Drawing.Size(59, 40)
        Me.BtnDividePorVisor.TabIndex = 23
        Me.BtnDividePorVisor.Text = "¹/×"
        Me.BtnDividePorVisor.UseVisualStyleBackColor = False
        '
        'BtnPotencia
        '
        Me.BtnPotencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPotencia.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPotencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnPotencia.ForeColor = System.Drawing.Color.Black
        Me.BtnPotencia.Location = New System.Drawing.Point(68, 105)
        Me.BtnPotencia.Name = "BtnPotencia"
        Me.BtnPotencia.Size = New System.Drawing.Size(59, 40)
        Me.BtnPotencia.TabIndex = 22
        Me.BtnPotencia.Text = "×²"
        Me.BtnPotencia.UseVisualStyleBackColor = False
        '
        'BtnDivide
        '
        Me.BtnDivide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDivide.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnDivide.ForeColor = System.Drawing.Color.Black
        Me.BtnDivide.Location = New System.Drawing.Point(198, 105)
        Me.BtnDivide.Name = "BtnDivide"
        Me.BtnDivide.Size = New System.Drawing.Size(59, 40)
        Me.BtnDivide.TabIndex = 21
        Me.BtnDivide.Text = "÷"
        Me.BtnDivide.UseVisualStyleBackColor = False
        '
        'BtnPorcent
        '
        Me.BtnPorcent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPorcent.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPorcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPorcent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnPorcent.ForeColor = System.Drawing.Color.Black
        Me.BtnPorcent.Location = New System.Drawing.Point(3, 59)
        Me.BtnPorcent.Name = "BtnPorcent"
        Me.BtnPorcent.Size = New System.Drawing.Size(59, 40)
        Me.BtnPorcent.TabIndex = 20
        Me.BtnPorcent.Text = "%"
        Me.BtnPorcent.UseVisualStyleBackColor = False
        '
        'PlusAndMinusBtn
        '
        Me.PlusAndMinusBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PlusAndMinusBtn.BackColor = System.Drawing.SystemColors.Control
        Me.PlusAndMinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlusAndMinusBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.PlusAndMinusBtn.ForeColor = System.Drawing.Color.Black
        Me.PlusAndMinusBtn.Location = New System.Drawing.Point(3, 289)
        Me.PlusAndMinusBtn.Name = "PlusAndMinusBtn"
        Me.PlusAndMinusBtn.Size = New System.Drawing.Size(59, 40)
        Me.PlusAndMinusBtn.TabIndex = 19
        Me.PlusAndMinusBtn.Text = "+/-"
        Me.PlusAndMinusBtn.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnLimpar.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpar.Location = New System.Drawing.Point(133, 59)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(59, 40)
        Me.BtnLimpar.TabIndex = 18
        Me.BtnLimpar.Text = "C"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnMultiplica
        '
        Me.BtnMultiplica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnMultiplica.BackColor = System.Drawing.SystemColors.Control
        Me.BtnMultiplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMultiplica.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnMultiplica.ForeColor = System.Drawing.Color.Black
        Me.BtnMultiplica.Location = New System.Drawing.Point(198, 151)
        Me.BtnMultiplica.Name = "BtnMultiplica"
        Me.BtnMultiplica.Size = New System.Drawing.Size(59, 40)
        Me.BtnMultiplica.TabIndex = 17
        Me.BtnMultiplica.Text = "×"
        Me.BtnMultiplica.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn9.BackColor = System.Drawing.SystemColors.Control
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn9.ForeColor = System.Drawing.Color.Black
        Me.Btn9.Location = New System.Drawing.Point(133, 151)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(59, 40)
        Me.Btn9.TabIndex = 16
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn8.BackColor = System.Drawing.SystemColors.Control
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn8.ForeColor = System.Drawing.Color.Black
        Me.Btn8.Location = New System.Drawing.Point(68, 151)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(59, 40)
        Me.Btn8.TabIndex = 15
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'Btn7
        '
        Me.Btn7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn7.BackColor = System.Drawing.SystemColors.Control
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn7.ForeColor = System.Drawing.Color.Black
        Me.Btn7.Location = New System.Drawing.Point(3, 151)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(59, 40)
        Me.Btn7.TabIndex = 14
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'BtnSubtrai
        '
        Me.BtnSubtrai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSubtrai.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSubtrai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubtrai.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnSubtrai.ForeColor = System.Drawing.Color.Black
        Me.BtnSubtrai.Location = New System.Drawing.Point(198, 197)
        Me.BtnSubtrai.Name = "BtnSubtrai"
        Me.BtnSubtrai.Size = New System.Drawing.Size(59, 40)
        Me.BtnSubtrai.TabIndex = 13
        Me.BtnSubtrai.Text = "-"
        Me.BtnSubtrai.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn6.BackColor = System.Drawing.SystemColors.Control
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn6.ForeColor = System.Drawing.Color.Black
        Me.Btn6.Location = New System.Drawing.Point(133, 197)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(59, 40)
        Me.Btn6.TabIndex = 12
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn5.BackColor = System.Drawing.SystemColors.Control
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn5.ForeColor = System.Drawing.Color.Black
        Me.Btn5.Location = New System.Drawing.Point(68, 197)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(59, 40)
        Me.Btn5.TabIndex = 11
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn4.BackColor = System.Drawing.SystemColors.Control
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn4.ForeColor = System.Drawing.Color.Black
        Me.Btn4.Location = New System.Drawing.Point(3, 197)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(59, 40)
        Me.Btn4.TabIndex = 10
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'BtnSoma
        '
        Me.BtnSoma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSoma.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnSoma.ForeColor = System.Drawing.Color.Black
        Me.BtnSoma.Location = New System.Drawing.Point(198, 243)
        Me.BtnSoma.Name = "BtnSoma"
        Me.BtnSoma.Size = New System.Drawing.Size(59, 40)
        Me.BtnSoma.TabIndex = 9
        Me.BtnSoma.Text = "+"
        Me.BtnSoma.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn3.BackColor = System.Drawing.SystemColors.Control
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn3.ForeColor = System.Drawing.Color.Black
        Me.Btn3.Location = New System.Drawing.Point(133, 243)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(59, 40)
        Me.Btn3.TabIndex = 8
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn2.BackColor = System.Drawing.SystemColors.Control
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn2.ForeColor = System.Drawing.Color.Black
        Me.Btn2.Location = New System.Drawing.Point(68, 243)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(59, 40)
        Me.Btn2.TabIndex = 7
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn1.BackColor = System.Drawing.SystemColors.Control
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn1.ForeColor = System.Drawing.Color.Black
        Me.Btn1.Location = New System.Drawing.Point(3, 243)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(59, 40)
        Me.Btn1.TabIndex = 6
        Me.Btn1.TabStop = False
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'BtnIgual
        '
        Me.BtnIgual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnIgual.BackColor = System.Drawing.SystemColors.Control
        Me.BtnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnIgual.ForeColor = System.Drawing.Color.Black
        Me.BtnIgual.Location = New System.Drawing.Point(198, 289)
        Me.BtnIgual.Name = "BtnIgual"
        Me.BtnIgual.Size = New System.Drawing.Size(59, 40)
        Me.BtnIgual.TabIndex = 5
        Me.BtnIgual.Text = "="
        Me.BtnIgual.UseVisualStyleBackColor = False
        '
        'BtnPonto
        '
        Me.BtnPonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPonto.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BtnPonto.ForeColor = System.Drawing.Color.Black
        Me.BtnPonto.Location = New System.Drawing.Point(133, 289)
        Me.BtnPonto.Name = "BtnPonto"
        Me.BtnPonto.Size = New System.Drawing.Size(59, 40)
        Me.BtnPonto.TabIndex = 4
        Me.BtnPonto.Text = "."
        Me.BtnPonto.UseVisualStyleBackColor = False
        '
        'Btn0
        '
        Me.Btn0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn0.BackColor = System.Drawing.SystemColors.Control
        Me.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn0.ForeColor = System.Drawing.Color.Black
        Me.Btn0.Location = New System.Drawing.Point(68, 289)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(59, 40)
        Me.Btn0.TabIndex = 3
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = False
        '
        'KeyBoardPress
        '
        Me.KeyBoardPress.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(284, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 516)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 516)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreCalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnDivide As System.Windows.Forms.Button
    Friend WithEvents BtnPorcent As System.Windows.Forms.Button
    Friend WithEvents PlusAndMinusBtn As System.Windows.Forms.Button
    Friend WithEvents BtnLimpar As System.Windows.Forms.Button
    Friend WithEvents BtnMultiplica As System.Windows.Forms.Button
    Friend WithEvents Btn9 As System.Windows.Forms.Button
    Friend WithEvents Btn8 As System.Windows.Forms.Button
    Friend WithEvents Btn7 As System.Windows.Forms.Button
    Friend WithEvents BtnSubtrai As System.Windows.Forms.Button
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents Btn5 As System.Windows.Forms.Button
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents BtnSoma As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents BtnIgual As System.Windows.Forms.Button
    Friend WithEvents BtnPonto As System.Windows.Forms.Button
    Friend WithEvents Btn0 As System.Windows.Forms.Button
    Friend WithEvents LblVisor As System.Windows.Forms.Label
    Friend WithEvents HoraDoDueloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirContadorDePontosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProcurarAtualiaçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncerrarCalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddComandoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeyBoardPress As System.Windows.Forms.Timer
    Public WithEvents HistoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BtnMMenos As System.Windows.Forms.Button
    Friend WithEvents BtnMMais As System.Windows.Forms.Button
    Friend WithEvents BtnMMostra As System.Windows.Forms.Button
    Friend WithEvents BtnMLimpa As System.Windows.Forms.Button
    Friend WithEvents BtnBackSpace As System.Windows.Forms.Button
    Friend WithEvents BtnCorrige As System.Windows.Forms.Button
    Friend WithEvents BtnRaiz As System.Windows.Forms.Button
    Friend WithEvents BtnDividePorVisor As System.Windows.Forms.Button
    Friend WithEvents BtnPotencia As System.Windows.Forms.Button

End Class
