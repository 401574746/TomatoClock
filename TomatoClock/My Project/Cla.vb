Public Class Cla
    Public Shared Tomatoes() As TomatoDetail

    Public Structure TomatoDetail
        Public DateData As Date
        Public StartTime As TimeSpan
        Public EndTime As TimeSpan
        Public TotalTime As TimeSpan
    End Structure

    Public Shared Function File_Name() As String
        If FileIO.FileSystem.FileExists(My.Settings.TomatoesFolder) Then
            Return My.Settings.TomatoesFolder
        Else
            My.Settings.TomatoesFolder = Application.StartupPath + "/Tomatoes"
            MessageBox.Show("记录文件夹已更换为:" + vbNewLine + Application.StartupPath)
            Return Application.StartupPath + "/Tomatoes"
            End If
    End Function

    Public Shared Sub AddTomato(DateData As Date, StartTime As TimeSpan, Endtime As TimeSpan, TotalTime As TimeSpan)
        Dim I As Integer
        If IsNothing(Tomatoes) = False Then I = UBound(Tomatoes) + 1
        ReDim Preserve Tomatoes(I)
        With Tomatoes(I)
            .DateData = DateData
            .StartTime = StartTime
            .EndTime = Endtime
            .TotalTime = Endtime.Subtract(StartTime)
        End With
    End Sub
    ''' <summary>
    ''' 获取番茄数目
    ''' </summary>
    ''' <param name="Serial">1:总数;2:红番茄数(25min);3:绿番茄数(5min)</param>
    ''' <returns></returns>
    Public Shared Function GetTotalTomatoes(Serial As Integer) As Integer
        If IsNothing(Tomatoes) Then Return 0
        Tomatoes = Nothing
        OpenTomatoesFromFile(File_Name())
        If Serial = 1 Then Return UBound(Tomatoes) + 1
        Dim GreenTomatoes = 0
        Dim RedTomatoes = 0
        For i = 0 To UBound(Tomatoes)
            If Tomatoes(i).TotalTime >= TimeSpan.FromMinutes(25) Then RedTomatoes += 1
            If Tomatoes(i).TotalTime <= TimeSpan.FromMinutes(10) Then GreenTomatoes += 1
        Next
        If Serial = 2 Then Return RedTomatoes
        If Serial = 3 Then Return GreenTomatoes
        Return UBound(Tomatoes) + 1
    End Function

    ''' <summary>
    ''' 获取今日番茄数目
    ''' </summary>
    ''' <param name="Serial">1:总数;2:红番茄数(25min);3:绿番茄数(5min)</param>
    ''' <returns></returns>
    Public Shared Function GetTodayTomatoes(Serial As Integer) As Integer
        If IsNothing(Tomatoes) Then Return 0
        Tomatoes = Nothing
        OpenTomatoesFromFile(File_Name)
        Dim GreenTomatoes = 0
        Dim RedTomatoes = 0
        Dim TodayTomatoes = 0
        For i = 0 To UBound(Tomatoes)
            If Tomatoes(i).DateData = Today.Date Then
                TodayTomatoes += 1
                If Tomatoes(i).TotalTime >= TimeSpan.FromMinutes(25) Then RedTomatoes += 1
                If Tomatoes(i).TotalTime <= TimeSpan.FromMinutes(10) Then GreenTomatoes += 1
            End If
        Next
        If Serial = 2 Then Return RedTomatoes
        If Serial = 3 Then Return GreenTomatoes
        Return TodayTomatoes
    End Function


    Public Shared Function OpenTomatoesFromFile(File_Path As String) As Boolean
        On Error GoTo Er
        Dim FST = FileIO.FileSystem.ReadAllText(File_Path)
        Dim FSTL = Split(FST, vbNewLine)
        For i = 0 To UBound(FSTL)
            Dim FSTLS = Split(FSTL(i), vbTab)
            If UBound(FSTLS) = 0 Then Exit For
            Dim SWITCH(2)
            For j = 0 To 2
                TimeSpan.TryParse(FSTLS(j + 1), SWITCH(j))
            Next
            AddTomato(FSTLS(0), SWITCH(0), SWITCH(1), SWITCH(2))
        Next
        Return True
Er:     Return False
    End Function

    Public Shared Function Get7DaysTomatoes() As Integer(,)
        If IsNothing(Tomatoes) Then Return Nothing
        Dim ReturnInt(1, 7) As Integer
        Dim m
        For i = 0 To UBound(Tomatoes)
            m = DateDiff(DateInterval.Day, Tomatoes(i).DateData.Date, Now)
            If m <= 7 Then
                If Tomatoes(i).TotalTime >= TimeSpan.FromMinutes(25) Then ReturnInt(0, m) += 1
                If Tomatoes(i).TotalTime <= TimeSpan.FromMinutes(10) Then ReturnInt(1, m) += 1
            End If
        Next
        Return ReturnInt
    End Function
End Class
