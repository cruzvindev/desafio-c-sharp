using DesafiosCSharp.Vertices;

Console.WriteLine("PROJETO VÉRTICE:");
Vertice a = new Vertice(10, 13);
Vertice b = new Vertice(20, 12);

Console.WriteLine("A DISTÂNCIA ENTRE O VERTICE A E O VERTICE B É:");
Console.WriteLine(Vertice.Distancia(a, b));

Vertice c = new Vertice(10, 10);
Vertice d = new Vertice(10, 10);

Console.WriteLine("----------------------------------");
Console.WriteLine("O VERTICE C É IGUAL AO VERTICE D ?");
Console.WriteLine(Vertice.VerificaVertices(c,d));