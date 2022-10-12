// FRANCESCA SUBA
using System.Collections.Generic;

namespace GuitarShop.Models
{
    public class ProductListViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public string SelectedCategory { get; set; }
        public string CheckActiveCategory(string category) =>
            category == SelectedCategory ? "active" : "";

        public ProductListViewModel(List<Category> Categories, List<Product> Products, string SelectedCategory)
        {
            this.Categories = Categories;
            this.Products = Products;
            this.SelectedCategory = SelectedCategory;
        }

        

    }
}
