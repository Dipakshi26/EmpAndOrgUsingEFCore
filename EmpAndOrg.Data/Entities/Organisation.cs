using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndOrg.Data.Entities
{
    public class Organisation
    { 
    
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            [Key]
            public int ID { get; set; }

            [Column(TypeName = "Varchar(50)")]
            public string? OrgName { get; set; }

            public Employee? Employee { get; set; }
        }
}
