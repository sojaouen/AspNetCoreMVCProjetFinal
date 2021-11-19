using AspNetCoreMVCProjetFinal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVCProjetFinal.Models
{

    public class Cart
    {
        private readonly ApplicationDbContext _context; 

        public int Id { get; set; }
        public int ProducId { get; set; }
        public string ProductName { get; set; }
        public string ProductPhoto { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
        public double Total
        {
            get { return Quantity * ProductPrice; }
        }

        //public Cart(int ProductId)
        //{
        //    this.ProducId = ProductId;
        //    Product product = _context.

        //}
    }
}
