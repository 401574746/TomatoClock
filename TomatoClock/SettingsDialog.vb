Imports System.ComponentModel
Imports System.Windows.Forms

Public Class SettingsDialog

    Private Sub SettingsDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        TrackBar1.Value = My.Settings.FormOpacity * 100
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        My.Settings.FormOpacity = TrackBar1.Value / 100
    End Sub

    Private Sub SettingsDialog_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        My.Settings.Save()
        If MainForm.Tomato_Alarm.Enabled = False Then
            If MsgBox("需要重新打开软件以应用更改"， vbYesNo， "提示") = MsgBoxResult.Yes Then
                DialogResult = DialogResult.Abort
                Me.Close()
            End If
        Else
            MsgBox("需要重新打开软件以应用更改"， vbOKOnly， "提示")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://egzhueducn-my.sharepoint.com/:f:/g/personal/1965400005_e_gzhu_edu_cn/EsCmSKeAmntEgDTi52OfxF8B7It_4fldP7ei4OHx2V0HVw?e=VYatAv")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AboutTomato.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

            If FileIO.FileSystem.FileExists(Application.StartupPath + "/Tomatoes") Then
                If MsgBox("已有历史记录,是否转移?", vbYesNo, "提示") = MsgBoxResult.Yes Then
                    FileSystem.FileCopy(Application.StartupPath + "/Tomatoes", FolderBrowserDialog1.SelectedPath + "/Tomatoes")
                    Exit Sub
                End If
            End If
            My.Settings.TomatoesFolder = FolderBrowserDialog1.SelectedPath + "/Tomatoes"

            If FileIO.FileSystem.FileExists(My.Settings.TomatoesFolder) = False Then My.Computer.FileSystem.WriteAllText(My.Settings.TomatoesFolder, "", False)

        End If
    End Sub
End Class
