
function checklengthlimit() {
    
    var p = document.getElementById("phoneno").value;
    var u = document.getElementById("uname").value;
    var e = document.getElementById("email").value;
    var pas = document.getElementById("password").value;
   
    var n3 = p.length;
    var n4 = u.length;
    var n5 = e.length;
    var n6 = pas.length;
    
    if (n3 < 11) {
        document.getElementById('p').innerText = "Phone must be greater than 11 characters";
        document.getElementById('p').style.color = 'red';
        return false;
    }
    else {
        document.getElementById("p").innerText = "";
    }
    if (n4 < 4 || n4 > 20) {
        document.getElementById('u').innerText = "User Name must be between length 3-20 characters";
        document.getElementById('u').style.color = 'red';
        return false;
    }
    else {
        document.getElementById("u").innerText = "";
    }
    if (n5 < 5 || n5 > 32) {
        document.getElementById('e').innerText = "Email must be between length 5-32 characters";
        document.getElementById('e').style.color = 'red';
        return false;
    }
    else {
        document.getElementById("e").innerText = "";
    }
    if (n6 < 8 || n6 > 32) {
        document.getElementById('pas').innerText = "Password must be between length 8-32 characters";
        document.getElementById('pas').style.color = 'red';
        return false;
    }
    else {
        document.getElementById("pas").innerText = "";
    }
    return true;
}
function AlphabetsCheck() {
    var f = document.getElementById("fname").value;
    var l = document.getElementById("lname").value;

    var letters = /^[A-Za-z]+$/;
    if (!f.match(letters)) {
        document.getElementById('f').innerText = "First Name should have alphabets only";
        document.getElementById('f').style.color = 'red';
        return false;
    }
    else {
        document.getElementById("f").innerText = "";
    }
    if (!l.match(letters)) {
        document.getElementById("l").innerText = "Last Name should have alphabets only";
        document.getElementById('l').style.color = 'red';
        return false;
    }
    else {
        document.getElementById('l').innerText = "";
    }
    return true;
}
function cpassword() {
    if (document.getElementById('password').value ==document.getElementById('password2').value) {
        document.getElementById('pas2').style.color = 'green';
        document.getElementById('pas2').innerHTML = 'Password matched';
        return true;
    } else {
        document.getElementById('pas2').style.color = 'red';
        document.getElementById('pas2').innerHTML = 'Password not matching';
        return false;
    }
}
function ValidateEmail() {
    if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(document.getElementById('email').value)) {
        document.getElementById('e').innerText = "Email is valid";
        document.getElementById('e').style.color = 'green';
        return (true)
    }
    document.getElementById('e').innerText = "Email is not valid";
    document.getElementById('e').style.color = 'red';

    return (false)
}
function checkGender() {
    var x = document.getElementById('gender').value;
    if (x=="F" || x == "M")
        return true;
    else {
        document.getElementById('g').innerText = 'Gender is not valid. Enter "M" or "F"';
        document.getElementById('g').style.color = 'red';
        return false;
    }
}