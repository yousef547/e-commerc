using E_commerce.Model;

namespace E_commerce.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Image { get; set; }

        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public List<ColorProductViewModel> Colors { get; set; }
        public List<SizeProductViewModel> Sizes { get; set; }
    }

}
