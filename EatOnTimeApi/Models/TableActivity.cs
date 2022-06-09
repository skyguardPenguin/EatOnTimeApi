using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatOnTimeApi.Models
{
    public class TableActivity
    {
        public string Status { get; set; }
        public int? Qty { get; set; }
        public DateTime? StartTime { get; set; }
        public string EstTime { get; set; }

    }
}