using System;
//Pacote para manipulação de datas
using System.Globalization;

namespace CSharp_dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var diaDeHoje = DateTime.Now;  //03/12/2019 20:20:18
            //Dia de hoje
            var dia = diaDeHoje.Day; // 3
            //Dia da semana
            var diaDaSemana = diaDeHoje.DayOfWeek; //Tuesday
            //Enum para dia da semana
            var sabado = DayOfWeek.Saturday;
            //Segundos da hora atual
            var segundos = diaDeHoje.Second; //36
            //Tempo que passou em milisegundos desde 1970
            var ticks = diaDeHoje.Ticks; //637110015171367380

            //Operações com Data
            var umaHoraDepois = diaDeHoje.AddHours(1.0); //04/12/2019 00:26:24
            //Exemplo de nova data
            var aniversario = new DateTime(1991,03,20); // Nova instancia da data especificada
            //Diferença entre duas datas
            TimeSpan idade = DateTime.Now - aniversario; //

            //Exemplos de tempo/timespan
            var dias = idade.Days;
            var seconds = idade.Seconds;
            var totalDeSegundos = idade.TotalMinutes;

            //Comparar Datas
            var resultado = (aniversario < DateTime.Now); //True
            //Formatar datas
            var culture = CultureInfo.CreateSpecificCulture("jp-JP"); // Define um formato para as horas
            var ptBr = diaDeHoje.ToString(culture);
            var custom = string.Format("{0: dd MM yyyy hh:mm tt }", diaDeHoje); //Formatação customizada para a Data
            System.Console.WriteLine($"{ptBr}");

        }
    }
}
