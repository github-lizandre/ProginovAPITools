using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Commande
{
    public class CreateOrderSuccessRoot
    {
        [JsonProperty("success")]
        public CreateOrderSuccess Success { get; set; }
    }

    public class CreateOrderSuccess
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("createdid")]
        public int CreatedID { get; set; }
    }
}
