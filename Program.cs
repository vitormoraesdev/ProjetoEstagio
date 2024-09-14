using ProjetoEstagio;

TechnicalQuestions Questions = new TechnicalQuestions();

Distribuidora distribuidora = new Distribuidora();

#region Questão 1
Console.WriteLine("1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;\n" +
    "Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }\n" +
    "Imprimir(SOMA);\n" +
    "Ao final do processamento, qual será o valor da variável SOMA?\n" +
    "Informe os valores das variaveis acima:");
int indice = int.Parse(Console.ReadLine());
int soma = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
Questions.TestarCondição(indice, soma, k);
#endregion

#region Questão 2
Console.WriteLine(
    "2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e \n" +
    "o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),\n" +
    " escreva um programa na linguagem que desejar onde, informado um número,\n" +
    " ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número\n" +
    " informado pertence ou não a sequência.\n" +
    "Infome o numero:");
int validador = int.Parse(Console.ReadLine());
if (Questions.ValidarNumFibonacci(validador))
{
    Console.WriteLine($"O numero {validador} pertence a sequência de Fibonacci");
}
else
{
    Console.WriteLine($"O numero {validador} não pertence a sequência de Fibonacci");
}
#endregion

#region Question 3
Console.WriteLine($"3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora,\n" +
    $" faça um programa, na linguagem que desejar, que calcule e retorne:\n" +
    $"• O menor valor de faturamento ocorrido em um dia do mês;\n" +
    $"• O maior valor de faturamento ocorrido em um dia do mês;\n" +
    $"• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.\n\n" +
    $"IMPORTANTE:\n" +
    $"a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;\n" +
    $"b) Podem existir dias sem faturamento, como nos finais de semana e feriados.\n" +
    $" Estes dias devem ser ignorados no cálculo da média;");

string caminhoArquivo = "C:\\Users\\vitcath\\Desktop\\projEstagio\\ProjetoEstagio\\JSON\\DistribuidoraFaturamento.json";
List<Faturamento> faturamentos = distribuidora.CarregarFaturamentoMensal(caminhoArquivo);

distribuidora.CalcularEstatisticas(faturamentos);
#endregion

#region Question 4
Console.WriteLine($"4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:\n" +
    $"• SP – R$67.836,43\n" +
    $"• RJ – R$36.678,66\n" +
    $"• MG – R$29.229,88\n" +
    $"• ES – R$27.165,48\n" +
    $"• Outros – R$19.849,53\n\n" +
    $"Escreva um programa na linguagem que desejar onde\n" +
    $"calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  ");

double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;

double faturamentoTotal = sp + rj + mg + es + outros;

void ExibirPercentual(string estado, double valor)
{
    double percentual = (valor / faturamentoTotal) * 100;
    Console.WriteLine($"{estado}: {percentual:F2}% do total");
}

Console.WriteLine("Percentual de representação por estado:");
ExibirPercentual("SP", sp);
ExibirPercentual("RJ", rj);
ExibirPercentual("MG", mg);
ExibirPercentual("ES", es);
ExibirPercentual("Outros", outros);
#endregion

#region Question 5
Console.WriteLine($"5) Escreva um programa que inverta os caracteres de um string.\n\n" +
    $"IMPORTANTE:\n" +
    $"a) Essa string pode ser informada através de qualquer entrada de sua preferência \n" +
    $"ou pode ser previamente definida no código;\n" +
    $"b) Evite usar funções prontas, como, por exemplo, reverse;");

Console.WriteLine("Informe uma string para ser invertida:");
string input = Console.ReadLine();

string stringInvertida = Questions.InverterString(input);

Console.WriteLine($"String invertida: {stringInvertida}");
#endregion