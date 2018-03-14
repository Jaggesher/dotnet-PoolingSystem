// Write your JavaScript code.
var i = 1;

$(document).ready(function() {
    $('#AddAnotherOption').on('click', addAnotherOption);

    // $('#contactTable').DataTable();

});

function addAnotherOption() {
    i++;
    $('#MultipleOptions').append('<div class = "form-group" ><label for = "Options_' + i + '_" > Options[' + i + '] </label> <input class = "form-control" type = "text" id ="Options_' + i + '_"name = "Options[' + i + ']" value = "" /><span class = "text-danger field-validation-valid" data-valmsg-for = "Options[' + i + ']" data-valmsg-replace = "true"> </span> </div>');
}