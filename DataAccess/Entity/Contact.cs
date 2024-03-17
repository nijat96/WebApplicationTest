using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string? Map { get; set; }
    }
}
