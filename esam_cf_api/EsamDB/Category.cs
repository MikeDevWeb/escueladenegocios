using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsamDB
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public required string CategoryName { get; set; }
        public required string CategoryDescription { get; set; }
        [ForeignKey("UserID")]
        public Guid UserID { get; set; }
        public required User User { get; set; }
        public required IList<User> Users { get; set; }
        public required IList<Project> Projects { get; set; }   

    }
}