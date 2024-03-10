using Domains.Data;
using E_commerce.Model;
using E_commerce.Repository;
using System;

namespace E_commerce.Services
{
    public interface ICategoriesService : IBaseRepository<TbCatagery>
    {
        
    }
    public class CategoriesService : BaseRepository<TbCatagery>, ICategoriesService
    {
        public CategoriesService(ApplicationDbContext context)
         : base(context)
        {

        }

    }
}
