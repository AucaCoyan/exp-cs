namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Write something and I will repeat: ");
            string inputUsuario = Console.ReadLine();
            Console.WriteLine("{0}", inputUsuario);
            // linea para el ejecutable exe
            // Console.Read();
        }

    }
}
