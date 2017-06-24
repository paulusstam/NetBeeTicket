using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetBeeTicket.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsSubscribed { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public byte SubscriptionTypeId { get; set; }
    }
}