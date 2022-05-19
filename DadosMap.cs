using CsvHelper.Configuration;

namespace lerArquivoCsv
{
    public class DadosMap : ClassMap<Dados>
    {
        public DadosMap()
        {
            Map(m => m.Nome).Name("nome");
            Map(m => m.Idade).Name("idade");
            Map(m => m.Cidade).Name("cidade");
        }
    }
}
