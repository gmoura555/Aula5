namespace ClasseAbstract
{
    public abstract class Figura //class pai PArent - base
    {
        public string Exibir()
        {
            string nomeClasse = this.GetType().Name;
            double area = CalcularArea();
            return $"Classe: {nomeClasse}\n Área: {area}";
        }

        public abstract double CalcularArea();
    }

    public class Retangulo : Figura
    {
        public Retangulo() { }
        public Retangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public double Base { get; set; }
        public double Altura { get; set; }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
    public class Circulo : Figura
    {
        public Circulo() { }
        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }
        public double Raio { get; set; }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Figura fig1 = new Retangulo(2, 3);

            Figura fig2 = new Retangulo()
            {
                Base = 2,
                Altura = 3
            };
            Figura fig3 = new Circulo(5);
            Figura fig4 = new Circulo()
            {
                Raio = 5
            };

            //Alterando o valor do Raio
            Circulo circulo = (Circulo)fig4;
            circulo.Raio = 10;


            Console.WriteLine(new String('-', 30));
            Console.WriteLine(fig1.Exibir());
            Console.WriteLine(new String('-', 30));
            Console.WriteLine(fig2.Exibir());
            Console.WriteLine(new String('-', 30));
            Console.WriteLine(fig3.Exibir());
            Console.WriteLine(new String('-', 30));
            Console.WriteLine(fig4.Exibir());

        }

    }
}