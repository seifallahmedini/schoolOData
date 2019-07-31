using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiOData.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public Guid SchoolId { get; set; }
        public School School { get; set; }
    }
}
