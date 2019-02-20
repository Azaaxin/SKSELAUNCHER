Imports TESVMP_Launcher.IniFile

Public Class Protection
    Dim objIniFile As New IniFile(My.Application.Info.DirectoryPath & "\SKSELauncher.ini")
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.PasswordChar = "*"
    End Sub

    Private Sub Protection_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If objIniFile.GetString("Special", "INI", "") = "True" Then

            If TextBox1.Text = objIniFile.GetString("Special", "Passwd", "") Then
                Form1.Show()
                Me.Hide()
            End If
        Else
            If TextBox1.Text = My.Settings.Password Then
                Form1.Show()
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub Protection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If objIniFile.GetString("Special", "INI", "") = "True" Then

                If TextBox1.Text = objIniFile.GetString("Special", "Passwd", "") Then
                    Form1.Show()
                    Me.Hide()
                End If
            Else
                If TextBox1.Text = My.Settings.Password Then
                    Form1.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub
End Class