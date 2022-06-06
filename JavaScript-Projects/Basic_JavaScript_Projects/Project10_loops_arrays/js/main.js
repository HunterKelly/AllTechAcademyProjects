alert(document.getElementById("p1").innerHTML);

function count_To_Ten() {
    var Digit = "";
    var X = 1;
    while (X < 11) {
        Digit += "<br>" + X;
        X++;
    }
    document.getElementById("Counting_to_Ten").innerHTML = Digit;
    document.getElementById('hi').style.visibility = "hidden"
}

function Call_Loop() {
    var Y = 0;
    var Z = "";
    while (Y < 11) {
        Z += "Never gonna give you up! "
        Y++;
    }
    document.getElementById("loop").innerHTML = Z;
}

let A = "Hello World!";
let B = A.length;
document.getElementById("length").innerHTML = B;

var Instruments = ["Guitar", "Drums", "Piano", "Bass", "Violin", "Trumpet", "Flute"];
var Content = "";
var Y;
function for_Loop() {
    for (Y = 0; Y < Instruments.length; Y++) {
        Content += Instruments[Y] + "<br>";
    }
    document.getElementById("List_of_Instruments").innerHTML = Content;
}

function cat_pics() {
    var Cat_Picture = []
    Cat_Picture[0] = "Sleeping";
    Cat_Picture[1] = "playing";
    Cat_Picture[2] = "eating";
    Cat_Picture[3] = "purring";
    document.getElementById("Cat").innerHTML = "In this picture, the cat is " +
        Cat_Picture[2] + ".";
}

function array_Function() {
    var Clown = []
    Clown[0] = "Dancing";
    Clown[1] = "juggling";
    Clown[2] = "making balloons";
    Clown[3] = "face painting";
    document.getElementById("Array").innerHTML = "In this picture, the clown is " +
        Clown[2] + ".";
}

function constant_function() {
    const Musical_Instrument = { type: "guitar", brand: "Fender", color: "black" };
    Musical_Instrument.color = "blue";
    Musical_Instrument.price = "$900";
    document.getElementById("Constant").innerHTML = "The cost of the " +
        Musical_Instrument.type + " was " + Musical_Instrument.price;
}

let x = myFunction(4, 3);
document.getElementById("ret").innerHTML = x
function myFunction(a, b) {
    return a * b;
}

let car = {
    make: "Dodge ",
    model: "Viper ",
    year: "2021 ",
    color: "red ",
    description: function () {
        return "The car is a " + this.year + this.color + this.make + this.model;
    }
};
document.getElementById("Car_Object").innerHTML = car.description();

for (let i = 0; i < 10; i++) {
    if (i == 3) { break; }
    text += "The number is " + i + "<br>"
}

for (let i = 0; i < 10; i++) {
    if (i == 3) { countinue; }
    text += "The number is " + i + "<br>";
}




function poof() {
    console.log('magic');
    document.getElementById('magic').style.visibility = "hidden"
    
}