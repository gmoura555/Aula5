namespace ClasseEstatica
{
 public class ClasseEstatica1
    {
        public void ExibeAlgo()
        {
            Console.WriteLine("Exibe um valor");
        }
    }
    internal class Program
    {
        ClasseEstatica1 teste = new ClasseEstatica1();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}