Imports System
Imports System.IO
Imports System.Text
Imports TESVMP_Launcher.IniFile
Public Class Customize13
Dim objIniFile As New IniFile(My.Application.Info.DirectoryPath & "\SKSELauncher.ini")
Dim infile_loc As New String(My.Application.Info.DirectoryPath & "\SKSELauncher.ini")
Dim PlayX_pos As Integer
Dim PlayY_pos As Integer
Dim OptionsX_pos As Integer        ' = 0
Dim ExitX_pos As Integer        ' = 0
Dim OptionsY_pos As Integer        ' = 0
Dim ExitY_pos As Integer        ' = 0
Dim Button1Y As Integer        ' = 0
Dim Button1X As Integer        ' = 0
Dim CustomButton As Integer        ' = 0
Dim App1 As String
Private Sub RstBG_Click(sender As Object, e As EventArgs) Handles rstBG.Click
    Form1.BackgroundImage = My.Resources.Resources.AZAMODLOADER
    'Dim BG = System.IO.File.Exists("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\TESVMP_CustomBackground.png")
    'If BG = True Then
    '    Dim appPath As String = Application.StartupPath()
    
    '    '  System.IO.File.Delete("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\TESVMP_CustomBackground.png")
    '    File.Create(appPath & "\temp.txt").Dispose()
    '    ' My.Computer.FileSystem.RenameFile("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\TESVMP_CustomBackground.png", "TESVMP_CustomBackground_Temp.png")
    '    Dim fPath = appPath & "\bg_remember.bat"
    '    Dim afile As New IO.StreamWriter(fPath, True)
    '    afile.WriteLine("@echo off" + Environment.NewLine +
    '                    "IF EXIST temp.txt (" + Environment.NewLine +
    '                    "del C:\Users\%username%\AppData\Local\Skyrim\TESVMP_CustomBackground.png" + Environment.NewLine +
    '                    ") ELSE (" + Environment.NewLine +
    '                    "REM Dont blame, learned this by myself, uses this for custom background image- render_from_TESVMP_Launcher.exe" + Environment.NewLine +
    '                    ")")
    '    afile.Close()
    
    'Else
    '    MsgBox("could not found the target")
    'End If
    'My.Settings.varible = My.Resources.Resources.AZAMODLOADER.ToString
    ' My.Settings.Save()
    objIniFile.WriteString("Illustration Settings", "BackgroundImage", "")
    
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '   Button1.Enabled = False
    'Set the Filter.
    OpenFileDialog1.Filter = "PNG |*.png*"
    
    'Clear the file name
    OpenFileDialog1.FileName = ""
    
    'Show it
    Dim img As String
    Dim img2 As String
    If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
        ' Get the image name
        img = OpenFileDialog1.FileName
        img2 = img
        ' Create a New Bitmap And display it
        Form1.BackgroundImage = System.Drawing.Bitmap.FromFile(img)
        
        ' My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, "C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\TESVMP_CustomBackground.png", overwrite:=True)
        ' My.Settings.varible = img2
        'My.Settings.Save()
        objIniFile.WriteString("Illustration Settings", "BackgroundImage", img)
        
    End If
    '  img = My.Settings.varible
    
    '   Dim MyPicture As New Bitmap("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\TESVMP_CustomBackground.png")
    
    'If System.IO.File.Exists("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\TESVMP_CustomBackground.png") = True Then
    
    '    If MyPicture.Width = 628 And MyPicture.Height = 304 Then
    '        MyPicture.Dispose()
    '        MsgBox("error")
    '        Form1.BackgroundImage = System.Drawing.Image.FromFile("c:\users\" & System.Environment.UserName & "\appdata\local\skyrim\tesvmp_custombackground.png") 'custom background loaded
    '        Form1.BackgroundImage.Dispose()
    '    Else
    '        'nothing loaded
    '        MyPicture.Dispose()
    
    '  MsgBox(My.Settings.varible)
    
    ' Form1.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.varible)
    
    '    Form1.BackgroundImage.Dispose()
    'End If
    'Form1.BackgroundImage.Dispose()
    
    'Else
    '    '    'Nothing loaded
    
    'End If
    'If System.IO.File.Exists("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\TESVMP_CustomBackground.png") = True Then
    '    Threading.Thread.Sleep(500)
    '    Shell("TESVMP_Launcher_updater.cmd", AppWinStyle.Hide)
    'End If
    '  Form1.BackgroundImage = Image.FromFile(My.Settings.bg_image.ToString)
    
