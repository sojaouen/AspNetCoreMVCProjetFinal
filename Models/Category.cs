using System.Collections.Generic;

namespace AspNetCoreMVCProjetFinal.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string NameCategory { get; set; }

        public string Info { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}