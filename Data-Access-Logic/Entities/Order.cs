using System;
using System.Collections.Generic;

#nullable disable

namespace Data_Access_Logic.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string Address { get; set; }
        public decimal TotatPrice { get; set; }
        public int? StorefrontId { get; set; }

        public virtual Storefront Storefront { get; set; }
    }
}