End Sub

Private Sub customize_Load(sender As Object, e As EventArgs)
    'If System.IO.File.Exists("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\TESVMP_CustomBackground.png") = True Then
    '    Button1.Enabled = False
    'End If
    Label4.Text = form1_X.Text + "x" + form1_Y.Text
    
End Sub

Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)
    
End Sub

Private Sub Form1_apply_formsize_Click(sender As Object, e As EventArgs) Handles form1_apply_formsize.Click
    If (form1_Y.Text < 10) = FALSE Then
        If (form1_X.Text < 10) = FALSE Then
            Form1.Size = New Size(form1_X.Text, form1_Y.Text)
            ' My.Settings.form1_sizeX = form1_X.Text
            ' My.Settings.Save()
            ' My.Settings.Reload()
            '  My.Settings.form1_sizeY = form1_Y.Text
            '  My.Settings.Save()
            '  My.Settings.Reload()
            objIniFile.WriteString("Settings", "Window_Size_Y", form1_Y.Text)
            objIniFile.WriteString("Settings", "Window_Size_X", form1_X.Text)
            Label4.Text = form1_X.Text + "x" + form1_Y.Text
        Else
            MsgBox("Window cannot be smaller than 10px")
        End If
    Else
        MsgBox("Window cannot be smaller than 10px")
    End If
    
End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    form1_X.Text = "612"
    form1_Y.Text = "266"
    Form1.Size = New Size(form1_X.Text, form1_Y.Text)
    objIniFile.WriteString("Settings", "Window_Size_Y", form1_Y.Text)
    objIniFile.WriteString("Settings", "Window_Size_X", form1_X.Text)
    'My.Settings.form1_sizeX = form1_X.Text
    '  My.Settings.Save()
    ' My.Settings.Reload()
    '  My.Settings.form1_sizeY = form1_Y.Text
    '   My.Settings.Save()
    '   My.Settings.Reload()
End Sub

Private Sub Play_button_picture_Click(sender As Object, e As EventArgs) Handles Play_button_picture.Click
    Dim Img As Bitmap
    OpenFileDialogPlay.Filter = "PNG |*.png*"
    
    'Clear the file name
    OpenFileDialogPlay.FileName = ""
    
    'Show it
    Dim Play_btn_picture As String = ""
    
    If OpenFileDialogPlay.ShowDialog(Me) = DialogResult.OK Then
        ' Get the image name
        Play_btn_picture = OpenFileDialogPlay.FileName
        
        Img = New Bitmap(Play_btn_picture)
        objIniFile.WriteString("Illustration Settings", "Play_button", Play_btn_picture)
        '  My.Settings.Play_btn = Play_btn_picture
        ' My.Settings.Save()
        'My.Settings.Reload()
        Form1.PLAY0.Size = New Size(Img.Width, Img.Height)
        objIniFile.WriteInteger("Illustration Settings", "Play_Size_x", Img.Width)
        objIniFile.WriteInteger("Illustration Settings", "Play_Size_y", Img.Height)
        'My.Settings.PLAY0_Size = Form1.PLAY0.Size
        'My.Settings.Save()
        'My.Settings.Reload()
    End If
    
End Sub

