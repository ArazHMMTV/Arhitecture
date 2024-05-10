using Pronia.Core.Models;
using Pronia.Core.RepositoryAbstract;
using Pronia.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Data.RepositoryConcretes
{
    public class TagRepository:GenericRepository<Tag>,ITagsRepository
    {
        public TagRepository(AppDbContext appDbContext):base(appDbContext)
        {
              
        }
    }
}
