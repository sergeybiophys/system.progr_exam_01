// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//function ChckBoxClick() {

//   // int count = 0;

//    const chkBxs = document.querySelectorAll('.form-check-input');

//    chkBxs.forEach(function (item) {
//        //if (item.checked) {
//            console.log(item);
//        //}
//    });

//}

///*ChckBoxClick();*/


//function Foo() {
//    var overall = document.querySelectorAll('.form-check-input');
//    overall.addEventListener('click', ChckBoxClick);
//    console.log('hell0');
//}

//Foo();

$('.form-check-input').each(function () {
    //console.log('start');
    $(this).on('change', function () {

        if ($(this).is(':checked')) {
            console.log($(this).attr('name'));
        }
        else {
            console.log(minus: $(this).attr('name'));
        }
    });
    

});