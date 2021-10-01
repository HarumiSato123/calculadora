using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calendario
{
    class Program
    {
        static int ano { get; set; }
        static int mes { get; set; }
        static int[,] calendario = new int[6, 7];
        private static DateTime date;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano: ");
            ano = Convert.ToInt32(Console.ReadLine());
            mes = 10;
            PreencherCalendrio();
            ImprimirCalendario();

            Console.ReadKey();

        }

        static void PreencherCalendrio()
        {
            int dataInicial = 1;
            int dias = DateTime.DaysInMonth(ano, mes);
            date = new DateTime(ano, mes, dataInicial);
            var hoje = (int)date.DayOfWeek;

            for (int i = 0; i < calendario.GetLength(0); i++)
            {
                for (int j = 0; j < calendario.GetLength(1) && dataInicial - hoje + 1 <= dias; j++)
                {
                    int valor = dataInicial - hoje + 1;
                    if (i == 0 && mes > j)
                    {
                        calendario[i, j] = 0;
                    }
                    else
                    {
                        calendario[i, j] = valor;
                        dataInicial++;
                    }
                }
            }

        }

        static void ImprimirCalendario()
        {

            for (int i = 0; i < calendario.GetLength(0); i++)
            {

                for (int j = 0; j < calendario.GetLength(1);  j++)
                {
                    if (calendario[i, j] > 0)
                    {
                        if (calendario[i, j] < 10)
                        {
                            Console.Write(" " + calendario[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calendario[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");
            }


        }
    }
}