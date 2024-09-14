using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio
{
    public class TechnicalQuestions
    {
        public TechnicalQuestions() 
        { 

        }
        #region Question 1
        //1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
        //Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
        //Imprimir(SOMA);
        //Ao final do processamento, qual será o valor da variável SOMA?

        public void TestarCondição(int indice, int soma, int k)
        {
            while (k < indice)
            {
                k++;
                soma = soma + k;
            }
            Console.WriteLine($"Ao final do processamento o valor da variavel soma será de: {soma}");
        }
        #endregion
        #region Question 2
        //2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor
        //sempre será a soma dos 2 valores anteriores(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
        //escreva um programa na linguagem que desejar onde,
        //informado um número, ele calcule a sequência de Fibonacci e retorne uma
        //mensagem avisando se o número informado pertence ou não a sequência.

        public bool ValidarNumFibonacci(int validador)
        {
            int num1 = 0;
            int num2 = 1;
            int soma = num1 + num2;

            if(validador == num1 || validador == num2)
            {
                return true;
            }
            while (validador >= soma)
            {
                if (validador == soma)
                {
                    return true;
                }
                num1 = num2;
                num2 = soma;
                soma = num1 + num2;
            }
            return false;
        }
        #endregion
        #region Question 5
        //5) Escreva um programa que inverta os caracteres de um string.

        //IMPORTANTE:
        //a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
        //b) Evite usar funções prontas, como, por exemplo, reverse;

        public string InverterString(string str)
        {
            char[] caracteres = str.ToCharArray();
            string resultado = "";

            for (int i = caracteres.Length - 1; i>= 0; i--)
            {
                resultado += caracteres[i];
            }
            return resultado;
        }
        #endregion
    }
}
