using System.ComponentModel.DataAnnotations;

namespace E_commerce.Model
{
    public class TbProduct 
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public TbCatagery Category { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<ProductColor> Colors { get; set; }
        public virtual ICollection<ProductSize> Sizes { get; set; }

    }
}
