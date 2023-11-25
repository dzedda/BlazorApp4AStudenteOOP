using Newtonsoft.Json;
namespace BlazorApp4A.Models

{
    public class SupplierList
    {
        private static string dataSourceString = @"Data/Source/suppliers.json";
        public List<Supplier> Suppliers { get; set; }= new List<Supplier>();
        public virtual void Serializza()
        {
            File.WriteAllText(dataSourceString, JsonConvert.SerializeObject(this));
        }
        public static SupplierList Deserializza()
        {
            SupplierList? x;            
            x = JsonConvert.DeserializeObject<SupplierList>(File.ReadAllText(dataSourceString));            
            return x;
        }
    }
    public class Supplier
    {
        public string IdSupplier { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostaCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }


   


}
