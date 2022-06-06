function validateForm() {
    let x = document.forms["myForm"]["fname"].value;
    if (x == "" || x =="John") {
        alert("Name must be filled out");
        return false;
    }
}

function openForm() {
    document.getElementById("myForm2").style.display = "block";
}

function closeForm() {
    document.getElementById("myForm2").style.display = "none";
}

$("#slideshow > div:gt(0)").hide();

setInterval(function () {
    $('#slideshow > div:first')
        .fadeOut(1000)
        .next()
        .fadeIn(1000)
        .end()
        .appendTo('#slideshow');
}, 3000);


/*JS dictionary object */
var dog = '{ "name": "Dax", "breed": "Great Pyrenees", "color": "White" }';

//convert JS objects to string format 
//var JSONstring = JSON.stringify(dog);
//document.getElementById("myDog").innerHTML = JSONstring; 

var JSONstring = JSON.parse(dog);
document.getElementById("myDog").innerHTML = JSONstring.name + " the " +
    JSONstring.breed;

/*set the data as a key/value pair to be saved locally in your browser */
localStorage.setItem("Name", "Dax");

//Then use the key "Name" to return its velu "Dax"
document.getElementById("myDog").innerHTML = localStorage.getItem("Name");