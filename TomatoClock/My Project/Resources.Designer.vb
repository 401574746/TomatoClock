﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("TomatoClock.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  重写当前线程的 CurrentUICulture 属性
        '''  重写当前线程的 CurrentUICulture 属性。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找类似于 System.IO.MemoryStream 的 System.IO.UnmanagedMemoryStream 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property Alarm() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Alarm", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似于 System.IO.MemoryStream 的 System.IO.UnmanagedMemoryStream 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property Alarm1() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Alarm1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似于 System.IO.MemoryStream 的 System.IO.UnmanagedMemoryStream 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property Alarm2() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("Alarm2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 == 2020/07/30 v1.0.7 ==
        '''新增&quot;7日番茄统计图表&quot;,直观展示番茄历程
        '''
        '''== 2020/07/27 v1.0.6 ==
        '''优化 连续番茄钟 逻辑
        '''简化主界面
        '''
        '''== 2020/06/19 v1.0.5.2 ==
        '''优化逻辑
        '''
        '''== 2020/06/15 v1.0.5 ==
        '''BUGFIX:因功能关闭导致程序无法启动
        '''
        '''== 2020/06/14 v1.0.4.x ==
        '''&quot;取消&quot;键音效√
        '''优化番茄记录逻辑
        '''番茄类型突出显示
        '''自定义番茄归类、排序方式
        '''
        '''== 2020/06/13 v1.0.3.3 ==
        '''BUGFIX:连续开启番茄钟时，总时间计算错误
        '''对&quot;关于&quot;窗口重新排版
        '''
        '''== 2020/06/12 v1.0.3.1 ==
        '''新建番茄钟音效√
        '''
        '''== 2020/06/11 v1.0.3 ==
        '''BUGFIX:多日期番茄加载失败
        '''
        '''== 2020/06/10 v1.0.0 ==
        '''加入&quot;设置&quot;窗口
        '''加入&quot;关于&quot;窗口
        '''加入番茄记录
        '''界面优化×2
        '''BUGFIX/添加功能:支持选择保存文件夹，防止更新后记录消失
        '''
        '''== 2020/06/ [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property Describe() As String
            Get
                Return ResourceManager.GetString("Describe", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property tomato_128px() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("tomato_128px", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
