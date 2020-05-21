using ChatRoomLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ChatRoomLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Login(string param_email, string param_password)
        {

            // Here I need a server to call to validate login

            /*if validLogin(param_email, param_pass) {

                return RedirectToAction("Index", "Home");
            }*/

            string queryObject = "login";
            string queryType = "validate";
            string queryData = " 'email': '{0}', 'password': '{1}' ";
            string data = "{" + String.Format(queryData, param_email, param_password) + "}";

            Models.Query query = new Models.Query(queryObject, queryType, data);
            string encoded_object = JsonConverter.jsonEncode(query);


            string responseMsg;
            responseMsg = AsynchronousClient.StartClient(encoded_object);



            return Content(responseMsg);
        }
    }
}