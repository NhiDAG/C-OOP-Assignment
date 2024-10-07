namespace Object_Oriented_Programming
{
    class Program
    {
        public class Product
        {
            private string name { get; set; }
            private double price { get; set; }
            private double discount { get; set; }

            public Product(string name, double price, double discount)
            {
                this.name = name;
                this.price = price;
                this.discount = discount;
            }

            public Product(string name, double price)
            {
                this.name = name;
                this.price = price;
                this.discount = 0.0;
            }

            private double getImportTax()
            {
                return price * 0.1;
            }

            public void display()
            {
                Console.WriteLine("ProductName: " + name);
                Console.WriteLine("Price: " + price);
                Console.WriteLine("Discount: " + discount);
                Console.WriteLine("Import Tax: " + getImportTax());
                Console.WriteLine("Total price: " + ((1 - (discount / 100)) * (price + getImportTax())));
                Console.WriteLine();
            }

            public void input()
            {
                Console.Write("Enter product name: ");
                name = Console.ReadLine();
                Console.Write("Enter product price: ");
                price = double.Parse(Console.ReadLine());
                Console.Write("Enter product discount (enter 0 for no discount): ");
                discount = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }

        }

        public class Test
        {
            static void Main(string[] args)
            {
            Product pd1 = new Product("Product", 0.0);
            Console.WriteLine("Enter details for Product 1:");
            pd1.input();
            Console.WriteLine("Product 1 Details:");
            pd1.display();

            Console.WriteLine();
            Product pd2 = new Product("Product", 0.0);
            Console.WriteLine("Enter details for Product 2:");
            pd2.input();
            
            Console.WriteLine("Product 2 Details:");
            pd2.display();
                Console.ReadLine();
            }

        }
    }
}
