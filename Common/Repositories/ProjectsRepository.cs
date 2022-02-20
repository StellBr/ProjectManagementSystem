using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;

namespace Common.Repositories
{
    public class ProjectsRepository : BaseRepository<Project>
    {
        public ProjectsRepository(UnitOfWork uow) : base(uow)
        { }

        public ProjectsRepository() : base()
        { }

    }
}
