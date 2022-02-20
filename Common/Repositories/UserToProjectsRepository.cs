using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
   public class UserToProjectsRepository : BaseRepository<UserToProject>
    {
        public UserToProjectsRepository(UnitOfWork uow) : base(uow)
        { }
        public UserToProjectsRepository() : base()
        { }
    }
}
