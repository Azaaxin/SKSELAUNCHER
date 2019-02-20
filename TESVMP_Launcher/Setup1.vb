Public Class Setup1
    Dim game As String
    Dim SSEEdit_Func As String
    Dim FNIS_Func As String
    Dim fpath As String = ""
    Dim folderlocation As String
    Dim sksename2016 As String = "skse64_loader.exe"
    Dim sksename2011 As String = "skse_loader.exe"
    Dim Normalskyrimname As String = "TESV.exe"
    Dim Specialskyrimname As String = "SkyrimSE.exe"
    Dim autofindText As String = "A copy of Skyrim has been detected. Use it?"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        game = "skyrim_2016"
        PictureBox1.Hide()
        Button1.Hide()
        Button2.Hide()
        Gamefinder()
        TextBox1.Show()
        Button3.Show()
        Label1.Show()
        Button4.Show()
        Button5.Show()
        Label2.Show()
        If TextBox1.Text = Nothing Then
            Button5.Enabled = False
        End If
        Label3.Show()
        FNIS_button.Show()
        FNIS_textbox.Show()
        SSEEdit_Button.Show()
        SSEEdit_textbox.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        fpath = OpenFileDialog1.FileName
        TextBox1.Text = fpath
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Filter = "exe |*.exe*"
        If game = "skyrim_2011" = True Then
            OpenFileDialog1.FileName = sksename2011
        ElseIf game = "skyrim_2016" = True Then
            OpenFileDialog1.FileName = sksename2016
        End If

        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then

        End If
    End Sub

    Private Sub Setup1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        game = "skyrim_2011"
        PictureBox1.Hide()
        Button1.Hide()
        Button2.Hide()
        Gamefinder()
        TextBox1.Show()
        Button3.Show()
        Label1.Show()
        Button4.Show()
        Button5.Show()
        Label2.Show()
        If TextBox1.Text = Nothing Then
            Button5.Enabled = False
        End If
        Label3.Show()
        FNIS_button.Show()
        FNIS_textbox.Show()
        SSEEdit_Button.Show()
        SSEEdit_textbox.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
    End Sub
    Private Sub Gamefinder()
        Dim folders As String = "\steamapps\common\Skyrim Special Edition\"
        Dim foldersold As String = "\steamapps\common\Skyrim\"
        Dim strSteamInstallPath As String = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
        If game = "skyrim_2016" = True Then

            If System.IO.File.Exists(strSteamInstallPath + folders + "skse64_loader.exe") = True Then
                fpath = strSteamInstallPath + folders + sksename2016
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
            If System.IO.File.Exists(strSteamInstallPath + folders + "SkyrimSE.exe") Then
                fpath = strSteamInstallPath + folders + "SkyrimSE.exe"
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
            If System.IO.File.Exists("D:\Program Files (x86)\Steam\steamapps\common\Skyrim Special Edition\" + sksename2016) = True Then
                fpath = "D:\Program Files (x86)\Steam\steamapps\common\Skyrim Special Edition\" + sksename2016
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If

            If System.IO.File.Exists("D:\Program Files\Steam\steamapps\common\Skyrim Special Edition\" + sksename2016) = True Then
                    fpath = "D:\Program Files\Steam\steamapps\common\Skyrim Special Edition\" + sksename2016
                    Label1.Text = autofindText
                    Label3.Location = New Point(49, 146)
                End If
                If System.IO.File.Exists("C:\Program Files (x86)\Steam\steamapps\common\Skyrim Special Edition\" + sksename2016) = True Then
                    fpath = "C:\Program Files (x86)\Steam\steamapps\common\Skyrim Special Edition\" + sksename2016
                    Label1.Text = autofindText
                    Label3.Location = New Point(49, 146)
                End If
                If System.IO.File.Exists("C:\Program Files\Steam\steamapps\common\Skyrim Special Edition\" + sksename2016) = True Then
                    fpath = "C:\Program Files\Steam\steamapps\common\Skyrim Special Edition\" + sksename2016
                    Label1.Text = autofindText
                    Label3.Location = New Point(49, 146)
                End If

            If System.IO.File.Exists("D:\Program Files\Steam\steamapps\common\Skyrim Special Edition\" + Specialskyrimname) = True Then
                fpath = "D:\Program Files\Steam\steamapps\common\Skyrim Special Edition\" + Specialskyrimname
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
            TextBox1.Text = fpath
        End If

        If game = "skyrim_2011" = True Then
            If System.IO.File.Exists(strSteamInstallPath + foldersold + sksename2011) Then
                fpath = strSteamInstallPath + foldersold + sksename2011
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
            If System.IO.File.Exists("D:\Program Files (x86)\Steam\steamapps\common\Skyrim\" + sksename2011) = True Then
                fpath = "D:\Program Files (x86)\Steam\steamapps\common\Skyrim\" + sksename2011
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
            If System.IO.File.Exists("D:\Program Files\Steam\steamapps\common\Skyrim\" + sksename2011) = True Then
                fpath = "D:\Program Files\Steam\steamapps\common\Skyrim\" + sksename2011
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
            If System.IO.File.Exists("C:\Program Files (x86)\Steam\steamapps\common\Skyrim\" + sksename2011) = True Then
                fpath = "C:\Program Files (x86)\Steam\steamapps\common\Skyrim\" + sksename2011
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
            If System.IO.File.Exists("C:\Program Files\Steam\steamapps\common\Skyrim\" + sksename2011) = True Then
                fpath = "C:\Program Files\Steam\steamapps\common\Skyrim\" + sksename2011
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
            If System.IO.File.Exists("D:\Program Files HDD\Steam\steamapps\common\Skyrim\" + sksename2011) = True Then
                fpath = "D:\Program Files HDD\Steam\steamapps\common\Skyrim\" + sksename2011
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
            TextBox1.Text = fpath

            If System.IO.File.Exists("D:\Program Files\Steam\steamapps\common\Skyrim Special Edition\" + Normalskyrimname) = True Then
                fpath = "D:\Program Files\Steam\steamapps\common\Skyrim Special Edition\" + Normalskyrimname
                Label1.Text = autofindText
                Label3.Location = New Point(49, 146)
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Show()
        Button1.Show()
        Button2.Show()
        TextBox1.Text = ""
        TextBox1.Hide()
        Button3.Hide()
        Label1.Hide()
        Button4.Hide()
        Button5.Hide()
        Label2.Hide()
        Label1.Text = ""
        Label3.Hide()
        Label3.Location = New Point(49, 124)
        FNIS_button.Hide()
        FNIS_textbox.Hide()
        SSEEdit_Button.Hide()
        SSEEdit_textbox.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If System.IO.File.Exists(TextBox1.Text) = True Then
            If TextBox1.Text.Contains(sksename2011) Or TextBox1.Text.Contains(sksename2016) Or TextBox1.Text.Contains("TESV.exe") Or TextBox1.Text.Contains("SkyrimSE.exe") = True Then
                Button5.Enabled = True
            Else
                Button5.Enabled = False
            End If
        Else
            Button5.Enabled = False
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.Game = game

        My.Settings.Save()
        My.Settings.Reload()

        My.Settings.Gamepath = fpath

        My.Settings.Save()
        My.Settings.Reload()

        My.Settings.FNIS = FNIS_Func

        My.Settings.Save()
        My.Settings.Reload()

        My.Settings.SSEEdit = SSEEdit_Func

        My.Settings.Save()
        My.Settings.Reload()

        My.Settings.FirstTimeUsed = False
        My.Settings.Save()
        My.Settings.Reload()

        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub SSEEdit_Button_Click(sender As Object, e As EventArgs) Handles SSEEdit_Button.Click
        SSEEdit.Filter = "Exe |*.exe*"
        SSEEdit.FileName = "SSEEdit/Tes5edit"
        If SSEEdit.ShowDialog(Me) = DialogResult.OK Then
            SSEEdit_textbox.Text = SSEEdit.ShowDialog
        End If
        SSEEdit_textbox.Text = SSEEdit.FileName
    End Sub

    Private Sub SSEEdit_textbox_TextChanged(sender As Object, e As EventArgs) Handles SSEEdit_textbox.TextChanged
        SSEEdit_Func = SSEEdit_textbox.Text
    End Sub

    Private Sub FNIS_textbox_TextChanged(sender As Object, e As EventArgs) Handles FNIS_textbox.TextChanged
        FNIS_Func = FNIS_textbox.Text
    End Sub

    Private Sub FNIS_button_Click(sender As Object, e As EventArgs) Handles FNIS_button.Click
        FNIS.Filter = "Exe |*.exe*"
        FNIS.FileName = "FNIS"
        If FNIS.ShowDialog(Me) = DialogResult.OK Then

        End If
        FNIS_textbox.Text = FNIS.FileName
    End Sub

    Private Sub Setup1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub
End Class