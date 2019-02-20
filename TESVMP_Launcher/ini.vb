Imports System.Runtime.InteropServices
Imports System.Text
Imports TESVMP_Launcher.IniFile

Public Class ini
    Dim objIniFile As New IniFile(My.Application.Info.DirectoryPath & "\SKSELaucher.ini")

    ' <DllImport("kernel32")>
    ' Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    ' End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        objIniFile.WriteString("Settings", "Textbox1", TextBox1.Text)
        objIniFile.WriteString("Settings", "Textbox2", TextBox2.Text)
        objIniFile.WriteString("Settings", "Textbox3", TextBox3.Text)
        objIniFile.WriteString("Settings", "CheckBox1", CheckBox1.Checked)
        objIniFile.WriteString("Settings", "CheckBox2", CheckBox2.Checked)
        objIniFile.WriteString("Settings", "CheckBox3", CheckBox3.Checked)

    End Sub

    Private Sub ini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = objIniFile.GetString("Settings", "Textbox1", "")
        TextBox2.Text = objIniFile.GetString("Settings", "Textbox2", "")
        TextBox3.Text = objIniFile.GetString("Settings", "Textbox3", "")
        CheckBox1.Checked = objIniFile.GetString("Settings", "CheckBox1", "False")
        CheckBox2.Checked = objIniFile.GetString("Settings", "CheckBox2", "False")
        CheckBox3.Checked = objIniFile.GetString("Settings", "CheckBox3", "False")
        ' CheckBox2.Checked = objIniFile.GetBoolean("Settings", "CheckBox2", CheckBox2.Checked)
        '  objIniFile.GetBoolean("Settings", "CheckBox3", CheckBox3.Checked)
    End Sub
End Class
