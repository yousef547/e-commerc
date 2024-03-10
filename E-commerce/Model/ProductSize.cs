namespace E_commerce.Model
{
    public class ProductSize
    {
        public int Id { get; set; }
        public TbProduct Product { get; set; }
        public int ProductId { get; set; }
        public TbSize Size { get; set; }
        public int SizeId { get; set; }
    }
}
