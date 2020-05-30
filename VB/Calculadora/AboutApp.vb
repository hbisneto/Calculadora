Public Class AboutApp

    Dim MyTheme As MyTheme = New MyTheme()
    Dim MySystem As MySystem = New MySystem()

    Private Sub AboutApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTheme.AboutAppTheme()
        MySystem.About()
        MySystem.GetProjectName()
    End Sub
End Class