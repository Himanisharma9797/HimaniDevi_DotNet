using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningSystem.DataLayer.Models
{
    public class FacultyModel
    {
        [Key]
        public int FacultyId { get; set; }
        public string FacultyFirstName { get; set; }
        public string FacultyLastName { get; set; }
        public string FacultyEmail { get; set; }
    }
}

