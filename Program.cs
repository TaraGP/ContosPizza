// See https://aka.ms/new-console-template for more information

//code first .net approach

using ContosPizza.Models;

using ContosoPizzaContext context=new ContosoPizzaContext();
/*
 * Data insertion part
Product veggieSpecial = new Product()
{
    Name="Veggie Special Pizza",
    Price=9.99M
};

Product deluxeMeat = new Product()
{
    Name="Deluxe Meat Pizza",
    Price=12.99M
};
context.Products.Add(veggieSpecial);
context.Add(deluxeMeat);
context.SaveChanges();
*/


/*
 *reading an entity from the database

//fluent api syntax
var products = context.Products
                        .Where(p => p.Price > 10.00M)
                        .OrderBy(p => p.Name);


//LINQ syntax---any one can be used
//var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;


foreach(Product p in products)
{
    Console.WriteLine($"Name:{p.Name}");
    Console.WriteLine($"Id:{p.Id}");
    Console.WriteLine($"Price:{p.Price}");
    Console.WriteLine(new string('-', 20));
}
*/

/*
//updating an entity
var veggieSpecial=context.Products
    .Where(p=>p.Name == "Veggie Special Pizza")
    .FirstOrDefault();
if (veggieSpecial is Product)
{
    veggieSpecial.Price = 10.99M;
}
context.SaveChanges();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;


foreach (Product p in products)
{
    Console.WriteLine($"Name:{p.Name}");
    Console.WriteLine($"Id:{p.Id}");
    Console.WriteLine($"Price:{p.Price}");
    Console.WriteLine(new string('-', 20));
}
*/

//deleting an entity
var veggieSpecial = context.Products
    .Where(p => p.Name == "Veggie Special Pizza")
    .FirstOrDefault();
if (veggieSpecial is Product)
{
    context.Remove(veggieSpecial);
}
context.SaveChanges();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;


foreach (Product p in products)
{
    Console.WriteLine($"Name:{p.Name}");
    Console.WriteLine($"Id:{p.Id}");
    Console.WriteLine($"Price:{p.Price}");
    Console.WriteLine(new string('-', 20));
}