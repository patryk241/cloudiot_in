﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ten kod został wygenerowany przez odpowiednie narzędzie.
'     Wersja środowiska wykonawczego: 4.0.30319.18033
'
'     Zmiany w tym pliku mogą być przyczyną niepoprawnego zachowania i zostaną utracone w przypadku
'     ponownego wygenerowania kodu.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My.Resources

    'Ta klasa została wygenerowana automatycznie przez klasę StronglyTypedResourceBuilder
    'za pomocą narzędzia, takiego jak ResGen lub Visual Studio.
    'Aby dodać lub usunąć składową, zmodyfikuj plik .ResX, a następnie uruchom ponownie program ResGen
    'z opcją /str lub odbuduj projekt VS.
    '<summary>
    '  Silnie typizowana klasa zasobów do wyszukiwania ciągów zlokalizowanych itp.
    '</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

        '<summary>
        '  Zwraca zbuforowane wystąpienie obiektu ResourceManager używane przez tę klasę.
        '</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("WebAPI_VB_NoAuth.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        '<summary>
        '  Zastępuje właściwość CurrentUICulture bieżącego wątku dla wszystkich
        '  przypadków wyszukiwania zasobów za pomocą tej silnie typizowanej klasy zasobów.
        '</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As Global.System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
    End Module
End Namespace
