using Command2;
using System.Runtime.CompilerServices;

var modifyPrice = new ModifyPrice();

var product = new Product("Phone", 500);


Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 25));

Console.WriteLine(product);

 static void Execute(Product product, ModifyPrice modifyPrice, ICommand productCommand)
{
    modifyPrice.SetCommand(productCommand);
    modifyPrice.Invoke();
}