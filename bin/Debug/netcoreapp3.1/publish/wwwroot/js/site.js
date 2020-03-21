// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var path = $(location).attr('href');
$(".nav-link").each( function() {
    console.log(path)
    console.log(this.href)
    if (path == this.href){
        $(this).addClass("active")
    }
});
