Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web

Namespace DXWebApplication
    Public Class SettingsHelper

        Private Shared formLayoutItemSettingsMethod_Renamed As Action(Of MVCxFormLayoutItem)
        Public Shared ReadOnly Property FormLayoutItemSettingsMethod() As Action(Of MVCxFormLayoutItem)
            Get
                If formLayoutItemSettingsMethod_Renamed Is Nothing Then
                    formLayoutItemSettingsMethod_Renamed = CreateFormLayoutItemSettingsMethod()
                End If
                Return formLayoutItemSettingsMethod_Renamed
            End Get
        End Property
        Private Shared Function CreateFormLayoutItemSettingsMethod() As Action(Of MVCxFormLayoutItem)
            Return Sub(itemSettings)
                itemSettings.Width = Unit.Percentage(100)
                Dim editorSettings As Object = itemSettings.NestedExtensionSettings
                editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                editorSettings.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom
                editorSettings.Properties.ValidationSettings.Display = Display.Dynamic
                editorSettings.ShowModelErrors = True
                editorSettings.Width = Unit.Percentage(100)
            End Sub
        End Function
    End Class
End Namespace