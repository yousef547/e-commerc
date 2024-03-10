using E_commerce.Services;
using System.Threading.Tasks;

namespace E_commerce.Repository
{
    public interface IUnitOfWork
    {

        ICategoriesService Category { get; }

        Task CommitAsync();
    }
}
 