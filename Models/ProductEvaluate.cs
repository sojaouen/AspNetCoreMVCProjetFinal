using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMVCProjetFinal.Models
{
    public class ProductEvaluate
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Mark { get; set; }

        public DateTime DateEvaluate { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }

    }
}