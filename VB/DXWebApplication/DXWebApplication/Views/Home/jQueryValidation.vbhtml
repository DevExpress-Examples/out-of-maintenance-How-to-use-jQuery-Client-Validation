@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@ModelType DXWebApplication.JQueryValidationData

<script type="text/javascript">
    $().ready(function () {
        $("#jQueryValidationForm").validate({
            showErrors: function (errorMap, errorList) {
            },
            rules: {
                Author: {
                    required: true
                },
                Publisher: {
                    maxlength: 10
                },
                ReleaseDate: {
                    required: true,
                    remote: '@(Url.Action("CheckReleaseDate", "Home"))'
                },
                Annotation: {
                    required: true
                }
            },
            messages: {
                Author: {
                    required: "Author is required"
                },
                Publisher: {
                    range: "Must be under 10 characters"
                },
                ReleaseDate: {
                    required: "Release date is required",
                    remote: "Release date can not be earlier than today"
                },
                Annotation: {
                    required: "Annotation is required"
                }
            }
        });
    });
</script>

@Code
    Html.EnableClientValidation(false)
    Html.EnableUnobtrusiveJavaScript(false)
End Code

@Using Html.BeginForm("jQueryValidation", "Home", FormMethod.Post, New With {.id = "jQueryValidationForm", .class = "edit_form"})
    @Html.DevExpress().FormLayout(Sub(settings)
                                       settings.Name = "jQueryValidationFormLayout"
                                       settings.ControlStyle.CssClass = "formLayoutMaxWidth"
                                       settings.Width = 400
                                       settings.UseDefaultPaddings = False
                                       settings.Items.Add(Function(m) m.Author).NestedExtension().TextBox(Sub(textBoxSettings)
                                                                                                              textBoxSettings.Properties.ValidationSettings.Display = Display.None
                                                                                                              textBoxSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                                                                                                              textBoxSettings.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom
                                                                                                              textBoxSettings.ShowModelErrors = True
                                                                                                              textBoxSettings.Width = Unit.Percentage(100)
                                                                                                          End Sub)


                                       settings.Items.Add(Function(m) m.Publisher, Sub(itemSettings)
                                                                                       itemSettings.NestedExtension().TextBox(Sub(textBoxSettings)
                                                                                                                                  textBoxSettings.Properties.ValidationSettings.Display = Display.None
                                                                                                                                  textBoxSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                                                                                                                                  textBoxSettings.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom
                                                                                                                                  textBoxSettings.ShowModelErrors = True
                                                                                                                                  textBoxSettings.Width = Unit.Percentage(100)
                                                                                                                              End Sub)
                                                                                       itemSettings.HelpText = "Must be under 10 characters"
                                                                                       itemSettings.Width = Unit.Percentage(100)
                                                                                   End Sub)

                                       settings.Items.Add(Function(m) m.ReleaseDate, Sub(itemSettings)
                                                                                         itemSettings.HelpText = "Cannot be earlier than today"
                                                                                         itemSettings.Width = Unit.Percentage(100)
                                                                                         itemSettings.NestedExtension().DateEdit(Sub(dateEditSettings)
                                                                                                                                     dateEditSettings.Properties.ValidationSettings.Display = Display.None
                                                                                                                                     dateEditSettings.Properties.CalendarProperties.FastNavProperties.DisplayMode = FastNavigationDisplayMode.Inline
                                                                                                                                     dateEditSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                                                                                                                                     dateEditSettings.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom
                                                                                                                                     dateEditSettings.ShowModelErrors = True
                                                                                                                                     dateEditSettings.Width = Unit.Percentage(100)
                                                                                                                                 End Sub)
                                                                                     End Sub)
                                       settings.Items.Add(Function(m) m.Annotation, Sub(itemSettings)
                                                                                        itemSettings.Width = Unit.Percentage(100)
                                                                                        itemSettings.NestedExtension().Memo(Sub(memoSettings)
                                                                                                                                memoSettings.ShowModelErrors = True
                                                                                                                                memoSettings.Properties.ValidationSettings.Display = Display.None
                                                                                                                                memoSettings.Width = Unit.Percentage(100)
                                                                                                                                memoSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                                                                                                                                memoSettings.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom
                                                                                                                                memoSettings.ShowModelErrors = True
                                                                                                                            End Sub)
                                                                                    End Sub)
                                       settings.Items.Add(Sub(itemSettings)
                                                              itemSettings.ShowCaption = DefaultBoolean.False
                                                              itemSettings.SetNestedContent(Sub()
                                                                                                Html.DevExpress().ValidationSummary().Render()
                                                                                            End Sub)
                                                          End Sub)
                                       settings.Items.Add(Sub(itemSettings)
                                                              itemSettings.ShowCaption = DefaultBoolean.False
                                                              itemSettings.HorizontalAlign = FormLayoutHorizontalAlign.Right
                                                              itemSettings.SetNestedContent(Sub()
                                                                                                Html.DevExpress().Button(Sub(btnSettings)
                                                                                                                             btnSettings.Name = "btnUpdate"
                                                                                                                             btnSettings.Text = "Send"
                                                                                                                             btnSettings.ControlStyle.CssClass = "flButton"
                                                                                                                             btnSettings.UseSubmitBehavior = True
                                                                                                                         End Sub).Render()
                                                                                                Html.DevExpress().Button(Sub(btnSettings)
                                                                                                                             btnSettings.Name = "btnClear"
                                                                                                                             btnSettings.Text = "Clear"
                                                                                                                             btnSettings.ControlStyle.CssClass = "flButton"
                                                                                                                             btnSettings.ClientSideEvents.Click = "function(s, e){ ASPxClientEdit.ClearEditorsInContainer(); }"
                                                                                                                         End Sub).Render()
                                                                                            End Sub)
                                                          End Sub)
                                   End Sub).GetHtml()
End Using
