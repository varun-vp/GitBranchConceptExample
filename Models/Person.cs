using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GitBranchConceptExmaple.Models
{
    public class Person
    {
        [Key]
        public int PId { get; set; }
        public string PName{ get; set; }
        public int Page { get; set; }
    }
}
