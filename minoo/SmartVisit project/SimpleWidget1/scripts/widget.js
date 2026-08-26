function applyCssStyles() {
    var width = document.documentElement.clientWidth;       
    var cssFile = "css/LoDPI.css";       
    if (width >= 480) {           
        // The document is wider than 480 pixels           
        // it must be a High DPI device          
        cssFile = "css/HiDPI.css";      
    }   
    
    // Set the correct CSS style sheet to the document
    var cssNode = document.getElementById("widgetCss");      
    cssNode.href = cssFile;
}

window.onload = function() {
    var menu = widget.menu;
    var mi = menu.createMenuItem(100);

    mi.text = "Hi";
    mi.onSelect = function() { alert("Hi"); }

    menu.setSoftKey(mi, menu.leftSoftKeyIndex);

    applyCssStyles();
}

