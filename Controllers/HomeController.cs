using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatRoomLogin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(String param_email, String param_pass)
        {

            // Here I need a server to call to validate login

            /*if validLogin(param_email, param_pass) {

                return RedirectToAction("Index", "Home");
            }*/

            String returnedMsg;

            returnedMsg = AsynchronousClient.StartClient();
            


            return Content(returnedMsg);
        }


    }
}