Private Sub OpenFileDialogPlay_FileOk(sender As Object, e As ComponentModel.CancelEventArgs)
    
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    Dim Img As Bitmap
    OpenFileDialog3Options.Filter = "PNG |*.png*"
    
    'Clear the file name
    OpenFileDialog3Options.FileName = ""
    
    'Show it
    Dim Play_btn_picture As String = ""
    
    If OpenFileDialog3Options.ShowDialog(Me) = DialogResult.OK Then
        ' Get the image name
        Play_btn_picture = OpenFileDialog3Options.FileName
        
        Img = New Bitmap(Play_btn_picture)
        objIniFile.WriteString("Illustration Settings", "Options_button", Play_btn_picture)
        '   My.Settings.Options_Btn = Play_btn_picture
        '  My.Settings.Save()
        '  My.Settings.Reload()
        Form1.OPTIONS0.Size = New Size(Img.Width, Img.Height)
        objIniFile.WriteInteger("Illustration Settings", "Options_Size_x", Img.Width)
        objIniFile.WriteInteger("Illustration Settings", "Options_Size_y", Img.Height)
        '  My.Settings.OPTIONS0_Size = Form1.OPTIONS0.Size
        '   My.Settings.Save()
        '   My.Settings.Reload()
    End If
End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    OpenFileDialogPlay_mouseover.Filter = "PNG |*.png*"
    
    'Clear the file name
    OpenFileDialogPlay_mouseover.FileName = ""
    
    'Show it
    Dim Play_btn_picture As String = ""
    
    If OpenFileDialogPlay_mouseover.ShowDialog(Me) = DialogResult.OK Then
        ' Get the image name
        Play_btn_picture = OpenFileDialogPlay_mouseover.FileName
        objIniFile.WriteString("Illustration Settings", "Play_MouseOver", Play_btn_picture)
        
        '  My.Settings.Play_Btn_Mouseover = Play_btn_picture
        ' My.Settings.Save()
    End If
End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    OpenFileDialog3Options_mouseover.Filter = "PNG |*.png*"
    
    'Clear the file name
    OpenFileDialog3Options_mouseover.FileName = ""
    
    'Show it
    Dim Play_btn_picture As String = ""
    
    If OpenFileDialog3Options_mouseover.ShowDialog(Me) = DialogResult.OK Then
        ' Get the image name
        Play_btn_picture = OpenFileDialog3Options_mouseover.FileName
        objIniFile.WriteString("Illustration Settings", "Options_MouseOver", Play_btn_picture)
        
        'My.Settings.Options_Btn_mouseover = Play_btn_picture
        ' My.Settings.Save()
    End If
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    Dim Img As Bitmap
    OpenFileDialog4Exit.Filter = "PNG |*.png*"
    
    'Clear the file name
    OpenFileDialog4Exit.FileName = ""
    
    'Show it
    Dim Play_btn_picture As String = ""
    
    If OpenFileDialog4Exit.ShowDialog(Me) = DialogResult.OK Then
        ' Get the image name
        Play_btn_picture = OpenFileDialog4Exit.FileName
        Img = New Bitmap(Play_btn_picture)
        objIniFile.WriteString("Illustration Settings", "Exit_button", Play_btn_picture)
        ' My.Settings.Exit_Btn = Play_btn_picture
        '  My.Settings.Save()
        '  My.Settings.Reload()
        Form1.EXIT0.Size = New Size(Img.Width, Img.Height)
        objIniFile.WriteInteger("Illustration Settings", "Exit_Size_x", Img.Width)
        objIniFile.WriteInteger("Illustration Settings", "Exit_Size_y", Img.Height)
        '  My.Settings.OPTIONS0_Size = Form1.OPTIONS0.Size
        '  My.Settings.Save()
        '  My.Settings.Reload()
    End If
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    OpenFileDialog4Exit_mouseover.Filter = "PNG |*.png*"
    
    'Clear the file name
    OpenFileDialog4Exit_mouseover.FileName = ""
    
    'Show it
    Dim Play_btn_picture As String = ""
    
    If OpenFileDialog4Exit_mouseover.ShowDialog(Me) = DialogResult.OK Then
        ' Get the image name
        Play_btn_picture = OpenFileDialog4Exit_mouseover.FileName
        objIniFile.WriteString("Illustration Settings", "Exit_MouseOver", Play_btn_picture)
        
        ' My.Settings.Exit_Btn_mouseover = Play_btn_picture
        ' My.Settings.Save()
    End If
