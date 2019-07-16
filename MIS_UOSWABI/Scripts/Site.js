$(document).ready(function () {
    $(".nav-link").on("click", (event) => {
        $(".navbar-nav").find(".active").removeClass('active');
        $(event.target).parent().addClass('active');
    });

    var url = window.location;
    $('.navbar .nav').find('.active').removeClass('active');
    $('.navbar .nav li a').each(function () {
        if (this.href == url) {
            $(this).parent().addClass('active');
        }
    }); 
});