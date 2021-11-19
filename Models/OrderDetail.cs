using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVCProjetFinal.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int? QtyProduct { get; set; }

        public decimal? PriceProduct { get; set; }

        public decimal? Total { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

    }
}
