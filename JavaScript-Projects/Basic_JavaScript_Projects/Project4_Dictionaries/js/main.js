function my_Dictionary() {
    var Animal = {
        Species: "Dog",
        Color: "Black",
        Breed: "Labrador",
        Age: 5,
        Sound: "Bark!"
    };
    document.getElementById("Dictionary").innerHTML = Animal.Sound; 
} //Pulls the sound from this dictionary to display it in the HTML document

function two_Dictionary() {
    var Plant = {
        Species: "Oak", 
        Color: "Brown",
        Age: "300",
        Size: "20 meters",
        
    }
    delete Plant.Age; //deletes the key value pair from the dictionary
    document.getElementById("Dictionary2").innerHTML = Plant.Age;
} //Pulls a value that doesnt exist due to the delete.