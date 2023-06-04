using ChatRoomLogin.Controllers;
using MongoDB.Bson;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using BsonObjectId = MongoDB.Bson.BsonObjectId;

namespace ChatRoomLogin.Models
{
    //Reciever(business logic)
    public class CommandReciever
    {
        public Query loginQueryCommand(string email, string password)
        {
            string query_type = "login";
            string[] payload = { email, password };
            Query client_query = JsonConverter.createQuery(query_type, payload);   // Create Query object
            
            string json_query = JsonConverter.encodeQuery(client_query);    // Convert Query object to json
            string responseMsg = AsynchronousClient.StartClient(json_query);    // Send to server and wait for return
            Console.WriteLine("Here is the json response from the server: " + responseMsg);

            Query server_query = JsonConverter.decodeQuery(responseMsg);


            return server_query;

            /*string[] response = { json_query, responseMsg };    // Just testing if id's of both jsons match(don't send client json when done)
            return response;*/
        }



        public Query registerQueryCommand(string email, string password)
        {
            string query_type = "register";
            string[] payload = { email, password };
            Query client_query = JsonConverter.createQuery(query_type, payload);   // Create Query object

            string json_query = JsonConverter.encodeQuery(client_query);    // Convert Query object to json
            string responseMsg = AsynchronousClient.StartClient(json_query);    // Send to server and wait for return
            Console.WriteLine("Here is the json response from the server: " + responseMsg);

            Query server_query = JsonConverter.decodeQuery(responseMsg);


            return server_query;

            /*string[] response = { json_query, responseMsg };    // Just testing if id's of both jsons match(don't send client json when done)
            return response;*/
        }





        public Query getUserDataQueryCommand(string user_id)
        {
            string query_type = "getUserData";
            string[] payload = { user_id };
            Query client_query = JsonConverter.createQuery(query_type, payload);   // Create Query object

            string json_query = JsonConverter.encodeQuery(client_query);    // Convert Query object to json
            string responseMsg = AsynchronousClient.StartClient(json_query);    // Send to server and wait for return
            Console.WriteLine("Here is the json response from the server: " + responseMsg);

            Query server_query = JsonConverter.decodeQuery(responseMsg);


            return server_query;


        }






        // Match client and server query ids
        private bool idsMatch(Query client_query, Query server_query)
        {
            int client_id = client_query.QueryID;
            int server_id = server_query.QueryID;
            if (client_id == server_id)
            {
                return true;
            }

            return false;
        }

    }
}