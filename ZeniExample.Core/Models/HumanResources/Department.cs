using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeniExample.Core.Models.HumanResources
{
    [Table("Department", Schema ="HumanResources")]
    public class Department
    {
        [Key]
        public short DepartmentID { get; set; }
        [Required]
        public string Name { get; set; }
        public string GroupName { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
