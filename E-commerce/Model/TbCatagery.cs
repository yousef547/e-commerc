
using System.ComponentModel.DataAnnotations;

namespace E_commerce.Model
{
    public class TbCatagery 
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string NameEn { get; set; }
        public virtual ICollection<TbProduct> Products { get; set; }

    }
}
