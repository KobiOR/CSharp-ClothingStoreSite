var pie = new d3pie("pieChart", {
    "header": {
        "title": {
            "text": "Men",
            "color": "#14478a",
            "fontSize": 30
        },
        "subtitle": {
            "text": "Purchases made by men",
            "color": "#645e5e",
            "font": "open sans"
        },
        "titleSubtitlePadding": 7
    },
    "footer": {
        "color": "#999999",
        "fontSize": 10,
        "font": "open sans",
        "location": "bottom-left"
    },
    "size": {
        "canvasWidth": 450,
        "pieInnerRadius": "12%",
        "pieOuterRadius": "79%"
    },
    "data": {
        "sortOrder": "value-desc",
        "content": [
			{
			    "label": "Shirts",
			    "value": 8,
			    "color": "#2484c1"
			},
			{
			    "label": "Pants",
			    "value": 3,
			    "color": "#0c6197"
			},
			
			{
			    "label": "Jeans",
			    "value": 2,
			    "color": "#daca61"
			}
			
			
        ]
    },
    "labels": {
        "outer": {
            "hideWhenLessThanPercentage": 2,
            "pieDistance": 40
        },
        "mainLabel": {
            "color": "#1328b3",
            "fontSize": 13
        },
        "percentage": {
            "color": "#ffffff",
            "fontSize": 14,
            "decimalPlaces": 0
        },
        "value": {
            "color": "#000000",
            "fontSize": 11
        },
        "lines": {
            "enabled": true
        }
    },
    "effects": {
        "load": {
            "speed": 2000
        },
        "pullOutSegmentOnClick": {
            "speed": 400,
            "size": 8
        }
    },
    "misc": {
        "colors": {
            "background": "#ffffff"
        },
        "gradient": {
            "enabled": true,
            "percentage": 100
        }
    },
    "callbacks": {}
});

var pie1 = new d3pie("pieChart", {
    "header": {
        "title": {
            "text": "Women",
            "color": "#14478a",
            "fontSize": 30
        },
        "subtitle": {
            "text": "Purchases made by women",
            "color": "#645e5e",
            "font": "open sans"
        },
        "titleSubtitlePadding": 7
    },
    "footer": {
        "color": "#999999",
        "fontSize": 10,
        "font": "open sans",
        "location": "bottom-left"
    },
    "size": {
        "canvasWidth": 450,
        "pieInnerRadius": "12%",
        "pieOuterRadius": "79%"
    },
    "data": {
        "sortOrder": "value-desc",
        "content": [
			{
			    "label": "Shirts",
			    "value": 5,
			    "color": "#2484c1"
			},
			{
			    "label": "Tops",
			    "value": 3,
			    "color": "#0c6197"
			},

			{
			    "label": "Dresses",
			    "value": 2,
			    "color": "#1328b3"
			}


        ]
    },
    "labels": {
        "outer": {
            "hideWhenLessThanPercentage": 2,
            "pieDistance": 40
        },
        "mainLabel": {
            "color": "#1328b3",
            "fontSize": 13
        },
        "percentage": {
            "color": "#ffffff",
            "fontSize": 14,
            "decimalPlaces": 0
        },
        "value": {
            "color": "#000000",
            "fontSize": 11
        },
        "lines": {
            "enabled": true
        }
    },
    "effects": {
        "load": {
            "speed": 2000
        },
        "pullOutSegmentOnClick": {
            "speed": 400,
            "size": 8
        }
    },
    "misc": {
        "colors": {
            "background": "#ffffff"
        },
        "gradient": {
            "enabled": true,
            "percentage": 100
        }
    },
    "callbacks": {}
});
var pie2 = new d3pie("pieChart", {
    "header": {
        "title": {
            "text": "Children",
            "color": "#14478a",
            "fontSize": 30
        },
        "subtitle": {
            "text": "Purchases made by Children",
            "color": "#645e5e",
            "font": "open sans"
        },
        "titleSubtitlePadding": 7
    },
    "footer": {
        "color": "#999999",
        "fontSize": 10,
        "font": "open sans",
        "location": "bottom-left"
    },
    "size": {
        "canvasWidth": 450,
        "pieInnerRadius": "12%",
        "pieOuterRadius": "79%"
    },
    "data": {
        "sortOrder": "value-desc",
        "content": [
			{
			    "label": "Shirts",
			    "value": 7,
			    "color": "#2484c1"
			},
			

			{
			    "label": "Jeans",
			    "value": 3,
			    "color": "#1328b3"
			}


        ]
    },
    "labels": {
        "outer": {
            "hideWhenLessThanPercentage": 2,
            "pieDistance": 40
        },
        "mainLabel": {
            "color": "#1328b3",
            "fontSize": 13
        },
        "percentage": {
            "color": "#ffffff",
            "fontSize": 14,
            "decimalPlaces": 0
        },
        "value": {
            "color": "#000000",
            "fontSize": 11
        },
        "lines": {
            "enabled": true
        }
    },
    "effects": {
        "load": {
            "speed": 2000
        },
        "pullOutSegmentOnClick": {
            "speed": 400,
            "size": 8
        }
    },
    "misc": {
        "colors": {
            "background": "#ffffff"
        },
        "gradient": {
            "enabled": true,
            "percentage": 100
        }
    },
    "callbacks": {}
});