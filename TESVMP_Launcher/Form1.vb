Imports System
Imports System.IO
Imports System.Text
Imports System.Reflection
Imports System.Diagnostics
Imports System.ComponentModel
Imports TESVMP_Launcher.IniFile
Public Class Form1
    Dim objIniFile As New IniFile(My.Application.Info.DirectoryPath & "\SKSELauncher.ini")
    'Declare the variables

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim p() As Process

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If objIniFile.GetString("Special", "Passwd", "") = "" = False Then
            Protection.ShowDialog()
            Me.Hide()
        End If
        If My.Settings.Password = "" = False Then
            Protection.ShowDialog()
            Me.Hide()
        End If
        If objIniFile.GetString("Illustration Settings", "BackgroundImage", "") = "" = False Then
            If File.Exists(objIniFile.GetString("Illustration Settings", "BackgroundImage", "")) Then
                Me.BackgroundImage = System.Drawing.Image.FromFile(objIniFile.GetString("Illustration Settings", "BackgroundImage", ""))
            End If

        End If


            FirstUse()
        If My.Settings.Game = "" Then
            End
        End If
        setMenuPictures()
        setMenuCustomPictures()
        Me.Size = New Size(objIniFile.GetString("Settings", "Window_Size_X", "612"), objIniFile.GetString("Settings", "Window_Size_Y", "266"))
        If settings_options.GametimeStatus.Checked = True Then
            Me.timeplayed.Visible = True
            Me.Label1.Visible = True
        Else
            Me.Label1.Visible = False
            Me.timeplayed.Visible = False
        End If
        If settings_options.version_checkbox.Checked = True Then
            Me.AZAAXIN_INFO.Visible = True
            Me.version1.Visible = True
        Else
            Me.AZAAXIN_INFO.Visible = False
            Me.version1.Visible = False
        End If
        'If settings_options.CheckBox1.Checked = True Then
        '    Me.PLAY0.Location = New Point(6, 21)
        '    Me.OPTIONS0.Location = New Point(6, 95)
        '    Me.EXIT0.Location = New Point(6, 164)
        'Else
        '    Me.PLAY0.Location = New Point(436, 21)
        '    Me.OPTIONS0.Location = New Point(436, 95)
        '    Me.EXIT0.Location = New Point(436, 164)
        'End If

        Try
            If My.Settings.Game = "skyrim_2011" = True Then

                If System.IO.File.Exists("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat") = True Then

                    Dim FILE_NAME As String = "C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat"
                    Dim objReader4 As StreamReader
                    Dim gametimes4 As Integer
                    objReader4 = System.IO.File.OpenText(FILE_NAME)
                    gametimes4 = objReader4.ReadToEnd
                    objReader4.Close()
                    timeplayed.Text = Format(gametimes4 / 60, "0.00") & " hours"

                Else
                    System.IO.File.AppendAllText("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat", "0" & vbCrLf)
                    Dim objReader1 As New System.IO.StreamReader("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat")
                    Dim gametimes1 As Integer = objReader1.ReadToEnd
                    objReader1.Close()
                    timeplayed.Text = Format(gametimes1 / 60, "0.00") & " hours"



                End If
            Else
                If System.IO.File.Exists("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim Special Edition\gametime.dat") = True Then

                    Dim FILE_NAME As String = "C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim Special Edition\gametime.dat"
                    Dim objReader4 As StreamReader
                    Dim gametimes4 As Integer
                    objReader4 = System.IO.File.OpenText(FILE_NAME)
                    gametimes4 = objReader4.ReadToEnd
                    objReader4.Close()
                    timeplayed.Text = Format(gametimes4 / 60, "0.00") & " hours"

                Else
                    System.IO.File.AppendAllText("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim Special Edition\gametime.dat", "0" & vbCrLf)
                    Dim objReader1 As New System.IO.StreamReader("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim Special Edition\gametime.dat")
                    Dim gametimes1 As Integer = objReader1.ReadToEnd
                    objReader1.Close()
                    timeplayed.Text = Format(gametimes1 / 60, "0.00") & " hours"



                End If
            End If
            systemTray()

            Label2.Text = ""
            Dim appPath As String = Application.StartupPath()
            If System.IO.File.Exists("bg_remember.bat") = True Then
                If System.IO.File.Exists("mario.bat") = True Then
                    '   MsgBox(appPath & "\mario.bat")
                    File.Delete(appPath & "\mario.bat")
                End If
                '   MsgBox(appPath & "\mario.bat")
                File.Delete(appPath & "\bg_remember.bat")
            Else
                'Nothing
            End If

            ' Me.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.varible) 'Custom Background loaded

            If Assembly.GetEntryAssembly.ToString <> "0.0.0.0" Then
                version1.Text = Assembly.GetEntryAssembly.ToString
            Else
                version1.Text = My.Application.Info.Version.ToString()
            End If

            PLAY0_MouseLeave(sender, e)
            OPTIONS0_MouseLeave(sender, e)
            EXIT0_MouseLeave(sender, e)

            If System.IO.File.Exists("TESVMP_Launcher_updater.cmd") = True Then

            Else
                If IsConnected() = True Then
                    My.Computer.Network.DownloadFile(
                    "http://leso-notes.dlinkddns.com/TESVMP_Launcher_updater.cmd",
                    "TESVMP_Launcher_updater.cmd")

                End If
            End If
            If IsConnected() = True Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://leso-notes.dlinkddns.com/TESVMP_version.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion

                If newestversion.Contains(currentversion) Then
                    UpdateMessage.Hide()
                Else
                    UpdateMessage.Text = ("New version available")

                End If
            End If
        Catch
        Finally
        End Try

    End Sub
    Private Sub setMenuCustomPictures()
        If (objIniFile.GetString("Custom Buttons", "CustomBtn1_Enabled", "") = "True") Then
            CustomButton1.Visible = True
        Else
            CustomButton1.Visible = False
        End If
        '  If (objIniFile.GetString("Custom Buttons", "CustomBtn1_Image", "") = "") Then
        ' CustomButton1.Image = New Bitmap(My.Resources._1)
        '  Else
        '  CustomButton1.Image = Image.FromFile(objIniFile.GetString("Custom Buttons", "CustomBtn1_Image", ""))
        '   End If
    End Sub
    Function IsConnected() As Boolean
        Return My.Computer.Network.Ping("209.85.147.147")
    End Function
    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave

    End Sub


    Private Sub FirstUse()
        If My.Settings.FirstTimeUsed = True Then
            Me.Hide()
            Me.Visible = False
            Setup1.ShowDialog()

        End If
    End Sub
    Private Sub setMenuPictures()
        If (objIniFile.GetString("Illustration Settings", "Play_button", "") = "") Then
            PLAY0.Image = New Bitmap(My.Resources.PLAY0)
        Else
            If File.Exists(objIniFile.GetString("Illustration Settings", "Play_button", "")) Then
                PLAY0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Play_button", ""))
            End If
        End If
        If (objIniFile.GetString("Illustration Settings", "Options_button", "") = "") Then
            OPTIONS0.Image = New Bitmap(My.Resources.OPTIONS0)
        Else
            If File.Exists(objIniFile.GetString("Illustration Settings", "Options_button", "")) Then
                OPTIONS0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Options_button", ""))
            End If
        End If
        If (objIniFile.GetString("Illustration Settings", "Exit_button", "") = "") Then
            EXIT0.Image = New Bitmap(My.Resources.EXIT0)
        Else
            If File.Exists(objIniFile.GetString("Illustration Settings", "Exit_button", "")) Then
                EXIT0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Exit_button", ""))
            End If
        End If

        If (objIniFile.GetString("Custom Buttons", "CustomBtn1_Image", "") = "") Then
            CustomButton1.Image = New Bitmap(My.Resources._1)
            'CustomButton1.Image = Image.FromFile(objIniFile.GetString("Custom Buttons", "CustomBtn1_Image", ""))
        Else
            If File.Exists(objIniFile.GetString("Custom Buttons", "CustomBtn1_Image", "")) Then
                CustomButton1.Image = Image.FromFile(objIniFile.GetString("Custom Buttons", "CustomBtn1_Image", ""))
            End If
        End If

            CustomButton1.Size = New Point(objIniFile.GetInteger("Custom Buttons", "CustomBtn1_Size_x=", "100"), objIniFile.GetInteger("Custom Buttons", "CustomBtn1_Size_y=", "50"))
        'PLAY0.Size = My.Settings.PLAY0_Size
        PLAY0.Size = New Point(objIniFile.GetInteger("Illustration Settings", "Play_Size_x", "164"), objIniFile.GetInteger("Illustration Settings", "Play_Size_y", "43"))

        ' OPTIONS0.Size = My.Settings.OPTIONS0_Size
        OPTIONS0.Size = New Point(objIniFile.GetInteger("Illustration Settings", "Options_Size_x", "164"), objIniFile.GetInteger("Illustration Settings", "Options_Size_y", "43"))
        'EXIT0.Size = My.Settings.EXIT0_Size
        EXIT0.Size = New Point(objIniFile.GetInteger("Illustration Settings", "Exit_Size_x", "164"), objIniFile.GetInteger("Illustration Settings", "Exit_Size_y", "43"))
        ' PLAY0.Location = My.Settings.Play_Location
        PLAY0.Location = New Point(objIniFile.GetInteger("Settings", "Play_location_X", "436"), objIniFile.GetInteger("Settings", "Play_location_Y", "21"))
        'OPTIONS0.Location = My.Settings.OPTIONS_location
        OPTIONS0.Location = New Point(objIniFile.GetInteger("Settings", "Options_location_X", "436"), objIniFile.GetInteger("Settings", "Options_location_Y", "95"))
        ' EXIT0.Location = My.Settings.Exit_location
        EXIT0.Location = New Point(objIniFile.GetInteger("Settings", "Exit_location_X", "436"), objIniFile.GetInteger("Settings", "Exit_location_Y", "164"))
        CustomButton1.Location = New Point(objIniFile.GetInteger("Custom Buttons", "CustomBtn1_location_X", "0"), objIniFile.GetInteger("Custom Buttons", "CustomBtn1_location_Y", "0"))

        '  MsgBox(My.Settings.Exit_location.ToString)
    End Sub


    Private Sub PLAY0_MouseHover(sender As Object, e As EventArgs) Handles PLAY0.MouseHover
        'If (My.Settings.Play_Btn_Mouseover = "") Then
        If (objIniFile.GetString("Illustration Settings", "Play_MouseOver", "") = "") Then
            PLAY0.Image = New Bitmap(My.Resources.PLAY1)
        Else
            '   PLAY0.Image = Image.FromFile(My.Settings.Play_Btn_Mouseover)
            If File.Exists(objIniFile.GetString("Illustration Settings", "Play_MouseOver", "")) Then
                PLAY0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Play_MouseOver", ""))
            End If
        End If

    End Sub
    Private Sub PLAY0_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PLAY0.MouseLeave, PLAY0.MouseLeave
        If (objIniFile.GetString("Illustration Settings", "Play_button", "") = "") Then
            PLAY0.Image = New Bitmap(My.Resources.PLAY0)
        Else
            PLAY0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Play_button", ""))
        End If
    End Sub

    Private Sub OPTIONS0_MouseHover(sender As Object, e As EventArgs) Handles OPTIONS0.MouseHover
        If (objIniFile.GetString("Illustration Settings", "Options_MouseOver", "") = "") Then
            OPTIONS0.Image = New Bitmap(My.Resources.OPTIONS1)
        Else
            If File.Exists(objIniFile.GetString("Illustration Settings", "Options_MouseOver", "")) Then
                OPTIONS0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Options_MouseOver", ""))
            End If
        End If
    End Sub

    Private Sub OPTIONS0_MouseLeave(sender As Object, e As EventArgs) Handles OPTIONS0.MouseLeave
        If (objIniFile.GetString("Illustration Settings", "Options_button", "") = "") Then
            OPTIONS0.Image = New Bitmap(My.Resources.OPTIONS0)
        Else
            OPTIONS0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Options_button", ""))
        End If
    End Sub

    Private Sub EXIT0_MouseHover(sender As Object, e As EventArgs) Handles EXIT0.MouseHover
        If (objIniFile.GetString("Illustration Settings", "Exit_MouseOver", "") = "") Then
            EXIT0.Image = New Bitmap(My.Resources.EXIT1)
        Else
            If File.Exists(objIniFile.GetString("Illustration Settings", "Exit_MouseOver", "")) Then
                EXIT0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Exit_MouseOver", ""))
            End If

        End If
    End Sub

    Private Sub EXIT0_MouseLeave(sender As Object, e As EventArgs) Handles EXIT0.MouseLeave
        If (objIniFile.GetString("Illustration Settings", "Exit_button", "") = "") Then
            EXIT0.Image = New Bitmap(My.Resources.EXIT0)
        Else

            EXIT0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Exit_button", ""))
        End If

    End Sub

    Private Sub EXIT0_Click(sender As Object, e As EventArgs) Handles EXIT0.Click
        Try
            If File.Exists("TESVMP_Launcher1.exe") = True Then
                Shell("TESVMP_Launcher_updater.cmd", AppWinStyle.Hide)
                End
            End If
            If File.Exists("bg_remember.bat") = True Then

                Shell("bg_remember.bat", AppWinStyle.Hide)
                End
            End If
            End

        Catch
        Finally
        End Try
    End Sub
    Private Sub game_launcher()

        If File.Exists("skse_loader.exe") = False Then


            MsgBox("skse not found, download it here: http://skse.silverlock.org/", MsgBoxStyle.Critical, "Skse Not Found")

        Else
            '  Process.Start("skse_loader.exe")
            Dim psInfo As New System.Diagnostics.ProcessStartInfo("skse_loader.exe")
            psInfo.WindowStyle = ProcessWindowStyle.Hidden
            System.Diagnostics.Process.Start(psInfo)
            Me.WindowState = FormWindowState.Minimized
            Timer1.Start()
            Timer2.Start()
            'Now make it invisible (make it look like it went into the system tray)
            Me.Visible = False
            nfi.Visible = True

        End If
    End Sub
    Private Sub PLAY0_Click(sender As Object, e As EventArgs) Handles PLAY0.Click

        If File.Exists(My.Settings.Gamepath) = True Then
            Dim psInfo As New System.Diagnostics.ProcessStartInfo(My.Settings.Gamepath)
            psInfo.WindowStyle = ProcessWindowStyle.Hidden
            System.Diagnostics.Process.Start(psInfo)
            Me.WindowState = FormWindowState.Minimized
            Timer1.Start()
            Timer2.Start()
            'Now make it invisible (make it look like it went into the system tray)
            Me.Visible = False
            nfi.Visible = True
        Else
            game_launcher()
        End If

    End Sub

    Private Sub systemTray()

        nfi.Visible = True

    End Sub

    Private Sub OPTIONS0_Click(sender As Object, e As EventArgs) Handles OPTIONS0.Click

        Me.Opacity = 0.9
        settings_options.ShowDialog()
        Me.Opacity = 1

    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles AZAAXIN_INFO.Click

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If File.Exists("TESVMP_Launcher1.exe") = True Then
            Shell("TESVMP_Launcher_updater.cmd", AppWinStyle.Hide)
            End
        End If
        If System.IO.File.Exists("mario.bat") = True Then
            Shell("mario.bat", AppWinStyle.Hide)
            End
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub nfi_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nfi.MouseDoubleClick
        '  nfi.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '  Dim gametime As Integer

        p = Process.GetProcessesByName("TESV")
        If p.Count > 0 Then
            '    timeplayed.Text = 0 + 1
            If File.Exists("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat") = True Then

                Dim FILE_NAME As String = "C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat"
                Dim objReader4 As StreamReader
                Dim gametimes4 As Integer
                objReader4 = System.IO.File.OpenText(FILE_NAME)
                gametimes4 = objReader4.ReadToEnd
                objReader4.Close()

                gametimes4 = gametimes4 + 1
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat", False)
                file.WriteLine(gametimes4, False)
                file.Close()
                ' timeplayed.Text = gametimes4
                timeplayed.Text = Format(gametimes4 / 60, "0.00") & " hours"
            End If
        Else
            '  nfi.Visible = True
            '  Me.WindowState = FormWindowState.Maximized
            ' Me.Visible = True

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        p = Process.GetProcessesByName("TESV")
        If p.Count > 0 Then

        Else
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
        Me.Visible = True
    End Sub

    Private Sub StartSkyrimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartSkyrimToolStripMenuItem.Click
        game_launcher()

    End Sub

    Private Sub NormalMinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalMinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SystemTrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemTrayToolStripMenuItem.Click
        Me.Visible = False
        nfi.Visible = True
    End Sub

    Private Sub version1_Click(sender As Object, e As EventArgs) Handles version1.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.D Then

            Debug1.ShowDialog()
        End If
    End Sub

    Private Sub CustomButton1_Click(sender As Object, e As EventArgs) Handles CustomButton1.Click
        If (objIniFile.GetString("Custom Buttons", "CustomBtn1_url", "") = "") = True Then
            'MsgBox("File Doesn't Exist, please add one!")
        Else
            Dim startInfo As New ProcessStartInfo(objIniFile.GetString("Custom Buttons", "CustomBtn1_url", ""))
            startInfo.WorkingDirectory = Path.GetDirectoryName(objIniFile.GetString("Custom Buttons", "CustomBtn1_url", ""))
            Process.Start(startInfo)
        End If




    End Sub

    Private Sub CustomButton5_Click(sender As Object, e As EventArgs) Handles CustomButton5.Click

    End Sub

    Private Sub CustomButton1_MouseHover(sender As Object, e As EventArgs) Handles CustomButton1.MouseHover
        If (objIniFile.GetString("Custom Buttons", "CustomBtn1_MouseOver", "") = "") Then
            CustomButton1.Image = New Bitmap(My.Resources._1)
        Else
            If File.Exists(objIniFile.GetString("Custom Buttons", "CustomBtn1_MouseOver", "")) Then
                CustomButton1.Image = Image.FromFile(objIniFile.GetString("Custom Buttons", "CustomBtn1_MouseOver", ""))
            End If
        End If
    End Sub

    Private Sub CustomButton1_MouseLeave(sender As Object, e As EventArgs) Handles CustomButton1.MouseLeave
        If (objIniFile.GetString("Custom Buttons", "CustomBtn1_Image", "") = "") Then
            CustomButton1.Image = New Bitmap(My.Resources._1)
        Else

            CustomButton1.Image = Image.FromFile(objIniFile.GetString("Custom Buttons", "CustomBtn1_Image", ""))
        End If
    End Sub

    Private Sub PLAY0_MouseEnter(sender As Object, e As EventArgs) Handles PLAY0.MouseEnter
        If (objIniFile.GetString("Illustration Settings", "Play_MouseOver", "") = "") Then
            PLAY0.Image = New Bitmap(My.Resources.PLAY1)
        Else
            '   PLAY0.Image = Image.FromFile(My.Settings.Play_Btn_Mouseover)
            If File.Exists(objIniFile.GetString("Illustration Settings", "Play_MouseOver", "")) Then
                PLAY0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Play_MouseOver", ""))
            End If
        End If
    End Sub

    Private Sub OPTIONS0_MouseEnter(sender As Object, e As EventArgs) Handles OPTIONS0.MouseEnter
        If (objIniFile.GetString("Illustration Settings", "Options_MouseOver", "") = "") Then
            OPTIONS0.Image = New Bitmap(My.Resources.OPTIONS1)
        Else
            If File.Exists(objIniFile.GetString("Illustration Settings", "Options_MouseOver", "")) Then
                OPTIONS0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Options_MouseOver", ""))
            End If
        End If
    End Sub

    Private Sub EXIT0_MouseEnter(sender As Object, e As EventArgs) Handles EXIT0.MouseEnter
        If (objIniFile.GetString("Illustration Settings", "Exit_MouseOver", "") = "") Then
            EXIT0.Image = New Bitmap(My.Resources.EXIT1)
        Else
            If File.Exists(objIniFile.GetString("Illustration Settings", "Exit_MouseOver", "")) Then
                EXIT0.Image = Image.FromFile(objIniFile.GetString("Illustration Settings", "Exit_MouseOver", ""))
            End If

        End If
    End Sub

    Private Sub CustomButton1_MouseEnter(sender As Object, e As EventArgs) Handles CustomButton1.MouseEnter
        If (objIniFile.GetString("Custom Buttons", "CustomBtn1_MouseOver", "") = "") Then
            CustomButton1.Image = New Bitmap(My.Resources._1)
        Else
            If File.Exists(objIniFile.GetString("Custom Buttons", "CustomBtn1_MouseOver", "")) Then
                CustomButton1.Image = Image.FromFile(objIniFile.GetString("Custom Buttons", "CustomBtn1_MouseOver", ""))
            End If
        End If
    End Sub
End Class
'~*~WARNING: 38 too many END | NEXT | LOOP statements