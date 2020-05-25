using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace iTransition.Models
{
    public class Company : DbContext
    {
        [Required]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
        [NotMapped]
        public List<Comment> Comments { get; set; }
        [Required]
        public DateTime date { get; set; }
    }
}
