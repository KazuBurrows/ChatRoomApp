using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoomLogin.Models
{
    public class JsonConverter
    {


        public JsonConverter()
        {

        }


        public static string jsonEncode(Query query_object)
        {
            string encoded_object;
            string obj_type = query_object.getObjectType();

            switch (obj_type)
            {
                case "login":
                    encoded_object = encodeLogin(query_object);

                    return encoded_object;

            }

            return null;
        }



        //https://stackoverflow.com/questions/2246694/how-to-convert-json-object-to-custom-c-sharp-object
        public static Query jsonDecode(string encoded_object)
        {
            Query decoded_object;

            string jsonData = @"{  
            'FirstName':'Jignesh',  
            'LastName':'Trivedi'  
            }";

            var details = JObject.Parse(jsonData);
            Console.WriteLine(string.Concat("Hi ", details["FirstName"], " " + details["LastName"]));

            /*JToken j_query = jObject["query"];
            string email = (string)j_query["email"];
            string password = (string)j_query["password"];
            data = (string)j_query["data"];*/





            return null;
        }





        private static string encodeLogin(Query query_object)
        {
            string json_qeury = "";
            string json_format;

            json_format = " 'objectType': '{0}',";
            json_qeury += String.Format(json_format, query_object.getObjectType());

            json_format = " 'queryType': '{0}',";
            json_qeury += String.Format(json_format, query_object.getQueryType());


            json_format = " 'data': [{0}] ";
            json_qeury += String.Format(json_format, query_object.getData());

            json_qeury = @"{" + json_qeury + "}";

            return json_qeury;

        }






    }
}