using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFConsole.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Standard")]//name-std is the one that we've given,is not used anywhere
        public int StandardRefId { get; set; }
        public Standard ?Standard { get; set; } //the above two codes-from standard table take stdId as reference and give it to StdRefId
    }
    public class Standard
    {
            [Key]
            public int StandardId { get; set; }
            public string? StandardName { get; set; }
            ICollection<Student>? Students { get; set; }//for one to many relationship ICollection<> is used,many students can be mapped to a same std using this ICollection<> 
        }
       
    
}
