Imports System.Threading

Public Class Welcome

    Private Async Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        Await Task.Delay(1500)

        Dim IDE As MainWindow = New MainWindow
        IDE.Show()
        Me.Close()

    End Sub

    Private IsAliveTimer As Timers.Timer



End Class
