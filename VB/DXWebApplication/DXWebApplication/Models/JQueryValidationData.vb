Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web

Namespace DXWebApplication
    Public Class JQueryValidationData
        <Display(Name := "Author:"), Required(ErrorMessage := "Author is required")> _
        Public Property Author() As String

        <Display(Name := "Publisher:"), StringLength(10, ErrorMessage := "Must be under 10 characters")> _
        Public Property Publisher() As String

        <Display(Name := "Release Date:"), Required(ErrorMessage := "Release date is required"), Remote("CheckReleaseDate", "Common", ErrorMessage := "Release date can not be earlier than today")> _
        Public Property ReleaseDate() As Date

        <Display(Name := "Annotation:"), Required(ErrorMessage := "Annotation is required")> _
        Public Property Annotation() As String
    End Class
End Namespace