End Sub

Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    If TextBox1.Text.Length < 1 Then
        TextBox1.Text = 0
    Else
        PlayX_pos = TextBox1.Text
    End If
    
    If Val(TextBox1.Text.Trim) > Val(form1_X.Text) Then
        TextBox1.Text = Nothing
        TextBox1.Text = form1_X.Text
        Form1.PLAY0.Location = New Point(PlayX_pos - 10, PlayY_pos - 10)
        objIniFile.WriteInteger("Settings", "Play_location_X", TextBox1.Text)
        '      My.Settings.Play_Location = Form1.PLAY0.Location
        '      My.Settings.Save()
    Else
        Form1.PLAY0.Location = New Point(PlayX_pos, PlayY_pos)
        '    My.Settings.Play_Location = Form1.PLAY0.Location
        objIniFile.WriteInteger("Settings", "Play_location_X", TextBox1.Text)
        '    My.Settings.Save()
    End If
    'My.Settings.PlayPosition1 = TextBox1.Text
    ' My.Settings.Save()
    ' My.Settings.Reload()
    'objIniFile.WriteString("Settings", "Textbox1", TextBox1.Text)
End Sub

Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    
    If TextBox2.Text.Length < 1 Then
        TextBox2.Text = 0
    Else
        PlayY_pos = TextBox2.Text
    End If
    
    If Val(TextBox2.Text.Trim) > Val(form1_Y.Text) Then
        TextBox2.Text = Nothing
        TextBox2.Text = form1_Y.Text
        Form1.PLAY0.Location = New Point(PlayX_pos - 10, PlayY_pos - 10)
        ' My.Settings.Play_Location = Form1.PLAY0.Location
        ' My.Settings.Save()
        objIniFile.WriteInteger("Settings", "Play_location_Y", TextBox2.Text)
    Else
        Form1.PLAY0.Location = New Point(PlayX_pos, PlayY_pos)
        ' My.Settings.Play_Location = Form1.PLAY0.Location
        'My.Settings.Save()
        objIniFile.WriteInteger("Settings", "Play_location_Y", TextBox2.Text)
    End If
    '  My.Settings.PlayPosition2 = TextBox2.Text
    ' My.Settings.Save()
    'My.Settings.Reload()
End Sub

Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
    
    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = TRUE
        End If
    End If
End Sub

Private Sub Settings_btn_pos_x_TextChanged(sender As Object, e As EventArgs) Handles Settings_btn_pos_x.TextChanged
    If Settings_btn_pos_x.Text.Length < 1 Then
        '       Settings_btn_pos_x.Text = 0
    Else
        OptionsX_pos = Settings_btn_pos_x.Text
    End If
    If Val(Settings_btn_pos_x.Text.Trim) > Val(form1_X.Text) Then
        Settings_btn_pos_x.Text = Nothing
        Settings_btn_pos_x.Text = form1_X.Text
        Form1.OPTIONS0.Location = New Point(OptionsX_pos - 10, OptionsY_pos - 10)
        ' My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        '  My.Settings.Save()
        '  My.Settings.Reload()
    Else
        Form1.OPTIONS0.Location = New Point(OptionsX_pos, OptionsY_pos)
        My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        My.Settings.Save()
        My.Settings.Reload()
    End If
    '      My.Settings.SettingsPosition1 = Settings_btn_pos_x.Text
    '     My.Settings.Save()
    '    My.Settings.Reload()
End Sub

