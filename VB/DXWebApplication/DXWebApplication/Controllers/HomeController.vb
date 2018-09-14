Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace DXWebApplication
    <ValidateInput(False)> _
    Public Class HomeController
        Inherits Controller

        Public ReadOnly Property Name() As String
            Get
                Return "Common"
            End Get
        End Property

        Public Function Index() As ActionResult
            Return RedirectToAction("ModelValidation")
        End Function
        Public Function jQueryValidation() As ActionResult
            Return View("jQueryValidation", New JQueryValidationData())
        End Function
        <HttpPost> _
        Public Function jQueryValidation(ByVal validationData As JQueryValidationData) As ActionResult
            If Request.Params("btnUpdate") Is Nothing Then
                ModelState.Clear()
                Return View("jQueryValidation", validationData)
            End If

            If ModelState.IsValid Then
                Return View("_ValidationSuccess")
            End If
            Return View("jQueryValidation", validationData)
        End Function
        Public Function CheckReleaseDate(ByVal ReleaseDate As Date) As JsonResult
            Return Json(ReleaseDate >= Date.Today, JsonRequestBehavior.AllowGet)
        End Function
    End Class


End Namespace