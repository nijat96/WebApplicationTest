﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Menu>? Menu { get; set; }
    }
}
