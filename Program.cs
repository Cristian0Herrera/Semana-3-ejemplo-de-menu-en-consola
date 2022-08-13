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
            Console.WriteLine("*****Proyecto de un menu en consola*****");
            Console.WriteLine("");
            Console.WriteLine("Primer Programa de munu creando con estructuras");
            Console.WriteLine("Por favor, precione ENTER.");

            Console.ReadKey();

            int repetir;

            //menu_interno();

            do
            {
                Console.Clear();
                menu_interno();
                Console.WriteLine("");
                Console.WriteLine("Ingrese 1 para repetir nuevamente el menú");
                Console.WriteLine("Ingrese 2 para salir");
                repetir = Int32.Parse(Console.ReadLine());

            } while (repetir == 1);

        } //Cierre de función principal


        //Inicio de funciones interna
        static void menu_interno()
        {
            string seleccion;
            int seleccionInt;

            Console.WriteLine("***Menu Principal***");
            Console.WriteLine("1. Ejemplo If");
            Console.WriteLine("2. Ejemplo Switch");
            Console.WriteLine("3. Ejemplo For");
            Console.WriteLine("4. Ejemplo While");
            Console.WriteLine("5. Ejemplo Do While");

            Console.Write("Por favor, seleccione una opción: ");
            seleccion = Console.ReadLine();
            seleccionInt = Int32.Parse(seleccion);

          

        }

        static void programa_if()
        { Console.WriteLine("Aqui llamo el programa 1"); }
        static void programa_switch()
        { Console.WriteLine("Aqui llamo el programa 2"); }
        static void programa_for()
        { Console.WriteLine("Aqui llamo el programa 3"); }
        static void programa_while()
        { Console.WriteLine("Aqui llamo el programa 4");}
        static void programa_dowhile()
        { Console.WriteLine("Aqui llamo el programa 4");}
    }
}
