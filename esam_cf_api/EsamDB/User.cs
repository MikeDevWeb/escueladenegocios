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
        public Boolean Gender { get; set; }
        
    }
}
