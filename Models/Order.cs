using System;
using System.Collections.Generic;

namespace AspNetCoreMVCProjetFinal.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime? DateOrder { get; set; }

        public int? Status { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        
    }
}