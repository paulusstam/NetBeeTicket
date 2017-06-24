using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NetBeeTicket.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}