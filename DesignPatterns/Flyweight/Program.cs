using FlyweightPattern;

ShapeFactory shapeFactory = new ShapeFactory();

IShape circle1 = shapeFactory.GetCircle(5);
circle1.Draw(1, 2);

IShape circle2 = shapeFactory.GetCircle(10);
circle2.Draw(3, 4);


IShape circle3 = shapeFactory.GetCircle(5);
circle3.Draw(5, 6);