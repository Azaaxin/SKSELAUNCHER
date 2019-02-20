Imports System
Imports System.IO
Imports System.Text

Public Class customize13
    Dim PlayX_pos As Integer
    Dim PlayY_pos As Integer
    Dim OptionsX_pos As Integer = 0
    Dim ExitX_pos As Integer = 0
    Dim OptionsY_pos As Integer = 0
    Dim ExitY_pos As Integer = 0
    Private Sub rstBG_Click(sender As Object, e As EventArgs)
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
        My.Settings.varible = My.Resources.Resources.AZAMODLOADER.ToString
        My.Settings.Save()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
            '       PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)

            ' My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, "C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\TESVMP_CustomBackground.png", overwrite:=True)
            My.Settings.varible = img2
            My.Settings.Save()
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
        Form1.BackgroundImage = System.Drawing.Image.FromFile(My.Settings.varible)

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

    Private Sub form1_apply_formsize_Click(sender As Object, e As EventArgs)
        Form1.Size = New Size(form1_X.Text, form1_Y.Text)
        My.Settings.form1_sizeX = form1_X.Text
        My.Settings.Save()
        My.Settings.Reload()
        My.Settings.form1_sizeY = form1_Y.Text
        My.Settings.Save()
        My.Settings.Reload()
        Label4.Text = form1_X.Text + "x" + form1_Y.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        form1_X.Text = "612"
        form1_Y.Text = "266"
        Form1.Size = New Size(form1_X.Text, form1_Y.Text)

    End Sub

    Private Sub Play_button_picture_Click(sender As Object, e As EventArgs)
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
            My.Settings.Play_btn = Play_btn_picture
            My.Settings.Save()
            My.Settings.Reload()
            Form1.PLAY0.Size = New Size(Img.Width, Img.Height)
            My.Settings.PLAY0_Size = Form1.PLAY0.Size
            My.Settings.Save()
            My.Settings.Reload()
        End If


    End Sub

    Private Sub OpenFileDialogPlay_FileOk(sender As Object, e As ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim Img As Bitmap
        OpenFileDialogOptions.Filter = "PNG |*.png*"

        'Clear the file name  
        OpenFileDialogOptions.FileName = ""



        'Show it  
        Dim Play_btn_picture As String = ""

        If OpenFileDialogOptions.ShowDialog(Me) = DialogResult.OK Then
            ' Get the image name  
            Play_btn_picture = OpenFileDialogOptions.FileName

            Img = New Bitmap(Play_btn_picture)
            My.Settings.Options_Btn = Play_btn_picture
            My.Settings.Save()
            My.Settings.Reload()
            Form1.OPTIONS0.Size = New Size(Img.Width, Img.Height)
            My.Settings.OPTIONS0_Size = Form1.OPTIONS0.Size
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        OpenFileDialogPlay_mouseover.Filter = "PNG |*.png*"

        'Clear the file name  
        OpenFileDialogPlay_mouseover.FileName = ""


        'Show it  
        Dim Play_btn_picture As String = ""

        If OpenFileDialogPlay_mouseover.ShowDialog(Me) = DialogResult.OK Then
            ' Get the image name  
            Play_btn_picture = OpenFileDialogPlay_mouseover.FileName


            My.Settings.Play_Btn_Mouseover = Play_btn_picture
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        OpenFileDialogOptions_mouseover.Filter = "PNG |*.png*"

        'Clear the file name  
        OpenFileDialogOptions_mouseover.FileName = ""


        'Show it  
        Dim Play_btn_picture As String = ""

        If OpenFileDialogOptions_mouseover.ShowDialog(Me) = DialogResult.OK Then
            ' Get the image name  
            Play_btn_picture = OpenFileDialogOptions_mouseover.FileName


            My.Settings.Options_Btn_mouseover = Play_btn_picture
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim Img As Bitmap
        OpenFileDialogExit.Filter = "PNG |*.png*"

        'Clear the file name  
        OpenFileDialogExit.FileName = ""


        'Show it  
        Dim Play_btn_picture As String = ""

        If OpenFileDialogExit.ShowDialog(Me) = DialogResult.OK Then
            ' Get the image name  
            Play_btn_picture = OpenFileDialogExit.FileName
            Img = New Bitmap(Play_btn_picture)

            My.Settings.Exit_Btn = Play_btn_picture
            My.Settings.Save()
            My.Settings.Reload()
            Form1.EXIT0.Size = New Size(Img.Width, Img.Height)
            My.Settings.OPTIONS0_Size = Form1.OPTIONS0.Size
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        OpenFileDialogExit_mouseover.Filter = "PNG |*.png*"

        'Clear the file name  
        OpenFileDialogExit_mouseover.FileName = ""


        'Show it  
        Dim Play_btn_picture As String = ""

        If OpenFileDialogExit_mouseover.ShowDialog(Me) = DialogResult.OK Then
            ' Get the image name  
            Play_btn_picture = OpenFileDialogExit_mouseover.FileName


            My.Settings.Exit_Btn_mouseover = Play_btn_picture
            My.Settings.Save()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        If TextBox1.Text.Length < 1 Then
            TextBox1.Text = 0
        Else
            PlayX_pos = TextBox1.Text
        End If

        Form1.PLAY0.Location = New Point(PlayX_pos, PlayY_pos)
        My.Settings.Play_Location = Form1.PLAY0.Location
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)


        If TextBox2.Text.Length < 1 Then
            TextBox2.Text = 0
        Else
            PlayY_pos = TextBox2.Text
        End If

        Form1.PLAY0.Location = New Point(PlayX_pos, PlayY_pos)
        My.Settings.Play_Location = Form1.PLAY0.Location
        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Settings_btn_pos_x_TextChanged(sender As Object, e As EventArgs)
        If Settings_btn_pos_x.Text.Length < 1 Then
            Settings_btn_pos_x.Text = 0
        Else
            OptionsX_pos = Settings_btn_pos_x.Text
        End If

        Form1.OPTIONS0.Location = New Point(OptionsX_pos, OptionsY_pos)
        My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub Settings_btn_pos_y_TextChanged(sender As Object, e As EventArgs)
        If Settings_btn_pos_y.Text.Length < 1 Then
            Settings_btn_pos_y.Text = 0
        Else
            OptionsY_pos = Settings_btn_pos_y.Text
        End If

        Form1.OPTIONS0.Location = New Point(OptionsX_pos, OptionsY_pos)
        My.Settings.OPTIONS_location = Form1.OPTIONS0.Location
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Settings_btn_pos_x_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Settings_btn_pos_y_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

        If TextBox6.Text.Length < 1 Then
            TextBox6.Text = 0
        Else
            ExitY_pos = TextBox6.Text
        End If

        Form1.EXIT0.Location = New Point(ExitX_pos, ExitY_pos)
        My.Settings.Exit_location = Form1.EXIT0.Location
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub customize13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class