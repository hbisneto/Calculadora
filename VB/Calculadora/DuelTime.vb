Public Class DuelTime

    Dim MyTheme As MyTheme = New MyTheme()
    Dim MySystem As MySystem = New MySystem()
    ' ============ Life Points Controller ===========
    Public P1StartedPoint As Integer
    Public P2StartedPoint As Integer
    Public P1Life As Integer
    Public P2Life As Integer
    ' ============ Life Points Controller ===========
    Dim LVCounterP1 As Integer = 0
    Dim LVCounterP2 As Integer = 0

    Private Sub DuelTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTheme.DuelTimeTheme()
        MySystem.DuelTimeSystem()
    End Sub

    Private Sub ConfiguraçõesDeDueloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarDueloToolStripMenuItem.Click
        DuelTimeSettings.Show()
        DuelTimeSettings.BringToFront()
    End Sub

    Private Sub LogDeDueloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogDeDueloToolStripMenuItem.Click
        DuelLog.Show()
    End Sub

    Private Sub BtnAddLP1_Click(sender As Object, e As EventArgs) Handles BtnAddLP1.Click
        LVCounterP1 += 1
        Try
            LblP1Life.Text = (P1Life + TxtBoxPointsP1.Text)
            P1Life += TxtBoxPointsP1.Text

            If P1Life > P1StartedPoint Then
                LblP1Life.ForeColor = Color.Green
            ElseIf P1Life <= P1StartedPoint And P1Life > "200" Then
                LblP1Life.ForeColor = Color.White
            Else
                LblP1Life.ForeColor = Color.Red
            End If

        Catch ex As Exception
            MessageBox.Show("Insira um valor para o calculo", "Valor Não Atribuido", MessageBoxButtons.OK)
        End Try

        Dim LVItem As New ListViewItem(LVCounterP1)
        LVItem.SubItems.Add(LblP1Name.Text & " ganhou mais " & TxtBoxPointsP1.Text & " pontos de vida")
        LVItem.SubItems.Add(LblP1Life.Text)

        DuelLog.ListViewP1.Items.AddRange(New ListViewItem() {LVItem})
    End Sub

    Private Sub BtnSubLP1_Click(sender As Object, e As EventArgs) Handles BtnSubLP1.Click
        LVCounterP1 += 1
        Try
            LblP1Life.Text = (P1Life - TxtBoxPointsP1.Text)
            P1Life -= TxtBoxPointsP1.Text

            If P1Life > P1StartedPoint Then
                LblP1Life.ForeColor = Color.Green
            ElseIf P1Life <= P1StartedPoint And P1Life > "200" Then
                LblP1Life.ForeColor = Color.White
            Else
                LblP1Life.ForeColor = Color.Red
            End If

        Catch ex As Exception
            MessageBox.Show("Insira um valor para o calculo", "Valor Não Atribuido", MessageBoxButtons.OK)
        End Try

        Dim LVItem As New ListViewItem(LVCounterP1)
        LVItem.SubItems.Add(LblP1Name.Text & " perdeu " & TxtBoxPointsP1.Text & " pontos de vida")
        LVItem.SubItems.Add(LblP1Life.Text)

        DuelLog.ListViewP1.Items.AddRange(New ListViewItem() {LVItem})
    End Sub

    Private Sub BtnAddLP2_Click(sender As Object, e As EventArgs) Handles BtnAddLP2.Click
        LVCounterP2 += 1
        Try
            LblP2Life.Text = (P2Life + TxtBoxPointsP2.Text)
            P2Life += TxtBoxPointsP2.Text

            If P2Life > P2StartedPoint Then
                LblP2Life.ForeColor = Color.Green
            ElseIf P2Life <= P2StartedPoint And P2Life > "200" Then
                LblP2Life.ForeColor = Color.White
            Else
                LblP2Life.ForeColor = Color.Red
            End If

        Catch ex As Exception
            MessageBox.Show("Insira um valor para o calculo", "Valor Não Atribuido", MessageBoxButtons.OK)
        End Try

        Dim LVItem As New ListViewItem(LVCounterP2)
        LVItem.SubItems.Add(LblP2Name.Text & " ganhou mais " & TxtBoxPointsP2.Text & " pontos de vida")
        LVItem.SubItems.Add(LblP2Life.Text)

        DuelLog.ListViewP2.Items.AddRange(New ListViewItem() {LVItem})
    End Sub

    Private Sub BtnSubLP2_Click(sender As Object, e As EventArgs) Handles BtnSubLP2.Click
        LVCounterP2 += 1
        Try
            LblP2Life.Text = (P2Life - TxtBoxPointsP2.Text)
            P2Life -= TxtBoxPointsP2.Text

            If P2Life > P2StartedPoint Then
                LblP2Life.ForeColor = Color.Green
            ElseIf P2Life <= P2StartedPoint And P2Life > "200" Then
                LblP2Life.ForeColor = Color.White
            Else
                LblP2Life.ForeColor = Color.Red
            End If

        Catch ex As Exception
            MessageBox.Show("Insira um valor para o calculo", "Valor Não Atribuido", MessageBoxButtons.OK)
        End Try

        Dim LVItem As New ListViewItem(LVCounterP2)
        LVItem.SubItems.Add(LblP2Name.Text & " perdeu " & TxtBoxPointsP2.Text & " pontos de vida")
        LVItem.SubItems.Add(LblP2Life.Text)

        DuelLog.ListViewP2.Items.AddRange(New ListViewItem() {LVItem})
    End Sub
End Class