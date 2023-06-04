using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoomLogin.Models
{
    class LoginCommand : Command
    {
        private CommandReciever _reciever;
        private string _email;
        private string _password;

        public LoginCommand(CommandReciever reciever, string email, string password)
        {
            this._reciever = reciever;
            this._email = email;
            this._password = password;
        }

        public Query Execute()
        {
            return _reciever.loginQueryCommand(_email, _password);
        }
    }



    class RegisterCommand : Command
    {
        private CommandReciever _reciever;
        private string _email;
        private string _password;

        public RegisterCommand(CommandReciever reciever, string email, string password)
        {
            this._reciever = reciever;
            this._email = email;
            this._password = password;
        }

        public Query Execute()
        {
            return _reciever.registerQueryCommand(_email, _password);
        }
    }




    class GetUserDataCommand : Command
    {
        private CommandReciever _reciever;
        private string _user_id;

        public GetUserDataCommand(CommandReciever reciever, string user_id)
        {
            this._reciever = reciever;
            this._user_id = user_id;
        }


        public Query Execute()
        {
            return _reciever.getUserDataQueryCommand(_user_id);
        }
    
    }




}