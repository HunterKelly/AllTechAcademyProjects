var x = "Father"; //unused variables for whatever
var y = "Mother"; //

function button1() {
    var button1 = "BOO!" //stored variable to be used in the function
    document.getElementById("buttonText").innerHTML = button1 //changes text to stored variable
}

var Birds = "Flock", Dogs = "Pack", Cows = "herd", Ants = "colony"; //unused variables for whatever

function para() {
    var text1 = "Here is additional text! " //The text in HTML changes into this on click
    text1 += "And even MORE TEXT! "         //This text is concatonated into the above
    text1 += "Muahahahaha!"                 //concatonated as well
    document.getElementById("para1").innerHTML = text1 //this inputs the text into the html
                                                       //(the actual function part of the function)
}
var foo = document.getElementsByTagName("p");

function addition_function() {
    var addition = 2 + 2;
    document.getElementById("Math").innerHTML = "2 + 2 = " + addition;
}