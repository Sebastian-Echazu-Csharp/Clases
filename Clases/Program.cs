using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            // Empleado
            string[] nombres = new string[3];
            string[] apellidos = new string[3];
            bool[] afiliado = new bool[3];
            // Afiliado
            int[] nroAfiliado = new int[3];
            bool[] delegado = new bool[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("ingrese un nombre:");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("ingrese un apellido:");
                apellidos[i] = Console.ReadLine();
                Console.WriteLine("Es afiliado? ");
                string linea = Console.ReadLine();
                if (linea == "si")
                {
                    afiliado[i] = true;
                }
                else
                {
                    afiliado[i] = false;
                }
                Console.WriteLine("Nro de Afiliado: ");
                nroAfiliado[i] = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Es Delegado? ");
                string linea2 = Console.ReadLine();
                if (linea2 == "si")
                {
                    afiliado[i] = true;
                }
                else
                {
                    afiliado[i] = false;
                }

                if (apellidos[i] == "perez" || nombres[i] == "luis" || afiliado[i] == true)
                {
                    delegado[i] = true;
                }

            }

            for (int i = 0; i < 3; i++)
            {
                if (apellidos[i] == "perez" || nombres[i] == "luis")
                {
                    imprime(nombres[i], apellidos[i], nroAfiliado[i]);
                    break;
                }
            }

            static void imprime(string nombre, string apellido,int nroAfiliado)
            {
                Console.WriteLine("el nombre del delegado es:");
                Console.WriteLine(nombre);
                Console.WriteLine(apellido);
                Console.WriteLine(nroAfiliado);
            }
        }
    }


}
