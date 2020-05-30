Public Class MySystem

    Public AppMajor As String = My.Application.Info.Version.Major
    Public AppMinor As String = My.Application.Info.Version.Minor
    Public AppBuild As String = My.Application.Info.Version.Build
    Public AppRevision As String = My.Application.Info.Version.Revision
    Public AppEasterEgg As String = "H.B.A.N"

    Public ServerApp As String = "https://dl.dropboxusercontent.com/s/cgnkycid9k5y1zg/Calculadora.exe"
    Public ServerAppVersion As String = "https://dl.dropboxusercontent.com/s/euor4e57fr0vohj/Version.txt"
    Public ServerNews As String = "https://dl.dropboxusercontent.com/s/5a1ega79ii9uxto/News.txt"

    ' ============ Codiname Image ===========
    Public Code_Sun = My.Resources.Sol
    ' ============ Codiname Image ===========

    ' ============ Monstros de Duelo ===========
    Public PlayerOneName As String
    Public PlayerTwoName As String

    ' ============ DuelTime Action Counter ===========
    Public P1Counter As Integer = 0
    Public P2Counter As Integer = 0
    ' ============ DuelTime Action Counter ===========

    ' ============ Characters Images ===========
    Public AkizaIzinski As Image = My.Resources.AkizaIzinski
    Public AlexisRhodes As Image = My.Resources.AlexisRhodes
    Public ChazzPrinceton As Image = My.Resources.ChazzPrinceton
    Public JadenYuki As Image = My.Resources.JadenYuki
    Public Joey As Image = My.Resources.Joey
    Public MaiValentine As Image = My.Resources.MaiValentine
    Public MaximillionPegasus As Image = My.Resources.MaximillionPegasus
    Public SetoKaiba As Image = My.Resources.SetoKaiba
    Public Tea As Image = My.Resources.Tea
    Public YamiMarik As Image = My.Resources.YamiMarik
    Public YamiYugi As Image = My.Resources.YamiYugi
    Public Yugi As Image = My.Resources.Yugi
    Public YuseiFudo As Image = My.Resources.YuseiFudo
    Public DefaultPlayer As Image = My.Resources.UserIcon
    ' ============ Characters Images ===========
    ' ============ Monstros de Duelo ===========

    ' ============ CMD ===========
    Public Count As Integer = 0
    Public CommandMessage As String
    Public SetTimer As Boolean = False
    ' ============ CMD ===========

    ' ============ System Version Controller ===========
    ' ============ X.0.0.0 ===========
    Public Property GetAppMajor As String
        Get
            Return AppMajor
        End Get
        Set(ByVal MajorValue As String)
            AppMajor = MajorValue
        End Set
    End Property
    ' ============ 0.X.0.0 ===========
    Public Property GetAppMinor As String
        Get
            Return AppMinor
        End Get
        Set(ByVal MajorRevisionValue As String)
            AppMinor = MajorRevisionValue
        End Set
    End Property
    ' ============ 0.0.X.0 ===========
    Public Property GetAppBuild As String
        Get
            Return AppBuild
        End Get
        Set(ByVal BuildValue As String)
            AppBuild = BuildValue
        End Set
    End Property
    ' ============ 0.0.0.X ===========
    Public Property GetAppRevision As String
        Get
            Return AppRevision
        End Get
        Set(ByVal RevisionValue As String)
            AppRevision = RevisionValue
        End Set
    End Property
    ' ============ EasterEgg Property ===========
    Public Property GetEasterEgg As String
        Get
            Return AppEasterEgg
        End Get
        Set(ByVal EasterValue As String)
            AppEasterEgg = EasterValue
        End Set
    End Property
    ' ============ EasterEgg Property ===========

    ' ============ EasterEgg Function ===========
    Public Sub EasterEgg()
        If Form1.LblVisor.Text = AppBuild Then
            Form1.HistoryTextBox.Text = "Calculadora " & String.Format("{0}", My.Application.Info.Version.ToString) & " - Projeto SOLAR"

            If Form1.LblVisor.Text = "0" Then
                Form1.LblVisor.Text = "SOL"
            End If

            If Form1.LblVisor.Text = "1" Then
                Form1.LblVisor.Text = "Moon???"
            End If

            ' Previous version of Calculadora
            If Form1.LblVisor.Text = "3" And GetAppRevision = "257" Then
                Form1.LblVisor.Text = "H.B.A.N"
            End If

        End If
    End Sub
    ' ============ EasterEgg Function ===========
    ' ============ System Version Controller ===========

    ' ============ Get Server Info ===========
    Public Property GetServerApp As String
        Get
            Return ServerApp
        End Get
        Set(ByVal ServerAppValue As String)
            ServerApp = ServerAppValue
        End Set
    End Property

    Public Property GetServerAppVersion As String
        Get
            Return ServerAppVersion
        End Get
        Set(ByVal ServerAppVersionValue As String)
            ServerAppVersion = ServerAppVersionValue
        End Set
    End Property

    Public Property GetServerNews As String
        Get
            Return ServerNews
        End Get
        Set(ByVal ServerAppNewsValue As String)
            ServerNews = ServerAppNewsValue
        End Set
    End Property
    ' ============ Get Server Info ===========

    ' ============ Condiname Controller ===========
    Public Sub GetProjectName()
        'ProjectName = ProjectNameValue

        If AppBuild = "0" Then
            AboutApp.ProjectNameTextBox.Text = "Codinome: Sol"
            AboutApp.CodeNamePic.Image = Code_Sun
        End If
        If AppBuild = "1" Then
            AboutApp.ProjectNameTextBox.Text = "Codinome: Moon???"
        End If

    End Sub
    ' ============ Condiname Controller ===========

    ' ============ AboutApp Window ===========
    Public Sub About()
        AboutApp.AppName.Text = My.Application.Info.AssemblyName
        AboutApp.Copyright.Text = My.Application.Info.Copyright
        AboutApp.Version.Text = String.Format("Versão {0}", My.Application.Info.Version.ToString)
    End Sub
    ' ============ AboutApp Window ===========

    ' ============ CheckUpdate Window ===========
    Public Sub CheckUpdateSettings()
        CheckUpdate.GroupBoxUpdate.Size = New Size(405, 250)
        CheckUpdate.GroupBoxUpdate.Location = New Point(12, 118)
        CheckUpdate.AtualizacaoInfo.Size = New Size(393, 230)
        CheckUpdate.AtualizacaoInfo.Location = New Point(6, 13)

        CheckUpdate.UpdateUpLabel.Visible = False
        CheckUpdate.UpdateProgressBar.Visible = False
        CheckUpdate.UpdateDownLabel.Visible = False
    End Sub
    ' ============ CheckUpdate Window ===========

    ' ============ DuelTime Window ===========
    Public Sub DuelTimeSystem()
        Dim DT = DuelTime

        ' ============ P1 Controller ===========
        'P1Life = 8000
        DT.ProfilePicP1.Image = DefaultPlayer
        ' ============ P1 Controller ===========

        ' ============ P2 Controller ===========
        'P2Life = 8000
        DT.ProfilePicP2.Image = DefaultPlayer
        ' ============ P2 Controller ===========
    End Sub
    ' ============ DuelTime Window ===========
End Class
