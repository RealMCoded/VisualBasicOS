<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WinClock = New System.Windows.Forms.Label()
        Me.AMB = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fact_ICO = New System.Windows.Forms.PictureBox()
        Me.ImgView_LAB = New System.Windows.Forms.Label()
        Me.ImgView_ICO = New System.Windows.Forms.PictureBox()
        Me.Fact_TXT = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.AMB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fact_ICO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgView_ICO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.WinClock)
        Me.Panel1.Controls.Add(Me.AMB)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 390)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 24)
        Me.Panel1.TabIndex = 0
        '
        'WinClock
        '
        Me.WinClock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WinClock.AutoSize = True
        Me.WinClock.ForeColor = System.Drawing.Color.White
        Me.WinClock.Location = New System.Drawing.Point(612, 3)
        Me.WinClock.Name = "WinClock"
        Me.WinClock.Size = New System.Drawing.Size(34, 13)
        Me.WinClock.TabIndex = 1
        Me.WinClock.Text = "Clock"
        '
        'AMB
        '
        Me.AMB.BackgroundImage = CType(resources.GetObject("AMB.BackgroundImage"), System.Drawing.Image)
        Me.AMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AMB.Location = New System.Drawing.Point(3, 0)
        Me.AMB.Name = "AMB"
        Me.AMB.Size = New System.Drawing.Size(134, 23)
        Me.AMB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AMB.TabIndex = 0
        Me.AMB.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Fact_ICO)
        Me.Panel2.Controls.Add(Me.ImgView_LAB)
        Me.Panel2.Controls.Add(Me.ImgView_ICO)
        Me.Panel2.Controls.Add(Me.Fact_TXT)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(751, 391)
        Me.Panel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(98, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "CRASH IT!"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(109, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(703, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "D-NO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 284)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Theme Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(707, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "FLW"
        '
        'Fact_ICO
        '
        Me.Fact_ICO.Image = CType(resources.GetObject("Fact_ICO.Image"), System.Drawing.Image)
        Me.Fact_ICO.Location = New System.Drawing.Point(25, 119)
        Me.Fact_ICO.Name = "Fact_ICO"
        Me.Fact_ICO.Size = New System.Drawing.Size(50, 50)
        Me.Fact_ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fact_ICO.TabIndex = 10
        Me.Fact_ICO.TabStop = False
        '
        'ImgView_LAB
        '
        Me.ImgView_LAB.AutoSize = True
        Me.ImgView_LAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImgView_LAB.ForeColor = System.Drawing.Color.White
        Me.ImgView_LAB.Location = New System.Drawing.Point(7, 255)
        Me.ImgView_LAB.Name = "ImgView_LAB"
        Me.ImgView_LAB.Size = New System.Drawing.Size(102, 16)
        Me.ImgView_LAB.TabIndex = 9
        Me.ImgView_LAB.Text = "Image Viewer"
        '
        'ImgView_ICO
        '
        Me.ImgView_ICO.Image = CType(resources.GetObject("ImgView_ICO.Image"), System.Drawing.Image)
        Me.ImgView_ICO.Location = New System.Drawing.Point(25, 202)
        Me.ImgView_ICO.Name = "ImgView_ICO"
        Me.ImgView_ICO.Size = New System.Drawing.Size(50, 50)
        Me.ImgView_ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgView_ICO.TabIndex = 8
        Me.ImgView_ICO.TabStop = False
        '
        'Fact_TXT
        '
        Me.Fact_TXT.AutoSize = True
        Me.Fact_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fact_TXT.ForeColor = System.Drawing.Color.White
        Me.Fact_TXT.Location = New System.Drawing.Point(3, 172)
        Me.Fact_TXT.Name = "Fact_TXT"
        Me.Fact_TXT.Size = New System.Drawing.Size(115, 16)
        Me.Fact_TXT.TabIndex = 7
        Me.Fact_TXT.Text = "Random Tip (3)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Discord!"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(25, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(612, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Visual Basic OS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Codename Exxa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Work in progress :)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(C)2019 MCoded"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimeUpdater
        '
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(670, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "stop all audio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 412)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(765, 451)
        Me.Name = "OS"
        Me.Text = "(Early Tester Mode) | Visual Basic OS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AMB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fact_ICO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgView_ICO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AMB As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WinClock As Label
    Friend WithEvents TimeUpdater As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Fact_TXT As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ImgView_LAB As Label
    Friend WithEvents ImgView_ICO As PictureBox
    Friend WithEvents Fact_ICO As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
End Class
