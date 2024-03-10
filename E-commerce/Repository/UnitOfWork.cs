using Domains.Data;
using E_commerce.Services;
using System;
using System.Threading.Tasks;
using System.Transactions;


namespace E_commerce.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        private ICategoriesService _category;


        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this._context = dbContext;
        }


      

        public ICategoriesService Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoriesService(_context);
                }

                return _category;
            }
        }

        public async Task CommitAsync()
        {
            await this._context.SaveChangesAsync();
        }
    }
}
 