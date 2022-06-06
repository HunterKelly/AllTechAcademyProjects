function validateForm() {
    let x = document.forms["form1"]["fname"].value;
    if (x == "") {
        alert("Name must be filled out");
        return false;
    }
}