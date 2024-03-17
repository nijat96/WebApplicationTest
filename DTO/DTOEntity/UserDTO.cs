using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class UserDTO
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? Salt { get; set; }
        public string? PasswordHash { get; set; }
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
    }
}
