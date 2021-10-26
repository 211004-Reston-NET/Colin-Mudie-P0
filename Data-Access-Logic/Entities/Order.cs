using System;
using System.Collections.Generic;

#nullable disable

namespace Data_Access_Logic.Entities
{
    public partial class Order
    {
        public Order()
        {
            Storefronts = new HashSet<Storefront>();
        }

        public int OrderId { get; set; }
        public string Address { get; set; }
        public decimal TotatPrice { get; set; }

        public virtual ICollection<Storefront> Storefronts { get; set; }
    }
}
