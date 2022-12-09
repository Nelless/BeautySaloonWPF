using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.Models
{
    public class ServiceCategoryes
    {

        [JsonProperty("categoryId")]
            public int CategoryId { get; set; }
            public string categoryTitle { get; set; }
            public string categoryImage { get; set; }
            public object[] services { get; set; }

    }
}
