﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Timing_FisTest.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
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
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        '''&lt;livetiming codex=&quot;###CODEX###&quot; passwd=&quot;###PASSWORD###&quot; sequence=&quot;###SEQ###&quot; timestamp=&quot;###TIME###&quot;&gt;
        '''&lt;command&gt;
        '''&lt;clear/&gt;
        '''&lt;/command&gt;
        '''&lt;/livetiming&gt;.
        '''</summary>
        Friend ReadOnly Property LoadInitial() As String
            Get
                Return ResourceManager.GetString("LoadInitial", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        '''&lt;livetiming codex=&quot;###CODEX###&quot; passwd=&quot;###PASSWORD###&quot; sequence=&quot;###SEQ###&quot; timestamp=&quot;###TIME###&quot;&gt;
        '''&lt;raceevent&gt;
        '''    &lt;dnf bib=&quot;1&quot; /&gt;
        '''&lt;/raceevent&gt; 
        '''&lt;/livetiming&gt;.
        '''</summary>
        Friend ReadOnly Property LoadRaceEventDNF() As String
            Get
                Return ResourceManager.GetString("LoadRaceEventDNF", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        '''&lt;livetiming codex=&quot;###CODEX###&quot; passwd=&quot;###PASSWORD###&quot; sequence=&quot;###SEQ###&quot; timestamp=&quot;###TIME###&quot;&gt;
        '''&lt;raceevent&gt;
        '''    &lt;dns bib=&quot;2&quot; /&gt;
        '''    &lt;nextstart bib=&quot;26&quot; /&gt; 
        '''&lt;/raceevent&gt; 
        '''&lt;/livetiming&gt;.
        '''</summary>
        Friend ReadOnly Property LoadRaceEventDNS() As String
            Get
                Return ResourceManager.GetString("LoadRaceEventDNS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        '''&lt;livetiming codex=&quot;###CODEX###&quot; passwd=&quot;###PASSWORD###&quot; sequence=&quot;###SEQ###&quot; timestamp=&quot;###TIME###&quot;&gt;
        '''&lt;raceevent&gt;
        '''    &lt;dq bib=&quot;26&quot; /&gt;
        '''&lt;/raceevent&gt; 
        '''&lt;/livetiming&gt;.
        '''</summary>
        Friend ReadOnly Property LoadRaceEventDSQ() As String
            Get
                Return ResourceManager.GetString("LoadRaceEventDSQ", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        '''&lt;livetiming codex=&quot;###CODEX###&quot; passwd=&quot;###PASSWORD###&quot; sequence=&quot;###SEQ###&quot; timestamp=&quot;###TIME###&quot;&gt;
        '''&lt;raceevent&gt;
        '''    &lt;start bib=&quot;1&quot; /&gt;
        '''    &lt;nextstart bib=&quot;2&quot; /&gt; 
        '''&lt;/raceevent&gt; 
        '''&lt;/livetiming&gt;.
        '''</summary>
        Friend ReadOnly Property LoadRaceEventStarted() As String
            Get
                Return ResourceManager.GetString("LoadRaceEventStarted", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        '''&lt;livetiming codex=&quot;###CODEX###&quot; passwd=&quot;###PASSWORD###&quot; sequence=&quot;###SEQ###&quot; timestamp=&quot;###TIME###&quot;&gt;
        '''&lt;raceevent&gt;
        '''    &lt;finish bib=&quot;29&quot;&gt;
        '''        &lt;time&gt;1:03.46&lt;/time&gt;
        '''        &lt;diff&gt;0.00&lt;/diff&gt;
        '''        &lt;rank&gt;1&lt;/rank&gt;
        '''    &lt;/finish&gt;
        '''&lt;/raceevent&gt; 
        '''&lt;/livetiming&gt;.
        '''</summary>
        Friend ReadOnly Property LoadRaceEventTime() As String
            Get
                Return ResourceManager.GetString("LoadRaceEventTime", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        '''&lt;livetiming codex=&quot;###CODEX###&quot; passwd=&quot;###PASSWORD###&quot; sequence=&quot;###SEQ###&quot; timestamp=&quot;###TIME###&quot;&gt;
        '''&lt;raceinfo&gt;
        '''    &lt;event&gt;TC Test Again&lt;/event&gt;
        '''    &lt;name /&gt;
        '''    &lt;slope&gt;Tignes, Stade&lt;/slope&gt;
        '''    &lt;discipline&gt;DH&lt;/discipline&gt;
        '''    &lt;gender&gt;M&lt;/gender&gt;
        '''    &lt;category&gt;FIS&lt;/category&gt;
        '''    &lt;place&gt;Tignes, FRA&lt;/place&gt;
        '''    &lt;tempunit&gt;C&lt;/tempunit&gt;
        '''    &lt;longunit&gt;m&lt;/longunit&gt;
        '''    &lt;speedunit&gt;kmh&lt;/speedunit&gt;
        '''    &lt;run no=&quot;1&quot;&gt;
        '''        &lt;discipline /&gt;
        '''        &lt;start&gt;2100&lt;/start&gt; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property LoadRaceInfo() As String
            Get
                Return ResourceManager.GetString("LoadRaceInfo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        '''&lt;livetiming codex=&quot;###CODEX###&quot; passwd=&quot;###PASSWORD###&quot; sequence=&quot;###SEQ###&quot; timestamp=&quot;###TIME###&quot;&gt;
        '''&lt;startlist runno=&quot;1&quot;&gt;
        '''    &lt;racer order=&quot;1&quot;&gt;
        '''        &lt;bib&gt;1&lt;/bib&gt;
        '''        &lt;lastname&gt;RAICH&lt;/lastname&gt;
        '''        &lt;firstname&gt;Benjamin&lt;/firstname&gt;
        '''        &lt;nat&gt;AUT&lt;/nat&gt;
        '''        &lt;fiscode&gt;50625&lt;/fiscode&gt;
        '''    &lt;/racer&gt;
        '''    &lt;racer order=&quot;2&quot;&gt;
        '''        &lt;bib&gt;2&lt;/bib&gt;
        '''        &lt;lastname&gt;BLARDONE&lt;/lastname&gt;
        '''        &lt;firstname&gt;Massimiliano&lt;/firstname&gt;
        '''        &lt;nat&gt;ITA&lt;/nat&gt;
        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property LoadStartList() As String
            Get
                Return ResourceManager.GetString("LoadStartList", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
