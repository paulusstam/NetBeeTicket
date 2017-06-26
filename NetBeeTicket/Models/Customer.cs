﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetBeeTicket.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsSubscribed { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
       
    }
}