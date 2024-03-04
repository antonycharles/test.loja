using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Core.Enums;

namespace Loja.Core.Entities
{
    public class Product : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public StatusEnum Status { get; set; }
    }
}