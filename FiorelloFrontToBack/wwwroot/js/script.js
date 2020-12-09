
$(document).ready(function () {
    let skip = 8;
    let $count = $("#count").val();
    let $loader = $("#loader");
    let test = $("#tes").val();
    let idd = $(".btnDel").attr("data-id")

    

    let value = document.querySelectorAll("#tes").value

    //let id = document.querySelectorAll(".btnDel");
    //id.forEach(function (item, index) {
    //    item.addEventListener("click", function () {
    //        $.ajax({
    //            url: "/Home/DeleteBasket?id=" + item.getAttribute("data-id"),
    //            type: "get",
    //            success: function (res) {
    //                console.log(res)
    //            }
    //        })
    //    })
    //})

    //$(document).on("click", ".btnDel", function () {
    //    $.ajax({
    //        )
    //})
   
   
    $(document).on("click", "#loadMore", function () {
        $loader.removeClass("d-none")
        $(this).css("display", "none")
        setTimeout(() => {
            $loader.addClass("d-none")
            $(this).css("display", "block")
        }, 1000);

        $.ajax({
            url: "/Product/LoadMore?skip="+skip,
            type: "GET",
            success: function (response) {
                setTimeout(() => {
                    $("#proList").append(response)
                    skip += 8;
                    if (skip >= $count) {
                        $("#loadMore").remove()
                        console.log("Skip: ", skip)
                        console.log("Count: ", $count)
                    }
                }, 900) //Thats for loading. Actually will not be into setTimeOut
            }
        })
    })

    $(document).on("click", "#addtocard", function () {
        $.ajax({
            url: "/home/addbasket?id="+$id,
            type: "get",
            success: function (response) {
                console.log($id)
            }
        })
    })

    $(document).on('click', '#search', function () {
        $(this).next().toggle();
    })

    $(document).on('click', '#mobile-navbar-close', function () {
        $(this).parent().removeClass("active");

    })
    $(document).on('click', '#mobile-navbar-show', function () {
        $('.mobile-navbar').addClass("active");

    })

    $(document).on('click', '.mobile-navbar ul li a', function () {
        if ($(this).children('i').hasClass('fa-caret-right')) {
            $(this).children('i').removeClass('fa-caret-right').addClass('fa-sort-down')
        }
        else {
            $(this).children('i').removeClass('fa-sort-down').addClass('fa-caret-right')
        }
        $(this).parent().next().slideToggle();
    })

    // SLIDER

    $(document).ready(function(){
        $(".slider").owlCarousel(
            {
                items: 1,
                loop: true,
                autoplay: true
            }
        );
      });

    // PRODUCT

    $(document).on('click', '.categories', function(e)
    {
        e.preventDefault();
        $(this).next().next().slideToggle();
    })

    $(document).on('click', '.category li a', function (e) {
        e.preventDefault();
        let category = $(this).attr('data-id');
        let products = $('.product-item');
        
        products.each(function () {
            if(category == $(this).attr('data-id'))
            {
                $(this).parent().fadeIn();
            }
            else
            {
                $(this).parent().hide();
            }
        })
        if(category == 'all')
        {
            products.parent().fadeIn();
        }
    })

    // ACCORDION 

    $(document).on('click', '.question', function()
    {   
       $(this).siblings('.question').children('i').removeClass('fa-minus').addClass('fa-plus');
       $(this).siblings('.answer').not($(this).next()).slideUp();
       $(this).children('i').toggleClass('fa-plus').toggleClass('fa-minus');
       $(this).next().slideToggle();
       $(this).siblings('.active').removeClass('active');
       $(this).toggleClass('active');
    })

    // TAB

    $(document).on('click', 'ul li', function()
    {   
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().next().children('p.active').removeClass('active');

        $(this).parent().next().children('p').each(function()
        {
            if(dataId == $(this).attr('data-id'))
            {
                $(this).addClass('active')
            }
        })
    })

    $(document).on('click', '.tab4 ul li', function()
    {   
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().parent().next().children().children('p.active').removeClass('active');

        $(this).parent().parent().next().children().children('p').each(function()
        {
            if(dataId == $(this).attr('data-id'))
            {
                $(this).addClass('active')
            }
        })
    })

    // INSTAGRAM

    $(document).ready(function(){
        $(".instagram").owlCarousel(
            {
                items: 4,
                loop: true,
                autoplay: true,
                responsive:{
                    0:{
                        items:1
                    },
                    576:{
                        items:2
                    },
                    768:{
                        items:3
                    },
                    992:{
                        items:4
                    }
                }
            }
        );
      });

      $(document).ready(function(){
        $(".say").owlCarousel(
            {
                items: 1,
                loop: true,
                autoplay: true
            }
        );
      });
})