using DesafiosCSharp.Poligono;
using DesafiosCSharp.Vertices;

var verticeA = new Vertice(0, 0);
var verticeB = new Vertice(4, 0);
var verticeC = new Vertice(4, 3);
var verticeD = new Vertice(0, 3);
var verticeE = new Vertice(0, 3);

var vertices = new List<Vertice> {verticeA, verticeB, verticeC, verticeD};

try
{
    Console.WriteLine("PROJETO POLÍGONO:");
    Poligono poligono = new Poligono(vertices);
    Console.WriteLine("Polígono criado com sucesso!");
    Console.WriteLine("Perímetro do polígono: " + poligono.Perimetro());
    Console.WriteLine("Quantidade de vértices: " + poligono.QuantidadeVertices);
    Console.WriteLine("Adicionando um novo vertice...");
    Console.WriteLine(poligono.AddVertice(verticeE));
    Console.WriteLine("O polígono possui agora: " + poligono.QuantidadeVertices + " vertices");
    Console.WriteLine("Removendo um vértice...");
    poligono.RemoveVertice();
    Console.WriteLine("Quantidade de vértices: " + poligono.QuantidadeVertices);
    Console.WriteLine("Removendo um vértice...");
    poligono.RemoveVertice();

}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
