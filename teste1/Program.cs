namespace Lab.Models
{
    public class Cliente
    {
        private string _cpf;
        public string Cpf
        {
            get => _cpf;
            set => _cpf = (value.ValidarCPF() ? value :
            throw new Exception("CPF inválido"));
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Sexos Sexo { get; set; }
        public Endereco EnderecoResidencial { get; set; }
        public ContaCorrente Conta { get; set; }
        public Cliente(string Cpf, string Nome, Sexos Sexo)
        {
            this.Cpf = Cpf;
            this.Nome = Nome;
            this.Sexo = Sexo;
        }
        public Cliente(string Cpf, string Nome, Sexos Sexo, Endereco
       endereco)
        : this(Cpf, Nome, Sexo)
        {
            this.EnderecoResidencial = endereco;
        }
        public string Exibir()
        {
            return $"Cpf: {this.Cpf}\n" +
            $"Nome: {this.Nome}\n" +
            $"Idade: {this.Idade}\n" +
            $"Sexo: {this.Sexo}\n" +
            $"ENDEREÇO DO CLIENTE:\n" +
            $"{this.EnderecoResidencial.Exibir()}";
        }
    }
}
