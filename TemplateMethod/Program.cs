using TemplateMethod;

ExchangeMailParser exchangeMailParser = new();
Console.WriteLine(exchangeMailParser.ParseMailBody("ddgg-5677-dfgg-45656"));
Console.WriteLine();

ApacheMailParser apacheMailParser = new();
Console.WriteLine(apacheMailParser.ParseMailBody("ddgg-5677-bbbjbj-dfgg-45656"));
Console.WriteLine();



EudoraMailParser eudoraMailParser = new();
Console.WriteLine(exchangeMailParser.ParseMailBody("ddgg-5677-dfgg-45656-787779"));
Console.WriteLine();