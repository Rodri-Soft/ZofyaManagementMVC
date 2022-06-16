﻿using System;
using System.Collections.Generic;

namespace ZofyaManagementMVC.Models
{
    public partial class ItemShoppingCart
    {
        public int IDItemShoppingCart { get; set; }
        public int IDShoppingCart { get; set; }
        public string SKU { get; set; } = null!;
        public int QuantityOfItems { get; set; }
        public decimal TotalItem { get; set; }

        public virtual Item SKUNavigation { get; set; } = null!;
    }
}
