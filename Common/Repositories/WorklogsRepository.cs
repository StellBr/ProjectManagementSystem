using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
   public class WorklogsRepository : BaseRepository<Worklog>
    {
        public WorklogsRepository(UnitOfWork uow) : base(uow)
        { }

        public WorklogsRepository() : base()
        { }
    }
}
