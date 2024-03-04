using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Core.Entities;
using Loja.Core.Repositories;
using Loja.Infrastructure.Data;

namespace Loja.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(LojaContext dbContext) : base(dbContext)
        {
        }
    }
}