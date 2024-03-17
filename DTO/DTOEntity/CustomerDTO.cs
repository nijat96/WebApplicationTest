using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class CustomerDTO
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ImageURL { get; set; }
        public string? Text { get; set; }
        public int Rate { get; set; }
    }
}
