using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Asigantura : Alumno, IAsignatura
    {

        public int N1, N2, N3;
        public string nombreAsignatura, horario, nombreDocente;

        public double calcularNotaFinal()
        {
            return N1 + N2 +N3;
        }

        public double calcularNotaFinal(double n1, double n2, double n3)
        {
            n1 = N1;
            n2 = N2;
            n3 = N3;

            return n1 + n2 + n3;

        }

        public void imprimir()
        {
            Console.WriteLine($"Nota 1: {N1}");
            Console.WriteLine($"Nota 2: {N2}");
            Console.WriteLine($"Nota 3: {N3}");
            Console.WriteLine($"Nota Final: {calcularNotaFinal()}");
        }


        public void imprimir(double n1,double n2,double n3)
        {

            n1 = N1;
            n2 = N2;
            n3 = N3;

            Console.WriteLine($"Nota 1: {N1}");
            Console.WriteLine($"Nota 2: {N2}");
            Console.WriteLine($"Nota 3: {N3}");
            Console.WriteLine($"Nota Final: {calcularNotaFinal()}");
        }


  



        public void mensajeNotaFinal(double notaFinal)
        {

           


            switch (notaFinal)
            {
                case >+90:


                    imprimir();
                    imprimir(N1,N2,N3);

                     Console.Write("Sobresaliente ");

                    break;

                case >=80:

                    imprimir();
                    imprimir(N1, N2, N3);

                    Console.Write("Muy Bueno");
                    break;

                case >= 60:

                    imprimir();
                    imprimir(N1, N2, N3);

                    Console.Write("Bueno");

                    break;

                case >= 0:

                    imprimir();
                    imprimir(N1, N2, N3);

                    Console.Write("Reprobado");

                    break;



                default:

                    break;
            }

        }

        
    }
}
