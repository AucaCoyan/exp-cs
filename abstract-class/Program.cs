//- lo mismo para las abstracts: para que sirve una `abstract class` 
// si puedo hacer una `interface` que me aplique a todas mis clases?

// ejemplo herencia
abstract class Mascota
{
    public string name { get; set; }

    public void Caminar()
    {
        Console.WriteLine($"el {name} está caminando");
    }
}

class Gato: Mascota
{
    public Gato(string n)
    {
        this.name = n;
    }
    public void Maullar()
    {
        Console.WriteLine($"el {name} esta maullando");
    } 
}

// ejemplo de interfaz
public interface IAnimal
{
    public string Name { get; set; }
    public void Caminar() { }
}

class Perro : IAnimal
{
    public string Name { get; set; }

    public void Caminar() { Console.WriteLine($"El {Name} esta caminando"); }

}

class Program
{
    static void Main()
    {
        Console.WriteLine("hola mundo!");
        Gato sally = new Gato("Sallinger");
        sally.Maullar();
        sally.Caminar();

        Perro martin = new Perro() { Name = "Martín" };
        martin.Caminar();
    }
}
