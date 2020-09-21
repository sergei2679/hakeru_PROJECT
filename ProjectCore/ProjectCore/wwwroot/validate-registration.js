function validate(form) {
    //debugger;

    let name = document.myForm.name.value;
    if (name == "" || name == null) {
        document.getElementById("span1").innerHTML = "Please enter the Product Name";
        document.myForm.name.focus();
        document.getElementById("name").style.border = "3px solid red";
        return false;
    }
    else {
        document.getElementById("span1").innerHTML = "";
        document.getElementById("name").style.border = "3px solid green";
    }

    let age = document.myForm.age.value;
    let ageFormat = /^(([1][8-9])|([2-5][0-9])|(6[0]))$/gm;

    if (age == "" || age == null) {
        document.getElementById("span2").innerHTML = "Please provide Age";
        document.myForm.age.focus();
        document.getElementById("age").style.border = "3px solid red";
        return false;
    }
    else if (!ageFormat.test(age)) {
        document.getElementById("span2").innerHTML = "Age can't be leass than 18 and greater than 60";
        document.myForm.age.focus();
        document.getElementById("age").style.border = "3px solid red";
        return false;
    }
    else {
        document.getElementById("span2").innerHTML = "";
        document.getElementById("age").style.border = "3px solid green";
    }

    let password = document.myForm.password.value;
    if (document.myForm.password.length < 6) {
        alert("Error: Password must contain at least six characters!");
        document.myForm.password.focus();
        document.getElementById("password").style.border = "3px solid red";
        return false;
    }
    re = /[0-9]/g;
    if (!re.test(password)) {
        alert("Error: password must contain at least one number!");
        document.myForm.password.focus();
        document.getElementById("password").style.border = "3px solid red";
        return false;
    }
    re = /[a-z]/g;
    if (!re.test(password)) {
        alert("Error: password must contain at least one lowercase letter (a-z)!");
        document.myForm.password.focus();
        document.getElementById("password").style.border = "3px solid red";
        return false;
    }
    re = /[A-Z]/g;
    if (!re.test(password)) {
        alert("Error: password must contain at least one uppercase letter!");
        document.myForm.password.focus();
        document.getElementById("password").style.border = "3px solid red";
        return false;
    }
    re = /[$&+,:;=?@#|'<>.^*()%!-]/g;
    if (!re.test(password)) {
        alert("Error: password must contain at least one special character!");
        document.myForm.password.focus();
        document.getElementById("password").style.border = "3px solid red";
        return false;
    }
    else {
        document.getElementById("span3").innerHTML = "";
        document.getElementById("password").style.border = "3px solid green";

        onSubmit(form)

        //createJSON();
    }
}

//function createJSON(form) {
//    //debugger;
//    //let myData = document.getElementById("form");
//    let jsonData = JSON.stringify($(form).serializeArray());
//    document.getElementById("span4").innerHTML = jsonData;
//    console.log(jsonData);

//    //return false
//}

function onSubmit(form) {
    var data = JSON.stringify($(form).serializeArray()); //  <-----------
    document.getElementById("span4").innerHTML = jsonData;

    console.log(data);
    return false; //don't submit
}


function restrictCharacters(evt) {
    evt = (evt) ? evt : window.event;
    let charCode = (evt.which) ? evt.which : evt.keyCode;
    if (((charCode >= '65') && (charCode <= '90')) || ((charCode >= '97') && (charCode <= '122')) || (charCode == '32')) {
        return true;
    }
    else {
        return false;
    }
}

function clearForm() {
    document.getElementById("name").innerHTML = "";
    document.getElementById("age").innerHTML = "";
    document.getElementById("password").innerHTML = "";
}