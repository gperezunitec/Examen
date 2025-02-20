using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface IAsignatura
    {

        public double calcularNotaFinal();
        public double calcularNotaFinal(double n1, double n2, double n3);

        public void mensajeNotaFinal(double notaFinal);


        public void imprimir();



    }
}
