using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoomLogin.Models
{

    public class Query
    {

        private string objectType;
        private string queryType;
        private string data;


        /*
         * 
         * 
         * param query_data
         */
        public Query(string query_object, string query_type, string query_data)
        {
            objectType = query_object;
            queryType = query_type;
            data = query_data;

        }

        

    }
}