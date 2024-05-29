using DesafiosCSharp.Triangulo;
using DesafiosCSharp.Vertices;

Console.WriteLine("PROJETO TRIÂNGULO:");
Console.WriteLine("--------------------------");

var verticeA = new Vertice(0, 0);
var verticeB = new Vertice(2, 0);
var verticeC = new Vertice(1, 2);


var triangulo = new Triangulo(verticeA, verticeB, verticeC);

Console.WriteLine("Area: " + triangulo.Area);
Console.WriteLine("---------------------------");
Console.WriteLine("Perímetro: " + triangulo.Perimetro);
Console.WriteLine("---------------------------");
Console.WriteLine("Tipo do triângulo: " + triangulo.Tipo);