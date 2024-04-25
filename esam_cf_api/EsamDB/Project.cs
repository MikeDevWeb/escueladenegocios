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
        public Guid ProjectID { get; set; }
        public required string ProjectName { get; set; }
        public required string ProjectDescription { get; set; }
        public required DateTime ProjectStartDate { get; set; }
        public required DateTime ProjectEndDate { get; set; }
        [ForeignKey("UserID")]
        public required Guid UserID { get; set; }
        [ForeignKey("CategoryId")]
        public required Guid CategoryId { get; set; }
        [ForeignKey("AreaId")]
        public required Guid AreaId { get; set; }
        public virtual required Area Area { get; set; }
        public virtual required Category Category { get; set; }
    }
}
