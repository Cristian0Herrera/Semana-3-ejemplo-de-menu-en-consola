using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3_ejemplo_de_menu_en_consola
{
    class Program
    {
        static void Main(string[] args)

        {
            
            switch (opcionint)
            {
                case 1:
                    System.Console.WriteLine("Aqui llamo el programa1");
                    break;

                case 2:
                    System.Console.WriteLine("Aqui llamo el programa2");
                    break;

                case 3:
                    System.Console.WriteLine("Aqui llamo el programa3");
                    break;

                case 4:
                    System.Console.WriteLine("Opcion no disponible");
                    break;

            }
        }
        static void menu_interno()
        {
            System.Console.WriteLine("Programa Principal");
            System.Console.WriteLine("Primer Programa");

            System.Console.ReadKey();

            int repetir;

            menu();

            System.Console.WriteLine("Ingrese la opcion: ");
            repetir = Int32.Parse(Console.ReadLine());

            while (repetir == 1)
            {
                menu();

            }
        }

        static void programa_if()
        { }
        static void programa_switch()
        { }
        static void programa_for()
        { }
        static void programa_while()
        { }
        static void programa_dowhile()
        { }


    }
}
