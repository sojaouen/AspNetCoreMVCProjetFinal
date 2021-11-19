using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVCProjetFinal.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        public int? QuantityArrival { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(200)]
        public string Photo { get; set; }
        public bool?  NewProduct { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category{ get; set; }

        public int ProducerId { get; set; }

        public virtual Producer Producer{ get; set; }

        public virtual ICollection<ProductEvaluate> ProductEvaluates { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<Promotion> Promotions { get; set; }







    }
}
