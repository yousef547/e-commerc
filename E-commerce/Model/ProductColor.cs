namespace E_commerce.Model
{
    public class ProductColor
    {
        public int Id { get; set; }
        public TbProduct Product { get; set; }
        public int ProductId { get; set; }
        public TbColor Color { get; set; }
        public int ColorId { get; set; }
    }
}
