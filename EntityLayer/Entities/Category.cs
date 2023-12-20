using E_Ticaret.EntityLayer.Entities;

namespace E_Ticaret.EntiyLayer.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public bool Status { get; set; }
        public List<Product>? Products { get; set; }
    }
}