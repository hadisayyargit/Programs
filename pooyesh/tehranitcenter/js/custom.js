jQuery.noConflict();



var $ = jQuery;



$(document).ready(function(){



$(".post-attachement").fitVids();
	$("#hide").click(function(){
	$("#option_panel").css({"right":"-196px"});
	$("#hide").css({"right":"196px", "opacity":"0"});
	$("#show").css({"right":"0px", "opacity":"1"});

})
$("#show").click(function(){
	$("#option_panel").css({"right":"0px"});
	$("#hide").css({"right":"196px", "opacity":"1"});
	$("#show").css({"right":"0px", "opacity":"0"});
})

	$('#to_boxed').click(function(){
		$("#newcolor").empty();
	$( "<style>#boxed_layout{width:1000px; margin:60px auto;}</style>" ).appendTo( "#newlayout" )
	})
	$('#to_wide').click(function(){
		$("#newcolor").empty();
	$( "<style>#boxed_layout{width:100%; margin:0px auto;}</style>" ).appendTo( "#newlayout" )
	})

var blacktheme = 0;
	$('#to_light').click(function(){
				$("#newcolor").empty();
				$("#newstyle").empty();
		blacktheme = 0;
	$( "<link rel='stylesheet' id='style-css'  href='http://ryuka-design.com/Maxon/wp-content/themes/Maxon/style.css' type='text/css' media='all' /><style>.tp-bannertimer{background:#fef332; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #fef332;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#fef332;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#fef332;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}</style>" ).appendTo( "#newstyle" );
	
	})
	$('#to_light_t').click(function(){
				$("#newcolor").empty();
				$("#newstyle").empty();				
		blacktheme = 0;
	$( "<link rel='stylesheet' id='style-css'  href='http://ryuka-design.com/Maxon/wp-content/themes/Maxon/style_trans.css' type='text/css' media='all' /><style>.tp-bannertimer{background:#fef332; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #fef332;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#fef332;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#fef332;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}#to_top_img{background-color:rgba(26, 29, 32, 0);</style>" ).appendTo( "#newstyle" );

	})				
	$('#to_dark').click(function(){
				$("#newcolor").empty();
				$("#newstyle").empty();					
		blacktheme = 1;
	$( "<link rel='stylesheet' id='style-css'  href='http://ryuka-design.com/Maxon/wp-content/themes/Maxon/style_dark.css' type='text/css' media='all' /><style>.tp-bannertimer{background:#fef332; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #fef332;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#fef332;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#fef332;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#fef332;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#fef332; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}</style>" ).appendTo( "#newstyle" );
	})
	$('#to_dark_t').click(function(){
				$("#newcolor").empty();
				$("#newstyle").empty();					
		blacktheme = 1;
	$( "<link rel='stylesheet' id='style-css'  href='http://ryuka-design.com/Maxon/wp-content/themes/Maxon/style_dark_trans.css' type='text/css' media='all' /><style>.tp-bannertimer{background:#fef332; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #fef332;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#fef332;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#fef332;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#fef332;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#fef332; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}#to_top_img{background-color:rgba(26, 29, 32, 0);</style>" ).appendTo( "#newstyle" );
})		

	$('#cb1').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#99c22a; border-radius:5px; }.tp-bannertimer{background:#99c22a; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #99c22a;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#99c22a;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#99c22a;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#99c22a;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#99c22a; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#99c22a; border-radius:5px; }.tp-bannertimer{background:#99c22a; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #99c22a;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#99c22a;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#99c22a;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
			
	$('#cb2').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#0eb3f3; border-radius:5px; }.tp-bannertimer{background:#0eb3f3; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #0eb3f3;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#0eb3f3;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#0eb3f3;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#0eb3f3;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#0eb3f3; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#0eb3f3; border-radius:5px; }.tp-bannertimer{background:#0eb3f3; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #0eb3f3;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#0eb3f3;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#0eb3f3;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})	
			
			
	$('#cb3').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#0ee1f3; border-radius:5px; }.tp-bannertimer{background:#0ee1f3; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #0ee1f3;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#0ee1f3;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#0ee1f3;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#0ee1f3;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#0ee1f3; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#0ee1f3; border-radius:5px; }.tp-bannertimer{background:#0ee1f3; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #0ee1f3;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#0ee1f3;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#0ee1f3;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})	
			
	$('#cb4').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#f08a1d; border-radius:5px; }.tp-bannertimer{background:#f08a1d; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f08a1d;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f08a1d;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f08a1d;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#f08a1d;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#f08a1d; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#f08a1d; border-radius:5px; }.tp-bannertimer{background:#f08a1d; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f08a1d;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f08a1d;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f08a1d;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cb5').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#f0581d; border-radius:5px; }.tp-bannertimer{background:#f0581d; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f0581d;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f0581d;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f0581d;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#f0581d;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#f0581d; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#f0581d; border-radius:5px; }.tp-bannertimer{background:#f0581d; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f0581d;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f0581d;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f0581d;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cb6').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#f01d9f; border-radius:5px; }.tp-bannertimer{background:#f01d9f; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f01d9f;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f01d9f;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f01d9f;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#f01d9f;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#f01d9f; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#f01d9f; border-radius:5px; }.tp-bannertimer{background:#f01d9f; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f01d9f;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f01d9f;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f01d9f;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cb7').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#9d1df0; border-radius:5px; }.tp-bannertimer{background:#9d1df0; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #9d1df0;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#9d1df0;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#9d1df0;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#9d1df0;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#9d1df0; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#9d1df0; border-radius:5px; }.tp-bannertimer{background:#9d1df0; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #9d1df0;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#9d1df0;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#9d1df0;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cb8').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#2b5ae1; border-radius:5px; }.tp-bannertimer{background:#2b5ae1; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #2b5ae1;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#2b5ae1;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#2b5ae1;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#2b5ae1;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#2b5ae1; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#2b5ae1; border-radius:5px; }.tp-bannertimer{background:#2b5ae1; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #2b5ae1;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#2b5ae1;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#2b5ae1;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cb9').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#e92255; border-radius:5px; }.tp-bannertimer{background:#e92255; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #e92255;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#e92255;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#e92255;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#e92255;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#e92255; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#e92255; border-radius:5px; }.tp-bannertimer{background:#e92255; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #e92255;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#e92255;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#e92255;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cb10').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#03bc79; border-radius:5px; }.tp-bannertimer{background:#03bc79; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #03bc79;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#03bc79;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#03bc79;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#03bc79;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#03bc79; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#03bc79; border-radius:5px; }.tp-bannertimer{background:#03bc79; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #03bc79;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#03bc79;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#03bc79;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})																										
	


	$('#cc1').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#99c22a; border-radius:5px; }.tp-bannertimer{background:#99c22a; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #99c22a;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#99c22a;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#99c22a;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#99c22a;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#99c22a; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#99c22a;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#99c22a; border-radius:5px; }.tp-bannertimer{background:#99c22a; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #99c22a;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#99c22a;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#99c22a;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#99c22a;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cc1').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#99c22a; border-radius:5px; }.tp-bannertimer{background:#99c22a; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #99c22a;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#99c22a;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#99c22a;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#99c22a;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#99c22a; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#99c22a;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#99c22a; border-radius:5px; }.tp-bannertimer{background:#99c22a; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #99c22a;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#99c22a;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#99c22a;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#99c22a;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})			

	$('#cc2').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#0eb3f3; border-radius:5px; }.tp-bannertimer{background:#0eb3f3; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #0eb3f3;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#0eb3f3;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#0eb3f3;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#0eb3f3;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#0eb3f3; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#0eb3f3;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#0eb3f3; border-radius:5px; }.tp-bannertimer{background:#0eb3f3; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #0eb3f3;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#0eb3f3;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#0eb3f3;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#0eb3f3;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})

	$('#cc3').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#0ee1f3; border-radius:5px; }.tp-bannertimer{background:#0ee1f3; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #0ee1f3;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#0ee1f3;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#0ee1f3;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#0ee1f3;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#0ee1f3; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#0ee1f3;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#0ee1f3; border-radius:5px; }.tp-bannertimer{background:#0ee1f3; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #0ee1f3;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#0ee1f3;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#0ee1f3;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#0ee1f3;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cc4').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#f08a1d; border-radius:5px; }.tp-bannertimer{background:#f08a1d; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f08a1d;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f08a1d;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f08a1d;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#f08a1d;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#f08a1d; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#f08a1d;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#f08a1d; border-radius:5px; }.tp-bannertimer{background:#f08a1d; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f08a1d;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f08a1d;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f08a1d;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#f08a1d;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cc5').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#f0581d; border-radius:5px; }.tp-bannertimer{background:#f0581d; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f0581d;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f0581d;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f0581d;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#f0581d;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#f0581d; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#f0581d;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#f0581d; border-radius:5px; }.tp-bannertimer{background:#f0581d; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f0581d;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f0581d;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f0581d;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#f0581d;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cc6').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#f01d9f; border-radius:5px; }.tp-bannertimer{background:#f01d9f; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f01d9f;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f01d9f;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f01d9f;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#f01d9f;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#f01d9f; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#f01d9f;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#f01d9f; border-radius:5px; }.tp-bannertimer{background:#f01d9f; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #f01d9f;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#f01d9f;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#f01d9f;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#f01d9f;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cc7').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#9d1df0; border-radius:5px; }.tp-bannertimer{background:#9d1df0; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #9d1df0;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#9d1df0;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#9d1df0;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#9d1df0;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#9d1df0; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#9d1df0;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#9d1df0; border-radius:5px; }.tp-bannertimer{background:#9d1df0; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #9d1df0;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#9d1df0;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#9d1df0;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#9d1df0;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cc8').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#2b5ae1; border-radius:5px; }.tp-bannertimer{background:#2b5ae1; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #2b5ae1;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#2b5ae1;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#2b5ae1;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#2b5ae1;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#2b5ae1; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#2b5ae1;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#2b5ae1; border-radius:5px; }.tp-bannertimer{background:#2b5ae1; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #2b5ae1;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#2b5ae1;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#2b5ae1;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#2b5ae1;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cc9').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#e92255; border-radius:5px; }.tp-bannertimer{background:#e92255; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #e92255;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#e92255;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#e92255;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#e92255;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#e92255; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#e92255;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#e92255; border-radius:5px; }.tp-bannertimer{background:#e92255; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #e92255;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#e92255;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#e92255;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#e92255;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
	$('#cc10').click(function(){
	if(blacktheme === 1) {
		 $("#newcolor").empty();
$( "<style>img[alt='colored'] {background-color:#03bc79; border-radius:5px; }.tp-bannertimer{background:#03bc79; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #03bc79;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#03bc79;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#03bc79;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}.sb_widget a{color:#a9a9a9;}.pagination a{color:#ffffff;}.post-title a,.post-sep,.sc_divider span,.page_title,#crumbs a,#crumbs .current,.section h1,.section h2,.section h3,.section h4,.section h5,.section h6,.testimonial-author a{color:#03bc79;}input[type=submit], .pagination .current ,.pagination a.active, .pagination a:active,.pagination a:hover{background-color:#03bc79; border-none; color:#000000;}#sidebar h4,.icon_box h5{color:#767676} header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#03bc79;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )			
}else{
	$("#newcolor").empty();
	$( "<style>img[alt='colored'] {background-color:#03bc79; border-radius:5px; }.tp-bannertimer{background:#03bc79; opacity:0.9; max-height:3px;}.tab-holder .tabs li.active a{border-top:3px solid #03bc79;}.testimonial-next:hover, .testimonial-prev:hover,.ta_c,.carousel_left:hover, .carousel_right:hover,.partners_left:hover, .partners_right:hover,.pb_bg,.page-numbers:hover,.current,.pricetable .pricetable-button-container a:hover,.post-date-ctn,#options a.active, #options a:active, #options .selected a,#footer .wpcf7 input[type=submit],.get_portfolio_works_btn,.port_hover,#to_top_img,.post-content .more:hover,.pricetable .pricetable-button-container a{background-color:#03bc79;}#footer a:hover,.testimonial-author a:hover,a,.post a:hover,#comments a:hover,.widget_post_title a:hover,.more:hover,.sb_widget a:hover,nav ul li a:hover,.current-menu-item a,#mobile-menu ul ul li a:before,.portfolio_desc h5 a,#information h4,#port_gallery h4,nav ul ul .current-menu-item a,nav ul ul li:hover a{color:#03bc79;}.top_email a,.post .button_sc_ ,nav ul ul li a,nav ul ul .current-menu-item a:hover{color:#fff;}.pricetable-featured .pricetable-button-container a{background-color:#151515;}.tweets li p a{color:#34a6fe;}#crumbs a, #crumbs .current{color:#353535; background:none;}.widget_post_title a,.more{color:#444444}.details span.date a{color:#626262;}.isotope-item a,.portfolio_desc a{color:#888}.pagination a,.sb_widget a,.cmt_nb a,#respond a,.post-title a:hover{color:#000000}#footer a{color:#666}header,header .wrapper,#search-form input[type=text],#search-form input[type=submit],#search-form{background-color:#03bc79;}nav ul li a:hover, .current-menu-item a{color:#000000;}nav ul a:after,nav ul li a:hover:after,nav ul li.current-menu-item a:after{color:#fff;}"+blacktheme+"</style>" ).appendTo( "#newcolor" )
	}
			})
			
																								

	$('#bg01').click(function(){
	$( "<style>body{background:url(http://ryuka-design.com/Maxon/wp-content/themes/Maxon/bg/bg01.jpg) fixed top center; -webkit-background-size: cover; -moz-background-size: cover; -o-background-size: cover; background-size: cover;</style>" ).appendTo( "#newbg" )
	})
	$('#bg02').click(function(){
	$( "<style>body{background:url(http://ryuka-design.com/Maxon/wp-content/themes/Maxon/bg/bg02.jpg) fixed top center; -webkit-background-size: cover; -moz-background-size: cover; -o-background-size: cover; background-size: cover;</style>" ).appendTo( "#newbg" )
	})
	$('#bg03').click(function(){
	$( "<style>body{background:url(http://ryuka-design.com/Maxon/wp-content/themes/Maxon/bg/bg03.jpg) fixed top center; -webkit-background-size: cover; -moz-background-size: cover; -o-background-size: cover; background-size: cover;</style>" ).appendTo( "#newbg" )
	})
	$('#bg04').click(function(){
	$( "<style>body{background:url(http://ryuka-design.com/Maxon/wp-content/themes/Maxon/bg/bg04.jpg) fixed top center; -webkit-background-size: cover; -moz-background-size: cover; -o-background-size: cover; background-size: cover;</style>" ).appendTo( "#newbg" )
	})
	

	
$(window).load(function() {



//*** Loading effect ***//



$('#map_canvas').append('<div id="top_shadow"></div>');

$('.rev_slider').append('<div id="top_shadow"></div>');	



$('.column br').remove();



});



$('#to_top').click(function () {



			$('body,html').animate({



				scrollTop: 0



			}, 800);



			return false;



		});



//*** Search form ***//	



var searchvisible = 0;            

    $("#searchtop").click(function(e){ 

        //This stops the page scrolling to the top on a # link.

        e.preventDefault();

        if (searchvisible ===0) {

            //Search is currently hidden. Slide down and show it.

            $("#search-form").slideDown('1000','easeInOutBack');

            $("#s").focus(); //Set focus on the search input field.

            searchvisible = 1; //Set search visible flag to visible.

        } else {

            //Search is currently showing. Slide it back up and hide it.

            $("#search-form").slideUp('400','linear');

            searchvisible = 0;

        }

    });







$(function(){



	$('nav ul').superfish({ 



            animation: {height:'show'},   // slide-down effect without fade-in 



            delay:     1000               // 1.2 second delay on mouseout 



        }); 



});



//*** Toggle ***//	



$('.toggle-content').each(function() {



if(!$(this).hasClass('default-open')){



$(this).hide();



}



});



$("div.toggle").click(function(){



if($(this).hasClass('active')){



$(this).removeClass("active");



}else{



$(this).addClass("active");



}



return false;



});



$("div.toggle").click(function(){



$(this).next(".toggle-content").slideToggle();



});



//*** Tabs ***//	



$('.tabs-wrapper').each(function() {



$(this).find(".tab_content").hide(); //Hide all content



$(this).find("ul.tabs li:first").addClass("active").show(); //Activate first tab



$(this).find(".tab_content:first").show(); //Show first tab content



});



//On Click Event



$("ul.tabs li").click(function(e) {



$(this).parents('.tabs-wrapper').find("ul.tabs li").removeClass("active"); //Remove any "active" class



$(this).addClass("active"); //Add "active" class to selected tab



$(this).parents('.tabs-wrapper').find(".tab_content").hide(); //Hide all tab content



var activeTab = $(this).find("a").attr("href"); //Find the href attribute value to identify the active tab + content



$(this).parents('.tabs-wrapper').find(activeTab).fadeIn(); //Fade in the active ID content



e.preventDefault();



});



$("ul.tabs li a").click(function(e) {



e.preventDefault();



});	





//*** Change nav button ***//

      



	





$("<div id='nav_button' />").appendTo("nav");







$(window).resize(function() {



if ($(window).width() > 1020) {

	

	$("#mobile-menu").slideUp('400','linear');

	var mobilenav = 0;

$("nav ul").show();



$("nav ul a").click(function(){



$("nav ul").show();



})



}



if ($(window).width() < 1020) { 

var mobilenav = 0;

$("nav ul").hide();



$("#nav_button").show();



}



});

var mobilenav = 0;            

    $("#nav_button").click(function(e){ 

        e.preventDefault();

        if (mobilenav ===0) {

            $("#mobile-menu").slideDown('700','linear');

            mobilenav = 1;

        } else {



            $("#mobile-menu").slideUp('700','linear');

            mobilenav = 0;

        }

    });

$(function() {



//*** Portfolio filter effect ***//



$("#portfolio-filter li a").click(function(){



$("#portfolio-filter li a").removeClass("active");



$(this).addClass("active");



});



});



//*** Share icon effect ***//



$('.social-networks li, .share-box li, .social-icon, .social li').mouseenter(function(){



$(this).find('.popup').fadeIn();



});



$('.social-networks li, .share-box li, .social-icon, .social li').mouseleave(function(){



$(this).find('.popup').fadeOut();



});



//*** Load Flexsliders ***//



$('.flexslider').flexslider({



animation: "slide",              //String: Select your animation type, "fade" or "slide"



slideDirection: "horizontal",



directionNav: true,



start: function(slider){ // init the height of the first item on start



var $new_height = slider.slides.eq().height();     



slider.height($new_height);                                     



},          



before: function(slider){ // init the height of the next item before slide



var $new_height = slider.slides.eq(slider.animatingTo).height();                



if($new_height != slider.height()){



slider.animate({ height: $new_height  }, 400);



}



}          



});



//*** Setup prettyPhoto ***//



$('.blog_post_single a').has('img').addClass('prettyPhoto');



$('.blog_post_single a img').click(function () {  



var desc = $(this).attr('title');  



$('.blog_post_single a').has('img').attr('title', desc);  



});



$("a[class^='prettyPhoto']").prettyPhoto({



opacity: 0.50,



theme: 'light_square',



show_title: false,



horizontal_padding: 20,



social_tools: false



});



$('#page_content a').has('img').addClass('prettyPhoto');



$('#page_content a img').click(function () {  



var desc = $(this).attr('title');  



$('#page_content a').has('img').attr('title', desc);  



});



$("a[class^='prettyPhoto']").prettyPhoto({



opacity: 0.50,



theme: 'light_square',



show_title: false,



horizontal_padding: 20,



social_tools: false



});





//*** Testimonials ***//



$(window).load(function() {



$(".testimonials-wrapper .testimonial").first().show().addClass('active').siblings('.testimonial').hide().removeClass('active');



$(".testimonials-wrapper .testimonial-next").click(function(){



if (typeof($finish)=="undefined" || $finish == true)



$finish = false;



else



return false;



if ($(this).parent().find('.testimonial.active').next('.testimonial').length == 0) {



$(this).parent().find('.testimonial.active').animate({ left: '300%' },{ duration: 300, easing: 'easeInOutExpo', complete: function(){



$(this).hide().removeClass('active').parent().find('.testimonial').first().addClass('active').css('position','relative').css('left','-300%').fadeIn().animate({left:0},{ duration: 400, easing: 'easeInOutExpo', complete: function() { $finish = true; } });



}});



} else {



$(this).parent().find('.testimonial.active').animate({ left: '300%' },{ duration: 300, easing: 'easeInOutExpo', complete: function(){



$(this).hide().removeClass('active').css('position','absolute').next('.testimonial').addClass('active').css('position','relative').css('left','-300%').fadeIn().animate({left:0},{ duration: 400, easing: 'easeInOutExpo', complete: function() { $finish = true; } });



}});



}



});



$(".testimonials-wrapper .testimonial-prev").click(function(){



if (typeof($finish)=="undefined" || $finish == true)



$finish = false;



else



return false;



if ($(this).parent().find('.testimonial.active').prev('.testimonial').length == 0) {



$(this).parent().find('.testimonial.active').animate({ left: '-300%' },{ duration: 300, easing: 'easeInOutExpo', complete: function(){



$(this).hide().removeClass('active').parent().find('.testimonial').last().addClass('active').css('position','relative').css('left','300%').fadeIn().animate({left:0},{ duration: 400, easing: 'easeInOutExpo', complete: function() { $finish = true; } });



}});



} else {



$(this).parent().find('.testimonial.active').animate({ left: '-300%' },{ duration: 300, easing: 'easeInOutExpo', complete: function(){



$(this).hide().removeClass('active').css('position','absolute').prev('.testimonial').addClass('active').css('position','relative').css('left','300%').fadeIn().animate({left:0},{ duration: 400, easing: 'easeInOutExpo', complete: function() { $finish = true; } });



}});



}			



});



});



});







