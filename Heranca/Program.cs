namespace Heranca
{
    class Veiculo // Classe Pai - calsse base
    {
        public string Marca = "Ford";
        public string RoncoDoMotor()
        {
            return "Ram ram";
}
       
        
    }
    //classe filha -  calsse derivada
    class Carro : Veiculo //carro externo (Herda) Veiculo
    {
        public string Modelo = "Mustang";
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            Console.WriteLine($"Marca: \n { meuCarro.Marca}");
            Console.WriteLine($"Modelo: {meuCarro.Modelo}");
            Console.WriteLine($"O Ronco do Motor é: {meuCarro.RoncoDoMotor()}");
        }
    }
}