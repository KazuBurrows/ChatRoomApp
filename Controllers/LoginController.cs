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


            CommandHandler command_handler = new CommandHandler();
            Query server_response = command_handler.Login(param_email, param_password);



            return Content(server_response.Payload[0]);
            //return Content("Server returned: " + server_response.QueryID + ", " + server_response.PayloadType + ", " + server_response.Payload[0]);

        }
    }
}