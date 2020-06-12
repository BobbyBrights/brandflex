// Navigation ACTIVE class
$(document).ready(function(){
	$('.navbar-nav a[href="' + document.location.pathname + '"]').addClass('active');
});

// Header switch class        
$(function() {
    var navheader = $(".navbar");
    $(window).scroll(function() {    
        var scroll = $(window).scrollTop();
    
        if (scroll >= 200) {
	        navheader.addClass("scrolled");
        } else {
	        navheader.removeClass("scrolled");
        }
    });
});

// tooltip demo
$("[data-toggle=tooltip]").tooltip();

// popover demo
$("[data-toggle=popover]").popover();

