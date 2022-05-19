using CsvHelper.Configuration.Attributes;

namespace lerArquivoCsv
{
    public class Dados
    {
        [Name("nome")]
        public string Nome { get; set; }

        [Name("idade")]
        public int Idade { get; set; }

        [Name("cidade")]
        public string Cidade { get; set; }
    }

    public class DadosJson
    {
        [Name("cidade")]
        public string Cidade { get; set; }

        [Name("idade")]
        public double Idade { get; set; }
    }
}
