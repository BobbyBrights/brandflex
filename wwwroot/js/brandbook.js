
// tooltip demo
$("[data-toggle=tooltip]").tooltip();

// popover demo
$("[data-toggle=popover]").popover();


$(document).ready(function () {
    var $body = $('body');
    /*------------------------------------------------
     Sidebar toggle menu
    -------------------------------------------------*/
    $body.on('click', '.navigation__sub > a', function (e) {
        e.preventDefault();

        $(this).parent().toggleClass('navigation__sub--toggled');
        $(this).next('ul').slideToggle(250);
    });
});