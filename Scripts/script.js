$(document).ready(function () {
    console.log("ready!");
});






function loginSubmit()
{
    var email = $("#login_form_email").val();
    var password = $("#login_form_password").val();

    console.log(email);
    console.log(password);

    
    /*$.post("/Home/Login", { test_param: "tesing" },
        function () { alert('Successfully posted to server') });*/



    $.ajax({
        type: "POST",
        url: "/Login/Login",
        data: { param_email: email, param_password: password },
        success: function (response)
        {
            alert(response);
        }

    });

}


function registerSubmit() {
    var email = $("#register_form_email").val();
    var password = $("#register_form_password").val();

    console.log(email);
    console.log(password);


    /*$.post("/Home/Login", { test_param: "tesing" },
        function () { alert('Successfully posted to server') });*/



    $.ajax({
        type: "POST",
        url: "/Register/Register",
        data: { param_email: email, param_password: password },
        success: function (response) {
            alert(response);
        }

    });

}