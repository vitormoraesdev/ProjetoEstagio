using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio
{
    public class Distribuidora
    {
        public List<Faturamento> CarregarFaturamentoMensal(string caminhoArquivo)
        {
            if (File.Exists(caminhoArquivo))
            {
                string jsonData = File.ReadAllText(caminhoArquivo);
                return JsonConvert.DeserializeObject<List<Faturamento>>(jsonData);
            }
            else
            {
                Console.WriteLine("Arquivo de faturamento não encontrado.");
                return new List<Faturamento>();
            }
        }

        public void CalcularEstatisticas(List<Faturamento> faturamentos)
        {
            var diasComFaturamento = faturamentos.Where(f => f.FaturamentoDiario > 0).ToList();

            if (diasComFaturamento.Count == 0)
            {
                Console.WriteLine("Não há dias com faturamento registrado.");
                return;
            }

            double menorFaturamento = diasComFaturamento.Min(f => f.FaturamentoDiario);

            double maiorFaturamento = diasComFaturamento.Max(f => f.FaturamentoDiario);

            double mediaMensal = diasComFaturamento.Average(f => f.FaturamentoDiario);

            int diasAcimaDaMedia = diasComFaturamento.Count(f => f.FaturamentoDiario > mediaMensal);

            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:C}");
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:C}");
            Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
        }
    }
}
