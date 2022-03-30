using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class CommentsRepository : BaseRepository<Comment>
    {
        public CommentsRepository(UnitOfWork uow) : base(uow)
        { }

        public CommentsRepository() : base()
        { }
    }
}
