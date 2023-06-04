using ChatRoomLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatRoomLogin.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Register(string param_email, string param_password)
        {

            // Here I need a server to call to validate login

            /*if validLogin(param_email, param_pass) {

                return RedirectToAction("Index", "Home");
            }*/


            CommandHandler command_handler = new CommandHandler();
            command_handler.Register(param_email, param_password);

            return Content("no response message yet.");

            /*string json_query = QueryFactory.RegisterQuery(param_email, param_password);

            string responseMsg = AsynchronousClient.StartClient(json_query);
            //return Content(responseMsg);
            return Content(json_query);*/
        }

    }
}