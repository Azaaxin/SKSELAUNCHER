<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PLAY0 = New System.Windows.Forms.PictureBox()
        Me.OPTIONS0 = New System.Windows.Forms.PictureBox()
        Me.EXIT0 = New System.Windows.Forms.PictureBox()
        Me.AZAAXIN_INFO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.version1 = New System.Windows.Forms.Label()
        Me.UpdateMessage = New System.Windows.Forms.Label()
        Me.nfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartSkyrimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalMinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timeplayed = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CustomButton1 = New System.Windows.Forms.PictureBox()
        Me.CustomButton2 = New System.Windows.Forms.PictureBox()
        Me.CustomButton3 = New System.Windows.Forms.PictureBox()
        Me.CustomButton4 = New System.Windows.Forms.PictureBox()
        Me.CustomButton5 = New System.Windows.Forms.PictureBox()
        CType(Me.PLAY0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPTIONS0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXIT0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.CustomButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PLAY0
        '
        Me.PLAY0.BackColor = System.Drawing.Color.Transparent
        Me.PLAY0.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Global.TESVMP_Launcher.My.MySettings.Default, "Play_btn", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PLAY0.DataBindings.Add(New System.Windows.Forms.Binding("Size", Global.TESVMP_Launcher.My.MySettings.Default, "PLAY0_Size", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PLAY0.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.TESVMP_Launcher.My.MySettings.Default, "Play_Location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PLAY0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TESVMP_Launcher.My.MySettings.Default, "Opacity_Play", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PLAY0.Image = Global.TESVMP_Launcher.My.Resources.Resources.PLAY0
        Me.PLAY0.ImageLocation = Global.TESVMP_Launcher.My.MySettings.Default.Play_btn
        Me.PLAY0.Location = Global.TESVMP_Launcher.My.MySettings.Default.Play_Location
        Me.PLAY0.Name = "PLAY0"
        Me.PLAY0.Size = Global.TESVMP_Launcher.My.MySettings.Default.PLAY0_Size
        Me.PLAY0.TabIndex = 0
        Me.PLAY0.TabStop = False
        Me.PLAY0.Text = Global.TESVMP_Launcher.My.MySettings.Default.Opacity_Play
        '
        'OPTIONS0
        '
        Me.OPTIONS0.BackColor = System.Drawing.Color.Transparent
        Me.OPTIONS0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OPTIONS0.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Global.TESVMP_Launcher.My.MySettings.Default, "Options_Btn", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OPTIONS0.DataBindings.Add(New System.Windows.Forms.Binding("Size", Global.TESVMP_Launcher.My.MySettings.Default, "OPTIONS0_Size", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OPTIONS0.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.TESVMP_Launcher.My.MySettings.Default, "OPTIONS_location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OPTIONS0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TESVMP_Launcher.My.MySettings.Default, "Opacity_Options", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.OPTIONS0.Image = Global.TESVMP_Launcher.My.Resources.Resources.OPTIONS0
        Me.OPTIONS0.ImageLocation = Global.TESVMP_Launcher.My.MySettings.Default.Options_Btn
        Me.OPTIONS0.Location = Global.TESVMP_Launcher.My.MySettings.Default.OPTIONS_location
        Me.OPTIONS0.Name = "OPTIONS0"
        Me.OPTIONS0.Size = Global.TESVMP_Launcher.My.MySettings.Default.OPTIONS0_Size
        Me.OPTIONS0.TabIndex = 1
        Me.OPTIONS0.TabStop = False
        Me.OPTIONS0.Text = Global.TESVMP_Launcher.My.MySettings.Default.Opacity_Options
        '
        'EXIT0
        '
        Me.EXIT0.BackColor = System.Drawing.Color.Transparent
        Me.EXIT0.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Global.TESVMP_Launcher.My.MySettings.Default, "Exit_Btn", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EXIT0.DataBindings.Add(New System.Windows.Forms.Binding("Size", Global.TESVMP_Launcher.My.MySettings.Default, "EXIT0_Size", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EXIT0.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.TESVMP_Launcher.My.MySettings.Default, "Exit_location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EXIT0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TESVMP_Launcher.My.MySettings.Default, "Opacity_Exit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EXIT0.Image = Global.TESVMP_Launcher.My.Resources.Resources.EXIT0
        Me.EXIT0.ImageLocation = Global.TESVMP_Launcher.My.MySettings.Default.Exit_Btn
        Me.EXIT0.Location = Global.TESVMP_Launcher.My.MySettings.Default.Exit_location
        Me.EXIT0.Name = "EXIT0"
        Me.EXIT0.Size = Global.TESVMP_Launcher.My.MySettings.Default.EXIT0_Size
        Me.EXIT0.TabIndex = 2
        Me.EXIT0.TabStop = False
        Me.EXIT0.Text = Global.TESVMP_Launcher.My.MySettings.Default.Opacity_Exit
        '
        'AZAAXIN_INFO
        '
        Me.AZAAXIN_INFO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AZAAXIN_INFO.AutoSize = True
        Me.AZAAXIN_INFO.BackColor = System.Drawing.Color.Transparent
        Me.AZAAXIN_INFO.ForeColor = System.Drawing.Color.DimGray
        Me.AZAAXIN_INFO.Location = New System.Drawing.Point(-1, 244)
        Me.AZAAXIN_INFO.Name = "AZAAXIN_INFO"
        Me.AZAAXIN_INFO.Size = New System.Drawing.Size(61, 13)
        Me.AZAAXIN_INFO.TabIndex = 3
        Me.AZAAXIN_INFO.Text = "TESVAMP:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(96, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Beta Unstable"
        Me.Label2.Visible = False
        '
        'version1
        '
        Me.version1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.version1.AutoSize = True
        Me.version1.BackColor = System.Drawing.Color.Transparent
        Me.version1.ForeColor = System.Drawing.Color.DimGray
        Me.version1.Location = New System.Drawing.Point(58, 244)
        Me.version1.Name = "version1"
        Me.version1.Size = New System.Drawing.Size(40, 13)
        Me.version1.TabIndex = 6
        Me.version1.Text = "0.0.0.0"
        '
        'UpdateMessage
        '
        Me.UpdateMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateMessage.AutoSize = True
        Me.UpdateMessage.BackColor = System.Drawing.Color.Transparent
        Me.UpdateMessage.ForeColor = System.Drawing.Color.DimGray
        Me.UpdateMessage.Location = New System.Drawing.Point(433, 244)
        Me.UpdateMessage.Name = "UpdateMessage"
        Me.UpdateMessage.Size = New System.Drawing.Size(0, 13)
        Me.UpdateMessage.TabIndex = 7
        '
        'nfi
        '
        Me.nfi.ContextMenuStrip = Me.ContextMenuStrip1
        Me.nfi.Icon = CType(resources.GetObject("nfi.Icon"), System.Drawing.Icon)
        Me.nfi.Text = "Skyrim Custom Launcher"
        Me.nfi.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartSkyrimToolStripMenuItem, Me.MinimizeToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 92)
        '
        'StartSkyrimToolStripMenuItem
        '
        Me.StartSkyrimToolStripMenuItem.Name = "StartSkyrimToolStripMenuItem"
        Me.StartSkyrimToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.StartSkyrimToolStripMenuItem.Text = "Start Skyrim"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemTrayToolStripMenuItem, Me.NormalMinimizeToolStripMenuItem})
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'SystemTrayToolStripMenuItem
        '
        Me.SystemTrayToolStripMenuItem.Name = "SystemTrayToolStripMenuItem"
        Me.SystemTrayToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SystemTrayToolStripMenuItem.Text = "System Tray"
        '
        'NormalMinimizeToolStripMenuItem
        '
        Me.NormalMinimizeToolStripMenuItem.Name = "NormalMinimizeToolStripMenuItem"
        Me.NormalMinimizeToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NormalMinimizeToolStripMenuItem.Text = "Normal Minimize"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(-1, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Time played:"
        '
        'timeplayed
        '
        Me.timeplayed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.timeplayed.AutoSize = True
        Me.timeplayed.BackColor = System.Drawing.Color.Transparent
        Me.timeplayed.ForeColor = System.Drawing.Color.DimGray
        Me.timeplayed.Location = New System.Drawing.Point(66, 228)
        Me.timeplayed.Name = "timeplayed"
        Me.timeplayed.Size = New System.Drawing.Size(0, 13)
        Me.timeplayed.TabIndex = 9
        '
        'Timer2
        '
        '
        'CustomButton1
        '
        Me.CustomButton1.BackColor = System.Drawing.Color.Transparent
        Me.CustomButton1.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Global.TESVMP_Launcher.My.MySettings.Default, "CustomButton1_Image", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CustomButton1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TESVMP_Launcher.My.MySettings.Default, "Application_Buttton1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CustomButton1.Image = Global.TESVMP_Launcher.My.Resources.Resources._1
        Me.CustomButton1.ImageLocation = Global.TESVMP_Launcher.My.MySettings.Default.CustomButton1_Image
        Me.CustomButton1.Location = New System.Drawing.Point(0, 0)
        Me.CustomButton1.Name = "CustomButton1"
        Me.CustomButton1.Size = New System.Drawing.Size(100, 50)
        Me.CustomButton1.TabIndex = 10
        Me.CustomButton1.TabStop = False
        Me.CustomButton1.Text = Global.TESVMP_Launcher.My.MySettings.Default.Application_Buttton1
        Me.CustomButton1.Visible = False
        '
        'CustomButton2
        '
        Me.CustomButton2.BackgroundImage = CType(resources.GetObject("CustomButton2.BackgroundImage"), System.Drawing.Image)
        Me.CustomButton2.Location = New System.Drawing.Point(5, 5)
        Me.CustomButton2.Name = "CustomButton2"
        Me.CustomButton2.Size = New System.Drawing.Size(100, 50)
        Me.CustomButton2.TabIndex = 11
        Me.CustomButton2.TabStop = False
        Me.CustomButton2.Visible = False
        '
        'CustomButton3
        '
        Me.CustomButton3.BackgroundImage = CType(resources.GetObject("CustomButton3.BackgroundImage"), System.Drawing.Image)
        Me.CustomButton3.Location = New System.Drawing.Point(10, 10)
        Me.CustomButton3.Name = "CustomButton3"
        Me.CustomButton3.Size = New System.Drawing.Size(100, 50)
        Me.CustomButton3.TabIndex = 12
        Me.CustomButton3.TabStop = False
        Me.CustomButton3.Visible = False
        '
        'CustomButton4
        '
        Me.CustomButton4.BackgroundImage = CType(resources.GetObject("CustomButton4.BackgroundImage"), System.Drawing.Image)
        Me.CustomButton4.Location = New System.Drawing.Point(15, 15)
        Me.CustomButton4.Name = "CustomButton4"
        Me.CustomButton4.Size = New System.Drawing.Size(100, 50)
        Me.CustomButton4.TabIndex = 13
        Me.CustomButton4.TabStop = False
        Me.CustomButton4.Visible = False
        '
        'CustomButton5
        '
        Me.CustomButton5.BackgroundImage = CType(resources.GetObject("CustomButton5.BackgroundImage"), System.Drawing.Image)
        Me.CustomButton5.Location = New System.Drawing.Point(20, 20)
        Me.CustomButton5.Name = "CustomButton5"
        Me.CustomButton5.Size = New System.Drawing.Size(100, 50)
        Me.CustomButton5.TabIndex = 14
        Me.CustomButton5.TabStop = False
        Me.CustomButton5.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TESVMP_Launcher.My.Resources.Resources.AZAMODLOADER
        Me.BackgroundImageLayout = Global.TESVMP_Launcher.My.MySettings.Default.bgimage
        Me.ClientSize = New System.Drawing.Size(612, 266)
        Me.Controls.Add(Me.CustomButton5)
        Me.Controls.Add(Me.CustomButton4)
        Me.Controls.Add(Me.CustomButton3)
        Me.Controls.Add(Me.CustomButton2)
        Me.Controls.Add(Me.CustomButton1)
        Me.Controls.Add(Me.timeplayed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpdateMessage)
        Me.Controls.Add(Me.version1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AZAAXIN_INFO)
        Me.Controls.Add(Me.EXIT0)
        Me.Controls.Add(Me.OPTIONS0)
        Me.Controls.Add(Me.PLAY0)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackgroundImageLayout", Global.TESVMP_Launcher.My.MySettings.Default, "bgimage", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "TESV_MODPACK_LAUNCHER_AZAAXIN"
        CType(Me.PLAY0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPTIONS0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXIT0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.CustomButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PLAY0 As System.Windows.Forms.PictureBox
    Friend WithEvents OPTIONS0 As System.Windows.Forms.PictureBox
    Friend WithEvents EXIT0 As System.Windows.Forms.PictureBox
    Friend WithEvents AZAAXIN_INFO As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents version1 As System.Windows.Forms.Label
    Friend WithEvents UpdateMessage As System.Windows.Forms.Label
    Private WithEvents nfi As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents timeplayed As System.Windows.Forms.Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents StartSkyrimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemTrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalMinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomButton1 As PictureBox
    Friend WithEvents CustomButton2 As PictureBox
    Friend WithEvents CustomButton3 As PictureBox
    Friend WithEvents CustomButton4 As PictureBox
    Friend WithEvents CustomButton5 As PictureBox
End Class
