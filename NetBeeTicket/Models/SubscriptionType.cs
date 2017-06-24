using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetBeeTicket.Models
{
    public class SubscriptionType
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        public short Fee { get; set; }
        public byte DiscountRate { get; set; }
    }
}