using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsamDB
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoleId { get; set; }
        [StringLength(30, MinimumLength =5, ErrorMessage ="inscribir un nombre entre 5 y 30 caracteres")]
        public required string RoleName { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Inscribir una descripción entre 5 y 50 caracteres")]
        public required string RoleDescription { get; set; }
        public virtual required IList<User> Users { get; set; }
    }
}
