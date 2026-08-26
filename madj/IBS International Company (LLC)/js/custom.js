jQuery(document).ready(function() {
	// ==================================================
	// change menu on mobile version
	// ==================================================
	domready(function(){
		selectnav('mainmenu', {
			label: 'Menu',
			nested: true,
			indent: '-'
		});
	});
	
	
	// ==================================================
	// paralax background
	// ==================================================
	$window = jQuery(window);
   	jQuery('section[data-type="background"]').each(function(){
    var $bgobj = jQuery(this); // assigning the object
                    
    jQuery(window).scroll(function() {
	var yPos = -($window.scrollTop() / $bgobj.data('speed')); 
	var coords = '50% '+ yPos + 'px';
	$bgobj.css({ backgroundPosition: coords });
		
	});
 	});
	document.createElement("article");
	document.createElement("section");
	
	
	// ==================================================
	// static header on scroll
	// ==================================================
	jQuery(window).scroll(function(){ 
	  if (jQuery(this).scrollTop() > 50){  
		jQuery('body').addClass("att2");
		jQuery('header').addClass("att1");
		jQuery('header .info').addClass('h_info_hide');
		
	  } 
	  else{
		// ==================================================
		//back to default styles
		// ==================================================
		jQuery('body').removeClass("att2");
		jQuery('header').removeClass("att1");
		jQuery('header .info').removeClass('h_info_hide');
	  }
	});
	
	
	// ==================================================
	// filtering gallery
	// ==================================================	
	var $container = jQuery('#gallery');
		$container.isotope({
			itemSelector: '.item',
			filter: '*',
	});
	jQuery('#filters a').click(function(){
		var $this = jQuery(this);
		if ( $this.hasClass('selected') ) {
			return false;
			}
		var $optionSet = $this.parents();
		$optionSet.find('.selected').removeClass('selected');
		$this.addClass('selected');
				
		var selector = jQuery(this).attr('data-filter');
		$container.isotope({ 
		filter: selector,
	});
	return false;
	});
	
	
	// ==================================================
	// prettyPhoto function
	// ==================================================	
	jQuery("area[rel^='prettyPhoto']").prettyPhoto();
	jQuery(".gallery:first a[rel^='prettyPhoto']").prettyPhoto({animation_speed:'fast',theme:'light_square',slideshow:3000, autoplay_slideshow: false});
	jQuery(".gallery:gt(0) a[rel^='prettyPhoto']").prettyPhoto({animation_speed:'fast',slideshow:10000, hideflash: true});
		
	jQuery("#custom_content a[rel^='prettyPhoto']:first").prettyPhoto({
		custom_markup: '<div id="map_canvas" style="width:260px; height:265px"></div>',
		changepicturecallback: function(){ initialize(); }
	});
	jQuery("#custom_content a[rel^='prettyPhoto']:last").prettyPhoto({
		custom_markup: '<div id="bsap_1259344" class="bsarocks bsap_d49a0984d0f377271ccbf01a33f2b6d6"></div><div id="bsap_1237859" class="bsarocks bsap_d49a0984d0f377271ccbf01a33f2b6d6" style="height:260px"></div><div id="bsap_1251710" class="bsarocks bsap_d49a0984d0f377271ccbf01a33f2b6d6"></div>',
		changepicturecallback: function(){ _bsap.exec(); }
	});
	
	
	// ==================================================
	// scroll to top
	// ==================================================	
	jQuery().UItoTop({ easingType: 'easeOutQuart' });
	
	
	// ==================================================
	// lazyload
	// ==================================================	
	 $(function() {
          $("img").lazyload({
              effect : "fadeIn",
			  effectspeed: 900 

          });
      });
	  
	  
	// ==================================================
	// gallery hover
	// ==================================================	
	jQuery('.gallery .item').hover(function() {
	jQuery('.gallery .item').not(jQuery(this)).stop().animate({opacity: .3}, 100);
	}, function() {
	jQuery('.gallery .item').stop().animate({opacity: 1});}, 100);
	
	
	// ==================================================
	// resize
	// ==================================================	
	window.onresize = function(event) {
		jQuery('#gallery').isotope('reLayout');
  	};
});

