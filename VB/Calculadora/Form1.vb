Imports System.Net

Public Class Form1

    Dim MyTheme As MyTheme = New MyTheme()
    Dim MySystem As MySystem = New MySystem()

    Public ChangeEasterEgg As String = MySystem.AppEasterEgg
    Public ServerVersion As String

    Public visor As String = "0"
    Public operacaoAtual As Char
    Public operacaoUso As Boolean
    Public operacaoUso1 As Boolean
    Public operacaoUso2 As Boolean
    Public pontoUso As Boolean = False
    Public igualClique As Boolean
    Public num1 As Double
    Public num2 As Double
    Public Result As Double
    Public memoResult As Double
    Public count As Integer = 0
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        ' OPERATIONS
        If e.KeyCode = Keys.Add Then
            BtnSoma.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.Subtract Then
            BtnSubtrai.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.Multiply Then
            BtnMultiplica.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.Divide Then
            BtnDivide.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.Enter Then
            BtnIgual.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        ' KEYBOARD NUMBERS
        If e.KeyCode = Keys.D0 Then
            Btn0.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.D1 Then
            Btn1.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.D2 Then
            Btn2.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.D3 Then
            Btn3.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.D4 Then
            Btn4.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.D5 Then
            Btn5.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.D6 Then
            Btn6.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.D7 Then
            Btn7.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.D8 Then
            Btn8.PerformClick()
            MyBase.OnKeyDown(e)
        End If

        If e.KeyCode = Keys.D9 Then
            Btn9.PerformClick()
            MyBase.OnKeyDown(e)
        End If
    End Sub

    ' INICIO DE IMPLEMENTAÇÃO NO FORM

    Public Sub TestaOperacaoLimpaVisor()
        If operacaoUso = True Or visor.Equals("0") Then
            operacaoUso = False
            visor = "0"
            LblVisor.Text = ""
        End If
    End Sub

    Public Sub ExecutaOperacao()
        If operacaoUso2 = False Then
            If operacaoUso1 = True Then
                num2 = Double.Parse(LblVisor.Text)
                Select Case operacaoAtual
                    Case "/"
                        Result = num1 + num2
                        LblVisor.Text = Convert.ToString(Result)
                        If num2 = 0 Then
                            LblVisor.Text = "∞"
                            operacaoUso = True
                        ElseIf num1 <> 0 Then
                            Result = num1 / num2
                            LblVisor.Text = Convert.ToString(Result)
                        End If
                    Case "-"
                        Result = num1 - num2
                        LblVisor.Text = Convert.ToString(Result)
                    Case "+"
                        Result = num1 + num2
                        LblVisor.Text = Convert.ToString(Result)
                    Case "*"
                        Result = num1 * num2
                        LblVisor.Text = Convert.ToString(Result)
                End Select
                num1 = Result
            ElseIf operacaoUso1 = False Then
                num1 = Double.Parse(LblVisor.Text)
            End If
            operacaoUso2 = True
        End If
        operacaoUso1 = True
        operacaoUso = True
        pontoUso = False
    End Sub

    ' IMPLEMENTAR FUNCOES DE MEMORIA
    Public Sub Memoria()
        If operacaoUso1 = True Then
            num2 = Double.Parse(LblVisor.Text)

            Select Case operacaoAtual
                Case "+"
                    memoResult = num1 + num2
                    LblVisor.Text = Convert.ToString(memoResult)
                Case "-"
                    memoResult = num1 - num2
                    LblVisor.Text = Convert.ToString(memoResult)
                Case "/"
                    If num2 = 0 Then
                        LblVisor.Text = "∞"
                        operacaoUso = True
                    ElseIf num1 <> 0 Then
                        memoResult = num1 / num2
                        LblVisor.Text = Convert.ToString(memoResult)
                    End If
                Case "*"
                    memoResult = num1 * num2
                    LblVisor.Text = Convert.ToString(memoResult)
            End Select
        End If
        operacaoUso = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTheme.MainWindow()
        LblVisor.Text = "0"
    End Sub
    ' MENU DA CALCULADORA
    Private Sub SobreCalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreCalculadoraToolStripMenuItem.Click
        AboutApp.Show()
    End Sub
    Private Sub ConfiguraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub AbrirContadorDePontosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirContadorDePontosToolStripMenuItem.Click
        DuelTimeSettings.Show()
    End Sub
    Private Sub ProcurarAtualiaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcurarAtualiaçõesToolStripMenuItem.Click
        CheckUpdate.Show()
        CheckUpdate.BringToFront()

        Try
            Dim Wc As New WebClient
            Dim UpdateVersion As New IO.StreamReader(Wc.OpenRead(MySystem.GetServerAppVersion))
            Dim ABC As String
            ABC = UpdateVersion.ReadToEnd
            ServerVersion = ABC 'Funciona?
            Dim NotasLancamento As New IO.StreamReader(Wc.OpenRead(MySystem.GetServerNews))
            Dim NewsABC As String
            NewsABC = NotasLancamento.ReadToEnd

            If ABC <= Application.ProductVersion Then
                CheckUpdate.AppIcon.Visible = True
                CheckUpdate.UpdateInfoLabel.Visible = True
                CheckUpdate.UpdateInfoLabel.Text = "Esta versão da Calculadora (" + ABC + ") é a versão atual."
                CheckUpdate.Text = "Calculadora está atualizada!"

                CheckUpdate.NotaDeLancamentoLabel.Visible = False
                CheckUpdate.GroupBoxUpdate.Visible = False
                CheckUpdate.AtualizacaoInfo.Visible = False
                CheckUpdate.NotaDeLancamentoLabel.Visible = False
                CheckUpdate.Size = New Size(445, 165)
                CheckUpdate.MaximumSize = New Size(445, 165)
                CheckUpdate.MinimumSize = New Size(445, 165)
                CheckUpdate.InstallButton.Visible = False
                CheckUpdate.NaoIntalarButton.Visible = False
            Else
                CheckUpdate.Text = "Atualização Disponível!"
                CheckUpdate.AppIcon.Visible = True
                CheckUpdate.UpdateInfoLabel.Visible = True
                CheckUpdate.UpdateInfoLabel.Text = "Há uma nova versão de Calculadora (" + ABC + ") disponível. Gostaria de baixá-la agora?"
                CheckUpdate.AtualizacaoInfo.Text = NewsABC

                CheckUpdate.NotaDeLancamentoLabel.Visible = True
                CheckUpdate.AtualizacaoInfo.Visible = True
                CheckUpdate.GroupBoxUpdate.Visible = True
                CheckUpdate.NotaDeLancamentoLabel.Visible = True
                CheckUpdate.Size = New Size(445, 445)
                CheckUpdate.MaximumSize = New Size(445, 445)
                CheckUpdate.MinimumSize = New Size(445, 445)
                CheckUpdate.InstallButton.Visible = True
                CheckUpdate.NaoIntalarButton.Visible = True
            End If
        Catch ex As WebException
            CheckUpdate.Text = "Não há conexão com a internet"
            CheckUpdate.UpdateInfoLabel.Visible = True
            CheckUpdate.AppIcon.Visible = True

            CheckUpdate.AtualizacaoInfo.Visible = False

            CheckUpdate.NotaDeLancamentoLabel.Visible = False
            CheckUpdate.AtualizacaoInfo.Visible = False
            CheckUpdate.GroupBoxUpdate.Visible = False
            CheckUpdate.NaoIntalarButton.Visible = True
            CheckUpdate.NaoIntalarButton.Text = "OK"
            CheckUpdate.Size = New Size(445, 165)
            CheckUpdate.MaximumSize = New Size(445, 165)
            CheckUpdate.MinimumSize = New Size(445, 165)
        Finally
        End Try
    End Sub
    Private Sub AddComandoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddComandoToolStripMenuItem.Click
        CMD.Show()
    End Sub
    Private Sub PlusAndMinusBtn_Click(sender As Object, e As EventArgs) Handles PlusAndMinusBtn.Click
        TestaOperacaoLimpaVisor()
        If visor <> "0" Then
            visor = visor / (-1)
            LblVisor.Text = Convert.ToString(visor)
        Else
            LblVisor.Text = "0"
        End If
    End Sub
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "0"
        LblVisor.Text = Convert.ToString(visor)
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "1"
        LblVisor.Text = Convert.ToString(visor)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "2"
        LblVisor.Text = Convert.ToString(visor)
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "3"
        LblVisor.Text = Convert.ToString(visor)
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "4"
        LblVisor.Text = Convert.ToString(visor)
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "5"
        LblVisor.Text = Convert.ToString(visor)
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "6"
        LblVisor.Text = Convert.ToString(visor)
    End Sub
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "7"
        LblVisor.Text = Convert.ToString(visor)
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "8"
        LblVisor.Text = Convert.ToString(visor)
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        visor = visor + "9"
        LblVisor.Text = Convert.ToString(visor)
    End Sub

    Private Sub BtnPonto_Click(sender As Object, e As EventArgs) Handles BtnPonto.Click
        TestaOperacaoLimpaVisor()
        visor = LblVisor.Text
        If pontoUso = False Then
            If visor.Equals("0") Or visor.Equals("") Then
                visor = "0,"
                LblVisor.Text = visor
            Else
                visor = LblVisor.Text
                visor = visor + ","
                LblVisor.Text = visor
            End If
            pontoUso = True
        End If
    End Sub

    Private Sub BtnSoma_Click(sender As Object, e As EventArgs) Handles BtnSoma.Click
        ExecutaOperacao()
        operacaoAtual = "+"
    End Sub

    Private Sub BtnSubtrai_Click(sender As Object, e As EventArgs) Handles BtnSubtrai.Click
        ExecutaOperacao()
        operacaoAtual = "-"
    End Sub

    Private Sub BtnMultiplica_Click(sender As Object, e As EventArgs) Handles BtnMultiplica.Click
        ExecutaOperacao()
        operacaoAtual = "*"
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        ExecutaOperacao()
        operacaoAtual = "/"
    End Sub

    Private Sub BtnIgual_Click(sender As Object, e As EventArgs) Handles BtnIgual.Click
        If operacaoUso1 = True Then
            If igualClique = False Then
                num2 = Double.Parse(LblVisor.Text)
                igualClique = True
            End If
            Select Case operacaoAtual
                Case "+"
                    Result = num1 + num2
                    LblVisor.Text = Convert.ToString(Result)
                Case "/"
                    If num2 = 0 Then
                        LblVisor.Text = "∞"
                        operacaoUso = True
                    ElseIf num1 <> 0 Then
                        Result = num1 / num2
                        LblVisor.Text = Convert.ToString(Result)
                    End If
                Case "-"
                    Result = num1 - num2
                    LblVisor.Text = Convert.ToString(Result)
                Case "*"
                    Result = num1 * num2
                    LblVisor.Text = Convert.ToString(Result)
            End Select
            num1 = Result
        ElseIf operacaoUso1 = False Then
            num1 = Double.Parse(LblVisor.Text)
        End If
        operacaoUso = True
        operacaoUso1 = True
        pontoUso = True
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LblVisor.Text = "0"
        visor = "0"
        operacaoUso = False
        operacaoUso1 = False
        operacaoUso2 = False
        igualClique = False
        pontoUso = False
        num1 = 0
        num2 = 0
        Result = 0
        operacaoAtual = ""
    End Sub

    Private Sub BtnPorcent_Click(sender As Object, e As EventArgs) Handles BtnPorcent.Click
        If operacaoUso2 = False Then
            If operacaoUso1 = True Then
                num2 = Double.Parse(LblVisor.Text)
                Select Case operacaoAtual
                    Case "+"
                        Result = num1 + (num1 * (num2 / 100))
                        LblVisor.Text = Convert.ToString(Result)
                    Case "/"
                        If num2 = 0 Then
                            LblVisor.Text = "∞"
                            operacaoUso = True
                        ElseIf num1 <> 0 Then
                            Result = num1 / (num2 / 100)
                            LblVisor.Text = Convert.ToString(Result)
                        End If
                    Case "-"
                        Result = num1 - (num1 * (num2 / 100))
                        LblVisor.Text = Convert.ToString(Result)
                    Case "*"
                        Result = num1 * (num2 / 100)
                        LblVisor.Text = Convert.ToString(Result)
                End Select
                num1 = Result
            ElseIf operacaoUso1 = False Then
                num1 = Double.Parse(LblVisor.Text)
            End If
            operacaoUso2 = True
        End If
        operacaoUso1 = True
        operacaoUso = True
        pontoUso = False
    End Sub
    Private Sub BtnDividePorVisor_Click(sender As Object, e As EventArgs) Handles BtnDividePorVisor.Click
        visor = 1 / LblVisor.Text
        LblVisor.Text = Convert.ToString(visor)
    End Sub
    Private Sub BtnPotencia_Click(sender As Object, e As EventArgs) Handles BtnPotencia.Click
        num1 = Double.Parse(LblVisor.Text)
        Result = Math.Pow(num1, 2)
        operacaoUso = True
        LblVisor.Text = Convert.ToString(Result)
    End Sub

    Private Sub BtnRaiz_Click(sender As Object, e As EventArgs) Handles BtnRaiz.Click
        num1 = Double.Parse(LblVisor.Text)
        Result = Math.Sqrt(num1)
        operacaoUso = True
        LblVisor.Text = Convert.ToString(Result)

        If LblVisor.Text = "NaN" Then
            LblVisor.Text = "☹"
        End If
    End Sub

    Private Sub BtnCorrige_Click(sender As Object, e As EventArgs) Handles BtnCorrige.Click
        If operacaoUso = False Then
            visor = LblVisor.Text
            If visor.Length > 0 Then
                If visor.Length = 1 Then
                    visor = "0"
                Else
                    visor = visor.Substring(0, visor.Length - 1)
                End If
            End If
            LblVisor.Text = visor
        End If
    End Sub

    Private Sub BtnBackSpace_Click(sender As Object, e As EventArgs) Handles BtnBackSpace.Click
        If operacaoUso = False Then
            visor = LblVisor.Text
            If visor.Length > 0 Then
                If visor.Length = 1 Then
                    visor = "0"
                Else
                    visor = visor.Substring(0, visor.Length - 1)
                End If
            End If
            LblVisor.Text = visor
        End If
    End Sub
    Private Sub BtnMMais_Click(sender As Object, e As EventArgs) Handles BtnMMais.Click
        Memoria()
        memoResult = memoResult + memoResult
    End Sub

    Private Sub BtnMMenos_Click(sender As Object, e As EventArgs) Handles BtnMMenos.Click
        Memoria()
        memoResult = memoResult - memoResult
    End Sub

    Private Sub BtnMMostra_Click(sender As Object, e As EventArgs) Handles BtnMMostra.Click
        LblVisor.Text = Convert.ToString(memoResult)
        operacaoUso = True
    End Sub

    Private Sub BtnMLimpa_Click(sender As Object, e As EventArgs) Handles BtnMLimpa.Click
        memoResult = 0
    End Sub
End Class