Private Sub Settings_btn_pos_y_TextChanged(sender As Object, e As EventArgs) Handles Settings_btn_pos_y.TextChanged
    If Settings_btn_pos_y.Text.Length < 1 Then
        ' Settings_btn_pos_y.Text = 0
    Else
        OptionsY_pos = Settings_btn_pos_y.Text
    End If
    If Val(Settings_btn_pos_y.Text.Trim) > Val(form1_Y.Text) Then
        Settings_btn_pos_y.Text = Nothing
        Settings_btn_pos_y.Text = form1_Y.Text
        Form1.OPTIONS0.Location = New Point(OptionsX_pos - 10, OptionsY_pos - 10)
        '   My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        '  My.Settings.Save()
        '   My.Settings.Reload()
    Else
        Form1.OPTIONS0.Location = New Point(OptionsX_pos, OptionsY_pos)
        '   My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        '  My.Settings.Save()
        '   My.Settings.Reload()
    End If
    '   My.Settings.SettingsPosition2 = Settings_btn_pos_y.Text
    '   My.Settings.Save()
    '  My.Settings.Reload()
End Sub

Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = TRUE
        End If
    End If
End Sub

Private Sub Settings_btn_pos_x_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Settings_btn_pos_x.KeyPress
    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = TRUE
        End If
    End If
End Sub

Private Sub Settings_btn_pos_y_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Settings_btn_pos_y.KeyPress
    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = TRUE
        End If
    End If
End Sub

Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
    
    If TextBox6.Text.Length < 1 Then
        '        TextBox6.Text = 0
    Else
        ExitX_pos = TextBox6.Text
    End If
    If Val(TextBox6.Text.Trim) > Val(form1_X.Text) Then
        TextBox6.Text = Nothing
        TextBox6.Text = form1_X.Text
        Form1.EXIT0.Location = New Point(ExitX_pos - 10, ExitY_pos - 10)
        objIniFile.WriteString("Settings", "Exit_location_X", TextBox6.Text)
        ' My.Settings.Exit_location = Form1.EXIT0.Location
        '  My.Settings.Save()
        '  My.Settings.Reload()
    Else
        Form1.EXIT0.Location = New Point(ExitX_pos, ExitY_pos)
        objIniFile.WriteString("Settings", "Exit_location_X", TextBox6.Text)
        '   My.Settings.Exit_location = Form1.EXIT0.Location
        '    My.Settings.Save()
        '    My.Settings.Reload()
    End If
    ' My.Settings.SettingsPosition2 = TextBox6.Text
    'My.Settings.Save()
    ' My.Settings.Reload()
End Sub

Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = TRUE
        End If
    End If
End Sub

Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = TRUE
        End If
    End If
End Sub

