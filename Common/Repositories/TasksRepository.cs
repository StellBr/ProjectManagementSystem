using System;
using System.Collections.Generic;
using System.Linq;
using Common.Entities;

namespace Common.Repositories
{
    public class TasksRepository : BaseRepository<Task>
    {
        public TasksRepository(UnitOfWork uow) : base(uow)
        { }
        public TasksRepository() : base()
        { }
    }
}
