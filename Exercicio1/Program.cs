using System;

namespace Exercicio1
{
  
 public abstract class Conta
    {
        public int NumeroBanco { get; set; }
        public string NumeroAgencia { get; set; }
        public string NumeroConta { get; set; }
        public Conta(int Banco, string Agencia, string Conta)
        {
            this.NumeroBanco = Banco;
            this.NumeroAgencia = Agencia;
            this.NumeroConta = Conta;
        }
        public abstract string MostrarExtrato();
    }
}

internal class Program
    {
        static void Main(string[] args)
        {
           












            ////funcionario novoFuncionario = new funcionario();
            ////Console.WriteLine("CADASTRO DE NOVOS FUNCIONÁRIOS");
            //Console.WriteLine(new string('-', 30));
            //Console.Write($"Nome: {funcionario.Nome}"); Console.ReadLine();
            ////Console.Write($"Idade: {funcionario.Idade}"); Console.ReadLine();
            ////Console.Write($"RG: {funcionario.RG}");Console.ReadLine();
            ////Console.WriteLine();
            ////Console.WriteLine(new string('-', 30));
            ////Console.ReadKey();
        }
    }
}