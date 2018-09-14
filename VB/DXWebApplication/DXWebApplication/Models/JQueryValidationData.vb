Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace DXWebApplication
    Public Class JQueryValidationData
        <Display(Name:="Author:"), Required(ErrorMessage:="Author is required")>
        Public Property Author() As String

        <Display(Name:="Publisher:"), StringLength(10, ErrorMessage:="Must be under 10 characters")>
        Public Property Publisher() As String

        <Display(Name:="Release Date:"), Required(ErrorMessage:="Release date is required"), Remote("CheckReleaseDate", "Common", ErrorMessage:="Release date can not be earlier than today")>
        Public Property ReleaseDate() As Date

        <Display(Name:="Annotation:"), Required(ErrorMessage:="Annotation is required")>
        Public Property Annotation() As String
    End Class
End Namespace