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
    public class ProductRepository : GenericRepository<Product>,IProductsRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext) { }
        
    }
}
