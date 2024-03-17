using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class MenuDTO
    {
        public int ID { get; set; }

        public string? ImageURL { get; set; }
        public string? Title { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Discount { get; set; }

        public string? Gram { get; set; }
        public string? Calorie { get; set; }
        public string? Status { get; set; }
        public DateTime? Date { get; set; }

        [ForeignKey(nameof(CategoryID))]
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
    }
}
