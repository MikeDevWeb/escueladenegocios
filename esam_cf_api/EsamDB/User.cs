using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsamDB
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe ser de 3 a 50 caracteres")]
        public required string UserName { get; set; }
        [RegularExpression(@"^\d{7}-[A-Z]{2}$", ErrorMessage = "El formato del CI no es válido. Debe ser #######-AA")]
        public required string CI { get; set; }
        [Range(18, 80, ErrorMessage = "La edad debe ser entre 18 y 80")]
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateOnly Birthday { get; set; }
        [RegularExpression("^(M|F)$", ErrorMessage = "El género debe ser M o F")]
        public required string Gender { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        [ForeignKey("RoleId")]
        public Guid RoleId{ get; set; }
        public required Role Role { get; set; }
        public required IList<Role> Roles { get; set; }
        public required IList<Area> Areas { get; set; }
        public required IList<Project> Projects { get; set; }
        public required IList<AreaUser> AreaUsers { get; set; }

    }
}
