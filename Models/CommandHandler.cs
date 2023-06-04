using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoomLogin.Models
{
    //The invoker
    public class CommandHandler
    {
        private CommandReciever _reciever = new CommandReciever();


        public Query Login(string email, string password)
        {
            Command command = new LoginCommand(_reciever, email, password);
            Query response = command.Execute();

            return response;
        }


        public Query Register(string email, string password)
        {
            Command command = new RegisterCommand(_reciever, email, password);
            Query response = command.Execute();

            return response;
        }

        [Obsolete]
        public Query GetUserData(string user_id)
        {
            Command command = new GetUserDataCommand(_reciever, user_id);
            Query response = command.Execute();

            return response;
        }





        // Need to call decode json command here




    }
}