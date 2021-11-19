using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCProjetFinal.Models
{
    public class Producer
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string NomProducer { get; set; }

       
        public virtual ICollection<Product> Products { get; set; }

    }
}