﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.Models
{
    class Services
    {
        [JsonProperty("id")]
            public int Id { get; set; }
            public string title { get; set; }
            public float cost { get; set; }
            public int durationInSeconds { get; set; }
            public string description { get; set; }
            public float discount { get; set; }
            public string mainImagePath { get; set; }
            public int categoryId { get; set; }
            public object category { get; set; }
            public object[] clientServices { get; set; }
            public object[] servicePhotos { get; set; }
    }
}
