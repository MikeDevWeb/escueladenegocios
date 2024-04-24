using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsamDB
{
    public class AreaUser
    {
        [Key]
        public int AreaID { get; set; }
        public required Area Area { get; set; }
        public int UserID { get; set; }
        public required User User { get; set; }
    }
}
