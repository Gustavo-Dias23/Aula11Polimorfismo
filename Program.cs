using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoPlayer = new Calculo();
            System.Console.WriteLine( infoPlayer.Calcular());

            System.Console.WriteLine( infoPlayer.Calcular(75) );

            System.Console.WriteLine( infoPlayer.Calcular(75, 45));

            System.Console.WriteLine( infoPlayer.Calcular("Ezio", "Auditore") );
        }
    }
}
