var X = 10;
function Add_numbers_1() {
    document.write(20 + X + "<br>");
}
function Add_numbers_2() {
    document.write(X + 100 + "<br>");
}
Add_numbers_1();
Add_numbers_2();

function Add_numbers_3() {
    var X = 10;
    console.log(15 + X);
}
function Add_numbers_4() {
    console.log(X + 100);
}
Add_numbers_3();
Add_numbers_4();

if (1 < 2) {
    document.write("The left number is smaller than the number on the right.<br>")
}
function get_Date() {
    if (new Date().getHours() < 18) {
        document.getElementById("Greeting").innerHTML = "How are you today?<br>";
    }
}
var red = "color red"  //if statement with strings that describe colors literally. 
var blue = "color blue"
if (red !== blue) {
    document.write("Red is not equal to blue.<br>")
}

function Animal_Count_Function() { //gives a response based on how many dogs user has
    Animals = document.getElementById("Animals").value;
    if (Animals == 0) {
        Vote = "You should get a dog!";
    }
    else {
        Vote = Animals + " is an okay amount, but how about 10 more?";
    }
    document.getElementById("How_many_dogs?").innerHTML = Vote;
}

function Time_function() {
    var Time = new Date().getHours();
    var Reply;
    if (Time < 12 == Time > 0) {
        Reply = "It is morning time!";
    }
    else if (Time > - 12 == Time < 18) {
        Reply = "It is afternoon.";
    }
    else {
        Reply = "It is evening time.";
    }
    document.getElementById("Time_of_day").innerHTML = Reply;
}