namespace LanguageFeatures.Models
{
    public class Product
    {
        /*"Assigning a value to a read-only property"
         
        The constructor allows the value for the read-only property to be specified as an argument and defaults to true if no value is provided. The property value cannot be changed once set by the constructor
         
         
         
         */
        public Product(bool stock = true)
        {
          InStock = stock;
        }


        /*Autoaticall Implemented Properties. This type of feature is known as syntactic sugar*/
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";//Auto-Implemented Properties Initilizer
        public decimal? Price { get; set; }
        public Product Related { get; set; }//"Chaining the Null Conditional Operator." -property that nests references, creating a more complex hierarchy
        public bool InStock { get; } = true;//Read-Only Property. Created by ommiting the 'set' keyword from an auto-implemented property. You cn add an optional initializer. This 'InStock' property is initialized to trus andconnot be changed; however, the value can be assigned to in the type's constructor as below.
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Wter Craft",
                Price = 275M
            };
            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }
    }
}