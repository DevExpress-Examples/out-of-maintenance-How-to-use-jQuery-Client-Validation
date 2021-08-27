<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/144776795/18.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830542)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->


## How to use jQuery Client Validation
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/144776795/)**
<!-- run online end -->

This example illustrates how user input can be easily validated using the jQuery Validation library. DevExpress MVC extensions provide you with full jQuery Client Validation support.

In this example, the jQuery Validation methods are used to specify validation rules for individual model fields on the client. You can find a full list of the validation methods on the jQuery Documentation page:  [Plugins/Validation - jQuery Wiki - List of built-in Validation methods](http://docs.jquery.com/Plugins/Validation#List_of_built-in_Validation_methods).

The  **rules:{...}**  block contains field names with validation atributes.

The  **messages:{...}**  block contains field names with related error messages that should be displayed to the end-users when the validation fails.

The DevExpress MVC  [ValidationSummary](http://help.devexpress.com/#AspNet/CustomDocument12360)  extension is used to summarize validation errors from multiple editors and then display them in a single block.

  
See Also:

-   [Online Documentation - jQuery Validation](http://help.devexpress.com/#AspNet/CustomDocument12061)
