
using Examen;

double n1,n2,n3;
bool notasValidas;


Asigantura asigantura=new Asigantura();




do
{

    Console.WriteLine("Escriba la Nota 1: ");
    asigantura.N1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escriba la Nota 2: ");
    asigantura.N2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escriba la Nota 3: ");
    asigantura.N3 = Convert.ToInt32(Console.ReadLine());

    n1 = asigantura.N1;
    n2 = asigantura.N2;
    n3 = asigantura.N3;

    notasValidas = (n1 >= 0 && n1 <= 30) && (n2 >= 0 && n2 <= 30) &&(n3 >= 0 && n3 <= 40);

    if (!notasValidas)
    {
        Console.WriteLine("Errr , las notas 1 y 2debe ser menor que 30 y la nota 3 debe ser menor que 40");
    }





} while (!notasValidas);





asigantura.mensajeNotaFinal(asigantura.calcularNotaFinal());