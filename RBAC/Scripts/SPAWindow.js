(function ($) {

    _submit = function(data, targeturl, options)
    {
        alert('submiting data');
    };
    $("#TestH").submit(function (event) {
        alert("Handler for .submit() called.");
        event.preventDefault();
    });


}(jQuery));