Imports TomatoClock.Cla

Public Class MainForm
    Private NextTime As Integer = 25
    Private End_Time As TimeSpan
    Private Start_Time As TimeSpan
    Private Total_Time As TimeSpan

    Private Sub CancelTomato(sender As Object, e As EventArgs) Handles CancelTomatoButton.Click
        NextTime = Total_Time.Minutes
        Set_Zero()
        If My.Settings.AlarmEnable Then My.Computer.Audio.Play(My.Resources.Alarm2, AudioPlayMode.Background)
    End Sub

    Private Sub Tomato_Alarm_Tick(sender As Object, e As EventArgs) Handles Tomato_Alarm.Tick
        Label1.Text = End_Time.Subtract(Now.TimeOfDay).ToString.Substring(0, 11)
        Tomato.Text = "剩余时间: " + Label1.Text
        If End_Time.Subtract(Now.TimeOfDay) <= TimeSpan.Zero Then End_Tomato()
    End Sub

    Public Sub New_Tomato(Selected_Time As Integer)
        If Selected_Time = 5 Then NextTime = 25
        If Selected_Time = 25 Then NextTime = 5
        Total_Time = TimeSpan.FromMinutes(Selected_Time)
        Label1.Text = Total_Time.ToString
    End Sub

    Private Sub End_Tomato()
        TopMost = True
        Me.Show()
        If My.Settings.AlarmEnable Then My.Computer.Audio.Play(My.Resources.Alarm, AudioPlayMode.Background)
        Set_Zero()
        SaveHistory()
        ReflashTomatoes()
    End Sub

    Private Sub ReflashTomatoes()
        OpenTomatoesFromFile(File_Name())
        ToolStripLabel2.Text = "今日获得番茄：" & GetTodayTomatoes(2) & "/" & GetTodayTomatoes(1)
    End Sub

    Private Sub SaveHistory()
        If My.Settings.TomatoHistory = False Then Exit Sub
        If Start_Time = TimeSpan.Zero Or End_Time = TimeSpan.Zero Or Total_Time = TimeSpan.Zero Then
            MsgBox("Saved Error")
            Exit Sub
        End If
        My.Computer.FileSystem.WriteAllText(File_Name, Now.Date.ToString + vbTab + Start_Time.ToString + vbTab + End_Time.ToString + vbTab + Total_Time.ToString + vbNewLine, True)
    End Sub

    Private Sub Set_Zero()
        Tomato_Alarm.Enabled = False
        StartTomatoButton.Enabled = True
        CancelTomatoButton.Enabled = False
        Tomato.Text = "Tomato_Alarm By Shuhan Xu"
        New_Tomato(NextTime)
    End Sub '置零
    '''
    Private Sub Tomato_MouseClick(sender As Object, e As MouseEventArgs) Handles Tomato.MouseClick
        If Visible = False Then
            Show()
            WindowState = FormWindowState.Normal
            TopMost = True
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        New_Tomato(25)
        ReflashTomatoes()
    End Sub

    Private Sub Label1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Label1.LinkClicked
        ContextMenuStrip1.Show(MousePosition)
    End Sub

    Private Sub MinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem.Click
        New_Tomato(25)
    End Sub

    Private Sub MinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem1.Click
        New_Tomato(5)
    End Sub

    Private Sub StartTomato(sender As Object, e As EventArgs) Handles StartTomatoButton.Click
        If Total_Time = TimeSpan.Zero Then Exit Sub

        Start_Time = Now.TimeOfDay
        End_Time = Start_Time.Add(Total_Time)
        CancelTomatoButton.Enabled = True
        Tomato_Alarm.Enabled = True
        If My.Settings.AlarmEnable Then My.Computer.Audio.Play(My.Resources.Alarm1, AudioPlayMode.Background)
        'Me.Hide()
        StartTomatoButton.Enabled = False
    End Sub

    Private Sub ToolStripMenuItemTomatoes_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemTomatoes.Click
        Hide()
        TomatoesDialog.ShowDialog()
        Show()
    End Sub

    Private Sub ToolStripMenuItemSettings_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSettings.Click
        Me.Hide()
        If SettingsDialog.ShowDialog() = DialogResult.Abort Then
            Application.Restart()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItemEnd_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEnd.Click
        Tomato.Visible = False
        End
    End Sub

    Private Sub ToolStripMenuItemHide_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItemHide.Click
        Me.Hide()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
