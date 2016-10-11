// Write your Javascript code.



$(document).ready(function () {
    $(".col-md-4").mouseenter(function () {
        $(this).fadeTo(400, 0.5);
    }).mouseleave(function () {
        $(this).fadeTo(400, 1);
    });



    $(".picture").mouseenter(function () {
        $(this).css({ borderColor: "#000" });
    }).mouseleave(function(){
        $(this).css({ borderColor: "#fff" });
    });


});