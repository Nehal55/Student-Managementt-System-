using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Students
    {
        public int Id {  get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string AdmissionDate { get; set; }

        public int ClassNameId { get; set; }


        [ForeignKey("ClassNameId")]

        public StudentClass StudentClass { get; set; }


    }
}
