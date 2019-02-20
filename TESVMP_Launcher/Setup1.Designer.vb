<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SSEEdit = New System.Windows.Forms.OpenFileDialog()
        Me.FNIS = New System.Windows.Forms.OpenFileDialog()
        Me.FNIS_button = New System.Windows.Forms.Button()
        Me.SSEEdit_Button = New System.Windows.Forms.Button()
        Me.SSEEdit_textbox = New System.Windows.Forms.TextBox()
        Me.FNIS_textbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(12, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 57)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "TESV: Skyrim"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(298, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 57)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "TESV: Skyrim Special Edition"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(467, 101)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 20)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gray
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(51, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(407, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(48, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Visible = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(12, 285)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 25)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(422, 285)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 25)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Get Started"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Image = Global.TESVMP_Launcher.My.Resources.Resources.VerisionChoose
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(496, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.TESVMP_Launcher.My.Resources.Resources.ezgif_2_133544a992
        Me.PictureBox1.Location = New System.Drawing.Point(12, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(496, 188)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(49, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Browse and select SKSE"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(409, 26)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "It only accepts skse_loader.exe,TESV.exe and Special Edition. Keep in mind it's c" &
    "ase" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive."
        Me.Label3.Visible = False
        '
        'SSEEdit
        '
        Me.SSEEdit.FileName = "OpenFileDialog2"
        '
        'FNIS
        '
        Me.FNIS.FileName = "OpenFileDialog2"
        '
        'FNIS_button
        '
        Me.FNIS_button.Location = New System.Drawing.Point(467, 226)
        Me.FNIS_button.Name = "FNIS_button"
        Me.FNIS_button.Size = New System.Drawing.Size(30, 23)
        Me.FNIS_button.TabIndex = 25
        Me.FNIS_button.Text = "..."
        Me.FNIS_button.UseVisualStyleBackColor = True
        Me.FNIS_button.Visible = False
        '
        'SSEEdit_Button
        '
        Me.SSEEdit_Button.Location = New System.Drawing.Point(467, 197)
        Me.SSEEdit_Button.Name = "SSEEdit_Button"
        Me.SSEEdit_Button.Size = New System.Drawing.Size(30, 23)
        Me.SSEEdit_Button.TabIndex = 24
        Me.SSEEdit_Button.Text = "..."
        Me.SSEEdit_Button.UseVisualStyleBackColor = True
        Me.SSEEdit_Button.Visible = False
        '
        'SSEEdit_textbox
        '
        Me.SSEEdit_textbox.Location = New System.Drawing.Point(51, 199)
        Me.SSEEdit_textbox.Name = "SSEEdit_textbox"
        Me.SSEEdit_textbox.Size = New System.Drawing.Size(410, 20)
        Me.SSEEdit_textbox.TabIndex = 26
        Me.SSEEdit_textbox.Visible = False
        '
        'FNIS_textbox
        '
        Me.FNIS_textbox.Location = New System.Drawing.Point(51, 226)
        Me.FNIS_textbox.Name = "FNIS_textbox"
        Me.FNIS_textbox.Size = New System.Drawing.Size(410, 20)
        Me.FNIS_textbox.TabIndex = 27
        Me.FNIS_textbox.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-1, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "SSEEdit:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "FNIS:"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(209, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "-------OPTIONAL-------"
        Me.Label6.Visible = False
        '
        'Setup1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 322)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FNIS_textbox)
        Me.Controls.Add(Me.SSEEdit_textbox)
        Me.Controls.Add(Me.FNIS_button)
        Me.Controls.Add(Me.SSEEdit_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Setup1"
        Me.ShowIcon = False
        Me.Text = "Setup"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SSEEdit As OpenFileDialog
    Friend WithEvents FNIS As OpenFileDialog
    Friend WithEvents FNIS_button As Button
    Friend WithEvents SSEEdit_Button As Button
    Friend WithEvents SSEEdit_textbox As TextBox
    Friend WithEvents FNIS_textbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
