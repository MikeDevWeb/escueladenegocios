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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public DateTime RegisterDate { get; set; }
        public required string UserName { get; set; }
        public required string CI { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
        
        [RegularExpression("^(M|F)$", ErrorMessage = "El género debe ser M o F")]
        public required string Gender { get; set; }
        public required string Email { get; set; }
        
    }
}
