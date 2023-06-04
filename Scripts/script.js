$(document).ready(function () {
    $('#login_form_email').val("kazuiscool@gmail.com");
    $('#login_form_password').val("Rockstar03");
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



    $.ajax({                //https://stackoverflow.com/questions/16245277/function-always-returns-the-same-value
        type: "POST",
        url: "/Login/Login",
        data: { param_email: email, param_password: password },
        success: function (response)
        {
            determineRedirect(response)
            console.log(response);
            //alert(response);
        },
		error: function (request, status, error) {
			console.log(response);
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




function determineRedirect(server_response) {

    if (server_response == "valid login") {
        window.location.href = "/Dashboard/Index";

    } else {
        // Need to print some message to user, oh, this is easy, just make a place to to put msg, then use jquery to fill it with text

    }
    
}