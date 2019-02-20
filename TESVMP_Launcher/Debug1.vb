Imports System.ComponentModel
Imports System.IO
Imports System.Math
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Net
Imports TESVMP_Launcher.IniFile
Public Class Debug1
    Private WithEvents httpclient As WebClient
    ' Dim MyCheckboxes(4) As CheckBox
    Dim objIniFile As New IniFile(My.Application.Info.DirectoryPath & "\SKSELauncher.ini")
    Dim lines() As String = IO.File.ReadAllLines("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\plugins.txt")
    Dim Commandon As String
    Dim gametimes4 As Integer
    Dim objReader1 As New System.IO.StreamReader("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim Special Edition\gametime.dat")
    Dim gametimes1 As Integer = objReader1.ReadToEnd
    Dim FILE_NAME As String = "C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat"
    Dim objReader5 As StreamReader
    Dim gametimes5 As Integer
    Dim lineArray As New ArrayList()
    Dim ifbeenrunning As Boolean = False
    Dim x As Integer
    Dim drag As Boolean
    Dim steamdir As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)

    Dim mousex As Integer
    Dim mousey As Integer



    Private Sub Checkbox_onCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim MyCheckboxes As CheckBox = DirectCast(sender, CheckBox)
        Dim annie As Integer = 0

        For x = 2 To lineArray.Count - 1
            annie = annie + 1
            If MyCheckboxes.Name = "MyCheckboxes" & annie Then
                If MyCheckboxes.Checked Then
                    Dim Lines() As String = System.IO.File.ReadAllLines("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\plugins.txt")
                    Lines(annie) = "" & lineArray.Item(annie)
                    System.IO.File.WriteAllLines("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\plugins.txt", Lines)

                    MyCheckboxes.BackColor = Color.Green
                    '  My.Computer.FileSystem.WriteAllText("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\plugins.txt", lineArray.Item(annie).insert(1, "/"), True)
                Else
                    Dim Lines() As String = System.IO.File.ReadAllLines("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\plugins.txt")
                    Lines(annie) = "/" & lineArray.Item(annie)
                    System.IO.File.WriteAllLines("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\plugins.txt", Lines)

                    MyCheckboxes.BackColor = Color.Red
                    '  My.Computer.FileSystem.WriteAllText("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\plugins.txt", lineArray.Item(annie).insert(1, "/"), True)
                End If



            End If
        Next


    End Sub

    Private Sub PLuginloader()

        If ifbeenrunning = True Then
        Else
            For x = 0 To lines.GetUpperBound(0)

                ifbeenrunning = False
                lineArray.Add(lines(x))

            Next



            'LOOP THROUGH THE LAYERS AND CREATE A CHECKBOX FOR EACH
            Dim i As Integer
            Dim Ypos As Integer

            For x = 2 To lineArray.Count - 1


                'CREATE NEW CHECKBOX CONTROL ARRAY
                Dim MyCheckboxes(x) As CheckBox



                'if the number of layers is 5 our Layer array will be 0 to 4

                MyCheckboxes(i) = New CheckBox
                Panel1.Controls.Add(MyCheckboxes(i))
                'CYCLE THROUGH AND POPULATE CHECKBOXES

                MyCheckboxes(i).Location = New Point(10, Ypos) ' X LOCATION NEVER CHANGES, Y POSITION DOWN BY 25
                Ypos = Ypos + 25
                MyCheckboxes(i).Visible = True
                MyCheckboxes(i).Name = "MyCheckboxes" & x
                MyCheckboxes(i).Size = New Size(300, 20)
                If InStr(lineArray.Item(x), "/") > 0 Then
                    MyCheckboxes(i).Checked = False
                    lineArray.Item(x) = lineArray.Item(x).Remove(4, 1)
                    MyCheckboxes(i).BackColor = Color.Red
                    MyCheckboxes(i).Text = lineArray.Item(x)
                Else
                    MyCheckboxes(i).Checked = True
                    MyCheckboxes(i).Text = lineArray.Item(x)
                    MyCheckboxes(i).BackColor = Color.Green
                End If
                AddHandler MyCheckboxes(i).CheckedChanged, AddressOf Checkbox_onCheckedChanged
            Next
        End If
        ifbeenrunning = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Debug1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
        Command.Parent = Me
        Command.Location = New Point(3, 21)
        Command.Size = New Size(803, 422)
        ListBox1.Parent = Me
        ListBox1.Location = New Point(3, 21)
        ListBox1.Size = New Size(803, 422)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Commandon = TextBox1.Text
            e.SuppressKeyPress = True
            Panel1.BackColor = Color.Black
            Panel1.Visible = False
            ListBox1.Visible = False
            ListBox1.Items.Clear()
            'CommandWindow.Clear()
            Command.Visible = False
            '  CommandWindow.Visible = False
            Panel1.Controls.Clear()

            If TextBox1.Text = "ini" Then
                ini.ShowDialog()
            End If

            If TextBox1.Text = "help" Then

                Command.Text = "
                help
                show.plugin.list {sse/skyrim}
                launcher.update
                launcher.checkupdate
                end.update
                show.options
                show.playtime
                edit.playtime
                show.all.plugins {esm/esp/bsa}
                show.all.files
                test.service
                "
                Command.Visible = True

            End If
            If TextBox1.Text = "test.service" Then
                Command.Text = "
                Set Password type: passwd
                Enable extended options in Customize Launcher not released yet! type: O1NMs9w 
                "
                Command.Visible = True
            End If
            If TextBox1.Text = "O1NMs9w" Then
                objIniFile.WriteString("Special", "TestLauncher", "True")
            End If
            If TextBox1.Text = "passwd" Then
                Password.ShowDialog()
            End If
            If TextBox1.Text = "show.options" Then

                    settings_options.ShowDialog()

                End If
                If TextBox1.Text = "show.all.plugins" Then
                    ListBox1.Visible = True
                    Dim Folder As New IO.DirectoryInfo(steamdir + "\steamapps\common\Skyrim\data\")

                    For Each esm As IO.FileInfo In Folder.GetFiles("*.esm*", IO.SearchOption.AllDirectories)
                        ListBox1.Items.Add(esm.FullName)
                    Next
                    For Each esp As IO.FileInfo In Folder.GetFiles("*.esp*", IO.SearchOption.AllDirectories)
                        ListBox1.Items.Add(esp.FullName)
                    Next
                    For Each bsa As IO.FileInfo In Folder.GetFiles("*.bsa*", IO.SearchOption.AllDirectories)
                        ListBox1.Items.Add(bsa.FullName)
                    Next

                End If
                If TextBox1.Text = "show.all.plugins esm" Then
                    ListBox1.Visible = True
                    Dim Folder As New IO.DirectoryInfo(steamdir + "\steamapps\common\Skyrim\data\")

                    For Each esm As IO.FileInfo In Folder.GetFiles("*.esm*", IO.SearchOption.AllDirectories)
                        ListBox1.Items.Add(esm.FullName)
                    Next

                End If
                If TextBox1.Text = "show.all.plugins esp" Then
                    ListBox1.Visible = True
                    Dim Folder As New IO.DirectoryInfo(steamdir + "\steamapps\common\Skyrim\data\")


                    For Each esp As IO.FileInfo In Folder.GetFiles("*.esp*", IO.SearchOption.AllDirectories)
                        ListBox1.Items.Add(esp.FullName)
                    Next
                End If
                If TextBox1.Text = "show.all.plugins bsa" Then
                    ListBox1.Visible = True
                    Dim Folder As New IO.DirectoryInfo(steamdir + "\steamapps\common\Skyrim\data\")
                    For Each bsa As IO.FileInfo In Folder.GetFiles("*.bsa*", IO.SearchOption.AllDirectories)
                        ListBox1.Items.Add(bsa.FullName)
                    Next
                End If
                If TextBox1.Text = "show.all.files" Then
                    ListBox1.Visible = True
                    Dim Folder As New IO.DirectoryInfo(steamdir + "\steamapps\common\Skyrim\data\")
                    For Each files As IO.FileInfo In Folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
                        ListBox1.Items.Add(files.FullName)
                    Next
                End If
                If TextBox1.Text = "show.plugin.list" Then
                    PLuginloader()
                    Panel1.BackColor = Color.White
                    Panel1.Visible = True
                End If
                If TextBox1.Text = "launcher.update" Then
                    Try


                        httpclient = New WebClient
                        AddHandler httpclient.DownloadFileCompleted, AddressOf Downloaded
                        httpclient.DownloadFileAsync(New Uri("http: //leso-notes.dlinkddns.com/TESVMP_Launcher.exe"), ("TESVMP_Launcher1.exe"))

                    Catch
                    Finally
                    End Try
                End If
                If TextBox1.Text = "end.update" Then

                    If Form1.IsConnected() = True Then
                        If System.IO.File.Exists("TESVMP_Launcher1.exe") = True Then
                            Shell("TESVMP_Launcher_updater.cmd", AppWinStyle.Hide)
                            End
                        Else
                            Command.Visible = True
                            Command.Text = "You need to download the update first!"
                        End If
                    End If
                End If
                If TextBox1.Text = "launcher.checkupdate" Then
                    If Form1.IsConnected() = True Then
                        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://leso-notes.dlinkddns.com/TESVMP_version.txt")
                        Dim response As System.Net.HttpWebResponse = request.GetResponse()
                        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                        Dim newestversion As String = sr.ReadToEnd()
                        Dim currentversion As String = Application.ProductVersion
                        If newestversion.Contains(currentversion) Then
                            Command.Text = ("You have the current version!")

                        Else

                            Command.Text = ("New version available")

                        End If
                        Command.Visible = True
                    End If
                End If
                If TextBox1.Text = "show.playtime" Then
                    Command.Visible = True
                    If System.IO.File.Exists("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat") = True Then


                        objReader5 = System.IO.File.OpenText(FILE_NAME)
                        gametimes5 = objReader5.ReadToEnd
                        objReader5.Close()
                        Command.Text = "Skyrim: " & Format(gametimes5 / 60, "0.00") & " hours"

                    Else
                        System.IO.File.AppendAllText("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat", "0" & vbCrLf)
                        Dim objReader1 As New System.IO.StreamReader("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim\gametime.dat")
                        Dim gametimes1 As Integer = objReader1.ReadToEnd
                        objReader1.Close()




                    End If
                    If System.IO.File.Exists("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim Special Edition\gametime.dat") = True Then

                        Dim FILE_NAME As String = "C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim Special Edition\gametime.dat"
                        Dim objReader4 As StreamReader

                        objReader4 = System.IO.File.OpenText(FILE_NAME)
                        gametimes4 = objReader4.ReadToEnd
                        objReader4.Close()
                        Command.Text = "Skyrim Special Edition: " & Format(gametimes4 / 60, "0.00") & " hours"

                    Else
                        System.IO.File.AppendAllText("C:\Users\" & System.Environment.UserName & "\AppData\Local\Skyrim Special Edition\gametime.dat", "0" & vbCrLf)

                        objReader1.Close()




                    End If
                    Command.Text = "Skyrim Special Edition: " & Format(gametimes4 / 60, "0.00") & " hours
" & "Skyrim: " & Format(gametimes5 / 60, "0.00") & " hours"
                End If
                If Commandon.Contains("edit.playtime") Then
                    Dim splits() As String = Split(Commandon)

                End If
                TextBox1.Text = Nothing
            End If

    End Sub

    Private Sub Downloaded()
        Command.Visible = True
        Command.Text = "Update Sucessfull
        Finish it by typing: end.update"


    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        End
    End Sub

    Private Sub Command_TextChanged(sender As Object, e As EventArgs) Handles Command.TextChanged

    End Sub

    Private Sub Debug1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Debug1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Debug1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class