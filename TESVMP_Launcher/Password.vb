Imports TESVMP_Launcher.IniFile
Public Class Password
    Dim objIniFile As New IniFile(My.Application.Info.DirectoryPath & "\SKSELauncher.ini")


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.PasswordChar = "*"

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            If RadioButton2.Checked = True Then
                objIniFile.WriteString("Special", "Passwd", TextBox1.Text)
                objIniFile.WriteString("Special", "INI", "True")
            End If
            If RadioButton1.Checked = True Then
                objIniFile.WriteString("Special", "INI", "False")
                My.Settings.Password = TextBox1.Text
                My.Settings.Save()
                My.Settings.Reload()
            End If
        Else
            MsgBox("Doesn't match, try again!")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Password = ""
        My.Settings.Save()
        My.Settings.Reload()
        objIniFile.WriteString("Special", "Passwd", "")
    End Sub

    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class