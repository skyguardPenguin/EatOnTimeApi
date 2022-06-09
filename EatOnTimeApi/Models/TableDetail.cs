using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatOnTimeApi.Models
{
    public class TableDetail
    {
        public int TableId { get; set; }
        public int? QtyLimit { get; set; }
        public string TableStatus { get; set; }
        public string EstTime { get; set; }

    }
}