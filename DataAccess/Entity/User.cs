using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        public string? Username { get; set; }
        public string? Salt { get; set; }
        public string? PasswordHash { get; set; }

        [ForeignKey(nameof(RoleID))]
        public int RoleID { get; set; }
        public Role? Role { get; set; }
    }
}
