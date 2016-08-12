using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public int ClientID { get; set; }
        public List<int> Articles { get; set; }
    }
}