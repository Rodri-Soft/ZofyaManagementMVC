﻿using System;
using System.Collections.Generic;

namespace ZofyaManagementMVC.Models
{
    public partial class Item_WishList
    {
        public int IDItemWishList { get; set; }
        public int IDWishList { get; set; }
        public string SKU { get; set; } = null!;

        public virtual WishList IDWishListNavigation { get; set; } = null!;
        public virtual Item SKUNavigation { get; set; } = null!;
    }
}
