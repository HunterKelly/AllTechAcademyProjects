document.write(typeof "Word" + " ");//what type of value this is (string)

document.write(typeof 3 + " ");//What type of value this is (int)

document.write("10" + 5 + " "); //Does not add mathematically


function my_Function() {
    document.getElementById("Test").innerHTML = 0 / 0; //will return NaN because not possible
}

function my_Functionn() {
    document.getElementById("Test2").innerHTML = isNaN('This is a string'); //isNan is checking if its a number or not here
}

function my_Functionnn() {
    document.getElementById("Test3").innerHTML = isNaN('007'); //checking to see if 007 is a number or not
}

document.write(2E310 + " "); //infinity

document.write(-3E310 + " "); //negative infinity

document.write(10 > 2 + "  ");

document.write(10 < 2 + "  "); 

console.log(2 + 2);  //displayed in console log

console.log(5 < 2); //displayed in console log

document.write(10 == 10 + " "); //equal

document.write(3 == 11 + " "); //not equal

var DateOfBirth1 = "1/1/1970";
var DateOfBirth2 = "1/1/1970";

document.write(DateOfBirth1 === DateOfBirth2); //same time same value

X = 82;
Y = "82";

document.write(X === Y); //different type same value

A = 82;
B = "Person";
document.write(A === B); //different type different value

C = 82;
D = 85;

document.write(C == D); //same type different value

document.write(5 > 2 && 10 > 4); //both true, therefore true (and)

document.write(5 > 10 && 10 > 4); //one untrue, therefore fale (and)

document.write(5 > 10 || 10 > 4); //one true, therefore true (or)

document.write(5 > 10 || 10 > 20); //both untrue

function not_Function() {
    document.getElementById("Test4").innerHTML = !(20 > 10); //If true, then false (not)
}
function notnot_Function() {
    document.getElementById("Test5").innerHTML = !(5 > 10); //double negative(True)
}
