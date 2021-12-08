using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciionario_assariado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMFORME A SUA FORMA DE CONTRATAÇÃO: " +
                "\n1:ASSALARIADO" +
                "\n2:COMISSIONARIO" +
                "\n3:HORISTA");
            double contrato = double.Parse(Console.ReadLine());

            switch (contrato)

            {
                case 1:

                    Console.WriteLine("IMFORME O SEU SALÁRIO: ");
                    double salario = double.Parse(Console.ReadLine());

                    Console.WriteLine("IMFORME A % DO SEU IMPOSTO: ");
                    double imposto = double.Parse(Console.ReadLine());

                    salario -= (salario * (imposto / 100));

                    Console.WriteLine("O SEU SALÁRIO FIXO SERA DE " + salario.ToString("C"));

                    break;

                case 2:
                    Console.WriteLine("IMFORME O VALOR TOTAL DA SUA VENDA: ");
                    double venda = double.Parse(Console.ReadLine());

                    Console.WriteLine("IMFORME A % DA SUA COMISSÃO ");
                    double comissao = double.Parse(Console.ReadLine());

                    venda += (venda * (comissao / 100));

                    Console.WriteLine("O SEU SALÁRIO LIQUIDO SERA DE " + venda.ToString("C"));
                    break;

                case 3:
                    Console.WriteLine("IMFORME O VALOR DA SUA HORA ");
                    double hora = double.Parse(Console.ReadLine());

                    Console.WriteLine("IMFORME A QUANTIDADE DE HORAS TRABALHADAS ");
                    double vlr_hora = double.Parse(Console.ReadLine());

                    vlr_hora = vlr_hora * hora;

                    Console.WriteLine("O SEU SALÁRIO LIQUIDO SERA De: " + vlr_hora.ToString("C"));
                    break;

                default:
                    Console.WriteLine("INSIRA UM NUMERO DE 1 Á 3 COMO FOI PEDIDO ACIMA !" +
                        "\nvalor inválido");
                    break;
                    
            }



            Console.ReadKey();
        }
    }
}
