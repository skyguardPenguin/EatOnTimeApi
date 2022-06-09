using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatOnTimeApi.Models
{
    public class Check
    {
        public string OrderId { get; set; }
        public string Total { get; set; }
        public string Subtotal { get; set; }

    }
}