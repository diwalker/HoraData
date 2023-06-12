using System;
using System.Threading;

namespace HoraData
{
    public class MainClass
    {
        public static void Main()
        {
            string version = "1.0";
            Console.WriteLine("========================");
            Console.WriteLine("Hora & Data - Versão {0}", version);
            Console.WriteLine("========================");
            Console.WriteLine("Dica: Pressione CTRL + C para sair do programa!\n");

            while (true)
            {
                string diaDaSemana = GetDiaDaSemana();
                string mes = GetMes();

                Console.Write("\r{0} - {1} de {2} de {3} - {4}",
                    diaDaSemana, DateTime.Now.ToString("dd"),
                    mes, DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("HH:mm:ss"));

                Thread.Sleep(1000);
            }
        }

        private static string GetDiaDaSemana()
        {
            switch ((int)DateTime.Now.DayOfWeek)
            {
                case 0: return "Domingo";
                case 1: return "Segunda-Feira";
                case 2: return "Terça-Feira";
                case 3: return "Quarta-Feira";
                case 4: return "Quinta-Feira";
                case 5: return "Sexta-Feira";
                case 6: return "Sábado";
                default: return "N/D";
            }
        }

        private static string GetMes()
        {
            switch ((int)DateTime.Now.Month)
            {
                case 1: return "Janeiro";
                case 2: return "Fevereiro";
                case 3: return "Março";
                case 4: return "Abril";
                case 5: return "Maio";
                case 6: return "Junho";
                case 7: return "Julho";
                case 8: return "Agosto";
                case 9: return "Setembro";
                case 10: return "Outubro";
                case 11: return "Novembro";
                case 12: return "Dezembro";
                default: return "N/D";
            }
        }
    }
}
