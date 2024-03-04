using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Core.Entities;
using Loja.Core.Repositories;
using Loja.Infrastructure.Data;

namespace Loja.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(LojaContext dbContext) : base(dbContext)
        {
        }
    }
}