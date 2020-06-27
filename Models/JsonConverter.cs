using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoomLogin.Models
{
    /*
    * Return json string of object
    */
    public static class JsonConverter
    {

        public static string encodeQuery(string queryType, string data)
        {
            Query query = new Query
            {
                QueryType = queryType,
                Data = data,
            };

            return JsonConvert.SerializeObject(query, Formatting.Indented);
        }


        public static string encodeLogin(string email, string password)
        {
            Login login = new Login
            {
                Email = email,
                Password = password,
            };

            return JsonConvert.SerializeObject(login, Formatting.Indented);
        }


        public static string encodeRegister(string email, string password)
        {
            Register register = new Register
            {
                Email = email,
                Password = password,
            };

            return JsonConvert.SerializeObject(register, Formatting.Indented);
        }



    }
}