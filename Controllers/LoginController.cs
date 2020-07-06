using ChatRoomLogin.Models;
using Newtonsoft.Json;
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


            string json_query = QueryFactory.LoginQuery(param_email, param_password);

            string responseMsg = AsynchronousClient.StartClient(json_query);
            //return Content(responseMsg);


            /*if () {
                return Redirect("http://www.google.com");
            }*/


            return Content(responseMsg);
        }
    }
}