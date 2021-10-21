using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocsReader.Modal
{
    public class Admins
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Username { get; set; }
        public String Password { get; set; }
    }
}
