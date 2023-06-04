using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoomLogin.Models
{
    interface Command
    {
        Query Execute();
    }
}