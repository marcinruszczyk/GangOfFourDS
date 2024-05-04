
using Strategy;

var order = new Order("Marvin software", 5, "Visual Studio License");
order.ExportService = new CSVExportService();
order.Export();

order.ExportService = new JsonExportService();
order.Export();