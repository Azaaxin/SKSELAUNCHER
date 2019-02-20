Namespace Namespace1
    Public Class PluginEngine
        Dim Engine As Integer = 1002
    End Class
End Namespace

Public Sub ChangedBoxes()
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
Public Sub PLuginLoader()
    For x As Integer = 0 To lines.GetUpperBound(0)

        lineArray.Add(lines(x))
    Next


    For x = 2 To lineArray.Count - 1


        'CREATE NEW CHECKBOX CONTROL ARRAY
        Dim MyCheckboxes(x) As CheckBox

        'LOOP THROUGH THE LAYERS AND CREATE A CHECKBOX FOR EACH
        Dim i As Integer
        Dim Ypos As Integer



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
            lineArray.Item(x) = lineArray.Item(x).Remove(0, 1)
            MyCheckboxes(i).BackColor = Color.Red
            MyCheckboxes(i).Text = lineArray.Item(x)
        Else
            MyCheckboxes(i).Checked = True
            MyCheckboxes(i).Text = lineArray.Item(x)
        End If
        AddHandler MyCheckboxes(i).CheckedChanged, AddressOf Checkbox_onCheckedChanged
    Next
End Sub