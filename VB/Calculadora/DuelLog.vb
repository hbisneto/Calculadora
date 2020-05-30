Public Class DuelLog

    Dim MySystem As MySystem = New MySystem()
    Dim MyTheme As MyTheme = New MyTheme()

    Private Sub DuelLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTheme.DuelLogTheme()
        ProfilePicP1.Image = DuelTime.ProfilePicP1.Image
        ProfilePicP2.Image = DuelTime.ProfilePicP2.Image
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        ListViewP1.Items.Clear()
    End Sub
End Class