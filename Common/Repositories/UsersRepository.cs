using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Common.Data;
using Common.Entities;

namespace Common.Repositories
{
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository(UnitOfWork uow) : base(uow)
        { }
        public UsersRepository() : base()
        { }
    }
}
