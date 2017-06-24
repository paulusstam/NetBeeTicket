using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetBeeTicket.Models;

namespace NetBeeTicket.ViewModels
{
    public class SubscriptionTypeViewModel
    {
        public Subscription Subscription { get; set; }
        public Type TypeOfSubscription { get; set; }
    }
}