

## How to use jQuery Client Validation

This example illustrates how user input can be easily validated using the jQuery Validation library. DevExpress MVC extensions provide you with full jQuery Client Validation support.

In this example, the jQuery Validation methods are used to specify validation rules for individual model fields on the client. You can find a full list of the validation methods on the jQuery Documentation page:  [Plugins/Validation - jQuery Wiki - List of built-in Validation methods](https://github.com/jquery-validation/jquery-validation/blob/master/README.md).

The  **rules:{...}**  block contains field names with validation atributes.

The  **messages:{...}**  block contains field names with related error messages that should be displayed to the end-users when the validation fails.

The DevExpress MVC  [ValidationSummary](http://help.devexpress.com/#AspNet/CustomDocument12360)  extension is used to summarize validation errors from multiple editors and then display them in a single block.

  
See Also:

-   [Online Documentation - jQuery Validation](http://help.devexpress.com/#AspNet/CustomDocument12061)
