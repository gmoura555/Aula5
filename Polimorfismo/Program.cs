namespace Polimorfismo
{
    class Animal // classe pai (parent)- classe base 
    { 
    public virtual void SomdoAnimal() 
        {
            Console.WriteLine("O animal faz o som: ");
        }
    }
    //classe filha - Derivada 
    class Porco : Animal 
    {
        public override void SomdoAnimal()
        {
            Console.WriteLine("O animal faz o som: Oinc Oinc ");
        }
    }

    // classe filha - Derivada

    class Cachorro : Animal 
    {
        public override void SomdoAnimal()
        {
            Console.WriteLine("O Cachorro  faz o som: au au ");
        }
    }
class Gato : Animal 
    {
        public override void SomdoAnimal()
        {
            Console.WriteLine("O Gato faz o som: miau miau ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.SomdoAnimal();

            Animal meuPorco = new Porco();
            Animal meuCachorro = new Cachorro();
            Animal meuGato = new Gato();

            meuPorco.SomdoAnimal();
            meuCachorro.SomdoAnimal();
            meuGato.SomdoAnimal();

        }
    }
}