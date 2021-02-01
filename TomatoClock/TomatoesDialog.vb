Imports TomatoClock.Cla
Public Class TomatoesDialog
    Private Sub TomatoesDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        If FileIO.FileSystem.FileExists(File_Name) = False Then Exit Sub
        OpenTomatoes(File_Name)
        ToolStripStatusLabel1.Text = "累计红番茄数：" & GetTotalTomatoes(2) & "/" & GetTotalTomatoes(1)
        Show7Detail(My.Settings.LargerDetail)
    End Sub

    Private Sub OpenTomatoes(File_Path As String)
        Tomatoes = Nothing
        OpenTomatoesFromFile(File_Path)
        GroupMode()
    End Sub
    ''' <summary>
    ''' 分组方式
    ''' </summary>
    ''' <param name="Mode">
    ''' 1.按时间分组
    ''' 2.按番茄类型分组
    ''' </param>
    Private Sub GroupMode(Optional Mode As Integer = 1)
        If IsNothing(Tomatoes) Then Exit Sub
        ListV.Groups.Clear()
        ListV.Items.Clear()
        For i = 0 To UBound(Tomatoes)
            With Tomatoes(i)
                Dim LI As New ListViewItem
                LI.Text = .StartTime.ToString.Substring(0, 8)
                LI.SubItems.Add(.EndTime.ToString.Substring(0, 8))

                Select Case Mode
                    Case 1
                        LI.SubItems.Add(.TotalTime.ToString)
                        For j = 0 To i - 1

                            If Tomatoes(i).DateData = Tomatoes(j).DateData Then
                                LI.Group = ListV.Items(j).Group
                                Exit For
                            End If
                        Next

                        If IsNothing(LI.Group) Then LI.Group = ListV.Groups.Add(ListV.Groups.Count + 1, .DateData.ToShortDateString)
                    Case 2
                        LI.SubItems.Add(.DateData.ToShortDateString)
                        For j = 0 To i - 1
                            If Tomatoes(i).TotalTime = Tomatoes(j).TotalTime Then
                                LI.Group = ListV.Items(j).Group
                                Exit For
                            End If
                        Next

                        If IsNothing(LI.Group) Then LI.Group = ListV.Groups.Add(ListV.Groups.Count + 1, .TotalTime.ToString)
                End Select

                If Tomatoes(i).TotalTime >= TimeSpan.FromMinutes(25) Then LI.BackColor = Color.MistyRose
                If Tomatoes(i).TotalTime <= TimeSpan.FromMinutes(10) Then LI.BackColor = Color.Honeydew
                ListV.Items.Add(LI)
            End With
        Next
    End Sub

    Private Sub 选择文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选择文件ToolStripMenuItem.Click
        With OpenTomatoesHistory
            .InitialDirectory = File_Name()
        End With

        If OpenTomatoesHistory.ShowDialog = DialogResult.OK Then
            Try
                OpenTomatoes(OpenTomatoesHistory.FileName)
            Catch ex As Exception
                MessageBox.Show(ex, MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub 按类型ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 按类型ToolStripMenuItem.Click
        GroupMode(2)
    End Sub

    Private Sub Show7DetailMenuItem_Click(sender As Object, e As EventArgs) Handles 按日期ToolStripMenuItem.Click
        GroupMode(1)
    End Sub

    Private Sub 近7天统计数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 近7天统计数据ToolStripMenuItem.Click
        If My.Settings.LargerDetail = False Then
            My.Settings.LargerDetail = True
        Else
            My.Settings.LargerDetail = False
        End If
        Show7Detail(My.Settings.LargerDetail)
    End Sub

    Private Sub Show7Detail(LargerDetail As Boolean)
        If LargerDetail Then
            Me.Width = 877
            Dim XY = Get7DaysTomatoes()
            Chart1.Series(0).Points.Clear()
            Chart1.Series(1).Points.Clear()
            For i = 0 To 7
                Chart1.Series(0).Points.AddXY(0 - i, XY(0, i))
                Chart1.Series(1).Points.AddXY(0 - i, XY(1, i))
            Next
        Else
            Chart1.Series(0).Points.Clear()
            Chart1.Series(1).Points.Clear()
            Me.Width = 544
        End If
        Me.CenterToScreen()
    End Sub
End Class
