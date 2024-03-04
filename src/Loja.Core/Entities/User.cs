using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Loja.Core.Enums;

namespace Loja.Core.Entities
{
    public class User : BaseEntity<Guid>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public StatusEnum Status { get; set; }
        public ProfileEnum  Profile { get; set; }
    }
}