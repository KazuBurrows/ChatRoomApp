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

        public static Query createQuery(string payload_type, string[] payload)
        {
            Random r = new Random();            //Need like an atomic variable to make this work. Having a random id is risky
            int queryID = r.Next(64000);

            Query query = new Query
            {
                QueryID = queryID,
                PayloadType = payload_type,
                Payload = payload
            };

            return query;
        }


        public static string encodeQuery(Query query)
        {
            /*Random r = new Random();            //Need like an atomic variable to make this work. Having a random id is risky
            int queryID = r.Next(64000);

            Query query = new Query
            {
                QueryID = queryID,
                PayloadType = payload_type,
                Payload = payload
            };*/
            return JsonConvert.SerializeObject(query, Formatting.Indented);
        }


        public static Query decodeQuery(string json_query)
        {
            return JsonConvert.DeserializeObject<Query>(json_query);
        }




        /*public static string encodeQuery(string queryType, string queryObject, string data)
        {
            Random r = new Random();
            int queryID = r.Next(64000);

            Query query = new Query
            {
                QueryID = queryID,
                QueryType = queryType,
                QueryObject = queryObject,
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


        *//*
         * Decode json Query object
         *//*
        public static Query decodeQuery(string json_query)
        {
            return JsonConvert.DeserializeObject<Query>(json_query);
        }*/



    }
}