// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);
int menu,a,b;
do
{
Console.WriteLine("ingrese la operacion que desea realizar"); 
Console.WriteLine("1_Sumar:"); 
Console.WriteLine("2_Restar:"); 
Console.WriteLine("3_Multiplicar:"); 
Console.WriteLine("4_Dividir:"); 
Console.WriteLine("5_Salir:"); 
bool control=int.TryParse(Console.ReadLine(),out menu);  
switch (menu)
{
    case 1:

    break;
     case 2:

    break;
     case 3:

    break;
     case 4:

    break;
    default:
    Console.WriteLine("Ingrese un numero valido"); 
    break;
}
} while (menu != 5);





