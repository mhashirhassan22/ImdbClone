function myFunction() {
    var x = document.getElementById("password");
    if (x.type === "password") {
        x.type = "text";
    }
    else {
        x.type = "password";
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