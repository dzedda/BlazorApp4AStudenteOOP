using BlazorApp4A.Pages;
using Newtonsoft.Json;

namespace BlazorApp4A.Models
{
    

    public class ProductList
    {
        private static string dataSourceString = @"Data/Source/products.json";

        public List<Product>  Products { get; set; }
        public virtual void Serializza()
        {
            File.WriteAllText(dataSourceString, JsonConvert.SerializeObject(this));
        }
        public static ProductList Deserializza()
        {
            ProductList? x;
            x = JsonConvert.DeserializeObject<ProductList>(File.ReadAllText(dataSourceString));
            return x;
        }
    }

    public class Product
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string supplierId { get; set; }
        public string CategoryId { get; set; }
        public string Unit { get; set; }
        public string Price { get; set; }
    }


}
