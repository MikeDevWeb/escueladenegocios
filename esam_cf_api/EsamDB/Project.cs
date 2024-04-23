using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EsamDB
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }
        public required string ProjectName { get; set; }
        public required string ProjectDescription { get; set; }
        public required DateTime ProjectStartDate { get; set; }
        public required DateTime ProjectEndDate { get; set; }
        [ForeignKey("CategoryID")]
        public required int CategoryID { get; set; }
        public virtual required Category Category { get; set; }
    }
}