Private Sub customize13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    If objIniFile.GetString("Special", "TestLauncher", "" = "True") Then
        Me.Size = New Point(648, 593)
    Else
        Me.Size = New Point(298, 593)
    End If
    
    Label4.Text = form1_X.Text + "x" + form1_Y.Text
    If (Form1.CustomButton1.Visible = True) Then
        CheckBox1.Checked = TRUE
    End If
    
    form1_X.Text = objIniFile.GetString("Settings", "Window_Size_X", "")
    form1_Y.Text = objIniFile.GetString("Settings", "Window_Size_Y", "")
    
    TextBox1.Text = objIniFile.GetString("Settings", "Play_location_X", "")
    TextBox2.Text = objIniFile.GetString("Settings", "Play_location_Y", "")
    
    TextBox9.Text = objIniFile.GetString("Settings", "Options_location_X", "")
    TextBox10e.Text = objIniFile.GetString("Settings", "Options_location_Y", "")
    TextBox6.Text = objIniFile.GetString("Settings", "Exit_location_X", "")
    TextBox5.Text = objIniFile.GetString("Settings", "Exit_location_Y", "")
    
    ''''
    '
    '/ test area
    ' MsgBox(Form1.PLAY0.Location.ToString & " | " & Form1.OPTIONS0.Location.ToString & " | " & Form1.EXIT0.Location.ToString & Environment.NewLine & infile_loc)
    
End Sub

Private Sub Button1_Click_1(sender As Object, e As EventArgs)
    
End Sub

Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
    
    If TextBox5.Text.Length < 1 Then
        '         TextBox5.Text = 0
    Else
        ExitY_pos = TextBox5.Text
    End If
    If Val(TextBox5.Text.Trim) > Val(form1_Y.Text) Then
        TextBox5.Text = Nothing
        TextBox5.Text = form1_Y.Text
        Form1.EXIT0.Location = New Point(ExitX_pos - 10, ExitY_pos - 10)
        objIniFile.WriteString("Settings", "Exit_location_Y", TextBox5.Text)
        '   My.Settings.Exit_location = Form1.EXIT0.Location
        '    My.Settings.Save()
        '   My.Settings.Reload()
    Else
        Form1.EXIT0.Location = New Point(ExitX_pos, ExitY_pos)
        'Form1.EXIT0.Location = My.Settings.Exit_location
        objIniFile.WriteString("Settings", "Exit_location_Y", TextBox5.Text)
        '    My.Settings.Save()
        '    My.Settings.Reload()
    End If
    '  My.Settings.ExitPosition2 = TextBox5.Text
    '   My.Settings.Save()
    'My.Settings.Reload()
End Sub

Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
    My.Settings.Play_btn = ""
    My.Settings.Play_Btn_Mouseover = ""
    My.Settings.Play_btn_Size = New Point(164, 43)
    My.Settings.PLAY0_Size = New Point(164, 43)
    'My.Settings.Play_Location = New Point(436, 21)
    My.Settings.Save()
    My.Settings.Reload()
    TextBox1.Text = "436"
    TextBox2.Text = "21"
End Sub

Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
    'My.Settings.OPTIONS_location = New Point(436, 95)
    My.Settings.Options_Btn = ""
    My.Settings.Options_Btn_mouseover = ""
    My.Settings.OPTIONS0_Size = New Point(164, 43)
    My.Settings.Save()
    My.Settings.Reload()
    TextBox9.Text = "436"
    TextBox10e.Text = "95"
End Sub

Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
    ' My.Settings.Exit_location = New Point(436, 164)
    My.Settings.EXIT0_Size = New Point(164, 43)
    My.Settings.Exit_Btn = ""
    My.Settings.Exit_Btn_mouseover = ""
    My.Settings.Save()
    My.Settings.Reload()
    TextBox6.Text = "436"
    TextBox5.Text = "164"
End Sub

Private Sub form1_X_TextChanged(sender As Object, e As EventArgs) Handles form1_X.TextChanged
    
End Sub

Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
    My.Settings.Opacity_Play = TextBox4.Text
    My.Settings.Save()
    My.Settings.Reload()
    'Form1.PLAY0.Opacity = TextBox4.Text
End Sub

Private Sub Settings_btn_opacity_TextChanged(sender As Object, e As EventArgs) Handles Settings_btn_opacity.TextChanged
    My.Settings.Opacity_Options = Settings_btn_opacity.Text
    My.Settings.Save()
    My.Settings.Reload()
End Sub

Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    My.Settings.Opacity_Exit = TextBox3.Text
    My.Settings.Save()
    My.Settings.Reload()
End Sub
Private Sub MenuBoxesfeed_add()
    If CustomButton = 1 Then
        Form1.CustomButton1.Visible = TRUE
        ' My.Settings.Custom1_visible = True JAG KOMMENTERADE DETTA DET SPARADES INNAN HÄR
        'My.Settings.Save()
        'My.Settings.Reload()
    End If
    CustomButton = 0
End Sub
Private Sub MenuBoxesfeed_remove()
    If CustomButton = 1 Then
        Form1.CustomButton1.Visible = FALSE
        
        '  My.Settings.Custom1_visible = False
        ' My.Settings.Save()
        ' My.Settings.Reload()
    End If
    CustomButton = 0
End Sub
Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
    If CheckBox1.Checked = TRUE Then
        CustomButton = 1
        MenuBoxesfeed_add()
        objIniFile.WriteString("Custom Buttons", "CustomBtn1_Enabled", True)
    Else
        CustomButton = 1
        objIniFile.WriteString("Custom Buttons", "CustomBtn1_Enabled", False)
        MenuBoxesfeed_remove()
    End If
End Sub

Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
    Dim Img As Bitmap
    OpenFileDialog_Custom1.Filter = "PNG |*.png*"
    
    'Clear the file name
    OpenFileDialog_Custom1.FileName = ""
    
    'Show it
    Dim custom1_btn_picture As String = ""
    
    If OpenFileDialog_Custom1.ShowDialog(Me) = DialogResult.OK Then
        ' Get the image name
        custom1_btn_picture = OpenFileDialog_Custom1.FileName
        
        Img = New Bitmap(custom1_btn_picture)
        
        '  My.Settings.CustomButton1_Image = custom1_btn_picture
        ' My.Settings.Save()
        '  My.Settings.Reload()
        Form1.CustomButton1.Size = New Size(Img.Width, Img.Height)
        objIniFile.WriteString("Custom Buttons", "CustomBtn1_Size_x", Img.Width)
        objIniFile.WriteString("Custom Buttons", "CustomBtn1_Size_y", Img.Height)
        objIniFile.WriteString("Custom Buttons", "CustomBtn1_Image", custom1_btn_picture)
    End If
End Sub

Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
    
    OpenFileDialog_Application.Filter = "Exe |*.exe*|All files (*.*)|*.*"
    
    'Clear the file name
    OpenFileDialog_Custom1.FileName = ""
    
    'Show it
    Dim custom1_btn_picture As String = ""
    
    If OpenFileDialog_Application.ShowDialog(Me) = DialogResult.OK Then
        
        App1 = OpenFileDialog_Application.FileName
        objIniFile.WriteString("Custom Buttons", "CustomBtn1_url", App1)
        
        ' My.Settings.Application_Buttton1 = App1
        '   My.Settings.Save()
        '    My.Settings.Reload()
        ' Form1.PLAY0.Size = New Size(Img.Width, Img.Height)
        
    End If
End Sub

Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
    If TextBox7.Text.Length < 1 Then
        TextBox7.Text = 0
    Else
        Button1X = TextBox7.Text
    End If
    
    If Val(TextBox7.Text.Trim) > Val(form1_X.Text) Then
        TextBox7.Text = Nothing
        TextBox7.Text = form1_X.Text
        Form1.CustomButton1.Location = New Point(Button1X - 10, Button1Y - 10)
        '  My.Settings.Button1 = Form1.CustomButton1.Location
        '  My.Settings.Save()
        objIniFile.WriteInteger("Custom Buttons", "CustomBtn1_location_X", Button1X)
    Else
        Form1.CustomButton1.Location = New Point(Button1X, Button1Y)
        ' My.Settings.Button1 = Form1.CustomButton1.Location
        'My.Settings.Save()
        objIniFile.WriteInteger("Custom Buttons", "CustomBtn1_location_X", Button1X)
    End If
End Sub

Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
    If TextBox8.Text.Length < 1 Then
        '    TextBox8.Text = 0
    Else
        Button1Y = TextBox8.Text
    End If
    
    If Val(TextBox8.Text.Trim) > Val(form1_Y.Text) Then
        TextBox8.Text = Nothing
        TextBox8.Text = form1_Y.Text
        Form1.CustomButton1.Location = New Point(Button1X - 10, Button1Y - 10)
        '  My.Settings.Button1 = Form1.CustomButton1.Location
        '  My.Settings.Save()
        objIniFile.WriteInteger("Custom Buttons", "CustomBtn1_location_Y", Button1Y)
    Else
        Form1.CustomButton1.Location = New Point(Button1X, Button1Y)
        '   My.Settings.Button1 = Form1.CustomButton1.Location
        '  My.Settings.Save()
        objIniFile.WriteInteger("Custom Buttons", "CustomBtn1_location_Y", Button1Y)
    End If
End Sub

Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs)
    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = TRUE
        End If
    End If
End Sub

Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs)
    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = TRUE
        End If
    End If
End Sub

Private Sub GroupBox10_Enter(sender As Object, e As EventArgs)
    
End Sub

Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
    If TextBox9.Text.Length < 1 Then
        TextBox9.Text = 0
    Else
        OptionsX_pos = TextBox9.Text
    End If
    If Val(TextBox9.Text.Trim) > Val(form1_X.Text) Then
        TextBox9.Text = Nothing
        TextBox9.Text = form1_X.Text
        Form1.OPTIONS0.Location = New Point(OptionsX_pos - 10, OptionsY_pos - 10)
        ' My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        ' My.Settings.Save()
        '  My.Settings.Reload()
        objIniFile.WriteInteger("Settings", "Options_location_X", TextBox9.Text)
    Else
        Form1.OPTIONS0.Location = New Point(OptionsX_pos, OptionsY_pos)
        objIniFile.WriteInteger("Settings", "Options_location_X", TextBox9.Text)
        '   My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        '    My.Settings.Save()
        '    My.Settings.Reload()
    End If
    '   My.Settings.SettingsPosition1 = TextBox9.Text
    '   My.Settings.Save()
    '   My.Settings.Reload()
End Sub

Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
    If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = TRUE
        End If
    End If
End Sub

Private Sub TextBox10e_TextChanged(sender As Object, e As EventArgs) Handles TextBox10e.TextChanged
    If TextBox10e.Text.Length < 1 Then
        TextBox10e.Text = 0
        ' Settings_btn_pos_y.Text = 0
    Else
        OptionsY_pos = TextBox10e.Text
    End If
    If Val(TextBox10e.Text.Trim) > Val(form1_Y.Text) Then
        TextBox10e.Text = Nothing
        TextBox10e.Text = form1_Y.Text
        Form1.OPTIONS0.Location = New Point(OptionsX_pos - 10, OptionsY_pos - 10)
        '    My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        '   My.Settings.Save()
        '   My.Settings.Reload()
        objIniFile.WriteInteger("Settings", "Options_location_Y", TextBox10e.Text)
    Else
        Form1.OPTIONS0.Location = New Point(OptionsX_pos, OptionsY_pos)
        objIniFile.WriteInteger("Settings", "Options_location_Y", TextBox10e.Text)
        '    My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        '   My.Settings.Save()
        '   My.Settings.Reload()
    End If
    '  My.Settings.SettingsPosition2 = TextBox10e.Text
    ' My.Settings.Save()
    '  My.Settings.Reload()
End Sub

Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
    If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
        
        objIniFile.WriteString("Custom Buttons", "CustomBtn1_url", FolderBrowserDialog1.SelectedPath)
        ' objIniFile.WriteString("Custom Buttons", "CustomBtn1_app", "")
    End If
    '  If (FolderBrowserDialog1.SelectedPath = "") = False Then
    '  Button12.Enabled = False
    ' End If
End Sub

Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
    objIniFile.WriteString("Custom Buttons", "CustomBtn1_url", TextBox10.Text)
End Sub

Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
    Dim Img As Bitmap
    OpenFileDialogPlay.Filter = "PNG |*.png*"
    
    'Clear the file name
    OpenFileDialogPlay.FileName = ""
    
    'Show it
    Dim Play_btn_picture As String = ""
    
    If OpenFileDialogPlay.ShowDialog(Me) = DialogResult.OK Then
        ' Get the image name
        Play_btn_picture = OpenFileDialogPlay.FileName
        
        Img = New Bitmap(Play_btn_picture)
        objIniFile.WriteString("Custom Buttons", "CustomBtn1_MouseOver", Play_btn_picture)
        '  My.Settings.Play_btn = Play_btn_picture
        ' My.Settings.Save()
        'My.Settings.Reload()
        ' Form1.PLAY0.Size = New Size(Img.Width, Img.Height)
        '  objIniFile.WriteInteger("Illustration Settings", "Play_Size_x", Img.Width)
        '    objIniFile.WriteInteger("Illustration Settings", "Play_Size_y", Img.Height)
        'My.Settings.PLAY0_Size = Form1.PLAY0.Size
        'My.Settings.Save()
        'My.Settings.Reload()
    End If
End Sub

Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    Process.Start("https://www.youtube.com/watch?v=aIDrEvJ8zq8")
    't tell me i have a bad taste.")
End Sub
End Class
