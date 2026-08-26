jQuery(document).ready(function() {
	
	jQuery(".bg1").click(function(){
		jQuery("#colors").attr("href", "css/colors/beige.css");
	});
	
	jQuery(".bg2").click(function(){
		jQuery("#colors").attr("href", "css/colors/blue.css");
	});
	
	jQuery(".bg3").click(function(){
		jQuery("#colors").attr("href", "css/colors/cyan.css");
	});
	
	jQuery(".bg4").click(function(){
		jQuery("#colors").attr("href", "css/colors/green.css");
	});
	
	jQuery(".bg5").click(function(){
		jQuery("#colors").attr("href", "css/colors/orange.css");
	});
	
	jQuery(".bg6").click(function(){
		jQuery("#colors").attr("href", "css/colors/pink.css");
	});
	
	jQuery(".bg7").click(function(){
		jQuery("#colors").attr("href", "css/colors/purple.css");
	});
	
	jQuery(".bg8").click(function(){
		jQuery("#colors").attr("href", "css/colors/red.css");
	});
	
	
	
	jQuery(".custom-show").hide();
	
	jQuery(".custom-close").click(function(){
		$(this).hide();
		jQuery(".custom-show").show();
		$('#switcher').animate({'left': '+=108px'},'slow');
	});
  	

	jQuery(".custom-show").click(function(){
		$(this).hide();
		jQuery(".custom-close").show();
		$(this).parent().animate({'left': '-=108px'},'slow');
	});
});

