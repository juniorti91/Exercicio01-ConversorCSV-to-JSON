using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace lerArquivoCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new CsvConfiguration(CultureInfo.InstalledUICulture)
            {
                HasHeaderRecord = true,
            };

            using (var reader = new StreamReader("pessoas.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var new_Dados = csv.GetRecords<Dados>();

                var contador1 = 0;
                var contador2 = 0;
                var contador3 = 0;
                var acumulador1 = 0;
                var acumulador2 = 0;
                var acumulador3 = 0;
                var media1 = 0;
                var media2 = 0;
                var media3 = 0;

                foreach (var dados_Manipulado in new_Dados)
                {
                    if (dados_Manipulado.Cidade == "Atibaia")
                    {                                               
                        acumulador1 += dados_Manipulado.Idade;
                        contador1++;
                    }
                    else if (dados_Manipulado.Cidade == "Campinas")
                    {                                              
                        acumulador2 += dados_Manipulado.Idade;
                        contador2++;
                    }
                    else if(dados_Manipulado.Cidade == "Rio de Janeiro")
                    {                                                
                        acumulador3 += dados_Manipulado.Idade;
                        contador3++;
                    }
                }
                media1 = acumulador1 / contador1;
                media2 = acumulador2 / contador2;
                media3 = acumulador3 / contador3;

                var imprimir_json = new List<DadosJson>
                {
                    new DadosJson
                    {
                        Cidade = "Rio de Janeiro",
                        Idade = media3
                    },
                    new DadosJson
                    {
                        Cidade = "Atibaia",
                        Idade = media1
                    },
                    new DadosJson
                    {
                        Cidade = "Campinas",
                        Idade = media2
                    },
                };

                var dadosJson = JsonConvert.SerializeObject(imprimir_json);
                Console.WriteLine("médias: ");
                Console.WriteLine(dadosJson);   
            }
        }
    }
}
