using AutoMapper;
using E_commerce.Repository;
using E_commerce.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Controllers
{
    [ApiController]

    public class CatageryController : ControllerBase
    {
        private readonly IUnitOfWork _IUnitOfWork;
        public readonly IMapper _mapper;

        public CatageryController(IUnitOfWork IUnitOfWork,IMapper mapper)
        {
            _IUnitOfWork = IUnitOfWork;
            _mapper = mapper;
        }

        [HttpGet("Get/Catogery")]
        public async Task<IActionResult> Get()
        {
            var data = _IUnitOfWork.Category.GetMany(x => x.IsActive)
                .Include(x => x.Products).ThenInclude(c=>c.Colors).ThenInclude(s=>s.Color)
                .Include(x => x.Products).ThenInclude(c=>c.Sizes).ThenInclude(s=>s.Size);
            var mapping  = _mapper.Map<List<CategoryViewModel>>(await data.ToListAsync()); 
            //.Include(x => x.Products).ThenInclude(c => c.Colors);
            return Ok(mapping);

        }
    }
}
