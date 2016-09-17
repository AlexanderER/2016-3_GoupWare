using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {


        static String GenerateHelloWorld(String p_sUserName)
        {
            String sResult;
            sResult = "Hello World " + p_sUserName;

            return sResult;
        }



        static void Main(string[] args)
        {

            String sUserName;
            Console.WriteLine("Escriba el nombre de usuario: ");
            sUserName = Console.ReadLine();
            Console.WriteLine(GenerateHelloWorld(sUserName));
            Console.ReadLine();

        }
    }
}
