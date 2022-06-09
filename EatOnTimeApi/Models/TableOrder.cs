using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatOnTimeApi.Models
{
    public class TableOrder
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string OrderId { get; set; }
        public string UnitPrice { get; set; }
        public string QtyPO { get; set; }
        public  string CreatedOn { get; set; }
        public string Served { get; set; }

    }
}