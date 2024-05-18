using Bridge2;
using System.Net.Http.Headers;

IRender vectorRenderer = new VectorRender();
Shape circle = new Circle(5, vectorRenderer);
circle.Draw();


IRender rasterRenderer = new RasterRender();
circle = new Circle(10, rasterRenderer);
circle.Draw();
