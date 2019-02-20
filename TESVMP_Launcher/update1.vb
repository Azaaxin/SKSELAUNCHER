Imports System.Net
Imports System.IO
Imports System.Text


Public Class update1
    Private WithEvents httpclient As WebClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Button1.Enabled = False
            persent.Show()
            ProgressBar1.Show()
            If Form1.IsConnected() = True Then
                httpclient = New WebClient
                AddHandler httpclient.DownloadFileCompleted, AddressOf Downloaded
                httpclient.DownloadFileAsync(New Uri("http://leso-notes.dlinkddns.com/TESVMP_Launcher.exe"), ("TESVMP_Launcher1.exe"))
            End If
        Catch
        Finally
        End Try
    End Sub
    Private Sub dpc(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles httpclient.DownloadProgressChanged
        persent.Text = e.ProgressPercentage
        ProgressBar1.Value = Int32.Parse(Math.Truncate(e.ProgressPercentage).ToString())

    End Sub
    Private Sub update1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Size = New System.Drawing.Size(187, 191)
        Try
            'stable
            If Form1.IsConnected() = True Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://leso-notes.dlinkddns.com/TESVMP_version.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Label1.Text = ("You have the current version!")

                Else
                    Label1.Text = ("New version available")
                    Button1.Enabled = True
                End If

                'beta
                Dim request1 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://leso-notes.dlinkddns.com/TESVMP_version_alpha.txt")
                Dim response1 As System.Net.HttpWebResponse = request1.GetResponse()
                Dim sr1 As System.IO.StreamReader = New System.IO.StreamReader(response1.GetResponseStream())
                Dim newestversion1 As String = sr1.ReadToEnd()
                Dim currentversion1 As String = Application.ProductVersion
                Dim address As String = "http://leso-notes.dlinkddns.com/TESVMP_start_alpha.txt"
                Dim client As WebClient = New WebClient()
                Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
                Dim alpha_on As String = reader.ReadToEnd
                If newestversion1.Contains(currentversion1 & alpha_on) Then
                    Me.Size = New System.Drawing.Size(374, 191)
                    Label2.Text = ("Beta version available")
                    Button2.Enabled = True
                Else
                    Label2.Text = ("Beta Closed")
                    Me.Size = New System.Drawing.Size(187, 191)
                End If


            End If
        Catch

        Finally
        End Try
    End Sub

    Public Sub Downloaded()

        If MsgBox("You may need to restart TESVMP for this update to take effect" & vbCrLf & "Wanna do it now?", MsgBoxStyle.YesNo, "Done - 100%") = MsgBoxResult.Yes Then
            If System.IO.File.Exists("TESVMP_Launcher1.exe") = True Then
                If File.Exists("TESVMP_Launcher_updater.cmd") Then
                    Shell("TESVMP_Launcher_updater.cmd", AppWinStyle.Hide)
                Else
                    MsgBox("Error, could not update! Try again!")
                    End
                End If
            End If
                End
        ElseIf MsgBoxResult.No Then
            Me.Hide()
            settings_options.Hide()
        End If
    End Sub


    Private Sub persent_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Button2.Enabled = False
            persent.Show()
            ProgressBar1.Show()
            If Form1.IsConnected() = True Then
                httpclient = New WebClient
                AddHandler httpclient.DownloadFileCompleted, AddressOf Downloaded
                httpclient.DownloadFileAsync(New Uri("http://leso-notes.dlinkddns.com/TESVMP_Launcher_alpha.exe"), ("TESVMP_Launcher1.exe"))
            End If

        Catch
        Finally
        End Try
    End Sub

    Private Sub persent_Click_1(sender As Object, e As EventArgs) Handles persent.Click

    End Sub
End Class