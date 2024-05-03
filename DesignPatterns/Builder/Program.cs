using Builder;

var garage = new Garage();

var miniBuilder = new MiniBuilder();
var bmwBuilder = new BMWBuilder();

garage.Constructor(miniBuilder);
Console.WriteLine(miniBuilder.Car.ToString());
garage.Show();


garage.Constructor(bmwBuilder);
Console.WriteLine(bmwBuilder.Car.ToString());
garage.Show();

Console.ReadKey();