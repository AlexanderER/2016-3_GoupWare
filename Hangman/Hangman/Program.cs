using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sPalabra = System.IO.File.ReadAllLines(@"D:\Palabra.txt");
            String sPalabraFinal = sPalabra[0];
            int iTamano = sPalabraFinal.Length;
            int iCantIntentos = 5;

            string sOculta = "";

            for (int x = 0; x < iTamano; x++)
            {
                sOculta = sOculta + "@";
            }

            Console.WriteLine("Palabra: " + sOculta);


            var theString = sOculta;
            var aStringBuilder = new StringBuilder(theString);

            for (int i = 0; i < iCantIntentos; i++)
            {

                //                       
                theString = aStringBuilder.ToString();
                //

                string spalabradescubierta = "";
                string sLetra;
                Console.WriteLine(Environment.NewLine + "Digite la letra deseada: " + Environment.NewLine);

                sLetra = Console.ReadLine();

                for (int j = 0; j < iTamano; j++)
                {
                    if (sPalabraFinal.Substring(j,1) == sLetra)
                    {
                        aStringBuilder.Remove(j, 1);
                        aStringBuilder.Insert(j, sLetra);
                        //spalabradescubierta = spalabradescubierta + sPalabraFinal.Substring(j, 1);
                        //Console.Write(sLetra);
                    }
                    else
                    {
                        spalabradescubierta = spalabradescubierta + "@";
                        //Console.Write("_");
                    }
                }

                Console.Write(Environment.NewLine + aStringBuilder);
            }


            if (aStringBuilder.ToString() == sPalabraFinal)
            {
                Console.Write(Environment.NewLine + "EXITO");
                Console.ReadLine();
            }
            else
            {
                Console.Write(Environment.NewLine + "FALLIDO");
                Console.ReadLine();
            }
        }
    }
}
