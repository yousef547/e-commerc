using E_commerce.Model;

namespace E_commerce.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string NameEn { get; set; }
        public virtual ICollection<ProductViewModel> Products { get; set; }

    }
}
