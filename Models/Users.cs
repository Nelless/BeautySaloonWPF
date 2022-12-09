using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.Models
{
    class Users
    {
        [JsonProperty("id")]
            public int Idrole { get; set; }
            public string userName { get; set; }
            public string userLastName { get; set; }
            public string userOtherName { get; set; }
            public string userLogin { get; set; }
            public string userPassword { get; set; }
            public object idroleNavigation { get; set; }

    }
}
