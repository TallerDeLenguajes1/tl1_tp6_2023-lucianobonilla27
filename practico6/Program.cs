// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

Console.WriteLine("ingrese un numero:"); // Muestra un mensaje por pantalla
float a ;
bool control=float.TryParse(Console.ReadLine(),out a);
if (control)
{
    if (a > 0)  // si a > 0 lo invierto
    {
        a = 1/a;
    }
}
Console.WriteLine("El numero invertido es:"); // Muestra un mensaje por pantalla

Console.WriteLine(a);