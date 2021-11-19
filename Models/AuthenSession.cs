using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCProjetFinal.Models
{
    public class AuthenSession
    {
        public int Id{ get; set; }

        [StringLength(20)]

        public string NameAuth { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}