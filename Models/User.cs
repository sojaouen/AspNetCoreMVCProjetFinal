using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCProjetFinal.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }
        
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? AuthId { get; set; }

        [StringLength(100)]
        public string Adresse { get; set; }
                
        public virtual ICollection<Order> Order { get; set; }

        public virtual AuthenSession AuthenSession { get; set; }

    }
}