$(document).ready(function(){
    $('.owl-carousel').owlCarousel({
        loop:true,
        margin:50,
        nav:false,
        autoWidth: true,
        autoplay: true,
        center: true,
        dots: false,
        items:1,
        margin:10,
        autoHeight: true,
        responsive:{
            0:{
                items:1
            },
            600:{
                items:3
            },
            1000:{
                items:5
            }
        }
    })
});
