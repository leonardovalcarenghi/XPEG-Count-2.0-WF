﻿'------------------------------------------------------------------------------
' <auto-generated>
'     O código foi gerado por uma ferramenta.
'     Versão de Tempo de Execução:4.0.30319.42000
'
'     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
'     o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>  _
Partial Friend NotInheritable Class XpegCountSettings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As XpegCountSettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New XpegCountSettings()),XpegCountSettings)
    
    Public Shared ReadOnly Property [Default]() As XpegCountSettings
        Get
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property FirstUse() As Boolean
        Get
            Return CType(Me("FirstUse"),Boolean)
        End Get
        Set
            Me("FirstUse") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property ViewMode() As Integer
        Get
            Return CType(Me("ViewMode"),Integer)
        End Get
        Set
            Me("ViewMode") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property ConfirmClose() As Boolean
        Get
            Return CType(Me("ConfirmClose"),Boolean)
        End Get
        Set
            Me("ConfirmClose") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property AutoTabInCalendar() As Boolean
        Get
            Return CType(Me("AutoTabInCalendar"),Boolean)
        End Get
        Set
            Me("AutoTabInCalendar") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
    Public Property ChangeStatusInXBeforeDays() As Integer
        Get
            Return CType(Me("ChangeStatusInXBeforeDays"),Integer)
        End Get
        Set
            Me("ChangeStatusInXBeforeDays") = value
        End Set
    End Property
End Class
