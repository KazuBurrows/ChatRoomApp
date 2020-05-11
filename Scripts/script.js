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
        url: "/Home/Login",
        data: { param_email: email, param_pass: password },
        success: function (a)
        {
            alert(a);
        }

    });




}