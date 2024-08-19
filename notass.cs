using System;


class Notas
{

    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de  Calculos de Notas");
        Console.WriteLine("Favor ingresa su Nota ");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor ingresa el Nombre De su Asignatura");
        string Asignatura = Console.ReadLine();
        Console.WriteLine("ingresa la primer nota parcial");
        int Nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingresa la segunda nota parcial");
        int Nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingresa la tercer nota parcial");
        int Nota3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingresa la cuarta nota parcial");
        int Nota4 = Convert.ToInt32(Console.ReadLine());
        int promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;



        if (promedio <= 70)
        {
            Console.WriteLine("Usted esta reprobado");
            Console.ReadKey();
        }
        if (promedio > 70 & promedio <= 80)
        {
            Console.WriteLine("Usted se encuentra en la categoria de bueno");
            Console.ReadKey();
        }
        if (promedio > 80 & promedio <= 90)
        {
            Console.WriteLine("Usted se encuentra en la categoria de muy bueno");
            Console.ReadKey();
        }
        if (promedio > 90 & promedio < 100)
        {
            Console.WriteLine("Usted es sobresaliente");
            Console.ReadKey();
        }
    }
}





