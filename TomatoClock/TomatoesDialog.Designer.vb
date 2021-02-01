<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TomatoesDialog
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.ListV = New System.Windows.Forms.ListView()
        Me.StartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Endtime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Totaltime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.选择文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.排序方式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.按类型ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.按日期ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.近7天统计数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTomatoesHistory = New System.Windows.Forms.OpenFileDialog()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListV
        '
        Me.ListV.AllowColumnReorder = True
        Me.ListV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.StartTime, Me.Endtime, Me.Totaltime})
        Me.ListV.FullRowSelect = True
        Me.ListV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListV.HideSelection = False
        Me.ListV.Location = New System.Drawing.Point(0, 28)
        Me.ListV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListV.MultiSelect = False
        Me.ListV.Name = "ListV"
        Me.ListV.Size = New System.Drawing.Size(528, 279)
        Me.ListV.TabIndex = 1
        Me.ListV.UseCompatibleStateImageBehavior = False
        Me.ListV.View = System.Windows.Forms.View.Details
        '
        'StartTime
        '
        Me.StartTime.Text = "开始时间"
        Me.StartTime.Width = 130
        '
        'Endtime
        '
        Me.Endtime.Text = "结束时间"
        Me.Endtime.Width = 130
        '
        'Totaltime
        '
        Me.Totaltime.Text = "时间"
        Me.Totaltime.Width = 130
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 311)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(861, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(80, 17)
        Me.ToolStripStatusLabel1.Text = "累计红番茄数"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选择文件ToolStripMenuItem, Me.排序方式ToolStripMenuItem, Me.近7天统计数据ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(861, 25)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '选择文件ToolStripMenuItem
        '
        Me.选择文件ToolStripMenuItem.Name = "选择文件ToolStripMenuItem"
        Me.选择文件ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.选择文件ToolStripMenuItem.Text = "选择文件"
        '
        '排序方式ToolStripMenuItem
        '
        Me.排序方式ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.按类型ToolStripMenuItem, Me.按日期ToolStripMenuItem})
        Me.排序方式ToolStripMenuItem.Name = "排序方式ToolStripMenuItem"
        Me.排序方式ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.排序方式ToolStripMenuItem.Text = "排序方式"
        '
        '按类型ToolStripMenuItem
        '
        Me.按类型ToolStripMenuItem.Name = "按类型ToolStripMenuItem"
        Me.按类型ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.按类型ToolStripMenuItem.Text = "按类型"
        '
        '按日期ToolStripMenuItem
        '
        Me.按日期ToolStripMenuItem.Name = "按日期ToolStripMenuItem"
        Me.按日期ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.按日期ToolStripMenuItem.Text = "按日期"
        '
        '近7天统计数据ToolStripMenuItem
        '
        Me.近7天统计数据ToolStripMenuItem.Name = "近7天统计数据ToolStripMenuItem"
        Me.近7天统计数据ToolStripMenuItem.Size = New System.Drawing.Size(99, 21)
        Me.近7天统计数据ToolStripMenuItem.Text = "近7日统计数据"
        '
        'OpenTomatoesHistory
        '
        Me.OpenTomatoesHistory.FileName = "Tomatoes"
        Me.OpenTomatoesHistory.Title = "选择记录"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.SystemColors.Control
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.SystemColors.ActiveBorder
        ChartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ActiveCaption
        ChartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        ChartArea1.BackColor = System.Drawing.SystemColors.Control
        ChartArea1.CursorX.AutoScroll = False
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(534, 28)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.Tomato
        Series1.IsVisibleInLegend = False
        Series1.LegendText = "Tomatoes"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.MediumSeaGreen
        Series2.IsVisibleInLegend = False
        Series2.LegendText = "Tomatoes"
        Series2.Name = "Series2"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(315, 279)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Title1.Name = "Title1"
        Title1.Text = "近7日统计数据"
        Me.Chart1.Titles.Add(Title1)
        '
        'TomatoesDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 333)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListV)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Opacity", Global.TomatoClock.My.MySettings.Default, "FormOpacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TomatoesDialog"
        Me.Opacity = Global.TomatoClock.My.MySettings.Default.FormOpacity
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TomatoesDialog"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListV As ListView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StartTime As ColumnHeader
    Friend WithEvents Endtime As ColumnHeader
    Friend WithEvents Totaltime As ColumnHeader
    Friend WithEvents 选择文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTomatoesHistory As OpenFileDialog
    Friend WithEvents 排序方式ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 按类型ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 按日期ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents 近7天统计数据ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
