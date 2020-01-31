Public Class Azaaxin
Dim drag As Boolean
Dim mousex As Integer
Dim mousey As Integer
Private Sub Azaaxin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    
End Sub
Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
    drag = TRUE        'Sets the variable drag to true.
    mousex = Windows.Forms.Cursor.Position.X - Me.Left        'Sets variable mousex
    mousey = Windows.Forms.Cursor.Position.Y - Me.Top        'Sets variable mousey
End Sub

Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    'If drag is set to true then move the form accordingly.
    If drag Then
        Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        Me.Left = Windows.Forms.Cursor.Position.X - mousex
    End If
End Sub

Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
    drag = FALSE        'Sets drag to false, so the form does not move according to the code in MouseMove
End Sub

Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    
End Sub

Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
    
End Sub

Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
    Me.Hide()
End Sub

Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    
End Sub

Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
    
End Sub

Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    Debug1.ShowDialog()
End Sub
End Class
