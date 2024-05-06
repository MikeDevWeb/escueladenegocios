using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsamDB
{
    internal class ProjectState
    {
        [Key]
        public Guid Id { get; set; }
        public required string ProjectStateName { get; set; }
        public required string ProjectStateDetail { get; set; }
        [ForeignKey("ProjectId")]
        public required Guid ProjectId { get; set; }
        [ForeignKey("UserId")]
        public required Guid UserId { get; set; }
    }
}
