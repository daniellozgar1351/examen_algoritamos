
using System;

namespace examen_algoritmos_DanielGLopezG
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            int[] b = new int[3];
            string mensaje = "";
       
            //Alice
            a = GetText("Alice");
            //Bob
            b = GetText("Bob");
            //Obtengo calificaciones
            mensaje = getScore(a,b);
            Console.WriteLine(mensaje);
            Console.ReadKey();

        }

        //Función para obtener calificaciones
        private static int[] GetText(string nombre)
        {
            bool salir = false;
            int[] c = new int[3];

         
            for (int i = 0; i < 3; i++)
            {
                salir = false;
                do
                {
                    
                    Console.WriteLine("Ingrese la calificación {0} de {1}", i + 1, nombre);
                   
                    c[i] = int.Parse(Console.ReadLine());
                   
                    if (c[i] <= 1 || c[i] >= 100)
                    {
                        Console.WriteLine("La calificación debe ser mayor o igual a 1  y menor o igual 100");
                    }
                    else
                    {
                        salir = true;
                    }
                } while (salir != true);

                Console.WriteLine(" ");
            }

            return c;

        }

        //Función para calcular puntos ganados
        private static string getScore(int[] alice, int[] bob) {

            String mensaje = "";
            int[] calificaciones = new int[2];

            //Valido calificaciones
            for (int x = 0; x < 3; x++)
            {
                if (alice[x] > bob[x])
                { //Alice
                    calificaciones[1] = calificaciones[1] + 1;
                }
                else if (alice[x] < bob[x])
                { //Bob
                    calificaciones[0] = calificaciones[0] + 1;
                }
            }
            
            mensaje = " Calificación de Bob " + calificaciones[0] + ", calificación de Alice " + calificaciones[1];

            return mensaje;


        }
    }
}
