(function ($) {
"use strict";  
    
/*------------------------------------
	Sticky Menu 
--------------------------------------*/
 var windows = $(window);
    var stick = $(".header-sticky");
	windows.on('scroll',function() {    
		var scroll = windows.scrollTop();
		if (scroll < 5) {
			stick.removeClass("sticky");
		}else{
			stick.addClass("sticky");
		}
	});  
/*------------------------------------
	jQuery MeanMenu 
--------------------------------------*/
	$('.main-menu nav').meanmenu({
		meanScreenWidth: "767",
		meanMenuContainer: '.mobile-menu'
	});
    

    
    /* last  2 li child add class */
    $('ul.menu>li').slice(-2).addClass('last-elements');


/*------------------------------------
    Search
--------------------------------------*/
    $(document).on('keyup', '#searchTeachers', function () {
        var searchedTeacherName = $(this).val()

        $.ajax({
            url: `/teacher/search?searchedTeacher=${searchedTeacherName}`,
            type: "GET",

            success: function (response) {
                $('#searchedTeacher').slice(1)
                $('#searchedTeacher').append(response)
            },

            error: function (xhr) {

            }
        });
    })
    
/*------------------------------------
        Load More Teacher
--------------------------------------*/
    var skip = 4;
    $(document).on('click', '#loadMore', function () {
        var teacherCount = $("#teacherCount").val();
        $.ajax({
            url: "/teacher/loadTeachers?skip=" + skip,
            type: "GET",
            success: function (response) {
                $("#teacherRow").append(response);
                skip += 4;

                if (skip >= teacherCount)
                    $("#loadMore").remove();

                console.log(response);
            },
            error: function (xhr) {

            }
        });
    })

    /*------------------------------------
        Load More Event
--------------------------------------*/
    var skipEvent = 3;

    $(document).on('click', '#loadEvent', function () {
        var eventCount = $('#eventCount').val()
        $.ajax({
            url: "/event/loadevents?skip=" + skipEvent,
            type: "GET",

            success: function (response) {
                $('#eventRow').append(response)
                skipEvent += 3;

                if (skipEvent >= eventCount)
                    $('#loadEvent').remove()
            },

            error: function (xhr) {

            }
        });
    })



/*------------------------------------
	Owl Carousel
--------------------------------------*/
    $('.slider-owl').owlCarousel({
        loop:true,
        nav:true,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        smartSpeed: 2500,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });

    $('.partner-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:3
            },
            1000:{
                items:5
            }
        }
    });  

    $('.testimonial-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });
/*------------------------------------
	Video Player
--------------------------------------*/
    $('.video-popup').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        zoom: {
            enabled: true,
        }
    });
    
    $('.image-popup').magnificPopup({
        type: 'image',
        gallery:{
            enabled:true
        }
    }); 
/*----------------------------
    Wow js active
------------------------------ */
    new WOW().init();
/*------------------------------------
	Scrollup
--------------------------------------*/
    $.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });
/*------------------------------------
	Nicescroll
--------------------------------------*/
     $('body').scrollspy({ 
            target: '.navbar-collapse',
            offset: 95
        });
$(".notice-left").niceScroll({
            cursorcolor: "#EC1C23",
            cursorborder: "0px solid #fff",
            autohidemode: false,
            
        });

})(jQuery);	