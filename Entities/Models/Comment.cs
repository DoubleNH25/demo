using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Content { get; set; }
        public string? TargetTo { get; set; }
        public int IdTarget { get; set; }
        public DateTime SavedDate { get; set; }
    }
}
