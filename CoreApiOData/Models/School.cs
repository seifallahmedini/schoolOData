using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiOData.Models
{
    public class School
    {
        public School()
        {
            Students = new HashSet<Student>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid SchoolId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
