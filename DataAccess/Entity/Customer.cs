using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ImageURL { get; set; }
        public string? Text { get; set; }
        public int Rate { get; set; }
    }
}
