using Objective_2;

Store store = new Store("Silpo");
Department fruitAndVegetables = new Department("Vegetables and fruits");
Department meatAndFish = new Department("Meat and fish");
store.AddDepartment(fruitAndVegetables);
store.AddDepartment(meatAndFish);

List<Product> productsFruitsAndVegetables = new List<Product>
    {
        new Product("Apples", new Dimensions(10, 10, 5), fruitAndVegetables),
        new Product("Oranges", new Dimensions(8, 8, 4), fruitAndVegetables),
        new Product("Bananas", new Dimensions(12, 10, 5), fruitAndVegetables),
        new Product("Carrots", new Dimensions(7, 12, 6), fruitAndVegetables),
        new Product("Tomatoes", new Dimensions(5, 5, 5), fruitAndVegetables),
        new Product("Cucumbers", new Dimensions(8, 11, 5), fruitAndVegetables),
        new Product("Potatoes", new Dimensions(10, 10, 10), fruitAndVegetables)
    };
fruitAndVegetables.AddProducts(productsFruitsAndVegetables);

List<Product> productsMeatAndFish = new List<Product>
    {
        new Product("Chicken fillet", new Dimensions(20, 15, 10), meatAndFish),
        new Product("Pork", new Dimensions(25, 20, 10), meatAndFish),
        new Product("Beef", new Dimensions(30, 18, 10), meatAndFish),
        new Product("Salmon", new Dimensions(30, 15, 8), meatAndFish),
        new Product("Mackerel", new Dimensions(25, 12, 6), meatAndFish),
        new Product("Shrimps", new Dimensions(10, 10, 8), meatAndFish),
        new Product("Mussels", new Dimensions(8, 8, 5), meatAndFish)
    };
meatAndFish.AddProducts(productsMeatAndFish);


foreach (var product in productsFruitsAndVegetables)
{
    Console.WriteLine(product.ToString());
}
foreach (var product in productsMeatAndFish)
{
    Console.WriteLine(product.ToString());
}
var boxes = store.PackProducts(fruitAndVegetables.Products, store);
Console.WriteLine();
foreach (var box in boxes)
{
    Console.WriteLine(box.ToString());
}
boxes = store.PackProducts(meatAndFish.Products, store);
foreach (var box in boxes)
{  
    Console.WriteLine(box.ToString());
}

