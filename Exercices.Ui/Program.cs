﻿

using Ejercicios;
using Exercices.Logic;
using System.ComponentModel;


// Console Exe33

Console.WriteLine("*** A ***");
var ex33 = new Exe33(3, 4, 2);
ex33.FillA();
Console.WriteLine(ex33);
ex33.FillB();
Console.WriteLine("*** A ***");
Console.WriteLine(ex33.PrintB());
ex33.FillC();
Console.WriteLine("*** C ***");
Console.WriteLine(ex33.PrintC());


// Console Exe34

var myMatrix = new Exe34();
myMatrix.Fill();

Console.WriteLine("MATRIZ COMPLETA");
Console.WriteLine(myMatrix);

Console.WriteLine(" RELOJ DE ARENA");
Console.WriteLine(myMatrix.Wacth());

// Console Exe35

Console.Write("Introduce un número: ");
var num = Exe35.Factors(Convert.ToInt32(Console.ReadLine()));

foreach (var item in num)
{
    Console.Write($"{item} x ");
}






