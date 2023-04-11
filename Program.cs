using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Cadena
    {
        public string cadena { get; set; }

        static void Main(string[] args)
        {
            Cadena cadena = new Cadena();
            cadena.MenuPrincipal();
        }

        public void MenuPrincipal()
        {
            Console.WriteLine("Menu principal:");
            Console.WriteLine("1) Introducir una cadena de al menos 40 caracteres, a la que se le podran hacer cambios posteriormente");
            Console.WriteLine("2) Introducir un digito que pasara a ser una cadena rellena por doce ceros por delante");
            Console.WriteLine("Introduce una opcion para continuar, 0 para salir");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    IntroduceCadena();
                    break;

                case "2":
                    IntroduceDigito();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opcion no valida, prueba de nuevo");
                    MenuPrincipal();
                    break;
            }
        }

        public void IntroduceCadena()
        {
            Console.WriteLine("Introduce una cadena de al menos 40 caracteres: ");
            cadena = Console.ReadLine();
            if (cadena.Length < 40)
            {
                Console.WriteLine($"La cadena introducida posee solo {cadena.Length} caracteres");
                IntroduceCadena();
            }
            else
            {
                MenuCadena();
            }
        }

        public void IntroduceDigito()
        {
            Console.WriteLine("Introduce un digito: ");
            int digito = int.Parse(Console.ReadLine());
            string digitoCeros = digito.ToString().PadLeft(12, '0');
            Console.WriteLine($"El digito convertido a cadena con ceros es: {digitoCeros}");

            Console.WriteLine("Introduce 1 para volver al menu principal, 2 para repetir la operacion u otro caracter para salir: ");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                MenuPrincipal();
            }
            else if (opcion == "2")
            {
                IntroduceDigito();
            }
            else
            {
                return;
            }
        }

        public void MenuCadena()
        {
            Console.WriteLine("Has introducido una cadena de al menos 40 caracteres. ¿Que quieres hacer ahora?");
            Console.WriteLine("1) Sustituir una palabra por otra");
            Console.WriteLine("2) Buscar texto en la cadena");
            Console.WriteLine("3) Buscar texto de inicio en la cadena");
            Console.WriteLine("4) Salir");
            Console.WriteLine("Elige una opcion: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    SustituirPalabra();
                    break;
                case "2":
                    BuscarTexto();
                    break;
                case "3":
                    BuscarInicioTexto();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opcion no valida, prueba de nuevo");
                    MenuCadena();
                    break;
            }
        }

        public void SustituirPalabra()
        {
            try
            {
                Console.WriteLine("Introduce la palabra a sustituir y la sustituta separadas por un espacio: ");
                string[] palabra = Console.ReadLine().Split(' ');
                cadena = cadena.Replace(palabra[0], palabra[1]);
                Console.WriteLine($"La cadena resultante es: {cadena}");
            }
            catch
            {
                Console.WriteLine("El formato introducido no es correcto");
                SustituirPalabra();
            }


            Console.WriteLine("Introduce 1 para volver al menu principal, 2 para repetir la operacion u otro caracter para salir: ");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                MenuPrincipal();
            }
            else if (opcion == "2")
            {
                SustituirPalabra();
            }
            else
            {
                return;
            }
        }

        public void BuscarTexto()
        {
            Console.WriteLine("Introduce el texto a buscar: ");
            string texto = Console.ReadLine();
            if (cadena.Contains(texto))
            {
                Console.WriteLine($"El texto '{texto}' si se encuentra en la cadena");
            }
            else
            {
                Console.WriteLine($"El texto '{texto}' no se encuentra en la cadena");
            }

            Console.WriteLine("Introduce 1 para volver al menu principal, 2 para repetir la operacion u otro caracter para salir: ");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                MenuPrincipal();
            }
            else if (opcion == "2")
            {
                BuscarTexto();
            }
            else
            {
                return;
            }
        }

        public void BuscarInicioTexto()
        {
            Console.WriteLine("Introduce un texto para comprobar si la cadena empieza por el mismo: ");
            string texto = Console.ReadLine();
            if (cadena.StartsWith(texto))
            {
                Console.WriteLine($"La cadena si empieza por {texto}");
            }
            else
            {
                Console.WriteLine($"La cadena no empieza por {texto}");
            }

            Console.WriteLine("Introduce 1 para volver al menu principal, 2 para repetir la operacion u otro caracter para salir: ");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                MenuPrincipal();
            }
            else if (opcion == "2")
            {
                BuscarInicioTexto();
            }
            else
            {
                return;
            }
        }
    }
}
