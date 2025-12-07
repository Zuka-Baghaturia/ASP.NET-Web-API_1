namespace WebApplication_Zuka.Models
{
    public class Product
    {
        private static int _counter = 1; 

        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }  


        public Product()
        {
            Id = _counter++;
        }
    }
}
