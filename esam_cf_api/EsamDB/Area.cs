using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsamDB
{
    public class Area
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AreaId { get; set; }
        [Required]
        [MaxLength(35), MinLength(3), RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solamente se permiten letras.")]
        public required string AreaName { get; set; }
        public required ICollection<AreaUser> AreaUsers { get; set; }

    }
}
