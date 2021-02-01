<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Tomato_Alarm = New System.Windows.Forms.Timer(Me.components)
        Me.Tomato = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TomatoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.隐藏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关闭ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.LinkLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelTomatoButton = New System.Windows.Forms.Button()
        Me.StartTomatoButton = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Copyright = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTomatoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tomato_Alarm
        '
        Me.Tomato_Alarm.Interval = 10
        '
        'Tomato
        '
        Me.Tomato.Icon = CType(resources.GetObject("Tomato.Icon"), System.Drawing.Icon)
        Me.Tomato.Text = "Tomato_Alarm By Shuhan Xu"
        Me.Tomato.Visible = True
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = Global.TomatoClock.My.Resources.Resources.tomato_128px
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        'TomatoesToolStripMenuItem
        '
        Me.TomatoesToolStripMenuItem.Name = "TomatoesToolStripMenuItem"
        Me.TomatoesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TomatoesToolStripMenuItem.Text = "Tomatoes"
        Me.TomatoesToolStripMenuItem.Visible = Global.TomatoClock.My.MySettings.Default.TomatoHistory
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        '隐藏ToolStripMenuItem
        '
        Me.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem"
        Me.隐藏ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.隐藏ToolStripMenuItem.Text = "隐藏"
        '
        '关闭ToolStripMenuItem
        '
        Me.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem"
        Me.关闭ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.关闭ToolStripMenuItem.Text = "关闭"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(92, 17)
        Me.ToolStripStatusLabel2.Text = "今日新增番茄:"
        Me.ToolStripStatusLabel2.Visible = Global.TomatoClock.My.MySettings.Default.TomatoHistory
        '
        'Label1
        '
        Me.Label1.ActiveLinkColor = System.Drawing.Color.Black
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.Label1.LinkColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 311)
        Me.Label1.TabIndex = 5
        Me.Label1.TabStop = True
        Me.Label1.Text = "00:00:00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinToolStripMenuItem, Me.MinToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 48)
        '
        'MinToolStripMenuItem
        '
        Me.MinToolStripMenuItem.Name = "MinToolStripMenuItem"
        Me.MinToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.MinToolStripMenuItem.Text = "25分钟"
        '
        'MinToolStripMenuItem1
        '
        Me.MinToolStripMenuItem1.Name = "MinToolStripMenuItem1"
        Me.MinToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.MinToolStripMenuItem1.Text = "5分钟"
        '
        'CancelTomatoButton
        '
        Me.CancelTomatoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelTomatoButton.Enabled = False
        Me.CancelTomatoButton.Location = New System.Drawing.Point(162, 324)
        Me.CancelTomatoButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelTomatoButton.Name = "CancelTomatoButton"
        Me.CancelTomatoButton.Size = New System.Drawing.Size(137, 33)
        Me.CancelTomatoButton.TabIndex = 4
        Me.CancelTomatoButton.Text = "暂停"
        Me.CancelTomatoButton.UseVisualStyleBackColor = True
        '
        'StartTomatoButton
        '
        Me.StartTomatoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartTomatoButton.Location = New System.Drawing.Point(12, 324)
        Me.StartTomatoButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartTomatoButton.Name = "StartTomatoButton"
        Me.StartTomatoButton.Size = New System.Drawing.Size(137, 33)
        Me.StartTomatoButton.TabIndex = 7
        Me.StartTomatoButton.Text = "开始"
        Me.StartTomatoButton.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 358)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(311, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Copyright, Me.ToolStripMenuItemTomatoes, Me.ToolStripMenuItemSettings, Me.ToolStripSeparator2, Me.ToolStripMenuItemHide, Me.ToolStripMenuItemEnd})
        Me.ToolStripDropDownButton2.Image = Global.TomatoClock.My.Resources.Resources.tomato_128px
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton2.Text = "Tomato"
        '
        'Copyright
        '
        Me.Copyright.Enabled = False
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(186, 22)
        Me.Copyright.Text = "By YueHsu 2020.06"
        '
        'ToolStripMenuItemTomatoes
        '
        Me.ToolStripMenuItemTomatoes.Name = "ToolStripMenuItemTomatoes"
        Me.ToolStripMenuItemTomatoes.Size = New System.Drawing.Size(186, 22)
        Me.ToolStripMenuItemTomatoes.Text = "Tomatoes"
        '
        'ToolStripMenuItemSettings
        '
        Me.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings"
        Me.ToolStripMenuItemSettings.Size = New System.Drawing.Size(186, 22)
        Me.ToolStripMenuItemSettings.Text = "设置"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'ToolStripMenuItemHide
        '
        Me.ToolStripMenuItemHide.Name = "ToolStripMenuItemHide"
        Me.ToolStripMenuItemHide.Size = New System.Drawing.Size(186, 22)
        Me.ToolStripMenuItemHide.Text = "隐藏"
        '
        'ToolStripMenuItemEnd
        '
        Me.ToolStripMenuItemEnd.Name = "ToolStripMenuItemEnd"
        Me.ToolStripMenuItemEnd.Size = New System.Drawing.Size(186, 22)
        Me.ToolStripMenuItemEnd.Text = "关闭"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripLabel2.Text = "今日获得番茄"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(311, 383)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StartTomatoButton)
        Me.Controls.Add(Me.CancelTomatoButton)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Opacity", Global.TomatoClock.My.MySettings.Default, "FormOpacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Opacity = Global.TomatoClock.My.MySettings.Default.FormOpacity
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tomato Clock"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tomato_Alarm As Timer
    Friend WithEvents Tomato As NotifyIcon
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents 关闭ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 隐藏ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TomatoesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Label1 As LinkLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CancelTomatoButton As Button
    Friend WithEvents StartTomatoButton As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItemTomatoes As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSettings As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItemHide As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemEnd As ToolStripMenuItem
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Copyright As ToolStripMenuItem
End Class
