namespace ACME.Models
{
    public class ProducsService
    {
        List<Product> listOfProduct = new List<Product>();
        static ProducsService service;

        static int ID = 1;
        private ProducsService()
        {
            listOfProduct.Add(new Product { Id = ID++, Make = "Ford", Model = "F150", Price = 25000 });
            listOfProduct.Add(new Product { Id = ID++, Make = "Chevy", Model = "Silverado", Price = 30000 });
            listOfProduct.Add(new Product { Id = ID++, Make = "Toyota", Model = "Tacoma", Price = 20000 });
            listOfProduct.Add(new Product { Id = ID++, Make = "Honda", Model = "Ridgeline", Price = 22000 });
            listOfProduct.Add(new Product { Id = ID++, Make = "Nissan", Model = "Frontier", Price = 18000 });
        }
        public Product[] GetAll()
        {
            return listOfProduct
                .OrderBy(p => p.Price)
                .ThenBy(p => p.Model)
                .ToArray();
        }
        public static ProducsService getInstance()
        {
            if(service == null)
            {
                service = new ProducsService();
            }
            return service;
        }
    }
}
