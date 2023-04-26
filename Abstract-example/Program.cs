// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Book fablehaven = new Book("Fablehaven","Brandon Mull");
fablehaven.display();

Book bom = new Book("Book of Mormon","Mormon");
bom.display();

Console.WriteLine(bom.IsAvailable());
bom.Checkout();
bom.display();
bom.Checkin();
bom.display();
Console.WriteLine(bom.IsAvailable());

Console.WriteLine(bom.hasAuthor("Mormon"));
Console.WriteLine(bom.hasAuthor("Smith"));