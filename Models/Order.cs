﻿using System;
using System.Collections.Generic;

namespace ZofyaManagementMVC.Models
{
    public partial class Order
    {
        public int IDOrder { get; set; }
        public DateTime Date { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string Status { get; set; } = null!;
        public decimal TotalToPay { get; set; }
        public int IDUser { get; set; }

        public virtual Customer IDUserNavigation { get; set; } = null!;
    }
}
