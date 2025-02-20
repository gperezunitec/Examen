
using Examen;

double n1,n2,n3;
bool notasValidas;


Asigantura asigantura=new Asigantura();
Alumno alumno=new Alumno();



do
{


    Console.WriteLine("Ingrese nombre del alumno: ");
    alumno.nombreAlumno = Console.ReadLine();

    Console.WriteLine("Ingrese numero de cuenta del alumno: ");
    alumno.numeroCuenta = Console.ReadLine();

    Console.WriteLine("Ingrese el email del alumno: ");
    alumno.email = Console.ReadLine();



    Console.WriteLine("Ingrese nombre de Asignatura: ");
    asigantura.nombreAsignatura = Console.ReadLine();

    Console.WriteLine("Ingrese el horario: ");
    asigantura.horario = Console.ReadLine();

    Console.WriteLine("Ingrese nombre del docente: ");
    asigantura.nombreDocente = Console.ReadLine();






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


Console.WriteLine($"Nombre del alumno:{alumno.nombreAlumno} ");
Console.WriteLine($"Cuenta del alumno:{alumno.numeroCuenta} ");
Console.WriteLine($"Emaildel alumno:{alumno.email} ");


Console.WriteLine($"Asignatura:{asigantura.nombreAsignatura} ");
Console.WriteLine($"Horario:{asigantura.horario} ");
Console.WriteLine($"Docente:{asigantura.nombreDocente} ");


asigantura.mensajeNotaFinal(asigantura.calcularNotaFinal());